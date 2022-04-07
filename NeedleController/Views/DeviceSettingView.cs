using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedleController.Views
{
    public partial class DeviceSettingView : Form
    {
        private static MainView _mainView;
        public DeviceSettingView(MainView mainView)
        {
            InitializeComponent();
            _mainView = mainView;
        }
    }
}
