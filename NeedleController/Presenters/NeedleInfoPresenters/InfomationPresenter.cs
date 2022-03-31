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
    public class InfomationPresenter : Presenter<IInfomationUC>
    {
        public InfomationPresenter(IInfomationUC view) : base(view)
        {
            View.InfomationUCLoaded += View_InformationUCLoaded;
            View.NeedleComboBoxSelectedIndexChanged += View_NeedleComboBoxSelectedIndexChanged;
            View.SearchButtonClicked += View_SearchButtonClicked;
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
    }
}
