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
using NeedleController.Presenters.RecycleBinPresenters;

using System.Globalization;
using Infralution.Localization;
using System.Resources;
using NeedleController.Properties;
using System.IO;
using System.Reflection;

namespace NeedleController.Views.RecycleBinUCs
{
    [PresenterBinding(typeof(InformationRecycleBinPresenter))]
    public partial class InformationRecycleBinUC : MvpUserControl, IInformationRecycleBinUC
    {
        private static int zoomStep = 40;
        private static Point mouseDownPoint;
        private static bool isMove;
        private static Size original_size;
        private static Point original_point;

        public string _needlename
        {
            get 
            { 
                return this.NeedleNameLabel_Value.Text; 
            }
            set 
            { 
                this.NeedleNameLabel_Value.Text = value; 
            }
        }
        public string _devicename
        {
            get
            {
                return this.DeviceNameLabel_Value.Text;
            }
            set
            {
                this.DeviceNameLabel_Value.Text = value;
            }
        }
        public string _brokentimestr
        {
            get
            {
                return this.BrokenTimeLabel_Value.Text;
            }
            set
            {
                this.BrokenTimeLabel_Value.Text = value;
            }
        }
        public string _exporttimestr
        {
            get
            {
                return this.ExportTimeStrLabel_Value.Text;
            }
            set
            {
                this.ExportTimeStrLabel_Value.Text = value;
            }
        }
        public string _staffname
        {
            get
            {
                return this.StaffNameLabel_Value.Text;
            }
            set
            {
                this.StaffNameLabel_Value.Text = value;
            }
        }
        public string _sewingmachine
        {
            get
            {
                return this.SewingMachineLabel_Value.Text;
            }
            set
            {
                this.SewingMachineLabel_Value.Text = value;
            }
        }
        public string _operator
        {
            get
            {
                return this.OperatorLabel_Value.Text;
            }
            set
            {
                this.OperatorLabel_Value.Text = value;
            }
        }
        public string _procsess
        {
            get
            {
                return this.ProcessLabel_Value.Text;
            }
            set
            {
                this.ProcessLabel_Value.Text = value;
            }
        }
        public string _reason
        {
            get
            {
                return this.ReasonLabel_Value.Text;
            }
            set
            {
                this.ReasonLabel_Value.Text = value;
            }
        }
        public string _partenough
        {
            get
            {
                return this.PartEnoughLabel_Value.Text;
            }
            set
            {
                this.PartEnoughLabel_Value.Text = value;
            }
        }
        public string _po
        {
            get
            {
                return this.POLabel_Value.Text;
            }
            set
            {
                this.POLabel_Value.Text = value;
            }
        }
        public Image _capturedimage
        {
            get
            {
                return this.CapturedImagePictureBox.Image;
            }
            set
            {
                this.CapturedImagePictureBox.Image = value;
            }
        }
        public string _confirmationTime
        {
            get
            {
                return this.ConfirmTimeLabel_value.Text;
            }
            set
            {
                this.ConfirmTimeLabel_value.Text = value;
            }
        }
        public string _confirmationBy
        {
            get
            {
                return this.ConfirmByLabel_value.Text;
            }
            set
            {
                this.ConfirmByLabel_value.Text = value;
            }
        }
        public string _handle
        {
            get
            {
                return this.HandleTextBox_Value.Text;
            }
            set
            {
                this.HandleTextBox_Value.Text = value;
            }
        }
        public string _line
        {
            get
            {
                return this.LineLabel_Value.Text;
            }
            set
            {
                this.LineLabel_Value.Text = value;
            }
        }
        public Color _brokentimeColor
        {
            get 
            {
                return this.BrokenTimeLabel_Value.ForeColor;
            }
            set
            {
                this.BrokenTimeLabel_Value.ForeColor = value;
            }
        }
        
