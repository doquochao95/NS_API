using NeedleController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Presenters
{
    public class DeviceSettingPresenter : Presenter<IDeviceSettingView>
    {
        public DeviceSettingPresenter(IDeviceSettingView view)
            : base(view)
        {
            View.DeviceSettingViewLoaded += View_DeviceSettingViewLoaded;
            View.DeviceSettingViewFormClosed += View_DeviceSettingViewFormClosed;
        }
        void View_DeviceSettingViewLoaded(object sender, System.EventArgs e)
        {
            View.Load_DeviceSettingView();
        }
        void View_DeviceSettingViewFormClosed(object sender, System.EventArgs e)
        {
            View.Exit_DeviceSettingView();
        }
    }
}
