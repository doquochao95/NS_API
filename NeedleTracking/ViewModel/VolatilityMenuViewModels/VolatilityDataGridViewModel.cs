using EF_CONFIG.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;

namespace NeedleTracking.ViewModel.VolatilityMenuViewModels
{
    public class VolatilityDataGridViewModel : BaseViewModel
    {
        private ObservableCollection<VotatilityDatagridModel>? _ExtendExportList { get; set; }
        public ObservableCollection<VotatilityDatagridModel>? ExtendExportList
        {
            get { return _ExtendExportList; }
            set
            {
                _ExtendExportList = value;
                OnPropertyChanged();
            }
        }

        public VolatilityDataGridViewModel()
        {

        }

        public void LoadDataGrid(string buildingstr, int? machineID, DateTime datetime, string dayweekmonth)
        {
            if (buildingstr == "All" && dayweekmonth == "Day")
            {
                ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                var ExportList = QuantityBase.Get_AllDayExports(datetime);
                this.ExtendExportList.Clear();
                int i = 1;
                foreach (var item in ExportList)
                {
                    var needle = NeedleBase.Get_NeedleByExportItem(item);
                    var building = ImplementBase.Get_BuildingByExportItem(item);
                    var device = ImplementBase.Get_MachineByExportItem(item);
                    var staff = StaffBase.Get_StaffByExportItem(item);
                    VotatilityDatagridModel votatilityDatagridModel = new VotatilityDatagridModel();
                    votatilityDatagridModel.SN = i;
                    votatilityDatagridModel.NS_Export = item;
                    votatilityDatagridModel.NS_Buildings = building;
                    votatilityDatagridModel.NS_Devices = device;
                    votatilityDatagridModel.NS_Needles = needle;
                    votatilityDatagridModel.NS_Staffs = staff;
                    ExtendExportList.Add(votatilityDatagridModel);
                    i++;
                }
            }
            else if (buildingstr == "All" && dayweekmonth == "Week")
            {
                ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                var ExportList = QuantityBase.Get_AllWeekExports(datetime);
                this.ExtendExportList.Clear();
                int i = 1;
                foreach (var item in ExportList)
                {
                    var needle = NeedleBase.Get_NeedleByExportItem(item);
                    var building = ImplementBase.Get_BuildingByExportItem(item);
                    var device = ImplementBase.Get_MachineByExportItem(item);
                    var staff = StaffBase.Get_StaffByExportItem(item);
                    VotatilityDatagridModel votatilityDatagridModel = new VotatilityDatagridModel();
                    votatilityDatagridModel.SN = i;
                    votatilityDatagridModel.NS_Export = item;
                    votatilityDatagridModel.NS_Buildings = building;
                    votatilityDatagridModel.NS_Devices = device;
                    votatilityDatagridModel.NS_Needles = needle;
                    votatilityDatagridModel.NS_Staffs = staff;
                    ExtendExportList.Add(votatilityDatagridModel);
                    i++;
                }
            }
            else if (buildingstr == "All" && dayweekmonth == "Month")
            {
                ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                var ExportList = QuantityBase.Get_AllMonthExports(datetime);
                this.ExtendExportList.Clear();
                int i = 1;
                foreach (var item in ExportList)
                {
                    var needle = NeedleBase.Get_NeedleByExportItem(item);
                    var building = ImplementBase.Get_BuildingByExportItem(item);
                    var device = ImplementBase.Get_MachineByExportItem(item);
                    var staff = StaffBase.Get_StaffByExportItem(item);
                    VotatilityDatagridModel votatilityDatagridModel = new VotatilityDatagridModel();
                    votatilityDatagridModel.SN = i;
                    votatilityDatagridModel.NS_Export = item;
                    votatilityDatagridModel.NS_Buildings = building;
                    votatilityDatagridModel.NS_Devices = device;
                    votatilityDatagridModel.NS_Needles = needle;
                    votatilityDatagridModel.NS_Staffs = staff;
                    ExtendExportList.Add(votatilityDatagridModel);
                    i++;
                }
            }
            else
            {
                return;
            }
        }

        /*public void LoadDataGrid()
        {
            ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
            var ExportList = QuantityBase.Get_AllExports();
            this.ExtendExportList.Clear();
            int i=1;
            foreach( var item in ExportList)
            {
                var needle = NeedleBase.Get_NeedleByExportItem(item);
                var building = ImplementBase.Get_BuildingByExportItem(item);
                var device = ImplementBase.Get_MachineByExportItem(item);
                var staff = StaffBase.Get_StaffByExportItem(item);
                VotatilityDatagridModel votatilityDatagridModel = new VotatilityDatagridModel();
                votatilityDatagridModel.SN=i;
                votatilityDatagridModel.NS_Export=item;
                votatilityDatagridModel.NS_Buildings=building;
                votatilityDatagridModel.NS_Devices= device;
                votatilityDatagridModel.NS_Needles=needle;
                votatilityDatagridModel.NS_Staffs=staff;
                ExtendExportList.Add(votatilityDatagridModel);
                i++;
            }
        }*/

    }
}
