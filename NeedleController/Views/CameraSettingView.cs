using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using WinFormsMvp.Forms;
using OpenCvDotNet;
using System.Configuration;

namespace NeedleController.Views
{
    public partial class CameraSettingView : MvpForm, ICameraSettingView
    {
        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();
        private double width;
        private double height;

        public static bool reset_camera { get; set; } = false;
        public static bool thread_flag { get; set; } = false;
        public static bool change_flag { get; set; } = false;
        public static bool default_flag { get; set; } = false;
        public static bool load_flag { get; set; } = false;
        public static bool default_img { get; set; } = false;
        public static bool default_opencv { get; set; } = false;
        public static bool on_off_detect { get; set; } = true;
        public Thread threadOpenCV;

        public CameraSettingView()
        {
            InitializeComponent();
            InitializeTimer();
        }

        public event EventHandler CameraSettingViewLoaded;
        public event EventHandler CameraSettingViewClosed;
        public event EventHandler DefaultParaButton_Clicked;
        public event EventHandler SaveParaButton_Clicked;

        private void CameraSettingView_Load(object sender, EventArgs e)
        {
            CameraSettingViewLoaded(this, EventArgs.Empty);            
        }

        private void CameraSettingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            CameraSettingViewClosed(this, EventArgs.Empty); 
        }

        private void DefaultParaButton_Click(object sender, EventArgs e)
        {
            DefaultParaButton_Clicked(this, EventArgs.Empty);
        }

        private void SaveParaButton_Click(object sender, EventArgs e)
        {
            SaveParaButton_Clicked(this, EventArgs.Empty);
        }

        public void CameraSettingViewLoad()
        {
            thread_flag = false;
            change_flag = false;
            default_flag = false;
            on_off_detect = true;
            cameraParaSetting1.LoadOpencvPara();
            cameraImgParaSetting1.LoadImgPara();
            load_flag = true;
        }

        public void CameraSettingViewClose()
        {
            opencv.stopCamera();
            Properties.Settings.Default.Reload();
            load_flag = false;
        }

        public void DefaultPara()
        {
            default_flag = false;
            Properties.Settings.Default.Reset();
            reset_camera = true;
            cameraParaSetting1.LoadOpencvPara();
            cameraImgParaSetting1.LoadImgPara();
        }

        public void SavePara()
        {
            change_flag = false;
            Properties.Settings.Default.Save();
        }

        private void InitializeCamera()
        {
            opencv.startCamera(Properties.Settings.Default.IDCamera);
            threadOpenCV = new Thread(() => Display(opencv));
            threadOpenCV.IsBackground = true;
            threadOpenCV.Start();
            thread_flag = true;
        }

        private void Display(MyOpenCvWrapper opencv)
        {
            try
            {
                if (!opencv.checkCamera())
                    MessageBox.Show("Can't open Camera");

                while (opencv.checkCamera())
                {
                    SetImgPosition();
                    opencv.getNeedleLength(Properties.Settings.Default.gaussianBlurKsize, Properties.Settings.Default.cannyThreshold1, Properties.Settings.Default.cannyThreshold2, 
                        width, height);
                    
                    opencv.getColor(Properties.Settings.Default.colorLowR, Properties.Settings.Default.colorLowG, Properties.Settings.Default.colorLowB,
                        Properties.Settings.Default.colorHighR, Properties.Settings.Default.colorHighG, Properties.Settings.Default.colorHighB);

                    opencv.Display_Mode((sbyte)Properties.Settings.Default.displayImgMode, Properties.Settings.Default.brightness, Properties.Settings.Default.contrast, on_off_detect);

                    Bitmap dst = opencv.displayDst();
                    Bitmap canny = opencv.displayCanny();
                    Invoke(new Action(() =>
                    {
                        OutputVideo.Image = dst;
                        CannyVideo.Image = canny;
                    }));
                }
            }
            catch
            {
                threadOpenCV.Abort();
            }
        }

        private void SetImgPosition()
        {
            switch(Properties.Settings.Default.imgPosition)
            {
                case "Center":
                    width = 100;
                    height = 100;
                    break;
                case "Fill":
                    width = Math.Round((double)(OutputVideo.Width * 100 / 640));
                    height = Math.Round((double)(OutputVideo.Width * 100 / 640));
                    break;
                case "Fit":
                    width = Math.Round((double)(OutputVideo.Height * 100 / 480));
                    height = Math.Round((double)(OutputVideo.Height * 100 / 480));
                    break;
                case "Stretch":
                    width = Math.Round((double)(OutputVideo.Width * 100 / 640));
                    height = Math.Round((double)(OutputVideo.Height * 100 / 480));
                    break;
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!thread_flag)
            {
                InitializeCamera();
            }
            else
            {
                if (reset_camera)
                {
                    opencv.stopCamera();
                    threadOpenCV.Abort();
                    thread_flag = false;
                    reset_camera = false;
                }
            }

            if (change_flag)
                SaveParaButton.Enabled = true;
            else 
                SaveParaButton.Enabled = false;
            
            if (default_flag)
                DefaultParaButton.Enabled = true;
            else
            {
                if (default_img || default_opencv)
                {
                    DefaultParaButton.Enabled = false;
                }
            }
            
        }
        
    }
}
