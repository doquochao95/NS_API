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
    public class CameraViewerPresenter  : Presenter<ICameraViewerUC>
    {
        public CameraViewerPresenter(ICameraViewerUC view) : base(view)
        {

        }
    }
}
