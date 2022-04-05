
namespace NeedleController.Views
{
    partial class NeedleInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeedleInfoView));
            this.NeedleInformationTabControl = new MetroFramework.Controls.MetroTabControl();
            this.InformationTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.infomationUC1 = new NeedleController.Views.NeedleInfoUCs.InfomationUC();
            this.AddTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.addUC1 = new NeedleController.Views.NeedleInfoUCs.AddUC();
            this.ModifyTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.modifyUC1 = new NeedleController.Views.NeedleInfoUCs.ModifyUC();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.NeedleInformationTabControl.SuspendLayout();
            this.InformationTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.ModifyTab.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NeedleInformationTabControl
            // 
            this.NeedleInformationTabControl.Controls.Add(this.InformationTab);
            this.NeedleInformationTabControl.Controls.Add(this.AddTab);
            this.NeedleInformationTabControl.Controls.Add(this.ModifyTab);
            this.NeedleInformationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleInformationTabControl.ItemSize = new System.Drawing.Size(80, 35);
            this.NeedleInformationTabControl.Location = new System.Drawing.Point(0, 0);
            this.NeedleInformationTabControl.Name = "NeedleInformationTabControl";
            this.NeedleInformationTabControl.SelectedIndex = 2;
            this.NeedleInformationTabControl.Size = new System.Drawing.Size(984, 661);
            this.NeedleInformationTabControl.TabIndex = 0;
            this.NeedleInformationTabControl.UseSelectable = true;
            this.NeedleInformationTabControl.SelectedIndexChanged += new System.EventHandler(this.NeedleInformationTabControl_SelectedIndexChanged);
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.metroPanel1);
            this.InformationTab.HorizontalScrollbarBarColor = false;
            this.InformationTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InformationTab.HorizontalScrollbarSize = 10;
            this.InformationTab.Location = new System.Drawing.Point(4, 39);
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.Size = new System.Drawing.Size(976, 618);
            this.InformationTab.TabIndex = 0;
            this.InformationTab.Text = "Information";
            this.InformationTab.VerticalScrollbarBarColor = false;
            this.InformationTab.VerticalScrollbarHighlightOnWheel = false;
            this.InformationTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.infomationUC1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel1.Size = new System.Drawing.Size(976, 618);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // infomationUC1
            // 
            this.infomationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infomationUC1.Location = new System.Drawing.Point(10, 10);
            this.infomationUC1.MinimumSize = new System.Drawing.Size(881, 469);
            this.infomationUC1.Name = "infomationUC1";
            this.infomationUC1.Size = new System.Drawing.Size(956, 598);
            this.infomationUC1.TabIndex = 2;
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.metroPanel2);
            this.AddTab.HorizontalScrollbarBarColor = false;
            this.AddTab.HorizontalScrollbarHighlightOnWheel = false;
            this.AddTab.HorizontalScrollbarSize = 10;
            this.AddTab.Location = new System.Drawing.Point(4, 39);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(976, 618);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "Add";
            this.AddTab.VerticalScrollbarBarColor = false;
            this.AddTab.VerticalScrollbarHighlightOnWheel = false;
            this.AddTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.addUC1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel2.Size = new System.Drawing.Size(976, 618);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // addUC1
            // 
            this.addUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUC1.Location = new System.Drawing.Point(10, 10);
            this.addUC1.MinimumSize = new System.Drawing.Size(830, 491);
            this.addUC1.Name = "addUC1";
            this.addUC1.Size = new System.Drawing.Size(956, 598);
            this.addUC1.TabIndex = 2;
            // 
            // ModifyTab
            // 
            this.ModifyTab.Controls.Add(this.metroPanel3);
            this.ModifyTab.HorizontalScrollbarBarColor = false;
            this.ModifyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ModifyTab.HorizontalScrollbarSize = 10;
            this.ModifyTab.Location = new System.Drawing.Point(4, 39);
            this.ModifyTab.Name = "ModifyTab";
            this.ModifyTab.Size = new System.Drawing.Size(976, 618);
            this.ModifyTab.TabIndex = 2;
            this.ModifyTab.Text = "Modify";
            this.ModifyTab.VerticalScrollbarBarColor = false;
            this.ModifyTab.VerticalScrollbarHighlightOnWheel = false;
            this.ModifyTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.modifyUC1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel3.Size = new System.Drawing.Size(976, 618);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // modifyUC1
            // 
            this.modifyUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyUC1.Location = new System.Drawing.Point(10, 10);
            this.modifyUC1.MinimumSize = new System.Drawing.Size(830, 491);
            this.modifyUC1.Name = "modifyUC1";
            this.modifyUC1.Size = new System.Drawing.Size(956, 598);
            this.modifyUC1.TabIndex = 2;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // NeedleInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.NeedleInformationTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "NeedleInfoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedleInfoView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NeedleInfoView_FormClosed);
            this.Load += new System.EventHandler(this.NeedleInfoView_Load);
            this.NeedleInformationTabControl.ResumeLayout(false);
            this.InformationTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ModifyTab.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage AddTab;
        private MetroFramework.Controls.MetroTabPage ModifyTab;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private NeedleInfoUCs.InfomationUC infomationUC1;
        private MetroFramework.Controls.MetroTabPage InformationTab;
        private MetroFramework.Controls.MetroTabControl NeedleInformationTabControl;
        private NeedleInfoUCs.AddUC addUC1;
        private NeedleInfoUCs.ModifyUC modifyUC1;
        private System.Windows.Forms.Timer Timer1;
    }
}