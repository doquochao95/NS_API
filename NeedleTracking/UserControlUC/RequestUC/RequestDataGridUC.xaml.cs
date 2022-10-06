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
using NeedleTracking.ViewModel.RequestMenuViewModels;

namespace NeedleTracking.UserControlUC.RequestUC
{
    /// <summary>
    /// Interaction logic for RequestDataGridUC.xaml
    /// </summary>
    public partial class RequestDataGridUC : UserControl
    {
        public RequestDataGridUC()
        {
            InitializeComponent();
            
        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((ListBox)sender).ScrollIntoView(e.AddedItems[0]);
        }
    }
}
