using NeedleController.Views.CameraSettingUCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Presenters.CameraSettingPresenters
{
    public class CameraImgParaPresenter : Presenter<ICameraImgParaSetting>
    {
        public CameraImgParaPresenter(ICameraImgParaSetting view)
            : base(view)
        {
            View.CameraImgParaSetting_Loaded += View_CameraImgParaSetting_Loaded;
            View.RedRaBtn_Checked += View_RedRaBtn_Checked;
            View.GreenRaBtn_Checked += View_GreenRaBtn_Checked;
            View.BlueRaBtn_Checked += View_BlueRaBtn_Checked;
            View.NormalRaBtn_Checked += View_NormalRaBtn_Checked;
            View.BrightnessTrackbar_Scrolled += View_BrightnessTrackbar_Scrolled;
            View.ContrastTrackbar_Scrolled += View_ContrastTrackbar_Scrolled;
            View.ImgPositionCmb_Selected += View_ImgPositionCmb_Selected;
        }

        void View_CameraImgParaSetting_Loaded(object sende, EventArgs e)
        {
            View.Load_CameraImgParaSetting();
        }

        void View_BrightnessTrackbar_Scrolled(object sender, System.EventArgs e)
        {
            View.GetBrightness();
        }

        void View_ContrastTrackbar_Scrolled(object sender, System.EventArgs e)
        {
            View.GetContrast();
        }

        void View_RedRaBtn_Checked(object sender, System.EventArgs e)
        {
            View.GetDisplayMode();
        }

        void View_GreenRaBtn_Checked(object sender, System.EventArgs e)
        {
            View.GetDisplayMode();
        }

        void View_BlueRaBtn_Checked(object sender, System.EventArgs e)
        {
            View.GetDisplayMode();
        }

        void View_NormalRaBtn_Checked(object sender, System.EventArgs e)
        {
            View.GetDisplayMode();
        }

        void View_ImgPositionCmb_Selected(object sender, System.EventArgs e)
        {
            View.GetImgPosition();
        }
    }
}
