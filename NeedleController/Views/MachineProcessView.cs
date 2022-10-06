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
using System.Reflection;

namespace NeedleController.Views
{
    public partial class MachineProcessView : MvpForm, IMachineProcessView
    {
        private Image CapturedImage { get; set; } = null;
        private bool needle_confirm_flag { get; set; } = false;
        private bool data_saved_success { get; set; } = false;
        private bool load_done = false;
        public Image destVideo
        {
            get { return this.DestVideo.Image; }
            set { this.DestVideo.Image = value; }
        }
        public static bool _RFIDconfirm { get; set; }
        public static int user_id { get; set; }
        public static int user_deviceid { get; set; }
        public static string user_layer { get; set; }

        public string SelectedNeedleLength
        {
            get
            {
                return this.SelectedNeedleLegnthLabel.Text;
            }
            set
            {
                this.SelectedNeedleLegnthLabel.Text = value;
            }
        }
        private System.Windows.Forms.Timer timer_camera = new System.Windows.Forms.Timer { Enabled = true, Interval = 1000, };
        private int counter = 10;
        private System.Windows.Forms.TextBox POTextBox;


        public MachineProcessView()
        {
            InitializeComponent();
            InitializeTimer();
            InitializedestVideoTimer();

        }
        public event EventHandler MachineProcessOpened;
        public event EventHandler ContinueButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler SuccessButtonClicked;
        public event EventHandler FailButtonClicked;
        public event KeyPressEventHandler ReasonComboBoxKeyPressed;
        public event KeyPressEventHandler ProcessComboBoxKeyPressed;
        public event EventHandler MachineProcessClosed;


        private void MachineProcessView_Load(object sender, EventArgs e)
        {
            MachineProcessOpened(this, EventArgs.Empty);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButtonClicked(this, EventArgs.Empty);
        }
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ContinueButtonClicked(this, EventArgs.Empty);
        }
        private void SuccessButton_Click(object sender, EventArgs e)
        {
            SuccessButtonClicked(this, EventArgs.Empty);
        }

