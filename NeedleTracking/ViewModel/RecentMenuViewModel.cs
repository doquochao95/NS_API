using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NeedleTracking.UserControlUC.RecentUC;
using NeedleTracking.ViewModel.RecentMenuViewModels;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using EF_CONFIG.DataTransform;
using System.Collections.ObjectModel;
using EF_CONFIG.BaseModel;
using EF_CONFIG.Model;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.RecentUC;

using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace NeedleTracking.ViewModel
{
    public class RecentMenuViewModel : BaseViewModel
    {

        private int _SelectedDeviceID;
        public int SelectedDeviceID
        {
            get { return _SelectedDeviceID; }
            set
            {
                _SelectedDeviceID = value;
                OnPropertyChanged();
            }
        }
        public string DateString;
        private List<int> _devicelist;
        private List<Building> _Buildings;
        public List<Building> Buildings
        {
            get
            {
                return _Buildings;
            }
            set
            {
                _Buildings = value;
                OnPropertyChanged();
            }

        }
        public ICommand TreeViewSelectedItemChangedCommand { get; set; }

        public ICommand LoadedRecentMenuCommand { get; set; }

        public RecentMenuViewModel()
        {
            TreeViewSelectedItemChangedCommand = new RelayCommand<object>((p) => { return true; }, (p) => { TreeViewSelectedItemChanged_Command(p); });
            LoadedRecentMenuCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { LoadedWindowCommand(p); });
        }
        void TreeViewSelectedItemChanged_Command(object p)
        {
            var type = p.GetType();
            if (p == null || type != typeof(Device))
                return;
            var item = (Device)p;
            SelectedDeviceID = item.DeviceID;
            DeviceRecentUC deviceRecentUC = new DeviceRecentUC();
            var deviceRecentVM = deviceRecentUC.DataContext as DeviceRecentViewModel;
            if (deviceRecentVM != null)
            {
                deviceRecentVM.Load_UserControl(SelectedDeviceID);
            }
        }
        void LoadedWindowCommand(UserControl p)
        {
            _devicelist = new List<int>();
            var _buildinglist = new List<Building>();
            var buildingList = EF_CONFIG.DataTransform.ImplementBase.Get_BuildingList();
            foreach (var building in buildingList)
            {
                Building _building = new Building();
                var devicelist = new List<Device>();
                var devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithBuildingId(building.BuildingID);
                if (devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        var newdevice = new Device(device.DeviceID, device.DeviceName);
                        devicelist.Add(newdevice);
                        _devicelist.Add(device.DeviceID);
                    }
                    _building.Devices = devicelist;
                    _building.BuildingName = building.BuildingName;
                    _buildinglist.Add(_building);
                }
            }
            Buildings = _buildinglist;
        }
    }
}
