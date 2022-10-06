using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

using System.Threading;
using System.Net;
using System.Net.Sockets;

using WinFormsMvp;
using WinFormsMvp.Forms;
using System.Net.NetworkInformation;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;
using NeedleController.Views.NeedlePickingUCs;
using System.Collections.ObjectModel;
using OpenCvDotNet;
using System.IO;

namespace NeedleController.Views
{
    public partial class NeedlePickingView : MvpForm, INeedlePickingView
    {
        public static ObservableCollection<NeedlePickingFormModel> NeedleQtyList { get; set; }
        public static ObservableCollection<NeedlePickingListtFormModel> NeedleQtyList_StockList { get; set; }
        /*public static ICollection<NS_Stocks> NeedleQtyList_NSstock { get; set; }*/

        public static Image destVideo { get; set; }
        public static Image _capturedImage { get; set; }
        public static double captured_needle_length { get; set; }
        public static double selected_needle_length { get; set; }

        private readonly MainView MainView1;
        private static string listbox_string;
        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();
        private static Thread threadOpenCV;

        private DateTime export_time;
        private string export_time_string;

        private double width;
        private double height;
        private static bool camera_connected = false;
        private static bool retry_connect_camera = false;
        private static bool exit_flag = false;

        public static bool getneedle_flag { get; set; }
        public static bool retry_flag { get; set; } = true;
        public static bool needlesupplied_status { get; set; } = false;
        public static string selected_operator { get; set; }
        public static int? selected_operator_int { get; set; }

        public static string selected_sewingmachine { get; set; }
        public static int? selected_processID { get; set; }
        public static int? selected_needlepartsenough { get; set; }
        public static int? selected_reasonID { get; set; }
        public static string selected_handle { get; set; }
        public static int? selected_allowStaffID { get; set; }
        public static DateTime? selected_brokenDateTime { get; set; }
        public static string selected_brokenDateTimeStr { get; set; }
        public static DateTime? selected_allowDateTime { get; set; }
        public static string selected_allowDateTimeStr { get; set; }
        public static string selected_po { get; set; }
        public static double selected_captured_needle_length { get; set; }

        public static int selected_stockid { get; set; }
        public static int selected_needleid { get; set; }
        public static int current_qty { get; set; }
        public static int? selected_requestID { get; set; }

        public NeedlePickingView(MainView mainView)
        {
            InitializeComponent();
            InitializeCamera();
            InitializeTimer();
            MainView1 = mainView;
        }

        public event EventHandler NeedlePickingViewLoaded;
        public event EventHandler NeedlePickingViewExited;

        private void NeedlePickingView_Load(object sender, EventArgs e)
        {
            NeedlePickingViewLoaded(this, EventArgs.Empty);
        }
        private void NeedlePickingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            NeedlePickingViewExited(this, EventArgs.Empty);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 500;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (listbox_string != MainView.listbox_string)
            {
                if (MainView.listbox_string != null)
                {
                    listbox_string = MainView.listbox_string;
                    listBox1.Items.Add(DateTime.Now.ToString("yy/MM/dd HH:mm:ss ") + ":" + listbox_string.ToString());
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                }
            }
            bool _cableConnection = MainView1.PingHost(NeedleController.Properties.Settings.Default.local_ip);
            while (true)
            {
                if (!_cableConnection)
                {
                    MainView._connected = false;
                    Logger.Error("Lost connection from " + MainView.device_name, MainView.device_id);
                    Timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to device again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        case DialogResult.Retry:
                            _cableConnection = MainView1.PingHost(NeedleController.Properties.Settings.Default.local_ip);
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            Application.Exit();
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    if (!MainView._connected)
                    {
                        MainView._connected = true;
                        Logger.Information("Device " + MainView.device_name + " from " + MainView.building_name + " is connected", MainView.device_id);
                        Timer1.Start();
                    }
                    break;
                }
            }
            bool database_conneciton = MainView1.CheckForDatabaseConnection();
            while (true)
            {
                if (!database_conneciton)
                {
                    MainView._databaseconnected = false;
                    Logger.Error("Lost connection from database", MainView.device_id);
                    Timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to database again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        //Stay on this form
                        case DialogResult.Retry:
                            database_conneciton = MainView1.CheckForDatabaseConnection();
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            Application.Exit();
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    if (!MainView._databaseconnected)
                    {
                        MainView._databaseconnected = true;
                        Logger.Information("Device " + MainView.device_name + " from " + MainView.building_name + " is connected to database", MainView.device_id);
                        Timer1.Start();
                    }
                    break;
                }
            }

