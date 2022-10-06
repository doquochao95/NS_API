
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
            this.components = new System.ComponentModel.Container();
            this.SettingMetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.AxisSettingMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ConnectionSettingMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axisSettingUC1 = new NeedleController.Views.DeviceSettingUCs.AxisSettingUC();
            this.connectionSettingUC1 = new NeedleController.Views.DeviceSettingUCs.ConnectionSettingUC();
            this.SettingMetroTabControl.SuspendLayout();
            this.AxisSettingMetroTabPage.SuspendLayout();
            this.ConnectionSettingMetroTabPage.SuspendLayout();
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
            this.AxisSettingMetroTabPage.Controls.Add(this.axisSettingUC1);
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
            this.ConnectionSettingMetroTabPage.Controls.Add(this.connectionSettingUC1);
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
            // axisSettingUC1
            // 
            this.axisSettingUC1._accel_w = 0;
            this.axisSettingUC1._accel_x = 0;
            this.axisSettingUC1._accel_y = 0;
            this.axisSettingUC1._accel_z = 0;
            this.axisSettingUC1._offset_w = 0;
            this.axisSettingUC1._offset_x = 0;
            this.axisSettingUC1._offset_y = 0;
            this.axisSettingUC1._offset_z = 0;
            this.axisSettingUC1._plus_w = 0;
            this.axisSettingUC1._plus_x = 0;
            this.axisSettingUC1._plus_y = 0;
            this.axisSettingUC1._plus_z = 0;
            this.axisSettingUC1._speed_w = 0;
            this.axisSettingUC1._speed_x = 0;
            this.axisSettingUC1._speed_y = 0;
            this.axisSettingUC1._speed_z = 0;
            this.axisSettingUC1._Xpos = 0;
            this.axisSettingUC1._Ypos = 0;
            this.axisSettingUC1._Zpos = 0;
            this.axisSettingUC1.Accel_w = 0;
            this.axisSettingUC1.Accel_x = 0;
            this.axisSettingUC1.Accel_y = 0;
            this.axisSettingUC1.Accel_z = 0;
            this.axisSettingUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisSettingUC1.Location = new System.Drawing.Point(0, 0);
            this.axisSettingUC1.MinimumSize = new System.Drawing.Size(832, 485);
            this.axisSettingUC1.Name = "axisSettingUC1";
            this.axisSettingUC1.Offset_w = 0;
            this.axisSettingUC1.Offset_x = 0;
            this.axisSettingUC1.Offset_y = 0;
            this.axisSettingUC1.Offset_z = 0;
            this.axisSettingUC1.Padding = new System.Windows.Forms.Padding(10);
            this.axisSettingUC1.Plus_w = 0;
            this.axisSettingUC1.Plus_x = 0;
            this.axisSettingUC1.Plus_y = 0;
            this.axisSettingUC1.Plus_z = 0;
            this.axisSettingUC1.Size = new System.Drawing.Size(976, 519);
            this.axisSettingUC1.Speed_w = 0;
            this.axisSettingUC1.Speed_x = 0;
            this.axisSettingUC1.Speed_y = 0;
            this.axisSettingUC1.Speed_z = 0;
            this.axisSettingUC1.TabIndex = 2;
            this.axisSettingUC1.Xpos = 0;
            this.axisSettingUC1.Ypos = 0;
            this.axisSettingUC1.Zpos = 0;
            // 
            // connectionSettingUC1
            // 
            this.connectionSettingUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionSettingUC1.Location = new System.Drawing.Point(0, 0);
            this.connectionSettingUC1.Name = "connectionSettingUC1";
            this.connectionSettingUC1.Size = new System.Drawing.Size(976, 519);
            this.connectionSettingUC1.TabIndex = 2;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceSettingView_FormClosed);
            this.Load += new System.EventHandler(this.DeviceSettingView_Load);
            this.SettingMetroTabControl.ResumeLayout(false);
            this.AxisSettingMetroTabPage.ResumeLayout(false);
            this.ConnectionSettingMetroTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl SettingMetroTabControl;
        private MetroFramework.Controls.MetroTabPage AxisSettingMetroTabPage;
        private MetroFramework.Controls.MetroTabPage ConnectionSettingMetroTabPage;
        private DeviceSettingUCs.AxisSettingUC axisSettingUC1;
        private DeviceSettingUCs.ConnectionSettingUC connectionSettingUC1;
        private System.Windows.Forms.Timer timer1;
    }
}