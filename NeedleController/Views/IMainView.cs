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
        event EventHandler MainViewLoaded;
        event EventHandler ConnectDeviceButtonClicked;


        void ShowNeedlePickingView();
        void ShowNeedleInfoView();
        void ShowDeviceSettingView();
        void ShowCameraSettingView();
        void MainViewLoad();
        void ConnectDevice();

        void ServerThread();
        bool PingHost(string nameOrAddress);
        void SetString_message();

    }
}
