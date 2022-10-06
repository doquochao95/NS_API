using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IMainView : IView
    {
        event EventHandler GetNeedleClicked;
        event EventHandler AddNeedleButtonCLicked;
        event EventHandler NeedleInfoClicked;
        event EventHandler RecycleBinClicked;
        event EventHandler DeviceSettingClicked;
        event EventHandler CameraSettingClicked;
        event EventHandler MainViewLoaded;
        event EventHandler ConnectDeviceButtonClicked;
        event EventHandler ExitToolStripMenuClicked;
        event EventHandler ConnectDeviceToolStripMenuClicked;
        event EventHandler EnglishToolStripMenuClicked;
        event EventHandler VietnameseToolStripMenuClicked;
        event EventHandler ChineseToolStripMenuClicked;
        event EventHandler UIcultureChanged;


        void ShowNeedlePickingView();
        void ShowAddNeedleView();
        void ShowNeedleInfoView();
        void ShowRecycleBinView();

        void ShowDeviceSettingView();
        void ShowCameraSettingView();
        void MainViewLoad();
        void ConnectDevice();
        void CloseForm();
        void SetLanguageEnglish();
        void SetLanguageVietnamese();
        void SetLanguageChinese();

        void UpdateLanguageMenus();

        bool CheckOpenedForm(string name);
        void Reply_Buffer(string buffer);

        void ServerThread();
        bool PingHost(string nameOrAddress);
        void SetString_message();
        void start_progressbar(ProgressBar progressBar);
        void stop_progressbar(ProgressBar progressBar);

    }
}