        public event MouseEventHandler CapturedImagePictureBoxMouseDowned;
        public event MouseEventHandler CapturedImagePictureBoxMouseUped;
        public event MouseEventHandler CapturedImagePictureBoxMouseMoved;
        public event MouseEventHandler CapturedImagePictureBoxMouseWheeled;
        public event MouseEventHandler Panel1MouseDowned;
        public event MouseEventHandler Panel1MouseUped;
        public event MouseEventHandler Panel1MouseMoved;
        public event EventHandler ResetButtonClicked;


        public InformationRecycleBinUC()
        {
            InitializeComponent();
            this.CapturedImagePictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.CapturedImagePictureBox_MouseWheel);
            original_point = CapturedImagePictureBox.Location;
            original_size = CapturedImagePictureBox.Size;
        }

        private void CapturedImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            CapturedImagePictureBoxMouseDowned(this, e);
        }
        private void CapturedImagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            CapturedImagePictureBoxMouseUped(this, e);
        }
        private void CapturedImagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            CapturedImagePictureBoxMouseMoved(this, e);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Panel1MouseDowned(this, e);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Panel1MouseUped(this, e);

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Panel1MouseMoved(this, e);
        }
        private void CapturedImagePictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            CapturedImagePictureBoxMouseWheeled(this, e);
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetButtonClicked(this, EventArgs.Empty);
        }

        public void MouseDown_CapturedImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                CapturedImagePictureBox.Focus();
            }
        }
        public void MouseUp_CapturedImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }
        public void MouseMove_CapturedImagePictureBox(MouseEventArgs e)
        {
            CapturedImagePictureBox.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = CapturedImagePictureBox.Location.X + moveX;
                y = CapturedImagePictureBox.Location.Y + moveY;
                CapturedImagePictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        public void MouseDown_panel1(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
            }
        }
        public void MouseUp_panel1(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }
        public void MouseMove_panel1(MouseEventArgs e)
        {
            panel1.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = CapturedImagePictureBox.Location.X + moveX;
                y = CapturedImagePictureBox.Location.Y + moveY;
                CapturedImagePictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        public void MouseWheel_CapturedImagePictureBox(MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = CapturedImagePictureBox.Width;
            int oh = CapturedImagePictureBox.Height;
            int VX, VY;
            if (e.Delta > 0)
            {
                CapturedImagePictureBox.Width += zoomStep;
                CapturedImagePictureBox.Height += zoomStep;
                PropertyInfo pInfo = CapturedImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(CapturedImagePictureBox, null);
                CapturedImagePictureBox.Width = rect.Width;
                CapturedImagePictureBox.Height = rect.Height;
            }
            if (e.Delta < 0)
            {
                if (CapturedImagePictureBox.Width < this._capturedimage.Width / 10)
                    return;

                CapturedImagePictureBox.Width -= zoomStep;
                CapturedImagePictureBox.Height -= zoomStep;
                PropertyInfo pInfo = CapturedImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(CapturedImagePictureBox, null);
                CapturedImagePictureBox.Width = rect.Width;
                CapturedImagePictureBox.Height = rect.Height;
            }
            VX = (int)((double)x * (ow - CapturedImagePictureBox.Width) / ow);
            VY = (int)((double)y * (oh - CapturedImagePictureBox.Height) / oh);
            CapturedImagePictureBox.Location = new Point(CapturedImagePictureBox.Location.X + VX, CapturedImagePictureBox.Location.Y + VY);
        }

        public void Click_ResetButton()
        {
            CapturedImagePictureBox.Location = original_point;
            CapturedImagePictureBox.Size = original_size;
        }

        private void InformationRecycleBinUC_SizeChanged(object sender, EventArgs e)
        {
            original_point = CapturedImagePictureBox.Location;
            original_size = CapturedImagePictureBox.Size;
        }

        public void draw_picturebox(string str)
        {
            Bitmap tempBitmap = new Bitmap(_capturedimage.Width, _capturedimage.Height);
            Font font = new Font("Arial", 16f);
            using (Graphics G = Graphics.FromImage(tempBitmap))
            {
                // no anti-aliasing, please
                G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                G.DrawImage(_capturedimage, 0, 0);
                G.DrawString(str, font, Brushes.Orange, 20f, 100f);
            }
            _capturedimage = tempBitmap;
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
