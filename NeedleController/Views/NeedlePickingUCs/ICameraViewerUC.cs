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
        event EventHandler SuccessButtonClicked;
        event EventHandler FailButtonClicked;

        void FeedbackSuccess();
        void FeedbackFail();
    }
}
