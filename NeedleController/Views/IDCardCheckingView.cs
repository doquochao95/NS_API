﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Markup;

using NeedleController.Views;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

using System.Resources;
using System.Globalization;
using Infralution.Localization;

namespace NeedleController.Views
{
    public partial class IDCardCheckingView : MetroFramework.Forms.MetroForm
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>();
        private string _lastView ;
        public IDCardCheckingView(string lastview)
        {
            this.TopMost = true;
            InitializeComponent();
            SetLanguage();
            this.KeyPress += new KeyPressEventHandler(RFID_KeyPress);
            _lastView = lastview;
            ResourceManager myManager = new ResourceManager(typeof(IDCardCheckingView));
            if (_lastView == "RecycleBinView" || _lastView == "MachineProcessView")
            {
                RFIDstatusLabel.Text = myManager.GetString("qcstatuslabel");
            }
        }
       
        private void RFID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            if (_barcode.Count == 10)
            {
                string msg = new String(_barcode.ToArray());
                NS_Staffs flag = StaffBase.Check_User(msg);
                if (flag!=null)
                {
                    NS_Staffs nS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_UserWithRfid(msg);
                    if (nS_Staffs != null)
                    {
                        if(_lastView=="RecycleBinView")
                        {
                            RecycleBinView.user_id = nS_Staffs.StaffID;
                            RecycleBinView.user_deviceid = nS_Staffs.DeviceID;
                            RecycleBinView.user_layer = nS_Staffs.UserLayer;
                            RecycleBinView._RFIDconfirm = true;
                        }
                        else if (_lastView == "MachineProcessView")
                        {
                            MachineProcessView.user_id = nS_Staffs.StaffID;
                            MachineProcessView.user_deviceid = nS_Staffs.DeviceID;
                            MachineProcessView.user_layer = nS_Staffs.UserLayer;
                            MachineProcessView._RFIDconfirm = true;
                        }
                        else
                        {
                            MainView.user_id = nS_Staffs.StaffID;
                            MainView.user_name = nS_Staffs.StaffName;
                            MainView.user_cardnumber = nS_Staffs.CardNumber;
                            MainView.user_deviceid = nS_Staffs.DeviceID;
                            MainView.user_layer = nS_Staffs.UserLayer;
                            MainView._confirmRFID = true;
                        }                       
                    }
                }
                else
                {
                    if (_lastView == "RecycleBinView")
                    {
                        RecycleBinView._RFIDconfirm = false;

                    }
                    else if (_lastView == "MachineProcessView")
                    {
                        MachineProcessView._RFIDconfirm = false;
                    }
                    else
                    {
                        MainView._confirmRFID = false;
                    }                     
                }
                MainView.CardCheckingDetected = true;
                _barcode.Clear();
                this.Hide();
                this.Close();
            }
        }
        public enum MapType : uint
        {
            MAPVK_VK_TO_VSC = 0x0,
            MAPVK_VSC_TO_VK = 0x1,
            MAPVK_VK_TO_CHAR = 0x2,
            MAPVK_VSC_TO_VK_EX = 0x3,
        }
        [DllImport("user32.dll")]
        public static extern int ToUnicode(
          uint wVirtKey,
          uint wScanCode,
          byte[] lpKeyState,
          [Out, MarshalAs(UnmanagedType.LPWStr, SizeParamIndex = 4)]
            StringBuilder pwszBuff,
          int cchBuff,
          uint wFlags);

        [DllImport("user32.dll")]
        public static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, MapType uMapType);
        private void SetLanguage()
        {
            CultureManager.ApplicationUICulture = new CultureInfo(NeedleController.Properties.Settings.Default.language_set);
        }

        private void RFIDstatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
