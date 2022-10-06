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
using System.Globalization;
using Infralution.Localization;
using Microsoft.Office.Interop.Excel;

using OpenCvDotNet;
using System.IO;
using System.Text.RegularExpressions;
using Serilog;
using Application = System.Windows.Forms.Application;

namespace NeedleController.Views
{
    public partial class MainView : MvpForm, IMainView
    {
        public List<ExcelFile> ExcelFiles_list { get; set; }
        public static List<string> POListString;

        string Filepath = @"\\10.4.0.8\Report\Produce Manage\Production Planning\新資料夾\1.生產進度";

        private static string lastlistbox_string;

        public static bool _deviceConnection = false;
        public static bool _cableConnection = false;
        public static bool _connected { get; set; } = false;
        public static bool _databaseconnected { get; set; } = false;


        public static bool _confirmRFID { get; set; } = false;
        public static bool needlepickingviewloaded_status { get; set; } = false;
        public static bool addneedleviewloaded_status { get; set; } = false;
        public static bool needleinfoviewloaded_status { get; set; } = false;
        public static bool recyclebinviewloaded_status { get; set; } = false;

        public static bool camerasettingviewloaded_status { get; set; } = false;
        public static bool devicesettingviewloaded_status { get; set; } = false;

        public static bool showaddneedleview_flag { get; set; } = false;
        public static bool showdevicesettingview_flag { get; set; } = false;
        public static bool showneedlepickingview_flag { get; set; } = false;
        public static bool showrecyclebinview_flag { get; set; } = false;
        public static bool showcamerasettingview_flag { get; set; } = false;

        public static bool CardCheckingDetected { get; set; } = false;

        public static bool loaddevicesetting_withoutconnection { get; set; } = false;



        public static bool check_camera { get; set; } = false;
        public static bool post_onlinestatus { get; set; } = false;
        public static bool get_onlinestatus { get; set; } = false;
        public static bool check_databaseconnection { get; set; } = false;
        public static bool close_waiting { get; set; } = false;
        public static bool mainview_close { get; set; } = false;

        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();

        public static string _message { get; set; }
        public static string replied_buffer { get; set; }

        public static string listbox_string { get; set; }
        public static string para_name;
        public static string para_value_str;

        public static string last_view { get; set; }

        public static int device_id { get; set; }
        public static string device_name { get; set; }
        public static int building_id { get; set; }
        public static string building_name { get; set; }
        public static int needlesupplied_status { get; set; } = 2; //0: Failed, 1:Success, 2: Null


        public static int countCamera { get; set; }

        public static int user_id { get; set; }
        public static int user_cardnumber { get; set; }
        public static string user_name { get; set; }
        public static int user_deviceid { get; set; }
        public static string user_layer { get; set; }

        public static string[] limit_error_list { get; set; } = new string[] { "x_at_limit+", "x_at_limit-", "y_at_limit+", "y_at_limit-", "z_at_limit+", "z_at_limit-" };
        public static int x_position { get; set; }
        public static int y_position { get; set; }
        public static int z_position { get; set; }
        public static bool limit_reached { get; set; } = false;
        public static bool needle_table_opened { get; set; } = false;
        public static bool machine_parked { get; set; } = false;
        public static bool machine_led_on { get; set; } = false;
        public static bool table_led_on { get; set; } = false;

        public static int x_speed { get; set; }
        public static int y_speed { get; set; }
        public static int z_speed { get; set; }
        public static int w_speed { get; set; }

        public static int x_accel { get; set; }
        public static int y_accel { get; set; }
        public static int z_accel { get; set; }
        public static int w_accel { get; set; }

        public static int x_offset { get; set; }
        public static int y_offset { get; set; }
        public static int z_offset { get; set; }
        public static int w_offset { get; set; }

        public static int x_plus { get; set; }
        public static int y_plus { get; set; }
        public static int z_plus { get; set; }
        public static int w_plus { get; set; }

