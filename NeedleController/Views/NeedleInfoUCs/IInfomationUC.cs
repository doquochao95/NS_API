using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views.NeedleInfoUCs
{
    public interface IInfomationUC : IView
    {
        event EventHandler InfomationUCLoaded;
        event EventHandler NeedleComboBoxSelectedIndexChanged;
        event EventHandler SearchButtonClicked;


        void Load_InformationUC();
        void Change_NeedleComboBoxSelectedIndex();
        void SearchNeedle();

    }
}
