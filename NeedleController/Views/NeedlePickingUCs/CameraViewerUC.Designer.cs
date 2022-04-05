
namespace NeedleController.Views.NeedlePickingUCs
{
    partial class CameraViewerUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraViewerUC));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SourceVideo = new System.Windows.Forms.PictureBox();
            this.DestVideo = new System.Windows.Forms.PictureBox();
            this.CameraControllergroupBox = new System.Windows.Forms.GroupBox();
            this.UserContrastValue = new System.Windows.Forms.Label();
            this.UserBrightnessValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User_Contrast = new System.Windows.Forms.Label();
            this.User_Brightness = new System.Windows.Forms.Label();
            this.UserContrastTrackbar = new System.Windows.Forms.TrackBar();
            this.UserBrightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).BeginInit();
            this.CameraControllergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserContrastTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBrightnessTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.SourceVideo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DestVideo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CameraControllergroupBox, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // SourceVideo
            // 
            this.SourceVideo.BackColor = System.Drawing.Color.DarkGray;
            this.SourceVideo.BackgroundImage = global::NeedleController.Properties.Resources.Techlogo;
            resources.ApplyResources(this.SourceVideo, "SourceVideo");
            this.SourceVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SourceVideo.Name = "SourceVideo";
            this.SourceVideo.TabStop = false;
            // 
            // DestVideo
            // 
            this.DestVideo.BackColor = System.Drawing.Color.DarkGray;
            this.DestVideo.BackgroundImage = global::NeedleController.Properties.Resources.Techlogo;
            resources.ApplyResources(this.DestVideo, "DestVideo");
            this.DestVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DestVideo.Name = "DestVideo";
            this.DestVideo.TabStop = false;
            // 
            // CameraControllergroupBox
            // 
            resources.ApplyResources(this.CameraControllergroupBox, "CameraControllergroupBox");
            this.CameraControllergroupBox.Controls.Add(this.UserContrastValue);
            this.CameraControllergroupBox.Controls.Add(this.UserBrightnessValue);
            this.CameraControllergroupBox.Controls.Add(this.label4);
            this.CameraControllergroupBox.Controls.Add(this.label3);
            this.CameraControllergroupBox.Controls.Add(this.User_Contrast);
            this.CameraControllergroupBox.Controls.Add(this.User_Brightness);
            this.CameraControllergroupBox.Controls.Add(this.UserContrastTrackbar);
            this.CameraControllergroupBox.Controls.Add(this.UserBrightnessTrackbar);
            this.CameraControllergroupBox.Name = "CameraControllergroupBox";
            this.CameraControllergroupBox.TabStop = false;
            // 
            // UserContrastValue
            // 
            resources.ApplyResources(this.UserContrastValue, "UserContrastValue");
            this.UserContrastValue.Name = "UserContrastValue";
            // 
            // UserBrightnessValue
            // 
            resources.ApplyResources(this.UserBrightnessValue, "UserBrightnessValue");
            this.UserBrightnessValue.Name = "UserBrightnessValue";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // User_Contrast
            // 
            resources.ApplyResources(this.User_Contrast, "User_Contrast");
            this.User_Contrast.Name = "User_Contrast";
            // 
            // User_Brightness
            // 
            resources.ApplyResources(this.User_Brightness, "User_Brightness");
            this.User_Brightness.Name = "User_Brightness";
            // 
            // UserContrastTrackbar
            // 
            resources.ApplyResources(this.UserContrastTrackbar, "UserContrastTrackbar");
            this.UserContrastTrackbar.Maximum = 100;
            this.UserContrastTrackbar.Name = "UserContrastTrackbar";
            this.UserContrastTrackbar.TickFrequency = 10;
            this.UserContrastTrackbar.Scroll += new System.EventHandler(this.UserContrastTrackbar_Scroll);
            // 
            // UserBrightnessTrackbar
            // 
            resources.ApplyResources(this.UserBrightnessTrackbar, "UserBrightnessTrackbar");
            this.UserBrightnessTrackbar.Maximum = 100;
            this.UserBrightnessTrackbar.Minimum = -100;
            this.UserBrightnessTrackbar.Name = "UserBrightnessTrackbar";
            this.UserBrightnessTrackbar.TickFrequency = 10;
            this.UserBrightnessTrackbar.Scroll += new System.EventHandler(this.UserBrightnessTrackbar_Scroll);
            // 
            // CameraViewerUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CameraViewerUC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).EndInit();
            this.CameraControllergroupBox.ResumeLayout(false);
            this.CameraControllergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserContrastTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBrightnessTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox SourceVideo;
        private System.Windows.Forms.PictureBox DestVideo;
        private System.Windows.Forms.GroupBox CameraControllergroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label User_Contrast;
        private System.Windows.Forms.Label User_Brightness;
        private System.Windows.Forms.TrackBar UserContrastTrackbar;
        private System.Windows.Forms.TrackBar UserBrightnessTrackbar;
        private System.Windows.Forms.Label UserContrastValue;
        private System.Windows.Forms.Label UserBrightnessValue;
    }
}
