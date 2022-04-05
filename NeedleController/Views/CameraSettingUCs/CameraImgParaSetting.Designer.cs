namespace NeedleController.Views.CameraSettingUCs
{
    partial class CameraImgParaSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageSetting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgPositionCmb = new System.Windows.Forms.ComboBox();
            this.ContrastValue = new System.Windows.Forms.Label();
            this.BrightnessValue = new System.Windows.Forms.Label();
            this.DisplayMode = new System.Windows.Forms.GroupBox();
            this.RedRaBtn = new System.Windows.Forms.RadioButton();
            this.NormalRaBtn = new System.Windows.Forms.RadioButton();
            this.GreenRaBtn = new System.Windows.Forms.RadioButton();
            this.BlueRaBtn = new System.Windows.Forms.RadioButton();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.Contrast = new System.Windows.Forms.Label();
            this.Brightness = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.ImageSetting.SuspendLayout();
            this.DisplayMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImageSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 414);
            this.panel1.TabIndex = 0;
            // 
            // ImageSetting
            // 
            this.ImageSetting.Controls.Add(this.label1);
            this.ImageSetting.Controls.Add(this.ImgPositionCmb);
            this.ImageSetting.Controls.Add(this.ContrastValue);
            this.ImageSetting.Controls.Add(this.BrightnessValue);
            this.ImageSetting.Controls.Add(this.DisplayMode);
            this.ImageSetting.Controls.Add(this.ContrastTrackBar);
            this.ImageSetting.Controls.Add(this.BrightnessTrackbar);
            this.ImageSetting.Controls.Add(this.Contrast);
            this.ImageSetting.Controls.Add(this.Brightness);
            this.ImageSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSetting.Location = new System.Drawing.Point(0, 0);
            this.ImageSetting.Name = "ImageSetting";
            this.ImageSetting.Size = new System.Drawing.Size(621, 414);
            this.ImageSetting.TabIndex = 1;
            this.ImageSetting.TabStop = false;
            this.ImageSetting.Text = "Image Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Image Position";
            // 
            // ImgPositionCmb
            // 
            this.ImgPositionCmb.FormattingEnabled = true;
            this.ImgPositionCmb.Items.AddRange(new object[] {
            "Center",
            "Fill",
            "Fit",
            "Stretch"});
            this.ImgPositionCmb.Location = new System.Drawing.Point(229, 303);
            this.ImgPositionCmb.Name = "ImgPositionCmb";
            this.ImgPositionCmb.Size = new System.Drawing.Size(100, 26);
            this.ImgPositionCmb.TabIndex = 15;
            this.ImgPositionCmb.SelectedIndexChanged += new System.EventHandler(this.ImgPositionCmb_SelectedIndexChanged);
            // 
            // ContrastValue
            // 
            this.ContrastValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastValue.AutoSize = true;
            this.ContrastValue.Location = new System.Drawing.Point(527, 103);
            this.ContrastValue.Name = "ContrastValue";
            this.ContrastValue.Size = new System.Drawing.Size(16, 18);
            this.ContrastValue.TabIndex = 14;
            this.ContrastValue.Text = "0";
            // 
            // BrightnessValue
            // 
            this.BrightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessValue.AutoSize = true;
            this.BrightnessValue.Location = new System.Drawing.Point(527, 44);
            this.BrightnessValue.Name = "BrightnessValue";
            this.BrightnessValue.Size = new System.Drawing.Size(16, 18);
            this.BrightnessValue.TabIndex = 13;
            this.BrightnessValue.Text = "0";
            // 
            // DisplayMode
            // 
            this.DisplayMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayMode.Controls.Add(this.RedRaBtn);
            this.DisplayMode.Controls.Add(this.NormalRaBtn);
            this.DisplayMode.Controls.Add(this.GreenRaBtn);
            this.DisplayMode.Controls.Add(this.BlueRaBtn);
            this.DisplayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DisplayMode.Location = new System.Drawing.Point(73, 165);
            this.DisplayMode.Name = "DisplayMode";
            this.DisplayMode.Size = new System.Drawing.Size(470, 118);
            this.DisplayMode.TabIndex = 12;
            this.DisplayMode.TabStop = false;
            this.DisplayMode.Text = "Display Mode";
            // 
            // RedRaBtn
            // 
            this.RedRaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RedRaBtn.AutoSize = true;
            this.RedRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedRaBtn.Location = new System.Drawing.Point(280, 35);
            this.RedRaBtn.Name = "RedRaBtn";
            this.RedRaBtn.Size = new System.Drawing.Size(100, 20);
            this.RedRaBtn.TabIndex = 8;
            this.RedRaBtn.Text = "Red Display";
            this.RedRaBtn.UseVisualStyleBackColor = true;
            this.RedRaBtn.CheckedChanged += new System.EventHandler(this.RedRaBtn_CheckedChanged);
            // 
            // NormalRaBtn
            // 
            this.NormalRaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NormalRaBtn.AutoSize = true;
            this.NormalRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalRaBtn.Location = new System.Drawing.Point(76, 35);
            this.NormalRaBtn.Name = "NormalRaBtn";
            this.NormalRaBtn.Size = new System.Drawing.Size(118, 20);
            this.NormalRaBtn.TabIndex = 11;
            this.NormalRaBtn.Text = "Normal Display";
            this.NormalRaBtn.UseVisualStyleBackColor = true;
            this.NormalRaBtn.CheckedChanged += new System.EventHandler(this.NormalRaBtn_CheckedChanged);
            // 
            // GreenRaBtn
            // 
            this.GreenRaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GreenRaBtn.AutoSize = true;
            this.GreenRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRaBtn.Location = new System.Drawing.Point(76, 72);
            this.GreenRaBtn.Name = "GreenRaBtn";
            this.GreenRaBtn.Size = new System.Drawing.Size(111, 20);
            this.GreenRaBtn.TabIndex = 9;
            this.GreenRaBtn.Text = "Green Display";
            this.GreenRaBtn.UseVisualStyleBackColor = true;
            this.GreenRaBtn.CheckedChanged += new System.EventHandler(this.GreenRaBtn_CheckedChanged);
            // 
            // BlueRaBtn
            // 
            this.BlueRaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BlueRaBtn.AutoSize = true;
            this.BlueRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRaBtn.Location = new System.Drawing.Point(280, 72);
            this.BlueRaBtn.Name = "BlueRaBtn";
            this.BlueRaBtn.Size = new System.Drawing.Size(101, 20);
            this.BlueRaBtn.TabIndex = 10;
            this.BlueRaBtn.Text = "Blue Display";
            this.BlueRaBtn.UseVisualStyleBackColor = true;
            this.BlueRaBtn.CheckedChanged += new System.EventHandler(this.BlueRaBtn_CheckedChanged);
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastTrackBar.LargeChange = 10;
            this.ContrastTrackBar.Location = new System.Drawing.Point(167, 103);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(344, 50);
            this.ContrastTrackBar.SmallChange = 5;
            this.ContrastTrackBar.TabIndex = 3;
            this.ContrastTrackBar.TickFrequency = 10;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // BrightnessTrackbar
            // 
            this.BrightnessTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessTrackbar.Location = new System.Drawing.Point(167, 44);
            this.BrightnessTrackbar.Maximum = 100;
            this.BrightnessTrackbar.Minimum = -100;
            this.BrightnessTrackbar.Name = "BrightnessTrackbar";
            this.BrightnessTrackbar.Size = new System.Drawing.Size(344, 50);
            this.BrightnessTrackbar.TabIndex = 2;
            this.BrightnessTrackbar.TickFrequency = 10;
            this.BrightnessTrackbar.Scroll += new System.EventHandler(this.BrightnessTrackbar_Scroll);
            // 
            // Contrast
            // 
            this.Contrast.AutoSize = true;
            this.Contrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast.Location = new System.Drawing.Point(70, 103);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(56, 16);
            this.Contrast.TabIndex = 1;
            this.Contrast.Text = "Contrast";
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brightness.Location = new System.Drawing.Point(70, 46);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(70, 16);
            this.Brightness.TabIndex = 0;
            this.Brightness.Text = "Brightness";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CameraImgParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CameraImgParaSetting";
            this.Size = new System.Drawing.Size(621, 414);
            this.panel1.ResumeLayout(false);
            this.ImageSetting.ResumeLayout(false);
            this.ImageSetting.PerformLayout();
            this.DisplayMode.ResumeLayout(false);
            this.DisplayMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ImageSetting;
        private System.Windows.Forms.Label ContrastValue;
        private System.Windows.Forms.Label BrightnessValue;
        private System.Windows.Forms.GroupBox DisplayMode;
        private System.Windows.Forms.RadioButton RedRaBtn;
        private System.Windows.Forms.RadioButton NormalRaBtn;
        private System.Windows.Forms.RadioButton GreenRaBtn;
        private System.Windows.Forms.RadioButton BlueRaBtn;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.TrackBar BrightnessTrackbar;
        private System.Windows.Forms.Label Contrast;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ImgPositionCmb;
        private System.Windows.Forms.Timer timer1;
    }
}
