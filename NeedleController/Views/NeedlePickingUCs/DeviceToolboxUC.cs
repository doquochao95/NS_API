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
using NeedleController.Presenters.NeedlePickingPresenters;

using System.Globalization;
using Infralution.Localization;

namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(DeviceToolboxPresenter))]
    public partial class DeviceToolboxUC : MvpUserControl, IDeviceToolboxUC
    {
        public DeviceToolboxUC()
        {
            InitializeComponent();
            SetLanguage();
            this.UnparkingDeviceButton.Enabled = false;
            this.MachineLightOffButton.Enabled = false;
            this.TableLightOffButton.Enabled = false;
        }


        private void ResetDeviceButton_Click(object sender, EventArgs e)
        {
            ResetDeviceButtonClicked(this, EventArgs.Empty);
            /* ResetDevice();*/
        }
        private void ParkingDeviceButton_Click(object sender, EventArgs e)
        {
            ParkingDeviceButtonClicked(this, EventArgs.Empty);
        }
        private void UnparkingDeviceButton_Click(object sender, EventArgs e)
        {
            UnparkingDeviceButtonClicked(this, EventArgs.Empty);
        }
        private void MachineLightOnButton_Click(object sender, EventArgs e)
        {
            MachineLightOnButtonClicked(this, EventArgs.Empty);
        }
        private void MachineLightOffButton_Click(object sender, EventArgs e)
        {
            MachineLightOffButtonClicked(this, EventArgs.Empty);
        }
        private void TableLightOnButton_Click(object sender, EventArgs e)
        {
            TableLightOnButtonClicked(this, EventArgs.Empty);
        }
        private void TableLightOffButton_Click(object sender, EventArgs e)
        {
            TableLightOffButtonClicked(this, EventArgs.Empty);
        }

        public event EventHandler ResetDeviceButtonClicked;
        public event EventHandler ParkingDeviceButtonClicked;
        public event EventHandler UnparkingDeviceButtonClicked;
        public event EventHandler MachineLightOnButtonClicked;
        public event EventHandler MachineLightOffButtonClicked;
        public event EventHandler TableLightOnButtonClicked;
        public event EventHandler TableLightOffButtonClicked;


        public void ResetDevice()
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
        public void ParkingDevice()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<parking:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            this.ParkingDeviceButton.Enabled = false;
            this.UnparkingDeviceButton.Enabled = true;
        }
        public void UnparkingDevice()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<parking:0>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            this.ParkingDeviceButton.Enabled = true;
            this.UnparkingDeviceButton.Enabled = false;
        }
        public void TurnOnMachineLight()
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
            this.MachineLightOnButton.Enabled=false;
            this.MachineLightOffButton.Enabled=true;
        }
        public void TurnOffMachineLight()
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
            this.MachineLightOnButton.Enabled = true;
            this.MachineLightOffButton.Enabled = false;
        }
        public void TurnOnTableLight()
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
            this.TableLightOnButton.Enabled = false;
            this.TableLightOffButton.Enabled = true;
        }
        public void TurnOffTableLight()
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
            this.TableLightOnButton.Enabled = true;
            this.TableLightOffButton.Enabled = false;
        }

        private void SetLanguage()
        {
            CultureManager.ApplicationUICulture = new CultureInfo(NeedleController.Properties.Settings.Default.language_set);
        }
    }
}
