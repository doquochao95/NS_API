
namespace NeedleController.Views.NeedlePickingUCs
{
    partial class DeviceToolboxUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceToolboxUC));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ResetDeviceLabel = new System.Windows.Forms.ToolStripLabel();
            this.ResetDeviceButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ParkingDeviceLabel = new System.Windows.Forms.ToolStripLabel();
            this.ParkingDeviceButton = new System.Windows.Forms.ToolStripButton();
            this.UnparkingDeviceButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.MachineLightLabel = new System.Windows.Forms.ToolStripLabel();
            this.MachineLightOnButton = new System.Windows.Forms.ToolStripButton();
            this.MachineLightOffButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TableLightOnButton = new System.Windows.Forms.ToolStripButton();
            this.TableLightOffButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.IdLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel1.Controls.Add(this.toolStrip2);
            this.flowLayoutPanel1.Controls.Add(this.IdLabel);
            this.flowLayoutPanel1.Controls.Add(this.UserNameLabel);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetDeviceLabel,
            this.ResetDeviceButton,
            this.toolStripSeparator1,
            this.ParkingDeviceLabel,
            this.ParkingDeviceButton,
            this.UnparkingDeviceButton});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // ResetDeviceLabel
            // 
            resources.ApplyResources(this.ResetDeviceLabel, "ResetDeviceLabel");
            this.ResetDeviceLabel.Name = "ResetDeviceLabel";
            // 
            // ResetDeviceButton
            // 
            resources.ApplyResources(this.ResetDeviceButton, "ResetDeviceButton");
            this.ResetDeviceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetDeviceButton.Image = global::NeedleController.Properties.Resources.ResetIcon;
            this.ResetDeviceButton.Name = "ResetDeviceButton";
            this.ResetDeviceButton.Click += new System.EventHandler(this.ResetDeviceButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // ParkingDeviceLabel
            // 
            resources.ApplyResources(this.ParkingDeviceLabel, "ParkingDeviceLabel");
            this.ParkingDeviceLabel.Name = "ParkingDeviceLabel";
            // 
            // ParkingDeviceButton
            // 
            resources.ApplyResources(this.ParkingDeviceButton, "ParkingDeviceButton");
            this.ParkingDeviceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ParkingDeviceButton.Image = global::NeedleController.Properties.Resources.ParkingIcon;
            this.ParkingDeviceButton.Name = "ParkingDeviceButton";
            this.ParkingDeviceButton.Click += new System.EventHandler(this.ParkingDeviceButton_Click);
            // 
            // UnparkingDeviceButton
            // 
            resources.ApplyResources(this.UnparkingDeviceButton, "UnparkingDeviceButton");
            this.UnparkingDeviceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnparkingDeviceButton.Image = global::NeedleController.Properties.Resources.UnParkingIcon;
            this.UnparkingDeviceButton.Name = "UnparkingDeviceButton";
            this.UnparkingDeviceButton.Click += new System.EventHandler(this.UnparkingDeviceButton_Click);
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MachineLightLabel,
            this.MachineLightOnButton,
            this.MachineLightOffButton,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.TableLightOnButton,
            this.TableLightOffButton,
            this.toolStripSeparator3});
            this.toolStrip2.Name = "toolStrip2";
            // 
            // MachineLightLabel
            // 
            resources.ApplyResources(this.MachineLightLabel, "MachineLightLabel");
            this.MachineLightLabel.Name = "MachineLightLabel";
            // 
            // MachineLightOnButton
            // 
            resources.ApplyResources(this.MachineLightOnButton, "MachineLightOnButton");
            this.MachineLightOnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MachineLightOnButton.Image = global::NeedleController.Properties.Resources.MachineLightIconON;
            this.MachineLightOnButton.Name = "MachineLightOnButton";
            this.MachineLightOnButton.Click += new System.EventHandler(this.MachineLightOnButton_Click);
            // 
            // MachineLightOffButton
            // 
            resources.ApplyResources(this.MachineLightOffButton, "MachineLightOffButton");
            this.MachineLightOffButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MachineLightOffButton.Image = global::NeedleController.Properties.Resources.MachineLightIconOFF;
            this.MachineLightOffButton.Name = "MachineLightOffButton";
            this.MachineLightOffButton.Click += new System.EventHandler(this.MachineLightOffButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // TableLightOnButton
            // 
            resources.ApplyResources(this.TableLightOnButton, "TableLightOnButton");
            this.TableLightOnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TableLightOnButton.Image = global::NeedleController.Properties.Resources.TableLightIconON;
            this.TableLightOnButton.Name = "TableLightOnButton";
            this.TableLightOnButton.Click += new System.EventHandler(this.TableLightOnButton_Click);
            // 
            // TableLightOffButton
            // 
            resources.ApplyResources(this.TableLightOffButton, "TableLightOffButton");
            this.TableLightOffButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TableLightOffButton.Image = global::NeedleController.Properties.Resources.TableLightIconOFF;
            this.TableLightOffButton.Name = "TableLightOffButton";
            this.TableLightOffButton.Click += new System.EventHandler(this.TableLightOffButton_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // IdLabel
            // 
            resources.ApplyResources(this.IdLabel, "IdLabel");
            this.IdLabel.Name = "IdLabel";
            // 
            // UserNameLabel
            // 
            resources.ApplyResources(this.UserNameLabel, "UserNameLabel");
            this.UserNameLabel.Name = "UserNameLabel";
            // 
            // DeviceToolboxUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DeviceToolboxUC";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ResetDeviceLabel;
        private System.Windows.Forms.ToolStripButton ResetDeviceButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ParkingDeviceLabel;
        private System.Windows.Forms.ToolStripButton ParkingDeviceButton;
        private System.Windows.Forms.ToolStripButton UnparkingDeviceButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel MachineLightLabel;
        private System.Windows.Forms.ToolStripButton MachineLightOnButton;
        private System.Windows.Forms.ToolStripButton MachineLightOffButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton TableLightOnButton;
        private System.Windows.Forms.ToolStripButton TableLightOffButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
