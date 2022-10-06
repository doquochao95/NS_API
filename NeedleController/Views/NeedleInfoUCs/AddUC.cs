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
using NeedleController.Presenters.NeedleInfoPresenters;

using System.Globalization;
using Infralution.Localization;
using System.Resources;
using NeedleController.Properties;
using System.IO;

namespace NeedleController.Views.NeedleInfoUCs
{
    [PresenterBinding(typeof(AddPresenter))]
    public partial class AddUC : MvpUserControl, IAddUC
    {
        public AddUC()
        {
            InitializeComponent();
            InitializeTimer();
        }
        public event EventHandler AddUCLoaded;
        public event EventHandler NeedlePointListComboBoxSelectedIndexChanged;
        public event EventHandler OpenFileButtonClicked;
        public event EventHandler FileDirectionTextBoxDoubleClicked;
        public event EventHandler NameTextBoxFocusLeaved;
        public event EventHandler CodeTextBoxFocusLeaved;
        public event EventHandler SizeTextBoxFocusLeaved;
        public event EventHandler PriceTextBoxFocusLeaved;
        public event EventHandler LengthTextBoxFocusLeaved;
        public event EventHandler SaveButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event KeyEventHandler EnterKeyPressed;

        private void AddUC_Load(object sender, EventArgs ev)
        {
            try
            {
                AddUCLoaded(this, EventArgs.Empty);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void NeedlePointListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedlePointListComboBoxSelectedIndexChanged(this, EventArgs.Empty);
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileButtonClicked(this, EventArgs.Empty);
        }
        private void FileDirectionTextBox_DoubleClick(object sender, EventArgs e)
        {
            FileDirectionTextBoxDoubleClicked(this, EventArgs.Empty);
        }
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameTextBoxFocusLeaved(this, EventArgs.Empty);
        }
        private void CodeTextBox_Leave(object sender, EventArgs e)
        {
            CodeTextBoxFocusLeaved(this, EventArgs.Empty);
        }
        private void SizeTextBox_Leave(object sender, EventArgs e)
        {
            SizeTextBoxFocusLeaved(this, EventArgs.Empty);
        }
        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            PriceTextBoxFocusLeaved(this, EventArgs.Empty);
        }
        private void LengthTextBox_Leave(object sender, EventArgs e)
        {
            LengthTextBoxFocusLeaved(this, EventArgs.Empty);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButtonClicked(this, EventArgs.Empty);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButtonClicked(this, EventArgs.Empty);
        }
        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPressed(this, e);
        }
        private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPressed(this, e);
        }
        private void SizeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPressed(this, e);
        }
        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPressed(this, e);
        }
        private void LengthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPressed(this, e);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 100;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (NeedleInfoView.last_selectedTabindex == 1 && NeedleInfoView.adduc_load == false)
            {
                LoadAddUC();
                NeedleInfoView.adduc_load = true;
            }
        }

        public void LoadAddUC()
        {
            NeedlePointListComboBox.Items.Clear();
            NeedlePointListComboBox.Items.AddRange(NeedleInfoView.PointList);
            Reset_Parameters();
            
        }
        public void Check_NeedlePointListComboBoxIndexChanged()
        {
            try
            {
                if (NeedlePointListComboBox.SelectedItem == null)
                {
                    NeedlePointWarningLabel.Text = "*Null data";
                    NeedlePointWarningLabel.ForeColor = Color.Red;
                    NeedleInfoView.selected_needlepoint = null;
                    NeedleInfoView.selected_needlepointbitmap = null;
                    NeedlePointPictureBox.Image = null;
                    return;
                }
                NeedleInfoView.selected_needlepoint = NeedlePointListComboBox.SelectedItem.ToString();
                NeedleInfoView.selected_needlepointbitmap = (Image)Resources.ResourceManager.GetObject(NeedleInfoView.selected_needlepoint);
                NeedlePointPictureBox.Image = NeedleInfoView.selected_needlepointbitmap;
                NeedleInfoView.selected_needlepointbitmap_byte = imageToByteArray(NeedleInfoView.selected_needlepointbitmap);
                NeedlePointWarningLabel.Text = "OK";
                NeedlePointWarningLabel.ForeColor = Color.Green;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public void Open_OpenFileDialog()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        NeedleInfoView.selected_needleimagebitmap = new Bitmap(openFileDialog.FileName);
                        NeedleInfoView.selected_needleimagebitmap_byte = imageToByteArray(NeedleInfoView.selected_needleimagebitmap);
                        NeedleRealityPictureBox.Image = NeedleInfoView.selected_needleimagebitmap;
                        FileDirectionTextBox.Text = openFileDialog.FileName;
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

        public void CheckNameTextBoxData()
        {
            string needle_name = NameTextBox.Text;
            if (needle_name == null || needle_name == "")
            {
                NameWarningLabel.Text = "*Null data";
                NameWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                if (needle_name.Length > 6)
                {
                    NameWarningLabel.Text = "*More than 6 characters";
                    NameWarningLabel.ForeColor = Color.Red;
                }
                else
                {
                    if (IsDigitsOnly(needle_name))
                    {
                        bool status = EF_CONFIG.DataTransform.NeedleBase.Check_AvailableNeedleName(int.Parse(needle_name));
                        if (!status)
                        {
                            NeedleInfoView.selected_needlename = needle_name;
                            NameWarningLabel.Text = "OK";
                            NameWarningLabel.ForeColor = Color.Green;
                        }
                        else
                        {
                            NameWarningLabel.Text = "*Already exited";
                            NameWarningLabel.ForeColor = Color.Red;
                        }

                    }
                    else
                    {
                        NameWarningLabel.Text = "*Contains not allowance character";
                        NameWarningLabel.ForeColor = Color.Red;
                    }
                }
            }
        }
        public void CheckCodeTextBoxData()
        {
            string needle_code = CodeTextBox.Text;
            if (needle_code == null || needle_code == "")
            {
                CodeWarningLabel.Text = "*Null data";
                CodeWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                NeedleInfoView.selected_needlecode = needle_code;
                CodeWarningLabel.Text = "OK";
                CodeWarningLabel.ForeColor = Color.Green;
            }
        }
        public void CheckSizeTextBoxData()
        {
            string needle_size = SizeTextBox.Text;
            if (needle_size == null || needle_size == "")
            {
                SizeWarningLabel.Text = "*Null data";
                SizeWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                NeedleInfoView.selected_needlesize = needle_size;
                SizeWarningLabel.Text = "OK";
                SizeWarningLabel.ForeColor = Color.Green;
            }
        }
        public void CheckPriceTextBoxData()
        {
            NeedleInfoView.selected_needleprice = PriceTextBox.Text;
            if (NeedleInfoView.selected_needleprice == null || NeedleInfoView.selected_needleprice == "")
            {
                PriceWarningLabel.Text = "*Null data";
                PriceWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                decimal d;
                if (decimal.TryParse(NeedleInfoView.selected_needleprice, out d))
                {
                    if (d > 0)
                    {
                        PriceWarningLabel.Text = "OK";
                        PriceWarningLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        PriceWarningLabel.Text = "*Need to be >0";
                        PriceWarningLabel.ForeColor = Color.Red;
                    }
                }
                else
                {
                    PriceWarningLabel.Text = "*Need to be decimal";
                    PriceWarningLabel.ForeColor = Color.Red;
                }

            }
        }
        public void CheckLengthTextBoxData()
        {
            NeedleInfoView.selected_needlelength = LengthTextBox.Text;
            if (NeedleInfoView.selected_needlelength == null || NeedleInfoView.selected_needlelength == "")
            {
                LengthWarningLabel.Text = "*Null data";
                LengthWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                decimal d;
                if (decimal.TryParse(NeedleInfoView.selected_needlelength, out d))
                {
                    if (d > 0)
                    {
                        LengthWarningLabel.Text = "OK";
                        LengthWarningLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        LengthWarningLabel.Text = "*Need to be >0";
                        LengthWarningLabel.ForeColor = Color.Red;
                    }
                }
                else
                {
                    LengthWarningLabel.Text = "*Need to be decimal";
                    LengthWarningLabel.ForeColor = Color.Red;
                }

            }
        }
        public void CheckWareHouseCodeTextBoxData()
        {
            string selected_warehousecode = WareHouseCodeTextBox.Text;
            if (selected_warehousecode == null || selected_warehousecode == "")
            {
                WarehouseCodeWarningLabel.Text = "*Null data";
                WarehouseCodeWarningLabel.ForeColor = Color.Red;
            }
            else
            {
                if (IsDigitsOnly(selected_warehousecode))
                {
                    bool status = EF_CONFIG.DataTransform.NeedleBase.Check_AvailableNeedleWarehousecode(int.Parse(selected_warehousecode));
                    if (!status)
                    {
                        NeedleInfoView.selected_needlename = selected_warehousecode;
                        NameWarningLabel.Text = "OK";
                        NameWarningLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        NameWarningLabel.Text = "*Already exited";
                        NameWarningLabel.ForeColor = Color.Red;
                    }

                }
                else
                {
                    NameWarningLabel.Text = "*Contains not allowance character";
                    NameWarningLabel.ForeColor = Color.Red;
                }
            }
        }
        public void Save_NewNeedleInfo()
        {
            try
            {
                int count = 0;
                CheckNameTextBoxData();
                CheckCodeTextBoxData();
                CheckSizeTextBoxData();
                CheckPriceTextBoxData();
                CheckLengthTextBoxData();
                Check_NeedlePointListComboBoxIndexChanged();
                CheckWareHouseCodeTextBoxData();

                TextBox[] textBoxes = new TextBox[] {NameTextBox,
                                                CodeTextBox,
                                                SizeTextBox,
                                                PriceTextBox,
                                                LengthTextBox,
                                                WareHouseCodeTextBox};
                Label[] label = new Label[] {NameWarningLabel,
                                        CodeWarningLabel,
                                        SizeWarningLabel,
                                        PriceWarningLabel,
                                        LengthWarningLabel,
                                        WarehouseCodeWarningLabel,
                                        NeedlePointWarningLabel};
                for (int i = 0; i < label.Length; i++)
                {
                    if (label[i].ForeColor == Color.Red)
                    {
                        if (i == 6)
                        {
                            MessageBox.Show(this, "Invalid data at " + NeedlePointListComboBox.Name + ": value NULL ", "Error: " + label[i].Text, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(this, "Invalid data at " + textBoxes[i].Name + ": value " + textBoxes[i].Text, "Error: " + label[i].Text, MessageBoxButtons.OK);

                        }
                    }
                    else
                    {
                        count++;
                        continue;
                    }
                }
                if (count == 7)
                {
                    NS_Needles nS_Needles = new NS_Needles()
                    {
                        NeedleName = int.Parse(NeedleInfoView.selected_needlename),
                        NeedleCode = NeedleInfoView.selected_needlecode,
                        NeedleSize = NeedleInfoView.selected_needlesize,
                        NeedlePoint = NeedleInfoView.selected_needlepoint,
                        NeedlePrice = decimal.Parse(NeedleInfoView.selected_needleprice),
                        NeedleLength = decimal.Parse(NeedleInfoView.selected_needlelength),
                        PointTypeImage = NeedleInfoView.selected_needlepointbitmap_byte,
                        RealityImage = NeedleInfoView.selected_needleimagebitmap_byte,
                        NeedleWarehouseCode = int.Parse(NeedleInfoView.selected_warehousecode)
                    };
                    switch (MessageBox.Show(this, "Do you want to save ?", "Attention :", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            bool status = EF_CONFIG.DataTransform.NeedleBase.Add_NewNeedle(nS_Needles);
                            if (!status)
                            {
                                return;
                            }
                            else
                            {
                                MessageBox.Show(this, "Saved successfuly", "Attention", MessageBoxButtons.OK);
                                LoadAddUC();
                            }
                            break;
                        case DialogResult.No:
                            break;
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
        public void Cancel_NewNeedleInfo()
        {
            try
            {
                switch (MessageBox.Show(this, "Do you want to cancel recent settings ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        NameTextBox.Text = null;
                        CodeTextBox.Text = null;
                        PriceTextBox.Text = null;
                        SizeTextBox.Text = null;
                        LengthTextBox.Text = null;
                        WareHouseCodeTextBox.Text = null;
                        NeedlePointListComboBox.SelectedItem = null;
                        FileDirectionTextBox.Text = null;
                        break;
                    case DialogResult.No:
                        break;
                }
                CheckNameTextBoxData();
                CheckCodeTextBoxData();
                CheckSizeTextBoxData();
                CheckPriceTextBoxData();
                CheckLengthTextBoxData();
                CheckWareHouseCodeTextBoxData();
                Check_NeedlePointListComboBoxIndexChanged();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
        public void Keyboard_EnterKeyPress(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        private bool IsDigitsOnly(string str)
        {
            return str.All(char.IsDigit);
        }
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            else
                return null;
        }
        private void Reset_Parameters()
        {
            try
            {
                NeedlePointListComboBox.Text = null;
                NeedlePointListComboBox.SelectedItem = null;
                NameTextBox.Text = null;
                CodeTextBox.Text = null;
                PriceTextBox.Text = null;
                SizeTextBox.Text = null;
                LengthTextBox.Text = null;
                WareHouseCodeTextBox.Text = null;
                FileDirectionTextBox.Text = null;
                NeedlePointPictureBox.Image = null;
                NeedleRealityPictureBox.Image = null;
                CheckNameTextBoxData();
                CheckCodeTextBoxData();
                CheckSizeTextBoxData();
                CheckPriceTextBoxData();
                CheckLengthTextBoxData();
                CheckWareHouseCodeTextBoxData();
                Check_NeedlePointListComboBoxIndexChanged();
                NeedleInfoView.selected_needleimagebitmap = null;
                NeedleInfoView.selected_needleimagebitmap_byte = imageToByteArray(NeedleInfoView.selected_needleimagebitmap);
                NeedleRealityPictureBox.Image = NeedleInfoView.selected_needleimagebitmap;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message, MainView.device_id);
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
    }
}
