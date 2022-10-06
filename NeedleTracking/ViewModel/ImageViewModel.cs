using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using NeedleTracking.UserControlUC;
using EF_CONFIG.DataTransform;
using EF_CONFIG;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;
using NeedleTracking.UserControlUC.HistoryUC;
using NeedleTracking.ViewModel.HistoryMenuViewModels;
using System.IO;
using System.Windows.Media.Imaging;

namespace NeedleTracking.ViewModel
{
    public class ImageViewModel : BaseViewModel
    {
        private HistoryDataGridModel _selectedItem;
        public HistoryDataGridModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }
        private BitmapImage _Image;
        public BitmapImage Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                OnPropertyChanged();
            }
        }
        private bool _CloseButtonEnableFlag;
        public bool CloseButtonEnableFlag
        {
            get { return _CloseButtonEnableFlag; }
            set
            {
                _CloseButtonEnableFlag = value;
                OnPropertyChanged();
            }
        }

        public ICommand CloseButtonClick { get; set; }
        public ICommand LoadWindowCommandClick { get; set; }


        public ImageViewModel()
        {
            CloseButtonClick = new RelayCommand<Window>((p) => { return true; }, (p) => { CloseButtonClick_Command(p); });
            LoadWindowCommandClick = new RelayCommand<Window>((p) => { return true; }, (p) => { LoadWindow_Command(p); });

        }
        void CloseButtonClick_Command(Window p)
        {
            p.Close();
        }
        void LoadWindow_Command(Window p)
        {
            HistoryDataUC historyDataUC = new HistoryDataUC();
            var historyDataVM = historyDataUC.DataContext as HistoryDataViewModel;
            SelectedItem = historyDataVM.SelectedDataGridValue;
            Image = LoadImage(SelectedItem.NS_RecycledBox.RecycleNeedleImage);
            CloseButtonEnableFlag = true;
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
