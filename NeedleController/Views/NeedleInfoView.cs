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
    public partial class NeedleInfoView : MvpForm, INeedleInfoView
    {

        private readonly MainView _MainView;

        public static int last_selectedTabindex { get; set; } = 0;

        public static bool adduc_load { get; set; } = false;
        public static bool infouc_load { get; set; } = false;
        public static bool moduc_load { get; set; } = false;

        public static string[] PointList { get; set; } = new string[] { "D", "LR", "R", "RG", "S" };
        
        public static string selected_needlepoint { get; set; }
        public static Image selected_needlepointbitmap { get; set; }
        public static byte[] selected_needlepointbitmap_byte { get; set; }
        public static Image selected_needleimagebitmap { get; set; }
        public static byte[] selected_needleimagebitmap_byte { get; set; }

        public static string selected_needleid { get; set; }
        public static string selected_needlename { get; set; }
        public static string selected_needlecode { get; set; }
        public static string selected_needlesize { get; set; }
        public static string selected_needleprice { get; set; }
        public static string selected_needlelength { get; set; }

        public static List<NS_Needles> needle_list { get; set; }

        public NeedleInfoView(MainView mainView)
        {
            InitializeComponent();
            InitializeTimer();
            _MainView = mainView;
            NeedleInformationTabControl.SelectTab(last_selectedTabindex);
        }
        public event EventHandler NeedleInfoViewLoaded;
        public event EventHandler NeedleInfoViewExited;
        public event EventHandler NeedleInformationTabControlSelectedIndexChanged;

        private void NeedleInfoView_Load(object sender, EventArgs e)
        {
            NeedleInfoViewLoaded(this, EventArgs.Empty);
        }

        private void NeedleInfoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            NeedleInfoViewExited(this, EventArgs.Empty);
        }
        private void NeedleInformationTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedleInformationTabControlSelectedIndexChanged(this, EventArgs.Empty);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 500;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool _cableConnection = _MainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
            while (true)
            {
                if (!_cableConnection)
                {
                    Timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to device again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        case DialogResult.Retry:
                            _cableConnection = _MainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
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
                    Timer1.Start();
                    break;
                }
            }

            bool database_conneciton = _MainView.CheckForDatabaseConnection();
            while (true)
            {
                if (!database_conneciton)
                {
                    Timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to database again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        //Stay on this form
                        case DialogResult.Retry:
                            database_conneciton = _MainView.CheckForDatabaseConnection();
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
                    Timer1.Start();
                    break;
                }
            }

        }
        public void Load_NeedleInfoView()
        {
            needle_list = EF_CONFIG.DataTransform.NeedleBase.Get_AllNeedle();
            MainView.last_view = this.Name;
            MainView.needleinfoviewloaded_status = true;

        }
        public void Exit_NeedleInfoView()
        {
            MainView.last_view = this.Name;
            MainView.needleinfoviewloaded_status = false;
        }
        public void Check_NeedleInformationTabControl()
        {

            switch (NeedleInformationTabControl.SelectedIndex)
            {
                case 0:
                    {
                        if (last_selectedTabindex != 0)
                        {
                            using (WaitingProcessView waitingProcessView = new WaitingProcessView())
                            {
                                waitingProcessView.ShowDialog();
                            }
                            if (!MainView.get_onlinestatus)
                            {
                                MessageBox.Show("PLease check ethernet connection and try againt later");

                                return;
                            }
                            Reset_Parameters();
                            last_selectedTabindex = 0;
                        }
                        else
                        {
                            Reset_Parameters();
                            last_selectedTabindex = 0;
                        }
                        //Your Changes
                        break;
                    }
                case 1:
                    {
                        Reset_Parameters();
                        using (IDCardCheckingView checkingView = new IDCardCheckingView())
                        {
                            checkingView.ShowDialog();
                        }
                        if (MainView.card_checkingprogress)
                        {
                            if (MainView._confirmRFID)
                            {
                                if (MainView.user_layer == "user")
                                {
                                    MessageBox.Show("You need adminstrator permission to access this funtion", "Error :", MessageBoxButtons.OK);

                                    NeedleInformationTabControl.SelectTab(0);
                                }
                                else
                                {
                                    using (WaitingProcessView waitingProcessView = new WaitingProcessView())
                                    {
                                        waitingProcessView.ShowDialog();
                                    }
                                    if (!MainView.get_onlinestatus)
                                    {
                                        MessageBox.Show("PLease check ethernet connection and try againt later", "Error :", MessageBoxButtons.OK);
                                        return;
                                    }
                                    Reset_Parameters();
                                    last_selectedTabindex = 1;

                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID card or connection lost", "Error :", MessageBoxButtons.OK);
                                NeedleInformationTabControl.SelectTab(0);
                            }
                        }
                        else
                        {

                            NeedleInformationTabControl.SelectTab(0);
                        }
                        MainView.card_checkingprogress = false;
                        MainView._confirmRFID = false;
                        break;
                    }
                case 2:
                    {
                        Reset_Parameters();
                        using (IDCardCheckingView checkingView = new IDCardCheckingView())
                        {
                            checkingView.ShowDialog();
                        }
                        if (MainView.card_checkingprogress)
                        {
                            if (MainView._confirmRFID)
                            {
                                if (MainView.user_layer == "user")
                                {
                                    MessageBox.Show("You need adminstrator permission to access this funtion");

                                    NeedleInformationTabControl.SelectTab(0);
                                }
                                else
                                {
                                    using (WaitingProcessView waitingProcessView = new WaitingProcessView())
                                    {
                                        waitingProcessView.ShowDialog();
                                    }
                                    if (!MainView.get_onlinestatus)
                                    {
                                        MessageBox.Show("PLease check ethernet connection and try againt later");
                                        return;
                                    }
                                    Reset_Parameters();
                                    last_selectedTabindex = 2;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID Card");

                                NeedleInformationTabControl.SelectTab(0);
                            }
                        }
                        else
                        {

                            NeedleInformationTabControl.SelectTab(0);
                        }
                        MainView.card_checkingprogress = false;
                        MainView._confirmRFID = false;
                        break;
                    }
            }
        }

        private void Reset_Parameters()
        {
            selected_needlepoint = null;
            selected_needlepointbitmap = null;
            selected_needlepointbitmap_byte = null;
            selected_needleimagebitmap = null;
            selected_needleimagebitmap_byte = null;

            selected_needleid = null;
            selected_needlename = null;
            selected_needlecode = null;
            selected_needlesize = null;
            selected_needleprice = null;
            selected_needlelength = null;

            infouc_load = false;
            adduc_load = false;
            moduc_load = false;
        }

    }
}
