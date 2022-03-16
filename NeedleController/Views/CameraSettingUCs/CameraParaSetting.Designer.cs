
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
            this.Canny = new System.Windows.Forms.GroupBox();
            this.CannyThreshold1Trackbar = new System.Windows.Forms.TrackBar();
            this.CannyThreshold2Value = new System.Windows.Forms.Label();
            this.CannyThreshold2Trackbar = new System.Windows.Forms.TrackBar();
            this.CannyThreshold1Value = new System.Windows.Forms.Label();
            this.CannyThreshold1Label = new System.Windows.Forms.Label();
            this.CannyThreshold2Label = new System.Windows.Forms.Label();
            this.GaussianKsizeLabel = new System.Windows.Forms.Label();
            this.GaussianKSizeCmb = new System.Windows.Forms.ComboBox();
            this.GaussianBlur = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.GroupBox();
            this.ColorNeedle = new System.Windows.Forms.PictureBox();
            this.SaveColorParaButton = new System.Windows.Forms.Button();
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
            this.Canny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).BeginInit();
            this.GaussianBlur.SuspendLayout();
            this.Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).BeginInit();
            this.SuspendLayout();
            // 
            // Canny
            // 
            this.Canny.Controls.Add(this.CannyThreshold1Trackbar);
            this.Canny.Controls.Add(this.CannyThreshold2Value);
            this.Canny.Controls.Add(this.CannyThreshold2Trackbar);
            this.Canny.Controls.Add(this.CannyThreshold1Value);
            this.Canny.Controls.Add(this.CannyThreshold1Label);
            this.Canny.Controls.Add(this.CannyThreshold2Label);
            this.Canny.Dock = System.Windows.Forms.DockStyle.Top;
            this.Canny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canny.Location = new System.Drawing.Point(0, 90);
            this.Canny.Name = "Canny";
            this.Canny.Size = new System.Drawing.Size(747, 165);
            this.Canny.TabIndex = 8;
            this.Canny.TabStop = false;
            this.Canny.Text = "Canny";
            // 
            // CannyThreshold1Trackbar
            // 
            this.CannyThreshold1Trackbar.Location = new System.Drawing.Point(223, 34);
            this.CannyThreshold1Trackbar.Maximum = 255;
            this.CannyThreshold1Trackbar.Name = "CannyThreshold1Trackbar";
            this.CannyThreshold1Trackbar.Size = new System.Drawing.Size(336, 50);
            this.CannyThreshold1Trackbar.TabIndex = 0;
            this.CannyThreshold1Trackbar.TickFrequency = 10;
            this.CannyThreshold1Trackbar.Scroll += new System.EventHandler(this.CannyThreshold1Trackbar_Scroll);
            // 
            // CannyThreshold2Value
            // 
            this.CannyThreshold2Value.AutoSize = true;
            this.CannyThreshold2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Value.Location = new System.Drawing.Point(565, 99);
            this.CannyThreshold2Value.Name = "CannyThreshold2Value";
            this.CannyThreshold2Value.Size = new System.Drawing.Size(18, 20);
            this.CannyThreshold2Value.TabIndex = 5;
            this.CannyThreshold2Value.Text = "0";
            // 
            // CannyThreshold2Trackbar
            // 
            this.CannyThreshold2Trackbar.Location = new System.Drawing.Point(223, 99);
            this.CannyThreshold2Trackbar.Maximum = 255;
            this.CannyThreshold2Trackbar.Name = "CannyThreshold2Trackbar";
            this.CannyThreshold2Trackbar.Size = new System.Drawing.Size(336, 50);
            this.CannyThreshold2Trackbar.TabIndex = 1;
            this.CannyThreshold2Trackbar.TickFrequency = 10;
            this.CannyThreshold2Trackbar.Scroll += new System.EventHandler(this.CannyThreshold2Trackbar_Scroll);
            // 
            // CannyThreshold1Value
            // 
            this.CannyThreshold1Value.AutoSize = true;
            this.CannyThreshold1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Value.Location = new System.Drawing.Point(565, 32);
            this.CannyThreshold1Value.Name = "CannyThreshold1Value";
            this.CannyThreshold1Value.Size = new System.Drawing.Size(18, 20);
            this.CannyThreshold1Value.TabIndex = 4;
            this.CannyThreshold1Value.Text = "0";
            // 
            // CannyThreshold1Label
            // 
            this.CannyThreshold1Label.AutoSize = true;
            this.CannyThreshold1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Label.Location = new System.Drawing.Point(133, 34);
            this.CannyThreshold1Label.Name = "CannyThreshold1Label";
            this.CannyThreshold1Label.Size = new System.Drawing.Size(79, 16);
            this.CannyThreshold1Label.TabIndex = 2;
            this.CannyThreshold1Label.Text = "Threshold 1";
            // 
            // CannyThreshold2Label
            // 
            this.CannyThreshold2Label.AutoSize = true;
            this.CannyThreshold2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Label.Location = new System.Drawing.Point(133, 99);
            this.CannyThreshold2Label.Name = "CannyThreshold2Label";
            this.CannyThreshold2Label.Size = new System.Drawing.Size(72, 16);
            this.CannyThreshold2Label.TabIndex = 3;
            this.CannyThreshold2Label.Text = "Threhold 2";
            // 
            // GaussianKsizeLabel
            // 
            this.GaussianKsizeLabel.AutoSize = true;
            this.GaussianKsizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianKsizeLabel.Location = new System.Drawing.Point(133, 42);
            this.GaussianKsizeLabel.Name = "GaussianKsizeLabel";
            this.GaussianKsizeLabel.Size = new System.Drawing.Size(135, 16);
            this.GaussianKsizeLabel.TabIndex = 9;
            this.GaussianKsizeLabel.Text = "Gaussian Kernel Size";
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
            this.GaussianKSizeCmb.Location = new System.Drawing.Point(285, 37);
            this.GaussianKSizeCmb.Name = "GaussianKSizeCmb";
            this.GaussianKSizeCmb.Size = new System.Drawing.Size(70, 26);
            this.GaussianKSizeCmb.TabIndex = 10;
            this.GaussianKSizeCmb.SelectedIndexChanged += new System.EventHandler(this.GaussianKSizeCmb_SelectedIndexChanged);
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.Controls.Add(this.GaussianKsizeLabel);
            this.GaussianBlur.Controls.Add(this.GaussianKSizeCmb);
            this.GaussianBlur.Dock = System.Windows.Forms.DockStyle.Top;
            this.GaussianBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianBlur.Location = new System.Drawing.Point(0, 0);
            this.GaussianBlur.Name = "GaussianBlur";
            this.GaussianBlur.Size = new System.Drawing.Size(747, 90);
            this.GaussianBlur.TabIndex = 11;
            this.GaussianBlur.TabStop = false;
            this.GaussianBlur.Text = "GaussianBlur";
            // 
            // Color
            // 
            this.Color.Controls.Add(this.ColorNeedle);
            this.Color.Controls.Add(this.SaveColorParaButton);
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
            this.Color.Dock = System.Windows.Forms.DockStyle.Top;
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(0, 255);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(747, 236);
            this.Color.TabIndex = 12;
            this.Color.TabStop = false;
            this.Color.Text = "Color";
            // 
            // ColorNeedle
            // 
            this.ColorNeedle.Location = new System.Drawing.Point(136, 176);
            this.ColorNeedle.Name = "ColorNeedle";
            this.ColorNeedle.Size = new System.Drawing.Size(447, 30);
            this.ColorNeedle.TabIndex = 12;
            this.ColorNeedle.TabStop = false;
            this.ColorNeedle.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorNeedle_Paint);
            // 
            // SaveColorParaButton
            // 
            this.SaveColorParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveColorParaButton.Location = new System.Drawing.Point(504, 90);
            this.SaveColorParaButton.Name = "SaveColorParaButton";
            this.SaveColorParaButton.Size = new System.Drawing.Size(79, 31);
            this.SaveColorParaButton.TabIndex = 11;
            this.SaveColorParaButton.Text = "Save";
            this.SaveColorParaButton.UseVisualStyleBackColor = true;
            this.SaveColorParaButton.Click += new System.EventHandler(this.SaveColorParaButton_Click);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueLabel.Location = new System.Drawing.Point(409, 37);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(35, 16);
            this.BlueLabel.TabIndex = 10;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.ForeColor = System.Drawing.Color.Green;
            this.GreenLabel.Location = new System.Drawing.Point(312, 38);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(45, 16);
            this.GreenLabel.TabIndex = 9;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(229, 38);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(34, 16);
            this.RedLabel.TabIndex = 8;
            this.RedLabel.Text = "Red";
            // 
            // HighB
            // 
            this.HighB.Location = new System.Drawing.Point(403, 123);
            this.HighB.Name = "HighB";
            this.HighB.Size = new System.Drawing.Size(45, 24);
            this.HighB.TabIndex = 7;
            this.HighB.Text = "80";
            this.HighB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighB_KeyPress);
            // 
            // HighG
            // 
            this.HighG.Location = new System.Drawing.Point(311, 123);
            this.HighG.Name = "HighG";
            this.HighG.Size = new System.Drawing.Size(45, 24);
            this.HighG.TabIndex = 6;
            this.HighG.Text = "110";
            this.HighG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighG_KeyPress);
            // 
            // HighR
            // 
            this.HighR.Location = new System.Drawing.Point(224, 123);
            this.HighR.Name = "HighR";
            this.HighR.Size = new System.Drawing.Size(45, 24);
            this.HighR.TabIndex = 5;
            this.HighR.Text = "150";
            this.HighR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighR_KeyPress);
            // 
            // LowB
            // 
            this.LowB.Location = new System.Drawing.Point(403, 69);
            this.LowB.Name = "LowB";
            this.LowB.Size = new System.Drawing.Size(45, 24);
            this.LowB.TabIndex = 4;
            this.LowB.Text = "50";
            this.LowB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowB_KeyPress);
            // 
            // LowG
            // 
            this.LowG.Location = new System.Drawing.Point(311, 69);
            this.LowG.Name = "LowG";
            this.LowG.Size = new System.Drawing.Size(45, 24);
            this.LowG.TabIndex = 3;
            this.LowG.Text = "90";
            this.LowG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowG_KeyPress);
            // 
            // LowR
            // 
            this.LowR.Location = new System.Drawing.Point(224, 69);
            this.LowR.Name = "LowR";
            this.LowR.Size = new System.Drawing.Size(45, 24);
            this.LowR.TabIndex = 2;
            this.LowR.Text = "130";
            this.LowR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowR_KeyPress);
            // 
            // LowerbLabel
            // 
            this.LowerbLabel.AutoSize = true;
            this.LowerbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerbLabel.Location = new System.Drawing.Point(133, 74);
            this.LowerbLabel.Name = "LowerbLabel";
            this.LowerbLabel.Size = new System.Drawing.Size(52, 16);
            this.LowerbLabel.TabIndex = 1;
            this.LowerbLabel.Text = "Lowerb";
            // 
            // UpperbLabel
            // 
            this.UpperbLabel.AutoSize = true;
            this.UpperbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperbLabel.Location = new System.Drawing.Point(133, 128);
            this.UpperbLabel.Name = "UpperbLabel";
            this.UpperbLabel.Size = new System.Drawing.Size(54, 16);
            this.UpperbLabel.TabIndex = 0;
            this.UpperbLabel.Text = "Upperb";
            // 
            // CameraParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Canny);
            this.Controls.Add(this.GaussianBlur);
            this.Name = "CameraParaSetting";
            this.Size = new System.Drawing.Size(747, 723);
            this.Canny.ResumeLayout(false);
            this.Canny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).EndInit();
            this.GaussianBlur.ResumeLayout(false);
            this.GaussianBlur.PerformLayout();
            this.Color.ResumeLayout(false);
            this.Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Canny;
        private System.Windows.Forms.TrackBar CannyThreshold1Trackbar;
        private System.Windows.Forms.Label CannyThreshold2Value;
        private System.Windows.Forms.TrackBar CannyThreshold2Trackbar;
        private System.Windows.Forms.Label CannyThreshold1Value;
        private System.Windows.Forms.Label CannyThreshold1Label;
        private System.Windows.Forms.Label CannyThreshold2Label;
        private System.Windows.Forms.Label GaussianKsizeLabel;
        private System.Windows.Forms.ComboBox GaussianKSizeCmb;
        private System.Windows.Forms.GroupBox GaussianBlur;
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
        private System.Windows.Forms.Button SaveColorParaButton;
        private System.Windows.Forms.PictureBox ColorNeedle;
    }
}
