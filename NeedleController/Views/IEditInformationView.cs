using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views
{
    public interface IEditInformationView : IView
    {
        event EventHandler ExitButtonClicked;
        event EventHandler SaveButtonClicked;
        event EventHandler EditInformationLoaded;


        void Save_Information();
        void Exit_EditInformationForm();
        void Load_EditInformationView();

    }
}
