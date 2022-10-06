using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using NeedleController.Views;

namespace NeedleController.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {
        public MainPresenter(IMainView view)
            : base(view)
        {
            View.GetNeedleClicked += View_GetNeedleClicked;    
            View.NeedleInfoClicked += View_NeedleInfoClicked;
            View.AddNeedleButtonCLicked += View_AddNeedleButtonClicked;
            View.RecycleBinClicked += View_RecycleBinClicked;
            View.DeviceSettingClicked += View_DeviceSettingClicked;
            View.CameraSettingClicked += View_CameraSettingClicked;
            View.MainViewLoaded += View_MainViewLoaded;
            View.ConnectDeviceButtonClicked += View_ConnectDeviceButtonClicked;
            View.ConnectDeviceToolStripMenuClicked += View_ConnectDeviceToolStripMenuClicked;
            View.ExitToolStripMenuClicked += View_ExitToolStripMenuClicked;
            View.EnglishToolStripMenuClicked += View_EnglishToolStripMenuClicked;
            View.VietnameseToolStripMenuClicked += View_VietnameseToolStripMenuClicked;
            View.ChineseToolStripMenuClicked += View_ChineseToolStripMenuClicked;
            View.UIcultureChanged += View_UIcultureChanged;
        }
        void View_GetNeedleClicked(object sender, EventArgs e)
        {
            View.ShowNeedlePickingView();
        }
        void View_AddNeedleButtonClicked(object sender, EventArgs e)
        {
            View.ShowAddNeedleView();
        }
        void View_NeedleInfoClicked(object sender, EventArgs e)
        {
            View.ShowNeedleInfoView();
        }
        void View_RecycleBinClicked(object sender, EventArgs e)
        {
            View.ShowRecycleBinView();
        }
        void View_DeviceSettingClicked(object sender, EventArgs e)
        {
            View.ShowDeviceSettingView();
        }
        void View_CameraSettingClicked(object sender, EventArgs e)
        {
            View.ShowCameraSettingView();
        }
        void View_MainViewLoaded(object sender, EventArgs e)
        {
            View.MainViewLoad();
        }
        void View_ConnectDeviceButtonClicked(object sender, EventArgs e)
        {
            View.ConnectDevice();
        }
        void View_ConnectDeviceToolStripMenuClicked(object sender, EventArgs e)
        {
            View.ConnectDevice();
        }
        void View_ExitToolStripMenuClicked(object sender, EventArgs e)
        {
            View.CloseForm();
        }
        void View_EnglishToolStripMenuClicked(object sender, EventArgs e)
        {
            View.SetLanguageEnglish();
        }
        void View_VietnameseToolStripMenuClicked(object sender, EventArgs e)
        {
            View.SetLanguageVietnamese();
        }
        void View_ChineseToolStripMenuClicked(object sender, EventArgs e)
        {
            View.SetLanguageChinese();
        }
        void View_UIcultureChanged(object sender, EventArgs e)
        {
            View.UpdateLanguageMenus();
        }
    }
}
