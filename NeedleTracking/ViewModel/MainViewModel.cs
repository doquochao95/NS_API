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
using NeedleTracking.UserControlUC.RequestUC;
using System.Windows.Media;
using System.Threading;
using NeedleTracking.ViewModel;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using System.Collections.ObjectModel;
using EF_CONFIG.Model;
using System.Windows.Media.Effects;
using System.Windows.Threading;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace NeedleTracking.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        private string _CartQuantity { get; set; } = "0";
        public string CartQuantity
        {
            get { return _CartQuantity; }
            set
            {
                _CartQuantity = value;
                OnPropertyChanged();
            }
        }
        private bool _CartButtonEnable { get; set; } = false;
        public bool CartButtonEnable
        {
            get { return _CartButtonEnable; }
            set
            {
                _CartButtonEnable = value;
                OnPropertyChanged();
            }
        }
        public NS_Staffs Selected_NS_Staff { get; set; }
        private Effect _WindowEffect;
        public Effect WindowEffect
        {
            get
            {
                return _WindowEffect;
            }
            set
            {
                _WindowEffect = value;
                OnPropertyChanged();
            }
        }
        public bool Isloaded = false;
        public ICommand LoadedMainWindowCommand { get; set; }

        public MainViewModel()
        {
            LoadedMainWindowCommand = new RelayCommand<System.Windows.Window>((p) => { return true; }, (p) => { LoadedWindowCommand(p); });
        }
        void LoadedWindowCommand(System.Windows.Window p)
        {
            if (p == null)
                return;
           
        }
       
    }
   
}
