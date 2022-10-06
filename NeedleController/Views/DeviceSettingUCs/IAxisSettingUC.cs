using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp;

namespace NeedleController.Views.DeviceSettingUCs
{
    public interface IAxisSettingUC : IView
    {
        event EventHandler AxisSettingUCLoaded;

        event EventHandler MoveUpXButtonClicked;
        event EventHandler MoveDownXButtonClicked;
        event EventHandler MoveUpYButtonClicked;
        event EventHandler MoveDownYButtonClicked;
        event EventHandler MoveUpZButtonClicked;
        event EventHandler MoveDownZButtonClicked;

        event EventHandler OpenTableButtonClicked;
        event EventHandler CloseTableButtonClicked;
        event EventHandler ResetButtonClicked;
        event EventHandler HomeButtonClicked;
        event EventHandler ParkingButtonClicked;
        event EventHandler MachineLedOnClicked;
        event EventHandler MachineLedOffClicked;
        event EventHandler TableLedOnClicked;
        event EventHandler TableLedOffClicked;

        event EventHandler ChangeImageButtonClicked;
        event EventHandler SaveSpeedButtonClicked;
        event EventHandler SaveAccelButtonClicked;
        event EventHandler SaveOffsetButtonClicked;
        event EventHandler SavePlusButtonClicked;

        event EventHandler ResetSpeedButtonClicked;
        event EventHandler ResetAccelButtonClicked;
        event EventHandler ResetOffsetButtonClicked;
        event EventHandler ResetPlusButtonClicked;

        event EventHandler SaveConnectionButtonClicked;
        event EventHandler ResetConnectionButtonClicked;
         event EventHandler CheckButtonClicked;



        void Load_AxisSettingUC();
        void MoveUp_X();
        void MoveDown_X();
        void MoveUp_Y();
        void MoveDown_Y();
        void MoveUp_Z();
        void MoveDown_Z();

        void RefreshDataBindings();
        void Click_OpenTableButton();
        void Click_CloseTableButton();
        void Click_ResetButton();
        void Click_HomeButton();
        void Click_ParkingButton();
        void Click_MachineLedOn();
        void Click_MachineLedOff();
        void Click_TableLedOn();
        void Click_TableLedOff();

        void Click_ChangeImageButton();
        void Click_SaveSpeedButton();
        void Click_SaveAccelButton();
        void Click_SaveOffsetButton();
        void Click_SavePlusButton();

        void Click_ResetSpeedButton();
        void Click_ResetAccelButton();
        void Click_ResetOffsetButton();
        void Click_ResetPlusButton();

        void Click_SaveConnectionButton();
        void Click_ResetConnectionButton();
        void Click_CheckButton();

    }
}
