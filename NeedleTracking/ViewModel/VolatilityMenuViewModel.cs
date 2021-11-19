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
using EF_CONFIG.DataTransform;
using System.Collections.ObjectModel;
using EF_CONFIG.Model;

namespace NeedleTracking.ViewModel
{
    public class VolatilityMenuViewModel : BaseViewModel
    {

        public string DateString;
        private string _ViewDateString { get; set; }
        public string ViewDateString
        {
            get { return _ViewDateString; }
            set
            {
                _ViewDateString = value;
                OnPropertyChanged();
            }
        }

        private DateTime _SelectedDate { get; set; } = DateTime.Today;
        public DateTime SelectedDate
        {
            get { return _SelectedDate; }
            set
            {
                _SelectedDate = value;
                OnPropertyChanged("Date");
                DateString = SelectedDate.ToString("HH:mm MM:dd:yyyy");
                ViewDateString = SelectedDate.ToString("MMM dd, yyy");
            }
        }

        public bool _ApplyButtonEnable { get; set; } = false;
        public bool ApplyButtonEnable
        {
            get { return _ApplyButtonEnable; }
            set
            {
                _ApplyButtonEnable = value;
                OnPropertyChanged();
            }
        }

        public bool _PickDateEnable { get; set; }
        public bool PickDateEnable
        {
            get { return _PickDateEnable; }
            set
            {
                _PickDateEnable = value;
                OnPropertyChanged("PickDateEnable");
            }
        }

        public bool _SortedByEnable { get; set; }
        public bool SortedByEnable
        {
            get { return _SortedByEnable; }
            set
            {
                _SortedByEnable = value;
                OnPropertyChanged("SortedByEnable");
            }
        }

        private bool _AllRadioButtonIsChecked { get; set; }
        public bool AllRadioButtonIsChecked
        {
            get { return _AllRadioButtonIsChecked; }
            set
            {
                _AllRadioButtonIsChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _BuildingRadioButtonIsChecked { get; set; }
        public bool BuildingRadioButtonIsChecked
        {
            get { return _BuildingRadioButtonIsChecked; }
            set
            {
                _BuildingRadioButtonIsChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _MachineRadioButtonIsChecked { get; set; }
        public bool MachineRadioButtonIsChecked
        {
            get { return _MachineRadioButtonIsChecked; }
            set
            {
                _MachineRadioButtonIsChecked = value;
                OnPropertyChanged();
            }
        }

        private bool _DayChecked { get; set; }
        private bool _WeekChecked { get; set; }
        private bool _MonthChecked { get; set; }
        public bool DayChecked
        {
            get { return _DayChecked; }
            set
            {
                _DayChecked = value;
                OnPropertyChanged("DayChecked");
            }
        }
        public bool WeekChecked
        {
            get { return _WeekChecked; }
            set
            {
                _WeekChecked = value;
                OnPropertyChanged("WeekChecked");
            }
        }
        public bool MonthChecked
        {
            get { return _MonthChecked; }
            set
            {
                _MonthChecked = value;
                OnPropertyChanged("MonthChecked");
            }
        }

        bool[] MenuArray = new bool[6];

        bool[] AllDayArray = new bool[6] { true, false, false, true, false, false };
        bool[] AllWeekArray = new bool[6] { true, false, false, false, true, false };
        bool[] AllMonthArray = new bool[6] { true, false, false, false, false, true };
        bool[] BuldingDayArray = new bool[6] { false, true, false, true, false, false };
        bool[] BuldingWeekArray = new bool[6] { false, true, false, false, true, false };
        bool[] BuldingMonthArray = new bool[6] { false, true, false, false, false, true };
        bool[] MachineDayArray = new bool[6] { false, false, true, true, false, false };
        bool[] MachineWeekArray = new bool[6] { false, false, true, false, true, false };
        bool[] MachineMonthArray = new bool[6] { false, false, true, false, false, true };

        public ICommand AllRadioButtonChecked { get; set; }
        public ICommand BuildingRadioButtonChecked { get; set; }
        public ICommand MachineRadioButtonChecked { get; set; }

        public ICommand DayRadioButtonChecked { get; set; }
        public ICommand WeekRadioButtonChecked { get; set; }
        public ICommand MonthRadioButtonChecked { get; set; }

        public ICommand ApplyButtonClick { get; set; }

        public VolatilityMenuViewModel()
        {
            AllRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { AllRadioButtonCheckedCommand(); });
            BuildingRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { BuildingRadioButtonCheckedCommand(); });
            MachineRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { MachineRadioButtonCheckedCommand(); });


            DayRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { DayRadioButton_CheckedCommand(); });
            WeekRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { WeekRadioButton_CheckedCommand(); });
            MonthRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { MonthRadioButton_CheckedCommand(); });

