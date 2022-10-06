using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IMachineProcessView : IView
    {
         event EventHandler MachineProcessOpened;
        event EventHandler ContinueButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler SuccessButtonClicked;
        event EventHandler FailButtonClicked;
        event KeyPressEventHandler ReasonComboBoxKeyPressed;
        event KeyPressEventHandler ProcessComboBoxKeyPressed;
        event EventHandler MachineProcessClosed;


        void Load_MachineProgress();
        void ContinueGetNeedle();
        void CancelGetNeedle();
        void FeedbackSuccess();
        void FeedbackFail();
        void FeedbackTimeOut();
        void FeedbackCancel();
        void PressKey_ReasonComboBox(KeyPressEventArgs e);
        void PressKey_ProcessComboBox(KeyPressEventArgs e);
        void MachineProcessClose();
    }
}
