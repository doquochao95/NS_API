
namespace NeedleController.Views.CameraSettingUCs
{
    partial class CameraParaSetting
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
            this.CannyThreshold1Trackbar = new System.Windows.Forms.TrackBar();
            this.CannyThreshold2Value = new System.Windows.Forms.Label();
            this.CannyThreshold1Value = new System.Windows.Forms.Label();
            this.CannyThreshold1Label = new System.Windows.Forms.Label();
            this.CannyThreshold2Label = new System.Windows.Forms.Label();
            this.CannyThreshold2Trackbar = new System.Windows.Forms.TrackBar();
            this.GaussianKsizeLabel = new System.Windows.Forms.Label();
            this.GaussianKSizeCmb = new System.Windows.Forms.ComboBox();
            this.Color = new System.Windows.Forms.GroupBox();
            this.ColorNeedle = new System.Windows.Forms.PictureBox();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.HighB = new System.Windows.Forms.TextBox();
            this.HighG = new System.Windows.Forms.TextBox();
            this.HighR = new System.Windows.Forms.TextBox();
            this.LowB = new System.Windows.Forms.TextBox();
            this.LowG = new System.Windows.Forms.TextBox();
            this.LowR = new System.Windows.Forms.TextBox();
            this.LowerbLabel = new System.Windows.Forms.Label();
            this.UpperbLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnOffDetect = new System.Windows.Forms.CheckBox();
            this.IDcameraCmb = new System.Windows.Forms.ComboBox();
            this.CameraAddress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).BeginInit();
            this.Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CannyThreshold1Trackbar
            // 
            this.CannyThreshold1Trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold1Trackbar.Location = new System.Drawing.Point(171, 122);
            this.CannyThreshold1Trackbar.Maximum = 255;
            this.CannyThreshold1Trackbar.Name = "CannyThreshold1Trackbar";
            this.CannyThreshold1Trackbar.Size = new System.Drawing.Size(364, 50);
            this.CannyThreshold1Trackbar.TabIndex = 0;
            this.CannyThreshold1Trackbar.TickFrequency = 10;
            this.CannyThreshold1Trackbar.Scroll += new System.EventHandler(this.CannyThreshold1Trackbar_Scroll);
            // 
            // CannyThreshold2Value
            // 
            this.CannyThreshold2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold2Value.AutoSize = true;
            this.CannyThreshold2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Value.Location = new System.Drawing.Point(550, 178);
            this.CannyThreshold2Value.Name = "CannyThreshold2Value";
            this.CannyThreshold2Value.Size = new System.Drawing.Size(16, 18);
            this.CannyThreshold2Value.TabIndex = 5;
            this.CannyThreshold2Value.Text = "0";
            // 
            // CannyThreshold1Value
            // 
            this.CannyThreshold1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold1Value.AutoSize = true;
            this.CannyThreshold1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Value.Location = new System.Drawing.Point(550, 126);
            this.CannyThreshold1Value.Name = "CannyThreshold1Value";
            this.CannyThreshold1Value.Size = new System.Drawing.Size(16, 18);
            this.CannyThreshold1Value.TabIndex = 4;
            this.CannyThreshold1Value.Text = "0";
            // 
            // CannyThreshold1Label
            // 
            this.CannyThreshold1Label.AutoSize = true;
            this.CannyThreshold1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Label.Location = new System.Drawing.Point(34, 128);
            this.CannyThreshold1Label.Name = "CannyThreshold1Label";
            this.CannyThreshold1Label.Size = new System.Drawing.Size(119, 16);
            this.CannyThreshold1Label.TabIndex = 2;
            this.CannyThreshold1Label.Text = "Canny Threshold 1";
            // 
            // CannyThreshold2Label
            // 
            this.CannyThreshold2Label.AutoSize = true;
            this.CannyThreshold2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Label.Location = new System.Drawing.Point(34, 184);
            this.CannyThreshold2Label.Name = "CannyThreshold2Label";
            this.CannyThreshold2Label.Size = new System.Drawing.Size(119, 16);
            this.CannyThreshold2Label.TabIndex = 3;
            this.CannyThreshold2Label.Text = "Canny Threshold 2";
            // 
            // CannyThreshold2Trackbar
            // 
            this.CannyThreshold2Trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold2Trackbar.Location = new System.Drawing.Point(171, 178);
            this.CannyThreshold2Trackbar.Maximum = 255;
            this.CannyThreshold2Trackbar.Name = "CannyThreshold2Trackbar";
            this.CannyThreshold2Trackbar.Size = new System.Drawing.Size(364, 50);
            this.CannyThreshold2Trackbar.TabIndex = 1;
            this.CannyThreshold2Trackbar.TickFrequency = 10;
            this.CannyThreshold2Trackbar.Scroll += new System.EventHandler(this.CannyThreshold2Trackbar_Scroll);
            // 
            // GaussianKsizeLabel
            // 
            this.GaussianKsizeLabel.AutoSize = true;
            this.GaussianKsizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianKsizeLabel.Location = new System.Drawing.Point(34, 77);
            this.GaussianKsizeLabel.Name = "GaussianKsizeLabel";
            this.GaussianKsizeLabel.Size = new System.Drawing.Size(157, 16);
            this.GaussianKsizeLabel.TabIndex = 9;
            this.GaussianKsizeLabel.Text = "GaussianBlur Kernel Size";
            // 
            // GaussianKSizeCmb
            // 
            this.GaussianKSizeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianKSizeCmb.FormattingEnabled = true;
            this.GaussianKSizeCmb.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.GaussianKSizeCmb.Location = new System.Drawing.Point(233, 72);
            this.GaussianKSizeCmb.Name = "GaussianKSizeCmb";
            this.GaussianKSizeCmb.Size = new System.Drawing.Size(80, 26);
            this.GaussianKSizeCmb.TabIndex = 10;
            this.GaussianKSizeCmb.SelectedIndexChanged += new System.EventHandler(this.GaussianKSizeCmb_SelectedIndexChanged);
            // 
            // Color
            // 
            this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Color.Controls.Add(this.ColorNeedle);
            this.Color.Controls.Add(this.BlueLabel);
            this.Color.Controls.Add(this.GreenLabel);
            this.Color.Controls.Add(this.RedLabel);
            this.Color.Controls.Add(this.HighB);
            this.Color.Controls.Add(this.HighG);
            this.Color.Controls.Add(this.HighR);
            this.Color.Controls.Add(this.LowB);
            this.Color.Controls.Add(this.LowG);
            this.Color.Controls.Add(this.LowR);
            this.Color.Controls.Add(this.LowerbLabel);
            this.Color.Controls.Add(this.UpperbLabel);
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(37, 235);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(529, 158);
            this.Color.TabIndex = 12;
            this.Color.TabStop = false;
            this.Color.Text = "Needle Color";
            // 
            // ColorNeedle
            // 
            this.ColorNeedle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ColorNeedle.Location = new System.Drawing.Point(68, 117);
            this.ColorNeedle.Name = "ColorNeedle";
            this.ColorNeedle.Size = new System.Drawing.Size(385, 26);
            this.ColorNeedle.TabIndex = 12;
            this.ColorNeedle.TabStop = false;
            this.ColorNeedle.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorNeedle_Paint);
            // 
            // BlueLabel
            // 
            this.BlueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueLabel.Location = new System.Drawing.Point(397, 20);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(34, 16);
            this.BlueLabel.TabIndex = 10;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.ForeColor = System.Drawing.Color.Green;
            this.GreenLabel.Location = new System.Drawing.Point(275, 20);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(44, 16);
            this.GreenLabel.TabIndex = 9;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(166, 20);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(33, 16);
            this.RedLabel.TabIndex = 8;
            this.RedLabel.Text = "Red";
            // 
            // HighB
            // 
            this.HighB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighB.Location = new System.Drawing.Point(373, 80);
            this.HighB.Name = "HighB";
            this.HighB.Size = new System.Drawing.Size(80, 24);
            this.HighB.TabIndex = 7;
            this.HighB.Text = "80";
            this.HighB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighB_KeyPress);
            // 
            // HighG
            // 
            this.HighG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighG.Location = new System.Drawing.Point(255, 80);
            this.HighG.Name = "HighG";
            this.HighG.Size = new System.Drawing.Size(80, 24);
            this.HighG.TabIndex = 6;
            this.HighG.Text = "110";
            this.HighG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighG_KeyPress);
            // 
            // HighR
            // 
            this.HighR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighR.Location = new System.Drawing.Point(142, 80);
            this.HighR.Name = "HighR";
            this.HighR.Size = new System.Drawing.Size(80, 24);
            this.HighR.TabIndex = 5;
            this.HighR.Text = "150";
            this.HighR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighR_KeyPress);
            // 
            // LowB
            // 
            this.LowB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowB.Location = new System.Drawing.Point(373, 45);
            this.LowB.Name = "LowB";
            this.LowB.Size = new System.Drawing.Size(80, 24);
            this.LowB.TabIndex = 4;
            this.LowB.Text = "50";
            this.LowB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowB_KeyPress);
            // 
            // LowG
            // 
            this.LowG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowG.Location = new System.Drawing.Point(255, 45);
            this.LowG.Name = "LowG";
            this.LowG.Size = new System.Drawing.Size(80, 24);
            this.LowG.TabIndex = 3;
            this.LowG.Text = "90";
            this.LowG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowG_KeyPress);
            // 
            // LowR
            // 
            this.LowR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowR.Location = new System.Drawing.Point(142, 45);
            this.LowR.Name = "LowR";
            this.LowR.Size = new System.Drawing.Size(80, 24);
            this.LowR.TabIndex = 2;
            this.LowR.Text = "130";
            this.LowR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowR_KeyPress);
            // 
            // LowerbLabel
            // 
            this.LowerbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowerbLabel.AutoSize = true;
            this.LowerbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerbLabel.Location = new System.Drawing.Point(65, 50);
            this.LowerbLabel.Name = "LowerbLabel";
            this.LowerbLabel.Size = new System.Drawing.Size(51, 16);
            this.LowerbLabel.TabIndex = 1;
            this.LowerbLabel.Text = "Lowerb";
            // 
            // UpperbLabel
            // 
            this.UpperbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UpperbLabel.AutoSize = true;
            this.UpperbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperbLabel.Location = new System.Drawing.Point(65, 85);
            this.UpperbLabel.Name = "UpperbLabel";
            this.UpperbLabel.Size = new System.Drawing.Size(53, 16);
            this.UpperbLabel.TabIndex = 0;
            this.UpperbLabel.Text = "Upperb";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnOffDetect);
            this.groupBox1.Controls.Add(this.CannyThreshold1Trackbar);
            this.groupBox1.Controls.Add(this.CannyThreshold2Value);
            this.groupBox1.Controls.Add(this.GaussianKsizeLabel);
            this.groupBox1.Controls.Add(this.CannyThreshold1Value);
            this.groupBox1.Controls.Add(this.GaussianKSizeCmb);
            this.groupBox1.Controls.Add(this.CannyThreshold1Label);
            this.groupBox1.Controls.Add(this.IDcameraCmb);
            this.groupBox1.Controls.Add(this.CannyThreshold2Label);
            this.groupBox1.Controls.Add(this.CameraAddress);
            this.groupBox1.Controls.Add(this.CannyThreshold2Trackbar);
            this.groupBox1.Controls.Add(this.Color);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 414);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opencv Setting";
            // 
            // OnOffDetect
            // 
            this.OnOffDetect.AutoSize = true;
            this.OnOffDetect.Checked = true;
            this.OnOffDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnOffDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffDetect.Location = new System.Drawing.Point(370, 32);
            this.OnOffDetect.Name = "OnOffDetect";
            this.OnOffDetect.Size = new System.Drawing.Size(85, 20);
            this.OnOffDetect.TabIndex = 16;
            this.OnOffDetect.Text = "On Detect";
            this.OnOffDetect.UseVisualStyleBackColor = true;
            this.OnOffDetect.CheckedChanged += new System.EventHandler(this.OnOffDetect_CheckedChanged);
            // 
            // IDcameraCmb
            // 
            this.IDcameraCmb.FormattingEnabled = true;
            this.IDcameraCmb.Location = new System.Drawing.Point(233, 28);
            this.IDcameraCmb.Name = "IDcameraCmb";
            this.IDcameraCmb.Size = new System.Drawing.Size(80, 26);
            this.IDcameraCmb.TabIndex = 15;
            this.IDcameraCmb.SelectedIndexChanged += new System.EventHandler(this.IDcameraCmb_SelectedIndexChanged);
            // 
            // CameraAddress
            // 
            this.CameraAddress.AutoSize = true;
            this.CameraAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraAddress.Location = new System.Drawing.Point(34, 33);
            this.CameraAddress.Name = "CameraAddress";
            this.CameraAddress.Size = new System.Drawing.Size(109, 16);
            this.CameraAddress.TabIndex = 14;
            this.CameraAddress.Text = "Camera Address";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CameraParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CameraParaSetting";
            this.Size = new System.Drawing.Size(621, 414);
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).EndInit();
            this.Color.ResumeLayout(false);
            this.Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar CannyThreshold1Trackbar;
        private System.Windows.Forms.Label CannyThreshold2Value;
        private System.Windows.Forms.TrackBar CannyThreshold2Trackbar;
        private System.Windows.Forms.Label CannyThreshold1Value;
        private System.Windows.Forms.Label CannyThreshold1Label;
        private System.Windows.Forms.Label CannyThreshold2Label;
        private System.Windows.Forms.Label GaussianKsizeLabel;
        private System.Windows.Forms.ComboBox GaussianKSizeCmb;
        private System.Windows.Forms.GroupBox Color;
        private System.Windows.Forms.Label UpperbLabel;
        private System.Windows.Forms.TextBox HighB;
        private System.Windows.Forms.TextBox HighG;
        private System.Windows.Forms.TextBox HighR;
        private System.Windows.Forms.TextBox LowB;
        private System.Windows.Forms.TextBox LowG;
        private System.Windows.Forms.TextBox LowR;
        private System.Windows.Forms.Label LowerbLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.PictureBox ColorNeedle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox IDcameraCmb;
        private System.Windows.Forms.Label CameraAddress;
        private System.Windows.Forms.CheckBox OnOffDetect;
        private System.Windows.Forms.Timer timer1;
    }
}
