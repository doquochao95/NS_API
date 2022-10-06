using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NeedleTracking.ViewModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;
using NeedleTracking.UserControlUC.RequestUC;
using NeedleTracking.ViewModel.RequestMenuViewModels;

namespace NeedleTracking
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode= new List<char>();

        public LoginWindow()
        {
            InitializeComponent();
           /* this.KeyDown += new KeyEventHandler(this.RFID_KeyPress);*/
        }
        private void RFID_KeyPress(object sender, KeyEventArgs e)
        {
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();
            _barcode.Add(GetCharFromKey(e.Key));
            _lastKeystroke = DateTime.Now;
            
            if (_barcode.Count == 10)
            {
                MainWindow mainWindow = new MainWindow();
                var mainWindowVM = mainWindow.DataContext as MainViewModel;
                string msg = new String(_barcode.ToArray());
                 NS_Staffs staff = StaffBase.Check_User(msg);
                if (staff!=null)
                {
                    mainWindowVM.Selected_NS_Staff = staff;
                    loginWindow.Close();
                    mainWindow.Show();
                }
                else
                {
                    StatusTextblock.Text = "Please recheck your informations";
                    StatusTextblock.Foreground=Brushes.Red;
                }
                _barcode.Clear();
               
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

        public static char GetCharFromKey(Key key)
        {
            char ch = ' ';

            int virtualKey = KeyInterop.VirtualKeyFromKey(key);
            byte[] keyboardState = new byte[256];
            GetKeyboardState(keyboardState);

            uint scanCode = MapVirtualKey((uint)virtualKey, MapType.MAPVK_VK_TO_VSC);
            StringBuilder stringBuilder = new StringBuilder(2);

            int result = ToUnicode((uint)virtualKey, scanCode, keyboardState, stringBuilder, stringBuilder.Capacity, 0);
            switch (result)
            {
                case -1:
                    break;
                case 0:
                    break;
                case 1:
                    {
                        ch = stringBuilder[0];
                        break;
                    }
                default:
                    {
                        ch = stringBuilder[0];
                        break;
                    }
            }
            return ch;
        }

    }
}