using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using EF_CONFIG.Model;
using EF_CONFIG.DataTransform;

namespace NeedleTracking.ViewModel
{
    public class SplashViewModel : BaseViewModel
    {
        private List<ExcelFile> _ExcelFiles_list;
        public List<ExcelFile> ExcelFiles_list
        {
            get
            {
                return _ExcelFiles_list;
            }
            set
            {
                _ExcelFiles_list = value;
                OnPropertyChanged();
            }
        }
       /* private List<string> _POListString;
        public List<string> POListString
        {
            get { return _POListString; }
            set { _POListString = value; OnPropertyChanged(); }
        }*/
        private List<NS_Needles> _NeedleList;
        public List<NS_Needles> NeedleList
        {
            get { return _NeedleList; }
            set { _NeedleList = value; OnPropertyChanged(); }
        }
        public System.Data.DataTable ExcelPOList { get; set; }
        /*string Filepath = @"\\svproxy\Report\Produce Manage\Production Planning\新資料夾\1.生產進度";*/
        public bool IsSplashed = false;

        public ICommand LoadSplashWindowCommand { get; set; }

        private string _StatusText;
        public string StatusText { get { return _StatusText; } set { _StatusText = value; OnPropertyChanged("StatusText"); } }

        public SplashViewModel()
        {
            LoadSplashWindowCommand = new RelayCommand<System.Windows.Window>((p) => { return true; }, (p) => { LoadedSpWindowCommand(p); });

        }
        void LoadedSpWindowCommand(System.Windows.Window p)
        {
            if (p == null)
                return;
            SendString("Connecting to server");
            Thread thread = new Thread(new ParameterizedThreadStart(delegate
            {
                ServerStatusChecking(p);
            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start(p);
        }

        public void ServerStatusChecking(System.Windows.Window p)
        {
            IsSplashed = IsServerConnected("data source=10.4.2.23;initial catalog=_NEEDLE_SUPPLIER_;persist security info=True;user id=sa;password=shc@1234;multipleactiveresultsets=True;application name=EntityFramework&quot;");
            if (IsSplashed)
            {
               /* POListString = Get_POlist();*/
                NeedleList = EF_CONFIG.DataTransform.NeedleBase.Get_AllNeedle();
                System.Windows.Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new System.Action(delegate () { SendString("Connection success"); }));
                Thread.Sleep(1000);
                System.Windows.Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new System.Action(delegate () { p.Close(); }));
            }
            else
            {
                System.Windows.Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new System.Action(delegate () { SendString("Connection failed"); }));
                Thread.Sleep(1000);
                System.Windows.Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new System.Action(delegate () { p.Close(); }));
                /*Application.Current.Dispatcher.Invoke(() =>
                {
                    p.Close();
                }, System.Windows.Threading.DispatcherPriority.Background);*/
            }
        }
        /*List<string> Get_POlist()
        {
            DirectoryInfo d = new DirectoryInfo(Filepath);
            List<ExcelFile> excelFiles = new List<ExcelFile>();
            FileInfo[] Files = d.GetFiles("A06-Schedule_Report *.xlsx");
            System.Data.DataTable table = new System.Data.DataTable();
            foreach (FileInfo file in Files)
            {
                string _name = file.Name;
                string[] date = _name.Split(new string[] { "A06-Schedule_Report " }, StringSplitOptions.None);
                string datestring = string.Concat(date);
                string[] datetime = datestring.Split(new string[] { ".xlsx" }, StringSplitOptions.None);
                string datetimestring = string.Concat(datetime);
                string resultString = null;
                Regex regexObj = new Regex(@"[^\d]");
                resultString = regexObj.Replace(datetimestring, "");
                DateTime _date = DateTime.ParseExact(resultString, "MMddyyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                ExcelFile excelfile = new ExcelFile()
                {
                    FileName = _name,
                    Date = _date
                };
                excelFiles.Add(excelfile);
            }
            ExcelFiles_list = excelFiles;
            ExcelFile ex = ExcelFiles_list.OrderByDescending(i => i.Date).First();
            ExcelPOList = Import(Filepath + "\\" + ex.FileName);
            string[] POListString_array = ExcelPOList.AsEnumerable().Select<DataRow, string>(x => x.Field<string>("COLUMN1")).ToArray();
            var item = new List<string>();
            for (int i = 0; i < POListString_array.Length; i++)
            {
                item.Add(POListString_array[i]);
            }
            return item.Distinct().ToList();
        }*/
        public System.Data.DataTable Import(string filename, bool headers = false)
        {
            var _xl = new Microsoft.Office.Interop.Excel.Application();
            var wb = _xl.Workbooks.Open(filename);
            var sheets = wb.Sheets;
            System.Data.DataTable dt = new System.Data.DataTable();
            if (sheets != null && sheets.Count != 0)
            {
                foreach (var item in sheets)
                {
                    var sheet = (Microsoft.Office.Interop.Excel.Worksheet)item;
                    if (sheet.Name == "ASL")
                    {
                        dt = new System.Data.DataTable();
                        if (sheet != null)
                        {
                            var ColumnCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Rows[1, Type.Missing]).Columns.Count;
                            var rowCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Columns[1, Type.Missing]).Rows.Count;

                            var cell = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[4, 9];
                            var column = new DataColumn(headers ? cell.Value : string.Empty);
                            dt.Columns.Add(column);

                            for (int i = 4; i < rowCount; i++)
                            {
                                var r = dt.NewRow();
                                var cell1 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[i + 1 + (headers ? 1 : 0), 9];
                                r[0] = cell1.Value;
                                dt.Rows.Add(r);
                            }

                        }
                    }
                }
            }
            _xl.Quit();
            return dt;
        }
        public void SendString(String str)
        {
            if (str == null)
            {
                return;
            }
            StatusText = str;
        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

    }
    public class ExcelFile : BaseViewModel
    {
        public string FileName { get; set; }
        public DateTime Date { get; set; }
    }
}
