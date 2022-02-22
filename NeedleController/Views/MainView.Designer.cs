
namespace NeedleController.Views
{
    partial class MainView
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
            this.DeviceSettingButton = new System.Windows.Forms.Button();
            this.CameraSettingButton = new System.Windows.Forms.Button();
            this.NeedleInfoButton = new System.Windows.Forms.Button();
            this.GetNeedleButton = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ConnectDeviceButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DeviceSettingButton
            // 
            this.DeviceSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeviceSettingButton.FlatAppearance.BorderSize = 5;
            this.DeviceSettingButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSettingButton.Image = global::NeedleController.Properties.Resources.SETTING_100x100;
            this.DeviceSettingButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeviceSettingButton.Location = new System.Drawing.Point(207, 252);
            this.DeviceSettingButton.Name = "DeviceSettingButton";
            this.DeviceSettingButton.Padding = new System.Windows.Forms.Padding(5);
            this.DeviceSettingButton.Size = new System.Drawing.Size(150, 150);
            this.DeviceSettingButton.TabIndex = 3;
            this.DeviceSettingButton.Text = "Device Setting";
            this.DeviceSettingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeviceSettingButton.UseVisualStyleBackColor = true;
            this.DeviceSettingButton.Click += new System.EventHandler(this.DeviceSettingButton_Click);
            // 
            // CameraSettingButton
            // 
            this.CameraSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CameraSettingButton.FlatAppearance.BorderSize = 5;
            this.CameraSettingButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraSettingButton.Image = global::NeedleController.Properties.Resources.camera_100x100;
            this.CameraSettingButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CameraSettingButton.Location = new System.Drawing.Point(418, 252);
            this.CameraSettingButton.Name = "CameraSettingButton";
            this.CameraSettingButton.Padding = new System.Windows.Forms.Padding(5);
            this.CameraSettingButton.Size = new System.Drawing.Size(150, 150);
            this.CameraSettingButton.TabIndex = 2;
            this.CameraSettingButton.Text = "Camera Setting";
            this.CameraSettingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CameraSettingButton.UseVisualStyleBackColor = true;
            this.CameraSettingButton.Click += new System.EventHandler(this.CameraSettingButton_Click);
            // 
            // NeedleInfoButton
            // 
            this.NeedleInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.NeedleInfoButton.FlatAppearance.BorderSize = 5;
            this.NeedleInfoButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleInfoButton.Image = global::NeedleController.Properties.Resources.Info_100x100_2;
            this.NeedleInfoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NeedleInfoButton.Location = new System.Drawing.Point(418, 49);
            this.NeedleInfoButton.Name = "NeedleInfoButton";
            this.NeedleInfoButton.Padding = new System.Windows.Forms.Padding(5);
            this.NeedleInfoButton.Size = new System.Drawing.Size(150, 150);
            this.NeedleInfoButton.TabIndex = 1;
            this.NeedleInfoButton.Text = "Needle Information";
            this.NeedleInfoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NeedleInfoButton.UseVisualStyleBackColor = true;
            this.NeedleInfoButton.Click += new System.EventHandler(this.NeedleInfoButton_Click);
            // 
            // GetNeedleButton
            // 
            this.GetNeedleButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.GetNeedleButton.FlatAppearance.BorderSize = 5;
            this.GetNeedleButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNeedleButton.Image = global::NeedleController.Properties.Resources.GROZ_B_100x100;
            this.GetNeedleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetNeedleButton.Location = new System.Drawing.Point(207, 49);
            this.GetNeedleButton.Name = "GetNeedleButton";
            this.GetNeedleButton.Padding = new System.Windows.Forms.Padding(5);
            this.GetNeedleButton.Size = new System.Drawing.Size(150, 150);
            this.GetNeedleButton.TabIndex = 0;
            this.GetNeedleButton.Text = "Get Needle";
            this.GetNeedleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GetNeedleButton.UseVisualStyleBackColor = true;
            this.GetNeedleButton.Click += new System.EventHandler(this.GetNeedleButton_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(10, 451);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(112, 15);
            this.ConnectionStatusLabel.TabIndex = 4;
            this.ConnectionStatusLabel.Text = "Connection Status :";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(121, 451);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(82, 15);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Disconnected";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 450);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 95);
            this.listBox1.TabIndex = 6;
            // 
            // ConnectDeviceButton
            // 
            this.ConnectDeviceButton.Location = new System.Drawing.Point(13, 476);
            this.ConnectDeviceButton.Name = "ConnectDeviceButton";
            this.ConnectDeviceButton.Size = new System.Drawing.Size(187, 23);
            this.ConnectDeviceButton.TabIndex = 7;
            this.ConnectDeviceButton.Text = "Connect Device";
            this.ConnectDeviceButton.UseVisualStyleBackColor = true;
            this.ConnectDeviceButton.Click += new System.EventHandler(this.ConnectDeviceButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ConnectDeviceButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.DeviceSettingButton);
            this.Controls.Add(this.CameraSettingButton);
            this.Controls.Add(this.NeedleInfoButton);
            this.Controls.Add(this.GetNeedleButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetNeedleButton;
        private System.Windows.Forms.Button NeedleInfoButton;
        private System.Windows.Forms.Button CameraSettingButton;
        private System.Windows.Forms.Button DeviceSettingButton;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ConnectDeviceButton;
        private System.Windows.Forms.Timer Timer1;
    }
}

