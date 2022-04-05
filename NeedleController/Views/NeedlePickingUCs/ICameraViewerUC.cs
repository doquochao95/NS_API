using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views.NeedlePickingUCs
{
    public interface ICameraViewerUC : IView
    {
        event EventHandler UserBrightnessTrackbar_Scrolled;
        event EventHandler UserContrastTrackbar_Scrolled;

        void GetUserBrightness();
        void GetUserContrast();
    }
}
