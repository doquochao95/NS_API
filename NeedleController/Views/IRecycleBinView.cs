using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IRecycleBinView : IView
    {
        event EventHandler RecycleBinViewLoaded;
        event EventHandler RecycleBinViewExited;
        event MouseEventHandler RecycleBindataGridViewRightClicked;
        event EventHandler DataGridViewSelectionChanged;



        void RecycleBinViewLoad();
        void RecycleBinViewExit();
        void RecycleBindataGridView_RightClick(MouseEventArgs e);
        void DataGridView_ChangeSelection();
    }
}
