using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsMvp.Forms;
using WinFormsMvp;
using OpenCvDotNet;

namespace NeedleController.Views.CameraSettingUCs
{
    [PresenterBinding(typeof(Presenters.CameraSettingPresenters.CameraParaPresenter))]
    public partial class CameraParaSetting : MvpUserControl, ICameraParaSetting
    {
        private static CameraSettingView _cameraSettingView;
        public CameraParaSetting(CameraSettingView cameraSettingView)
        {
            InitializeComponent();
            InitializeTimer();
            _cameraSettingView = cameraSettingView;
            /*_cameraSettingView = cameraSettingView;*/
            //for (int i = 0; i < 3/*MainView.countCamera*/; i++)
            //{
            //    IDcameraCmb.Items.Add(i.ToString());
            //}
        }

        public event EventHandler CameraParaSettingLoaded;
        public event EventHandler IDcameraCmb_Selected;
        public event EventHandler AddressStringTextBox_KeyPressed;
        public event EventHandler GaussianKSizeCmb_Selected;
        public event EventHandler CannyThreshold_1_Scrolled;
        public event EventHandler CannyThreshold_2_Scrolled;
        public event EventHandler LowR_KeyPressed;
        public event EventHandler LowG_KeyPressed;
        public event EventHandler LowB_KeyPressed;
        public event EventHandler HighR_KeyPressed;
        public event EventHandler HighG_KeyPressed;
        public event EventHandler HighB_KeyPressed;
        public event EventHandler OnOffDetect_Checked;

