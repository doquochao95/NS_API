
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deviceToolboxUC1 = new NeedleController.Views.NeedlePickingUCs.DeviceToolboxUC();
            this.cameraViewerUC1 = new NeedleController.Views.NeedlePickingUCs.CameraViewerUC();
            this.needleSearchingUC1 = new NeedleController.Views.NeedlePickingUCs.NeedleSearchingUC();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.51938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48062F));
            this.tableLayoutPanel1.Controls.Add(this.deviceToolboxUC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cameraViewerUC1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.needleSearchingUC1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
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
            this.cameraViewerUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraViewerUC1.Location = new System.Drawing.Point(3, 504);
            this.cameraViewerUC1.Name = "cameraViewerUC1";
            this.cameraViewerUC1.Padding = new System.Windows.Forms.Padding(2);
            this.cameraViewerUC1.Size = new System.Drawing.Size(1030, 222);
            this.cameraViewerUC1.TabIndex = 1;
            // 
            // needleSearchingUC1
            // 
            this.needleSearchingUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.needleSearchingUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.needleSearchingUC1.Location = new System.Drawing.Point(1039, 504);
            this.needleSearchingUC1.Name = "needleSearchingUC1";
            this.needleSearchingUC1.Padding = new System.Windows.Forms.Padding(10);
            this.needleSearchingUC1.Size = new System.Drawing.Size(222, 222);
            this.needleSearchingUC1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1258, 450);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.Load += new System.EventHandler(this.NeedlePickingView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NeedlePickingUCs.DeviceToolboxUC deviceToolboxUC1;
        private NeedlePickingUCs.CameraViewerUC cameraViewerUC1;
        private NeedlePickingUCs.NeedleSearchingUC needleSearchingUC1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}