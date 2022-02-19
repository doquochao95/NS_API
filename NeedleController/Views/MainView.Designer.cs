
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
            this.DeviceSettingButton = new System.Windows.Forms.Button();
            this.CameraSettingButton = new System.Windows.Forms.Button();
            this.NeedleInfoButton = new System.Windows.Forms.Button();
            this.GetNeedleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceSettingButton
            // 
            this.DeviceSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeviceSettingButton.FlatAppearance.BorderSize = 5;
            this.DeviceSettingButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceSettingButton.Image = global::NeedleController.Properties.Resources.SETTING_100x100;
            this.DeviceSettingButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeviceSettingButton.Location = new System.Drawing.Point(202, 313);
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
            this.CameraSettingButton.Location = new System.Drawing.Point(413, 313);
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
            this.NeedleInfoButton.Location = new System.Drawing.Point(413, 101);
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
            this.GetNeedleButton.Location = new System.Drawing.Point(202, 101);
            this.GetNeedleButton.Name = "GetNeedleButton";
            this.GetNeedleButton.Padding = new System.Windows.Forms.Padding(5);
            this.GetNeedleButton.Size = new System.Drawing.Size(150, 150);
            this.GetNeedleButton.TabIndex = 0;
            this.GetNeedleButton.Text = "Get Needle";
            this.GetNeedleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GetNeedleButton.UseVisualStyleBackColor = true;
            this.GetNeedleButton.Click += new System.EventHandler(this.GetNeedleButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
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

        }

        #endregion

        private System.Windows.Forms.Button GetNeedleButton;
        private System.Windows.Forms.Button NeedleInfoButton;
        private System.Windows.Forms.Button CameraSettingButton;
        private System.Windows.Forms.Button DeviceSettingButton;
    }
}

