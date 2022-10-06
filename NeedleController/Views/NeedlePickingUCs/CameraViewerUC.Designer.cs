
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CameraControllergroupBox = new System.Windows.Forms.GroupBox();
            this.User_Brightness = new System.Windows.Forms.Label();
            this.User_Contrast = new System.Windows.Forms.Label();
            this.UserBrightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.UserContrastTrackbar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UserBrightnessValue = new System.Windows.Forms.Label();
            this.UserContrastValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceVideo)).BeginInit();
            this.panel1.SuspendLayout();
            this.CameraControllergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserBrightnessTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserContrastTrackbar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.SourceVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // SourceVideo
            // 
            this.SourceVideo.BackColor = System.Drawing.Color.DarkGray;
            this.SourceVideo.BackgroundImage = global::NeedleController.Properties.Resources.Logo_100x100;
            resources.ApplyResources(this.SourceVideo, "SourceVideo");
            this.SourceVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SourceVideo.Name = "SourceVideo";
            this.SourceVideo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CameraControllergroupBox);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CameraControllergroupBox
            // 
            resources.ApplyResources(this.CameraControllergroupBox, "CameraControllergroupBox");
            this.CameraControllergroupBox.Controls.Add(this.tableLayoutPanel2);
            this.CameraControllergroupBox.Name = "CameraControllergroupBox";
            this.CameraControllergroupBox.TabStop = false;
            // 
            // User_Brightness
            // 
            resources.ApplyResources(this.User_Brightness, "User_Brightness");
            this.User_Brightness.Name = "User_Brightness";
            // 
            // User_Contrast
            // 
            resources.ApplyResources(this.User_Contrast, "User_Contrast");
            this.User_Contrast.Name = "User_Contrast";
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
            // UserContrastTrackbar
            // 
            resources.ApplyResources(this.UserContrastTrackbar, "UserContrastTrackbar");
            this.UserContrastTrackbar.Maximum = 100;
            this.UserContrastTrackbar.Name = "UserContrastTrackbar";
            this.UserContrastTrackbar.TickFrequency = 10;
            this.UserContrastTrackbar.Scroll += new System.EventHandler(this.UserContrastTrackbar_Scroll);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.UserContrastValue, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.UserBrightnessValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.UserContrastTrackbar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.UserBrightnessTrackbar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.User_Contrast, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.User_Brightness, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // UserBrightnessValue
            // 
            resources.ApplyResources(this.UserBrightnessValue, "UserBrightnessValue");
            this.UserBrightnessValue.Name = "UserBrightnessValue";
            // 
            // UserContrastValue
            // 
            resources.ApplyResources(this.UserContrastValue, "UserContrastValue");
            this.UserContrastValue.Name = "UserContrastValue";
            // 
            // CameraViewerUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CameraViewerUC";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CameraControllergroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserBrightnessTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserContrastTrackbar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox SourceVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox CameraControllergroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label UserContrastValue;
        private System.Windows.Forms.Label UserBrightnessValue;
        private System.Windows.Forms.TrackBar UserContrastTrackbar;
        private System.Windows.Forms.TrackBar UserBrightnessTrackbar;
        private System.Windows.Forms.Label User_Contrast;
        private System.Windows.Forms.Label User_Brightness;
    }
}
