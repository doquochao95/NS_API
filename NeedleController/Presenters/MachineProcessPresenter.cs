using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using NeedleController.Views;
using System.Windows.Forms;

namespace NeedleController.Presenters
{
    public class MachineProcessPresenter: Presenter<IMachineProcessView>
    {
        public MachineProcessPresenter(IMachineProcessView view)
            : base(view)
        {
            View.MachineProcessOpened += View_MachineProgressOpened;
            View.ContinueButtonClicked += View_ContinueButtonClicked;
            View.CancelButtonClicked += View_CancelButtonClicked;
            View.SuccessButtonClicked += View_SuccessButtonClicked;
            View.FailButtonClicked += View_FailButtonClicked;
            View.ReasonComboBoxKeyPressed += View_ReasonComboBoxKeyPressed;
            View.ProcessComboBoxKeyPressed += View_ProcessComboBoxKeyPressed;
            View.MachineProcessClosed += View_MachineProcessClosed;
        }
        void View_MachineProgressOpened(object sender, EventArgs e)
        {
            View.Load_MachineProgress();
        }
        void View_ContinueButtonClicked(object sender, EventArgs e)
        {
            View.ContinueGetNeedle();
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
        void View_ReasonComboBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            View.PressKey_ReasonComboBox(e);
        }
        void View_ProcessComboBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            View.PressKey_ProcessComboBox(e);
        }
        void View_MachineProcessClosed(object sender, EventArgs e)
        {
            View.MachineProcessClose();
        }
    }
}
