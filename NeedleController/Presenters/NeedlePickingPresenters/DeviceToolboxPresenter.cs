using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Views.NeedlePickingUCs;

namespace NeedleController.Presenters.NeedlePickingPresenters
{
    public class DeviceToolboxPresenter : Presenter<IDeviceToolboxUC>
    {
        public DeviceToolboxPresenter(IDeviceToolboxUC view) : base(view)
        {
            View.ResetDeviceButtonClicked += View_ResetDeviceButtonClicked;
            View.ParkingDeviceButtonClicked += View_ParkingDeviceButtonClicked;
            View.UnparkingDeviceButtonClicked += View_UnparkingDeviceButtonClicked;
            View.MachineLightOnButtonClicked += View_MachineLightOnButtonClicked;
            View.MachineLightOffButtonClicked += View_MachineLightOffButtonClicked;
            View.TableLightOnButtonClicked += View_TableLightOnButtonClicked;
            View.TableLightOffButtonClicked += View_TableLightOffButtonClicked;
        }

        void View_ResetDeviceButtonClicked(object sender, EventArgs e)
        {
            View.ResetDevice();
        }
        void View_ParkingDeviceButtonClicked(object sender, EventArgs e)
        {
            View.ParkingDevice();
        }
        void View_UnparkingDeviceButtonClicked(object sender, EventArgs e)
        {
            View.UnparkingDevice();
        }
        void View_MachineLightOnButtonClicked(object sender, EventArgs e)
        {
            View.TurnOnMachineLight();
        }
        void View_MachineLightOffButtonClicked(object sender, EventArgs e)
        {
            View.TurnOffMachineLight();
        }
        void View_TableLightOnButtonClicked(object sender, EventArgs e)
        {
            View.TurnOnTableLight();
        }
        void View_TableLightOffButtonClicked(object sender, EventArgs e)
        {
            View.TurnOffTableLight();
        }
    }
}
