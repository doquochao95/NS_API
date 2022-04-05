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
    public partial class WaitingProcessView : MetroFramework.Forms.MetroForm
    {
        public WaitingProcessView()
        {
            this.TopMost = true;
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (MainView.close_waiting)
            {
                this.Close();
                MainView.close_waiting = false;
            }
            if (MainView.last_view == "MainView")
            {
                if (MainView.mainview_close)
                {
                    bool status = EF_CONFIG.DataTransform.DeviceBase.Update_OnlineStatus(MainView.device_id, "OFFLINE");
                    if (status)
                    {
                        Thread.Sleep(3000);
                        MainView.post_onlinestatus = true;
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        MainView.post_onlinestatus = false;
                        this.Close();
                    }
                    MainView.last_view = null;
                }
            }
            else if (MainView.last_view == "NeedleInfoView")
            {
                NeedleInfoView.needle_list = EF_CONFIG.DataTransform.NeedleBase.Get_AllNeedle();
                if (NeedleInfoView.needle_list != null)
                {
                    Thread.Sleep(3000);
                    MainView.get_onlinestatus = true;
                    this.Close();
                }
                else
                {
                    Thread.Sleep(3000);
                    MainView.get_onlinestatus = false;
                    this.Close();
                }
                MainView.last_view = null;
            }
        }
    }
}
