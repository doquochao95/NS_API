using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

using EF_CONFIG;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Presenters;
using NeedleController.Presenters.NeedlePickingPresenters;


namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(CameraViewerPresenter))]
    public partial class CameraViewerUC : MvpUserControl, ICameraViewerUC
    {
        public Image sourceVideo
        {
            get { return this.SourceVideo.Image; }
            set { this.SourceVideo.Image = value; }
        }
        /* public Image destVideo
         {
             get { return this.DestVideo.Image; }
             set { this.DestVideo.Image = value; }
         }*/

        public int imgWidth
        {
            get { return this.SourceVideo.Width; }
            set { this.SourceVideo.Width = value; }
        }

        public int imgHeight
        {
            get { return this.SourceVideo.Height; }
            set { this.SourceVideo.Height = value; }
        }

        public int userBrightness { get; set; } = 0;
        public float userContrast { get; set; } = 1;

        public CameraViewerUC()
        {
            InitializeComponent();
            LoadViewer();
        }

        public event EventHandler UserBrightnessTrackbar_Scrolled;
        public event EventHandler UserContrastTrackbar_Scrolled;

        private void UserBrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            UserBrightnessTrackbar_Scrolled(this, EventArgs.Empty);
        }

        private void UserContrastTrackbar_Scroll(object sender, EventArgs e)
        {
            UserContrastTrackbar_Scrolled(this, EventArgs.Empty);
        }

        public void LoadViewer()
        {
            UserBrightnessTrackbar.Value = userBrightness;
            UserBrightnessValue.Text = UserBrightnessTrackbar.Value.ToString();
            UserContrastTrackbar.Value = (int)(userContrast * 10);
            UserContrastValue.Text = ((float)(UserContrastTrackbar.Value) / 10).ToString();
        }

        public void GetUserBrightness()
        {
            userBrightness = UserBrightnessTrackbar.Value;
            UserBrightnessValue.Text = UserBrightnessTrackbar.Value.ToString();
        }

        public void GetUserContrast()
        {
            userContrast = (float)UserContrastTrackbar.Value / 10;
            UserContrastValue.Text = ((float)UserContrastTrackbar.Value / 10).ToString();
        }

        private void User_Brightness_Click(object sender, EventArgs e)
        {

        }

        private void User_Contrast_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
