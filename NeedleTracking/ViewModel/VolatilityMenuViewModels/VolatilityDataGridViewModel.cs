using EF_CONFIG.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;


namespace NeedleTracking.ViewModel.VolatilityMenuViewModels
{
    public class VolatilityDataGridViewModel : BaseViewModel
    {
        public List<NS_Needles> needles { get; set; }

        private ObservableCollection<VotatilityDatagridModel> _ExtendExportList { get; set; }
        public ObservableCollection<VotatilityDatagridModel> ExtendExportList
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

        public void LoadDataGrid(bool allboolean, int? buildingid, int? machineid, DateTime datetime, string dayweekmonth)
        {
            if (allboolean)
            {
                if (dayweekmonth == "Day")
                {
                    ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                    var ExportList = QuantityBase.Get_AllDayExports(datetime);
                    this.ExtendExportList.Clear();
                    int i = 1;
                    foreach (var item in ExportList)
                    {
                        var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                else if (dayweekmonth == "Week")
                {
                    ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                    var ExportList = QuantityBase.Get_AllWeekExports(datetime);
                    this.ExtendExportList.Clear();
                    int i = 1;
                    foreach (var item in ExportList)
                    {
                        var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                else if (dayweekmonth == "Month")
                {
                    ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                    var ExportList = QuantityBase.Get_AllMonthExports(datetime);
                    this.ExtendExportList.Clear();
                    int i = 1;
                    foreach (var item in ExportList)
                    {
                        var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
            else
            {
                if (buildingid != null)
                {
                    if (dayweekmonth == "Day")
                    {
                        ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                        var ExportList = QuantityBase.Get_BuildingDayExports(buildingid, datetime);
                        this.ExtendExportList.Clear();
                        int i = 1;
                        foreach (var item in ExportList)
                        {
                            var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();

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
                    else if (dayweekmonth == "Week")
                    {
                        ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                        var ExportList = QuantityBase.Get_BuildingWeekExports(buildingid, datetime);
                        this.ExtendExportList.Clear();
                        int i = 1;
                        foreach (var item in ExportList)
                        {
                            var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                    else if (dayweekmonth == "Month")
                    {
                        ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                        var ExportList = QuantityBase.Get_BuildingMonthExports(buildingid, datetime);
                        this.ExtendExportList.Clear();
                        int i = 1;
                        foreach (var item in ExportList)
                        {
                            var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                else
                {
                    if (machineid != null)
                    {
                        if (dayweekmonth == "Day")
                        {
                            ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                            var ExportList = QuantityBase.Get_MachineDayExports(machineid, datetime);
                            this.ExtendExportList.Clear();
                            int i = 1;
                            foreach (var item in ExportList)
                            {
                                var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                        else if (dayweekmonth == "Week")
                        {
                            ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                            var ExportList = QuantityBase.Get_MachineWeekExports(machineid, datetime);
                            this.ExtendExportList.Clear();
                            int i = 1;
                            foreach (var item in ExportList)
                            {
                                var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                        else if (dayweekmonth == "Month")
                        {
                            ExtendExportList = new ObservableCollection<VotatilityDatagridModel>();
                            var ExportList = QuantityBase.Get_MachineMonthExports(machineid, datetime);
                            this.ExtendExportList.Clear();
                            int i = 1;
                            foreach (var item in ExportList)
                            {
                                var needle = needles.Where(i => i.NeedleID == item.NeedleID).FirstOrDefault();
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
                }
            }
        }
    }
}
