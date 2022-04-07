
namespace NeedleController.Views
{
    partial class DeviceSettingView
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
            this.SettingMetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.AxisSettingMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ConnectionSettingMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.SettingMetroTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingMetroTabControl
            // 
            this.SettingMetroTabControl.Controls.Add(this.AxisSettingMetroTabPage);
            this.SettingMetroTabControl.Controls.Add(this.ConnectionSettingMetroTabPage);
            this.SettingMetroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingMetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.SettingMetroTabControl.Name = "SettingMetroTabControl";
            this.SettingMetroTabControl.SelectedIndex = 0;
            this.SettingMetroTabControl.Size = new System.Drawing.Size(984, 561);
            this.SettingMetroTabControl.TabIndex = 0;
            this.SettingMetroTabControl.UseSelectable = true;
            // 
            // AxisSettingMetroTabPage
            // 
            this.AxisSettingMetroTabPage.HorizontalScrollbarBarColor = true;
            this.AxisSettingMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.AxisSettingMetroTabPage.HorizontalScrollbarSize = 10;
            this.AxisSettingMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.AxisSettingMetroTabPage.Name = "AxisSettingMetroTabPage";
            this.AxisSettingMetroTabPage.Size = new System.Drawing.Size(976, 519);
            this.AxisSettingMetroTabPage.TabIndex = 0;
            this.AxisSettingMetroTabPage.Text = "Axis Setting";
            this.AxisSettingMetroTabPage.VerticalScrollbarBarColor = true;
            this.AxisSettingMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.AxisSettingMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // ConnectionSettingMetroTabPage
            // 
            this.ConnectionSettingMetroTabPage.HorizontalScrollbarBarColor = true;
            this.ConnectionSettingMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ConnectionSettingMetroTabPage.HorizontalScrollbarSize = 10;
            this.ConnectionSettingMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.ConnectionSettingMetroTabPage.Name = "ConnectionSettingMetroTabPage";
            this.ConnectionSettingMetroTabPage.Size = new System.Drawing.Size(976, 519);
            this.ConnectionSettingMetroTabPage.TabIndex = 1;
            this.ConnectionSettingMetroTabPage.Text = "Connection Setting";
            this.ConnectionSettingMetroTabPage.VerticalScrollbarBarColor = true;
            this.ConnectionSettingMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ConnectionSettingMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // DeviceSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.SettingMetroTabControl);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DeviceSettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceSettingView";
            this.SettingMetroTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl SettingMetroTabControl;
        private MetroFramework.Controls.MetroTabPage AxisSettingMetroTabPage;
        private MetroFramework.Controls.MetroTabPage ConnectionSettingMetroTabPage;
    }
}