            ApplyButtonClick = new RelayCommand<object>((p) => { return true; }, (p) => { ApplyButton_Command(); });
        }
        void AllRadioButtonCheckedCommand()
        {
            SetNullCombobox();
            SetRadioButtonEnable(false, false);
            this.SortedByEnable = true;
            ResetVaribles();

        }
        void BuildingRadioButtonCheckedCommand()
        {
            SetNullCombobox();
            SetRadioButtonEnable(true, false);
            this.SortedByEnable = false;
            ResetVaribles();
        }
        void MachineRadioButtonCheckedCommand()
        {
            SetNullCombobox();
            SetRadioButtonEnable(false, true);
            this.SortedByEnable = false;
            ResetVaribles();
        }
        void DayRadioButton_CheckedCommand()
        {
            this.PickDateEnable = true;
        }
        void WeekRadioButton_CheckedCommand()
        {
            this.PickDateEnable = true;

        }
        void MonthRadioButton_CheckedCommand()
        {
            this.PickDateEnable = true;

        }
        void ApplyButton_Command()
        {
            ApplyBoolArray();
            if (MenuArray.SequenceEqual(AllDayArray))
            {
                VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
                var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
                voladatagridVM.LoadDataGrid("All", null, SelectedDate, "Day");
                return;
            }
            if (MenuArray.SequenceEqual(AllWeekArray))
            {
                VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
                var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
                voladatagridVM.LoadDataGrid("All", null, SelectedDate, "Week");
                return;
            }
            if (MenuArray.SequenceEqual(AllMonthArray))
            {
                VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
                var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
                voladatagridVM.LoadDataGrid("All", null, SelectedDate, "Month");
                return;
            }
            if (MenuArray.SequenceEqual(BuldingDayArray))
            {
                VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
                VolatilityCombobox volatilityCombobox = new VolatilityCombobox();
                var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
                var volacomboboxVM = volatilityCombobox.DataContext as VolatilityCBViewModel;
                voladatagridVM.LoadDataGrid("All", null, SelectedDate, "Month");
                return;
            }
            if (MenuArray.SequenceEqual(BuldingWeekArray))
            {
                return;
            }
            if (MenuArray.SequenceEqual(BuldingMonthArray))
            {
                return;
            }
            if (MenuArray.SequenceEqual(MachineDayArray))
            {
                return;
            }
            if (MenuArray.SequenceEqual(MachineWeekArray))
            {
                return;
            }
            if (MenuArray.SequenceEqual(MachineMonthArray))
            {
                return;
            }
            else
            {
                return;
            }
        }
        void SetRadioButtonEnable(bool Building, bool Machine)
        {
            VolatilityCombobox volatilityCombobox = new VolatilityCombobox();
            var volatilityComboBoxVM = volatilityCombobox.DataContext as VolatilityCBViewModel;
            volatilityComboBoxVM.BuildingComboBoxEnable = Building;
            volatilityComboBoxVM.MachineComboBoxEnable = Machine;
        }
        void SetNullCombobox()
        {
            VolatilityCombobox volatilityCombobox = new VolatilityCombobox();
            var volatilityComboBoxVM = volatilityCombobox.DataContext as VolatilityCBViewModel;
            volatilityComboBoxVM.BuildingSelected = null;
            volatilityComboBoxVM.MachineSelected = null;
        }
        void ResetVaribles()
        {
            this.PickDateEnable = false;
            DayChecked = false;
            WeekChecked = false;
            MonthChecked = false;
            DateString = null;
            ViewDateString = null;
            VolatilityCombobox volatilityCombobox = new VolatilityCombobox();
            var volatilityComboBoxVM = volatilityCombobox.DataContext as VolatilityCBViewModel;
            volatilityComboBoxVM.BuildingSelectedName = null;
            volatilityComboBoxVM.MachineSelectedName = null;
            ApplyButtonEnable = false;
            VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
            var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
            if (voladatagridVM.ExtendExportList != null)
            {
                voladatagridVM.ExtendExportList.Clear();
            }
        }
        void ApplyBoolArray()
        {
            bool[] array = new bool[6];
            array[0] = AllRadioButtonIsChecked;
            array[1] = BuildingRadioButtonIsChecked;
            array[2] = MachineRadioButtonIsChecked;
            array[3] = DayChecked;
            array[4] = WeekChecked;
            array[5] = MonthChecked;
            MenuArray = array;
        }
    }
}
