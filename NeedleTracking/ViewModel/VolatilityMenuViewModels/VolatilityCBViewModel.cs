using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;
using NeedleTracking.UserControlUC;
using NeedleTracking.ViewModel;

namespace NeedleTracking.ViewModel.VolatilityMenuViewModels
{
    public class VolatilityCBViewModel : BaseViewModel
    {
        public List<NS_Buildings> _BuildingList { get; set; }
        public List<NS_Buildings> BuildingList
        {
            get { return _BuildingList; }
            set
            {
                _BuildingList = value;
                OnPropertyChanged("BuildingList");
            }
        }

        public List<NS_Devices> _MachineList { get; set; }
        public List<NS_Devices> MachineList
        {
            get { return _MachineList; }
            set
            {
                _MachineList = value;
                OnPropertyChanged("MachineList");
            }
        }
        

        public NS_Buildings _BuildingSelected { get; set; }
        public NS_Buildings BuildingSelected
        {
            get { return _BuildingSelected; }
            set
            {
                _BuildingSelected = value;
                OnPropertyChanged("BuildingSelected");
                if (BuildingSelected != null)
                { 
                    VolatilityMenu volatilityMenu = new VolatilityMenu();
                    var volatilitymenuVM = volatilityMenu.DataContext as VolatilityMenuViewModel;
                    volatilitymenuVM.SortedByEnable=true;
                }
            }
        }

        public NS_Devices _MachineSelected { get; set; }
        public NS_Devices MachineSelected
        {
            get { return _MachineSelected; }
            set
            {
                _MachineSelected = value;
                OnPropertyChanged("MachineSelected");
                if (MachineSelected != null)
                {
                    VolatilityMenu volatilityMenu = new VolatilityMenu();
                    var volatilitymenuVM = volatilityMenu.DataContext as VolatilityMenuViewModel;
                    volatilitymenuVM.SortedByEnable = true;
                }
            }
        }

        private bool _BuildingComboBoxEnable = true;
        public bool BuildingComboBoxEnable
        {
            get { return _BuildingComboBoxEnable; }
            set
            {
                _BuildingComboBoxEnable = value;
                OnPropertyChanged("BuildingComboBoxEnable");
            }
        }

        private bool _MachineComboBoxEnable = true;
        public bool MachineComboBoxEnable
        {
            get { return _MachineComboBoxEnable; }
            set
            {
                _MachineComboBoxEnable = value;
                OnPropertyChanged("MachineComboBoxEnable");
            }
        }



        public VolatilityCBViewModel()
        {
            var buildinglist = ImplementBase.Get_BuildingList();
            var machinelist = ImplementBase.Get_MachineList();
            this._BuildingList = buildinglist;
            this._MachineList = machinelist;
            BuildingComboBoxEnable = false;
            MachineComboBoxEnable = false;
        }
    }
}
