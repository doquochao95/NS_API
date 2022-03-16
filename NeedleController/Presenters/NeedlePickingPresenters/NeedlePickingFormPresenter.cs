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
    public class NeedlePickingFormPresenter : Presenter<INeedlePickingForm>
    {
        public NeedlePickingFormPresenter(INeedlePickingForm view) : base(view)
        {
            View.GetButtonClicked += View_GetButtonClicked;
            View.NeedlePickingFormLoaded += View_NeedlePickingFormLoaded;

        }
        void View_GetButtonClicked(object sender, EventArgs e)
        {
            View.GetNeedle();
        }
        void View_NeedlePickingFormLoaded(object sender, EventArgs e)
        {
            View.LoadNeedlePickingForm();
        }
    }
}
