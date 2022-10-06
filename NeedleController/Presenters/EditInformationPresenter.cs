using NeedleController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsMvp;

namespace NeedleController.Presenters
{
    public class EditInformationPresenter : Presenter<IEditInformationView>
    {
        public EditInformationPresenter(IEditInformationView view)
            : base(view)
        {
            View.ExitButtonClicked += View_ExitButtonClicked;
            View.SaveButtonClicked += View_SaveButtonClicked;
            View.EditInformationLoaded += View_EditInformationLoaded;
        }
        void View_ExitButtonClicked(object sender, System.EventArgs e)
        {
            View.Exit_EditInformationForm();
        }
        void View_SaveButtonClicked(object sender, System.EventArgs e)
        {
            View.Save_Information();
        }
        void View_EditInformationLoaded(object sender, System.EventArgs e)
        {
            View.Load_EditInformationView();
        }
    }
}
