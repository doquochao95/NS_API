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
    public class LoadingViewModel : BaseViewModel
    {
        private bool _IsLoadedDone;
        public bool IsLoadedDone
        {
            get
            {
                return _IsLoadedDone;
            }
            set
            {
                _IsLoadedDone = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoadLoadingWindowCommand { get; set; }

        public LoadingViewModel ()
        {
            LoadLoadingWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { LoadLoadingWindow_Command(p); });
        }
        void LoadLoadingWindow_Command(Window p)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(delegate
            {
                SetAnimatedPreogress(p);
            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start(p);
        }
        void SetAnimatedPreogress(Window window)
        {
            while (true)
            {
                if (IsLoadedDone)
                {
                    Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { window.Close(); }));
                    IsLoadedDone = false;
                    break;
                }
            }
           
        }

    }
}
