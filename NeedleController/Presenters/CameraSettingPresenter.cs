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
            View.CameraSettingViewClosed += View_CameraSettingViewClosed;
            View.DefaultParaButton_Clicked += View_DefaultParaButton_Clicked;
            View.SaveParaButton_Clicked += View_SaveParaButton_Clicked;
        }

        void View_CameraSettingViewLoaded(object sender, System.EventArgs e)
        {
            View.CameraSettingViewLoad();
        }

        void View_CameraSettingViewClosed(object sender, System.EventArgs e)
        {
            View.CameraSettingViewClose();
        }

        void View_DefaultParaButton_Clicked(object sender, System.EventArgs e)
        {
            View.DefaultPara();
        }

        void View_SaveParaButton_Clicked(object sender, System.EventArgs e)
        {
            View.SavePara();
        }
    }
}
