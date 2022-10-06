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
    public class RecycleBinPresenter : Presenter<IRecycleBinView>
    {
        public RecycleBinPresenter(IRecycleBinView view)
            : base(view)
        {
            View.RecycleBinViewLoaded += View_RecycleBinViewLoaded;
            View.RecycleBinViewExited += View_RecycleBinViewExited;
            View.RecycleBindataGridViewRightClicked += View_RecycleBindataGridViewRightClicked;
            View.DataGridViewSelectionChanged += View_DataGridViewSelectionChanged;
        }
        void View_RecycleBinViewLoaded(object sender, EventArgs e)
        {
            View.RecycleBinViewLoad();
        }
        void View_RecycleBinViewExited(object sender, EventArgs e)
        {
            View.RecycleBinViewExit();
        }
        void View_RecycleBindataGridViewRightClicked(object sender, MouseEventArgs e)
        {
            View.RecycleBindataGridView_RightClick(e);
        }
        void View_DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            View.DataGridView_ChangeSelection();
        }
     
       

    }
}