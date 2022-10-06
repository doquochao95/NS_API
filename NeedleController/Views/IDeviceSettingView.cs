using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IDeviceSettingView : IView
    {
         event EventHandler DeviceSettingViewLoaded;
         event EventHandler DeviceSettingViewFormClosed;

        void Load_DeviceSettingView();
        void Exit_DeviceSettingView();
    }
}
