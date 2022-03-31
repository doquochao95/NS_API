using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedleInfoUCs;

namespace NeedleController.Presenters.NeedleInfoPresenters
{
    public class ModifyPresenter : Presenter<IModifyUC>
    {
        public ModifyPresenter(IModifyUC view) : base(view)
        { 
        }
    }
}
