using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace NeedleTracking.ViewModel
{
    public class SplashViewModel : BaseViewModel
    {
        public bool IsSplashed = false;

        public ICommand LoadSplashWindowCommand { get; set; }

        private string _StatusText;
        public string StatusText { get { return _StatusText; } set { _StatusText = value; OnPropertyChanged("StatusText"); } }

        public SplashViewModel()
        {
            LoadSplashWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { LoadedSpWindowCommand(p); });

        }
        void LoadedSpWindowCommand(Window p)
        {
            if (p == null)
                return;
            SendString("Connecting to server");
            Thread thread = new Thread(new ParameterizedThreadStart(delegate
            {
                ServerStatusChecking(p);
            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start(p);
        }

        public void ServerStatusChecking(Window p)
        {
            IsSplashed = IsServerConnected("data source=10.4.2.23;initial catalog=_NEEDLE_SUPPLIER_;persist security info=True;user id=sa;password=shc@1234;multipleactiveresultsets=True;application name=EntityFramework&quot;");
            if (IsSplashed)
            {
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { SendString("Connection success"); }));
                Thread.Sleep(1000);
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { p.Close(); }));
            }
            else
            {
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { SendString("Connection failed"); }));
                Thread.Sleep(1000);
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { p.Close(); }));
                /*Application.Current.Dispatcher.Invoke(() =>
                {
                    p.Close();
                }, System.Windows.Threading.DispatcherPriority.Background);*/
            }
        }

        public void SendString(String str)
        {
            if (str == null)
            {
                return;
            }
            StatusText = str;
        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

    }
}
