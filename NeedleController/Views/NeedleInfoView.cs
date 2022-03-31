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
        public static int last_selectedTabindex { get; set; } = 0;
        public static bool adduc_load { get; set; } = false;
        public static bool infouc_load { get; set; } = false;
        public static bool moduc_load { get; set; } = false;


        public NeedleInfoView()
        {
            InitializeComponent();
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

        public void Load_NeedleInfoView()
        {
            MainView.needleinfoviewloaded_status = true;
        }
        public void Exit_NeedleInfoView()
        {
            MainView.needleinfoviewloaded_status = false;
        }
        public void Check_NeedleInformationTabControl()
        {

            switch (NeedleInformationTabControl.SelectedIndex)
            {
                case 0:
                    {
                        infouc_load = false;
                        adduc_load = false;
                        moduc_load = false;

                        last_selectedTabindex = 0;
                        //Your Changes
                        break;
                    }
                case 1:
                    {
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
                                    NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                                }
                                else
                                {
                                    infouc_load = false;
                                    adduc_load = false;
                                    moduc_load = false;
                                    last_selectedTabindex = 1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID Card");
                                NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                            }
                            MainView.card_checkingprogress = false;
                            MainView._confirmRFID = false;
                            break;
                        }
                        else
                        {
                            NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                            MainView._confirmRFID = false;
                            break;
                        }
                    }
                case 2:
                    {
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
                                    NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                                }
                                else
                                {
                                    infouc_load = false;
                                    adduc_load = false;
                                    moduc_load = false;
                                    last_selectedTabindex = 2;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID Card");
                                NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                            }
                            MainView.card_checkingprogress = false;
                            MainView._confirmRFID = false;
                            break;
                        }
                        else
                        {
                            NeedleInformationTabControl.SelectTab(last_selectedTabindex);
                            MainView._confirmRFID = false;
                            break;
                        }
                    }
            }
        }

        

    }
}
