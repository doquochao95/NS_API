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
using NeedleController.Presenters.NeedleInfoPresenters;
using NeedleController.Presenters.DeviceSettingPresenters;


using System.Globalization;
using Infralution.Localization;
using System.Resources;
using NeedleController.Properties;
using System.IO;

namespace NeedleController.Views.DeviceSettingUCs
{
    [PresenterBinding(typeof(ConnectionSettingPresenter))]
    public partial class ConnectionSettingUC : MvpUserControl, IConnectionSetting
    {
        public ConnectionSettingUC()
        {
            InitializeComponent();
        }
    }
}