        public MainView()
        {
            this.Hide();           
            Thread thread = new Thread(new ThreadStart(Loading));
            thread.Start();
            SplashScreenView.loading_status = "InitializeComponent";
            InitializeComponent();
            SetInitalLanguage();
            UpdateLanguageMenus();
            SplashScreenView.loading_status = "GettingPOCollection";
            POListString = Get_POlist();
            SplashScreenView.loading_status = "POGettingSuccess";
            Thread.Sleep(2000);
            SplashScreenView.loading_status = "CheckForDatabaseConnection";
            bool status = CheckForDatabaseConnection();
            for (int i = 0; i <= 500; i++) Thread.Sleep(10);
            int count = 0;
            while (true)
            {
                if (count == 1)
                {
                    SplashScreenView.closeme = true;
                    /*   thread.Abort();*/
                    this.TopMost = true;
                    switch (MessageBox.Show(this, "Check your connection to datatabase and try againt later.", "Error: commmunication", MessageBoxButtons.OK))
                    {
                        case DialogResult.OK:
                            break;
                    }
                    this.Close();
                    System.Windows.Forms.Application.Exit();
                    Environment.Exit(0);
                }
                if (status)
                {
                    SplashScreenView.closeme = true;
                    /*  thread.Abort();*/
                    this.Show();
                    this.TopMost = true;
                    break;
                }
                else
                {
                    count++;
                    status = CheckForDatabaseConnection();
                }
            }
            InitializeTimer();
        }

        public event EventHandler GetNeedleClicked;
        public event EventHandler AddNeedleButtonCLicked;
        public event EventHandler NeedleInfoClicked;
        public event EventHandler RecycleBinClicked;
        public event EventHandler DeviceSettingClicked;
        public event EventHandler CameraSettingClicked;
        public event EventHandler MainViewLoaded;
        public event EventHandler ConnectDeviceButtonClicked;
        public event EventHandler ConnectDeviceToolStripMenuClicked;
        public event EventHandler ExitToolStripMenuClicked;
        public event EventHandler EnglishToolStripMenuClicked;
        public event EventHandler VietnameseToolStripMenuClicked;
        public event EventHandler ChineseToolStripMenuClicked;
        public event EventHandler UIcultureChanged;

