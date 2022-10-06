using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using EF_CONFIG.DataTransform;
using System.Collections.ObjectModel;
using EF_CONFIG.BaseModel;
using EF_CONFIG.Model;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.RequestUC;

using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace NeedleTracking.ViewModel
{
    public class RequestMenuViewModel : BaseViewModel
    {
        private List<int> _devicelist;
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
        public ICommand LoadedRequestMenuCommand { get; set; }

        public RequestMenuViewModel()
        {
            TreeViewSelectedItemChangedCommand = new RelayCommand<object>((p) => { return true; }, (p) => { TreeViewSelectedItemChanged_Command(p); });
            LoadedRequestMenuCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { LoadedWindowCommand(p); });
        }
        void TreeViewSelectedItemChanged_Command(object p)
        {
            var type = p.GetType();
            if (p == null || type != typeof(Device))
                return;
            var item = (Device)p;
            SelectedDeviceID = item.DeviceID;
            if (_devicelist.Contains(SelectedDeviceID))
            {
                LoadingWindow loadingWindow = new LoadingWindow();
                var loadingWindowVM = loadingWindow.DataContext as LoadingViewModel;
                loadingWindow.Show();
                RequestDataGridUC requestDataGridUC = new RequestDataGridUC();
                var requestDataGridVM = requestDataGridUC.DataContext as RequestDataGridViewModel;
                requestDataGridVM.LoadListView(SelectedDeviceID);
                loadingWindowVM.IsLoadedDone = true;
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
        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }

            return parent;
        }
    }
    public class Building : BaseViewModel
    {
        private List<Device> _Devices;
        public List<Device> Devices
        {
            get
            {
                return _Devices;
            }
            set
            {
                _Devices = value;
                OnPropertyChanged();
            }
        }
        public string BuildingName { get; set; }



    }
    public class Device : BaseViewModel
    {
        public int _DeviceID;
        public int DeviceID
        {
            get
            {
                return _DeviceID;
            }
            set
            {
                _DeviceID = value;
                OnPropertyChanged();
            }
        }

        private string _DeviceName;
        public string DeviceName
        {
            get
            {
                return _DeviceName;
            }
            set
            {
                _DeviceName = value;
                OnPropertyChanged();
            }
        }
        public Device(int id, string name)
        {
            DeviceID = id;
            DeviceName = name;
        }
    }

}
