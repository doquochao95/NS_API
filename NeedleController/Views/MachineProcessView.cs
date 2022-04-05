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

namespace NeedleController.Views
{
    public partial class MachineProcessView : MvpForm, IMachineProcessView
    {
        public MachineProcessView()
        {
            InitializeComponent();
            InitializeTimer();
        }
        public event EventHandler RetryButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler FailButtonClicked;
        public event EventHandler SuccessButtonClicked;


        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButtonClicked(this, EventArgs.Empty);
        }
        private void RetryButton_Click(object sender, EventArgs e)
        {
            RetryButtonClicked(this, EventArgs.Empty);

        }
        private void FailButton_Click(object sender, EventArgs e)
        {
            FailButtonClicked(this, EventArgs.Empty);

        }
        private void SuccessButton_Click(object sender, EventArgs e)
        {
            SuccessButtonClicked(this, EventArgs.Empty);
        }


        public void RetryGetNeedle()
        {
            NeedlePickingView.retry_flag = true;
            MainView.needlesupplied_status = 2;

            this.Close();
        }
        public void CancelGetNeedle()
        {
            NeedlePickingView.retry_flag = false;
            MainView.needlesupplied_status = 2;
            this.Close();
        }
        public void FeedbackSuccess()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:1>");
                    udpClient.Send(senddata, senddata.Length);
                    NeedlePickingView.needlesupplied_status = true;
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        public void FeedbackFail()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:0>");
                    udpClient.Send(senddata, senddata.Length);
                    NeedlePickingView.needlesupplied_status = true;

                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainView.listbox_string == "check_camera")
            {
                SuccessButton.Visible = true;
                FailButton.Visible = true;
            }
            else
            {
                int status = MainView.needlesupplied_status;
                if (status == 0)
                {
                    RetryButton.Enabled = true;
                    CancelButton.Enabled = true;
                }
                else if (status == 1)
                {
                    bool statuss = EF_CONFIG.DataTransform.StockBase.Update_Stock(MainView.selected_stockid, MainView.device_id, MainView.current_qty - 1);
                    if (statuss)
                    {
                        NeedlePickingView.retry_flag = false;
                        MainView.needlesupplied_status = 2;
                        this.Close();
                    }
                }
            }
        }
    }
}
