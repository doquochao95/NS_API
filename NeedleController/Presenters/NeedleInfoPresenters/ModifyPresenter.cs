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
    public class ModifyPresenter : Presenter<IModifyUC>
    {
        public ModifyPresenter(IModifyUC view) : base(view)
        {
            View.ModifyUCLoaded += View_ModifyUCLoaded;
            View.SearchButtonClicked += View_SearchButtonClicked;
            View.SaveButtonClicked += View_SaveButtonClicked;
            View.CancelButtonClicked += View_CancelButtonClicked;
            View.OpenFileButtonClicked += View_OpenFileButtonClicked;
            View.NeedleComboBoxSelectedIndexChanged += View_NeedleComboBoxSelectedIndexChanged;
            View.NeedlePointListComboBoxSelectedIndexChanged += View_NeedlePointListComboBoxSelectedIndexChanged;

            View.NameTextBoxFocusLeaved += View_NameTextBoxFocusLeaved;
            View.CodeTextBoxFocusLeaved += View_CodeTextBoxFocusLeaved;
            View.SizeTextBoxFocusLeaved += View_SizeTextBoxFocusLeaved;
            View.PriceTextBoxFocusLeaved += View_PriceTextBoxFocusLeaved;
            View.LengthTextBoxFocusLeaved += View_LengthTextBoxFocusLeaved;
            View.EnterKeyPressed += View_EnterKeyPressed;
        }

        void View_ModifyUCLoaded(object sender, EventArgs e)
        {
            View.LoadModifyUC();
        }
        void View_SearchButtonClicked(object sender, EventArgs e)
        {
            View.SearchForNeedle();
        }
        void View_SaveButtonClicked(object sender, EventArgs e)
        {
            View.SaveCurrentNeedleInformations();
        }
        void View_CancelButtonClicked(object sender, EventArgs e)
        {
            View.CancelSettedNeedleInformation();
        }
        void View_OpenFileButtonClicked(object sender, EventArgs e)
        {
            View.Open_OpenFileDialog();
        }
        void View_NeedleComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            View.Check_NeedleComboboxIndexChanged();
        }
        void View_NeedlePointListComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            View.Check_NeedlePointListComboBoxIndexChanged();
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
        void View_EnterKeyPressed(object sender, KeyEventArgs e)
        {
            View.Keyboard_EnterKeyPress(e);
        }
    }
}