        private void CameraParaSetting_Load(object sender, EventArgs e)
        {
            try
            {
                CameraParaSettingLoaded(this, EventArgs.Empty);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.ToString());
            }
        }
        private void IDcameraCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDcameraCmb_Selected(this, EventArgs.Empty);
        }

        private void AddressStringTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                AddressStringTextBox_KeyPressed(this, EventArgs.Empty);
        }

        private void GaussianKSizeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GaussianKSizeCmb_Selected(this, EventArgs.Empty);
        }

        private void CannyThreshold1Trackbar_Scroll(object sender, EventArgs e)
        {
            CannyThreshold_1_Scrolled(this, EventArgs.Empty);
        }

        private void CannyThreshold2Trackbar_Scroll(object sender, EventArgs e)
        {
            CannyThreshold_2_Scrolled(this, EventArgs.Empty);
        }

        private void LowR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                LowR_KeyPressed(this, EventArgs.Empty);
        }

        private void LowG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                LowG_KeyPressed(this, EventArgs.Empty);
        }

        private void LowB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                LowB_KeyPressed(this, EventArgs.Empty);
        }

        private void HighR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                HighR_KeyPressed(this, EventArgs.Empty);
        }

        private void HighG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                HighG_KeyPressed(this, EventArgs.Empty);
        }

        private void HighB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                HighB_KeyPressed(this, EventArgs.Empty);
        }

        private void OnOffDetect_CheckedChanged(object sender, EventArgs e)
        {
            OnOffDetect_Checked(this, EventArgs.Empty);
        }
        //------------------.-----------------//
        public void Load_CameraParaSetting()
        {
            switch (Properties.Settings.Default.gaussianBlurKsize)
            {
                case 3:
                    GaussianKSizeCmb.SelectedIndex = 0;
                    break;
                case 5:
                    GaussianKSizeCmb.SelectedIndex = 1;
                    break;
                case 7:
                    GaussianKSizeCmb.SelectedIndex = 2;
                    break;
                case 9:
                    GaussianKSizeCmb.SelectedIndex = 3;
                    break;
            }
            CannyThreshold1Trackbar.Value = Properties.Settings.Default.cannyThreshold1;
            CannyThreshold1Value.Text = CannyThreshold1Trackbar.Value.ToString();
            CannyThreshold2Trackbar.Value = Properties.Settings.Default.cannyThreshold2;
            CannyThreshold2Value.Text = CannyThreshold2Trackbar.Value.ToString();
            LowR.Text = Properties.Settings.Default.colorLowR.ToString();
            LowG.Text = Properties.Settings.Default.colorLowG.ToString();
            LowB.Text = Properties.Settings.Default.colorLowB.ToString();
            HighR.Text = Properties.Settings.Default.colorHighR.ToString();
            HighG.Text = Properties.Settings.Default.colorHighG.ToString();
            HighB.Text = Properties.Settings.Default.colorHighB.ToString();
            ColorNeedle.Invalidate();
            if (!CameraSettingView.camera_connection_failed)
            {
                AddressStringTextBox.Enabled = false;
                GaussianKSizeCmb.Enabled = false;
                CannyThreshold1Trackbar.Enabled = false;
                CannyThreshold2Trackbar.Enabled = false;
                Color.Enabled = false;
            }
            IDcameraCmb.Items.Clear();
            IDcameraCmb.Items.AddRange(CameraSettingView.camera_id_list);
            IDcameraCmb.SelectedItem = Properties.Settings.Default.modeCamera;
            AddressStringTextBox.Text = Properties.Settings.Default.IDCamera;
            
            if (IDcameraCmb.SelectedText == "Local Camera")
            {
                label1.Enabled = false;
                label2.Enabled = false;
            }
            else
            {
                label1.Enabled = true;
                label2.Enabled = true;
            }
        }
        public void LoadOpencvPara()
        {

        }

        public void GetIDCamera()
        {
            if (CameraSettingView.modeCamera == IDcameraCmb.SelectedItem.ToString())
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            CameraSettingView.change_flag = true;
            AddressStringTextBox.Enabled = true;
            if (IDcameraCmb.Text == "Local Camera")
            {
                label1.Enabled = false;
                label2.Enabled = false;
            }
            else
            {
                label1.Enabled = true;
                label2.Enabled = true;
            }
            Properties.Settings.Default.modeCamera = IDcameraCmb.SelectedItem.ToString();

            //if (CameraSettingView.load_flag)
            //{
            //    if (!Properties.Settings.Default.IDCamera.Equals(int.Parse(IDcameraCmb.SelectedItem.ToString())))
            //    {
            //        CameraSettingView.change_flag = true;
            //        Properties.Settings.Default.IDCamera = int.Parse(IDcameraCmb.SelectedItem.ToString());
            //        CameraSettingView.reset_camera = true;
            //    }
            //}
        }

        public void EnterCameraAddress()
        {
            string mode_camera = Properties.Settings.Default.modeCamera;
            string text_string = AddressStringTextBox.Text;
            int id_camera_input_legnth = text_string.Length;
            if (mode_camera == "Local Camera")
            {
                if (id_camera_input_legnth == 1)
                {
                    CameraSettingView.reset_camera = true;
                    Properties.Settings.Default.IDCamera = AddressStringTextBox.Text;
                    _cameraSettingView.Reset_timer();
                    Thread.Sleep(500);
                    CameraSettingView.change_flag = true;
                    CameraSettingView.camera_connected = true;
                    CameraSettingView.camera_connection_failed = false;
                    CameraSettingView.initial_flag = false;
                    CameraSettingView.camera_parasetting_flag = true;
                }
                else
                {
                    MessageBox.Show(this, "Invalid camera id", "Error: Data", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (id_camera_input_legnth == 1)
                {
                    MessageBox.Show(this, "Invalid camera id", "Error: Data", MessageBoxButtons.OK);
                }
                else
                {
                    CameraSettingView.reset_camera = true;
                    Properties.Settings.Default.IDCamera = AddressStringTextBox.Text;
                    _cameraSettingView.Reset_timer();
                    Thread.Sleep(500);
                    CameraSettingView.change_flag = true;
                    CameraSettingView.camera_connected = true;
                    CameraSettingView.camera_connection_failed = false;
                    CameraSettingView.initial_flag = false;
                    CameraSettingView.camera_parasetting_flag = true;
                }
            }

        }

        public void GetGaussianBlurKsize()
        {
            if (CameraSettingView.gaussianBlurKsize == int.Parse(GaussianKSizeCmb.SelectedItem.ToString()))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.gaussianBlurKsize.Equals(int.Parse(GaussianKSizeCmb.SelectedItem.ToString())))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.gaussianBlurKsize = int.Parse(GaussianKSizeCmb.SelectedItem.ToString());
        }

        public void GetCannyThreshold1()
        {
            if (CameraSettingView.cannyThreshold1 == CannyThreshold1Trackbar.Value)
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            CameraSettingView.change_flag = true;
            Properties.Settings.Default.cannyThreshold1 = CannyThreshold1Trackbar.Value;
            CannyThreshold1Value.Text = CannyThreshold1Trackbar.Value.ToString();
        }

        public void GetCannyThreshold2()
        {
            if (CameraSettingView.cannyThreshold2 == CannyThreshold2Trackbar.Value)
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            CameraSettingView.change_flag = true;
            Properties.Settings.Default.cannyThreshold2 = CannyThreshold2Trackbar.Value;
            CannyThreshold2Value.Text = CannyThreshold2Trackbar.Value.ToString();
        }

        public void EnterLowR()
        {
            if (CameraSettingView.colorLowR == int.Parse(LowR.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorLowR.Equals(int.Parse(LowR.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorLowR = int.Parse(LowR.Text);
            if (Properties.Settings.Default.colorLowR >= 0 && Properties.Settings.Default.colorLowR <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowR.Text = "0";
            }
        }

        public void EnterLowG()
        {
            if (CameraSettingView.colorLowG == int.Parse(LowG.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorLowG.Equals(int.Parse(LowG.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorLowG = int.Parse(LowG.Text);
            if (Properties.Settings.Default.colorLowG >= 0 && Properties.Settings.Default.colorLowG <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowG.Text = "0";
            }
        }

        public void EnterLowB()
        {
            if (CameraSettingView.colorLowB == int.Parse(LowB.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorLowB.Equals(int.Parse(LowB.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorLowB = int.Parse(LowB.Text);
            if (Properties.Settings.Default.colorLowB >= 0 && Properties.Settings.Default.colorLowB <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowB.Text = "0";
            }
        }

        public void EnterHighR()
        {
            if (CameraSettingView.colorHighR == int.Parse(HighR.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorHighR.Equals(int.Parse(HighR.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorHighR = int.Parse(HighR.Text);
            if (Properties.Settings.Default.colorHighR >= 0 && Properties.Settings.Default.colorHighR <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighR.Text = "0";
            }
        }

        public void EnterHighG()
        {
            if (CameraSettingView.colorHighG == int.Parse(HighG.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorHighG.Equals(int.Parse(HighG.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorHighG = int.Parse(HighG.Text);
            if (Properties.Settings.Default.colorHighG >= 0 && Properties.Settings.Default.colorHighG <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighG.Text = "0";
            }
        }

        public void EnterHighB()
        {
            if (CameraSettingView.colorHighB == int.Parse(HighB.Text))
                CameraSettingView.default_flag = false;
            else
                CameraSettingView.default_flag = true;

            if (!Properties.Settings.Default.colorHighB.Equals(int.Parse(HighB.Text)))
                CameraSettingView.change_flag = true;

            Properties.Settings.Default.colorHighB = int.Parse(HighB.Text);
            if (Properties.Settings.Default.colorHighB >= 0 && Properties.Settings.Default.colorHighB <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighB.Text = "0";
            }
        }

        public void Detect_OnOff()
        {
            if (OnOffDetect.Checked)
            {
                CameraSettingView.on_off_detect = true;
                OnOffDetect.Text = "On Detect";
            }
            else
            {
                CameraSettingView.on_off_detect = false;
                OnOffDetect.Text = "Off Detect";
            }
        }

        private void ColorNeedle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush bBackground = new LinearGradientBrush(rBackground,
                System.Drawing.Color.FromArgb(Properties.Settings.Default.colorLowR, Properties.Settings.Default.colorLowG, Properties.Settings.Default.colorLowB),
                System.Drawing.Color.FromArgb(Properties.Settings.Default.colorHighR, Properties.Settings.Default.colorHighG, Properties.Settings.Default.colorHighB), 0f);
            g.FillRectangle(bBackground, rBackground);
        }

        private void InitializeTimer()
        {
            timer1.Interval = 300;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.modeCamera.Equals(CameraSettingView.modeCamera)
                && !Properties.Settings.Default.IDCamera.Equals(CameraSettingView.IDCamera)
                && !Properties.Settings.Default.gaussianBlurKsize.Equals(CameraSettingView.gaussianBlurKsize)
                && !Properties.Settings.Default.cannyThreshold1.Equals(CameraSettingView.cannyThreshold1)
                && !Properties.Settings.Default.cannyThreshold2.Equals(CameraSettingView.cannyThreshold2)
                && !Properties.Settings.Default.colorLowR.Equals(CameraSettingView.colorLowR)
                && !Properties.Settings.Default.colorLowG.Equals(CameraSettingView.colorLowG)
                && !Properties.Settings.Default.colorLowB.Equals(CameraSettingView.colorLowB)
                && !Properties.Settings.Default.colorHighR.Equals(CameraSettingView.colorHighR)
                && !Properties.Settings.Default.colorHighG.Equals(CameraSettingView.colorHighG)
                && !Properties.Settings.Default.colorHighB.Equals(CameraSettingView.colorHighB))
            {
                CameraSettingView.default_opencv = true;
            }
            else
            {
                CameraSettingView.default_opencv = false;
            }

            if (CameraSettingView.camera_connected)
            {
                AddressStringTextBox.Enabled = true;
                GaussianKSizeCmb.Enabled = true;
                CannyThreshold1Trackbar.Enabled = true;
                CannyThreshold2Trackbar.Enabled = true;
                OnOffDetect.Enabled = true;
                Color.Enabled = true;
            }
            else
            {
                if (!CameraSettingView.paraSetting_flag)
                {
                    AddressStringTextBox.Enabled = false;
                    GaussianKSizeCmb.Enabled = false;
                    CannyThreshold1Trackbar.Enabled = false;
                    CannyThreshold2Trackbar.Enabled = false;
                    OnOffDetect.Enabled = false;
                    Color.Enabled = false;
                    CameraSettingView.paraSetting_flag = true;
                }  
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CameraAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
