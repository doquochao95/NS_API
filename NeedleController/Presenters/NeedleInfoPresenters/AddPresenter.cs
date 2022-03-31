using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedleInfoUCs;
using System.ComponentModel;
using System.Windows.Forms;

namespace NeedleController.Presenters.NeedleInfoPresenters
{
    public class AddPresenter : Presenter<IAddUC>
    {
        public AddPresenter(IAddUC view) : base(view)
        {
            View.AddUCLoaded += View_AddUCLoaded;
            View.NeedlePointListComboBoxSelectedIndexChanged += View_NeedlePointListComboBoxSelectedIndexChanged;
            View.OpenFileButtonClicked += View_OpenFileButtonClicked;
            View.FileDirectionTextBoxDoubleClicked += View_FileDirectionTextBoxDoubleClicked;

            View.NameTextBoxFocusLeaved += View_NameTextBoxFocusLeaved;
            View.CodeTextBoxFocusLeaved += View_CodeTextBoxFocusLeaved;
            View.SizeTextBoxFocusLeaved += View_SizeTextBoxFocusLeaved;
            View.PriceTextBoxFocusLeaved += View_PriceTextBoxFocusLeaved;
            View.LengthTextBoxFocusLeaved += View_LengthTextBoxFocusLeaved;

            View.SaveButtonClicked += View_SaveButtonClicked;
            View.CancelButtonClicked += View_CancelButtonClicked;
            View.EnterKeyPressed += View_EnterKeyPressed;
        }

        void View_AddUCLoaded(object sender, EventArgs e)
        {
            View.LoadAddUC();
        }
        void View_NeedlePointListComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            View.Change_NeedlePointListComboBoxIndex();
        }
        void View_OpenFileButtonClicked(object sender, EventArgs e)
        {
            View.Open_OpenFileDialog();
        }
        void View_FileDirectionTextBoxDoubleClicked(object sender, EventArgs e)
        {
            View.Open_OpenFileDialog();
        }

        void View_NameTextBoxFocusLeaved(object sender, EventArgs e)
        {
            View.CheckNameTextBoxData();
        }
        void View_CodeTextBoxFocusLeaved(object sender, EventArgs e)
        {
            View.CheckCodeTextBoxData();
        }
        void View_SizeTextBoxFocusLeaved(object sender, EventArgs e)
        {
            View.CheckSizeTextBoxData();
        }
        void View_PriceTextBoxFocusLeaved(object sender, EventArgs e)
        {
            View.CheckPriceTextBoxData();
        }
        void View_LengthTextBoxFocusLeaved(object sender, EventArgs e)
        {
            View.CheckLengthTextBoxData();
        }

        void View_SaveButtonClicked(object sender, EventArgs e)
        {
            View.Save_NewNeedleInfo();
        }
        void View_CancelButtonClicked(object sender, EventArgs e)
        {
            View.Cancel_NewNeedleInfo();
        }
        void View_EnterKeyPressed(object sender, KeyEventArgs e)
        {
            View.Keyboard_EnterKeyPress(e);
        }
    }
}
