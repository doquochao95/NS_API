using NeedleController.Views.CameraSettingUCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Presenters.CameraSettingPresenters
{

    public class CameraParaPresenter : Presenter<ICameraParaSetting>
    {
        public CameraParaPresenter(ICameraParaSetting view)
            : base (view)
        {
            View.IDcameraCmb_Selected += View_IDcameraCmb_Selected;
            View.GaussianKSizeCmb_Selected += View_GaussianKSizeCmb_Selected;
            View.CannyThreshold_1_Scrolled += View_CannyThreshold_1_Scrolled;
            View.CannyThreshold_2_Scrolled += View_CannyThreshold_2_Scrolled;            
            View.LowR_KeyPressed += View_LowR_KeyPressed;
            View.LowG_KeyPressed += View_LowG_KeyPressed;
            View.LowB_KeyPressed += View_LowB_KeyPressed;
            View.HighR_KeyPressed += View_HighR_KeyPressed;
            View.HighG_KeyPressed += View_HighG_KeyPressed;
            View.HighB_KeyPressed += View_HighB_KeyPressed;
            View.OnOffDetect_Checked += View_OnOffDetect_Checked;
        }

        void View_IDcameraCmb_Selected(object sender, System.EventArgs e)
        {
            View.GetIDCamera();
        }

        void View_GaussianKSizeCmb_Selected(object sender, System.EventArgs e)
        {
            View.GetGaussianBlurKsize();
        }

        void View_CannyThreshold_1_Scrolled(object sender, System.EventArgs e)
        {
            View.GetCannyThreshold1();
        }

        void View_CannyThreshold_2_Scrolled(object sender, System.EventArgs e)
        {
            View.GetCannyThreshold2();
        }

        void View_LowR_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterLowR();
        }

        void View_LowG_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterLowG();
        }

        void View_LowB_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterLowB();
        }

        void View_HighR_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterHighR();
        }

        void View_HighG_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterHighG();
        }

        void View_HighB_KeyPressed(object sender, System.EventArgs e)
        {
            View.EnterHighB();
        }

        void View_OnOffDetect_Checked(object sender, System.EventArgs e)
        {
            View.Detect_OnOff();
        }
    }
}
