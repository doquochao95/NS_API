using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedleController.Views
{
    public partial class SplashScreenView : MetroFramework.Forms.MetroForm
    {
        public static string loading_status { get; set; }
        public static bool  closeme { get; set; }

        public SplashScreenView()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadingStatusMetroLabel.Text = loading_status;
            if (closeme)
            {
                CloseMe();
            }
        }
        public void CloseMe()
        {
            BeginInvoke((Action)(() => { Close(); }));
        }
    }
}
