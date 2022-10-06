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
    public class InformationRecycleBinPresenter : Presenter<IInformationRecycleBinUC>
    {
        public InformationRecycleBinPresenter(IInformationRecycleBinUC view) : base(view)
        {
            View.CapturedImagePictureBoxMouseDowned += View_CapturedImagePictureBoxMouseDowned;
            View.CapturedImagePictureBoxMouseUped += View_CapturedImagePictureBoxMouseUped;
            View.CapturedImagePictureBoxMouseMoved += View_CapturedImagePictureBoxMouseMoved;
            View.Panel1MouseDowned += View_Panel1MouseDowned;
            View.Panel1MouseUped += View_Panel1MouseUped;
            View.Panel1MouseMoved += View_Panel1MouseMoved;
            View.CapturedImagePictureBoxMouseWheeled += View_CapturedImagePictureBoxMouseWheeled;
            View.ResetButtonClicked += View_ResetPointImageButtonClicked;
        }
        void View_CapturedImagePictureBoxMouseDowned(object sender, MouseEventArgs e)
        {
            View.MouseDown_CapturedImagePictureBox(e);
        }
        void View_CapturedImagePictureBoxMouseUped(object sender, MouseEventArgs e)
        {
            View.MouseUp_CapturedImagePictureBox(e);
        }
        void View_CapturedImagePictureBoxMouseMoved(object sender, MouseEventArgs e)
        {
            View.MouseMove_CapturedImagePictureBox(e);
        }
        void View_Panel1MouseDowned(object sender, MouseEventArgs e)
        {
            View.MouseDown_panel1(e);
        }
        void View_Panel1MouseUped(object sender, MouseEventArgs e)
        {
            View.MouseUp_panel1(e);
        }
        void View_Panel1MouseMoved(object sender, MouseEventArgs e)
        {
            View.MouseMove_panel1(e);
        }
        void View_CapturedImagePictureBoxMouseWheeled(object sender, MouseEventArgs e)
        {
            View.MouseWheel_CapturedImagePictureBox(e);
        }
        void View_ResetPointImageButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetButton();
        }
    }
}
