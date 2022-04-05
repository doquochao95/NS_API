using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Views.CameraSettingUCs
{
    public interface ICameraImgParaSetting : IView
    {
        event EventHandler BrightnessTrackbar_Scrolled;
        event EventHandler ContrastTrackbar_Scrolled;
        event EventHandler RedRaBtn_Checked;
        event EventHandler GreenRaBtn_Checked;
        event EventHandler BlueRaBtn_Checked;
        event EventHandler NormalRaBtn_Checked;
        event EventHandler ImgPositionCmb_Selected;

        void GetBrightness();
        void GetContrast();
        void GetDisplayMode();
        void GetImgPosition();
    }
}
