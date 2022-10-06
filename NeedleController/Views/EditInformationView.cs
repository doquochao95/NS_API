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
    public partial class EditInformationView : MvpForm, IEditInformationView
    {
        private int _RecycledBoxID;
        private bool loaddone = false;
        private string init_PO;
        private string init_operator;
        private string init_process;
        private string init_reason;
        private string init_sewingmachine;
        private string init_handle;
        private string init_brokentimestring;
        private TextBox POtextbox;
        private NS_RecycledBox recycledBox;

        public EditInformationView(int RecycleBoxID)
        {
            InitializeComponent();
            _RecycledBoxID = RecycleBoxID;


        }
        public event EventHandler ExitButtonClicked;
        public event EventHandler SaveButtonClicked;
        public event EventHandler EditInformationLoaded;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButtonClicked(this, EventArgs.Empty);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButtonClicked(this, EventArgs.Empty);
        }
        private void EditInformation_Load(object sender, EventArgs e)
        {
            EditInformationLoaded(this, EventArgs.Empty);
        }
        private void Operator_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void Load_EditInformationView()
        {
            RecycleBinView._editinformation_loaded = true;
            Create_AutoCompleteTextBoxPO();
            ResourceManager myManager = new ResourceManager(typeof(EditInformationView));
            var reasons = EF_CONFIG.DataTransform.BrokenReasonBase.Get_Reasons();
            foreach (var item in reasons)
            {
                item.ReasonName = myManager.GetString(item.ReasonName);
            }
            var processes = EF_CONFIG.DataTransform.ProcessBase.Get_Processs();
            ReasonComboBox.DataSource = reasons;
            ReasonComboBox.DisplayMember = "ReasonName";
            ReasonComboBox.ValueMember = "ReasonID";
            ReasonComboBox.SelectedItem = null;
            ProcessComboBox.DataSource = processes;
            ProcessComboBox.DisplayMember = "ProcessName";
            ProcessComboBox.ValueMember = "ProcessID";
            ProcessComboBox.SelectedItem = null;
            recycledBox = EF_CONFIG.DataTransform.RecycledBoxBase.Get_RecylcleBox(_RecycledBoxID);
            if (recycledBox.ReasonID == 4)
            {
                BrokenDatePicker.Value = DateTime.Now;
                BrokenTimePicker.Value = DateTime.Now;
                BrokenDatePicker.Enabled = false;
                BrokenTimePicker.Enabled = false;
                init_brokentimestring = null;
                if (recycledBox.ProcessID != null)
                {
                    recycledBox.NS_Process = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(recycledBox.ProcessID);
                    ProcessComboBox.SelectedItem = recycledBox.ProcessID;
                    ProcessComboBox.SelectedText = recycledBox.NS_Process.ProcessName;
                    init_process = recycledBox.NS_Process.ProcessName;
                }
                else
                {
                    init_process = null;
                    ProcessComboBox.SelectedText = null;
                }
                recycledBox.NS_BrokenReason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(recycledBox.ReasonID);
                ReasonComboBox.SelectedItem = recycledBox.ReasonID;
                ReasonComboBox.SelectedText = myManager.GetString(recycledBox.NS_BrokenReason.ReasonName);
                init_reason = myManager.GetString(recycledBox.NS_BrokenReason.ReasonName);
                POtextbox.Text = recycledBox.PO;
                init_PO = recycledBox.PO;
                OperatorTextBox.Text = recycledBox.Operator.ToString();
                init_operator = recycledBox.Operator.ToString();
                MachineTextBox.Text = recycledBox.SewingMachine;
                init_sewingmachine = recycledBox.SewingMachine;
                HandleTextBox.Text = recycledBox.Handle;
                init_handle = recycledBox.Handle;


                POtextbox.Enabled = true;
                HandleTextBox.Enabled = true;
            }
            else
            {
                if (recycledBox.ProcessID != null)
                {
                    recycledBox.NS_Process = EF_CONFIG.DataTransform.ProcessBase.Get_ProcesssbyID(recycledBox.ProcessID);
                    ProcessComboBox.SelectedItem = recycledBox.ProcessID;
                    ProcessComboBox.SelectedText = recycledBox.NS_Process.ProcessName;
                    init_process = recycledBox.NS_Process.ProcessName;
                }
                else
                {
                    init_process = null;
                    ProcessComboBox.SelectedText = null;
                }
                if (recycledBox.ReasonID != null)
                {
                    recycledBox.NS_BrokenReason = EF_CONFIG.DataTransform.BrokenReasonBase.Get_ReasonsbyID(recycledBox.ReasonID);
                    ReasonComboBox.SelectedItem = recycledBox.ReasonID;
                    ReasonComboBox.SelectedText = myManager.GetString(recycledBox.NS_BrokenReason.ReasonName);
                    init_reason = myManager.GetString(recycledBox.NS_BrokenReason.ReasonName);
                }
                else
                {
                    init_reason = null;
                    ReasonComboBox.SelectedText = null;
                }
                POtextbox.Text = recycledBox.PO;
                init_PO = recycledBox.PO;
                OperatorTextBox.Text = recycledBox.Operator.ToString();
                init_operator = recycledBox.Operator.ToString();
                MachineTextBox.Text = recycledBox.SewingMachine;
                init_sewingmachine = recycledBox.SewingMachine;
                HandleTextBox.Text = recycledBox.Handle;
                init_handle = recycledBox.Handle;
                BrokenDatePicker.Value = (DateTime)recycledBox.BrokenTime;
                BrokenTimePicker.Value = (DateTime)recycledBox.BrokenTime;
                init_brokentimestring = recycledBox.BrokenTime.ToString();
                if (recycledBox.NeedlePartsEnough == 1)
                {
                    POtextbox.Enabled = false;
                    HandleTextBox.Enabled = false;
                }
                else
                {
                    POtextbox.Enabled = true;
                    HandleTextBox.Enabled = true;
                }
            }
            loaddone = true;
        }
        public void Save_Information()
        {
            try
            {
                if (init_sewingmachine == null)
                {
                    init_sewingmachine = "";
                }
                if (init_PO == null)
                {
                    init_PO = "";
                }
                if (init_handle == null)
                {
                    init_handle = "";
                }
                if (init_process == null)
                {
                    init_process = "";
                }
                if (init_reason == null)
                {
                    init_reason = "";
                }
                if (Convert.ToInt32(ReasonComboBox.SelectedValue) == 4)
                {
                    if (init_process != ProcessComboBox.Text)
                    {
                        if (string.IsNullOrEmpty(ProcessComboBox.Text))
                        {
                            recycledBox.ProcessID = null;
                        }
                        else
                        {
                            recycledBox.ProcessID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                        }
                    }
                    if (init_reason != ReasonComboBox.Text)
                    {
                        if (string.IsNullOrEmpty(ReasonComboBox.Text))
                        {
                            recycledBox.ReasonID = null;
                        }
                        else
                        {
                            recycledBox.ReasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);
                        }
                    }
                    if (init_operator != OperatorTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(OperatorTextBox.Text))
                        {
                            recycledBox.Operator = null;
                        }
                        else
                        {
                            recycledBox.Operator = Convert.ToInt32(OperatorTextBox.Text);
                        }
                    }
                    if (init_sewingmachine != MachineTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(MachineTextBox.Text))
                        {
                            recycledBox.SewingMachine = null;
                        }
                        else
                        {
                            recycledBox.SewingMachine = MachineTextBox.Text;
                        }
                    }
                    if (init_handle != HandleTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(HandleTextBox.Text))
                        {
                            recycledBox.Handle = null;
                        }
                        else
                        {
                            recycledBox.Handle = HandleTextBox.Text;
                        }
                    }
                    recycledBox.BrokenTime = null;
                    recycledBox.BrokenTimeStr = null;
                    if (init_PO != POtextbox.Text)
                    {
                        if (string.IsNullOrEmpty(POtextbox.Text))
                        {
                            recycledBox.PO = null;
                        }
                        else
                        {
                            recycledBox.PO = POtextbox.Text;
                        }
                    }
                    while (true)
                    {
                        bool flag = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBin(recycledBox);
                        if (flag)
                        {
                            break;
                        }
                    }
                    this.Close();
                    RecycleBinView._editinformation_loaded = false;
                    RecycleBinView._saved_flag = true;
                }
                else
                {
                    if (init_process != ProcessComboBox.Text)
                    {
                        if (string.IsNullOrEmpty(ProcessComboBox.Text))
                        {
                            recycledBox.ProcessID = null;
                        }
                        else
                        {
                            recycledBox.ProcessID = Convert.ToInt32(ProcessComboBox.SelectedValue);
                        }
                    }
                    if (init_reason != ReasonComboBox.Text)
                    {
                        if (string.IsNullOrEmpty(ReasonComboBox.Text))
                        {
                            recycledBox.ReasonID = null;
                        }
                        else
                        {
                            recycledBox.ReasonID = Convert.ToInt32(ReasonComboBox.SelectedValue);

                        }
                    }
                    if (init_operator != OperatorTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(OperatorTextBox.Text))
                        {
                            recycledBox.Operator = null;
                        }
                        else
                        {
                            recycledBox.Operator = Convert.ToInt32(OperatorTextBox.Text);
                        }
                    }
                    if (init_sewingmachine != MachineTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(MachineTextBox.Text))
                        {
                            recycledBox.SewingMachine = null;
                        }
                        else
                        {
                            recycledBox.SewingMachine = MachineTextBox.Text;
                        }
                    }
                    if (init_handle != HandleTextBox.Text)
                    {
                        if (string.IsNullOrEmpty(HandleTextBox.Text))
                        {
                            recycledBox.Handle = null;
                        }
                        else
                        {
                            recycledBox.Handle = HandleTextBox.Text;
                        }
                    }
                    if (init_brokentimestring != BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString())
                    {
                        recycledBox.BrokenTime = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay);
                        recycledBox.BrokenTimeStr = BrokenDatePicker.Value.Date.Add(BrokenTimePicker.Value.TimeOfDay).ToString("HH:mm, dd/MM/yyyy");
                    }
                    if (init_PO != POtextbox.Text)
                    {
                        if (string.IsNullOrEmpty(POtextbox.Text))
                        {
                            recycledBox.PO = null;
                        }
                        else
                        {
                            recycledBox.PO = POtextbox.Text;
                        }
                    }
                    while (true)
                    {
                        bool flag = EF_CONFIG.DataTransform.RecycledBoxBase.Update_RecycleBin(recycledBox);
                        if (flag)
                        {
                            break;
                        }
                    }
                    this.Close();
                    RecycleBinView._editinformation_loaded = false;
                    RecycleBinView._saved_flag = true;
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public void Exit_EditInformationForm()
        {
            RecycleBinView._saved_flag = false;
            this.Close();
            RecycleBinView._editinformation_loaded = false;

        }
        private void Create_AutoCompleteTextBoxPO()
        {
            try
            {
                string[] nameArray = MainView.POListString.ToArray();
                AutoCompleteTextBox1 tb = new AutoCompleteTextBox1
                {
                    Dock = System.Windows.Forms.DockStyle.Bottom,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Margin = new System.Windows.Forms.Padding(10, 0, 10, 0),
                    Size = new System.Drawing.Size(234, 26),
                    Values = nameArray
                };
                this.tableLayoutPanel2.Controls.Add(tb, 3, 2);
                POtextbox = tb;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
            }
        }

        private void ReasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaddone)
            {
                int value;
                value = (int)ReasonComboBox.SelectedValue;
                if (value == 4)
                {
                    BrokenDatePicker.Enabled = false;
                    BrokenTimePicker.Enabled = false;
                    POtextbox.Enabled = true;
                    HandleTextBox.Enabled = true;
                    POtextbox.Text = init_PO;
                    HandleTextBox.Text = init_handle;
                }
                else
                {
                    BrokenDatePicker.Enabled = true;
                    BrokenTimePicker.Enabled = true;
                    if (recycledBox.NeedlePartsEnough == 0)
                    {
                        POtextbox.Enabled = true;
                        HandleTextBox.Enabled = true;
                        POtextbox.Text = init_PO;
                        HandleTextBox.Text = init_handle;
                    }
                    else
                    {
                        POtextbox.Enabled = false;
                        HandleTextBox.Enabled = false;
                        POtextbox.Text = null;
                        HandleTextBox.Text = null;
                    }

                }
            }

        }
    }
    public class AutoCompleteTextBox1 : TextBox
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

        public AutoCompleteTextBox1()
        {
            InitializeComponent();
            ResetListBox();
        }

        private void InitializeComponent()
        {
            _listBox = new ListBox();
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
                tableLayout.Controls.Add(_listBox, 3, 3);
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
                    _listBox.Width = 0;
                    Focus();
                    using (Graphics graphics = _listBox.CreateGraphics())
                    {
                        for (int i = 0; i < _listBox.Items.Count; i++)
                        {
                            if (i < 20)
                                _listBox.Height += _listBox.GetItemHeight(i);
                            // it item width is larger than the current one
                            // set it to the new max item width
                            // GetItemRectangle does not work for me
                            // we add a little extra space by using '_'
                            int itemWidth = (int)graphics.MeasureString(((string)_listBox.Items[i]) + "_", _listBox.Font).Width;
                            /*    _listBox.Width = (_listBox.Width < itemWidth) ? itemWidth : this.Width; ;*/
                            _listBox.Width = 234;

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

