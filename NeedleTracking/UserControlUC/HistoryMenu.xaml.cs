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
    /// Interaction logic for HistoryMenu.xaml
    /// </summary>
    public partial class HistoryMenu : UserControl
    {
        public HistoryMenu()
        {
            InitializeComponent();           
        }
        public void CalendarDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Calendar1.SelectedDate = ((HistoryMenuViewModel)DataContext).SelectedDate;
        }

        public void CalendarDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, "1")) return;

            if (!Calendar1.SelectedDate.HasValue)
            {
                eventArgs.Cancel();
                return;
            }

            ((HistoryMenuViewModel)DataContext).SelectedDate = Calendar1.SelectedDate.Value;
            HistoryMenu historyMenu = new HistoryMenu();
            var historyVM = historyMenu.DataContext as HistoryMenuViewModel;
            if (historyVM.ApplyButtonEnable)
            {
                return;
            }
            else
            {
                historyVM.ApplyButtonEnable = true;
            }
        }
    }
    
}
