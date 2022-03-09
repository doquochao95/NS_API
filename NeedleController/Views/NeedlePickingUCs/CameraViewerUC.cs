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

namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(CameraViewerPresenter))]
    public partial class CameraViewerUC : MvpUserControl, ICameraViewerUC
    {
        public CameraViewerUC()
        {
            InitializeComponent();
        }

        public event EventHandler SuccessButtonClicked;
        public event EventHandler FailButtonClicked;

        private void SuccessButton_Click(object sender, EventArgs e)
        {
            SuccessButtonClicked(this, EventArgs.Empty);
        }
        private void FailButton_Click(object sender, EventArgs e)
        {
            FailButtonClicked(this, EventArgs.Empty);
        }

        public void FeedbackSuccess()
        {
            try
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    try
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<camera:1>");
                        udpClient.Send(senddata, senddata.Length);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void FeedbackFail()
        {
            try
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    try
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<camera:0>");
                        udpClient.Send(senddata, senddata.Length);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
