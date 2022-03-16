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
            View.SuccessButtonClicked += View_SuccessButtonClicked;
            View.FailButtonClicked += View_FailButtonClicked;

            void View_SuccessButtonClicked(object sender, EventArgs e)
            {
              View.FeedbackSuccess();
            }
            void View_FailButtonClicked(object sender, EventArgs e)
            {
              View.FeedbackFail();
            }
        }
    }
}
