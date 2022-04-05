using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedleInfoUCs;
using System.Windows.Forms;

namespace NeedleController.Presenters.NeedleInfoPresenters
{
    public class InfomationPresenter : Presenter<IInfomationUC>
    {
        public InfomationPresenter(IInfomationUC view) : base(view)
        {
            View.InfomationUCLoaded += View_InformationUCLoaded;
            View.NeedleComboBoxSelectedIndexChanged += View_NeedleComboBoxSelectedIndexChanged;
            View.SearchButtonClicked += View_SearchButtonClicked;

            View.NeedleImagePictureBoxMouseDowned += View_NeedleImagePictureBoxMouseDowned;
            View.NeedleImagePictureBoxMouseUped += View_NeedleImagePictureBoxMouseUped;
            View.NeedleImagePictureBoxMouseMoved += View_NeedleImagePictureBoxMouseMoved;
            View.Panel2MouseDowned += View_Panel2MouseDowned;
            View.Panel2MouseUped += View_Panel2MouseUped;
            View.Panel2MouseMoved += View_Panel2MouseMoved;
            View.NeedleImagePictureBoxMouseWheeled += View_NeedleImagePictureBoxMouseWheeled;
            View.PointImagePictureBoxMouseDowned += View_PointImagePictureBoxMouseDowned;
            View.PointImagePictureBoxMouseUped += View_PointImagePictureBoxMouseUped;
            View.PointImagePictureBoxMouseMoved += View_PointImagePictureBoxMouseMoved;
            View.Panel1MouseDowned += View_Panel1MouseDowned;
            View.Panel1MouseUped += View_Panel1MouseUped;
            View.Panel1MouseMoved += View_Panel1MouseMoved;
            View.PointImagePictureBoxMouseWheeled += View_PointImagePictureBoxMouseWheeled;
            View.ResetPointImageButtonClicked += View_ResetPointImageButtonClicked;
            View.ResetNeedleImageButtonClicked += View_ResetNeedleImageButtonClicked;
        }
        void View_InformationUCLoaded(object sender, EventArgs e)
        {
            View.Load_InformationUC();
        }
        void View_NeedleComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            View.Change_NeedleComboBoxSelectedIndex();
        }
        void View_SearchButtonClicked(object sender, EventArgs e)
        {
            View.SearchNeedle();
        }

        void View_NeedleImagePictureBoxMouseDowned(object sender, MouseEventArgs e)
        {
            View.MouseDown_NeedleImagePictureBox(e);
        }
        void View_NeedleImagePictureBoxMouseUped(object sender, MouseEventArgs e)
        {
            View.MouseUp_NeedleImagePictureBox(e);
        }
        void View_NeedleImagePictureBoxMouseMoved(object sender, MouseEventArgs e)
        {
            View.MouseMove_NeedleImagePictureBox(e);
        }
        void View_Panel2MouseDowned(object sender, MouseEventArgs e)
        {
            View.MouseDown_panel2(e);
        }
        void View_Panel2MouseUped(object sender, MouseEventArgs e)
        {
            View.MouseUp_panel2(e);
        }
        void View_Panel2MouseMoved(object sender, MouseEventArgs e)
        {
            View.MouseMove_panel2(e);
        }
        void View_NeedleImagePictureBoxMouseWheeled(object sender, MouseEventArgs e)
        {
            View.MouseWheel_NeedleImagePictureBox(e);
        }
        void View_PointImagePictureBoxMouseDowned(object sender, MouseEventArgs e)
        {
            View.MouseDown_PointImagePictureBox(e);
        }
        void View_PointImagePictureBoxMouseUped(object sender, MouseEventArgs e)
        {
            View.MouseUp_PointImagePictureBox(e);
        }
        void View_PointImagePictureBoxMouseMoved(object sender, MouseEventArgs e)
        {
            View.MouseMove_PointImagePictureBox(e);
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
        void View_PointImagePictureBoxMouseWheeled(object sender, MouseEventArgs e)
        {
            View.MouseWheel_PointImagePictureBox(e);
        }
        void View_ResetPointImageButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetPointImageButton();
        }
        void View_ResetNeedleImageButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetNeedleImageButton();
        }

    }
}
