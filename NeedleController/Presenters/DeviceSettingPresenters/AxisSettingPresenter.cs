using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedleInfoUCs;
using NeedleController.Views.DeviceSettingUCs;

using System.ComponentModel;
using System.Windows.Forms;

namespace NeedleController.Presenters.DeviceSettingPresenters
{
    public class AxisSettingPresenter : Presenter<IAxisSettingUC>
    {
        public AxisSettingPresenter(IAxisSettingUC view) : base(view)
        {
            View.AxisSettingUCLoaded += View_AxisSettingUCLoaded;

            View.MoveUpXButtonClicked += View_MoveUpXButtonClicked;
            View.MoveDownXButtonClicked += View_MoveDownXButtonClicked;
            View.MoveUpYButtonClicked += View_MoveUpYButtonClicked;
            View.MoveDownYButtonClicked += View_MoveDownYButtonClicked;
            View.MoveUpZButtonClicked += View_MoveUpZButtonClicked;
            View.MoveDownZButtonClicked += View_MoveDownZButtonClicked;

            View.OpenTableButtonClicked += View_OpenTableButtonClicked;
            View.CloseTableButtonClicked += View_CloseTableButtonClicked;
            View.ResetButtonClicked += View_ResetButtonClicked;
            View.HomeButtonClicked += View_HomeButtonClicked;
            View.ParkingButtonClicked += View_ParkingButtonClicked;
            View.MachineLedOnClicked += View_MachineLedOnClicked;
            View.MachineLedOffClicked += View_MachineLedOffClicked;
            View.TableLedOnClicked += View_TableLedOnClicked;
            View.TableLedOffClicked += View_TableLedOffClicked;

            View.ChangeImageButtonClicked += View_ChangeImageButtonClicked;
            View.SaveSpeedButtonClicked += View_SaveSpeedButtonClicked;
            View.SaveAccelButtonClicked += View_SaveAccelButtonClicked;
            View.SaveOffsetButtonClicked += View_SaveOffsetButtonClicked;
            View.SavePlusButtonClicked += View_SavePlusButtonClicked;

            View.ResetSpeedButtonClicked += View_ResetSpeedButtonClicked;
            View.ResetAccelButtonClicked += View_ResetAccelButtonClicked;
            View.ResetOffsetButtonClicked += View_ResetOffsetButtonClicked;
            View.ResetPlusButtonClicked += View_ResetPlusButtonClicked;

            View.SaveConnectionButtonClicked += View_SaveConnectionButtonClicked;
            View.ResetConnectionButtonClicked += View_ResetConnectionButtonClicked;
            View.CheckButtonClicked += View_CheckButtonClicked;
        }

        private void View_AxisSettingUCLoaded(object sender, EventArgs e)
        {
            View.Load_AxisSettingUC();
        }

        private void View_MoveUpXButtonClicked(object sender, EventArgs e)
        {
            View.MoveUp_X();
        }
        private void View_MoveDownXButtonClicked(object sender, EventArgs e)
        {
            View.MoveDown_X();
        }
        private void View_MoveUpYButtonClicked(object sender, EventArgs e)
        {
            View.MoveUp_Y();
        }
        private void View_MoveDownYButtonClicked(object sender, EventArgs e)
        {
            View.MoveDown_Y();
        }
        private void View_MoveUpZButtonClicked(object sender, EventArgs e)
        {
            View.MoveUp_Z();
        }
        private void View_MoveDownZButtonClicked(object sender, EventArgs e)
        {
            View.MoveDown_Z();
        }
        private void View_OpenTableButtonClicked(object sender, EventArgs e)
        {
            View.Click_OpenTableButton();
        }
        private void View_CloseTableButtonClicked(object sender, EventArgs e)
        {
            View.Click_CloseTableButton();
        }
        private void View_ResetButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetButton();
        }
        private void View_HomeButtonClicked(object sender, EventArgs e)
        {
            View.Click_HomeButton();
        }
        private void View_ParkingButtonClicked(object sender, EventArgs e)
        {
            View.Click_ParkingButton();
        }
        private void View_MachineLedOnClicked(object sender, EventArgs e)
        {
            View.Click_MachineLedOn();
        }
        private void View_MachineLedOffClicked(object sender, EventArgs e)
        {
            View.Click_MachineLedOff();
        }
        private void View_TableLedOnClicked(object sender, EventArgs e)
        {
            View.Click_TableLedOn();
        }
        private void View_TableLedOffClicked(object sender, EventArgs e)
        {
            View.Click_TableLedOff();
        }

        private void View_ChangeImageButtonClicked(object sender, EventArgs e)
        {
            View.Click_ChangeImageButton();
        }
        private void View_SaveSpeedButtonClicked(object sender, EventArgs e)
        {
            View.Click_SaveSpeedButton();
        }
        private void View_SaveAccelButtonClicked(object sender, EventArgs e)
        {
            View.Click_SaveAccelButton();
        }
        private void View_SaveOffsetButtonClicked(object sender, EventArgs e)
        {
            View.Click_SaveOffsetButton();
        }
        private void View_SavePlusButtonClicked(object sender, EventArgs e)
        {
            View.Click_SavePlusButton();
        }
        public void View_ResetSpeedButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetSpeedButton();
        }
        public void View_ResetAccelButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetAccelButton();
        }
        public void View_ResetOffsetButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetOffsetButton();
        }
        public void View_ResetPlusButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetPlusButton();
        }
        public void View_SaveConnectionButtonClicked(object sender, EventArgs e)
        {
            View.Click_SaveConnectionButton();
        }
        public void View_ResetConnectionButtonClicked(object sender, EventArgs e)
        {
            View.Click_ResetConnectionButton();
        }
        public void View_CheckButtonClicked(object sender, EventArgs e)
        {
            View.Click_CheckButton();
        }

    }
}
