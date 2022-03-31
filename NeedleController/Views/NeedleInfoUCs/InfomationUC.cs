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
using System.IO;
using System.Collections.ObjectModel;

namespace NeedleController.Views.NeedleInfoUCs
{
    [PresenterBinding(typeof(InfomationPresenter))]
    public partial class InfomationUC : MvpUserControl, IInfomationUC
    {
      /*  private static string[] filtby_list = new string[] {"NeedleName", "NeedleSize", "NeedlePoint"};*/
        public static string selected_filtbyitem { get; set; }
        public static List<NS_Needles> needle_list { get; set; }
        public InfomationUC()
        {
            InitializeComponent();
            InitializeTimer();
        }
        public event EventHandler InfomationUCLoaded;
        public event EventHandler NeedleComboBoxSelectedIndexChanged;
        public event EventHandler SearchButtonClicked;


        private void InfomationUC_Load(object sender, EventArgs e)
        {
            try
            {
                InfomationUCLoaded(this, EventArgs.Empty);

            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.ToString());
            }
        }
        private void NeedleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedleComboBoxSelectedIndexChanged(this, EventArgs.Empty);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonClicked(this, EventArgs.Empty);

        }

        private void InitializeTimer()
        {
            Timer1.Interval = 100;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (NeedleInfoView.last_selectedTabindex == 0 && NeedleInfoView.infouc_load== false)
            {
                Load_InformationUC();
                NeedleNameTextBox.Text = null;
                NeedleCodeTextBox.Text = null;
                NeedleSizeTextBox.Text = null;
                NeedlePointTextBox.Text = null;
                NeedlePriceTextBox.Text = null;
                NeedleLengthTextBox.Text = null;
                PointImagePictureBox.Image = null;
                NeedleImagePictureBox.Image = null;
                NeedleInfoView.infouc_load = true;
            }
        }
        public void Load_InformationUC()
        {
            NeedleComboBox.Items.Clear();
            needle_list = EF_CONFIG.DataTransform.NeedleBase.Get_AllNeedle();
            if (needle_list == null)
            {
                return;
            }
            foreach (var needle in needle_list)
            {
                NeedleComboBox.Items.Add(needle);
            }
            NeedleComboBox.SelectedItem = null;
            NeedleComboBox.Text = null;
            NeedleComboBox.DisplayMember = "NeedleName";
            NeedleComboBox.ValueMember = "NeedleID";
            
        }
        public void Change_NeedleComboBoxSelectedIndex()
        {
            if (NeedleComboBox.SelectedItem != null)
            {
                int needlename = int.Parse(NeedleComboBox.Text);
                var item = needle_list.Where(i => i.NeedleName == needlename).FirstOrDefault();
                NeedleNameTextBox.Text = item.NeedleName.ToString();
                NeedleCodeTextBox.Text = item.NeedleCode;
                NeedleSizeTextBox.Text = item.NeedleSize;
                NeedlePointTextBox.Text = item.NeedlePoint;
                NeedlePriceTextBox.Text = item.NeedlePrice.ToString();
                NeedleLengthTextBox.Text = item.NeedleLength.ToString();
                PointImagePictureBox.Image = byteArrayToImage(item.PointTypeImage);
                NeedleImagePictureBox.Image = byteArrayToImage(item.RealityImage);
            }  
        }
        public void SearchNeedle()
        {
            string search_name = SearchTextBox.Text;
            if (search_name == null || search_name == "")
            {
                MessageBox.Show(this, "Please type needle name", "Attention :", MessageBoxButtons.OK);        
            }
            else
            {
                if (search_name.Length > 6)
                {
                    MessageBox.Show(this, "More than 6 characters", "Attention :", MessageBoxButtons.OK);
                }
                else
                {
                    if (IsDigitsOnly(search_name))
                    {
                        bool status = EF_CONFIG.DataTransform.NeedleBase.Check_AvailableNeedleName(int.Parse(search_name));
                        if (!status)
                        {
                            MessageBox.Show(this, "Needle is not available. Please try another name", "Attention :", MessageBoxButtons.OK);
                        }
                        else
                        {
                            var item = needle_list.Where(i => i.NeedleName == int.Parse(search_name)).FirstOrDefault();
                            NeedleNameTextBox.Text = item.NeedleName.ToString();
                            NeedleCodeTextBox.Text = item.NeedleCode;
                            NeedleSizeTextBox.Text = item.NeedleSize;
                            NeedlePointTextBox.Text = item.NeedlePoint;
                            NeedlePriceTextBox.Text = item.NeedlePrice.ToString();
                            NeedleLengthTextBox.Text = item.NeedleLength.ToString();
                            PointImagePictureBox.Image = byteArrayToImage(item.PointTypeImage);
                            NeedleImagePictureBox.Image = byteArrayToImage(item.RealityImage);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Contains not allowance character", "Attention :", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            if(byteArrayIn != null)
            {
                System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return null;
        }
        private bool IsDigitsOnly(string str)
        {
            return str.All(char.IsDigit);
        }

    }
}
