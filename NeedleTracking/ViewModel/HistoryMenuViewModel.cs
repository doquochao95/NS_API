using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NeedleTracking.UserControlUC.HistoryUC;
using NeedleTracking.ViewModel.HistoryMenuViewModels;
using NeedleTracking.ViewModel;
using NeedleTracking.ViewModel.RequestMenuViewModels;
using EF_CONFIG.DataTransform;
using System.Collections.ObjectModel;
using EF_CONFIG.BaseModel;
using EF_CONFIG.Model;
using NeedleTracking.UserControlUC;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using Microsoft.Win32;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Drawing;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Windows.Interop;

namespace NeedleTracking.ViewModel
{
    public class HistoryMenuViewModel : BaseViewModel
    {
        private ObservableCollection<HistoryDataGridModel> _HistoryDataList;

        private int _SelectedDeviceID;
        public int SelectedDeviceID
        {
            get { return _SelectedDeviceID; }
            set
            {
                _SelectedDeviceID = value;
                OnPropertyChanged();
            }
        }
        public string DateString;
        private List<int> _devicelist;
        private List<Building> _Buildings;
        public List<Building> Buildings
        {
            get
            {
                return _Buildings;
            }
            set
            {
                _Buildings = value;
                OnPropertyChanged();
            }

        }

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
        public bool _ExportExcelButtonEnable { get; set; } = false;
        public bool ExportExcelButtonEnable
        {
            get { return _ExportExcelButtonEnable; }
            set
            {
                _ExportExcelButtonEnable = value;
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
        bool[] MenuArray = new bool[3];
        bool[] DayArray = new bool[3] { true, false, false };
        bool[] WeefArray = new bool[3] { false, true, false };
        bool[] MonthArray = new bool[3] { false, false, true };

        public ICommand TreeViewSelectedItemChangedCommand { get; set; }
        public ICommand LoadedHistoryMenuCommand { get; set; }
        public ICommand DayRadioButtonChecked { get; set; }
        public ICommand WeekRadioButtonChecked { get; set; }
        public ICommand MonthRadioButtonChecked { get; set; }
        public ICommand ApplyButtonClick { get; set; }
        public ICommand ExportExcelButtonClick { get; set; }


        public HistoryMenuViewModel()
        {
            TreeViewSelectedItemChangedCommand = new RelayCommand<object>((p) => { return true; }, (p) => { TreeViewSelectedItemChanged_Command(p); });
            LoadedHistoryMenuCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { LoadedWindowCommand(p); });

            DayRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { DayRadioButton_CheckedCommand(); });
            WeekRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { WeekRadioButton_CheckedCommand(); });
            MonthRadioButtonChecked = new RelayCommand<object>((p) => { return true; }, (p) => { MonthRadioButton_CheckedCommand(); });

