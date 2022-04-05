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
    public class AddNeedlePresenter : Presenter<IAddNeedleView>
    {
        public AddNeedlePresenter(IAddNeedleView view)
            : base(view)
        {
            View.AddNeedleViewLoaded += View_AddNeedleViewLoaded;
            View.AddNeedleViewExited += View_AddNeedleViewExited;
            View.AddNeedleViewLeaving += View_AddNeedleViewLeaving;
        }
        void View_AddNeedleViewLoaded(object sender, EventArgs e)
        {
            View.AddNeedleViewLoad();
        }
        void View_AddNeedleViewExited(object sender, EventArgs e)
        {
            View.AddNeedleViewExit();
        }
        void View_AddNeedleViewLeaving(object sender, FormClosingEventArgs e)
        {
            View.AddNeedleViewLeave(e);
        }
    }
}
