
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.DisconnectedStatusLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ConnectDeviceButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceSettingButton = new System.Windows.Forms.Button();
            this.CameraSettingButton = new System.Windows.Forms.Button();
            this.NeedleInfoButton = new System.Windows.Forms.Button();
            this.GetNeedleButton = new System.Windows.Forms.Button();
            this.ConnectedStatusLabel = new System.Windows.Forms.Label();
            this.CultureManagerMainForm = new Infralution.Localization.CultureManager(this.components);
            this.BuildingNameLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.BuldingTilteLabel = new System.Windows.Forms.Label();
            this.DeviceTilteLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionStatusLabel
            // 
            resources.ApplyResources(this.ConnectionStatusLabel, "ConnectionStatusLabel");
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            // 
            // DisconnectedStatusLabel
            // 
            resources.ApplyResources(this.DisconnectedStatusLabel, "DisconnectedStatusLabel");
            this.DisconnectedStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.DisconnectedStatusLabel.Name = "DisconnectedStatusLabel";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // ConnectDeviceButton
            // 
            resources.ApplyResources(this.ConnectDeviceButton, "ConnectDeviceButton");
            this.ConnectDeviceButton.Name = "ConnectDeviceButton";
            this.ConnectDeviceButton.UseVisualStyleBackColor = true;
            this.ConnectDeviceButton.Click += new System.EventHandler(this.ConnectDeviceButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.LanguageToolStripMenuItem,
            this.HelpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectDeviceToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            // 
            // ConnectDeviceToolStripMenuItem
            // 
            this.ConnectDeviceToolStripMenuItem.Name = "ConnectDeviceToolStripMenuItem";
            resources.ApplyResources(this.ConnectDeviceToolStripMenuItem, "ConnectDeviceToolStripMenuItem");
            this.ConnectDeviceToolStripMenuItem.Click += new System.EventHandler(this.ConnectDeviceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishToolStripMenuItem,
            this.VietnameseToolStripMenuItem,
            this.ChineseToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            resources.ApplyResources(this.LanguageToolStripMenuItem, "LanguageToolStripMenuItem");
            // 
            // EnglishToolStripMenuItem
            // 
            this.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem";
            resources.ApplyResources(this.EnglishToolStripMenuItem, "EnglishToolStripMenuItem");
            this.EnglishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // VietnameseToolStripMenuItem
            // 
            this.VietnameseToolStripMenuItem.Name = "VietnameseToolStripMenuItem";
            resources.ApplyResources(this.VietnameseToolStripMenuItem, "VietnameseToolStripMenuItem");
            this.VietnameseToolStripMenuItem.Click += new System.EventHandler(this.VietnameseToolStripMenuItem_Click);
            // 
            // ChineseToolStripMenuItem
            // 
            this.ChineseToolStripMenuItem.Name = "ChineseToolStripMenuItem";
            resources.ApplyResources(this.ChineseToolStripMenuItem, "ChineseToolStripMenuItem");
            this.ChineseToolStripMenuItem.Click += new System.EventHandler(this.ChineseToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactToolStripMenuItem,
            this.toolStripSeparator2,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            // 
            // ContactToolStripMenuItem
            // 
            this.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem";
            resources.ApplyResources(this.ContactToolStripMenuItem, "ContactToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            // 
            // DeviceSettingButton
            // 
            this.DeviceSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeviceSettingButton.FlatAppearance.BorderSize = 5;
            resources.ApplyResources(this.DeviceSettingButton, "DeviceSettingButton");
            this.DeviceSettingButton.Image = global::NeedleController.Properties.Resources.SETTING_100x100;
            this.DeviceSettingButton.Name = "DeviceSettingButton";
            this.DeviceSettingButton.UseVisualStyleBackColor = true;
            this.DeviceSettingButton.Click += new System.EventHandler(this.DeviceSettingButton_Click);
            // 
            // CameraSettingButton
            // 
            this.CameraSettingButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CameraSettingButton.FlatAppearance.BorderSize = 5;
            resources.ApplyResources(this.CameraSettingButton, "CameraSettingButton");
            this.CameraSettingButton.Image = global::NeedleController.Properties.Resources.camera_100x100;
            this.CameraSettingButton.Name = "CameraSettingButton";
            this.CameraSettingButton.UseVisualStyleBackColor = true;
            this.CameraSettingButton.Click += new System.EventHandler(this.CameraSettingButton_Click);
            // 
            // NeedleInfoButton
            // 
            this.NeedleInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.NeedleInfoButton.FlatAppearance.BorderSize = 5;
            resources.ApplyResources(this.NeedleInfoButton, "NeedleInfoButton");
            this.NeedleInfoButton.Image = global::NeedleController.Properties.Resources.Info_100x100_2;
            this.NeedleInfoButton.Name = "NeedleInfoButton";
            this.NeedleInfoButton.UseVisualStyleBackColor = true;
            this.NeedleInfoButton.Click += new System.EventHandler(this.NeedleInfoButton_Click);
            // 
            // GetNeedleButton
            // 
            this.GetNeedleButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.GetNeedleButton.FlatAppearance.BorderSize = 5;
            resources.ApplyResources(this.GetNeedleButton, "GetNeedleButton");
            this.GetNeedleButton.Image = global::NeedleController.Properties.Resources.GROZ_B_100x100;
            this.GetNeedleButton.Name = "GetNeedleButton";
            this.GetNeedleButton.UseVisualStyleBackColor = true;
            this.GetNeedleButton.Click += new System.EventHandler(this.GetNeedleButton_Click);
            // 
            // ConnectedStatusLabel
            // 
            resources.ApplyResources(this.ConnectedStatusLabel, "ConnectedStatusLabel");
            this.ConnectedStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.ConnectedStatusLabel.Name = "ConnectedStatusLabel";
            // 
            // CultureManagerMainForm
            // 
            this.CultureManagerMainForm.ManagedControl = this;
            this.CultureManagerMainForm.UICultureChanged += new Infralution.Localization.CultureManager.CultureChangedHandler(this.CultureManagerMainForm_UICultureChanged);
            // 
            // BuildingNameLabel
            // 
            resources.ApplyResources(this.BuildingNameLabel, "BuildingNameLabel");
            this.BuildingNameLabel.Name = "BuildingNameLabel";
            this.BuildingNameLabel.Click += new System.EventHandler(this.BuildingNameLabel_Click);
            // 
            // DeviceNameLabel
            // 
            resources.ApplyResources(this.DeviceNameLabel, "DeviceNameLabel");
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            // 
            // BuldingTilteLabel
            // 
            resources.ApplyResources(this.BuldingTilteLabel, "BuldingTilteLabel");
            this.BuldingTilteLabel.Name = "BuldingTilteLabel";
            // 
            // DeviceTilteLabel
            // 
            resources.ApplyResources(this.DeviceTilteLabel, "DeviceTilteLabel");
            this.DeviceTilteLabel.Name = "DeviceTilteLabel";
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ControlBox = false;
            this.Controls.Add(this.DeviceTilteLabel);
            this.Controls.Add(this.BuldingTilteLabel);
            this.Controls.Add(this.DeviceNameLabel);
            this.Controls.Add(this.BuildingNameLabel);
            this.Controls.Add(this.ConnectedStatusLabel);
            this.Controls.Add(this.ConnectDeviceButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.DeviceSettingButton);
            this.Controls.Add(this.CameraSettingButton);
            this.Controls.Add(this.NeedleInfoButton);
            this.Controls.Add(this.GetNeedleButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DisconnectedStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetNeedleButton;
        private System.Windows.Forms.Button NeedleInfoButton;
        private System.Windows.Forms.Button CameraSettingButton;
        private System.Windows.Forms.Button DeviceSettingButton;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label DisconnectedStatusLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ConnectDeviceButton;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label ConnectedStatusLabel;
        private Infralution.Localization.CultureManager CultureManagerMainForm;
        private System.Windows.Forms.ToolStripMenuItem ChineseToolStripMenuItem;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label BuildingNameLabel;
        private System.Windows.Forms.Label DeviceTilteLabel;
        private System.Windows.Forms.Label BuldingTilteLabel;
    }
}

