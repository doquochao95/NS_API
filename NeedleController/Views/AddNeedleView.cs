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
using System.Windows.Forms;


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
    public partial class AddNeedleView : MvpForm, IAddNeedleView
    {
        public static ObservableCollection<NeedlePickingFormModel> _NeedleQtyList { get; set; }
        public static ObservableCollection<NS_Stocks> _NewStock { get; set; }
        public static List<NS_Stocks> Current_Stock { get; set; }
        public static bool save_flag = false;

        public AddNeedleView()
        {
            InitializeComponent();
        }
        public event EventHandler AddNeedleViewLoaded;
        public event EventHandler AddNeedleViewExited;
        public event FormClosingEventHandler AddNeedleViewLeaving;


        private void AddNeedleView_Load(object sender, EventArgs e)
        {
            AddNeedleViewLoaded(this, EventArgs.Empty);
        }
        private void AddNeedleView_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddNeedleViewExited(this, EventArgs.Empty);
        }
        private void AddNeedleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddNeedleViewLeaving(this, e);
        }
        public void AddNeedleViewLoad()
        {
            this.Text = "User: " + MainView.user_cardnumber + " " + MainView.user_name;
            MainView.addneedleviewloaded_status = true;
            _NeedleQtyList = new ObservableCollection<NeedlePickingFormModel>();
            Current_Stock = StockBase.Get_AllNeedleInStockWithDeviceID(MainView.device_id);
            _NeedleQtyList.Clear();
            foreach (var item in Current_Stock)
            {
                NeedlePickingFormModel needlePickingFormModel = new NeedlePickingFormModel
                {
                    NeedleID = item.NeedleID,
                    NeedleName = NeedleBase.Get_Needles(item.NeedleID).NeedleName,
                    StockId = item.StockID,
                    StockName = item.StockName,
                    CurrentQuantity = item.CurrentQuantity
                };
                _NeedleQtyList.Add(needlePickingFormModel);
            }
            foreach (var needle in _NeedleQtyList)
            {
                if (needle.StockName == "A1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    A1ComboBox.DataSource = needlelist;
                    A1ComboBox.DisplayMember = "NeedleName";
                    A1ComboBox.ValueMember = "NeedleID";
                    A1ComboBox.SelectedValue = needle.NeedleID;
                    A1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "B1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    B1ComboBox.DataSource = needlelist;
                    B1ComboBox.DisplayMember = "NeedleName";
                    B1ComboBox.ValueMember = "NeedleID";
                    B1ComboBox.SelectedValue = needle.NeedleID;
                    B1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "C1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    C1ComboBox.DataSource = needlelist;
                    C1ComboBox.DisplayMember = "NeedleName";
                    C1ComboBox.ValueMember = "NeedleID";
                    C1ComboBox.SelectedValue = needle.NeedleID;
                    C1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "D1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    D1ComboBox.DataSource = needlelist;
                    D1ComboBox.DisplayMember = "NeedleName";
                    D1ComboBox.ValueMember = "NeedleID";
                    D1ComboBox.SelectedValue = needle.NeedleID;
                    D1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "E1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    E1ComboBox.DataSource = needlelist;
                    E1ComboBox.DisplayMember = "NeedleName";
                    E1ComboBox.ValueMember = "NeedleID";
                    E1ComboBox.SelectedValue = needle.NeedleID;
                    E1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "F1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    F1ComboBox.DataSource = needlelist;
                    F1ComboBox.DisplayMember = "NeedleName";
                    F1ComboBox.ValueMember = "NeedleID";
                    F1ComboBox.SelectedValue = needle.NeedleID;
                    F1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "G1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    G1ComboBox.DataSource = needlelist;
                    G1ComboBox.DisplayMember = "NeedleName";
                    G1ComboBox.ValueMember = "NeedleID";
                    G1ComboBox.SelectedValue = needle.NeedleID;
                    G1NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "H1")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    H1ComboBox.DataSource = needlelist;
                    H1ComboBox.DisplayMember = "NeedleName";
                    H1ComboBox.ValueMember = "NeedleID";
                    H1ComboBox.SelectedValue = needle.NeedleID;
                    H1NumericUpDown.Value = needle.CurrentQuantity;
                }
                //////////
                else if (needle.StockName == "A2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    A2ComboBox.DataSource = needlelist;
                    A2ComboBox.DisplayMember = "NeedleName";
                    A2ComboBox.ValueMember = "NeedleID";
                    A2ComboBox.SelectedValue = needle.NeedleID;
                    A2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "B2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    B2ComboBox.DataSource = needlelist;
                    B2ComboBox.DisplayMember = "NeedleName";
                    B2ComboBox.ValueMember = "NeedleID";
                    B2ComboBox.SelectedValue = needle.NeedleID;
                    B2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "C2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    C2ComboBox.DataSource = needlelist;
                    C2ComboBox.DisplayMember = "NeedleName";
                    C2ComboBox.ValueMember = "NeedleID";
                    C2ComboBox.SelectedValue = needle.NeedleID;
                    C2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "D2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    D2ComboBox.DataSource = needlelist;
                    D2ComboBox.DisplayMember = "NeedleName";
                    D2ComboBox.ValueMember = "NeedleID";
                    D2ComboBox.SelectedValue = needle.NeedleID;
                    D2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "E2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    E2ComboBox.DataSource = needlelist;
                    E2ComboBox.DisplayMember = "NeedleName";
                    E2ComboBox.ValueMember = "NeedleID";
                    E2ComboBox.SelectedValue = needle.NeedleID;
                    E2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "F2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    F2ComboBox.DataSource = needlelist;
                    F2ComboBox.DisplayMember = "NeedleName";
                    F2ComboBox.ValueMember = "NeedleID";
                    F2ComboBox.SelectedValue = needle.NeedleID;
                    F2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "G2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    G2ComboBox.DataSource = needlelist;
                    G2ComboBox.DisplayMember = "NeedleName";
                    G2ComboBox.ValueMember = "NeedleID";
                    G2ComboBox.SelectedValue = needle.NeedleID;
                    G2NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "H2")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    H2ComboBox.DataSource = needlelist;
                    H2ComboBox.DisplayMember = "NeedleName";
                    H2ComboBox.ValueMember = "NeedleID";
                    H2ComboBox.SelectedValue = needle.NeedleID;
                    H2NumericUpDown.Value = needle.CurrentQuantity;
                }
                //////////
                else if (needle.StockName == "A3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    A3ComboBox.DataSource = needlelist;
                    A3ComboBox.DisplayMember = "NeedleName";
                    A3ComboBox.ValueMember = "NeedleID";
                    A3ComboBox.SelectedValue = needle.NeedleID;
                    A3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "B3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    B3ComboBox.DataSource = needlelist;
                    B3ComboBox.DisplayMember = "NeedleName";
                    B3ComboBox.ValueMember = "NeedleID";
                    B3ComboBox.SelectedValue = needle.NeedleID;
                    B3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "C3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    C3ComboBox.DataSource = needlelist;
                    C3ComboBox.DisplayMember = "NeedleName";
                    C3ComboBox.ValueMember = "NeedleID";
                    C3ComboBox.SelectedValue = needle.NeedleID;
                    C3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "D3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    D3ComboBox.DataSource = needlelist;
                    D3ComboBox.DisplayMember = "NeedleName";
                    D3ComboBox.ValueMember = "NeedleID";
                    D3ComboBox.SelectedValue = needle.NeedleID;
                    D3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "E3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    E3ComboBox.DataSource = needlelist;
                    E3ComboBox.DisplayMember = "NeedleName";
                    E3ComboBox.ValueMember = "NeedleID";
                    E3ComboBox.SelectedValue = needle.NeedleID;
                    E3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "F3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    F3ComboBox.DataSource = needlelist;
                    F3ComboBox.DisplayMember = "NeedleName";
                    F3ComboBox.ValueMember = "NeedleID";
                    F3ComboBox.SelectedValue = needle.NeedleID;
                    F3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "G3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    G3ComboBox.DataSource = needlelist;
                    G3ComboBox.DisplayMember = "NeedleName";
                    G3ComboBox.ValueMember = "NeedleID";
                    G3ComboBox.SelectedValue = needle.NeedleID;
                    G3NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "H3")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    H3ComboBox.DataSource = needlelist;
                    H3ComboBox.DisplayMember = "NeedleName";
                    H3ComboBox.ValueMember = "NeedleID";
                    H3ComboBox.SelectedValue = needle.NeedleID;
                    H3NumericUpDown.Value = needle.CurrentQuantity;
                }
                //////////
                else if (needle.StockName == "A4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    A4ComboBox.DataSource = needlelist;
                    A4ComboBox.DisplayMember = "NeedleName";
                    A4ComboBox.ValueMember = "NeedleID";
                    A4ComboBox.SelectedValue = needle.NeedleID;
                    A4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "B4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    B4ComboBox.DataSource = needlelist;
                    B4ComboBox.DisplayMember = "NeedleName";
                    B4ComboBox.ValueMember = "NeedleID";
                    B4ComboBox.SelectedValue = needle.NeedleID;
                    B4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "C4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    C4ComboBox.DataSource = needlelist;
                    C4ComboBox.DisplayMember = "NeedleName";
                    C4ComboBox.ValueMember = "NeedleID";
                    C4ComboBox.SelectedValue = needle.NeedleID;
                    C4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "D4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    D4ComboBox.DataSource = needlelist;
                    D4ComboBox.DisplayMember = "NeedleName";
                    D4ComboBox.ValueMember = "NeedleID";
                    D4ComboBox.SelectedValue = needle.NeedleID;
                    D4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "E4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    E4ComboBox.DataSource = needlelist;
                    E4ComboBox.DisplayMember = "NeedleName";
                    E4ComboBox.ValueMember = "NeedleID";
                    E4ComboBox.SelectedValue = needle.NeedleID;
                    E4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "F4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    F4ComboBox.DataSource = needlelist;
                    F4ComboBox.DisplayMember = "NeedleName";
                    F4ComboBox.ValueMember = "NeedleID";
                    F4ComboBox.SelectedValue = needle.NeedleID;
                    F4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "G4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    G4ComboBox.DataSource = needlelist;
                    G4ComboBox.DisplayMember = "NeedleName";
                    G4ComboBox.ValueMember = "NeedleID";
                    G4ComboBox.SelectedValue = needle.NeedleID;
                    G4NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "H4")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    H4ComboBox.DataSource = needlelist;
                    H4ComboBox.DisplayMember = "NeedleName";
                    H4ComboBox.ValueMember = "NeedleID";
                    H4ComboBox.SelectedValue = needle.NeedleID;
                    H4NumericUpDown.Value = needle.CurrentQuantity;
                }
                //////////
                else if (needle.StockName == "A5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    A5ComboBox.DataSource = needlelist;
                    A5ComboBox.DisplayMember = "NeedleName";
                    A5ComboBox.ValueMember = "NeedleID";
                    A5ComboBox.SelectedValue = needle.NeedleID;
                    A5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "B5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    B5ComboBox.DataSource = needlelist;
                    B5ComboBox.DisplayMember = "NeedleName";
                    B5ComboBox.ValueMember = "NeedleID";
                    B5ComboBox.SelectedValue = needle.NeedleID;
                    B5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "C5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    C5ComboBox.DataSource = needlelist;
                    C5ComboBox.DisplayMember = "NeedleName";
                    C5ComboBox.ValueMember = "NeedleID";
                    C5ComboBox.SelectedValue = needle.NeedleID;
                    C5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "D5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    D5ComboBox.DataSource = needlelist;
                    D5ComboBox.DisplayMember = "NeedleName";
                    D5ComboBox.ValueMember = "NeedleID";
                    D5ComboBox.SelectedValue = needle.NeedleID;
                    D5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "E5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    E5ComboBox.DataSource = needlelist;
                    E5ComboBox.DisplayMember = "NeedleName";
                    E5ComboBox.ValueMember = "NeedleID";
                    E5ComboBox.SelectedValue = needle.NeedleID;
                    E5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "F5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    F5ComboBox.DataSource = needlelist;
                    F5ComboBox.DisplayMember = "NeedleName";
                    F5ComboBox.ValueMember = "NeedleID";
                    F5ComboBox.SelectedValue = needle.NeedleID;
                    F5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "G5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    G5ComboBox.DataSource = needlelist;
                    G5ComboBox.DisplayMember = "NeedleName";
                    G5ComboBox.ValueMember = "NeedleID";
                    G5ComboBox.SelectedValue = needle.NeedleID;
                    G5NumericUpDown.Value = needle.CurrentQuantity;
                }
                else if (needle.StockName == "H5")
                {
                    var needlelist = NeedleBase.Get_AllNeedle();
                    H5ComboBox.DataSource = needlelist;
                    H5ComboBox.DisplayMember = "NeedleName";
                    H5ComboBox.ValueMember = "NeedleID";
                    H5ComboBox.SelectedValue = needle.NeedleID;
                    H5NumericUpDown.Value = needle.CurrentQuantity;
                }
            }

        }
        public void AddNeedleViewExit()
        {
            MainView.addneedleviewloaded_status = false;
        }
        public void AddNeedleViewLeave(FormClosingEventArgs e)
        {
            _NewStock = new ObservableCollection<NS_Stocks>();
            int id = 0;
            Label[] StockNameLabelArray = new Label[] {
                    A1Label, A2Label, A3Label, A4Label, A5Label,
                    B1Label, B2Label, B3Label, B4Label, B5Label,
                    C1Label, C2Label, C3Label, C4Label, C5Label,
                    D1Label, D2Label, D3Label, D4Label, D5Label,
                    E1Label, E2Label, E3Label, E4Label, E5Label,
                    F1Label, F2Label, F3Label, F4Label, F5Label,
                    G1Label, G2Label, G3Label, G4Label, G5Label,
                    H1Label, H2Label, H3Label, H4Label, H5Label };
            ComboBox[] NeedleNameComboboxArray = new ComboBox[] {
                    A1ComboBox, A2ComboBox, A3ComboBox, A4ComboBox, A5ComboBox,
                    B1ComboBox, B2ComboBox, B3ComboBox, B4ComboBox, B5ComboBox,
                    C1ComboBox, C2ComboBox, C3ComboBox, C4ComboBox, C5ComboBox,
                    D1ComboBox, D2ComboBox, D3ComboBox, D4ComboBox, D5ComboBox,
                    E1ComboBox, E2ComboBox, E3ComboBox, E4ComboBox, E5ComboBox,
                    F1ComboBox, F2ComboBox, F3ComboBox, F4ComboBox, F5ComboBox,
                    G1ComboBox, G2ComboBox, G3ComboBox, G4ComboBox, G5ComboBox,
                    H1ComboBox, H2ComboBox, H3ComboBox, H4ComboBox, H5ComboBox };
            NumericUpDown[] QuantityNumericUpDownArray = new NumericUpDown[] {
                    A1NumericUpDown, A2NumericUpDown, A3NumericUpDown, A4NumericUpDown, A5NumericUpDown,
                    B1NumericUpDown, B2NumericUpDown, B3NumericUpDown, B4NumericUpDown, B5NumericUpDown,
                    C1NumericUpDown, C2NumericUpDown, C3NumericUpDown, C4NumericUpDown, C5NumericUpDown,
                    D1NumericUpDown, D2NumericUpDown, D3NumericUpDown, D4NumericUpDown, D5NumericUpDown,
                    E1NumericUpDown, E2NumericUpDown, E3NumericUpDown, E4NumericUpDown, E5NumericUpDown,
                    F1NumericUpDown, F2NumericUpDown, F3NumericUpDown, F4NumericUpDown, F5NumericUpDown,
                    G1NumericUpDown, G2NumericUpDown, G3NumericUpDown, G4NumericUpDown, G5NumericUpDown,
                    H1NumericUpDown, H2NumericUpDown, H3NumericUpDown, H4NumericUpDown, H5NumericUpDown };
            int ParameterCount = StockNameLabelArray.Length;
            switch (MessageBox.Show(this, "Yes: Save and exit\r\nNo: Exit witout saving\r\nCancel: Close this form", "Do you want to save ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    for (int i = 0; i < ParameterCount; ++i)
                    {
                        id++;
                        NS_Stocks new_NS_Stock = new NS_Stocks
                        {
                            StockID = id,
                            StockName = StockNameLabelArray[i].Text,
                            DeviceID = MainView.device_id,
                            NeedleID = (int)NeedleNameComboboxArray[i].SelectedValue,
                            CurrentQuantity = Decimal.ToInt32(QuantityNumericUpDownArray[i].Value)
                        };
                        _NewStock.Add(new_NS_Stock);
                    }
                    bool status = StockBase.Update_StockQuantity(_NewStock);
                    if (status)
                    {
                        List<NS_Imports> nS_Imports = new List<NS_Imports>();
                        List<NS_Export> nS_Exports = new List<NS_Export>();

                        for (int i = 0; i < Current_Stock.Count; ++i)
                        {
                            if (Current_Stock[i].StockID == _NewStock[i].StockID)
                            {
                                if (Current_Stock[i].CurrentQuantity != _NewStock[i].CurrentQuantity || Current_Stock[i].NeedleID != _NewStock[i].NeedleID)
                                {
                                    if (_NewStock[i].CurrentQuantity < Current_Stock[i].CurrentQuantity)
                                    {
                                        NS_Export export = new NS_Export
                                        {
                                            DeviceID = MainView.device_id,
                                            BuildingID = MainView.building_id,
                                            NeedleID = _NewStock[i].NeedleID,
                                            ExportTime = DateTime.Now,
                                            ExprtTimeString = DateTime.Now.ToString("HH:mm, dd/MM/yyyy"),
                                            Quantity = Current_Stock[i].CurrentQuantity - _NewStock[i].CurrentQuantity,
                                            StaffID = MainView.user_id,
                                            StockID = _NewStock[i].StockID
                                        };
                                        nS_Exports.Add(export);
                                    }
                                    else
                                    {
                                        NS_Imports import = new NS_Imports
                                        {
                                            DeviceID = MainView.device_id,
                                            BuildingID = MainView.building_id,
                                            NeedleID = _NewStock[i].NeedleID,
                                            ImportTime = DateTime.Now,
                                            ImportTimeStr = DateTime.Now.ToString("HH:mm, dd/MM/yyyy"),
                                            Quantity = _NewStock[i].CurrentQuantity - Current_Stock[i].CurrentQuantity,
                                            StaffID = MainView.user_id,
                                            StockID = _NewStock[i].StockID
                                        };
                                        nS_Imports.Add(import);
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }

                        }
                        bool add_import = EF_CONFIG.DataTransform.ImportBase.Add_NewImport(nS_Imports);
                        bool add_export = EF_CONFIG.DataTransform.ExportBase.Add_NewExport(nS_Exports);
                        if (add_import && add_export)
                        {
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                case DialogResult.No:

                    for (int i = 0; i < ParameterCount; ++i)
                    {
                        id++;
                        NS_Stocks new_NS_Stock = new NS_Stocks
                        {
                            StockID = id,
                            StockName = StockNameLabelArray[i].Text,
                            DeviceID = MainView.device_id,
                            NeedleID = (int)NeedleNameComboboxArray[i].SelectedValue,
                            CurrentQuantity = Decimal.ToInt32(QuantityNumericUpDownArray[i].Value)
                        };
                        _NewStock.Add(new_NS_Stock);
                    }
                    break;
                default:
                    break;
            }
        }



    }
}
