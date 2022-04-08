using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsMvp;
using WinFormsMvp.Forms;

namespace NeedleController.Views.CameraSettingUCs
{
    [PresenterBinding(typeof(Presenters.CameraSettingPresenters.CameraImgParaPresenter))]
    public partial class CameraImgParaSetting : MvpUserControl, ICameraImgParaSetting
    {
        public CameraImgParaSetting()
        {
            InitializeComponent();
            InitializeTimer();
        }

        public event EventHandler CameraImgParaSetting_Loaded;
        public event EventHandler BrightnessTrackbar_Scrolled;
        public event EventHandler ContrastTrackbar_Scrolled;
        public event EventHandler RedRaBtn_Checked;
        public event EventHandler GreenRaBtn_Checked;
        public event EventHandler BlueRaBtn_Checked;
        public event EventHandler NormalRaBtn_Checked;
        public event EventHandler ImgPositionCmb_Selected;

        private void CameraImgParaSetting_Load(object sender, EventArgs e)
        {
            try
            {
                CameraImgParaSetting_Loaded(this, EventArgs.Empty);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.ToString());
            }
        }

        private void BrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            BrightnessTrackbar_Scrolled(this, EventArgs.Empty);
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            ContrastTrackbar_Scrolled(this, EventArgs.Empty);
        }

        private void RedRaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRaBtn.Checked)
                RedRaBtn_Checked(this, EventArgs.Empty);
        }

        private void GreenRaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenRaBtn.Checked)
                GreenRaBtn_Checked(this, EventArgs.Empty);
        }

        private void BlueRaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueRaBtn.Checked)
                BlueRaBtn_Checked(this, EventArgs.Empty);
        }

        private void NormalRaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalRaBtn.Checked)
                NormalRaBtn_Checked(this, EventArgs.Empty);
        }

        private void ImgPositionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImgPositionCmb_Selected(this, EventArgs.Empty);
        }

        public void Load_CameraImgParaSetting()
        {
            if (CameraSettingView.camera_connection_failed)
            {
                BrightnessTrackbar.Enabled = false;
                ContrastTrackBar.Enabled = false;
                DisplayMode.Enabled = false;
                ImgPositionCmb.Enabled = false;
            }
            BrightnessTrackbar.Value = Properties.Settings.Default.brightness;
            BrightnessValue.Text = BrightnessTrackbar.Value.ToString();
            ContrastTrackBar.Value = (int)(Properties.Settings.Default.contrast * 10);
            ContrastValue.Text = ((float)(ContrastTrackBar.Value) / 10).ToString();
            switch (Properties.Settings.Default.displayImgMode)
            {
                case 'R':
                    RedRaBtn.Checked = true;
                    break;
                case 'G':
                    GreenRaBtn.Checked = true;
                    break;
                case 'B':
                    BlueRaBtn.Checked = true;
                    break;
                case 'N':
                    NormalRaBtn.Checked = true;
                    break;
            }
            switch (Properties.Settings.Default.imgPosition)
            {
                case "Center":
                    ImgPositionCmb.SelectedIndex = 0;
                    break;
                case "Fill":
                    ImgPositionCmb.SelectedIndex = 1;
                    break;
                case "Fit":
                    ImgPositionCmb.SelectedIndex = 2;
                    break;
                case "Stretch":
                    ImgPositionCmb.SelectedIndex = 3;
                    break;
            }
        }

        public void LoadImgPara()
        {
            
        }

        public void GetBrightness()
        {
            if (!Properties.Settings.Default.Properties["brightness"].DefaultValue.Equals(BrightnessTrackbar.Value.ToString()))
                CameraSettingView.default_flag = true;
            else
                CameraSettingView.default_flag = false;

            CameraSettingView.change_flag = true;
            Properties.Settings.Default.brightness = BrightnessTrackbar.Value;
            BrightnessValue.Text = BrightnessTrackbar.Value.ToString();
        }

        public void GetContrast()
        {
            if (!Properties.Settings.Default.Properties["contrast"].DefaultValue.Equals(((float)(ContrastTrackBar.Value) / 10).ToString()))
                CameraSettingView.default_flag = true;
            else
                CameraSettingView.default_flag = false;

            CameraSettingView.change_flag = true;
            Properties.Settings.Default.contrast = (float)(ContrastTrackBar.Value) / 10;
            ContrastValue.Text = ((float)(ContrastTrackBar.Value)/10).ToString();
        }

        public void GetDisplayMode()
        {
            if (CameraSettingView.load_flag)
            {
                if (RedRaBtn.Checked)
                {
                    Properties.Settings.Default.displayImgMode = 'R';
                    CameraSettingView.default_flag = true;
                }
                else if (GreenRaBtn.Checked)
                {
                    Properties.Settings.Default.displayImgMode = 'G';
                    CameraSettingView.default_flag = true;
                }
                else if (BlueRaBtn.Checked)
                {
                    Properties.Settings.Default.displayImgMode = 'B';
                    CameraSettingView.default_flag = true;
                }
                else if (NormalRaBtn.Checked)
                {
                    Properties.Settings.Default.displayImgMode = 'N';
                    CameraSettingView.default_flag = false;
                }
                CameraSettingView.change_flag = true;
            }
        }

        public void GetImgPosition()
        {
            if (CameraSettingView.load_flag)
            {
                if (!Properties.Settings.Default.imgPosition.Equals(ImgPositionCmb.SelectedItem.ToString()))
                    CameraSettingView.change_flag = true;

                if (!Properties.Settings.Default.Properties["imgPosition"].DefaultValue.Equals(ImgPositionCmb.SelectedItem))
                    CameraSettingView.default_flag = true;
                else
                    CameraSettingView.default_flag = false;

                Properties.Settings.Default.imgPosition = ImgPositionCmb.SelectedItem.ToString();
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval = 300;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Properties["brightness"].DefaultValue.Equals(BrightnessTrackbar.Value.ToString())
                && Properties.Settings.Default.Properties["contrast"].DefaultValue.Equals(((float)(ContrastTrackBar.Value) / 10).ToString())
                && Properties.Settings.Default.Properties["imgPosition"].DefaultValue.Equals(ImgPositionCmb.SelectedItem)
                && Properties.Settings.Default.displayImgMode == 'N')
            {
                CameraSettingView.default_img = true;
            }
            else
            {
                CameraSettingView.default_img = false;
            }
            Load_CameraImgParaSetting();
        }

        
    }
}
