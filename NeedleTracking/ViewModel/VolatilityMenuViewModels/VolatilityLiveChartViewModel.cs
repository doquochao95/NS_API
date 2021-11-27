using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.BaseModel;
using NeedleTracking.ViewModel;
using NeedleTracking.ViewModel.VolatilityMenuViewModels;
using NeedleTracking.UserControlUC.VolatilityUC;
using NeedleTracking.UserControlUC;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows.Media;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Collections.Generic;
using EF_CONFIG.DataTransform;

namespace NeedleTracking.ViewModel.VolatilityMenuViewModels
{
    public class VolatilityLiveChartViewModel : BaseViewModel
    {
        private ObservableCollection<VolatilityLiveChartModel> _ExtendLiveChartExportList { get; set; }
        public ObservableCollection<VolatilityLiveChartModel> ExtendLiveChartExportList
        {
            get { return _ExtendLiveChartExportList; }
            set
            {
                _ExtendLiveChartExportList = value;
                OnPropertyChanged();
            }
        }
        private SeriesCollection _seriesCollection { get; set; }
        public SeriesCollection SeriesCollection
        {
            get { return _seriesCollection; }
            set
            {
                _seriesCollection = value;
                OnPropertyChanged("SeriesCollection");
            }
        }


        private string[] _Labels { get; set; }
        public string[] Labels
        {
            get { return _Labels; }
            set
            {
                _Labels = value;
                OnPropertyChanged();
            }
        }
        public Func<double, string> YFormatter { get; set; }

