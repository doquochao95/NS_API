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
using NeedleController.Presenters.NeedleInfoPresenters;

using System.Globalization;
using Infralution.Localization;
using System.IO;
using System.Collections.ObjectModel;
using System.Reflection;

namespace NeedleController.Views.NeedleInfoUCs
{
    [PresenterBinding(typeof(InfomationPresenter))]
    public partial class InfomationUC : MvpUserControl, IInfomationUC
    {
        private static int zoomStep = 40;
        private static Point mouseDownPoint;
        private static bool isMove;
        private static Size original_size;
        private static Point original_point;
        public InfomationUC()
        {
            InitializeComponent();
            InitializeTimer();
            this.NeedleImagePictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.NeedleImagePictureBox_MouseWheel);
            this.PointImagePictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PointImagePictureBox_MouseWheel);
        }
        public event EventHandler InfomationUCLoaded;
        public event EventHandler NeedleComboBoxSelectedIndexChanged;
        public event EventHandler SearchButtonClicked;

        public event MouseEventHandler NeedleImagePictureBoxMouseDowned;
        public event MouseEventHandler NeedleImagePictureBoxMouseUped;
        public event MouseEventHandler NeedleImagePictureBoxMouseMoved;
        public event MouseEventHandler Panel2MouseDowned;
        public event MouseEventHandler Panel2MouseUped;
        public event MouseEventHandler Panel2MouseMoved;
        public event MouseEventHandler NeedleImagePictureBoxMouseWheeled;
        public event MouseEventHandler PointImagePictureBoxMouseDowned;
        public event MouseEventHandler PointImagePictureBoxMouseUped;
        public event MouseEventHandler PointImagePictureBoxMouseMoved;
        public event MouseEventHandler Panel1MouseDowned;
        public event MouseEventHandler Panel1MouseUped;
        public event MouseEventHandler Panel1MouseMoved;
        public event MouseEventHandler PointImagePictureBoxMouseWheeled;
        public event EventHandler ResetPointImageButtonClicked;
        public event EventHandler ResetNeedleImageButtonClicked;


        private void InfomationUC_Load(object sender, EventArgs e)
        {
            try
            {
                InfomationUCLoaded(this, EventArgs.Empty);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.ToString());
            }
        }
        private void NeedleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedleComboBoxSelectedIndexChanged(this, EventArgs.Empty);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonClicked(this, EventArgs.Empty);
        }

        private void NeedleImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            NeedleImagePictureBoxMouseDowned(this, e);
        }
        private void NeedleImagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            NeedleImagePictureBoxMouseUped(this, e);
        }
        private void NeedleImagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            NeedleImagePictureBoxMouseMoved(this, e);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Panel2MouseDowned(this, e);
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Panel2MouseUped(this, e);
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Panel2MouseMoved(this, e);
        }
        private void NeedleImagePictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            NeedleImagePictureBoxMouseWheeled(this, e);
        }
        private void PointImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PointImagePictureBoxMouseDowned(this, e);
        }
        private void PointImagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PointImagePictureBoxMouseUped(this, e);
        }
        private void PointImagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PointImagePictureBoxMouseMoved(this, e);
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
        private void PointImagePictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            PointImagePictureBoxMouseWheeled(this, e);
        }
        private void ResetPointImageButton_Click(object sender, EventArgs e)
        {
            ResetPointImageButtonClicked(this, EventArgs.Empty);
        }
        private void ResetNeedleImageButton_Click(object sender, EventArgs e)
        {
            ResetNeedleImageButtonClicked(this, EventArgs.Empty);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 50;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (NeedleInfoView.last_selectedTabindex == 0 && NeedleInfoView.infouc_load == false)
            {
                Load_InformationUC();
                NeedleInfoView.infouc_load = true;
            }
        }
        public void Load_InformationUC()
        {
            original_point = PointImagePictureBox.Location;
            original_size = PointImagePictureBox.Size;
            NeedleComboBox.Items.Clear();
            if (NeedleInfoView.needle_list == null)
            {
                return;
            }
            foreach (var needle in NeedleInfoView.needle_list)
            {
                NeedleComboBox.Items.Add(needle);
            }
            NeedleComboBox.DisplayMember = "NeedleName";
            NeedleComboBox.ValueMember = "NeedleID";
            Reset_Parameters();
        }
        public void Change_NeedleComboBoxSelectedIndex()
        {
            if (NeedleComboBox.SelectedItem != null)
            {
                int needlename = int.Parse(NeedleComboBox.Text);
                var item = NeedleInfoView.needle_list.Where(i => i.NeedleName == needlename).FirstOrDefault();
                NeedleNameTextBox.Text = item.NeedleName.ToString();
                NeedleCodeTextBox.Text = item.NeedleCode;
                NeedleSizeTextBox.Text = item.NeedleSize;
                NeedlePointTextBox.Text = item.NeedlePoint;
                NeedlePriceTextBox.Text = item.NeedlePrice.ToString();
                NeedleLengthTextBox.Text = item.NeedleLength.ToString();
                PointImagePictureBox.Image = byteArrayToImage(item.PointTypeImage);
                NeedleImagePictureBox.Image = byteArrayToImage(item.RealityImage);
                NeedleInfoView.selected_needlepointbitmap = byteArrayToImage(item.PointTypeImage);
                NeedleInfoView.selected_needleimagebitmap = byteArrayToImage(item.RealityImage);
                SearchTextBox.Text = item.NeedleName.ToString();
            }
        }
        public void SearchNeedle()
        {
            string search_name = SearchTextBox.Text;
            if (search_name == null || search_name == "")
            {
                MessageBox.Show(this, "Please type needle name", "Attention :", MessageBoxButtons.OK);
            }
            else
            {
                if (search_name.Length > 6)
                {
                    MessageBox.Show(this, "More than 6 characters", "Attention :", MessageBoxButtons.OK);
                }
                else
                {
                    if (IsDigitsOnly(search_name))
                    {
                        bool status = EF_CONFIG.DataTransform.NeedleBase.Check_AvailableNeedleName(int.Parse(search_name));
                        if (!status)
                        {
                            MessageBox.Show(this, "Needle is not available. Please try another name", "Attention :", MessageBoxButtons.OK);
                        }
                        else
                        {
                            var item = NeedleInfoView.needle_list.Where(i => i.NeedleName == int.Parse(search_name)).FirstOrDefault();
                            NeedleNameTextBox.Text = item.NeedleName.ToString();
                            NeedleCodeTextBox.Text = item.NeedleCode;
                            NeedleSizeTextBox.Text = item.NeedleSize;
                            NeedlePointTextBox.Text = item.NeedlePoint;
                            NeedlePriceTextBox.Text = item.NeedlePrice.ToString();
                            NeedleLengthTextBox.Text = item.NeedleLength.ToString();
                            PointImagePictureBox.Image = byteArrayToImage(item.PointTypeImage);
                            NeedleImagePictureBox.Image = byteArrayToImage(item.RealityImage);
                            NeedleInfoView.selected_needlepointbitmap = byteArrayToImage(item.PointTypeImage);
                            NeedleInfoView.selected_needleimagebitmap = byteArrayToImage(item.RealityImage);
                            NeedleComboBox.Text = item.NeedleName.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Contains not allowance character", "Attention :", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void MouseDown_NeedleImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                NeedleImagePictureBox.Focus();
            }
        }
        public void MouseUp_NeedleImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }
        public void MouseMove_NeedleImagePictureBox(MouseEventArgs e)
        {
            NeedleImagePictureBox.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = NeedleImagePictureBox.Location.X + moveX;
                y = NeedleImagePictureBox.Location.Y + moveY;
                NeedleImagePictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        public void MouseDown_panel2(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
            }
        }
        public void MouseUp_panel2(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }
        public void MouseMove_panel2(MouseEventArgs e)
        {
            panel2.Focus(); if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = NeedleImagePictureBox.Location.X + moveX;
                y = NeedleImagePictureBox.Location.Y + moveY;
                NeedleImagePictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        public void MouseWheel_NeedleImagePictureBox(MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = NeedleImagePictureBox.Width;
            int oh = NeedleImagePictureBox.Height;
            int VX, VY;
            if (e.Delta > 0)
            {
                NeedleImagePictureBox.Width += zoomStep;
                NeedleImagePictureBox.Height += zoomStep;
                PropertyInfo pInfo = NeedleImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(NeedleImagePictureBox, null);
                NeedleImagePictureBox.Width = rect.Width;
                NeedleImagePictureBox.Height = rect.Height;
            }
            if (e.Delta < 0)
            {
                if (NeedleImagePictureBox.Width < NeedleInfoView.selected_needleimagebitmap.Width / 10)
                    return;

                NeedleImagePictureBox.Width -= zoomStep;
                NeedleImagePictureBox.Height -= zoomStep;
                PropertyInfo pInfo = NeedleImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(NeedleImagePictureBox, null);
                NeedleImagePictureBox.Width = rect.Width;
                NeedleImagePictureBox.Height = rect.Height;
            }
            VX = (int)((double)x * (ow - NeedleImagePictureBox.Width) / ow);
            VY = (int)((double)y * (oh - NeedleImagePictureBox.Height) / oh);
            NeedleImagePictureBox.Location = new Point(NeedleImagePictureBox.Location.X + VX, NeedleImagePictureBox.Location.Y + VY);
        }
        public void MouseDown_PointImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                PointImagePictureBox.Focus();
            }
        }
        public void MouseUp_PointImagePictureBox(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }
        public void MouseMove_PointImagePictureBox(MouseEventArgs e)
        {
            PointImagePictureBox.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = PointImagePictureBox.Location.X + moveX;
                y = PointImagePictureBox.Location.Y + moveY;
                PointImagePictureBox.Location = new Point(x, y);
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
            panel2.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = PointImagePictureBox.Location.X + moveX;
                y = PointImagePictureBox.Location.Y + moveY;
                PointImagePictureBox.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        public void MouseWheel_PointImagePictureBox(MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = PointImagePictureBox.Width;
            int oh = PointImagePictureBox.Height;
            int VX, VY;
            if (e.Delta > 0)
            {
                PointImagePictureBox.Width += zoomStep;
                PointImagePictureBox.Height += zoomStep;
                PropertyInfo pInfo = PointImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(PointImagePictureBox, null);
                PointImagePictureBox.Width = rect.Width;
                PointImagePictureBox.Height = rect.Height;
            }
            if (e.Delta < 0)
            {
                if (PointImagePictureBox.Width < NeedleInfoView.selected_needlepointbitmap.Width / 10)
                    return;

                PointImagePictureBox.Width -= zoomStep;
                PointImagePictureBox.Height -= zoomStep;
                PropertyInfo pInfo = PointImagePictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(PointImagePictureBox, null);
                PointImagePictureBox.Width = rect.Width;
                PointImagePictureBox.Height = rect.Height;
            }
            VX = (int)((double)x * (ow - PointImagePictureBox.Width) / ow);
            VY = (int)((double)y * (oh - PointImagePictureBox.Height) / oh);
            PointImagePictureBox.Location = new Point(PointImagePictureBox.Location.X + VX, PointImagePictureBox.Location.Y + VY);
        }
        public void Click_ResetPointImageButton()
        {
            PointImagePictureBox.Location = original_point;
            PointImagePictureBox.Size = original_size;
        }
        public void Click_ResetNeedleImageButton()
        {
            NeedleImagePictureBox.Location = original_point;
            NeedleImagePictureBox.Size = original_size;
        }

        private void Reset_Parameters()
        {
            NeedleNameTextBox.Text = null;
            NeedleCodeTextBox.Text = null;
            NeedleSizeTextBox.Text = null;
            NeedlePointTextBox.Text = null;
            NeedlePriceTextBox.Text = null;
            NeedleLengthTextBox.Text = null;
            PointImagePictureBox.Image = null;
            NeedleImagePictureBox.Image = null;
            SearchTextBox.Text = null;
            NeedleComboBox.SelectedItem = null;
            NeedleComboBox.Text = null;
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return null;
        }
        private bool IsDigitsOnly(string str)
        {
            return str.All(char.IsDigit);
        }


    }
}
