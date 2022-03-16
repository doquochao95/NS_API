
namespace NeedleController.Views
{
    partial class CameraSettingView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CannyVideo = new System.Windows.Forms.PictureBox();
            this.cameraParaSetting1 = new NeedleController.Views.CameraSettingUCs.CameraParaSetting();
            this.OutputVideo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.CannyVideo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cameraParaSetting1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputVideo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CannyVideo
            // 
            this.CannyVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CannyVideo.Image = global::NeedleController.Properties.Resources.Techlogo;
            this.CannyVideo.Location = new System.Drawing.Point(789, 396);
            this.CannyVideo.Margin = new System.Windows.Forms.Padding(30);
            this.CannyVideo.Name = "CannyVideo";
            this.CannyVideo.Size = new System.Drawing.Size(442, 300);
            this.CannyVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CannyVideo.TabIndex = 5;
            this.CannyVideo.TabStop = false;
            // 
            // cameraParaSetting1
            // 
            this.cameraParaSetting1.CannyThreshold1 = 0;
            this.cameraParaSetting1.CannyThreshold2 = 0;
            this.cameraParaSetting1.ColorHighB = 0;
            this.cameraParaSetting1.ColorHighG = 0;
            this.cameraParaSetting1.ColorHighR = 0;
            this.cameraParaSetting1.ColorLowB = 0;
            this.cameraParaSetting1.ColorLowG = 0;
            this.cameraParaSetting1.ColorLowR = 0;
            this.cameraParaSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraParaSetting1.GaussianBlurKsize = 1;
            this.cameraParaSetting1.Location = new System.Drawing.Point(6, 6);
            this.cameraParaSetting1.Name = "cameraParaSetting1";
            this.cameraParaSetting1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.SetRowSpan(this.cameraParaSetting1, 2);
            this.cameraParaSetting1.Size = new System.Drawing.Size(747, 717);
            this.cameraParaSetting1.TabIndex = 3;
            // 
            // OutputVideo
            // 
            this.OutputVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputVideo.Image = global::NeedleController.Properties.Resources.Techlogo;
            this.OutputVideo.Location = new System.Drawing.Point(789, 33);
            this.OutputVideo.Margin = new System.Windows.Forms.Padding(30);
            this.OutputVideo.Name = "OutputVideo";
            this.OutputVideo.Size = new System.Drawing.Size(442, 300);
            this.OutputVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OutputVideo.TabIndex = 4;
            this.OutputVideo.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // CameraSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "CameraSettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraSettingView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraSettingView_FormClosed);
            this.Load += new System.EventHandler(this.CameraSettingView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CannyVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox CannyVideo;
        private System.Windows.Forms.PictureBox OutputVideo;
        private CameraSettingUCs.CameraParaSetting cameraParaSetting1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}