        public VolatilityLiveChartViewModel()
        {

        }
        public void UpdateAllDayLiveChart()
        {
            SeriesCollection = new SeriesCollection();
            SeriesCollection.Clear();
            ChartValues<ObservableValue> values = new ChartValues<ObservableValue>();
            double value = 0;
            List<string> list = new List<string>();
            var datetimes = ExtendLiveChartExportList.Select(i => Convert.ToDateTime(i.DateTime.ToString("d"))).Distinct().ToList();
            var dates = new List<DateTime>();
            DateTime lastday = Convert.ToDateTime(DateTime.Today.ToString("d"));
            for (var dt = datetimes.First(); dt <= DateTime.Today; dt = dt.AddDays(1))
            {
                dates.Add(Convert.ToDateTime(dt.ToString("d")));
            }
            foreach (var date in dates)
            {
                foreach (var datetime in datetimes)
                {
                    if (date == datetime)
                    {
                        if (datetime != lastday)
                        {
                            value = 0;
                            var data = ExtendLiveChartExportList
                                .Where(p => Convert.ToDateTime(p.DateTime.ToString("d")) == Convert.ToDateTime(datetime.ToString("d")))
                                .OrderBy(p => p.DateTime)
                                .Select(p => new { p.Quantity })
                                .ToArray();
                            for (int e = 0; e < data.Count(); e++)
                            {
                                value += data[e].Quantity;
                            }
                            lastday = datetime;
                        }
                        else
                        {
                            var data = ExtendLiveChartExportList
                                .Where(p => Convert.ToDateTime(p.DateTime.ToString("d")) == Convert.ToDateTime(datetime.ToString("d")))
                                .OrderBy(p => p.DateTime)
                                .Select(p => new { p.Quantity })
                                .ToArray();
                            for (int e = 0; e < data.Count(); e++)
                            {
                                value += data[e].Quantity;
                            }
                            lastday = datetime;
                        }
                        break;
                    }
                    else
                    {
                        value = 0;
                        lastday = datetime;
                    }
                }
                values.Add(new ObservableValue(value));
                list.Add(date.ToString("d"));
            }
            SeriesCollection.Add(new LineSeries() { Title = "All", Values = values, DataLabels = true, Foreground = Brushes.White, LineSmoothness = 0, PointGeometrySize = 10, });
            Labels = list.ToArray();
        }
        public void UpdateAllWeekLiveChart()
        {
            SeriesCollection = new SeriesCollection();
            SeriesCollection.Clear();
            ChartValues<ObservableValue> values = new ChartValues<ObservableValue>();
            /*ChartValues<DateTimePoint> values = new ChartValues<DateTimePoint>();*/
            double value = 0;
            List<string> list = new List<string>();
            DateTime[] Last_daysofweek = new DateTime[7];
            var datetimes = ExtendLiveChartExportList.Select(i => Convert.ToDateTime(i.DateTime.ToString("d"))).Distinct().ToList();
            foreach (var datetime in datetimes)
            {
                DateTime startDayOfWeek = datetime.AddDays(-1 * (int)(datetime.DayOfWeek));
                DateTime endDayOfWeek = datetime.AddDays(7 - (int)datetime.DayOfWeek);

                DateTime[] daysofweek = new DateTime[7];
                for (int i = 0; i <= 6; i++)
                {
                    daysofweek[i] = startDayOfWeek.AddDays(i);
                }
                Last_daysofweek=daysofweek;
                foreach (var day in daysofweek)
                {
                     
                }
                var data = ExtendLiveChartExportList
                                .Where(p => Convert.ToDateTime(p.DateTime.ToString("d")) >= startDayOfWeek && Convert.ToDateTime(p.DateTime.ToString("d")) <= endDayOfWeek)
                                .OrderBy(p => p.DateTime)
                                .Select(p => new { p.Quantity })
                                .ToArray();
                for (int e = 0; e < data.Count(); e++)
                {
                    value += data[e].Quantity;
                }
                values.Add(new ObservableValue(value));
                list.Add("Week of" + datetime.ToString("d"));
            }

            SeriesCollection.Add(new LineSeries() { Title = "All", Values = values, DataLabels = true, Foreground = Brushes.White, LineSmoothness = 0, PointGeometrySize = 10, });
            Labels = list.ToArray();
            /*XFormatter = val => new DateTime((long)val).ToString("d");*/
        }
        public void UpdateAllMonthLiveChart()
        {
            SeriesCollection = new SeriesCollection();
            SeriesCollection.Clear();
            ChartValues<ObservableValue> values = new ChartValues<ObservableValue>();
            double value = 0;
            List<string> list = new List<string>();
            var Export_Years = ExtendLiveChartExportList.Select(i => i.DateTime.Year.ToString()).Distinct().ToList();
            var Export_Month = ExtendLiveChartExportList.Select(i => i.DateTime.ToString("MMMM")).Distinct().ToList();
            var Months = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
            Months.Remove(Months[12]);
            foreach (var year in Export_Years)
            {
                foreach (var month in Months)
                {
                    foreach (var export_month in Export_Month)
                    {
                        if (export_month.ToString() == month)
                        {
                            var data = ExtendLiveChartExportList
                            .Where(p => p.DateTime.ToString("MMMM") == month)
                            .OrderBy(p => p.DateTime)
                            .Select(p => new { p.Quantity })
                            .ToArray();
                            for (int e = 0; e < data.Count(); e++)
                            {
                                value += data[e].Quantity;
                            }
                        }
                        else
                        {
                            value = 0;
                        }
                    }
                    values.Add(new ObservableValue(value));
                    list.Add(month.ToString() + " " + year.ToString());
                }

            }
            SeriesCollection.Add(new LineSeries() { Title = "All", Values = values, DataLabels = true, Foreground = Brushes.White, LineSmoothness = 0, PointGeometrySize = 10, });
            Labels = list.ToArray();
        }

        public void SetLiveChartExportList()
        {
            ExtendLiveChartExportList = new ObservableCollection<VolatilityLiveChartModel>();
            ExtendLiveChartExportList.Clear();
            var extendLiveChartExportList = QuantityBase.Get_AllExports();
            foreach (var item in extendLiveChartExportList)
            {
                var building = ImplementBase.Get_BuildingByExportItem(item);
                var device = ImplementBase.Get_MachineByExportItem(item);
                VolatilityLiveChartModel volatilityLiveChartModel = new VolatilityLiveChartModel
                {
                    BuildingName = building.BuildingName,
                    DateTime = item.ExportTime,
                    DeviceName = device.DeviceName,
                    Quantity = item.Quantity
                };
                ExtendLiveChartExportList.Add(volatilityLiveChartModel);
            }
        }

    }
}
