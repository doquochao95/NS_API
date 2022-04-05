using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;
namespace NeedleController.Views.NeedleInfoUCs
{
    public interface IModifyUC : IView
    {
        event EventHandler ModifyUCLoaded;
        event EventHandler SearchButtonClicked;
        event EventHandler SaveButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler OpenFileButtonClicked;
        event EventHandler NeedleComboBoxSelectedIndexChanged;
        event EventHandler NeedlePointListComboBoxSelectedIndexChanged;

        event EventHandler NameTextBoxFocusLeaved;
        event EventHandler CodeTextBoxFocusLeaved;
        event EventHandler SizeTextBoxFocusLeaved;
        event EventHandler PriceTextBoxFocusLeaved;
        event EventHandler LengthTextBoxFocusLeaved;
        event KeyEventHandler EnterKeyPressed;

        void LoadModifyUC();
        void SearchForNeedle();
        void SaveCurrentNeedleInformations();
        void CancelSettedNeedleInformation();
        void Open_OpenFileDialog();
        void Check_NeedleComboboxIndexChanged();
        void Check_NeedlePointListComboBoxIndexChanged();
        void CheckNameTextBoxData();
        void CheckCodeTextBoxData();
        void CheckSizeTextBoxData();
        void CheckPriceTextBoxData();
        void CheckLengthTextBoxData();
        void Keyboard_EnterKeyPress(KeyEventArgs e);

    }
}
