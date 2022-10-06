using EF_CONFIG.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using NeedleTracking.UserControlUC.RequestUC;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using System.Windows;
using System.Windows.Input;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using NeedleTracking.UserControlUC;
using System.Windows.Threading;

using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Windows.Controls;

namespace NeedleTracking.ViewModel.RequestMenuViewModels
{
    public class RequestDataGridViewModel : BaseViewModel
    {

        private int _SelectedDeviceID;
        private string _SelectedDeviceName = "Device";
        public string SelectedDeviceName
        {
            get { return _SelectedDeviceName; }
            set
            {
                _SelectedDeviceName = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<LogListViewModel> _LogList = new ObservableCollection<LogListViewModel>();
        public ObservableCollection<LogListViewModel> LogList
        {
            get { return _LogList; }
            set
            {
                _LogList = value;
                OnPropertyChanged();
            }
        }

        private LogListViewModel _SelectedLogMessage { get; set; }
        public LogListViewModel SelectedLogMessage
        {
            get { return _SelectedLogMessage; }
            set
            {
                _SelectedLogMessage = value;
                OnPropertyChanged();
            }
        }

        public RequestDataGridViewModel()
        {              
        }
        public void LoadListView(int deviceID)
        {
            _SelectedDeviceID = deviceID;
            SelectedDeviceName = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(_SelectedDeviceID).DeviceName;
            var list = EF_CONFIG.DataTransform.LogBase.Get_AllLogEvent(_SelectedDeviceID);
            foreach (var item in list)
            {
                LogListViewModel log = new LogListViewModel()
                {
                    DateTime = item.TimeStamp,
                    LogType = item.LogType,
                    Message = item.Message,
                };
                LogList.Add(log);
            }
            SelectedLogMessage=LogList.Last();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += DispatcherTimer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Start();
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            var item = EF_CONFIG.DataTransform.LogBase.Get_MostRecentLogEvent(_SelectedDeviceID);
            var lastlog = LogList.Last();
            if (item.TimeStamp != lastlog.DateTime)
            {
                LogListViewModel log = new LogListViewModel()
                {
                    DateTime = item.TimeStamp,
                    LogType = item.LogType,
                    Message = item.Message,
                };
                LogList.Add(log);
                SelectedLogMessage = LogList.Last();
            }
        }
    }
}