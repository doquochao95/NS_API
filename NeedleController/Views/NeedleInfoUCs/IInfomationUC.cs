using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views.NeedleInfoUCs
{
    public interface IInfomationUC : IView
    {
        event EventHandler InfomationUCLoaded;
        event EventHandler NeedleComboBoxSelectedIndexChanged;
        event EventHandler SearchButtonClicked;

        event MouseEventHandler NeedleImagePictureBoxMouseDowned;
        event MouseEventHandler NeedleImagePictureBoxMouseUped;
        event MouseEventHandler NeedleImagePictureBoxMouseMoved;
        event MouseEventHandler Panel2MouseDowned;
        event MouseEventHandler Panel2MouseUped;
        event MouseEventHandler Panel2MouseMoved;
        event MouseEventHandler NeedleImagePictureBoxMouseWheeled;

        event MouseEventHandler PointImagePictureBoxMouseDowned;
        event MouseEventHandler PointImagePictureBoxMouseUped;
        event MouseEventHandler PointImagePictureBoxMouseMoved;
        event MouseEventHandler Panel1MouseDowned;
        event MouseEventHandler Panel1MouseUped;
        event MouseEventHandler Panel1MouseMoved;
        event MouseEventHandler PointImagePictureBoxMouseWheeled;
        event EventHandler ResetPointImageButtonClicked;
        event EventHandler ResetNeedleImageButtonClicked;

        void Load_InformationUC();
        void Change_NeedleComboBoxSelectedIndex();
        void SearchNeedle();

        void MouseDown_NeedleImagePictureBox(MouseEventArgs e);
        void MouseUp_NeedleImagePictureBox(MouseEventArgs e);
        void MouseMove_NeedleImagePictureBox(MouseEventArgs e);

        void MouseDown_panel2(MouseEventArgs e);
        void MouseUp_panel2(MouseEventArgs e);
        void MouseMove_panel2(MouseEventArgs e);

        void MouseWheel_NeedleImagePictureBox(MouseEventArgs e);

        void MouseDown_PointImagePictureBox(MouseEventArgs e);
        void MouseUp_PointImagePictureBox(MouseEventArgs e);
        void MouseMove_PointImagePictureBox(MouseEventArgs e);

        void MouseDown_panel1(MouseEventArgs e);
        void MouseUp_panel1(MouseEventArgs e);
        void MouseMove_panel1(MouseEventArgs e);

        void MouseWheel_PointImagePictureBox(MouseEventArgs e);

        void Click_ResetPointImageButton();
        void Click_ResetNeedleImageButton();
    }
}
