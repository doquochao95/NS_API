using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface INeedlePickingView : IView
    {
        event EventHandler NeedlePickingViewLoaded;
        event EventHandler NeedlePickingViewExited;
        event EventHandler NeedlePickingViewClosed;

        void NeedlePickingViewLoad();
        void NeedlePickingViewExit();
        void NeedlePickingViewClose();
    }
}
