using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.RequestUC;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using NeedleTracking.UserControlUC.RecentUC;
using NeedleTracking.ViewModel.RecentMenuViewModels;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;

using EF_CONFIG.DataTransform;
using EF_CONFIG;
using EF_CONFIG.Model;


namespace NeedleTracking.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
     /*   private List<string> _POListString { get; set; }*/
        private List<NS_Needles> _needleList { get; set; }
        public bool IsLogin = false;
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        private string _StatusTextBlock;
        public string StatusTextBlock { get => _StatusTextBlock; set { _StatusTextBlock = value; OnPropertyChanged(); } }


        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand LoadLogWindowCommand { get; set; }


        public LoginViewModel() 
        {
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { CloseWindow(p); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            LoadLogWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { LoadedLogWindowCommand(p); });
        }
        void LoadedLogWindowCommand (Window p)
        {
            if (p==null)
                return;
            p.Hide();
            SplashWindow splashWindow = new SplashWindow();
            var splashVM = splashWindow.DataContext as SplashViewModel;
            splashVM.SendString("Loading..." ) ;
            splashWindow.ShowDialog();
            if (splashVM.IsSplashed)
            {
                /*_POListString = splashVM.POListString;*/
                _needleList = splashVM.NeedleList;
                p.Show();
            }
            else
            {
                MessageBox.Show("Please try againt later");
                p.Close();
            }

        }
        void Login(Window p)
        {
            if (p == null)
                return;
            MainWindow mainWindow = new MainWindow();
            var mainWindowVM = mainWindow.DataContext as MainViewModel;
           
            DeviceRecentUC deviceRecentUC = new DeviceRecentUC();
            var deviceRecentUCVM = deviceRecentUC.DataContext as DeviceRecentViewModel;
            QuantityTabUC quantityTabUC = new QuantityTabUC();
            var quantityTabUCVM = quantityTabUC.DataContext as VolatilityQtyTabViewModel;
            VolatilityDataGrid volatilityDataGridUC = new VolatilityDataGrid();
            var volatilityDataGridVM = volatilityDataGridUC.DataContext as VolatilityDataGridViewModel;
            NS_Staffs staff = StaffBase.Check_User(UserName, Password);
            if (staff!=null)
            {
                deviceRecentUCVM.needle = _needleList;
                quantityTabUCVM.needle = _needleList;
                volatilityDataGridVM.needles = _needleList;
                mainWindowVM.Selected_NS_Staff = staff;
                p.Close();
                mainWindow.Show();
            }
            else
            {
                UserName = null;
                Password = null;
                StatusTextBlock = "Can not confirm your login information";
            }
             
        }
        void CloseWindow(Window p)
        {
            p.Close();
        }

    }
}
