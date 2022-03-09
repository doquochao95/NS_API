using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace NeedleController.Views.NeedlePickingUCs
{
    public interface IDeviceToolboxUC : IView
    {
        event EventHandler ResetDeviceButtonClicked;
        event EventHandler ParkingDeviceButtonClicked;
        event EventHandler UnparkingDeviceButtonClicked;
        event EventHandler MachineLightOnButtonClicked;
        event EventHandler MachineLightOffButtonClicked;
        event EventHandler TableLightOnButtonClicked;
        event EventHandler TableLightOffButtonClicked;

        void ResetDevice();
        void ParkingDevice();
        void UnparkingDevice();
        void TurnOnMachineLight();
        void TurnOffMachineLight();
        void TurnOnTableLight();
        void TurnOffTableLight();

    }
}
