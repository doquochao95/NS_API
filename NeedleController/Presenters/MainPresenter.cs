using NeedleController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;
namespace NeedleController.Presenters
{
    public class MainPresenter     : Presenter<IMainView>
    {
        public MainPresenter(IMainView view)
            : base(view)
        {
            View.GetNeedleClicked += View_GetNeedleClicked;   
            View.NeedleInfoClicked += View_NeedleInfoClicked;
            View.DeviceSettingClicked += View_DeviceSettingClicked;
            View.CameraSettingClicked += View_CameraSettingClicked;
            View.MainViewLoaded += View_MainViewLoaded;
            View.ConnectDeviceButtonClicked += View_ConnectDeviceButtonClicked;

        }
        void View_GetNeedleClicked(object sender, System.EventArgs e)
        {
            View.ShowNeedlePickingView();
        }
        void View_NeedleInfoClicked(object sender, System.EventArgs e)
        {
            View.ShowNeedleInfoView();
        }
        void View_DeviceSettingClicked(object sender, System.EventArgs e)
        {
            View.ShowDeviceSettingView();
        }
        void View_CameraSettingClicked(object sender, System.EventArgs e)
        {
            View.ShowCameraSettingView();
        }
        void View_MainViewLoaded(object sender, System.EventArgs e)
        {
            View.MainViewLoad();
        }
        void View_ConnectDeviceButtonClicked(object  sender, System.EventArgs e)
        {
            View.ConnectDevice();
        }
    }
}
