using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using NeedleController.Views;

namespace NeedleController.Presenters
{
    public class NeedleInfoPresenter : Presenter<INeedleInfoView>
    {
        public NeedleInfoPresenter(INeedleInfoView view)
            : base(view)
        {
            View.NeedleInfoViewLoaded += View_NeedleInfoViewLoaded;
            View.NeedleInfoViewExited += View_NeedleInfoViewExited;
            View.NeedleInformationTabControlSelectedIndexChanged += View_NeedleInformationTabControlSelectedIndexChanged;
        }

        public void View_NeedleInfoViewLoaded(object sender, EventArgs e)
        {
            View.Load_NeedleInfoView();
        }
        public void View_NeedleInfoViewExited(object sender, EventArgs e)
        {
            View.Exit_NeedleInfoView();
        }
        public void View_NeedleInformationTabControlSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            View.Check_NeedleInformationTabControl();
        }
    }
}
