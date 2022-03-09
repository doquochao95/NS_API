using System;
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
using System.Resources;
using System.Globalization;
using Infralution.Localization;

namespace NeedleController.Views
{
    public partial class RFIDCheckingView : Form
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>();

        public RFIDCheckingView()
        {
            InitializeComponent();
            SetLanguage();
            this.KeyPress += new KeyPressEventHandler(RFID_KeyPress);
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
                bool flag = StaffBase.Check_User(msg);
                if (flag)
                {
                    MainView._message = "Confirmed Success";
                    MainView._confirmRFID=true;
                }
                else
                {
                    MainView._message = "Invalid ID Card";
                    MainView._confirmRFID = false;
                }
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
        private void SetLanguage ()
        {
            CultureManager.ApplicationUICulture = new CultureInfo(NeedleController.Properties.Settings.Default.language_set);
        }
    }
}
