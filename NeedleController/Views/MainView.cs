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

namespace NeedleController.Views
{
    public partial class MainView : MvpForm, IMainView
    {
        public static bool _cableConnection;
        public static bool _deviceConnection;
        public static string _message { get; set; }
        public static bool _confirmRFID { get; set; }
        public static string para_name;
        public static string para_value_str;
        public static int device_id { get; set; }
        public static string building_name { get; set; }

        public static string device_name { get; set; }


        public MainView()
        {
            InitializeComponent();
            SetInitalLanguage();
            UpdateLanguageMenus();
            InitializeTimer();
        }
        public event EventHandler GetNeedleClicked;
        public event EventHandler NeedleInfoClicked;
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
        private void NeedleInfoButton_Click(object sender, EventArgs e)
        {
            NeedleInfoClicked(this, EventArgs.Empty);
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
            _cableConnection = PingHost(NeedleController.Properties.Settings.Default.local_ip);

            if (!_cableConnection)
            {
                Timer1.Enabled = false;
                ConnectDeviceButton.Enabled = true;
                ConnectDeviceToolStripMenuItem.Enabled = true;
                ConnectedStatusLabel.Visible = false;
                DisconnectedStatusLabel.Visible = true;
                DialogResult dlr = MessageBox.Show("Check connection again", "Error: Communication", MessageBoxButtons.RetryCancel);
                if (dlr == DialogResult.Retry)
                {
                    Timer1.Enabled = true;
                    return;
                }
            }
            else
            {
                if (_deviceConnection)
                {
                    DisconnectedStatusLabel.Visible = false;
                    ConnectedStatusLabel.Visible = true;
                    ConnectDeviceButton.Enabled = false;
                    ConnectDeviceToolStripMenuItem.Enabled = false;

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
                building_name = para_value_str;
            }
            if (para_name == "deviceid")
            {
                device_id = int.Parse(para_value_str);
            }
            if (para_name == "devicename")
            {
                device_name = para_value_str;
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
                using (RFIDCheckingView checkingView = new RFIDCheckingView())
                {
                    checkingView.ShowDialog();
                }
                SetString_message();
                if (_confirmRFID)
                {

                    Timer1.Enabled = false;
                    new NeedlePickingView(this).ShowDialog();
                    Timer1.Enabled = true;
                    _confirmRFID = false;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Connect to device first");
            }
        }
        public void ShowNeedleInfoView()
        {
            new NeedleInfoView().Show();
        }
        public void ShowDeviceSettingView()
        {
            if (_deviceConnection)
            {
                new DeviceSettingView().Show();
            }
            else
            {
                MessageBox.Show("Connect to device first");
            }
        }
        public void ShowCameraSettingView()
        {
            new CameraSettingView().Show();
        }
        public void MainViewLoad()
        {

        }
        public void ConnectDevice()
        {
            Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
            thdUDPServer.Start();
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
        public void CloseForm()
        {
            this.Close();
            Application.Exit();
            Environment.Exit(0);
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

        public void ServerThread()
        {
            using (UdpClient udpClient = new UdpClient(NeedleController.Properties.Settings.Default.port))
            {
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, NeedleController.Properties.Settings.Default.port);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        string msg = returnData;
                        _message = msg;
                        SetString_message();
                        CheckParameterThread();
                        if (returnData == "<msg:setting_success>")
                        {
                            _deviceConnection = true;
                            BuildingNameLabel.Text = building_name;
                            DeviceNameLabel.Text = device_name;
                        }
                    }));
                }
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
        public void SetString_message()
        {
            listBox1.Items.Add(DateTime.Now.ToString("yy/MM/dd HH:mm:ss ") + ":" + _message.ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = -1;
        }

        private void BuildingNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
