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
        private readonly NeedlePickingFormModel NeedleQtyStock;

        public NeedlePickingForm(NeedlePickingFormModel NeedleStock)
        {
            InitializeComponent();
            NeedleQtyStock = NeedleStock;
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
            try
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    try
                    {
                        udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                        Byte[] senddata = Encoding.ASCII.GetBytes("<"+NeedleQtyStock.StockName.ToLower()+":"+NeedleQtyStock.CurrentQuantity+">");
                        udpClient.Send(senddata, senddata.Length);
                    }
                    catch (Exception i)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void LoadNeedlePickingForm()
        {
            NeedleNameLabel.Text = NeedleQtyStock.NeedleName.ToString();
            NeedleQtyTextbox.Text = NeedleQtyStock.TotalQuantity.ToString();
            PositionLabel.Text = NeedleQtyStock.StockName;
        }
    }
}