        private void FailButton_Click(object sender, EventArgs e)
        {
            FailButtonClicked(this, EventArgs.Empty);
        }
        private void ReasonComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReasonComboBoxKeyPressed(this, e);
        }
        private void ProcessComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessComboBoxKeyPressed(this, e);

        }
        private void MachineProcess_Close(object sender, FormClosedEventArgs e)
        {
            MachineProcessClosed(this, EventArgs.Empty);
        }
        public void PressKey_ReasonComboBox(KeyPressEventArgs e)
        {
            ReasonComboBox.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = ReasonComboBox.Text.Substring(0, ReasonComboBox.SelectionStart) + e.KeyChar;
            Int32 index = ReasonComboBox.FindStringExact(str);
            if (index == -1)
            {
                index = ReasonComboBox.FindString(str);
            }
            this.ReasonComboBox.SelectedIndex = index;
            this.ReasonComboBox.SelectionStart = str.Length;
            this.ReasonComboBox.SelectionLength = this.ReasonComboBox.Text.Length - this.ReasonComboBox.SelectionStart;
            e.Handled = true;
        }
        public void PressKey_ProcessComboBox(KeyPressEventArgs e)
        {
            ProcessComboBox.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            string str = ProcessComboBox.Text.Substring(0, ProcessComboBox.SelectionStart) + e.KeyChar;
            Int32 index = ProcessComboBox.FindStringExact(str);
            if (index == -1)
            {
                index = ProcessComboBox.FindString(str);
            }
            this.ProcessComboBox.SelectedIndex = index;
            this.ProcessComboBox.SelectionStart = str.Length;
            this.ProcessComboBox.SelectionLength = this.ProcessComboBox.Text.Length - this.ProcessComboBox.SelectionStart;
            e.Handled = true;
        }
        private void Operator_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void Load_MachineProgress()
        {
            Create_AutoCompleteTextBoxPO();
            ResourceManager myManager = new ResourceManager(typeof(MachineProcessView));
            var processes = EF_CONFIG.DataTransform.ProcessBase.Get_Processs();
            var reasons = EF_CONFIG.DataTransform.BrokenReasonBase.Get_Reasons();
            foreach (var item in reasons)
            {
                item.ReasonName = myManager.GetString(item.ReasonName);
            }
            ReasonComboBox.DataSource = reasons;
            ReasonComboBox.DisplayMember = "ReasonName";
            ReasonComboBox.ValueMember = "ReasonID";
            ReasonComboBox.SelectedItem = null;
            
            ProcessComboBox.DataSource = processes;
            ProcessComboBox.DisplayMember = "ProcessName";
            ProcessComboBox.ValueMember = "ProcessID";
            ProcessComboBox.SelectedItem = null;
            load_done = true;
        }
        public void ContinueGetNeedle()
        {
            try
            {
                timer_camera.Stop();
                timer_camera.Dispose();
                ResourceManager myManager = new ResourceManager(typeof(MachineProcessView));
                if (ReasonComboBox.SelectedValue == null)
                {
                    if (!needle_confirm_flag)
                    {
                        IDCardCheckingView iDCardCheckingView = new IDCardCheckingView(this.Name);
                        iDCardCheckingView.ShowDialog();
                        if (MainView.CardCheckingDetected)
                        {
                            if (_RFIDconfirm)
                            {
                                if (user_deviceid == MainView.device_id)
                                {
                                    if (user_layer == "qc")
                                    {
                                        if (ProcessComboBox.SelectedValue == null || ReasonComboBox.SelectedValue == null || MachineTextBox.Text == null || OperatorTextBox.Text == null || HandleTextBox.Text == null || POTextBox.Text == null)
                                        {
                                            DialogResult dr = MessageBox.Show(myManager.GetString("MessageBoxString1"), "Warning", MessageBoxButtons.YesNo);
                                            switch (dr)
                                            {
                                                case DialogResult.Yes:
                                                    NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                                    NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                                    NeedlePickingView.selected_operator = OperatorTextBox.Text;
                                                    NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                                    NeedlePickingView.selected_needlepartsenough = 0;
                                                    NeedlePickingView.selected_handle = HandleTextBox.Text;
                                                    NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                                    NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");

                                                    NeedlePickingView.selected_allowDateTime = DateTime.Now;
                                                    NeedlePickingView.selected_allowDateTimeStr = DateTime.Now.ToString();
                                                    NeedlePickingView.selected_allowStaffID = user_id;
                                                    NeedlePickingView.selected_po = POTextBox.Text;
                                                    FeedbackSuccess();
                                                    break;
                                                case DialogResult.No:
                                                    FeedbackCancel();
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                            NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                            NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                            NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                            NeedlePickingView.selected_needlepartsenough = 0;
                                            NeedlePickingView.selected_handle = HandleTextBox.Text;
                                            NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                            NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");

                                            NeedlePickingView.selected_allowDateTime = DateTime.Now;
                                            NeedlePickingView.selected_allowDateTimeStr = DateTime.Now.ToString();
                                            NeedlePickingView.selected_allowStaffID = user_id;
                                            NeedlePickingView.selected_po = POTextBox.Text;
                                            FeedbackSuccess();
                                        }
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
                            MainView.CardCheckingDetected = false;
                        }
                    }
                    else
                    {
                        if (ProcessComboBox.SelectedValue == null || ReasonComboBox.SelectedValue == null || MachineTextBox.Text == null || OperatorTextBox.Text == null || HandleTextBox.Text == null || POTextBox.Text == null)
                        {
                            DialogResult dr = MessageBox.Show(myManager.GetString("MessageBoxString1"), "Warning", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                    NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                    NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                    NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                    NeedlePickingView.selected_needlepartsenough = 1;
                                    NeedlePickingView.selected_handle = null;
                                    NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                    NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");


                                    NeedlePickingView.selected_allowDateTime = null;
                                    NeedlePickingView.selected_allowDateTimeStr = null;
                                    NeedlePickingView.selected_allowStaffID = null;
                                    NeedlePickingView.selected_po = null;
                                    FeedbackSuccess();
                                    break;
                                case DialogResult.No:
                                    FeedbackCancel();
                                    break;
                            }
                        }
                        else
                        {
                            NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                            NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                            NeedlePickingView.selected_operator = OperatorTextBox.Text;

                            NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                            NeedlePickingView.selected_needlepartsenough = 1;
                            NeedlePickingView.selected_handle = null;
                            NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                            NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");


                            NeedlePickingView.selected_allowDateTime = null;
                            NeedlePickingView.selected_allowDateTimeStr = null;
                            NeedlePickingView.selected_allowStaffID = null;
                            NeedlePickingView.selected_po = null;
                            FeedbackSuccess();
                        }
                    }
                }
                else
                {
                    if ((int)ReasonComboBox.SelectedValue == 4)
                    {
                        if (ProcessComboBox.SelectedValue == null || MachineTextBox.Text == null || OperatorTextBox.Text == null || HandleTextBox.Text == null || POTextBox.Text == null)
                        {
                            DialogResult dr = MessageBox.Show(myManager.GetString("MessageBoxString1"), "Warning", MessageBoxButtons.YesNo);
                            switch (dr)
                            {
                                case DialogResult.Yes:
                                    NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                    NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                    NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                    NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                    NeedlePickingView.selected_needlepartsenough = null;
                                    NeedlePickingView.selected_handle = HandleTextBox.Text;
                                    NeedlePickingView.selected_brokenDateTime = null;
                                    NeedlePickingView.selected_brokenDateTimeStr = null;

                                    NeedlePickingView.selected_allowDateTime = null;
                                    NeedlePickingView.selected_allowDateTimeStr = null;
                                    NeedlePickingView.selected_allowStaffID = null;
                                    NeedlePickingView.selected_po = POTextBox.Text;
                                    FeedbackSuccess();
                                    break;
                                case DialogResult.No:
                                    FeedbackCancel();
                                    break;
                            }
                        }
                        else
                        {
                            NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                            NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                            NeedlePickingView.selected_operator = OperatorTextBox.Text;

                            NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                            NeedlePickingView.selected_needlepartsenough = null;
                            NeedlePickingView.selected_handle = HandleTextBox.Text;
                            NeedlePickingView.selected_brokenDateTime = null;
                            NeedlePickingView.selected_brokenDateTimeStr = null;

                            NeedlePickingView.selected_allowDateTime = null;
                            NeedlePickingView.selected_allowDateTimeStr = null;
                            NeedlePickingView.selected_allowStaffID = null;
                            NeedlePickingView.selected_po = POTextBox.Text;
                            FeedbackSuccess();
                        }
                    }
                    else
                    {
                        if (!needle_confirm_flag)
                        {
                            IDCardCheckingView iDCardCheckingView = new IDCardCheckingView(this.Name);
                            iDCardCheckingView.ShowDialog();
                            if (MainView.CardCheckingDetected)
                            {
                                if (_RFIDconfirm)
                                {
                                    if (user_deviceid == MainView.device_id)
                                    {
                                        if (user_layer == "qc")
                                        {
                                            if (ProcessComboBox.SelectedValue == null || ReasonComboBox.SelectedValue == null || MachineTextBox.Text == null || OperatorTextBox.Text == null || HandleTextBox.Text == null || POTextBox.Text == null)
                                            {
                                                DialogResult dr = MessageBox.Show(myManager.GetString("MessageBoxString1"), "Warning", MessageBoxButtons.YesNo);
                                                switch (dr)
                                                {
                                                    case DialogResult.Yes:
                                                        NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                                        NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                                        NeedlePickingView.selected_operator = OperatorTextBox.Text;
                                                        NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                                        NeedlePickingView.selected_needlepartsenough = 0;
                                                        NeedlePickingView.selected_handle = HandleTextBox.Text;
                                                        NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                                        NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");

                                                        NeedlePickingView.selected_allowDateTime = DateTime.Now;
                                                        NeedlePickingView.selected_allowDateTimeStr = DateTime.Now.ToString();
                                                        NeedlePickingView.selected_allowStaffID = user_id;
                                                        NeedlePickingView.selected_po = POTextBox.Text;
                                                        FeedbackSuccess();
                                                        break;
                                                    case DialogResult.No:
                                                        FeedbackCancel();
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                                NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                                NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                                NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                                NeedlePickingView.selected_needlepartsenough = 0;
                                                NeedlePickingView.selected_handle = HandleTextBox.Text;
                                                NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                                NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");

                                                NeedlePickingView.selected_allowDateTime = DateTime.Now;
                                                NeedlePickingView.selected_allowDateTimeStr = DateTime.Now.ToString();
                                                NeedlePickingView.selected_allowStaffID = user_id;
                                                NeedlePickingView.selected_po = POTextBox.Text;
                                                FeedbackSuccess();
                                            }
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
                                MainView.CardCheckingDetected = false;
                            }
                        }
                        else
                        {
                            if (ProcessComboBox.SelectedValue == null || ReasonComboBox.SelectedValue == null || MachineTextBox.Text == null || OperatorTextBox.Text == null || HandleTextBox.Text == null || POTextBox.Text == null)
                            {
                                DialogResult dr = MessageBox.Show(myManager.GetString("MessageBoxString1"), "Warning", MessageBoxButtons.YesNo);
                                switch (dr)
                                {
                                    case DialogResult.Yes:
                                        NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                        NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                        NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                        NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                        NeedlePickingView.selected_needlepartsenough = 1;
                                        NeedlePickingView.selected_handle = null;
                                        NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                        NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");


                                        NeedlePickingView.selected_allowDateTime = null;
                                        NeedlePickingView.selected_allowDateTimeStr = null;
                                        NeedlePickingView.selected_allowStaffID = null;
                                        NeedlePickingView.selected_po = null;
                                        FeedbackSuccess();
                                        break;
                                    case DialogResult.No:
                                        FeedbackCancel();
                                        break;
                                }
                            }
                            else
                            {
                                NeedlePickingView.selected_processID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                                NeedlePickingView.selected_reasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                                NeedlePickingView.selected_operator = OperatorTextBox.Text;

                                NeedlePickingView.selected_sewingmachine = MachineTextBox.Text;
                                NeedlePickingView.selected_needlepartsenough = 1;
                                NeedlePickingView.selected_handle = null;
                                NeedlePickingView.selected_brokenDateTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                                NeedlePickingView.selected_brokenDateTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");


                                NeedlePickingView.selected_allowDateTime = null;
                                NeedlePickingView.selected_allowDateTimeStr = null;
                                NeedlePickingView.selected_allowStaffID = null;
                                NeedlePickingView.selected_po = null;
                                FeedbackSuccess();
                            }
                        }
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

        public void CancelGetNeedle()
        {
            try
            {
                timer_camera.Stop();
                timer_camera.Dispose();
                FeedbackCancel();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public void FeedbackSuccess()
        {
            NeedlePickingView._capturedImage = this.CapturedImage;
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:1>");
                    udpClient.Send(senddata, senddata.Length);
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message, MainView.device_id);
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
            CancelButton.Enabled = false;
            ContinueButton.Enabled = false;
            InputInformationGroupBox.Enabled = false;
        }
        public void FeedbackFail()
        {

            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:2>");
                    udpClient.Send(senddata, senddata.Length);

                }
                catch (Exception e)
                {
                    Logger.Error(e.Message, MainView.device_id);
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
        }
        public void FeedbackTimeOut()
        {

            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:3>");
                    udpClient.Send(senddata, senddata.Length);

                }
                catch (Exception e)
                {
                    Logger.Error(e.Message, MainView.device_id);
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
            CancelButton.Enabled = false;
            ContinueButton.Enabled = false;
            InputInformationGroupBox.Enabled = false;

        }
        public void FeedbackCancel()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(NeedleController.Properties.Settings.Default.local_ip, NeedleController.Properties.Settings.Default.port);
                    Byte[] senddata = Encoding.ASCII.GetBytes("<camera:4>");
                    udpClient.Send(senddata, senddata.Length);

                }
                catch (Exception e)
                {
                    Logger.Error(e.Message, MainView.device_id);
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
            CancelButton.Enabled = false;
            ContinueButton.Enabled = false;
            InputInformationGroupBox.Enabled = false;
        }
        public void MachineProcessClose()
        {
            timer1.Enabled = false;
        }
       
        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
        private void InitializedestVideoTimer()
        {
            destVideotimer2.Interval = 50;
            destVideotimer2.Tick += new EventHandler(destVideotimer2_Tick);
            destVideotimer2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainView.listbox_string == null)
            {
                return;
            }
            else
            {
                timer1.Stop();
                if (MainView.listbox_string == "check_camera")
                {
                    CapturedImage = NeedlePickingView.destVideo;
                    CaptureImagePictureBox.Image = CapturedImage;
                    CapturedNeedleLenghtLabel.Text = NeedlePickingView.captured_needle_length.ToString();
                    ResourceManager myManager = new ResourceManager(typeof(MachineProcessView));
                    NeedlePickingView.selected_captured_needle_length = NeedlePickingView.captured_needle_length;
                    if (NeedlePickingView.selected_needle_length - NeedlePickingView.selected_needle_length * 0.05 <= NeedlePickingView.captured_needle_length &&
                        NeedlePickingView.captured_needle_length <= NeedlePickingView.selected_needle_length + NeedlePickingView.selected_needle_length * 0.1) //+10%
                    {
                        InputInformationGroupBox.Enabled = true;
                        ContinueButton.Enabled = true;
                        CancelButton.Enabled = true;
                        POTextBox.Enabled = false;
                        HandleTextBox.Enabled = false;
                        ProcessStatusLabel.Text = myManager.GetString("confirmationsuccess");
                        counter = 60;
                        needle_confirm_flag = true;
                        timer_camera.Tick += new EventHandler(TimerCamera_Tick);
                        timer_camera.Start();
                        timerLabel.Text = counter.ToString();
                    }
                    else if (NeedlePickingView.captured_needle_length >= 0 && NeedlePickingView.captured_needle_length <= 10)
                    {
                        InputInformationGroupBox.Enabled = true;
                        ContinueButton.Enabled = true;
                        ContinueButton.Text = myManager.GetString("confirmbuttontext");
                        CancelButton.Enabled = true;
                        POTextBox.Enabled = true;
                        HandleTextBox.Enabled = true;
                        ProcessStatusLabel.Text = myManager.GetString("cannotconfirm");
                        counter = 60;
                        needle_confirm_flag = false;
                        timer_camera.Tick += new EventHandler(TimerCamera_Tick);
                        timer_camera.Start();
                        timerLabel.Text = counter.ToString();
                    }
                    else
                    {
                        InputInformationGroupBox.Enabled = true;
                        ContinueButton.Enabled = true;
                        ContinueButton.Text = myManager.GetString("confirmbuttontext");
                        CancelButton.Enabled = true;
                        POTextBox.Enabled = true;
                        HandleTextBox.Enabled = true;
                        ProcessStatusLabel.Text = myManager.GetString("confirmationfail");
                        counter = 60;
                        needle_confirm_flag = false;
                        timer_camera.Tick += new EventHandler(TimerCamera_Tick);
                        timer_camera.Start();
                        timerLabel.Text = counter.ToString();
                    }
                    NeedlePickingView.needlesupplied_status = false;
                }
                else if (MainView.listbox_string == "needle_supplied")
                {
                    data_saved_success = EF_CONFIG.DataTransform.StockBase.Update_Stock(NeedlePickingView.selected_stockid, MainView.device_id, NeedlePickingView.current_qty - 1);
                    if (data_saved_success)
                    {
                        NeedlePickingView.retry_flag = false;
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                    NeedlePickingView.needlesupplied_status = true;
                }
                else if (MainView.listbox_string == "camera_failed")
                {
                    ContinueButton.Text = "Retry";
                    CancelButton.Text = "Exit";
                    ContinueButton.Enabled = true;
                    CancelButton.Enabled = true;
                    NeedlePickingView.needlesupplied_status = false;
                }
                else if (MainView.listbox_string == "camera_time_out")
                {
                    this.Close();
                    NeedlePickingView.retry_flag = false;
                    NeedlePickingView.needlesupplied_status = false;
                }
                else if (MainView.listbox_string == "camera_canceled")
                {
                    this.Close();
                    NeedlePickingView.retry_flag = false;
                    NeedlePickingView.needlesupplied_status = false;
                }

                else if (MainView.listbox_string.Contains("higher_needle_qty_"))
                {
                    this.Close();
                    NeedlePickingView.retry_flag = false;
                    NeedlePickingView.needlesupplied_status = false;
                }
                else if (MainView.listbox_string.Contains("needle_stock_empty_"))
                {
                    this.Close();
                    NeedlePickingView.retry_flag = false;
                    NeedlePickingView.needlesupplied_status = false;
                }
                else
                {

                }
                MainView.listbox_string = null;
                timer1.Dispose();
                timer1.Start();
            }

        }
        private void destVideotimer2_Tick(object sender, EventArgs e)
        {
            destVideo = NeedlePickingView.destVideo;
        }
        private void TimerCamera_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                FeedbackTimeOut();
                timer_camera.Stop();
                timer_camera.Dispose();
            }
            timerLabel.Text = counter.ToString();
        }
        private void Create_AutoCompleteTextBoxPO()
        {
            try
            {
                string[] nameArray = MainView.POListString.ToArray();
                AutoCompleteTextBox tb = new AutoCompleteTextBox
                {
                    Dock = System.Windows.Forms.DockStyle.Bottom,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Margin = new System.Windows.Forms.Padding(10, 0, 10, 0),
                    Values = nameArray
                };
                this.tableLayoutPanel2.Controls.Add(tb, 3, 0);
                POTextBox = tb;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
            }
        }

        private void ReasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(load_done)
            {
                if((int)ReasonComboBox.SelectedValue == 4)
                {
                    BrokenDatePicker.Enabled = false;
                    BrokenTimePicker.Enabled = false;
                    POTextBox.Enabled = true;
                    HandleTextBox.Enabled = true;
                }
                else
                {
                    BrokenDatePicker.Enabled = true;
                    BrokenTimePicker.Enabled = true;
                    if (needle_confirm_flag)
                    {
                        POTextBox.Enabled = false;
                        HandleTextBox.Enabled = false;
                    }
                    else
                    {
                        POTextBox.Enabled = true;
                        HandleTextBox.Enabled = true;
                    }
                }
            }
        }
    }
    public class AutoCompleteTextBox : System.Windows.Forms.TextBox
    {
        private System.Windows.Forms.ListBox _listBox;
        private bool _isAdded;
        private string[] _values;
        public string[] Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
            }
        }

        public List<string> SelectedValues
        {
            get
            {
                string[] result = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return new List<string>(result);
            }
        }
        private string _formerValue = string.Empty;
        public AutoCompleteTextBox()
        {
            InitializeComponent();
            ResetListBox();
        }
        private void InitializeComponent()
        {
            _listBox = new System.Windows.Forms.ListBox();
            this.KeyDown += this_KeyDown;
            this.KeyUp += this_KeyUp;
            _listBox.KeyDown += this_KeyDown;
            _listBox.MouseDoubleClick += _listBox_MouseDoubleClick;
        }

        private void _listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_listBox.Visible)
            {
                Text = _listBox.SelectedItem.ToString();
                ResetListBox();
                _formerValue = Text;
                this.Select(this.Text.Length, 0);
            }
        }

        private void ShowListBox()
        {
            if (!_isAdded)
            {
                TableLayoutPanel tableLayout = this.Parent as TableLayoutPanel;
                tableLayout.Controls.Add(_listBox, 3, 1);
                tableLayout.SetRowSpan(_listBox, 3);
                _listBox.Top = Top + Height;
                _listBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
                _isAdded = true;
            }
            _listBox.Visible = true;
            _listBox.BringToFront();
        }

        private void ResetListBox()
        {
            _listBox.Visible = false;
        }

        private void this_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateListBox();
        }
        private void this_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    {
                        if (_listBox.Visible)
                        {
                            Text = _listBox.SelectedItem.ToString();
                            ResetListBox();
                            _formerValue = Text;
                            this.Select(this.Text.Length, 0);
                            e.Handled = true;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex < _listBox.Items.Count - 1))
                            _listBox.SelectedIndex++;
                        e.Handled = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex > 0))
                            _listBox.SelectedIndex--;
                        e.Handled = true;
                        break;
                    }


            }
        }
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    if (_listBox.Visible)
                        return true;
                    else
                        return false;
                default:
                    return base.IsInputKey(keyData);
            }
        }
        private void UpdateListBox()
        {
            if (Text == _formerValue)
                return;

            _formerValue = this.Text;
            string word = this.Text;

            if (_values != null && word.Length > 0)
            {
                string[] matches = Array.FindAll(_values,
                    x => (x.ToLower().Contains(word.ToLower())));
                if (matches.Length > 0)
                {
                    ShowListBox();
                    _listBox.BeginUpdate();
                    _listBox.Items.Clear();
                    Array.ForEach(matches, x => _listBox.Items.Add(x));
                    _listBox.SelectedIndex = 0;
                    _listBox.Height = 0;
                    Focus();
                    using (Graphics graphics = _listBox.CreateGraphics())
                    {
                        for (int i = 0; i < _listBox.Items.Count; i++)
                        {
                            if (i < 20)
                                _listBox.Height += _listBox.GetItemHeight(i);
                        }
                    }
                    _listBox.EndUpdate();
                }
                else
                {
                    ResetListBox();
                }
            }
            else
            {
                ResetListBox();
            }
        }

    }
}