            if (getneedle_flag)
            {
                try
                {
                    getneedle_flag = false;
                    MachineProcessView machineProcessView = new MachineProcessView();
                    machineProcessView.SelectedNeedleLength = selected_needle_length.ToString();
                    machineProcessView.ShowDialog();
                    if (needlesupplied_status)
                    {
                        this.export_time = DateTime.Now;
                        this.export_time_string = export_time.ToString("HH:mm, dd/MM/yyyy");
                        if (selected_processID == 0)
                        {
                            selected_processID = null;
                        }
                        if (selected_reasonID == 0)
                        {
                            selected_reasonID = null;
                        }
                        if (selected_sewingmachine == "")
                        {
                            selected_sewingmachine = null;
                        }
                        if (selected_handle == "")
                        {
                            selected_handle = null;
                        }
                        if (selected_po == "")
                        {
                            selected_po = null;
                        }
                        if (selected_operator == "")
                        {
                            selected_operator_int = null;
                        }
                        else
                        {
                            selected_operator_int = Convert.ToInt32(selected_operator);
                        }
                        NS_RecycledBox nS_RecycledBox = new NS_RecycledBox
                        {
                            DeviceID = MainView.device_id,
                            NeedleID = selected_needleid,
                            ExportTime = this.export_time,
                            ExportTimeStr = this.export_time_string,
                            GetByStaffID = MainView.user_id,
                            Operator = selected_operator_int,
                            SewingMachine = selected_sewingmachine,
                            ProcessID = selected_processID,
                            BrokenTime = selected_brokenDateTime,
                            BrokenTimeStr = selected_brokenDateTimeStr,
                            NeedlePartsEnough = selected_needlepartsenough,
                            ReasonID = selected_reasonID,
                            RecycleNeedleImage = imageToByteArray(_capturedImage),

                            ConfirmationByStaffID = selected_allowStaffID,
                            ConfirmationTime = selected_allowDateTime,
                            ConfirmationTimeStr = selected_allowDateTimeStr,
                            Handle = selected_handle,
                            PO = selected_po,
                            InBox = 1,
                            CapturedLength = Convert.ToDecimal(selected_captured_needle_length),
                            DeleteByStaffID = null,
                            DeleteTime = null,
                            DeleteTimeStr = null                         
                        };
                        while (true)
                        {
                            bool status_ = EF_CONFIG.DataTransform.RecycledBoxBase.Add_NewRecycle(nS_RecycledBox);
                            if (status_)
                            {
                                NS_RecycledBox s_RecycledBox = EF_CONFIG.DataTransform.RecycledBoxBase.Get_MostRecentRecycleBox();
                                NS_Export export = new NS_Export
                                {
                                    DeviceID = MainView.device_id,
                                    BuildingID = MainView.building_id,
                                    NeedleID = selected_needleid,
                                    ExportTime = this.export_time,
                                    ExprtTimeString = this.export_time_string,
                                    Quantity = 1,
                                    StaffID = MainView.user_id,
                                    StockID = selected_stockid,
                                    RecycleBoxID = s_RecycledBox.RecycleBoxID
                                };
                                while (true)
                                {
                                    bool status = EF_CONFIG.DataTransform.ExportBase.Add_NewExport(export);
                                    if (status)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
                catch (Exception i)
                {
                    Logger.Error(i.Message, MainView.device_id);
                    MessageBox.Show(i.ToString());
                    Console.WriteLine(i.ToString());
                }
            }
            if (!retry_flag)
            {
                this.Close();
                retry_flag = true;
            }
            if (!camera_connected && !exit_flag)
            {
                Timer1.Stop();
                if (threadOpenCV.IsBackground)
                {
                    threadOpenCV.Abort();
                }
                switch (MessageBox.Show(this, "Can't open Camera", "Error: commmunication", MessageBoxButtons.RetryCancel))
                {
                    case DialogResult.Retry:
                        retry_connect_camera = true;
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        MainView.last_view = this.Name;
                        MainView.needlepickingviewloaded_status = false;
                        break;
                }
            }
            else
            {
                CheckCamera_Connection();
                if (!camera_connected)
                {
                    return;
                }
                if (!threadOpenCV.IsBackground)
                {
                    threadOpenCV.IsBackground = true;
                    threadOpenCV.Start();
                }
            }
            if (retry_connect_camera)
            {
                InitializeCamera();
                retry_connect_camera = false;
                Timer1.Start();
            }
        }
        public void NeedlePickingViewLoad()
        {
            try
            {
                MainView1.Reply_Buffer("<led2:1>");
                exit_flag = false;
                MainView.last_view = this.Name;
                MainView.needlepickingviewloaded_status = true;
                listbox_string = MainView._message;
                NeedleQtyList = new ObservableCollection<NeedlePickingFormModel>();
                ObservableCollection<NeedlePickingListtFormModel> _NeedleQtyList_StockList = new ObservableCollection<NeedlePickingListtFormModel>();
                var db = StockBase.Get_NeedleQtyInStockWithDeviceID(MainView.device_id);
                NeedleQtyList.Clear();
                foreach (var item in db)
                {
                    NeedlePickingFormModel needlePickingFormModel = new NeedlePickingFormModel
                    {
                        NeedleID = item.NeedleID,
                        NeedleName = NeedleBase.Get_Needles(item.NeedleID).NeedleName,
                        WareHouseCode = NeedleBase.Get_Needles(item.NeedleID).NeedleWarehouseCode,
                        StockId = item.StockID,
                        StockName = item.StockName,
                        CurrentQuantity = item.CurrentQuantity
                    };
                    NeedleQtyList.Add(needlePickingFormModel);
                }
                IEnumerable<NeedlePickingFormModel> NeedleList = NeedleQtyList.GroupBy(a => new { a.NeedleID })
                    .Select(p => new NeedlePickingFormModel
                    {
                        NeedleID = p.First().NeedleID,
                        NeedleName = p.First().NeedleName,
                        WareHouseCode = p.First().WareHouseCode,
                        CurrentQuantity = p.First().CurrentQuantity,
                        TotalQuantity = p.Sum(a => a.CurrentQuantity),
                        StockId = p.First().StockId,
                        StockName = p.First().StockName
                    })
                    .OrderBy(a => a.WareHouseCode);
                foreach (var item in NeedleList)
                {
                    NeedlePickingForm needlePickingForm = new NeedlePickingForm(item);
                    flowLayoutPanel1.Controls.Add(needlePickingForm);
                }
                MainView.close_waiting = true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public void NeedlePickingViewExit()
        {
            try
            {
                MainView1.Reply_Buffer("<led2:0>");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                exit_flag = true;
                MainView.last_view = this.Name;
                MainView.needlepickingviewloaded_status = false;
                if (camera_connected)
                {
                    if (threadOpenCV.IsBackground)
                    {
                        threadOpenCV.Abort();
                    }
                }
                opencv.stopCamera();
                camera_connected = false;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        private void InitializeCamera()
        {
            try
            {
                string camera_id = Properties.Settings.Default.IDCamera;
                string camera_mode = Properties.Settings.Default.modeCamera;
                if (camera_mode == "Local Camera" && camera_id.Length == 1)
                {
                    opencv.startCamera(int.Parse(camera_id));
                    threadOpenCV = new Thread(() => Display(opencv));
                    CheckCamera_Connection();
                }
                else if (camera_mode == "IP Camera" && camera_id.Length > 1)
                {
                    bool status = PingHost(camera_id);
                    if (status)
                    {
                        opencv.startCamera("http://" + camera_id + ":4747/video");
                        threadOpenCV = new Thread(() => Display(opencv));
                        CheckCamera_Connection();
                    }
                    else
                    {
                        threadOpenCV = new Thread(() => Display(opencv));
                        camera_connected = false;
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        private void CheckCamera_Connection()
        {
            if (!opencv.checkCamera())
            {
                camera_connected = false;
            }
            else
            {
                camera_connected = true;
            }
        }
        private void Display(MyOpenCvWrapper opencv)
        {
            while (true)
            {
                SetImgPosition();
                bool status = opencv.getNeedleLength(Properties.Settings.Default.gaussianBlurKsize, Properties.Settings.Default.cannyThreshold1, Properties.Settings.Default.cannyThreshold2,
                    width, height);
                if (status)
                {
                    opencv.getColor(Properties.Settings.Default.colorLowR, Properties.Settings.Default.colorLowG, Properties.Settings.Default.colorLowB,
                    Properties.Settings.Default.colorHighR, Properties.Settings.Default.colorHighG, Properties.Settings.Default.colorHighB);

                    opencv.User_Display_Mode((sbyte)Properties.Settings.Default.displayImgMode, Properties.Settings.Default.brightness,
                        Properties.Settings.Default.contrast, cameraViewerUC1.userBrightness, cameraViewerUC1.userContrast);

                    Bitmap src = opencv.displaySrc(width, height);
                    Bitmap dst = opencv.displayDst(width, height);
                    captured_needle_length = opencv.needleLength();
                    Invoke(new Action(() =>
                    {
                        destVideo = dst;
                        cameraViewerUC1.sourceVideo = src;
                            /*cameraViewerUC1.destVideo = dst;*/
                    }));
                }
                else
                {
                    opencv.stopCamera();
                }               
            }
        }
        private void SetImgPosition()
        {
            switch (Properties.Settings.Default.imgPosition)
            {
                case "Center":
                    width = 100;
                    height = 100;
                    break;
                case "Fill":
                    width = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 512));
                    height = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 512));
                    break;
                case "Fit":
                    width = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 384));
                    height = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 384));
                    break;
                case "Stretch":
                    width = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 512));
                    height = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 384));
                    break;
            }
        }
        private static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                if (imageIn != null)
                {
                    MemoryStream ms = new MemoryStream();
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    return ms.ToArray();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
