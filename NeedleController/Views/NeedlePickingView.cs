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
        private ObservableCollection<NeedlePickingFormModel> NeedleQtyList { get; set; }
        private readonly MainView MainView1;
        private static string Mess;

        public NeedlePickingView(MainView mainView)
        {
            InitializeComponent();
            InitializeTimer();
            MainView1 = mainView;
        }

        public event EventHandler NeedlePickingViewLoaded;

        private void NeedlePickingView_Load(object sender, EventArgs e)
        {
            NeedlePickingViewLoaded(this, EventArgs.Empty);

        }
        private void InitializeTimer()
        {
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Mess != MainView._message)
            {
                Mess = MainView._message;
                listBox1.Items.Add(DateTime.Now.ToString("yy/MM/dd HH:mm:ss ") + ":" + Mess.ToString());
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
            MainView._cableConnection = MainView1.PingHost(Properties.Settings.Default.local_ip);
            if (!MainView._cableConnection)
            {
                this.TopMost = false;
                this.Enabled = false;
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
            else
            {
                this.TopMost = true;
                this.Enabled = true;
            }
        }

        public void NeedlePickingViewLoad()
        {
            Mess = MainView._message;
            NeedleQtyList = new ObservableCollection<NeedlePickingFormModel>();
            var db = StockBase.Get_NeedleQtyInStock();
            NeedleQtyList.Clear();
            foreach (var item in db)
            {
                NeedlePickingFormModel needlePickingFormModel = new NeedlePickingFormModel
                {
                    NeedleID = item.NeedleID,
                    NeedleName = NeedleBase.Get_Needles(item.NeedleID).NeedleName,
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
                    StockName = p.First().StockName
                })
                .OrderBy(i => i.NeedleName);
            foreach (var item in NeedleList)
            {
                NeedlePickingForm needlePickingForm = new NeedlePickingForm(item);
                flowLayoutPanel1.Controls.Add(needlePickingForm);
            }
        }

    }
}
