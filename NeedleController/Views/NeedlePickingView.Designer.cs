
namespace NeedleController.Views
{
    partial class NeedlePickingView
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
            this.deviceToolboxUC1 = new NeedleController.Views.NeedlePickingUCs.DeviceToolboxUC();
            this.cameraViewerUC1 = new NeedleController.Views.NeedlePickingUCs.CameraViewerUC();
            this.needleSearchingUC1 = new NeedleController.Views.NeedlePickingUCs.NeedleSearchingUC();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.deviceToolboxUC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cameraViewerUC1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.needleSearchingUC1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 729);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // deviceToolboxUC1
            // 
            this.deviceToolboxUC1.AutoSize = true;
            this.deviceToolboxUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.deviceToolboxUC1, 3);
            this.deviceToolboxUC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceToolboxUC1.Location = new System.Drawing.Point(3, 3);
            this.deviceToolboxUC1.Name = "deviceToolboxUC1";
            this.deviceToolboxUC1.Padding = new System.Windows.Forms.Padding(2);
            this.deviceToolboxUC1.Size = new System.Drawing.Size(1258, 39);
            this.deviceToolboxUC1.TabIndex = 0;
            // 
            // cameraViewerUC1
            // 
            this.cameraViewerUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.cameraViewerUC1, 2);
            this.cameraViewerUC1.destVideo = null;
            this.cameraViewerUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraViewerUC1.imgHeight = 196;
            this.cameraViewerUC1.imgWidth = 295;
            this.cameraViewerUC1.Location = new System.Drawing.Point(3, 504);
            this.cameraViewerUC1.Name = "cameraViewerUC1";
            this.cameraViewerUC1.Padding = new System.Windows.Forms.Padding(2);
            this.cameraViewerUC1.Size = new System.Drawing.Size(953, 222);
            this.cameraViewerUC1.sourceVideo = null;
            this.cameraViewerUC1.TabIndex = 1;
            this.cameraViewerUC1.userBrightness = 0;
            this.cameraViewerUC1.userContrast = 1F;
            // 
            // needleSearchingUC1
            // 
            this.needleSearchingUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.needleSearchingUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.needleSearchingUC1.Location = new System.Drawing.Point(962, 504);
            this.needleSearchingUC1.Name = "needleSearchingUC1";
            this.needleSearchingUC1.Padding = new System.Windows.Forms.Padding(10);
            this.needleSearchingUC1.Size = new System.Drawing.Size(299, 222);
            this.needleSearchingUC1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(953, 450);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(962, 48);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(299, 450);
            this.panel1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 428);
            this.listBox1.TabIndex = 0;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 50;
            // 
            // NeedlePickingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "NeedlePickingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedlePickingView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NeedlePickingView_FormClosed);
            this.Load += new System.EventHandler(this.NeedlePickingView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NeedlePickingUCs.DeviceToolboxUC deviceToolboxUC1;
        private NeedlePickingUCs.CameraViewerUC cameraViewerUC1;
        private NeedlePickingUCs.NeedleSearchingUC needleSearchingUC1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}