            ApplyButtonClick = new RelayCommand<object>((p) => { return true; }, (p) => { ApplyButton_Command(); });
            ExportExcelButtonClick = new RelayCommand<object>((p) => { return true; }, (p) => { ExportExcelButton_Command(); });

        }
        void TreeViewSelectedItemChanged_Command(object p)
        {
            var type = p.GetType();
            if (p == null || type != typeof(Device))
                return;
            var item = (Device)p;
            SelectedDeviceID = item.DeviceID;
            if (_devicelist.Contains(SelectedDeviceID))
            {
                SortedByEnable = true;
            }
        }
        void LoadedWindowCommand(UserControl p)
        {
            _devicelist = new List<int>();
            var _buildinglist = new List<Building>();
            var buildingList = EF_CONFIG.DataTransform.ImplementBase.Get_BuildingList();
            foreach (var building in buildingList)
            {
                Building _building = new Building();
                var devicelist = new List<Device>();
                var devices = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithBuildingId(building.BuildingID);
                if (devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        var newdevice = new Device(device.DeviceID, device.DeviceName);
                        devicelist.Add(newdevice);
                        _devicelist.Add(device.DeviceID);
                    }
                    _building.Devices = devicelist;
                    _building.BuildingName = building.BuildingName;
                    _buildinglist.Add(_building);
                }
            }
            Buildings = _buildinglist;
        }
        void ApplyButton_Command()
        {
            ApplyBoolArray();
            HistoryDataUC historyDataUC = new HistoryDataUC();
            var historyDataVM = historyDataUC.DataContext as HistoryDataViewModel;
            this._HistoryDataList = historyDataVM.LoadDataGridView(SelectedDeviceID, MenuArray, SelectedDate);
            if (_HistoryDataList != null)
            {
                ExportExcelButtonEnable = true;
            }
            else
            {
                ExportExcelButtonEnable = false;
            }
        }
        void ExportExcelButton_Command()
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();
            if (MenuArray.SequenceEqual(DayArray))
            {
                sfd.FileName = "ConfirmedData" + SelectedDate.ToString("ddMMyyyy") + "(Day).xlsx";
            }
            else if (MenuArray.SequenceEqual(WeefArray))
            {
                sfd.FileName = "ConfirmedData" + SelectedDate.ToString("ddMMyyyy") + "(Week).xlsx";
            }
            else
            {
                sfd.FileName = "ConfirmedData" + SelectedDate.ToString("ddMMyyyy") + "(Month).xlsx";
            }
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.DefaultExt = ".xlsx";
            var sel = sfd.ShowDialog();
            if (sel == true)
            {
                string path = Path.GetFullPath(sfd.FileName);
                var FilePath = ExportToExcel(_HistoryDataList, path);
                if (FilePath != null)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(FilePath);
                    }
                    catch { }
                }
            }

        }
        void DayRadioButton_CheckedCommand()
        {
            ApplyBoolArray();
            this.PickDateEnable = true;
        }
        void WeekRadioButton_CheckedCommand()
        {
            ApplyBoolArray();
            this.PickDateEnable = true;

        }
        void MonthRadioButton_CheckedCommand()
        {
            ApplyBoolArray();
            this.PickDateEnable = true;
        }
        void ApplyBoolArray()
        {
            bool[] array = new bool[3];
            array[0] = DayChecked;
            array[1] = WeekChecked;
            array[2] = MonthChecked;
            MenuArray = array;
        }
        public string ExportToExcel(ObservableCollection<HistoryDataGridModel> historyDataGridModelList, string StorageFolder)
        {

            string FullFilePath = StorageFolder;
            // Initialize CurrentEditFile
            FileInfo CurrentEditFile = new FileInfo(FullFilePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(CurrentEditFile))
            {
                int SheetIndex = 0;
                package.Workbook.Worksheets.Add(Guid.NewGuid().ToString());
                string SheetName = $"{EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(SelectedDeviceID).DeviceName}";
                package.Workbook.Worksheets[SheetIndex].Name = SheetName;
                ExcelWorksheet CurrentEditSheet = package.Workbook.Worksheets[SheetIndex];
                ExportToExcel(historyDataGridModelList, CurrentEditSheet);
                package.Save();
            }
            return FullFilePath;
        }
        public void ExportToExcel(ObservableCollection<HistoryDataGridModel> historyDataGrids, ExcelWorksheet CurrentSheet)
        {
            string[] Header = new string[] { "STT"              , "Loại Kim"        , "Tên Kim"             , "Tòa Nhà"     , "Thiết Bị"    , "Chuyền",  "Máy May"
                                            , "Công Nhân"       , "Công Đoạn"       , "Thời Gian Gãy"       , "Bộ Phận Kim" , "Lí Do"       , "Thòi Gian Phát"
                                            , "Người Lấy Kim"   ,  "Xác Nhận Bởi"   , "Thời Gian Xác Nhận"  ,"PO"           , "Xử Lý"       , "Hình Kim Gãy"};
            int beginColumn = 1;
            int beginRow = 1;
            //create excel header
            for (int i = beginColumn; i <= Header.Length; i++)
            {
                CurrentSheet.Cells[beginRow, i].Value = Header[i - 1];
                CurrentSheet.Cells[beginRow, i].Style.Font.Bold = true;
                CurrentSheet.Cells[beginRow, i].Style.Border.BorderAround(ExcelBorderStyle.Medium);
            }

            ExcelRange HeaderRow = CurrentSheet.Cells[beginRow, beginColumn, beginRow, 19];
            HeaderRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
            HeaderRow.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            HeaderRow.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            HeaderRow.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            HeaderRow.Style.Border.BorderAround(ExcelBorderStyle.Medium);
            int Total = 0;
            foreach (var item in historyDataGrids)
            {
                Total++;
                int CurrentRowIndex = beginRow + Total;
                ExcelRange CurrentRow = CurrentSheet.Cells[beginRow + Total, beginColumn, beginRow + Total, 4];

                ExcelRange SNCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 0];
                ExcelRange NeedleCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 1];
                ExcelRange NeedleNameCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 2];
                ExcelRange BuildingCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 3];
                ExcelRange DeviceCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 4];
                ExcelRange LineCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 5];

                ExcelRange SewingMachineCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 6];
                ExcelRange OperatorCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 7];
                ExcelRange ProcessCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 8];
                ExcelRange BrokenTimeCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 9];
                ExcelRange EnoughtCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 10];
                ExcelRange ReasonCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 11];
                ExcelRange ExportTimeCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 12];
                ExcelRange GetByCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 13];
                ExcelRange ConfirmByCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 14];
                ExcelRange ConfirmTimeCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 15];
                ExcelRange POCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 16];
                ExcelRange HandleCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 17];
                ExcelRange ImageCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 18];

                ExcelRange[] excelRanges = new ExcelRange[] { SNCell,NeedleCell,NeedleNameCell,BuildingCell,DeviceCell,LineCell,SewingMachineCell
                                                             ,OperatorCell,ProcessCell,BrokenTimeCell,EnoughtCell,ReasonCell,ExportTimeCell
                                                             ,GetByCell,ConfirmByCell,ConfirmTimeCell,POCell,HandleCell,ImageCell};

                CurrentSheet.Row(CurrentRowIndex).Height = 50;

                for (int i = 0; i < excelRanges.Length; i++)
                {
                    excelRanges[i].Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                    excelRanges[i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    excelRanges[i].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                    excelRanges[i].Style.Font.Size = 16;
                }

                var needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NS_RecycledBox.NeedleID);
                var device = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.NS_RecycledBox.DeviceID);
                var getstaff = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.NS_RecycledBox.GetByStaffID);
                var confirmstaff = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.NS_RecycledBox.ConfirmationByStaffID);
                var reason =  EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.NS_RecycledBox.ReasonID);
                device.NS_Buildings = EF_CONFIG.DataTransform.BuildingBase.Get_Building(device.BuildingID);
                getstaff.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(getstaff.LineID);
                if (item.NS_RecycledBox.ReasonID == 4)
                {
                    SNCell.Value = Total;
                    NeedleCell.Value = needle.NeedleWarehouseCode;
                    NeedleNameCell.Value = needle.NeedleName;
                    BuildingCell.Value = device.NS_Buildings.BuildingName;
                    DeviceCell.Value = device.DeviceName;
                    LineCell.Value = getstaff.NS_Lines.LineName;
                    SewingMachineCell.Value = item.NS_RecycledBox.SewingMachine;
                    OperatorCell.Value = item.NS_RecycledBox.Operator;
                    ProcessCell.Value = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.NS_RecycledBox.ProcessID).ProcessName;
                    BrokenTimeCell.Value = "";
                    EnoughtCell.Value = "";
                    ConfirmByCell.Value = "";
                    ConfirmTimeCell.Value = "";
                    POCell.Value = item.NS_RecycledBox.PO;
                    HandleCell.Value = item.NS_RecycledBox.Handle;
                    if(reason.ReasonName == "Bent")
                    {
                        ReasonCell.Value = "Cong";
                    }
                    else if (reason.ReasonName == "Broken")
                    {
                        ReasonCell.Value = "Gãy";
                    }
                    else if (reason.ReasonName == "New")
                    {
                        ReasonCell.Value = "Lãnh mới";
                    }
                    else 
                    {
                        ReasonCell.Value = "Gãy Và Cong";
                    }
                    ExportTimeCell.Value = item.NS_RecycledBox.ExportTimeStr;
                    GetByCell.Value = getstaff.StaffName;
                }
                else
                {
                    SNCell.Value = Total;
                    NeedleCell.Value = needle.NeedleWarehouseCode;
                    NeedleNameCell.Value = needle.NeedleName;
                    BuildingCell.Value = device.NS_Buildings.BuildingName;
                    DeviceCell.Value = device.DeviceName;
                    LineCell.Value = getstaff.NS_Lines.LineName;
                    SewingMachineCell.Value = item.NS_RecycledBox.SewingMachine;
                    OperatorCell.Value = item.NS_RecycledBox.Operator;
                    ProcessCell.Value = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.NS_RecycledBox.ProcessID).ProcessName;
                    BrokenTimeCell.Value = item.NS_RecycledBox.BrokenTimeStr;
                    if (item.NS_RecycledBox.NeedlePartsEnough == 1)
                    {
                        EnoughtCell.Value = "Đủ";
                        ConfirmByCell.Value = "";
                        ConfirmTimeCell.Value = "";
                        POCell.Value = "";
                        HandleCell.Value = "";
                    }
                    else
                    {
                        EnoughtCell.Value = "Không Đủ";
                        ConfirmByCell.Value = confirmstaff.StaffName;
                        ConfirmTimeCell.Value = item.NS_RecycledBox.ConfirmationTimeStr;
                        POCell.Value = item.NS_RecycledBox.PO;
                        HandleCell.Value = item.NS_RecycledBox.Handle;
                    }
                    if (reason.ReasonName == "Bent")
                    {
                        ReasonCell.Value = "Cong";
                    }
                    else if (reason.ReasonName == "Broken")
                    {
                        ReasonCell.Value = "Gãy";
                    }
                    else if (reason.ReasonName == "New")
                    {
                        ReasonCell.Value = "Lãnh mới";
                    }
                    else
                    {
                        ReasonCell.Value = "Gãy Và Cong";
                    }
                    ExportTimeCell.Value = item.NS_RecycledBox.ExportTimeStr;
                    GetByCell.Value = getstaff.StaffName;
                    var image = Crop(0, 80, 320, 100, item.NS_RecycledBox.RecycleNeedleImage);
                    var bitmapimage = Bitmap2BitmapImage(image);
                    var imagebyte = SaveImage(bitmapimage);
                    SetImage(CurrentSheet, CurrentRowIndex, beginColumn + 18, imagebyte);
                }

            }

            ExcelRange CurrentTable = CurrentSheet.Cells[beginRow, beginColumn, beginRow + Total, beginColumn + 18];
            CurrentTable.Style.Border.BorderAround(ExcelBorderStyle.Medium);
            CurrentSheet.Cells.Style.WrapText = true;
            for (int i = 0; i < Header.Length; i++)
            {
                CurrentSheet.Column(beginColumn + i).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                CurrentSheet.Column(beginColumn + i).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }

            CurrentSheet.Column(beginColumn + 0).Width = 5;
            CurrentSheet.Column(beginColumn + 1).Width = 10;
            CurrentSheet.Column(beginColumn + 2).Width = 15;
            CurrentSheet.Column(beginColumn + 3).Width = 20;
            CurrentSheet.Column(beginColumn + 4).Width = 20;
            CurrentSheet.Column(beginColumn + 5).Width = 10;
            CurrentSheet.Column(beginColumn + 6).Width = 12;
            CurrentSheet.Column(beginColumn + 7).Width = 12;
            CurrentSheet.Column(beginColumn + 8).Width = 20;
            CurrentSheet.Column(beginColumn + 9).Width = 20;
            CurrentSheet.Column(beginColumn + 10).Width = 10;
            CurrentSheet.Column(beginColumn + 11).Width = 10;
            CurrentSheet.Column(beginColumn + 12).Width = 20;
            CurrentSheet.Column(beginColumn + 13).Width = 20;
            CurrentSheet.Column(beginColumn + 14).Width = 20;
            CurrentSheet.Column(beginColumn + 15).Width = 20;
            CurrentSheet.Column(beginColumn + 16).Width = 20;
            CurrentSheet.Column(beginColumn + 17).Width = 25;
            CurrentSheet.Column(beginColumn + 18).Width = 30;
        }
        private static void SetImage(ExcelWorksheet sheet, int row, int colum, byte[] image)
        {
            Stream stream = new MemoryStream(image);
            ExcelPicture picture = sheet.Drawings.AddPicture(Guid.NewGuid().ToString(), stream, ePictureType.Bmp);
            picture.SetPosition(row - 1, 10, colum - 1, 10);
            picture.SetSize(60);

        }
        public Bitmap Crop(int xPosition, int yPosition, int width, int height, byte[] image)
        {
            var _currentBitmapImage = LoadImage(image);
            var _currentBitmap = BitmapImage2Bitmap(_currentBitmapImage);
            Bitmap temp = _currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (xPosition + width > _currentBitmap.Width)
                width = _currentBitmap.Width - xPosition;
            if (yPosition + height > _currentBitmap.Height)
                height = _currentBitmap.Height - yPosition;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(xPosition, yPosition, width, height);
            return _currentBitmap = bmap.Clone(rect, bmap.PixelFormat);
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        private static byte[] SaveImage(BitmapImage image)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        private Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }
        private BitmapImage Bitmap2BitmapImage(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }
    }

}
