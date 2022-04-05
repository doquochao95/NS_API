using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

using EF_CONFIG;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

using WinFormsMvp;
using WinFormsMvp.Forms;
using NeedleController.Presenters;
using NeedleController.Presenters.NeedlePickingPresenters;

namespace NeedleController.Views.NeedlePickingUCs
{
    [PresenterBinding(typeof(NeedlePickingFormPresenter))]
    public partial class NeedlePickingForm : MvpUserControl, INeedlePickingForm
    {
        private readonly NeedlePickingFormModel _NeedleQtyStock;

        public NeedlePickingForm(NeedlePickingFormModel NeedleStock)
        {
            InitializeComponent();
            _NeedleQtyStock = NeedleStock;
        }
        public event EventHandler GetButtonClicked;
        public event EventHandler NeedlePickingFormLoaded;

        private void NeedlePickingForm_Load(object sender, EventArgs e)
        {
            NeedlePickingFormLoaded(this, EventArgs.Empty);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            GetButtonClicked(this, EventArgs.Empty);
        }


        public void GetNeedle()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<" + _NeedleQtyStock.StockName.ToLower() + ":" + _NeedleQtyStock.CurrentQuantity + ">");
                    udpClient.Send(senddata, senddata.Length);
                    NeedlePickingView.getneedle_flag = true;
                    foreach(var item in NeedlePickingView.NeedleQtyList)
                    {
                        if (item.StockId == _NeedleQtyStock.StockId)
                        {
                            MainView.selected_stockid = item.StockId;
                            MainView.selected_needleid = item.NeedleID;
                            MainView.current_qty = item.CurrentQuantity;
                        }
                    }
                }
                catch (Exception i)
                {
                    Console.WriteLine(i.ToString());
                }
            }

        }
        public void LoadNeedlePickingForm()
        {
            GetButton.Text = _NeedleQtyStock.NeedleName.ToString();
            QuantityLabel.Text = _NeedleQtyStock.TotalQuantity.ToString();
        }
    }
}
