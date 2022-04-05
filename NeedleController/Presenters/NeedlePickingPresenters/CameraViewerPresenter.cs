using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedlePickingUCs;

namespace NeedleController.Presenters.NeedlePickingPresenters
{
    public class CameraViewerPresenter  : Presenter<ICameraViewerUC>
    {
        public CameraViewerPresenter(ICameraViewerUC view) : base(view)
        {
            View.UserBrightnessTrackbar_Scrolled += View_UserBrightnessTrackbar_Scrolled;
            View.UserContrastTrackbar_Scrolled += View_UserContrastTrackbar_Scrolled;
        }

        void View_UserBrightnessTrackbar_Scrolled(object sender, EventArgs e)
        {
            View.GetUserBrightness();
        }

        void View_UserContrastTrackbar_Scrolled(object sender, EventArgs e)
        {
            View.GetUserContrast();
        }
    }
}
