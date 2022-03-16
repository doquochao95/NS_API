using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Views.CameraSettingUCs
{
    public interface ICameraParaSetting : IView
    {
        event EventHandler GaussianKSizeCmb_Selected;
        event EventHandler CannyThreshold_1_Scrolled;
        event EventHandler CannyThreshold_2_Scrolled;
        event EventHandler SaveColorPara_Clicked;
        event EventHandler LowR_KeyPressed;
        event EventHandler LowG_KeyPressed;
        event EventHandler LowB_KeyPressed;
        event EventHandler HighR_KeyPressed;
        event EventHandler HighG_KeyPressed;
        event EventHandler HighB_KeyPressed;

        void GetGaussianBlurKsize();
        void GetCannyThreshold1();
        void GetCannyThreshold2();
        void SaveColorPara();
        void EnterLowR();
        void EnterLowG();
        void EnterLowB();
        void EnterHighR();
        void EnterHighG();
        void EnterHighB();
    }
}
