using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using NeedleController.Views;

namespace NeedleController.Presenters
{
    public class MachineProcessPresenter: Presenter<IMachineProcessView>
    {
        public MachineProcessPresenter(IMachineProcessView view)
            : base(view)
        {
            View.RetryButtonClicked += View_RetryButtonClicked;
            View.CancelButtonClicked += View_CancelButtonClicked;
            View.SuccessButtonClicked += View_SuccessButtonClicked;
            View.FailButtonClicked += View_FailButtonClicked;
        }
        void View_RetryButtonClicked(object sender, EventArgs e)
        {
            View.RetryGetNeedle();
        }
        void View_CancelButtonClicked(object sender, EventArgs e)
        {
            View.CancelGetNeedle();
        }
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
