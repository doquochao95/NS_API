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

using WinFormsMvp.Forms;
using System.Net.NetworkInformation;

namespace NeedleController.Views
{
    public partial class MainView : MvpForm, IMainView
    {
        public static bool _cableConnection;
        public static bool _deviceConnection;
        public static string _message { get; set; }
        public static bool _confirmRFID { get; set; }

        public MainView()
        {
            InitializeComponent();
            InitializeTimer();
        }
        public event EventHandler GetNeedleClicked;
        public event EventHandler NeedleInfoClicked;
        public event EventHandler DeviceSettingClicked;
        public event EventHandler CameraSettingClicked;
        public event EventHandler MainViewLoaded;
        public event EventHandler ConnectDeviceButtonClicked;

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
                StatusLabel.Text = "Disconnected";
                StatusLabel.ForeColor = System.Drawing.Color.Red;
                DialogResult dlr = MessageBox.Show("Please to check connection again", "Communication Error", MessageBoxButtons.RetryCancel);
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
                    ConnectDeviceButton.Enabled = false;
                    StatusLabel.Text = "Connected";
                    StatusLabel.ForeColor = System.Drawing.Color.Green;
                }
            }
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
                    new NeedlePickingView().Show();
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

        public void ServerThread()
        {
            UdpClient udpClient = new UdpClient(NeedleController.Properties.Settings.Default.port);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, NeedleController.Properties.Settings.Default.port);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                this.Invoke(new MethodInvoker(delegate ()
                {
                    _message=returnData;
                    SetString_message();
                    if (returnData == "<msg:setting_success>")
                    {
                        _deviceConnection = true;
                    }
                }));

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
    }
}
