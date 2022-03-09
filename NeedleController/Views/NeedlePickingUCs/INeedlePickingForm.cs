using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views.NeedlePickingUCs
{
    public interface INeedlePickingForm :  IView
    {
        event EventHandler GetButtonClicked;
        event EventHandler NeedlePickingFormLoaded;

        void GetNeedle();
        void LoadNeedlePickingForm();
    }
}
