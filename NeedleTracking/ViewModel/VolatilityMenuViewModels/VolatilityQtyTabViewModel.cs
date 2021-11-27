using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeedleTracking.UserControlUC;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.ViewModel;
using EF_CONFIG.DataTransform;

namespace NeedleTracking.ViewModel.VolatilityMenuViewModels
{
    public class VolatilityQtyTabViewModel : BaseViewModel
    {
        private int _TotalUsage { get; set; }
        public int TotalUsage
        {
            get { return _TotalUsage; }
            set
            {
                _TotalUsage = value;
                OnPropertyChanged();
            }
        }
        private int _TotalType { get; set; }
        public int TotalType
        {
            get { return _TotalType; }
            set
            {
                _TotalType = value;
                OnPropertyChanged();
            }
        }
        private decimal _TotalPrice { get; set; }
        public decimal TotalPrice
        {
            get { return _TotalPrice; }
            set
            {
                _TotalPrice = value;
                OnPropertyChanged();
            }
        }

        public void CalculateVarible()
        {
            VolatilityDataGrid volatilityDataGrid = new VolatilityDataGrid();
            var voladatagridVM = volatilityDataGrid.DataContext as VolatilityDataGridViewModel;
            int quantity = voladatagridVM.ExtendExportList.Sum(i => i.NS_Export.Quantity);
            TotalUsage = quantity;
            int types = voladatagridVM.ExtendExportList.Select(i => i.NS_Export.NeedleID).Distinct().Count();
            TotalType = types;
            TotalPrice = 0;
            var ExportList = voladatagridVM.ExtendExportList;
            foreach (var item in ExportList)
            {
                var Needle = NeedleBase.Get_NeedleByVotatilityDatagridModelItem(item);
                TotalPrice = _TotalPrice + Needle.NeedlePrice;
            }


        }


    }
}
