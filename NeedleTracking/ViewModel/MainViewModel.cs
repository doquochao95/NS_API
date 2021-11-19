using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.VolatilityUC;
using System.Windows.Media;
using System.Threading;
using NeedleTracking.ViewModel;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using System.Collections.ObjectModel;
using EF_CONFIG.Model;

namespace NeedleTracking.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        
        public bool Isloaded = false;
        public ICommand LoadedMainWindowCommand { get; set; }

        public MainViewModel()
        {
            LoadedMainWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { LoadedWindowCommand(p); });
        }
        void LoadedWindowCommand(Window p)
        {
            if (p == null)
                return;
        }
    }
}
