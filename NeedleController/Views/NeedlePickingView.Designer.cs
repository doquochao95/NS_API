
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeedlePickingView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.deviceToolboxUC1 = new NeedleController.Views.NeedlePickingUCs.DeviceToolboxUC();
            this.cameraViewerUC1 = new NeedleController.Views.NeedlePickingUCs.CameraViewerUC();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.deviceToolboxUC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cameraViewerUC1, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 2);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 200;
            // 
            // deviceToolboxUC1
            // 
            resources.ApplyResources(this.deviceToolboxUC1, "deviceToolboxUC1");
            this.deviceToolboxUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deviceToolboxUC1.Name = "deviceToolboxUC1";
            // 
            // cameraViewerUC1
            // 
            this.cameraViewerUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.cameraViewerUC1, "cameraViewerUC1");
            this.cameraViewerUC1.imgHeight = 238;
            this.cameraViewerUC1.imgWidth = 368;
            this.cameraViewerUC1.Name = "cameraViewerUC1";
            this.cameraViewerUC1.sourceVideo = null;
            this.cameraViewerUC1.userBrightness = 0;
            this.cameraViewerUC1.userContrast = 1F;
            // 
            // NeedlePickingView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "NeedlePickingView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NeedlePickingView_FormClosed);
            this.Load += new System.EventHandler(this.NeedlePickingView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer Timer1;
        private NeedlePickingUCs.CameraViewerUC cameraViewerUC1;
        private NeedlePickingUCs.DeviceToolboxUC deviceToolboxUC1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}