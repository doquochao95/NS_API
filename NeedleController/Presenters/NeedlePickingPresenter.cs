﻿using System;
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
            View.NeedlePickingViewClosed += View_NeedlePickingViewClosed;
        }

        void View_NeedlePickingViewLoaded(object sender, EventArgs e)
        {
            View.NeedlePickingViewLoad();
        }

        void View_NeedlePickingViewClosed(object sender, EventArgs e)
        {
            View.NeedlePickingViewClose();
        }
    }
}
