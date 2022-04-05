namespace NeedleController.Views
{
    partial class SplashScreenView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenView));
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoadingStatusMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(-3, 104);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(356, 10);
            this.metroProgressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // LoadingStatusMetroLabel
            // 
            this.LoadingStatusMetroLabel.AutoSize = true;
            this.LoadingStatusMetroLabel.Location = new System.Drawing.Point(9, 122);
            this.LoadingStatusMetroLabel.Name = "LoadingStatusMetroLabel";
            this.LoadingStatusMetroLabel.Size = new System.Drawing.Size(65, 19);
            this.LoadingStatusMetroLabel.TabIndex = 4;
            this.LoadingStatusMetroLabel.Text = "Loading...";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(34, 20);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(279, 69);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SplashScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.LoadingStatusMetroLabel);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "SplashScreenView";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel LoadingStatusMetroLabel;
    }
}