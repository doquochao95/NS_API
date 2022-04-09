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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImageSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrightnessValue = new System.Windows.Forms.Label();
            this.BrightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.Brightness = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContrastValue = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.Contrast = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DisplayMode = new System.Windows.Forms.GroupBox();
            this.RedRaBtn = new System.Windows.Forms.RadioButton();
            this.NormalRaBtn = new System.Windows.Forms.RadioButton();
            this.GreenRaBtn = new System.Windows.Forms.RadioButton();
            this.BlueRaBtn = new System.Windows.Forms.RadioButton();
            this.ImgPositionCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ImageSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.DisplayMode.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImageSetting
            // 
            this.ImageSetting.Controls.Add(this.tableLayoutPanel1);
            this.ImageSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSetting.Location = new System.Drawing.Point(10, 10);
            this.ImageSetting.Name = "ImageSetting";
            this.ImageSetting.Padding = new System.Windows.Forms.Padding(5);
            this.ImageSetting.Size = new System.Drawing.Size(466, 345);
            this.ImageSetting.TabIndex = 3;
            this.ImageSetting.TabStop = false;
            this.ImageSetting.Text = "Image Setting";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 320);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrightnessValue);
            this.panel1.Controls.Add(this.BrightnessTrackbar);
            this.panel1.Controls.Add(this.Brightness);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 58);
            this.panel1.TabIndex = 18;
            // 
            // BrightnessValue
            // 
            this.BrightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessValue.AutoSize = true;
            this.BrightnessValue.Location = new System.Drawing.Point(411, 18);
            this.BrightnessValue.Name = "BrightnessValue";
            this.BrightnessValue.Size = new System.Drawing.Size(14, 16);
            this.BrightnessValue.TabIndex = 16;
            this.BrightnessValue.Text = "0";
            // 
            // BrightnessTrackbar
            // 
            this.BrightnessTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessTrackbar.Location = new System.Drawing.Point(92, 13);
            this.BrightnessTrackbar.Maximum = 100;
            this.BrightnessTrackbar.Minimum = -100;
            this.BrightnessTrackbar.Name = "BrightnessTrackbar";
            this.BrightnessTrackbar.Size = new System.Drawing.Size(313, 45);
            this.BrightnessTrackbar.TabIndex = 15;
            this.BrightnessTrackbar.TickFrequency = 10;
            this.BrightnessTrackbar.Scroll += new System.EventHandler(this.BrightnessTrackbar_Scroll);
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brightness.Location = new System.Drawing.Point(17, 18);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(76, 16);
            this.Brightness.TabIndex = 14;
            this.Brightness.Text = "Brightness :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ContrastValue);
            this.panel2.Controls.Add(this.ContrastTrackBar);
            this.panel2.Controls.Add(this.Contrast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 58);
            this.panel2.TabIndex = 19;
            // 
            // ContrastValue
            // 
            this.ContrastValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastValue.AutoSize = true;
            this.ContrastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastValue.Location = new System.Drawing.Point(411, 12);
            this.ContrastValue.Name = "ContrastValue";
            this.ContrastValue.Size = new System.Drawing.Size(14, 16);
            this.ContrastValue.TabIndex = 17;
            this.ContrastValue.Text = "0";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastTrackBar.LargeChange = 10;
            this.ContrastTrackBar.Location = new System.Drawing.Point(92, 7);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(313, 45);
            this.ContrastTrackBar.SmallChange = 5;
            this.ContrastTrackBar.TabIndex = 16;
            this.ContrastTrackBar.TickFrequency = 10;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // Contrast
            // 
            this.Contrast.AutoSize = true;
            this.Contrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast.Location = new System.Drawing.Point(17, 12);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(62, 16);
            this.Contrast.TabIndex = 15;
            this.Contrast.Text = "Contrast :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DisplayMode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 122);
            this.panel3.TabIndex = 20;
            // 
            // DisplayMode
            // 
            this.DisplayMode.Controls.Add(this.RedRaBtn);
            this.DisplayMode.Controls.Add(this.NormalRaBtn);
            this.DisplayMode.Controls.Add(this.GreenRaBtn);
            this.DisplayMode.Controls.Add(this.BlueRaBtn);
            this.DisplayMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DisplayMode.Location = new System.Drawing.Point(0, 0);
            this.DisplayMode.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.DisplayMode.Name = "DisplayMode";
            this.DisplayMode.Padding = new System.Windows.Forms.Padding(10);
            this.DisplayMode.Size = new System.Drawing.Size(450, 122);
            this.DisplayMode.TabIndex = 13;
            this.DisplayMode.TabStop = false;
            this.DisplayMode.Text = "Display Mode";
            // 
            // RedRaBtn
            // 
            this.RedRaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RedRaBtn.AutoSize = true;
            this.RedRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedRaBtn.Location = new System.Drawing.Point(270, 37);
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
            this.NormalRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalRaBtn.Location = new System.Drawing.Point(66, 37);
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
            this.GreenRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRaBtn.Location = new System.Drawing.Point(66, 76);
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
            this.BlueRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRaBtn.Location = new System.Drawing.Point(270, 76);
            this.BlueRaBtn.Name = "BlueRaBtn";
            this.BlueRaBtn.Size = new System.Drawing.Size(101, 20);
            this.BlueRaBtn.TabIndex = 10;
            this.BlueRaBtn.Text = "Blue Display";
            this.BlueRaBtn.UseVisualStyleBackColor = true;
            this.BlueRaBtn.CheckedChanged += new System.EventHandler(this.BlueRaBtn_CheckedChanged);
            // 
            // ImgPositionCmb
            // 
            this.ImgPositionCmb.FormattingEnabled = true;
            this.ImgPositionCmb.Items.AddRange(new object[] {
            "Center",
            "Fill",
            "Fit",
            "Stretch"});
            this.ImgPositionCmb.Location = new System.Drawing.Point(125, 20);
            this.ImgPositionCmb.Name = "ImgPositionCmb";
            this.ImgPositionCmb.Size = new System.Drawing.Size(100, 24);
            this.ImgPositionCmb.TabIndex = 17;
            this.ImgPositionCmb.SelectedIndexChanged += new System.EventHandler(this.ImgPositionCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Image Position :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ImgPositionCmb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 58);
            this.panel4.TabIndex = 20;
            // 
            // CameraImgParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImageSetting);
            this.MinimumSize = new System.Drawing.Size(486, 365);
            this.Name = "CameraImgParaSetting";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(486, 365);
            this.Load += new System.EventHandler(this.CameraImgParaSetting_Load);
            this.ImageSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.DisplayMode.ResumeLayout(false);
            this.DisplayMode.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox ImageSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BrightnessValue;
        private System.Windows.Forms.TrackBar BrightnessTrackbar;
        private System.Windows.Forms.Label Brightness;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ImgPositionCmb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ContrastValue;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label Contrast;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox DisplayMode;
        private System.Windows.Forms.RadioButton RedRaBtn;
        private System.Windows.Forms.RadioButton NormalRaBtn;
        private System.Windows.Forms.RadioButton GreenRaBtn;
        private System.Windows.Forms.RadioButton BlueRaBtn;
    }
}
