using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Views
{
    public interface ICameraSettingView : IView
    {
        event EventHandler CameraSettingViewLoaded;
        event EventHandler CameraSettingViewClosed;
        event EventHandler DefaultParaButton_Clicked;
        event EventHandler SaveParaButton_Clicked;

        void CameraSettingViewLoad();
        void CameraSettingViewClose();
        void DefaultPara();
        void SavePara();
    }
}
