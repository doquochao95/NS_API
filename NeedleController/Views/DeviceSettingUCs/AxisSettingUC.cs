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
using NeedleController.Presenters.DeviceSettingPresenters;


using System.Globalization;
using Infralution.Localization;
using System.Resources;
using NeedleController.Properties;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace NeedleController.Views.DeviceSettingUCs
{
    [PresenterBinding(typeof(AxisSettingPresenter))]
    public partial class AxisSettingUC : MvpUserControl, IAxisSettingUC
    {
        public int Xpos { get; set; } = 0;
        public int _Xpos
        {
            get
            {
                return Xpos;
            }
            set
            {
                if (Xpos != value)
                {
                    Xpos = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Ypos { get; set; } = 0;
        public int _Ypos
        {
            get
            {
                return Ypos;
            }
            set
            {
                if (Ypos != value)
                {
                    Ypos = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Zpos { get; set; } = 0;
        public int _Zpos
        {
            get
            {
                return Zpos;
            }
            set
            {
                if (Zpos != value)
                {
                    Zpos = value;
                    RefreshDataBindings();
                }
            }
        }

        public int Speed_x { get; set; } = 0;
        public int _speed_x
        {
            get
            {
                return Speed_x;
            }
            set
            {
                if (Speed_x != value)
                {
                    Speed_x = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Speed_y { get; set; } = 0;
        public int _speed_y
        {
            get
            {
                return Speed_y;
            }
            set
            {
                if (Speed_y != value)
                {
                    Speed_y = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Speed_z { get; set; } = 0;
        public int _speed_z
        {
            get
            {
                return Speed_z;
            }
            set
            {
                if (Speed_z != value)
                {
                    Speed_z = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Speed_w { get; set; } = 0;
        public int _speed_w
        {
            get
            {
                return Speed_w;
            }
            set
            {
                if (Speed_w != value)
                {
                    Speed_w = value;
                    RefreshDataBindings();
                }
            }
        }

        public int Accel_x { get; set; } = 0;
        public int _accel_x
        {
            get
            {
                return Accel_x;
            }
            set
            {
                if (Accel_x != value)
                {
                    Accel_x = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Accel_y { get; set; } = 0;
        public int _accel_y
        {
            get
            {
                return Accel_y;
            }
            set
            {
                if (Accel_y != value)
                {
                    Accel_y = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Accel_z { get; set; } = 0;
        public int _accel_z
        {
            get
            {
                return Accel_z;
            }
            set
            {
                if (Accel_z != value)
                {
                    Accel_z = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Accel_w { get; set; } = 0;
        public int _accel_w
        {
            get
            {
                return Accel_w;
            }
            set
            {
                if (Accel_w != value)
                {
                    Accel_w = value;
                    RefreshDataBindings();
                }
            }
        }

        public int Offset_x { get; set; } = 0;
        public int _offset_x
        {
            get
            {
                return Offset_x;
            }
            set
            {
                if (Offset_x != value)
                {
                    Offset_x = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Offset_y { get; set; } = 0;
        public int _offset_y
        {
            get
            {
                return Offset_y;
            }
            set
            {
                if (Offset_y != value)
                {
                    Offset_y = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Offset_z { get; set; } = 0;
        public int _offset_z
        {
            get
            {
                return Offset_z;
            }
            set
            {
                if (Offset_z != value)
                {
                    Offset_z = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Offset_w { get; set; } = 0;
        public int _offset_w
        {
            get
            {
                return Offset_w;
            }
            set
            {
                if (Offset_w != value)
                {
                    Offset_w = value;
                    RefreshDataBindings();
                }
            }
        }

        public int Plus_x { get; set; } = 0;
        public int _plus_x
        {
            get
            {
                return Plus_x;
            }
            set
            {
                if (Plus_x != value)
                {
                    Plus_x = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Plus_y { get; set; } = 0;
        public int _plus_y
        {
            get
            {
                return Plus_y;
            }
            set
            {
                if (Plus_y != value)
                {
                    Plus_y = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Plus_z { get; set; } = 0;
        public int _plus_z
        {
            get
            {
                return Plus_z;
            }
            set
            {
                if (Plus_z != value)
                {
                    Plus_z = value;
                    RefreshDataBindings();
                }
            }
        }
        public int Plus_w { get; set; } = 0;
        public int _plus_w
        {
            get
            {
                return Plus_w;
            }
            set
            {
                if (Plus_w != value)
                {
                    Plus_w = value;
                    RefreshDataBindings();
                }
            }
        }

        private static bool load_flag = false;

        private static int image_index = 0;
        public AxisSettingUC()
        {
            InitializeComponent();
            load_flag = false;

            InitializeTimer();
        }
        public event EventHandler AxisSettingUCLoaded;

        public event EventHandler MoveUpXButtonClicked;

        public event EventHandler MoveDownXButtonClicked;

        public event EventHandler MoveUpYButtonClicked;

        public event EventHandler MoveDownYButtonClicked;

        public event EventHandler MoveUpZButtonClicked;

        public event EventHandler MoveDownZButtonClicked;

        public event EventHandler OpenTableButtonClicked;
        public event EventHandler CloseTableButtonClicked;
        public event EventHandler ResetButtonClicked;
        public event EventHandler HomeButtonClicked;
        public event EventHandler ParkingButtonClicked;
        public event EventHandler MachineLedOnClicked;
        public event EventHandler MachineLedOffClicked;
        public event EventHandler TableLedOnClicked;
        public event EventHandler TableLedOffClicked;

        public event EventHandler ChangeImageButtonClicked;
        public event EventHandler SaveSpeedButtonClicked;
        public event EventHandler SaveAccelButtonClicked;
        public event EventHandler SaveOffsetButtonClicked;
        public event EventHandler SavePlusButtonClicked;

        public event EventHandler ResetSpeedButtonClicked;
        public event EventHandler ResetAccelButtonClicked;
        public event EventHandler ResetOffsetButtonClicked;
        public event EventHandler ResetPlusButtonClicked;

        public event EventHandler SaveConnectionButtonClicked;
        public event EventHandler ResetConnectionButtonClicked;
        public event EventHandler CheckButtonClicked;



        private void AxisSettingUC_Load(object sender, EventArgs e)
        {
            try
            {
                AxisSettingUCLoaded(this, EventArgs.Empty);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.ToString());
            }
        }
        private void MoveUpXButton_Click(object sender, EventArgs e)
        {
            MoveUpXButtonClicked(this, EventArgs.Empty);
        }
        private void MoveDownXButton_Click(object sender, EventArgs e)
        {
            MoveDownXButtonClicked(this, EventArgs.Empty);
        }
        private void MoveUpYButton_Click(object sender, EventArgs e)
        {
            MoveUpYButtonClicked(this, EventArgs.Empty);
        }
        private void MoveDownYButton_Click(object sender, EventArgs e)
        {
            MoveDownYButtonClicked(this, EventArgs.Empty);
        }
        private void MoveUpZButton_Click(object sender, EventArgs e)
        {
            MoveUpZButtonClicked(this, EventArgs.Empty);
        }
        private void MoveDownZButton_Click(object sender, EventArgs e)
        {
            MoveDownZButtonClicked(this, EventArgs.Empty);
        }
        private void OpenTableButton_Click(object sender, EventArgs e)
        {
            OpenTableButtonClicked(this, EventArgs.Empty);
        }
        private void CloseTableButton_Click(object sender, EventArgs e)
        {
            CloseTableButtonClicked(this, EventArgs.Empty);
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetButtonClicked(this, EventArgs.Empty);
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButtonClicked(this, EventArgs.Empty);
        }
        private void ParkingButton_Click(object sender, EventArgs e)
        {
            ParkingButtonClicked(this, EventArgs.Empty);
        }
        private void MachineLedOn_Click(object sender, EventArgs e)
        {
            MachineLedOnClicked(this, EventArgs.Empty);
        }
        private void MachineLedOff_Click(object sender, EventArgs e)
        {
            MachineLedOffClicked(this, EventArgs.Empty);
        }
        private void TableLedOn_Click(object sender, EventArgs e)
        {
            TableLedOnClicked(this, EventArgs.Empty);
        }
        private void TableLedOff_Click(object sender, EventArgs e)
        {
            TableLedOffClicked(this, EventArgs.Empty);
        }
        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            ChangeImageButtonClicked(this, EventArgs.Empty);
        }
        private void SaveSpeedButton_Click(object sender, EventArgs e)
        {
            SaveSpeedButtonClicked(this, EventArgs.Empty);
        }
        private void SaveAccelButton_Click(object sender, EventArgs e)
        {
            SaveAccelButtonClicked(this, EventArgs.Empty);
        }
        private void SaveOffsetButton_Click(object sender, EventArgs e)
        {
            SaveOffsetButtonClicked(this, EventArgs.Empty);
        }
        private void SavePlusButton_Click(object sender, EventArgs e)
        {
            SavePlusButtonClicked(this, EventArgs.Empty);
        }
        private void ResetSpeedButton_Click(object sender, EventArgs e)
        {
            ResetSpeedButtonClicked(this, EventArgs.Empty);
        }
        private void ResetAccelButton_Click(object sender, EventArgs e)
        {
            ResetAccelButtonClicked(this, EventArgs.Empty);
        }
        private void ResetOffsetButton_Click(object sender, EventArgs e)
        {
            ResetOffsetButtonClicked(this, EventArgs.Empty);
        }
        private void ResetPlusButton_Click(object sender, EventArgs e)
        {
            ResetPlusButtonClicked(this, EventArgs.Empty);
        }
        private void SaveConnectionButton_Click(object sender, EventArgs e)
        {
            SaveConnectionButtonClicked(this, EventArgs.Empty);
        }

        private void ResetConnectionButton_Click(object sender, EventArgs e)
        {
            ResetConnectionButtonClicked(this, EventArgs.Empty);
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckButtonClicked(this, EventArgs.Empty);
        }
        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Xpos != MainView.x_position)
            {
                _Xpos = MainView.x_position;
            }
            if (Ypos != MainView.y_position)
            {
                _Ypos = MainView.y_position;
            }
            if (Zpos != MainView.z_position)
            {
                _Zpos = MainView.z_position;
            }

            if (!load_flag)
            {
                if (Speed_x != MainView.x_speed)
                {
                    _speed_x = MainView.x_speed;
                }
                if (Speed_y != MainView.y_speed)
                {
                    _speed_y = MainView.y_speed;
                }
                if (Speed_z != MainView.z_speed)
                {
                    _speed_z = MainView.z_speed;
                }
                if (Speed_w != MainView.w_speed)
                {
                    _speed_w = MainView.w_speed;
                }

                if (Accel_x != MainView.x_accel)
                {
                    _accel_x = MainView.x_accel;
                }
                if (Accel_y != MainView.y_accel)
                {
                    _accel_y = MainView.y_accel;
                }
                if (Accel_z != MainView.z_accel)
                {
                    _accel_z = MainView.z_accel;
                }
                if (Accel_w != MainView.w_accel)
                {
                    _accel_w = MainView.w_accel;
                }

                if (Offset_x != MainView.x_offset)
                {
                    _offset_x = MainView.x_offset;
                }
                if (Offset_y != MainView.y_offset)
                {
                    _offset_y = MainView.y_offset;
                }
                if (Offset_z != MainView.z_offset)
                {
                    _offset_z = MainView.z_offset;
                }
                if (Offset_w != MainView.w_offset)
                {
                    _offset_w = MainView.w_offset;
                }

                if (Plus_x != MainView.x_plus)
                {
                    _plus_x = MainView.x_plus;
                }
                if (Plus_y != MainView.y_plus)
                {
                    _plus_y = MainView.y_plus;
                }
                if (Plus_z != MainView.z_plus)
                {
                    _plus_z = MainView.z_plus;
                }
                if (Plus_w != MainView.w_plus)
                {
                    _plus_w = MainView.w_plus;
                }
                load_flag = true;
            }
            if (Xpos == 0)
            {
                MoveDownXButton.Enabled = false;
            }
            else
            {
                MoveDownXButton.Enabled = true;
            }
            if (Ypos == 0)
            {
                MoveDownYButton.Enabled = false;
            }
            else
            {
                MoveDownYButton.Enabled = true;
            }
            if (Zpos == 0)
            {
                MoveUpZButton.Enabled = false;
            }
            else
            {
                MoveUpZButton.Enabled = true;
            }
            if (MainView.needle_table_opened)
            {
                OpenTableButton.Enabled = false;
                CloseTableButton.Enabled = true;
            }
            else
            {
                OpenTableButton.Enabled = true;
                CloseTableButton.Enabled = false;
            }
            if (MainView.machine_parked)
            {
                ParkingButton.Text = "Unpark";
            }
            else
            {
                ParkingButton.Text = "Park";
            }
            if (MainView.machine_led_on)
            {
                MachineLedOn.Enabled = false;
                MachineLedOff.Enabled = true;
            }
            else
            {
                MachineLedOn.Enabled = true;
                MachineLedOff.Enabled = false;
            }
            if (MainView.table_led_on)
            {
                TableLedOn.Enabled = false;
                TableLedOff.Enabled = true;
            }
            else
            {
                TableLedOn.Enabled = true;
                TableLedOff.Enabled = false;
            }
            if (int.Parse(XSpeedTextBox.Text) == MainView.x_speed &&
                int.Parse(YSpeedTextBox.Text) == MainView.y_speed &&
                int.Parse(ZSpeedTextBox.Text) == MainView.z_speed &&
                int.Parse(WSpeedTextBox.Text) == MainView.w_speed)
            {
                SaveSpeedButton.Enabled = false;
                ResetSpeedButton.Enabled = false;
            }
            else
            {
                SaveSpeedButton.Enabled = true;
                ResetSpeedButton.Enabled = true;
            }
            if (int.Parse(XAccelTextBox.Text) == MainView.x_accel &&
               int.Parse(YAccelTextBox.Text) == MainView.y_accel &&
               int.Parse(ZAccelTextBox.Text) == MainView.z_accel &&
               int.Parse(WAccelTextBox.Text) == MainView.w_accel)
            {
                SaveAccelButton.Enabled = false;
                ResetAccelButton.Enabled = false;
            }
            else
            {
                SaveAccelButton.Enabled = true;
                ResetAccelButton.Enabled = true;
            }
            if (int.Parse(XOffsetTextbox.Text) == MainView.x_offset &&
               int.Parse(YOffsetTextbox.Text) == MainView.y_offset &&
               int.Parse(ZOffsetTextbox.Text) == MainView.z_offset &&
               int.Parse(WOffsetTextbox.Text) == MainView.w_offset)
            {
                SaveOffsetButton.Enabled = false;
                ResetOffsetButton.Enabled = false;
            }
            else
            {
                SaveOffsetButton.Enabled = true;
                ResetOffsetButton.Enabled = true;
            }
            if (int.Parse(XPlusTextbox.Text) == MainView.x_plus &&
               int.Parse(YPlusTextbox.Text) == MainView.y_plus &&
               int.Parse(ZPlusTextbox.Text) == MainView.z_plus &&
               int.Parse(WPlusTextbox.Text) == MainView.w_plus)
            {
                SavePlusButton.Enabled = false;
                ResetPlusButton.Enabled = false;
            }
            else
            {
                SavePlusButton.Enabled = true;
                ResetPlusButton.Enabled = true;
            }
            if (DeviceIPTextBox.Text == Properties.Settings.Default.local_ip &&
            PortTextbox.Text == Properties.Settings.Default.port.ToString())
            {
                SaveConnectionButton.Enabled = false;
                ResetConnectionButton.Enabled = false;
            }
            else
            {
                SaveConnectionButton.Enabled = true;
                ResetConnectionButton.Enabled = true;
            }
            if (DeviceSettingView.cable_connection)
            {
                ConnectionStatusLabel.Text = "available";
                ConnectionStatusLabel.ForeColor = Color.Green;
                if (MainView._deviceConnection)
                {
                    ParameterGroupbox.Enabled = true;
                    ControllerGroupBox.Enabled = true;
                }
                else
                {
                    ParameterGroupbox.Enabled = false;
                    ControllerGroupBox.Enabled = false;
                }
            }
            else
            {
                ConnectionStatusLabel.Text = "invalid";
                ConnectionStatusLabel.ForeColor = Color.Red;
                if (MainView._deviceConnection)
                {
                    ParameterGroupbox.Enabled = true;
                    ControllerGroupBox.Enabled = true;
                }
                else
                {
                    ParameterGroupbox.Enabled = false;
                    ControllerGroupBox.Enabled = false;
                }
            }
        }

        public void Load_AxisSettingUC()
        {
            RefreshDataBindings();
            pictureBox4.Image = imageList1.Images[image_index];
            DeviceIPTextBox.Text = Properties.Settings.Default.local_ip;
            PortTextbox.Text = Properties.Settings.Default.port.ToString();
            DeviceSettingView.check_connection = true;

        }
        public void MoveUp_X()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movex:" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void MoveDown_X()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movex:" + "-" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void MoveUp_Y()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movey:" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void MoveDown_Y()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movey:" + "-" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void MoveUp_Z()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movez:" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void MoveDown_Z()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<movez:" + "-" + MoveValueTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }

        }

        public void Click_OpenTableButton()
        {
            OpenTableButton.Enabled = false;
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<table:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_CloseTableButton()
        {
            CloseTableButton.Enabled = false;
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<table:0>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_ResetButton()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<reset:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_HomeButton()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<home:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_ParkingButton()
        {
            if (MainView.machine_parked)
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    try
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<park:0>");
                        udpClient.Send(senddata, senddata.Length);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            else
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    try
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<park:1>");
                        udpClient.Send(senddata, senddata.Length);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
        }
        public void Click_MachineLedOn()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<led1:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_MachineLedOff()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<led1:0>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_TableLedOn()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<led2:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_TableLedOff()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<led2:0>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void Click_ChangeImageButton()
        {
            int imagelist_count = imageList1.Images.Count;
            image_index++;
            if (image_index < imagelist_count)
            {
                pictureBox4.Image = imageList1.Images[image_index];
            }
            else
            {
                image_index = 0;
                pictureBox4.Image = imageList1.Images[image_index];
            }
        }
        public void Click_SaveSpeedButton()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<speedx:" + XSpeedTextBox.Text + "><speedy:" + YSpeedTextBox.Text + "><speedz:" + ZSpeedTextBox.Text + "><speedw:" + WSpeedTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            MainView.x_speed = int.Parse(XSpeedTextBox.Text);
            MainView.y_speed = int.Parse(YSpeedTextBox.Text);
            MainView.z_speed = int.Parse(ZSpeedTextBox.Text);
            MainView.w_speed = int.Parse(WSpeedTextBox.Text);
            load_flag = false;
        }
        public void Click_SaveAccelButton()
        {

            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<accelx:" + XAccelTextBox.Text + "><accely:" + YAccelTextBox.Text + "><accelz:" + ZAccelTextBox.Text + "><accelw:" + WAccelTextBox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            MainView.x_accel = int.Parse(XAccelTextBox.Text);
            MainView.y_accel = int.Parse(YAccelTextBox.Text);
            MainView.z_accel = int.Parse(ZAccelTextBox.Text);
            MainView.w_accel = int.Parse(WAccelTextBox.Text);
            load_flag = false;

        }
        public void Click_SaveOffsetButton()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<offsetx:" + XOffsetTextbox.Text + "><offsety:" + YOffsetTextbox.Text + "><offsetz:" + ZOffsetTextbox.Text + "><offsetw:" + WOffsetTextbox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            MainView.x_offset = int.Parse(XOffsetTextbox.Text);
            MainView.y_offset = int.Parse(YOffsetTextbox.Text);
            MainView.z_offset = int.Parse(ZOffsetTextbox.Text);
            MainView.w_offset = int.Parse(WOffsetTextbox.Text);
            load_flag = false;
        }
        public void Click_SavePlusButton()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<plusx:" + XPlusTextbox.Text + "><plusy:" + YPlusTextbox.Text + "><plusz:" + ZPlusTextbox.Text + "><plusw:" + WPlusTextbox.Text + ">");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            MainView.x_plus = int.Parse(XPlusTextbox.Text);
            MainView.y_plus = int.Parse(YPlusTextbox.Text);
            MainView.z_plus = int.Parse(ZPlusTextbox.Text);
            MainView.w_plus = int.Parse(WPlusTextbox.Text);
            load_flag = false;

        }

        public void Click_ResetSpeedButton()
        {
            XSpeedTextBox.Text = MainView.x_speed.ToString();
            YSpeedTextBox.Text = MainView.y_speed.ToString();
            ZSpeedTextBox.Text = MainView.z_speed.ToString();
            WSpeedTextBox.Text = MainView.w_speed.ToString();
        }
        public void Click_ResetAccelButton()
        {
            XAccelTextBox.Text = MainView.x_accel.ToString();
            YAccelTextBox.Text = MainView.y_accel.ToString();
            ZAccelTextBox.Text = MainView.z_accel.ToString();
            WAccelTextBox.Text = MainView.w_accel.ToString();
        }
        public void Click_ResetOffsetButton()
        {
            XOffsetTextbox.Text = MainView.x_offset.ToString();
            YOffsetTextbox.Text = MainView.y_offset.ToString();
            ZOffsetTextbox.Text = MainView.z_offset.ToString();
            WOffsetTextbox.Text = MainView.w_offset.ToString();
        }
        public void Click_ResetPlusButton()
        {
            XPlusTextbox.Text = MainView.x_plus.ToString();
            YPlusTextbox.Text = MainView.y_plus.ToString();
            ZPlusTextbox.Text = MainView.z_plus.ToString();
            WPlusTextbox.Text = MainView.w_plus.ToString();
        }
        public void Click_SaveConnectionButton()
        {
            Properties.Settings.Default.local_ip = DeviceIPTextBox.Text;
            Properties.Settings.Default.port = int.Parse(PortTextbox.Text);
            Properties.Settings.Default.Save();
        }
        public void Click_ResetConnectionButton()
        {
            DeviceIPTextBox.Text = Properties.Settings.Default.local_ip;
            PortTextbox.Text = Properties.Settings.Default.port.ToString();
        }

        public void Click_CheckButton()
        {
            DeviceSettingView.device_ip = DeviceIPTextBox.Text;
            DeviceSettingView.check_connection = true;
        }

        public void RefreshDataBindings()
        {
            XPoxTextBox.DataBindings.Clear();
            XPoxTextBox.DataBindings.Add("Text", this, "Xpos", false, DataSourceUpdateMode.OnPropertyChanged);
            YPosTextBox.DataBindings.Clear();
            YPosTextBox.DataBindings.Add("Text", this, "Ypos", false, DataSourceUpdateMode.OnPropertyChanged);
            ZPosTextBox.DataBindings.Clear();
            ZPosTextBox.DataBindings.Add("Text", this, "Zpos", false, DataSourceUpdateMode.OnPropertyChanged);

            XSpeedTextBox.DataBindings.Clear();
            XSpeedTextBox.DataBindings.Add("Text", this, "Speed_x", false, DataSourceUpdateMode.OnPropertyChanged);
            YSpeedTextBox.DataBindings.Clear();
            YSpeedTextBox.DataBindings.Add("Text", this, "Speed_y", false, DataSourceUpdateMode.OnPropertyChanged);
            ZSpeedTextBox.DataBindings.Clear();
            ZSpeedTextBox.DataBindings.Add("Text", this, "Speed_z", false, DataSourceUpdateMode.OnPropertyChanged);
            WSpeedTextBox.DataBindings.Clear();
            WSpeedTextBox.DataBindings.Add("Text", this, "Speed_w", false, DataSourceUpdateMode.OnPropertyChanged);

            XAccelTextBox.DataBindings.Clear();
            XAccelTextBox.DataBindings.Add("Text", this, "Accel_x", false, DataSourceUpdateMode.OnPropertyChanged);
            YAccelTextBox.DataBindings.Clear();
            YAccelTextBox.DataBindings.Add("Text", this, "Accel_y", false, DataSourceUpdateMode.OnPropertyChanged);
            ZAccelTextBox.DataBindings.Clear();
            ZAccelTextBox.DataBindings.Add("Text", this, "Accel_z", false, DataSourceUpdateMode.OnPropertyChanged);
            WAccelTextBox.DataBindings.Clear();
            WAccelTextBox.DataBindings.Add("Text", this, "Accel_w", false, DataSourceUpdateMode.OnPropertyChanged);

            XOffsetTextbox.DataBindings.Clear();
            XOffsetTextbox.DataBindings.Add("Text", this, "Offset_x", false, DataSourceUpdateMode.OnPropertyChanged);
            YOffsetTextbox.DataBindings.Clear();
            YOffsetTextbox.DataBindings.Add("Text", this, "Offset_y", false, DataSourceUpdateMode.OnPropertyChanged);
            ZOffsetTextbox.DataBindings.Clear();
            ZOffsetTextbox.DataBindings.Add("Text", this, "Offset_z", false, DataSourceUpdateMode.OnPropertyChanged);
            WOffsetTextbox.DataBindings.Clear();
            WOffsetTextbox.DataBindings.Add("Text", this, "Offset_w", false, DataSourceUpdateMode.OnPropertyChanged);

            XPlusTextbox.DataBindings.Clear();
            XPlusTextbox.DataBindings.Add("Text", this, "Plus_x", false, DataSourceUpdateMode.OnPropertyChanged);
            YPlusTextbox.DataBindings.Clear();
            YPlusTextbox.DataBindings.Add("Text", this, "Plus_y", false, DataSourceUpdateMode.OnPropertyChanged);
            ZPlusTextbox.DataBindings.Clear();
            ZPlusTextbox.DataBindings.Add("Text", this, "Plus_z", false, DataSourceUpdateMode.OnPropertyChanged);
            WPlusTextbox.DataBindings.Clear();
            WPlusTextbox.DataBindings.Add("Text", this, "Plus_w", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void MoveValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
