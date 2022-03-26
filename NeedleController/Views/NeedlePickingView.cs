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

namespace NeedleController.Views
{
    public partial class NeedlePickingView : MvpForm, INeedlePickingView
    {
        public static ObservableCollection<NeedlePickingFormModel> NeedleQtyList { get; set; }
        private readonly MainView MainView1;
        private static string listbox_string;

        public static bool getneedle_flag { get; set; }
        public static bool retry_flag { get; set; } = true;
        public static bool needlesupplied_status { get; set; } = false;



        public NeedlePickingView(MainView mainView)
        {
            InitializeComponent();
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
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (listbox_string != MainView.listbox_string)
            {
                listbox_string = MainView.listbox_string;
                listBox1.Items.Add(DateTime.Now.ToString("yy/MM/dd HH:mm:ss ") + ":" + listbox_string.ToString());
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
            MainView._cableConnection = MainView1.PingHost(Properties.Settings.Default.local_ip);
            if (!MainView._cableConnection)
            {
                Timer1.Enabled = false;
                DialogResult dlr = MessageBox.Show("Please to check connection again", "Communication Error", MessageBoxButtons.RetryCancel);
                if (dlr == DialogResult.Retry)
                {
                    Timer1.Enabled = true;
                    return;
                }
                if (dlr == DialogResult.Cancel)
                {
                    this.Close();
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
            MainView.check_camera = false;
            MainView.needlepickingviewloaded_status = false;
        }

    }
}
