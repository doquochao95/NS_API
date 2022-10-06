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
                    NeedlePickingView.selected_needle_length = decimal.ToDouble((decimal)EF_CONFIG.DataTransform.NeedleBase.Get_Needles(_NeedleQtyStock.NeedleID).NeedleLength);
                    foreach(var item in NeedlePickingView.NeedleQtyList)
                    {
                        if (item.StockId == _NeedleQtyStock.StockId)
                        {
                            NeedlePickingView.selected_stockid = item.StockId;
                            NeedlePickingView.selected_needleid = item.NeedleID;
                            NeedlePickingView.current_qty = item.CurrentQuantity;
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

        }
        public void LoadNeedlePickingForm()
        {
            GetButton.Text = _NeedleQtyStock.WareHouseCode.ToString()+"-"+_NeedleQtyStock.NeedleName.ToString();
            QuantityLabel.Text = _NeedleQtyStock.TotalQuantity.ToString();
        }
        /*public void GetNeedle()
        {
            int count = 0;
            foreach (var item in _Stocks)
            {
                if (count == WishQuantityNumericUpDown.Value)
                {
                    break;
                }
                else
                {
                    using (UdpClient udpClient = new UdpClient())
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<" + item.StockName.ToLower() + ":" + item.CurrentQuantity + ">");
                        udpClient.Send(senddata, senddata.Length);
                        foreach (var _item in NeedlePickingView.NeedleQtyList_StockList)
                        {
                            if (_item.StockId == item.StockID)
                            {
                                MainView.selected_stockid = item.StockID;
                                MainView.selected_needleid = item.NeedleID;
                                MainView.current_qty = item.CurrentQuantity;
                            }
                        }
                        NeedlePickingView.getneedle_flag = true;
                        count++;
                    }
                }
            }

        }
        public void LoadNeedlePickingForm()
        {
            WishQuantityNumericUpDown.Maximum = _NeedleQtyStock.TotalQuantity;
            GetButton.Text = _NeedleQtyStock.NeedleName.ToString();
            QuantityLabel.Text = _NeedleQtyStock.TotalQuantity.ToString();
        }*/
    }

}
