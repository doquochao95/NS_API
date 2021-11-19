using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using NeedleTracking.ViewModel;

namespace NeedleTracking.UserControlUC
{
    /// <summary>
    /// Interaction logic for VolatilityMenu.xaml
    /// </summary>
    public partial class VolatilityMenu : UserControl
    {

        public VolatilityMenu()
        {
            InitializeComponent();
        }
        public void CalendarDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Calendar.SelectedDate = ((VolatilityMenuViewModel)DataContext).SelectedDate;
        }

        public void CalendarDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, "1")) return;

            if (!Calendar.SelectedDate.HasValue)
            {
                eventArgs.Cancel();
                return;
            }

            ((VolatilityMenuViewModel)DataContext).SelectedDate = Calendar.SelectedDate.Value;
            VolatilityMenu volatilityMenu = new VolatilityMenu();
            var volatilityVM = volatilityMenu.DataContext as VolatilityMenuViewModel;
            if (volatilityVM.ApplyButtonEnable)
            {
                return;
            }
            else
            {
                volatilityVM.ApplyButtonEnable = true;
            }
        }
    }
}
