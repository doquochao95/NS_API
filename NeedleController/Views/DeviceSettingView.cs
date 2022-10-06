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
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;
using NeedleController.Views.NeedlePickingUCs;
using System.Collections.ObjectModel;
using System.IO;

namespace NeedleController.Views
{
    public partial class DeviceSettingView : MvpForm, IDeviceSettingView
    {
        private static MainView _mainView;
        public static bool cable_connection { get; set; } = false;
        public static bool check_connection { get; set; } = false;
        public static string device_ip { get; set; }


        public DeviceSettingView(MainView mainView)
        {
            InitializeComponent();
            InitializeTimer();
            _mainView = mainView;
        }

        public event EventHandler DeviceSettingViewLoaded;
        public event EventHandler DeviceSettingViewFormClosed;

        private void DeviceSettingView_Load(object sender, EventArgs e)
        {
            DeviceSettingViewLoaded(this, EventArgs.Empty);
        }

        private void DeviceSettingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeviceSettingViewFormClosed(this, EventArgs.Empty);
        }
        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainView.limit_reached)
            {
                timer1.Stop();
                switch (MessageBox.Show(this, "Do you want to retry ?", "Error: Machine " + MainView.listbox_string, MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
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
                        MainView.listbox_string = null;
                        MainView.limit_reached = false;
                        timer1.Start();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;

                }
            }
            if (MainView.listbox_string != null)
            {
                if (MainView.limit_error_list.Any(MainView.listbox_string.Contains))
                {
                    MainView.limit_reached = true;
                }
            }
            if (check_connection)
            {
                if (!_mainView.PingHost(device_ip))
                {
                    cable_connection = false;
                }
                else
                {
                    cable_connection = true;
                }
                check_connection = false;
            }
            if (!MainView.loaddevicesetting_withoutconnection)
            {
                bool _cableConnection = _mainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
                while (true)
                {
                    if (!_cableConnection)
                    {
                        MainView._connected = false;
                        Logger.Error("Lost connection from " + MainView.device_name, MainView.device_id);
                        timer1.Stop();
                        switch (MessageBox.Show(this, "Check connection to device again", "Error: Communication", MessageBoxButtons.RetryCancel))
                        {
                            case DialogResult.Retry:
                                _cableConnection = _mainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
                                break;
                            case DialogResult.Cancel:
                                this.Close();
                                Application.Exit();
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        if (!MainView._connected)
                        {
                            MainView._connected = true;
                            Logger.Information("Device " + MainView.device_name + " from " + MainView.building_name + " is connected", MainView.device_id);
                            timer1.Start();
                        }
                        break;
                    }
                }
            }
        }

        public void Load_DeviceSettingView()
        {
            MainView.devicesettingviewloaded_status = true;
            device_ip = Properties.Settings.Default.local_ip;
        }
        public void Exit_DeviceSettingView()
        {
            MainView.loaddevicesetting_withoutconnection = false;
            MainView.last_view = this.Name;
            MainView.devicesettingviewloaded_status = false;
        }
    }
}
