
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
            this.cultureManager1 = new Infralution.Localization.CultureManager(this.components);
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
            resources.ApplyResources(this.NeedleInformationTabControl, "NeedleInformationTabControl");
            this.NeedleInformationTabControl.Name = "NeedleInformationTabControl";
            this.NeedleInformationTabControl.SelectedIndex = 2;
            this.NeedleInformationTabControl.UseSelectable = true;
            this.NeedleInformationTabControl.SelectedIndexChanged += new System.EventHandler(this.NeedleInformationTabControl_SelectedIndexChanged);
            // 
            // InformationTab
            // 
            this.InformationTab.Controls.Add(this.metroPanel1);
            this.InformationTab.HorizontalScrollbarBarColor = false;
            this.InformationTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InformationTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.InformationTab, "InformationTab");
            this.InformationTab.Name = "InformationTab";
            this.InformationTab.VerticalScrollbarBarColor = false;
            this.InformationTab.VerticalScrollbarHighlightOnWheel = false;
            this.InformationTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.infomationUC1);
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // infomationUC1
            // 
            resources.ApplyResources(this.infomationUC1, "infomationUC1");
            this.infomationUC1.Name = "infomationUC1";
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.metroPanel2);
            this.AddTab.HorizontalScrollbarBarColor = false;
            this.AddTab.HorizontalScrollbarHighlightOnWheel = false;
            this.AddTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.AddTab, "AddTab");
            this.AddTab.Name = "AddTab";
            this.AddTab.VerticalScrollbarBarColor = false;
            this.AddTab.VerticalScrollbarHighlightOnWheel = false;
            this.AddTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.addUC1);
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // addUC1
            // 
            resources.ApplyResources(this.addUC1, "addUC1");
            this.addUC1.Name = "addUC1";
            // 
            // ModifyTab
            // 
            this.ModifyTab.Controls.Add(this.metroPanel3);
            this.ModifyTab.HorizontalScrollbarBarColor = false;
            this.ModifyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ModifyTab.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.ModifyTab, "ModifyTab");
            this.ModifyTab.Name = "ModifyTab";
            this.ModifyTab.VerticalScrollbarBarColor = false;
            this.ModifyTab.VerticalScrollbarHighlightOnWheel = false;
            this.ModifyTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.modifyUC1);
            resources.ApplyResources(this.metroPanel3, "metroPanel3");
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // modifyUC1
            // 
            resources.ApplyResources(this.modifyUC1, "modifyUC1");
            this.modifyUC1.Name = "modifyUC1";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cultureManager1
            // 
            this.cultureManager1.ManagedControl = this;
            // 
            // NeedleInfoView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeedleInformationTabControl);
            this.MinimizeBox = false;
            this.Name = "NeedleInfoView";
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
        private Infralution.Localization.CultureManager cultureManager1;
    }
}