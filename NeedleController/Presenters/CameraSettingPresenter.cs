using NeedleController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Presenters
{
    public class CameraSettingPresenter : Presenter<ICameraSettingView>
    {
        public CameraSettingPresenter(ICameraSettingView view)
            : base(view)
        {
            View.CameraSettingViewLoaded += View_CameraSettingViewLoaded;
        }

        void View_CameraSettingViewLoaded(object sender, System.EventArgs e)
        {
            View.CameraSettingViewLoad();
        }
    }
}
