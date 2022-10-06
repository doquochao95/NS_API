using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedleInfoUCs;
using NeedleController.Views.DeviceSettingUCs;

using System.ComponentModel;
using System.Windows.Forms;

namespace NeedleController.Presenters.DeviceSettingPresenters
{
    public class ConnectionSettingPresenter : Presenter<IConnectionSetting>
    {
        public ConnectionSettingPresenter(IConnectionSetting view) : base(view)
        {

        }
    }
}
