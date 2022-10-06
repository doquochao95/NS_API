namespace NeedleController.Views
{
    partial class RecycleBinView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.RecycleBindataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.informationRecycleBinUC1 = new NeedleController.Views.RecycleBinUCs.InformationRecycleBinUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.MachineStatusDevice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecycleBindataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RecycleBindataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Maximum = 80;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Step = 1;
            // 
            // RecycleBindataGridView
            // 
            resources.ApplyResources(this.RecycleBindataGridView, "RecycleBindataGridView");
            this.RecycleBindataGridView.AllowUserToAddRows = false;
            this.RecycleBindataGridView.AllowUserToDeleteRows = false;
            this.RecycleBindataGridView.AllowUserToResizeColumns = false;
            this.RecycleBindataGridView.AllowUserToResizeRows = false;
            this.RecycleBindataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecycleBindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecycleBindataGridView.Name = "RecycleBindataGridView";
            this.RecycleBindataGridView.ReadOnly = true;
            this.RecycleBindataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RecycleBindataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecycleBindataGridView.SelectionChanged += new System.EventHandler(this.RecycleBindataGridView_SelectionChanged);
            this.RecycleBindataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RecycleBindataGridView_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.informationRecycleBinUC1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // informationRecycleBinUC1
            // 
            this.informationRecycleBinUC1._brokentimeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationRecycleBinUC1._brokentimestr = "*brokentime";
            this.informationRecycleBinUC1._capturedimage = null;
            this.informationRecycleBinUC1._confirmationBy = "*confirm";
            this.informationRecycleBinUC1._confirmationTime = "*at";
            this.informationRecycleBinUC1._devicename = "metroLabel7";
            this.informationRecycleBinUC1._exporttimestr = "metroLabel11";
            this.informationRecycleBinUC1._handle = "";
            this.informationRecycleBinUC1._line = "*line";
            this.informationRecycleBinUC1._needlename = "metroLabel6";
            this.informationRecycleBinUC1._operator = "*worker";
            this.informationRecycleBinUC1._partenough = "*enough/not";
            this.informationRecycleBinUC1._po = "*po";
            this.informationRecycleBinUC1._procsess = "*process";
            this.informationRecycleBinUC1._reason = "*reason";
            this.informationRecycleBinUC1._sewingmachine = "*machine";
            this.informationRecycleBinUC1._staffname = "metroLabel12";
            resources.ApplyResources(this.informationRecycleBinUC1, "informationRecycleBinUC1");
            this.tableLayoutPanel2.SetColumnSpan(this.informationRecycleBinUC1, 2);
            this.informationRecycleBinUC1.Name = "informationRecycleBinUC1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.UserInfoLabel);
            this.panel1.Controls.Add(this.MachineStatusDevice);
            this.panel1.Name = "panel1";
            // 
            // UserInfoLabel
            // 
            resources.ApplyResources(this.UserInfoLabel, "UserInfoLabel");
            this.UserInfoLabel.Name = "UserInfoLabel";
            // 
            // MachineStatusDevice
            // 
            resources.ApplyResources(this.MachineStatusDevice, "MachineStatusDevice");
            this.MachineStatusDevice.Name = "MachineStatusDevice";
            // 
            // RecycleBinView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecycleBinView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecycleBinView_FormClosed);
            this.Load += new System.EventHandler(this.RecycleBinView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecycleBindataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView RecycleBindataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserInfoLabel;
        private System.Windows.Forms.Label MachineStatusDevice;
        private System.Windows.Forms.ProgressBar progressBar1;
        private RecycleBinUCs.InformationRecycleBinUC informationRecycleBinUC1;
    }
}