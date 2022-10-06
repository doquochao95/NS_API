using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using NeedleTracking.UserControlUC.RequestUC;
using EF_CONFIG.BaseModel;

namespace NeedleTracking.ViewModel.HistoryMenuViewModels
{
    public class HistoryActionButtonViewModel : BaseViewModel
    {
        public ICommand ViewImageCommand { get; set; }

        public HistoryActionButtonViewModel()
        {
            ViewImageCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => { ViewImage(); });
        }
        private void ViewImage()
        {
            ImageWindow imageWindow = new ImageWindow();
            imageWindow.Show();
        }
    }
}
