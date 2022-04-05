using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IMachineProcessView : IView
    {
        event EventHandler RetryButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler SuccessButtonClicked;
        event EventHandler FailButtonClicked;

        void RetryGetNeedle();
        void CancelGetNeedle();
        void FeedbackSuccess();
        void FeedbackFail();

    }
}
