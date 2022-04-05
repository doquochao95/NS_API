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

namespace NeedleController.Views
{
    public partial class NeedlePickingView : MvpForm, INeedlePickingView
    {
        public static ObservableCollection<NeedlePickingFormModel> NeedleQtyList { get; set; }
        private readonly MainView MainView1;
        private static string listbox_string;
        private static string Mess;
        private readonly MyOpenCvWrapper opencv = new MyOpenCvWrapper();
        private Thread threadOpenCV;
        private double width;
        private double height;

        public static bool getneedle_flag { get; set; }
        public static bool retry_flag { get; set; } = true;
        public static bool needlesupplied_status { get; set; } = false;



        public NeedlePickingView(MainView mainView)
        {
            InitializeComponent();
            InitializeTimer();
            InitializeCamera();
            MainView1 = mainView;
        }

        public event EventHandler NeedlePickingViewLoaded;
        public event EventHandler NeedlePickingViewExited;
        public event EventHandler NeedlePickingViewClosed;

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
                    Timer1.Start();
                    break;
                }
            }

            bool database_conneciton = MainView1.CheckForDatabaseConnection();
            while (true)
            {
                if (!database_conneciton)
                {
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
                    Timer1.Start();
                    break;
                }
            }
            if (getneedle_flag)
            {
                getneedle_flag = false;
                MachineProcessView machineProcessView = new MachineProcessView();
                machineProcessView.ShowDialog();
                if (needlesupplied_status)
                {
                    NS_Export export = new NS_Export
                    {
                        DeviceID = MainView.device_id,
                        BuildingID = MainView.building_id,
                        NeedleID = MainView.selected_needleid,
                        ExportTime = DateTime.Now,
                        ExprtTimeString = DateTime.Now.ToString("HH:mm, dd/MM/yyyy"),
                        Quantity = 1,
                        StaffID = MainView.user_id,
                        StockID = MainView.selected_stockid
                    };
                    bool status = EF_CONFIG.DataTransform.ExportBase.Add_NewExport(export);
                    if (!status)
                    {
                        return;
                    }
                }
            }
            if (listbox_string == "check_camera")
            {
                MainView.check_camera = true;
            }
            if (!retry_flag)
            {
                this.Close();
                retry_flag = true;
            }

        }

        public void NeedlePickingViewLoad()
        {
            MainView.last_view = this.Name;
            MainView.needlepickingviewloaded_status = true;
            listbox_string = MainView._message;
            NeedleQtyList = new ObservableCollection<NeedlePickingFormModel>();
            var db = StockBase.Get_NeedleQtyInStockWithDeviceID(MainView.device_id);
            NeedleQtyList.Clear();
            foreach (var item in db)
            {
                NeedlePickingFormModel needlePickingFormModel = new NeedlePickingFormModel
                {
                    NeedleID = item.NeedleID,
                    NeedleName = NeedleBase.Get_Needles(item.NeedleID).NeedleName,
                    StockId = item.StockID,
                    StockName = item.StockName,
                    CurrentQuantity = item.CurrentQuantity
                };
                NeedleQtyList.Add(needlePickingFormModel);
            }
            /*IEnumerable<NeedlePickingFormModel> NeedleList = NeedleQtyList.OrderBy(i => i.NS_Needles.NeedleName);*/
            IEnumerable<NeedlePickingFormModel> NeedleList = NeedleQtyList.GroupBy(a => new { a.NeedleID })
                .Select(p => new NeedlePickingFormModel
                {
                    NeedleID = p.First().NeedleID,
                    NeedleName = p.First().NeedleName,
                    CurrentQuantity = p.First().CurrentQuantity,
                    TotalQuantity = p.Sum(a => a.CurrentQuantity),
                    StockId = p.First().StockId,
                    StockName = p.First().StockName
                })
                .OrderBy(a => a.NeedleID);


            foreach (var item in NeedleList)
            {
                NeedlePickingForm needlePickingForm = new NeedlePickingForm(item);
                flowLayoutPanel1.Controls.Add(needlePickingForm);
            }
        }
        public void NeedlePickingViewExit()
        {
            MainView.last_view = this.Name;
            MainView.check_camera = false;
            MainView.needlepickingviewloaded_status = false;
        }

        public void NeedlePickingViewClose()
        {
            opencv.stopCamera();
        }

        private void InitializeCamera()
        {
            opencv.startCamera(Properties.Settings.Default.IDCamera);
            threadOpenCV = new Thread(() => Display(opencv));
            threadOpenCV.IsBackground = true;
            threadOpenCV.Start();
        }

        private void Display(MyOpenCvWrapper opencv)
        {
            try
            {
                if (!opencv.checkCamera())
                    MessageBox.Show("Can't open Camera");

                while (opencv.checkCamera())
                {
                    SetImgPosition();
                    opencv.getNeedleLength(Properties.Settings.Default.gaussianBlurKsize, Properties.Settings.Default.cannyThreshold1, Properties.Settings.Default.cannyThreshold2,
                        width, height);

                    opencv.getColor(Properties.Settings.Default.colorLowR, Properties.Settings.Default.colorLowG, Properties.Settings.Default.colorLowB,
                        Properties.Settings.Default.colorHighR, Properties.Settings.Default.colorHighG, Properties.Settings.Default.colorHighB);

                    opencv.User_Display_Mode((sbyte)Properties.Settings.Default.displayImgMode, Properties.Settings.Default.brightness,
                        Properties.Settings.Default.contrast, cameraViewerUC1.userBrightness, cameraViewerUC1.userContrast);

                    Bitmap src = opencv.displaySrc();
                    Bitmap dst = opencv.displayDst();
                    Invoke(new Action(() =>
                    {
                        cameraViewerUC1.sourceVideo = src;
                        cameraViewerUC1.destVideo = dst;
                    }));
                }
            }
            catch
            {
                threadOpenCV.Abort();
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
                    width = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 640));
                    height = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 640));
                    break;
                case "Fit":
                    width = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 480));
                    height = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 480));
                    break;
                case "Stretch":
                    width = Math.Round((double)(cameraViewerUC1.imgWidth * 100 / 640));
                    height = Math.Round((double)(cameraViewerUC1.imgHeight * 100 / 480));
                    break;
            }
        }

        
    }
}
