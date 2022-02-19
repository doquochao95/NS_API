using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IMainView : IView
    {
        event EventHandler GetNeedleClicked;
        event EventHandler NeedleInfoClicked;
        event EventHandler DeviceSettingClicked;
        event EventHandler CameraSettingClicked;

        void ShowNeedlePickingView();
        void ShowNeedleInfoView();
        void ShowDeviceSettingView();
        void ShowCameraSettingView();
    }
}
