namespace NeedleController.Views
{
    partial class ImageReplaceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageReplaceView));
            this.destVideotimer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CapturedNeedleLenghtLabel = new System.Windows.Forms.Label();
            this.CaptureImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DestVideo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SelectedNeedleLengthLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.SelectedNeedleLengthLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CapturedNeedleLenghtLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.CaptureImagePictureBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DestVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // CapturedNeedleLenghtLabel
            // 
            resources.ApplyResources(this.CapturedNeedleLenghtLabel, "CapturedNeedleLenghtLabel");
            this.CapturedNeedleLenghtLabel.Name = "CapturedNeedleLenghtLabel";
            // 
            // CaptureImagePictureBox
            // 
            this.CaptureImagePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.CaptureImagePictureBox.BackgroundImage = global::NeedleController.Properties.Resources.Logo_100x100;
            resources.ApplyResources(this.CaptureImagePictureBox, "CaptureImagePictureBox");
            this.CaptureImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.CaptureImagePictureBox, 2);
            this.CaptureImagePictureBox.Name = "CaptureImagePictureBox";
            this.CaptureImagePictureBox.TabStop = false;
            // 
            // DestVideo
            // 
            this.DestVideo.BackColor = System.Drawing.Color.DarkGray;
            this.DestVideo.BackgroundImage = global::NeedleController.Properties.Resources.Logo_100x100;
            resources.ApplyResources(this.DestVideo, "DestVideo");
            this.DestVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.DestVideo, 2);
            this.DestVideo.Name = "DestVideo";
            this.DestVideo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ConfirmButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CaptureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExitButton, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.ConfirmButton, "ConfirmButton");
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CaptureButton
            // 
            this.CaptureButton.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.CaptureButton, "CaptureButton");
            this.CaptureButton.FlatAppearance.BorderSize = 0;
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.UseVisualStyleBackColor = false;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Wheat;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.tableLayoutPanel1.SetColumnSpan(this.StatusLabel, 2);
            this.StatusLabel.Name = "StatusLabel";
            // 
            // SelectedNeedleLengthLabel
            // 
            resources.ApplyResources(this.SelectedNeedleLengthLabel, "SelectedNeedleLengthLabel");
            this.SelectedNeedleLengthLabel.Name = "SelectedNeedleLengthLabel";
            // 
            // ImageReplaceView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageReplaceView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageReplaceView_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer destVideotimer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox CaptureImagePictureBox;
        private System.Windows.Forms.PictureBox DestVideo;
        private System.Windows.Forms.Label CapturedNeedleLenghtLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label SelectedNeedleLengthLabel;
    }
}