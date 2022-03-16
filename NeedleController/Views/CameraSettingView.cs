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
using System.Drawing.Imaging;

namespace NeedleController.Views
{
    public partial class CameraSettingView : MvpForm, ICameraSettingView
    {
        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();
        private int temp;

        public CameraSettingView()
        {
            InitializeComponent();            
        }

        public event EventHandler CameraSettingViewLoaded;

        private void CameraSettingView_Load(object sender, EventArgs e)
        {
            CameraSettingViewLoaded(this, EventArgs.Empty);
        }

        public void CameraSettingViewLoad()
        {            
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            opencv.startCamera();            
            Thread t = new Thread(()=>Display(opencv));
            t.IsBackground = true;
            t.Start();
        }

        private void Display(MyOpenCvWrapper opencv)
        {
            try
            {
                if (!opencv.checkCamera())
                    MessageBox.Show("Can't open Camera");

                while (opencv.checkCamera())
                {
                    opencv.getNeedleLength(cameraParaSetting1.GaussianBlurKsize, cameraParaSetting1.CannyThreshold1, cameraParaSetting1.CannyThreshold2,
                        Math.Round((double)(OutputVideo.Height*(4/3) * 100) / 480), Math.Round((double)(OutputVideo.Height * 100) / 480));

                    opencv.getColor(cameraParaSetting1.ColorLowR, cameraParaSetting1.ColorLowG, cameraParaSetting1.ColorLowB,
                        cameraParaSetting1.ColorHighR, cameraParaSetting1.ColorHighG, cameraParaSetting1.ColorHighB);

                    Bitmap src = opencv.displaySrc();
                    Bitmap dst = opencv.displayCanny();
                    Invoke(new Action(() =>
                    {
                        OutputVideo.Image = src;
                        CannyVideo.Image = dst;
                    }));
                }
            }
            catch
            {
                //Thread.CurrentThread.Abort();
            }
        }

        private void CameraSettingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            opencv.stopCamera();
        }

    }
}
