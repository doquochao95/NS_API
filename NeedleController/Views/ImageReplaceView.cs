using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

using System.Threading;
using System.Net;
using System.Net.Sockets;

using WinFormsMvp;
using WinFormsMvp.Forms;
using System.Net.NetworkInformation;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;
using NeedleController.Views.NeedlePickingUCs;
using System.Collections.ObjectModel;
using OpenCvDotNet;
using System.IO;

namespace NeedleController.Views
{
    public partial class ImageReplaceView : MvpForm, IImageReplaceView
    {
        private MainView _mainView;
        private int _recyleID;
        private NS_RecycledBox _recyleBox;
        public Image _capturedImage
        {
            get { return CaptureImagePictureBox.Image; }
            set { CaptureImagePictureBox.Image = value; }
        }
        public double captured_needle_length { get; set; }
        public double selected_captured_needle_length { get; set; }


        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();
        private static Thread threadOpenCV;

        private double width;
        private double height;
        private double selected_needle_length;

        private static bool camera_connected = false;
        private static bool retry_connect_camera = false;
        private static bool exit_flag = false;
        public ImageReplaceView(MainView mainView, int recID)
        {
            InitializeComponent();
            InitializeCamera();
            InitializeTimer();
            _mainView = mainView;
            _recyleID = recID;
            _recyleBox = EF_CONFIG.DataTransform.RecycledBoxBase.Get_RecylcleBox(_recyleID);
            selected_needle_length = Convert.ToDouble(EF_CONFIG.DataTransform.NeedleBase.Get_Needles(_recyleBox.NeedleID).NeedleLength);
            SelectedNeedleLengthLabel.Text = selected_needle_length.ToString();
            _mainView.Reply_Buffer("<led2:1>");
            _mainView.Reply_Buffer("<box:0>");

        }
        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!camera_connected && !exit_flag)
            {
                timer1.Stop();
                if (threadOpenCV.IsBackground)
                {
                    threadOpenCV.Abort();
                }
                switch (MessageBox.Show(this, "Can't open Camera", "Error: commmunication", MessageBoxButtons.RetryCancel))
                {
                    case DialogResult.Retry:
                        retry_connect_camera = true;
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
            else
            {
                CheckCamera_Connection();
                if (!camera_connected)
                {
                    return;
                }
                if (!threadOpenCV.IsBackground)
                {
                    threadOpenCV.IsBackground = true;
                    threadOpenCV.Start();
                }
            }
            if (retry_connect_camera)
            {
                InitializeCamera();
                retry_connect_camera = false;
                timer1.Start();
            }
        }
        private void InitializeCamera()
        {
            try
            {
                string camera_id = Properties.Settings.Default.IDCamera;
                string camera_mode = Properties.Settings.Default.modeCamera;
                if (camera_mode == "Local Camera" && camera_id.Length == 1)
                {
                    opencv.startCamera(int.Parse(camera_id));
                    threadOpenCV = new Thread(() => Display(opencv));
                    CheckCamera_Connection();
                }
                else if (camera_mode == "IP Camera" && camera_id.Length > 1)
                {
                    bool status = PingHost(camera_id);
                    if (status)
                    {
                        opencv.startCamera("http://" + camera_id + ":4747/video");
                        threadOpenCV = new Thread(() => Display(opencv));
                        CheckCamera_Connection();
                    }
                    else
                    {
                        threadOpenCV = new Thread(() => Display(opencv));
                        camera_connected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CheckCamera_Connection()
        {
            if (!opencv.checkCamera())
            {
                camera_connected = false;
            }
            else
            {
                camera_connected = true;
            }
        }
        private void Display(MyOpenCvWrapper opencv)
        {
            while (true)
            {
                SetImgPosition();
                bool status = opencv.getNeedleLength(Properties.Settings.Default.gaussianBlurKsize, Properties.Settings.Default.cannyThreshold1, Properties.Settings.Default.cannyThreshold2,
                    width, height);

                if (status)
                {
                    opencv.getColor(Properties.Settings.Default.colorLowR, Properties.Settings.Default.colorLowG, Properties.Settings.Default.colorLowB,
                    Properties.Settings.Default.colorHighR, Properties.Settings.Default.colorHighG, Properties.Settings.Default.colorHighB);

                    /* opencv.User_Display_Mode((sbyte)Properties.Settings.Default.displayImgMode, Properties.Settings.Default.brightness,
                         Properties.Settings.Default.contrast, this.userBrightness, this.userContrast);*/
                    opencv.Display_Mode((sbyte)Properties.Settings.Default.displayImgMode, Properties.Settings.Default.brightness, Properties.Settings.Default.contrast, true);
                    /*Bitmap src = opencv.displaySrc(width, height);*/
                    Bitmap dst = opencv.displayDst(width, height);
                    double length = opencv.needleLength();
                    Invoke(new Action(() =>
                    {
                        DestVideo.Image = dst;
                        captured_needle_length = length;
                        /*cameraViewerUC1.destVideo = dst;*/
                    }));
                }
                else
                {
                    opencv.stopCamera();
                }
            }
        }
        private void SetImgPosition()
        {
            switch (Properties.Settings.Default.imgPosition)
            {
                case "Center":
                    width = 100;
                    height = 100;
                    break;
                case "Fill":
                    width = Math.Round((double)(DestVideo.Width * 100 / 512));
                    height = Math.Round((double)(DestVideo.Width * 100 / 512));
                    break;
                case "Fit":
                    width = Math.Round((double)(DestVideo.Height * 100 / 384));
                    height = Math.Round((double)(DestVideo.Height * 100 / 384));
                    break;
                case "Stretch":
                    width = Math.Round((double)(DestVideo.Width * 100 / 512));
                    height = Math.Round((double)(DestVideo.Height * 100 / 384));
                    break;
            }
        }
        private static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            else
                return null;
        }
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            _capturedImage = DestVideo.Image;
            selected_captured_needle_length = captured_needle_length;
            CapturedNeedleLenghtLabel.Text = selected_captured_needle_length.ToString();
            if (selected_captured_needle_length > 10 && selected_captured_needle_length < 60)
            {
                _mainView.Reply_Buffer("<cyl1:1>");
                CaptureButton.Enabled = false;
                ConfirmButton.Enabled = true;
            }
            else
            {
                ConfirmButton.Enabled = false;
            }
            if (selected_needle_length - selected_needle_length * 0.05 <= selected_captured_needle_length &&
                        selected_captured_needle_length <= selected_needle_length + selected_needle_length * 0.1) //+10%
            {
                StatusLabel.Text = "Enough";
            }
            else
            {
                StatusLabel.Text = "Not Enough";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (selected_captured_needle_length > 10 && selected_captured_needle_length < 60)
            {
                _mainView.Reply_Buffer("<cyl1:0>");
            }
            ConfirmButton.Enabled = false;
            CaptureButton.Enabled = true;
            this.Close();
            timer1.Enabled = false;
        }

        private void ImageReplaceView_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            exit_flag = true;
            if (camera_connected)
            {
                if (threadOpenCV.IsBackground)
                {
                    threadOpenCV.Abort();
                }
            }
            _mainView.Reply_Buffer("<led2:0>");
            _mainView.Reply_Buffer("<box:1>");
            RecycleBinView._saved_flag = true;
            opencv.stopCamera();
            camera_connected = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            decimal len = Convert.ToDecimal(selected_captured_needle_length);
            byte[] data = imageToByteArray(_capturedImage);
            if (selected_needle_length - selected_needle_length * 0.05 <= selected_captured_needle_length &&
                        selected_captured_needle_length <= selected_needle_length + selected_needle_length * 0.1) //+10%
            {
                while (true)
                {
                    bool status = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBinCapturedImage(_recyleID, data, len, 1);
                    if (status)
                    {
                        break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    bool status = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBinCapturedImage(_recyleID, data, len, 0);
                    if (status)
                    {
                        break;
                    }
                }
            }
            _mainView.Reply_Buffer("<cyl2:1>");
            Thread.Sleep(1000);
            _mainView.Reply_Buffer("<cyl1:0><cyl2:0>");
            Thread.Sleep(500);
            this.Close();
            timer1.Enabled = false;
        }
    }
}
