using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using NeedleTracking.UserControlUC;
using EF_CONFIG.DataTransform;

namespace NeedleTracking.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {   
        public bool IsLogin = false;
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }


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
            bool flag = StaffBase.Check_User(UserName, Password);
            if (flag)
            {
                p.Close();
                mainWindow.Show();
            }
            else
            {
            }
             
        }
        void CloseWindow(Window p)
        {
            p.Close();
        }

    }
}
