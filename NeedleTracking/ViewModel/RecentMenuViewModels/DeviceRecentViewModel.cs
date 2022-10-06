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
using NeedleTracking.UserControlUC.RecentUC;
using NeedleTracking.ViewModel.RecentMenuViewModels;
using NeedleTracking.UserControlUC;
using System.Windows.Threading;

using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace NeedleTracking.ViewModel.RecentMenuViewModels
{
    public class DeviceRecentViewModel : BaseViewModel
    {
        public  List<NS_Needles> needle { get; set; }

        private ObservableCollection<NeedleRemainingDataGridModel> _NeedleRemainingDataList { get; set; }
        public ObservableCollection<NeedleRemainingDataGridModel> NeedleRemainingDataList
        {
            get { return _NeedleRemainingDataList; }
            set
            {
                _NeedleRemainingDataList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<RecycleNeedleInBoxDataGridModel> _RecycleNeedleInBoxDataList { get; set; }
        public ObservableCollection<RecycleNeedleInBoxDataGridModel> RecycleNeedleInBoxDataList
        {
            get { return _RecycleNeedleInBoxDataList; }
            set
            {
                _RecycleNeedleInBoxDataList = value;
                OnPropertyChanged();
            }
        }
        private NeedleRemainingDataGridModel _SelectedDataGrid1Value;
        public NeedleRemainingDataGridModel SelectedDataGrid1Value
        {
            get { return _SelectedDataGrid1Value; }
            set
            {
                _SelectedDataGrid1Value = value;
                OnPropertyChanged();
            }
        }
        private RecycleNeedleInBoxDataGridModel _SelectedDataGrid2Value;
        public RecycleNeedleInBoxDataGridModel SelectedDataGrid2Value
        {
            get { return _SelectedDataGrid2Value; }
            set
            {
                _SelectedDataGrid2Value = value;
                OnPropertyChanged();
            }
        }
        private string _Device = "Device *";
        public string Device
        {
            get { return _Device; }
            set
            {
                _Device = value;
                OnPropertyChanged();
            }
        }
        private string _InTable ;
        public string InTable
        {
            get { return _InTable; }
            set
            {
                _InTable = value;
                OnPropertyChanged();
            }
        }
        private string _InBox ;
        public string InBox
        {
            get { return _InBox; }
            set
            {
                _InBox = value;
                OnPropertyChanged();
            }
        }
        private System.Windows.Media.Brush _foregroundColor = System.Windows.Media.Brushes.DarkSeaGreen;

        public System.Windows.Media.Brush ForegroundColor
        {
            get { return _foregroundColor; }
            set
            {
                _foregroundColor = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectDataGrid1Command { get; set; }
        public ICommand SelectDataGrid2Command { get; set; }

        public DeviceRecentViewModel()
        {
        }
        public void Load_UserControl(int SelectedDeviceID)
        {
            NS_Devices devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(SelectedDeviceID);
            Device = devices.DeviceName;
            if (devices.OnlineStatus == "ONLINE")
            {
                ForegroundColor = System.Windows.Media.Brushes.DarkSeaGreen;
            }
            else
            {
                ForegroundColor = System.Windows.Media.Brushes.DarkRed;
            }
            int i = 1;
            int quant = 0;
            var RemainingList = new ObservableCollection<NeedleRemainingDataGridModel>();
            var stocks = EF_CONFIG.DataTransform.StockBase.Get_AllNeedleInStockWithDeviceID(SelectedDeviceID);
            foreach (var stock in stocks)
            {
                NeedleRemainingDataGridModel needleRemaining = new NeedleRemainingDataGridModel()
                {
                    SN = i,
                    Needle = needle.Where(x => x.NeedleID == stock.NeedleID).Select(i=>i.NeedleName).FirstOrDefault().ToString(),
                    NeedleName = needle.Where(x => x.NeedleID == stock.NeedleID).Select(i => i.NeedleWarehouseCode).FirstOrDefault().ToString(),
                    StockName = stock.StockName,
                    Quantity = stock.CurrentQuantity
                };
                RemainingList.Add(needleRemaining);
                quant = quant + needleRemaining.Quantity;
                i++;
            }
            NeedleRemainingDataList = RemainingList;
            InTable = quant.ToString();
            i = 1;
            var RecycleInboxList = new ObservableCollection<RecycleNeedleInBoxDataGridModel>();
            var recyleinBox = EF_CONFIG.DataTransform.RecycledBoxBase.Get_AllRecycleBinAvailable(SelectedDeviceID);
            foreach(var recylein in recyleinBox)
            {
                recylein.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(recylein.GetByStaffID);
                RecycleNeedleInBoxDataGridModel recycleNeedleInBoxDataGrid = new RecycleNeedleInBoxDataGridModel()
                {
                    SN = i,
                    Needle = needle.Where(x => x.NeedleID == recylein.NeedleID).Select(i => i.NeedleName).FirstOrDefault().ToString(),
                    NeedleName = needle.Where(x => x.NeedleID == recylein.NeedleID).Select(i => i.NeedleWarehouseCode).FirstOrDefault().ToString(),
                    Staffname = EF_CONFIG.DataTransform.StaffBase.Get_Staff(recylein.GetByStaffID).StaffName,
                    LineName = EF_CONFIG.DataTransform.LineBase.Get_Line(recylein.NS_Staffs.LineID).LineName,
                    ExportTimeString = recylein.ExportTimeStr
                };
                if(recylein.NeedlePartsEnough==1)
                {
                    recycleNeedleInBoxDataGrid.PartEnough = " Đủ Bộ Phận";
                }
                else
                {
                    recycleNeedleInBoxDataGrid.PartEnough = "Không Đủ Bộ Phận";
                }
                RecycleInboxList.Add(recycleNeedleInBoxDataGrid);
                i++;
            }
            RecycleNeedleInBoxDataList = RecycleInboxList;
            InBox = RecycleNeedleInBoxDataList.Count().ToString();

        }
    }
}
