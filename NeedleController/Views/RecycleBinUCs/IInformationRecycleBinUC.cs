using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views.RecycleBinUCs
{
    public interface IInformationRecycleBinUC : IView
    {
        event MouseEventHandler CapturedImagePictureBoxMouseDowned;
        event MouseEventHandler CapturedImagePictureBoxMouseUped;
        event MouseEventHandler CapturedImagePictureBoxMouseMoved;
        event MouseEventHandler Panel1MouseDowned;
        event MouseEventHandler Panel1MouseUped;
        event MouseEventHandler Panel1MouseMoved;
        event MouseEventHandler CapturedImagePictureBoxMouseWheeled;
        event EventHandler ResetButtonClicked;


        void MouseDown_CapturedImagePictureBox(MouseEventArgs e);
        void MouseUp_CapturedImagePictureBox(MouseEventArgs e);
        void MouseMove_CapturedImagePictureBox(MouseEventArgs e);
        void MouseDown_panel1(MouseEventArgs e);
        void MouseUp_panel1(MouseEventArgs e);
        void MouseMove_panel1(MouseEventArgs e);
        void MouseWheel_CapturedImagePictureBox(MouseEventArgs e);
        void Click_ResetButton();


    }
}
