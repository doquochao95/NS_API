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
using System.Reflection;

namespace NeedleController.Views
{
    public partial class RecycleBinView : MvpForm, IRecycleBinView
    {
        public static bool _confirmation_flag { get; set; }
        public static bool _saved_flag { get; set; }

        public static bool _unconfirmation_flag { get; set; }
        public static bool _RFIDconfirm { get; set; }
        public static int user_id { get; set; }
        public static int user_deviceid { get; set; }
        public static string user_layer { get; set; }
        public static bool _editinformation_loaded { get; set; }

        private readonly MainView _MainView;
        private static DataTable dataTableRecycleBin = new DataTable();
        private static List<NS_RecycledBox> _recyclebin { get; set; }

        public RecycleBinView(MainView mainView)
        {
            InitializeComponent();
            InitializeTimer();
            _MainView = mainView;

        }

        public event EventHandler RecycleBinViewLoaded;
        public event EventHandler RecycleBinViewExited;
        public event MouseEventHandler RecycleBindataGridViewRightClicked;
        public event EventHandler DataGridViewSelectionChanged;

        private void RecycleBinView_Load(object sender, EventArgs e)
        {
            RecycleBinViewLoaded(this, EventArgs.Empty);

        }
        private void RecycleBinView_FormClosed(object sender, FormClosedEventArgs e)
        {
            RecycleBinViewExited(this, EventArgs.Empty);
        }
        private void RecycleBindataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            RecycleBindataGridViewRightClicked(this, e);
        }
        private void RecycleBindataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectionChanged(this, EventArgs.Empty);
        }

        public void RecycleBinViewLoad()
        {
            MainView.recyclebinviewloaded_status = true;
            MainView.last_view = this.Name;
            UserInfoLabel.Text = "User: " + MainView.user_name + " " + MainView.user_cardnumber;
            RecycleBindataGridView.AllowUserToAddRows = false;
            SettingUp_DataGridView();
            ColorDataGridView();
            _MainView.Reply_Buffer("<box:1>");
            MainView.close_waiting = true;
        }
        public void RecycleBinViewExit()
        {
            _MainView.Reply_Buffer("<box:0>");
            MainView.last_view = this.Name;
            MainView.recyclebinviewloaded_status = false;
        }
        public void RecycleBindataGridView_RightClick(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (RecycleBindataGridView.SelectedRows.Count == 1)
                {

                    ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
                    ContextMenu m = new ContextMenu();
                    int currentMouseOverRow = RecycleBindataGridView.HitTest(e.X, e.Y).RowIndex;
                    if (currentMouseOverRow >= 0)
                    {
                        m.MenuItems.Add(new MenuItem(string.Format(myManager.GetString("editinformation"), currentMouseOverRow.ToString()), MenuItemNew_Click));
                        m.MenuItems.Add("-");
                        m.MenuItems.Add(new MenuItem(string.Format(myManager.GetString("refresh"), currentMouseOverRow.ToString()), MenuItemNew_Click2));
                        m.MenuItems.Add(new MenuItem(string.Format(myManager.GetString("confirm"), currentMouseOverRow.ToString()), MenuItemNew_Click1));
                        m.MenuItems.Add(new MenuItem(string.Format(myManager.GetString("delete"), currentMouseOverRow.ToString()), MenuItemNew_Click3));
                        m.MenuItems.Add(new MenuItem(string.Format(myManager.GetString("replaceimage"), currentMouseOverRow.ToString()), MenuItemNew_Click4));
                    }

                    int selectedrowindex = RecycleBindataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = RecycleBindataGridView.Rows[selectedrowindex];
                    int _recycleboxId = Convert.ToInt32(selectedRow.Cells["RecycleBoxID"].Value);
                    NS_RecycledBox nS_Recycled = EF_CONFIG.DataTransform.RecycledBoxBase.Get_RecylcleBox(_recycleboxId);
                    string _status = selectedRow.Cells["CompletedStatus"].Value.ToString();
                    if (_status == myManager.GetString("completed"))
                    {
                        m.MenuItems[4].Enabled = true;
                    }
                    else
                    {
                        m.MenuItems[4].Enabled = false;
                    }
                    if (nS_Recycled.NeedlePartsEnough == 1)
                    {
                        m.MenuItems[3].Enabled = false;
                    }
                    else
                    {
                        if (nS_Recycled.ConfirmationByStaffID == null)
                        {
                            m.MenuItems[3].Enabled = true;
                        }
                        else
                        {
                            m.MenuItems[3].Enabled = false;
                        }
                    }
                    if (nS_Recycled.ReasonID == 4)
                    {
                        m.MenuItems[3].Enabled = false;
                        m.MenuItems[5].Enabled = false;
                    }
                    /*if (nS_Recycled.CapturedLength > 10 && nS_Recycled.CapturedLength < 60)
                    {
                        m.MenuItems[5].Enabled = false;
                    }
                    else
                    {
                        m.MenuItems[5].Enabled = true;
                    }*/
                    /* m.MenuItems[0].Enabled = false;*/
                    m.Show(RecycleBindataGridView, new Point(e.X, e.Y));
                }
            }
        }
        public void DataGridView_ChangeSelection()
        {
            if (RecycleBindataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = RecycleBindataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = RecycleBindataGridView.Rows[selectedrowindex];
                int _recycleboxId = Convert.ToInt32(selectedRow.Cells["RecycleBoxID"].Value);
                ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
                foreach (var item in _recyclebin)
                {
                    if (item.RecycleBoxID == _recycleboxId)
                    {
                        if (item.ReasonID == 4) // get new needle
                        {
                            string reason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.ReasonID).ReasonName;
                            informationRecycleBinUC1._brokentimestr = null;
                            informationRecycleBinUC1._partenough = null;
                            informationRecycleBinUC1._confirmationTime = null;
                            informationRecycleBinUC1._confirmationBy = null;
                            informationRecycleBinUC1._capturedimage = null;

                            informationRecycleBinUC1._needlename = Convert.ToString(EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NeedleID).NeedleName);
                            informationRecycleBinUC1._devicename = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.DeviceID).DeviceName;
                            informationRecycleBinUC1._exporttimestr = item.ExportTimeStr;
                            informationRecycleBinUC1._staffname = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.GetByStaffID).StaffName;
                            informationRecycleBinUC1._line = item.NS_Staffs.NS_Lines.LineName;
                            informationRecycleBinUC1._reason = myManager.GetString(reason);
                            if (item.Operator == null)
                            {
                                informationRecycleBinUC1._operator = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._operator = item.Operator.ToString();
                            }
                            if (item.SewingMachine == null)
                            {
                                informationRecycleBinUC1._sewingmachine = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._sewingmachine = item.SewingMachine.ToString();
                            }
                            if (item.ProcessID == null)
                            {
                                informationRecycleBinUC1._procsess = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._procsess = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.ProcessID).ProcessName;
                            }
                            if (item.Handle == null)
                            {
                                informationRecycleBinUC1._handle = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._handle = item.Handle;
                            }
                            if (item.PO == null)
                            {
                                informationRecycleBinUC1._po = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._po = item.PO;
                            }
                        }
                        else // exchange needle
                        {
                            informationRecycleBinUC1._needlename = Convert.ToString(EF_CONFIG.DataTransform.NeedleBase.Get_Needles(item.NeedleID).NeedleName);
                            informationRecycleBinUC1._devicename = EF_CONFIG.DataTransform.DeviceBase.Get_DeviceWithDeviceId(item.DeviceID).DeviceName;
                            if (item.BrokenTimeStr == null)
                            {
                                informationRecycleBinUC1._brokentimestr = myManager.GetString("required");
                                informationRecycleBinUC1._brokentimeColor = Color.Red;
                            }
                            else
                            {
                                informationRecycleBinUC1._brokentimestr = item.BrokenTimeStr;
                                informationRecycleBinUC1._brokentimeColor = Color.Black;

                            }
                            informationRecycleBinUC1._exporttimestr = item.ExportTimeStr;
                            informationRecycleBinUC1._staffname = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.GetByStaffID).StaffName;
                            informationRecycleBinUC1._line = item.NS_Staffs.NS_Lines.LineName;
                            if (item.SewingMachine == null)
                            {
                                informationRecycleBinUC1._sewingmachine = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._sewingmachine = item.SewingMachine.ToString();
                            }
                            if (item.Operator == null)
                            {
                                informationRecycleBinUC1._operator = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._operator = item.Operator.ToString();
                            }
                            if (item.ProcessID == null)
                            {
                                informationRecycleBinUC1._procsess = myManager.GetString("required");
                            }
                            else
                            {
                                informationRecycleBinUC1._procsess = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(item.ProcessID).ProcessName;
                            }
                            if (item.ReasonID == null)
                            {
                                informationRecycleBinUC1._reason = myManager.GetString("required");
                            }
                            else
                            {
                                string reason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(item.ReasonID).ReasonName;
                                informationRecycleBinUC1._reason = myManager.GetString(reason);
                            }
                            if (item.NeedlePartsEnough == 1)
                            {
                                informationRecycleBinUC1._partenough = myManager.GetString("enoughtext");

                                if (item.ConfirmationByStaffID != null)
                                {
                                    informationRecycleBinUC1._confirmationBy = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.ConfirmationByStaffID).StaffName;
                                    informationRecycleBinUC1._confirmationTime = item.ConfirmationTimeStr;
                                }
                                else
                                {
                                    informationRecycleBinUC1._confirmationTime = null;
                                    informationRecycleBinUC1._confirmationBy = null;
                                }
                                informationRecycleBinUC1._handle = item.Handle;
                                informationRecycleBinUC1._po = item.PO;
                            }
                            else if (item.NeedlePartsEnough == 0)
                            {
                                informationRecycleBinUC1._partenough = myManager.GetString("notenoughtext");
                                if (item.ConfirmationByStaffID != null)
                                {
                                    informationRecycleBinUC1._confirmationBy = EF_CONFIG.DataTransform.StaffBase.Get_Staff(item.ConfirmationByStaffID).StaffName;
                                    informationRecycleBinUC1._confirmationTime = item.ConfirmationTimeStr;
                                }
                                else
                                {
                                    informationRecycleBinUC1._confirmationTime = myManager.GetString("required");
                                    informationRecycleBinUC1._confirmationBy = myManager.GetString("required");
                                }
                                if (item.Handle == null)
                                {
                                    informationRecycleBinUC1._handle = myManager.GetString("required");

                                }
                                else
                                {
                                    informationRecycleBinUC1._handle = item.Handle;
                                }
                                if (item.PO == null)
                                {
                                    informationRecycleBinUC1._po = myManager.GetString("required");

                                }
                                else
                                {
                                    informationRecycleBinUC1._po = item.PO;
                                }
                            }
                            else
                            {
                                informationRecycleBinUC1._partenough = myManager.GetString("required");
                            }
                            informationRecycleBinUC1._capturedimage = byteArrayToImage(item.RecycleNeedleImage);
                            if (item.CapturedLength == 0)
                            {
                                informationRecycleBinUC1.draw_picturebox(myManager.GetString("cannotdetect"));
                            }
                        }
                    }
                }
            }

        }

        public void Delete_RecycleBin()
        {
            if (RecycleBindataGridView.SelectedCells.Count > 0)
            {
                ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
                List<RecycleBinInformationModel> list_recyclebox = new List<RecycleBinInformationModel>();
                foreach (DataGridViewRow dataGridViewRow in RecycleBindataGridView.SelectedRows)
                {
                    RecycleBinInformationModel recycledBox = new RecycleBinInformationModel()
                    {
                        SN = Convert.ToInt32(dataGridViewRow.Cells["SN"].Value),
                        RecycleBoxID = Convert.ToInt32(dataGridViewRow.Cells["RecycleBoxID"].Value),
                        Line = dataGridViewRow.Cells["Line"].Value.ToString(),
                        Needle = Convert.ToInt32(dataGridViewRow.Cells["Needle"].Value),
                        WarehouseCode = Convert.ToInt32(dataGridViewRow.Cells["WarehouseCode"].Value),
                        ExportTime = (DateTime)dataGridViewRow.Cells["ExportTime"].Value,
                        CompletedStatus = dataGridViewRow.Cells["CompletedStatus"].Value.ToString()
                    };
                    list_recyclebox.Add(recycledBox);
                }
                foreach (var item in list_recyclebox)
                {
                    if (item.CompletedStatus == myManager.GetString("completed"))
                    {
                        while (true)
                        {
                            bool status = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBinRemoveFromBox(item.RecycleBoxID, MainView.user_id);
                            if (status)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please to complete the requirement information first");
                    }
                }
            }
            SettingUp_DataGridView();
            ColorDataGridView();
        }
        public void Confirm_RecycleBin()
        {
            ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
            using (IDCardCheckingView checkingView = new IDCardCheckingView(this.Name))
            {
                checkingView.ShowDialog();
            }
            if (MainView.CardCheckingDetected)
            {
                if (_RFIDconfirm)
                {
                    if (user_deviceid == MainView.device_id)
                    {
                        if (user_layer == "qc")
                        {
                            List<RecycleBinInformationModel> list_recyclebox = new List<RecycleBinInformationModel>();
                            foreach (DataGridViewRow dataGridViewRow in RecycleBindataGridView.SelectedRows)
                            {
                                RecycleBinInformationModel recycledBox = new RecycleBinInformationModel()
                                {
                                    SN = Convert.ToInt32(dataGridViewRow.Cells["SN"].Value),
                                    RecycleBoxID = Convert.ToInt32(dataGridViewRow.Cells["RecycleBoxID"].Value),
                                    Line = dataGridViewRow.Cells["Line"].Value.ToString(),
                                    Needle = Convert.ToInt32(dataGridViewRow.Cells["Needle"].Value),
                                    WarehouseCode = Convert.ToInt32(dataGridViewRow.Cells["WarehouseCode"].Value),
                                    ExportTime = (DateTime)dataGridViewRow.Cells["ExportTime"].Value,
                                    CompletedStatus = dataGridViewRow.Cells["CompletedStatus"].Value.ToString()
                                };
                                list_recyclebox.Add(recycledBox);
                            }
                            foreach (var item in list_recyclebox)
                            {
                                if (item.CompletedStatus == myManager.GetString("uncompleted"))
                                {
                                    NS_RecycledBox s_RecycledBox = EF_CONFIG.DataTransform.RecycledBoxBase.Get_RecylcleBox(item.RecycleBoxID);
                                    if (s_RecycledBox.ConfirmationByStaffID != null)
                                    {
                                        MessageBox.Show("Your needle informations have already confirmed ");
                                    }
                                    else
                                    {
                                        while (true)
                                        {
                                            bool flag = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBinConfirmation(s_RecycledBox.RecycleBoxID, user_id);
                                            if (flag)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Your needle informations are already completed ");

                                }
                            }
                            SettingUp_DataGridView();
                            ColorDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("You need QC permission to confirm this");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You is not permitted with this device");
                    }
                }
                else
                {
                    MessageBox.Show("Your ID is invailable");
                }
            }
            this.Show();
            this.Focus();
        }
        private void InitializeTimer()
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_editinformation_loaded)
            {
                return;
            }
            MachineStatusDevice.Text = MainView.device_name + ":" + MainView.building_name + ":" + DateTime.Now.ToString("F");
            bool _cableConnection = _MainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
            while (true)
            {
                if (!_cableConnection)
                {
                    MainView._connected = false;
                    Logger.Error("Lost connection from " + MainView.device_name, MainView.device_id);
                    timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to device again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        case DialogResult.Retry:
                            _cableConnection = _MainView.PingHost(NeedleController.Properties.Settings.Default.local_ip);
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
                        timer1.Start();
                    }
                    break;
                }
            }
            bool database_conneciton = _MainView.CheckForDatabaseConnection();
            while (true)
            {
                if (!database_conneciton)
                {
                    MainView._databaseconnected = false;
                    Logger.Error("Lost connection from database", MainView.device_id);
                    timer1.Stop();
                    switch (MessageBox.Show(this, "Check connection to database again", "Error: Communication", MessageBoxButtons.RetryCancel))
                    {
                        //Stay on this form
                        case DialogResult.Retry:
                            database_conneciton = _MainView.CheckForDatabaseConnection();
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
                        timer1.Start();
                    }
                    break;
                }
            }
        }
        private void MenuItemNew_Click(Object sender, System.EventArgs ev)
        {
            try
            {
                int selectedrowindex = RecycleBindataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = RecycleBindataGridView.Rows[selectedrowindex];
                int _recycleboxId = Convert.ToInt32(selectedRow.Cells["RecycleBoxID"].Value);
                EditInformationView view = new EditInformationView(_recycleboxId);
                view.ShowDialog();
                if (_saved_flag)
                {
                    SettingUp_DataGridView();
                    ColorDataGridView();
                    _saved_flag = false;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        private void MenuItemNew_Click1(Object sender, System.EventArgs e)
        {
            Confirm_RecycleBin();
        }
        private void MenuItemNew_Click2(Object sender, System.EventArgs e)
        {
            SettingUp_DataGridView();
            ColorDataGridView();
        }
        private void MenuItemNew_Click3(Object sender, System.EventArgs e)
        {
            Delete_RecycleBin();
        }
        private void MenuItemNew_Click4(Object sender, System.EventArgs ev)
        {
            try
            {
                int selectedrowindex = RecycleBindataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = RecycleBindataGridView.Rows[selectedrowindex];
                int _recycleboxId = Convert.ToInt32(selectedRow.Cells["RecycleBoxID"].Value);
                ImageReplaceView replaceView = new ImageReplaceView(_MainView, _recycleboxId);
                replaceView.ShowDialog();
                if (_saved_flag)
                {
                    SettingUp_DataGridView();
                    ColorDataGridView();
                    _saved_flag = false;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        private void SettingUp_DataGridView()
        {
            try
            {
                ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
                _recyclebin = EF_CONFIG.DataTransform.RecycledBoxBase.Get_AllRecycleBinAvailable(MainView.device_id);
                _MainView.start_progressbar(progressBar1);
                List<RecycleBinInformationModel> list = new List<RecycleBinInformationModel>();
                int _sn = 1;
                foreach (var nS in _recyclebin)
                {
                    if (nS.ReasonID == 4)
                    {
                        nS.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(nS.GetByStaffID);
                        nS.NS_Staffs.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(nS.NS_Staffs.LineID);
                        if (nS.SewingMachine != null && nS.Operator != null && nS.ProcessID != null && nS.Handle != null && nS.PO != null)
                        {
                                RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                {
                                    SN = _sn,
                                    RecycleBoxID = nS.RecycleBoxID,
                                    Line = nS.NS_Staffs.NS_Lines.LineName,
                                    Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                    WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                    ExportTime = nS.ExportTime,
                                    CompletedStatus = myManager.GetString("completed")
                                };
                                list.Add(recycleBinInformationModel);                           
                        }
                        else
                        {
                            RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                            {
                                SN = _sn,
                                RecycleBoxID = nS.RecycleBoxID,
                                Line = nS.NS_Staffs.NS_Lines.LineName,
                                Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                ExportTime = nS.ExportTime,
                                CompletedStatus = myManager.GetString("uncompleted")
                            };
                            list.Add(recycleBinInformationModel);
                        }
                        _sn++;
                    }
                    else
                    {
                        nS.NS_Staffs = EF_CONFIG.DataTransform.StaffBase.Get_Staff(nS.GetByStaffID);
                        nS.NS_Staffs.NS_Lines = EF_CONFIG.DataTransform.LineBase.Get_Line(nS.NS_Staffs.LineID);
                        if (nS.NeedlePartsEnough == 1)
                        {
                            if (nS.ConfirmationByStaffID > 0)
                            {
                                if (nS.BrokenTimeStr != null && nS.SewingMachine != null && nS.Operator != null && nS.ProcessID != null && nS.ReasonID != null)
                                {
                                    if (nS.CapturedLength > 20 && nS.CapturedLength < 60)
                                    {
                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("completed")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                    else
                                    {

                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("uncompleted")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                }
                                else
                                {
                                    RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                    {
                                        SN = _sn,
                                        RecycleBoxID = nS.RecycleBoxID,
                                        Line = nS.NS_Staffs.NS_Lines.LineName,
                                        Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                        WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                        ExportTime = nS.ExportTime,
                                        CompletedStatus = myManager.GetString("uncompleted")
                                    };
                                    list.Add(recycleBinInformationModel);
                                }
                            }
                            else
                            {
                                if (nS.BrokenTimeStr != null && nS.SewingMachine != null && nS.Operator != null && nS.ProcessID != null && nS.ReasonID != null)
                                {
                                    if (nS.CapturedLength > 20 && nS.CapturedLength < 60)
                                    {
                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("completed")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                    else
                                    {

                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("uncompleted")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                }
                                else
                                {
                                    RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                    {
                                        SN = _sn,
                                        RecycleBoxID = nS.RecycleBoxID,
                                        Line = nS.NS_Staffs.NS_Lines.LineName,
                                        Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                        WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                        ExportTime = nS.ExportTime,
                                        CompletedStatus = myManager.GetString("uncompleted")
                                    };
                                    list.Add(recycleBinInformationModel);
                                }
                            }

                        }
                        else
                        {
                            if (nS.ConfirmationByStaffID > 0)
                            {
                                if (nS.BrokenTimeStr != null && nS.SewingMachine != null && nS.Operator != null && nS.ProcessID != null && nS.ReasonID != null && nS.Handle != null && nS.PO != null)
                                {
                                    if (nS.CapturedLength > 20 && nS.CapturedLength < 60)
                                    {
                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("completed")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                    else
                                    {

                                        RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                        {
                                            SN = _sn,
                                            RecycleBoxID = nS.RecycleBoxID,
                                            Line = nS.NS_Staffs.NS_Lines.LineName,
                                            Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                            WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                            ExportTime = nS.ExportTime,
                                            CompletedStatus = myManager.GetString("uncompleted")
                                        };
                                        list.Add(recycleBinInformationModel);
                                    }
                                }
                                else
                                {
                                    RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                    {
                                        SN = _sn,
                                        RecycleBoxID = nS.RecycleBoxID,
                                        Line = nS.NS_Staffs.NS_Lines.LineName,
                                        Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                        WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                        ExportTime = nS.ExportTime,
                                        CompletedStatus = myManager.GetString("uncompleted")
                                    };
                                    list.Add(recycleBinInformationModel);
                                }
                            }
                            else
                            {
                                RecycleBinInformationModel recycleBinInformationModel = new RecycleBinInformationModel
                                {
                                    SN = _sn,
                                    RecycleBoxID = nS.RecycleBoxID,
                                    Line = nS.NS_Staffs.NS_Lines.LineName,
                                    Needle = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleName,
                                    WarehouseCode = EF_CONFIG.DataTransform.NeedleBase.Get_Needles(nS.NeedleID).NeedleWarehouseCode,
                                    ExportTime = nS.ExportTime,
                                    CompletedStatus = myManager.GetString("uncompleted")
                                };
                                list.Add(recycleBinInformationModel);
                            }
                        }
                        _sn++;
                    }
                }
                dataTableRecycleBin = ToDataTable(list);
                this.RecycleBindataGridView.DataSource = dataTableRecycleBin;
                this.RecycleBindataGridView.Columns["SN"].HeaderText = myManager.GetString("serinumber");
                this.RecycleBindataGridView.Columns["Line"].HeaderText = myManager.GetString("line");
                this.RecycleBindataGridView.Columns["Needle"].HeaderText = myManager.GetString("needle");
                this.RecycleBindataGridView.Columns["WarehouseCode"].HeaderText = myManager.GetString("warehousecode");
                this.RecycleBindataGridView.Columns["ExportTime"].HeaderText = myManager.GetString("exporttime");
                this.RecycleBindataGridView.Columns["CompletedStatus"].HeaderText = myManager.GetString("completestatus");
                this.RecycleBindataGridView.Columns["RecycleBoxID"].Visible = false;
                _MainView.stop_progressbar(progressBar1);
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        private void ColorDataGridView()
        {
            try
            {
                ResourceManager myManager = new ResourceManager(typeof(RecycleBinView));
                foreach (DataGridViewRow row in RecycleBindataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells["CompletedStatus"].FormattedValue) == myManager.GetString("completed"))
                    {
                        row.Cells["CompletedStatus"].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        row.Cells["CompletedStatus"].Style.BackColor = Color.Red;
                    }
                }
                foreach (DataGridViewColumn column in RecycleBindataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn != null)
                {
                    System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
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
        private DataTable ToDataTable<T>(List<T> data)
        {
            try
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                DataTable table = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
                return table;
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
