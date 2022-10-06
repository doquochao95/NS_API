using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using System.ComponentModel;
using System.Windows.Forms;
using NeedleController.Views.RecycleBinUCs;

namespace NeedleController.Presenters.RecycleBinPresenters
{
    public class ConfirmRecycleBinPresenter : Presenter<IConfirmRecycleBinUC>
    {
        public ConfirmRecycleBinPresenter(IConfirmRecycleBinUC view) : base(view)
        {

        }
    }
}
