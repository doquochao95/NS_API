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
    public interface IAddUC : IView
    {
        event EventHandler AddUCLoaded;
        event EventHandler NeedlePointListComboBoxSelectedIndexChanged;
        event EventHandler OpenFileButtonClicked;
        event EventHandler FileDirectionTextBoxDoubleClicked;

        event EventHandler NameTextBoxFocusLeaved;
        event EventHandler CodeTextBoxFocusLeaved;
        event EventHandler SizeTextBoxFocusLeaved;
        event EventHandler PriceTextBoxFocusLeaved;
        event EventHandler LengthTextBoxFocusLeaved;
        event EventHandler SaveButtonClicked;
        event EventHandler CancelButtonClicked;
        event KeyEventHandler EnterKeyPressed;


        void LoadAddUC();
        void Check_NeedlePointListComboBoxIndexChanged();
        void Open_OpenFileDialog();

        void CheckNameTextBoxData();
        void CheckCodeTextBoxData();
        void CheckSizeTextBoxData();
        void CheckPriceTextBoxData();
        void CheckLengthTextBoxData();
        void Save_NewNeedleInfo();
        void Cancel_NewNeedleInfo();
        void Keyboard_EnterKeyPress(KeyEventArgs e);

    }
}
