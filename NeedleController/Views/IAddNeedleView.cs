using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using System.Windows.Forms;


namespace NeedleController.Views
{
    public interface IAddNeedleView : IView
    {
        event EventHandler AddNeedleViewLoaded;
        event EventHandler AddNeedleViewExited;
        event FormClosingEventHandler AddNeedleViewLeaving;

        void AddNeedleViewLoad();
        void AddNeedleViewExit();
        void AddNeedleViewLeave(FormClosingEventArgs e);
    }
}
