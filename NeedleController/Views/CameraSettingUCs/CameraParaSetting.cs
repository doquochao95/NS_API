using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsMvp.Forms;
using NeedleController.Presenters;
using WinFormsMvp;

namespace NeedleController.Views.CameraSettingUCs
{
    [PresenterBinding(typeof(CameraParaPresenter))]
    public partial class CameraParaSetting : MvpUserControl, ICameraParaSetting
    {
        private int gaussianBlurKsize = 1;
        private int cannyThreshold1;
        private int cannyThreshold2;
        private int colorLowR;
        private int colorLowG;
        private int colorLowB;
        private int colorHighR;
        private int colorHighG;
        private int colorHighB;

        public int GaussianBlurKsize { get => gaussianBlurKsize; set => gaussianBlurKsize = value; }
        public int CannyThreshold1 { get => cannyThreshold1; set => cannyThreshold1 = value; }
        public int CannyThreshold2 { get => cannyThreshold2; set => cannyThreshold2 = value; }
        public int ColorLowR { get => colorLowR; set => colorLowR = value; }
        public int ColorLowG { get => colorLowG; set => colorLowG = value; }
        public int ColorLowB { get => colorLowB; set => colorLowB = value; }
        public int ColorHighR { get => colorHighR; set => colorHighR = value; }
        public int ColorHighG { get => colorHighG; set => colorHighG = value; }
        public int ColorHighB { get => colorHighB; set => colorHighB = value; }        

        public CameraParaSetting()
        {
            InitializeComponent();
            
        }
        
        public event EventHandler CannyThreshold_1_Scrolled;
        public event EventHandler CannyThreshold_2_Scrolled;
        public event EventHandler SaveColorPara_Clicked;
        public event EventHandler GaussianKSizeCmb_Selected;
        public event EventHandler LowR_KeyPressed;
        public event EventHandler LowG_KeyPressed;
        public event EventHandler LowB_KeyPressed;
        public event EventHandler HighR_KeyPressed;
        public event EventHandler HighG_KeyPressed;
        public event EventHandler HighB_KeyPressed;

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

        private void SaveColorParaButton_Click(object sender, EventArgs e)
        {
            SaveColorPara_Clicked(this, EventArgs.Empty);
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
        //------------------.-----------------//

        public void GetGaussianBlurKsize()
        {
            gaussianBlurKsize = int.Parse(GaussianKSizeCmb.SelectedItem.ToString());
        }

        public void GetCannyThreshold1()
        {
            cannyThreshold1 = CannyThreshold1Trackbar.Value;
            CannyThreshold1Value.Text = CannyThreshold1Trackbar.Value.ToString();
        }

        public void GetCannyThreshold2()
        {
            cannyThreshold2 = CannyThreshold2Trackbar.Value;
            CannyThreshold2Value.Text = CannyThreshold2Trackbar.Value.ToString();
        }

        public void SaveColorPara()
        {
            colorLowR = int.Parse(LowR.Text);
            colorLowG = int.Parse(LowG.Text);
            colorLowB = int.Parse(LowB.Text);
            colorHighR = int.Parse(HighR.Text);
            colorHighG = int.Parse(HighG.Text);
            colorHighB = int.Parse(HighB.Text);
            ColorNeedle.Invalidate();
        }

        public void EnterLowR()
        {
            colorLowR = int.Parse(LowR.Text);
            if (colorLowR >= 0 && colorLowR <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowR.Text = "0";
            }
        }

        public void EnterLowG()
        {
            colorLowG = int.Parse(LowG.Text);
            if (colorLowG >= 0 && colorLowG <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowG.Text = "0";
            }
        }

        public void EnterLowB()
        {
            colorLowB = int.Parse(LowB.Text);
            if (colorLowB >= 0 && colorLowB <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                LowB.Text = "0";
            }
        }

        public void EnterHighR()
        {
            colorHighR = int.Parse(HighR.Text);
            if (colorHighR >= 0 && colorHighR <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighR.Text = "0";
            }
        }

        public void EnterHighG()
        {
            colorHighG = int.Parse(HighG.Text);
            if (colorHighG >= 0 && colorHighG <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighG.Text = "0";
            }
        }

        public void EnterHighB()
        {
            colorHighB = int.Parse(HighB.Text);
            if (colorHighB >= 0 && colorHighB <= 255)
                ColorNeedle.Invalidate();
            else
            {
                MessageBox.Show("Please enter value in the range from 0 to 255");
                HighB.Text = "0";
            }
        }

        private void ColorNeedle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush bBackground = new LinearGradientBrush(rBackground, System.Drawing.Color.FromArgb(colorLowR, colorLowG, colorLowB), 
                System.Drawing.Color.FromArgb(colorHighR, colorHighG, colorHighB), 0f);
            g.FillRectangle(bBackground, rBackground);
        }

    }
}
