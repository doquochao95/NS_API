using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

using EF_CONFIG;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Presenters;
using NeedleController.Presenters.NeedlePickingPresenters;

using System.Globalization;
using Infralution.Localization;

namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(DeviceToolboxPresenter))]
    public partial class DeviceToolboxUC : MvpUserControl, IDeviceToolboxUC
    {
        public DeviceToolboxUC()
        {
            InitializeComponent();
            SetLanguage();
            this.IdLabel.Text = "ID: " + MainView.user_cardnumber.ToString();
            this.UserNameLabel.Text = "User Name: " + MainView.user_name;
        }

        private void SetLanguage()
        {
            CultureManager.ApplicationUICulture = new CultureInfo(NeedleController.Properties.Settings.Default.language_set);
        }
    }
}
