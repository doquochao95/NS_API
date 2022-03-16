using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using NeedleController.Views;

namespace NeedleController.Presenters
{
    public class NeedlePickingPresenter : Presenter<INeedlePickingView>
    {
        public NeedlePickingPresenter(INeedlePickingView view)
            : base(view)
        {
            View.NeedlePickingViewLoaded += View_NeedlePickingViewLoaded;
        }
        void View_NeedlePickingViewLoaded(object sender, EventArgs e)
        {
            View.NeedlePickingViewLoad();
        }
    }
}
