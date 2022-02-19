using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;

using WinFormsMvp.Forms;

namespace NeedleController.Views
{
    public partial class MainView : MvpForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
        public event EventHandler GetNeedleClicked;
        public event EventHandler NeedleInfoClicked;
        public event EventHandler DeviceSettingClicked;
        public event EventHandler CameraSettingClicked;

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void GetNeedleButton_Click(object sender, EventArgs e)
        {
            GetNeedleClicked(this, EventArgs.Empty);
        }

        private void NeedleInfoButton_Click(object sender, EventArgs e)
        {
            NeedleInfoClicked(this, EventArgs.Empty);

        }

        private void DeviceSettingButton_Click(object sender, EventArgs e)
        {
            DeviceSettingClicked(this, EventArgs.Empty);
        }

        private void CameraSettingButton_Click(object sender, EventArgs e)
        {
            CameraSettingClicked(this, EventArgs.Empty);
        }

        public void ShowNeedlePickingView()
        {
            new NeedlePickingView().Show();
        }
        public void ShowNeedleInfoView()
        {
            new NeedleInfoView().Show();
        }
        public void ShowDeviceSettingView()
        {
            new DeviceSettingView().Show();
        }
        public void ShowCameraSettingView()
        {
            new CameraSettingView().Show();
        }
    }
}