        private void MainView_Load(object sender, EventArgs e)
        {
            MainViewLoaded(this, EventArgs.Empty);
        }
        private void GetNeedleButton_Click(object sender, EventArgs e)
        {
            GetNeedleClicked(this, EventArgs.Empty);
        }
        private void AddNeedleButton_Click(object sender, EventArgs e)
        {
            AddNeedleButtonCLicked(this, EventArgs.Empty);
        }
        private void NeedleInfoButton_Click(object sender, EventArgs e)
        {
            NeedleInfoClicked(this, EventArgs.Empty);
        }
        private void RecycleBinButton_Click(object sender, EventArgs e)
        {
            RecycleBinClicked(this, EventArgs.Empty);
        }
        private void DeviceSettingButton_Click(object sender, EventArgs e)
        {
            DeviceSettingClicked(this, EventArgs.Empty);
        }
        private void CameraSettingButton_Click(object sender, EventArgs e)
        {
            CameraSettingClicked(this, EventArgs.Empty);
        }
        private void ConnectDeviceButton_Click(object sender, EventArgs e)
        {
            ConnectDeviceButtonClicked(this, EventArgs.Empty);
        }
        private void ConnectDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDeviceToolStripMenuClicked(this, EventArgs.Empty);
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitToolStripMenuClicked(this, EventArgs.Empty);
        }
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnglishToolStripMenuClicked(this, EventArgs.Empty);
        }
        private void VietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VietnameseToolStripMenuClicked(this, EventArgs.Empty);
        }
        private void ChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChineseToolStripMenuClicked(this, EventArgs.Empty);
        }
        private void CultureManagerMainForm_UICultureChanged(CultureInfo newCulture)
        {
            UIcultureChanged(this, EventArgs.Empty);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 500;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (needlepickingviewloaded_status || addneedleviewloaded_status || needleinfoviewloaded_status || recyclebinviewloaded_status || camerasettingviewloaded_status || devicesettingviewloaded_status)
            {
                return;
            }
            else
            {
                if (!this.Visible)
                {
                    if (last_view == "AddNeedleView")
                    {
                        if (listbox_string == "close_success")
                        {
                            Timer1.Stop();
                            close_waiting = true;
                            switch (MessageBox.Show(this, "Needle table close success", "Error: Machine", MessageBoxButtons.OK))
                            {
                                case DialogResult.OK:
                                    this.Visible = true;
                                    Timer1.Start();
                                    break;
                            }
                            listbox_string = null;
                        }
                        if (listbox_string == "close_fail")
                        {
                            Timer1.Stop();
                            close_waiting = false;

                            switch (MessageBox.Show(this, "Needle table close fail", "Error: Machine", MessageBoxButtons.OK))
                            {
                                case DialogResult.OK:
                                    this.Visible = true;
                                    Timer1.Start();
                                    break;
                            }
                            listbox_string = null;
                        }
                    }
                    if (last_view == "NeedlePickingView")
                    {
                        this.Visible = true;
                        last_view = null;
                    }
                    if (last_view == "NeedleInfoView")
                    {
                        this.Visible = true;
                        last_view = null;
                    }
                    if (last_view == "RecycleBinView")
                    {
                        this.Visible = true;
                        last_view = null;
                    }
                    if (last_view == "CameraSettingView")
                    {
                        this.Visible = true;
                        last_view = null;
                    }
                    if (last_view == "DeviceSettingView")
                    {
                        this.Visible = true;
                        last_view = null;
                    }
                }
            }
            if (listbox_string == "table_closed")
            {
                Timer1.Stop();
                Reply_Buffer("<led2:1><table:1>");
                this.Visible = false;
                new WaitingProcessView().Show();
                listbox_string = null;
                Timer1.Start();
            }
            if (listbox_string == "table_opened")
            {
                Timer1.Stop();
                switch (MessageBox.Show(this, "Needle table is still open", "Error: Machine", MessageBoxButtons.OK))
                {
                    case DialogResult.OK:
                        Timer1.Start();
                        break;
                }
                listbox_string = null;

            }
            if (listbox_string == "table_error")
            {
                Timer1.Stop();
                switch (MessageBox.Show(this, "Needle table is in right place", "Error: Machine", MessageBoxButtons.OK))
                {
                    case DialogResult.OK:
                        Timer1.Start();
                        break;
                }
                listbox_string = null;
            }
            if (listbox_string == "open_success")
            {
                Timer1.Stop();
                if (showaddneedleview_flag)
                {
                    close_waiting = true;
                    new AddNeedleView(this).Show();
                    showaddneedleview_flag = false;
                    listbox_string = null;
                }
                Timer1.Start();
            }
            if (listbox_string == "open_fail")
            {
                Timer1.Stop();
                Reply_Buffer("<table:0><led2:0>");
                close_waiting = true;
                switch (MessageBox.Show(this, "Needle table open failed", "Error: Machine", MessageBoxButtons.OK))
                {
                    case DialogResult.OK:
                        Timer1.Start();
                        break;
                }
                this.Visible = true;
                listbox_string = null;
            }
            if (listbox_string == "load_success")
            {
                close_waiting = true;
                new DeviceSettingView(this).Show();
                listbox_string = null;
            }
            if (loaddevicesetting_withoutconnection)
            {
                if (showdevicesettingview_flag)
                {
                    new DeviceSettingView(this).Show();
                    showdevicesettingview_flag = false;
                }
            }
            if (showneedlepickingview_flag)
            {
                new NeedlePickingView(this).Show();
                showneedlepickingview_flag = false;
            }
            if (showrecyclebinview_flag)
            {
                new RecycleBinView(this).Show();
                showrecyclebinview_flag = false;
            }
            if (showcamerasettingview_flag)
            {
                new CameraSettingView(this).Show();
                showcamerasettingview_flag = false;
            }
            if (_deviceConnection)
            {
                bool _cableConnection = PingHost(NeedleController.Properties.Settings.Default.local_ip);
                while (true)
                {
                    if (!_cableConnection)
                    {
                        Timer1.Stop();
                        ConnectDeviceButton.Enabled = true;
                        ConnectDeviceToolStripMenuItem.Enabled = true;
                        ConnectedStatusLabel.Visible = false;
                        DisconnectedStatusLabel.Visible = true;
                        _connected = false;
                        Logger.Error("Lost connection from " + device_name, device_id);
                        switch (MessageBox.Show(this, "Check connection to device again", "Error: Communication", MessageBoxButtons.RetryCancel))
                        {
                            case DialogResult.Retry:
                                _cableConnection = PingHost(NeedleController.Properties.Settings.Default.local_ip);
                                break;
                            case DialogResult.Cancel:
                                this.Close();
                                System.Windows.Forms.Application.Exit();
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        if (!_connected)
                        {
                            Logger.Information("Device " + device_name + " from " + building_name + " is connected", device_id);
                            DisconnectedStatusLabel.Visible = false;
                            ConnectedStatusLabel.Visible = true;
                            ConnectDeviceButton.Enabled = false;
                            ConnectDeviceToolStripMenuItem.Enabled = false;
                            Timer1.Start();
                            _connected = true;
                        }
                        break;
                    }
                }
                bool database_conneciton = CheckForDatabaseConnection();
                while (true)
                {
                    if (!database_conneciton)
                    {
                        _databaseconnected = false;
                        Logger.Error("Lost connection from database", device_id);
                        Timer1.Stop();
                        switch (MessageBox.Show(this, "Check connection to database again", "Error: Communication", MessageBoxButtons.RetryCancel))
                        {
                            //Stay on this form
                            case DialogResult.Retry:
                                database_conneciton = CheckForDatabaseConnection();
                                break;
                            case DialogResult.Cancel:
                                this.Close();
                                System.Windows.Forms.Application.Exit();
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        if (!_databaseconnected)
                        {
                            _databaseconnected = true;
                            Logger.Information("Device " + device_name + " from " + building_name + " is connected to database", device_id);
                            Timer1.Start();
                        }
                        break;
                    }
                }
            }
        }
        private void SetInitalLanguage()
        {
            CultureManager.ApplicationUICulture = new CultureInfo(NeedleController.Properties.Settings.Default.language_set);
        }
        private void CheckParameterThread()
        {
            if (_message == null)
            {
                return;
            }
            para_name = Getparametername_frombuffer(_message, "<", ":");
            para_value_str = Getparametervalue_frombuffer(_message, ":", ">");
            if (para_name == "buildingname")
            {
                if (building_name != para_value_str)
                {
                    building_name = para_value_str;
                    Properties.Settings.Default.buildingname = building_name;
                    Properties.Settings.Default.Save();
                }
            }
            if (para_name == "deviceid")
            {
                if (device_id != int.Parse(para_value_str))
                {
                    device_id = int.Parse(para_value_str);
                    Properties.Settings.Default.deviceid = device_id;
                    var device = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(device_id);
                    building_id = device.BuildingID;
                    Properties.Settings.Default.buildingid = building_id;
                    Properties.Settings.Default.Save();
                }
            }
            if (para_name == "devicename")
            {
                if (device_name != para_value_str)
                {
                    device_name = para_value_str;
                    Properties.Settings.Default.devicename = device_name;
                    Properties.Settings.Default.Save();
                }
            }
            if (para_name == "msg")
            {
                listbox_string = para_value_str;
            }
            if (para_name == "status")
            {
                needlesupplied_status = int.Parse(para_value_str);
            }
            if (para_name == "xpos")
            {
                x_position = int.Parse(para_value_str);
            }
            if (para_name == "ypos")
            {
                y_position = int.Parse(para_value_str);
            }
            if (para_name == "zpos")
            {
                z_position = int.Parse(para_value_str);
            }
            if (para_name == "table")
            {
                needle_table_opened = Convert.ToBoolean(int.Parse(para_value_str));
            }
            if (para_name == "park")
            {
                machine_parked = Convert.ToBoolean(int.Parse(para_value_str));
            }
            if (para_name == "led1")
            {
                machine_led_on = Convert.ToBoolean(int.Parse(para_value_str));
            }
            if (para_name == "led2")
            {
                table_led_on = Convert.ToBoolean(int.Parse(para_value_str));
            }
            ///
            if (para_name == "speedx")
            {
                x_speed = int.Parse(para_value_str);
            }
            if (para_name == "speedy")
            {
                y_speed = int.Parse(para_value_str);
            }
            if (para_name == "speedz")
            {
                z_speed = int.Parse(para_value_str);
            }
            if (para_name == "speedw")
            {
                w_speed = int.Parse(para_value_str);
            }
            ///
            if (para_name == "accelx")
            {
                x_accel = int.Parse(para_value_str);
            }
            if (para_name == "accely")
            {
                y_accel = int.Parse(para_value_str);
            }
            if (para_name == "accelz")
            {
                z_accel = int.Parse(para_value_str);
            }
            if (para_name == "accelw")
            {
                w_accel = int.Parse(para_value_str);
            }
            ///
            if (para_name == "offsetx")
            {
                x_offset = int.Parse(para_value_str);
            }
            if (para_name == "offsety")
            {
                y_offset = int.Parse(para_value_str);
            }
            if (para_name == "offsetz")
            {
                z_offset = int.Parse(para_value_str);
            }
            if (para_name == "offsetw")
            {
                w_offset = int.Parse(para_value_str);
            }
            ///
            if (para_name == "plusx")
            {
                x_plus = int.Parse(para_value_str);
            }
            if (para_name == "plusy")
            {
                y_plus = int.Parse(para_value_str);
            }
            if (para_name == "plusz")
            {
                z_plus = int.Parse(para_value_str);
            }
            if (para_name == "plusw")
            {
                w_plus = int.Parse(para_value_str);
            }

        }
        private string Getparametername_frombuffer(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        private string Getparametervalue_frombuffer(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        public void ShowNeedlePickingView()
        {
            if (_deviceConnection)
            {
                using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
                {
                    checkingView.ShowDialog();
                }
                if (CardCheckingDetected)
                {
                    if (_confirmRFID)
                    {
                        if (user_layer == "dev")
                        {
                            this.Visible = false;
                            new WaitingProcessView().Show();
                            /*new NeedlePickingView(this).Show();*/
                            showneedlepickingview_flag = true;
                        }
                        else
                        {
                            if (device_id == user_deviceid)
                            {
                                if (user_layer == "admin" || user_layer == "user")
                                {
                                    this.Visible = false;
                                    new WaitingProcessView().Show();
                                    /*new NeedlePickingView(this).Show();*/
                                    showneedlepickingview_flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("You need permission to confirm this");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your ID card is not acceptable in this device");
                            }
                        }
                        _confirmRFID = false;

                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Card");
                    }
                    CardCheckingDetected = false;
                }
            }
            else
            {
                MessageBox.Show("Connect to device first");
            }
        }
        public void ShowAddNeedleView()
        {
            if (_deviceConnection)
            {
                if (!showaddneedleview_flag)
                {
                    using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
                    {
                        checkingView.ShowDialog();
                    }
                    if (CardCheckingDetected)
                    {
                        if (_confirmRFID)
                        {
                            if (user_layer == "dev")
                            {
                                Reply_Buffer("<get:wstatus>");
                                showaddneedleview_flag = true;
                            }
                            else
                            {
                                if (device_id == user_deviceid)
                                {
                                    if (user_layer == "admin")
                                    {
                                        Reply_Buffer("<get:wstatus>");
                                        showaddneedleview_flag = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You need adminstrator permission to access this funtion");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Your ID card is not acceptable in this device");
                                }
                            }
                            _confirmRFID = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID Card");
                        }
                        CardCheckingDetected = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Connect to device first");
            }
        }
        public void ShowNeedleInfoView()
        {
            this.Visible = false;
            new NeedleInfoView(this).Show();
        }
        public void ShowRecycleBinView()
        {
            if (_deviceConnection)
            {
                using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
                {
                    checkingView.ShowDialog();
                }
                if (CardCheckingDetected)
                {
                    if (_confirmRFID)
                    {
                        if (user_layer == "dev")
                        {
                            this.Visible = false;
                            new WaitingProcessView().Show();
                            showrecyclebinview_flag = true;
                            /*new RecycleBinView(this).Show();*/
                        }
                        else
                        {
                            if (device_id == user_deviceid)
                            {
                                if (user_layer == "admin")
                                {
                                    this.Visible = false;
                                    new WaitingProcessView().Show();
                                    showrecyclebinview_flag = true;
                                    /*new RecycleBinView(this).Show();*/
                                }
                                else
                                {
                                    MessageBox.Show("You need adminstrator permission to access this funtion");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your ID card is not acceptable in this device");
                            }
                        }
                        _confirmRFID = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Card");
                    }
                    CardCheckingDetected = false;
                }
        }
            else
            {
                MessageBox.Show("Connect to device first");
            }
}
        public void ShowDeviceSettingView()
        {
            using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
            {
                checkingView.ShowDialog();
            }
            if (CardCheckingDetected)
            {
                if (_confirmRFID)
                {
                    if (user_layer == "dev")
                    {
                        if (_deviceConnection)
                        {
                            using (UdpClient udpClient = new UdpClient())
                            {
                                try
                                {
                                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                                    Byte[] senddata = Encoding.ASCII.GetBytes("<get:xpos><get:ypos><get:zpos><get:table><get:parking><get:led1><get:led2>");
                                    Byte[] senddata1 = Encoding.ASCII.GetBytes("<speed:x><speed:y><speed:z><speed:w>");
                                    Byte[] senddata2 = Encoding.ASCII.GetBytes("<accel:x><accel:y><accel:z><accel:w>");
                                    Byte[] senddata3 = Encoding.ASCII.GetBytes("<offset:x><offset:y><offset:z><offset:w>");
                                    Byte[] senddata4 = Encoding.ASCII.GetBytes("<plus:x><plus:y><plus:z><plus:w>");
                                    Byte[] senddata5 = Encoding.ASCII.GetBytes("<get:load>");
                                    udpClient.Send(senddata, senddata.Length);
                                    udpClient.Send(senddata1, senddata1.Length);
                                    udpClient.Send(senddata2, senddata2.Length);
                                    udpClient.Send(senddata3, senddata3.Length);
                                    udpClient.Send(senddata4, senddata4.Length);
                                    udpClient.Send(senddata5, senddata5.Length);
                                }
                                catch (Exception i)
                                {
                                    Console.WriteLine(i.ToString());
                                }
                            }
                            this.Visible = false;
                            new WaitingProcessView().Show();
                        }
                        else
                        {
                            this.Visible = false;
                            showdevicesettingview_flag = true;
                            loaddevicesetting_withoutconnection = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You need adminstrator permission to access this funtion");
                    }
                    _confirmRFID = false;
                }
                else
                {
                    MessageBox.Show("Invalid ID Card");
                }
                CardCheckingDetected = false;
            }
        }
        public void ShowCameraSettingView()
        {
            using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
            {
                checkingView.ShowDialog();
            }
            if (CardCheckingDetected)
            {
                if (_confirmRFID)
                {
                    if (user_layer == "dev")
                    {
                        this.Visible = false;
                        new WaitingProcessView().Show();
                        showcamerasettingview_flag = true;
                    }
                    else
                    {
                        MessageBox.Show("You need adminstrator permission to access this funtion");
                    }
                    _confirmRFID = false;
                }
                else
                {
                    MessageBox.Show("Invalid ID Card");
                }
                CardCheckingDetected = false;
            }
        }
        public void MainViewLoad()
        {
            this.TopMost = false;
            countCamera = opencv.countCamera();
            device_id = Properties.Settings.Default.deviceid;
            device_name = Properties.Settings.Default.devicename;
            building_id = Properties.Settings.Default.buildingid;
            building_name = Properties.Settings.Default.buildingname;

        }
        public void ConnectDevice()
        {
            start_progressbar(progressBar1);
            bool _cableConnection = PingHost(NeedleController.Properties.Settings.Default.local_ip);
            if (_cableConnection)
            {
                while (true)
                {
                    bool status = EF_CONFIG.DataTransform.DeviceBase.Update_OnlineStatus(device_id, "ONLINE");
                    if (status)
                    {
                        break;
                    }
                }
                Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
                thdUDPServer.IsBackground = true;
                thdUDPServer.Start();
                Reply_Buffer("<reset:1>");
            }
            else
            {
                MessageBox.Show("Recheck device ip or cable connection");
            }
        }
        public void CloseForm()
        {
            if (device_id == 0)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                last_view = this.Name;
                mainview_close = true;
                using (WaitingProcessView waitingProcessView = new WaitingProcessView())
                {
                    waitingProcessView.ShowDialog();
                }
                if (!post_onlinestatus)
                {
                    return;
                }
                this.Close();
                System.Windows.Forms.Application.Exit();
                Environment.Exit(0);
            }

        }
        public void SetLanguageEnglish()
        {
            CultureManager.ApplicationUICulture = new CultureInfo("en-US");
            NeedleController.Properties.Settings.Default.language_set = "en-US";
            NeedleController.Properties.Settings.Default.Save();
        }
        public void SetLanguageVietnamese()
        {
            CultureManager.ApplicationUICulture = new CultureInfo("vi-VN");
            NeedleController.Properties.Settings.Default.language_set = "vi-VN";
            NeedleController.Properties.Settings.Default.Save();
        }
        public void SetLanguageChinese()
        {
            CultureManager.ApplicationUICulture = new CultureInfo("zh-TW");
            NeedleController.Properties.Settings.Default.language_set = "zh-TW";
            NeedleController.Properties.Settings.Default.Save();
        }
        public void UpdateLanguageMenus()
        {
            CultureInfo culture = CultureManager.ApplicationUICulture;
            EnglishToolStripMenuItem.Checked = (culture.TwoLetterISOLanguageName == "en");
            VietnameseToolStripMenuItem.Checked = (culture.TwoLetterISOLanguageName == "vi");
            ChineseToolStripMenuItem.Checked = (culture.TwoLetterISOLanguageName == "zh");

        }
        private bool CheckFor_Form(string FormName)
        {
            try
            {
                FormCollection fc = System.Windows.Forms.Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm.Name == FormName)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public void ServerThread()
        {
            try
            {
                using (UdpClient udpClient = new UdpClient(NeedleController.Properties.Settings.Default.port))
                {
                    while (true)
                    {
                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(NeedleController.Properties.Settings.Default.local_ip), NeedleController.Properties.Settings.Default.port);
                        Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                        string returnData = Encoding.ASCII.GetString(receiveBytes);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            string msg = returnData;
                            if (!_connected)
                            {
                                Logger.Debug("Get buffer " + msg + " from ip " + NeedleController.Properties.Settings.Default.local_ip + " .Port " + NeedleController.Properties.Settings.Default.port);
                            }
                            else
                            {
                                Logger.Debug("Get buffer " + msg + " from device " + device_name, device_id);
                            }
                            _message = msg;
                            CheckParameterThread();
                            SetString_message();
                            if (returnData == "<msg:setting_success>")
                            {
                                _deviceConnection = true;
                                BuildingNameLabel.Text = building_name;
                                DeviceNameLabel.Text = device_name;
                                stop_progressbar(progressBar1);
                            }
                        }));
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public bool PingHost(string nameOrAddress)
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
        public void Reply_Buffer(string buffer)
        {
            if (!_connected)
            {
                Logger.Debug("Put buffer " + buffer + " to ip " + NeedleController.Properties.Settings.Default.local_ip + " .Port " + NeedleController.Properties.Settings.Default.port);

            }
            else
            {
                Logger.Debug("Put buffer " + buffer + " to device " + device_name, device_id);
            }
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    replied_buffer = buffer;
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes(replied_buffer);
                    udpClient.Send(senddata, senddata.Length);

                }
                catch (Exception e)
                {
                    Logger.Error(e.Message, device_id);
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
        }
        public bool CheckOpenedForm(string name)
        {
            FormCollection form = System.Windows.Forms.Application.OpenForms;
            foreach (Form form1 in form)
            {
                if (form1.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void SetString_message()
        {
            if (lastlistbox_string == listbox_string || listbox_string == null)
            {
                return;
            }
            lastlistbox_string = listbox_string;
            listBox1.Items.Add(DateTime.Now.ToString("yy/MM/dd HH:mm:ss ") + ":" + listbox_string.ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = -1;
        }
        public void Loading()
        {
            try
            {
                using (SplashScreenView splashScreen = new SplashScreenView())
                {
                    splashScreen.ShowDialog();
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
            /*try
            {
                System.Windows.Forms.Application.Run(new SplashScreenView());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
        List<string> Get_POlist()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(Filepath);
                List<ExcelFile> excelFiles = new List<ExcelFile>();
                FileInfo[] Files = d.GetFiles("A06-Schedule_Report *.xlsx");
                System.Data.DataTable ExcelPOList = new System.Data.DataTable();
                foreach (FileInfo file in Files)
                {
                    string _name = file.Name;
                    string[] date = _name.Split(new string[] { "A06-Schedule_Report " }, StringSplitOptions.None);
                    string datestring = string.Concat(date);
                    string[] datetime = datestring.Split(new string[] { ".xlsx" }, StringSplitOptions.None);
                    string datetimestring = string.Concat(datetime);
                    string resultString = null;
                    Regex regexObj = new Regex(@"[^\d]");
                    resultString = regexObj.Replace(datetimestring, "");
                    DateTime _date = DateTime.ParseExact(resultString, "MMddyyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);
                    ExcelFile excelfile = new ExcelFile()
                    {
                        FileName = _name,
                        Date = _date
                    };
                    excelFiles.Add(excelfile);
                }
                ExcelFiles_list = excelFiles;
                ExcelFile ex = ExcelFiles_list.OrderByDescending(i => i.Date).First();
                ExcelPOList = Import(Filepath + "\\" + ex.FileName);
                string[] POListString_array = ExcelPOList.AsEnumerable().Select<DataRow, string>(x => x.Field<string>("COLUMN1")).ToArray();
                var item = new List<string>();
                for (int i = 0; i < POListString_array.Length; i++)
                {
                    item.Add(POListString_array[i]);
                }
                return item.Distinct().ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public System.Data.DataTable Import(string filename, bool headers = false)
        {
            try
            {
                var _xl = new Microsoft.Office.Interop.Excel.Application();
                var wb = _xl.Workbooks.Open(filename);
                var sheets = wb.Sheets;
                System.Data.DataTable dt = new System.Data.DataTable();
                if (sheets != null && sheets.Count != 0)
                {
                    foreach (var item in sheets)
                    {
                        var sheet = (Microsoft.Office.Interop.Excel.Worksheet)item;
                        if (sheet.Name == "ASL")
                        {
                            dt = new System.Data.DataTable();
                            if (sheet != null)
                            {
                                var ColumnCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Rows[1, Type.Missing]).Columns.Count;
                                var rowCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Columns[1, Type.Missing]).Rows.Count;

                                var cell = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[4, 9];
                                var column = new DataColumn(headers ? cell.Value : string.Empty);
                                dt.Columns.Add(column);

                                for (int i = 4; i < rowCount; i++)
                                {
                                    var r = dt.NewRow();
                                    var cell1 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[i + 1 + (headers ? 1 : 0), 9];
                                    r[0] = cell1.Value;
                                    dt.Rows.Add(r);
                                }

                            }
                        }
                    }
                }
                _xl.Quit();
                return dt;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public bool CheckForDatabaseConnection()
        {
            try
            {
                return EF_CONFIG.Extends.SysExtendBase.IsAvailable();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        private void BuildingNameLabel_Click(object sender, EventArgs e)
        {

        }
        public void start_progressbar(ProgressBar progressBar)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 20;
        }
        public void stop_progressbar(ProgressBar progressBar)
        {
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar1.Minimum;
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            try
            {
                using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
                {
                    checkingView.ShowDialog();
                }
                if (CardCheckingDetected)
                {
                    if (_confirmRFID)
                    {
                        if (user_layer == "dev")
                        {
                            this.Visible = false;
                            MessageBox.Show("Funtion is being under development");
                        }
                        else
                        {
                            MessageBox.Show("You need developer permission to access this funtion");
                        }
                        _confirmRFID = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Card");
                    }
                    CardCheckingDetected = false;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
    }
    public class ExcelFile
    {
        public string FileName { get; set; }
        public DateTime Date { get; set; }
    }

}
