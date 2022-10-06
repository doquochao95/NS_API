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
using NeedleTracking.UserControlUC.HistoryUC;
using NeedleTracking.ViewModel.HistoryMenuViewModels;
using NeedleTracking.UserControlUC;
using System.Windows.Threading;

using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace NeedleTracking.ViewModel.HistoryMenuViewModels
{
    public class HistoryDataViewModel : BaseViewModel
    {
        private int _SelectedDeviceID;
        private DateTime _SelectedDate;
        private ObservableCollection<HistoryDataGridModel> _HistoryDataList { get; set; }
        public ObservableCollection<HistoryDataGridModel> HistoryDataList
        {
            get { return _HistoryDataList; }
            set
            {
                _HistoryDataList = value;
                OnPropertyChanged();
            }
        }
        private HistoryDataGridModel _SelectedDataGridValue;
        public HistoryDataGridModel SelectedDataGridValue
        {
            get { return _SelectedDataGridValue; }
            set
            {
                _SelectedDataGridValue = value;
                OnPropertyChanged();
            }
        }

        private bool _InformationEnable = false;
        public bool InformationEnable
        {
            get { return _InformationEnable; }
            set
            {
                _InformationEnable = value;
                OnPropertyChanged();
            }
        }

        private string _StatusLabelContent;
        public string StatusLabelContent
        {
            get { return _StatusLabelContent; }
            set
            {
                _StatusLabelContent = value;
                OnPropertyChanged();
            }
        }

        private string _NeedleName;
        public string NeedleName
        {
            get { return _NeedleName; }
            set
            {
                _NeedleName = value;
                OnPropertyChanged();
            }
        }
        private string _PO;
        public string PO
        {
            get { return _PO; }
            set
            {
                _PO = value;
                OnPropertyChanged();
            }
        }
        private string _RemovedBy;
        public string RemovedBy
        {
            get { return _RemovedBy; }
            set
            {
                _RemovedBy = value;
                OnPropertyChanged();
            }
        }
        private string _BrokenBy;
        public string BrokenBy
        {
            get { return _BrokenBy; }
            set
            {
                _BrokenBy = value;
                OnPropertyChanged();
            }
        }
        private string _SewingMachine;
        public string SewingMachine
        {
            get { return _SewingMachine; }
            set
            {
                _SewingMachine = value;
                OnPropertyChanged();
            }
        }
        private string _RemoveTimeString;
        public string RemoveTimeString
        {
            get { return _RemoveTimeString; }
            set
            {
                _RemoveTimeString = value;
                OnPropertyChanged();
            }
        }
        private string _ConfirmBy;
        public string ConfirmBy
        {
            get { return _ConfirmBy; }
            set
            {
                _ConfirmBy = value;
                OnPropertyChanged();
            }
        }
        private string _BrokenTimeString;
        public string BrokenTimeString
        {
            get { return _BrokenTimeString; }
            set
            {
                _BrokenTimeString = value;
                OnPropertyChanged();
            }
        }
        private string _ConfirmTimeString;
        public string ConfirmTimeString
        {
            get { return _ConfirmTimeString; }
            set
            {
                _ConfirmTimeString = value;
                OnPropertyChanged();
            }
        }
        private string _Handle;
        public string Handle
        {
            get { return _Handle; }
            set
            {
                _Handle = value;
                OnPropertyChanged();
            }
        }
        private string _NeedlePart;
        public string NeedlePart
        {
            get { return _NeedlePart; }
            set
            {
                _NeedlePart = value;
                OnPropertyChanged();
            }
        }
        private string _Reason;
        public string Reason
        {
            get { return _Reason; }
            set
            {
                _Reason = value;
                OnPropertyChanged();
            }
        }
        private string _Process;
        public string Process
        {
            get { return _Process; }
            set
            {
                _Process = value;
                OnPropertyChanged();
            }
        }

        bool[] MenuArray = new bool[3];
        bool[] DayArray = new bool[3] { true, false, false };
        bool[] WeefArray = new bool[3] { false, true, false };
        bool[] MonthArray = new bool[3] { false, false, true };

        public ICommand LoadHistoryDataViewCommand { get; set; }
        public ICommand SelectDataGridCommand { get; set; }


        public HistoryDataViewModel()
        {
            LoadHistoryDataViewCommand = new RelayCommand<object>((p) => { return true; }, (p) => { LoadHistoryDataView(); });
            SelectDataGridCommand = new RelayCommand<object>((p) => { return true; }, (p) => { UpdateTextboxs(); });

        }
        void LoadHistoryDataView()
        {

        }
        void UpdateTextboxs()
        {
            if (SelectedDataGridValue != null)
            {
                NeedleName = SelectedDataGridValue.NS_RecycledBox.NS_Needles.NeedleName.ToString();
                RemovedBy = SelectedDataGridValue.NS_RecycledBox.NS_Staffs2.StaffName;
                BrokenBy = SelectedDataGridValue.NS_RecycledBox.Operator.ToString();
                SewingMachine = SelectedDataGridValue.NS_RecycledBox.SewingMachine;
                RemoveTimeString = SelectedDataGridValue.NS_RecycledBox.DeleteTimeStr;
                BrokenTimeString = SelectedDataGridValue.NS_RecycledBox.BrokenTimeStr;
                if (SelectedDataGridValue.NS_RecycledBox.NeedlePartsEnough == 1)
                {
                    NeedlePart = "Đủ Bộ Phận";
                    PO = null;
                    Handle = null;
                    ConfirmBy = null;
                    ConfirmTimeString = null;
                }
                else
                {
                    NeedlePart = "Không Đủ Bộ Phận";
                    PO = SelectedDataGridValue.NS_RecycledBox.PO;
                    Handle = SelectedDataGridValue.NS_RecycledBox.Handle;
                    ConfirmBy = SelectedDataGridValue.NS_RecycledBox.NS_Staffs1.StaffName;
                    ConfirmTimeString = SelectedDataGridValue.NS_RecycledBox.ConfirmationTimeStr;
                }
                if (SelectedDataGridValue.NS_RecycledBox.NS_BrokenReason.ReasonName == "Bent")
                {
                    Reason = "Cong"; 
                }
                else if (SelectedDataGridValue.NS_RecycledBox.NS_BrokenReason.ReasonName == "Broken")
                {
                    Reason = "Gãy";
                }
                else
                {
                    Reason = "Gãy và Cong";
                }
                Process = SelectedDataGridValue.NS_RecycledBox.NS_Process.ProcessName;
            }
        }
        public void LoadDataGrid()
        {
            LoadDataGridView(_SelectedDeviceID, MenuArray, _SelectedDate);
        }
        public ObservableCollection<HistoryDataGridModel> LoadDataGridView(int deviceID, bool[] array, DateTime selectedDate)
        {
            MenuArray = array;
            _SelectedDeviceID = deviceID;
            _SelectedDate = selectedDate;
            if (MenuArray.SequenceEqual(DayArray))
            {
                HistoryDataList = new ObservableCollection<HistoryDataGridModel>();
                HistoryDataList.Clear();
                var List = EF_CONFIG.DataTransform.RecycledBoxBase.Get_AllRecycleBinUnavailable(_SelectedDeviceID);
                if (List != null)
                {
                    int i = 1;
                    var historyList = new List<NS_RecycledBox>();
                    foreach (var recycledBox in List)
                    {
                        if (recycledBox.ExportTime.Date == selectedDate.Date)
                        {
                            historyList.Add(recycledBox);
                        }
                    }
                    foreach (var item in historyList)
                    {
                        item.NS_BrokenReason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.ReasonID);
                        item.NS_Devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.DeviceID);
                        item.NS_Process = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.ProcessID);
                        item.NS_Needles = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NeedleID);
                        item.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.GetByStaffID);
                        item.NS_Staffs.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(item.NS_Staffs.LineID);
                        item.NS_Staffs1 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.ConfirmationByStaffID);
                        item.NS_Staffs2 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.DeleteByStaffID);
                        item.NS_Devices.NS_Buildings = EF_CONFIG.DataTransform.BuildingBase.Get_Building(item.NS_Devices.BuildingID);
                        HistoryDataGridModel historyData = new HistoryDataGridModel()
                        {
                            SN = i,
                            NS_RecycledBox = item
                        };
                        HistoryDataList.Add(historyData);
                        i++;
                    }
                }
            }
            if (MenuArray.SequenceEqual(WeefArray))
            {
                
                HistoryDataList = new ObservableCollection<HistoryDataGridModel>();
                HistoryDataList.Clear();
                var List = EF_CONFIG.DataTransform.RecycledBoxBase.Get_AllRecycleBinUnavailable(_SelectedDeviceID);
                if (List != null)
                {
                    int i = 1;
                    var historyList = new List<NS_RecycledBox>();
                    DateTime startDayOfWeek = selectedDate.AddDays(-1 * (int)(selectedDate.DayOfWeek));
                    DateTime endDayOfWeek = selectedDate.AddDays(7 - (int)selectedDate.DayOfWeek);
                    foreach (var recycledBox in List)
                    {
                        if (recycledBox.ExportTime >= startDayOfWeek && recycledBox.ExportTime <=endDayOfWeek)
                        {
                            historyList.Add(recycledBox);
                        }
                    }
                    foreach (var item in historyList)
                    {
                        item.NS_BrokenReason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.ReasonID);
                        item.NS_Devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.DeviceID);
                        item.NS_Process = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.ProcessID);
                        item.NS_Needles = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NeedleID);
                        item.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.GetByStaffID);
                        item.NS_Staffs.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(item.NS_Staffs.LineID);
                        item.NS_Staffs1 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.ConfirmationByStaffID);
                        item.NS_Staffs2 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.DeleteByStaffID);
                        item.NS_Devices.NS_Buildings = EF_CONFIG.DataTransform.BuildingBase.Get_Building(item.NS_Devices.BuildingID);
                        HistoryDataGridModel historyData = new HistoryDataGridModel()
                        {
                            SN = i,
                            NS_RecycledBox = item
                        };
                        HistoryDataList.Add(historyData);
                        i++;
                    }
                }
            }
            if (MenuArray.SequenceEqual(MonthArray))
            {
                HistoryDataList = new ObservableCollection<HistoryDataGridModel>();
                HistoryDataList.Clear();
                var List = EF_CONFIG.DataTransform.RecycledBoxBase.Get_AllRecycleBinUnavailable(_SelectedDeviceID);
                if (List != null)
                {
                    int i = 1;
                    var historyList = new List<NS_RecycledBox>();
                    foreach (var recycledBox in List)
                    {
                        if (recycledBox.ExportTime.Date.Month == selectedDate.Date.Month)
                        {
                            historyList.Add(recycledBox);
                        }
                    }
                    foreach (var item in historyList)
                    {
                        item.NS_BrokenReason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.ReasonID);
                        item.NS_Devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.DeviceID);
                        item.NS_Process = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.ProcessID);
                        item.NS_Needles = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NeedleID);
                        item.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.GetByStaffID);
                        item.NS_Staffs.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(item.NS_Staffs.LineID);
                        item.NS_Staffs1 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.ConfirmationByStaffID);
                        item.NS_Staffs2 = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.DeleteByStaffID);
                        item.NS_Devices.NS_Buildings = EF_CONFIG.DataTransform.BuildingBase.Get_Building(item.NS_Devices.BuildingID);
                        HistoryDataGridModel historyData = new HistoryDataGridModel()
                        {
                            SN = i,
                            NS_RecycledBox = item
                        };
                        HistoryDataList.Add(historyData);
                        i++;
                    }
                }
            }
            SetElementEnable();
            return HistoryDataList;
        }
        private void SetElementEnable()
        {
            InformationEnable = true;
            StatusLabelContent = "Select your filter";
        }
    }
}
