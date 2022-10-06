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
    public class ImageReplacePresenter : Presenter<IImageReplaceView>
    {
        public ImageReplacePresenter(IImageReplaceView view)
            : base(view)
        {

        }

    }
}
