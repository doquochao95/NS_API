namespace NeedleController.Views
{
    partial class EditInformationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInformationView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.HandleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessComboBox = new System.Windows.Forms.ComboBox();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.MachineLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MachineTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BrokenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BrokenDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.HandleTextBox, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.ProcessComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.OperatorLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OperatorTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MachineLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ReasonLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ProcessLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.MachineTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.ReasonComboBox, 1, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // HandleTextBox
            // 
            resources.ApplyResources(this.HandleTextBox, "HandleTextBox");
            this.HandleTextBox.Name = "HandleTextBox";
            this.tableLayoutPanel2.SetRowSpan(this.HandleTextBox, 3);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ProcessComboBox
            // 
            resources.ApplyResources(this.ProcessComboBox, "ProcessComboBox");
            this.ProcessComboBox.FormattingEnabled = true;
            this.ProcessComboBox.Name = "ProcessComboBox";
            // 
            // OperatorLabel
            // 
            resources.ApplyResources(this.OperatorLabel, "OperatorLabel");
            this.OperatorLabel.Name = "OperatorLabel";
            // 
            // OperatorTextBox
            // 
            resources.ApplyResources(this.OperatorTextBox, "OperatorTextBox");
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operator_KeyPress);
            // 
            // MachineLabel
            // 
            resources.ApplyResources(this.MachineLabel, "MachineLabel");
            this.MachineLabel.Name = "MachineLabel";
            // 
            // ReasonLabel
            // 
            resources.ApplyResources(this.ReasonLabel, "ReasonLabel");
            this.ReasonLabel.Name = "ReasonLabel";
            // 
            // ProcessLabel
            // 
            resources.ApplyResources(this.ProcessLabel, "ProcessLabel");
            this.ProcessLabel.Name = "ProcessLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // MachineTextBox
            // 
            resources.ApplyResources(this.MachineTextBox, "MachineTextBox");
            this.MachineTextBox.Name = "MachineTextBox";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BrokenTimePicker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BrokenDatePicker, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 3);
            // 
            // BrokenTimePicker
            // 
            resources.ApplyResources(this.BrokenTimePicker, "BrokenTimePicker");
            this.BrokenTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BrokenTimePicker.Name = "BrokenTimePicker";
            this.BrokenTimePicker.ShowUpDown = true;
            // 
            // BrokenDatePicker
            // 
            resources.ApplyResources(this.BrokenDatePicker, "BrokenDatePicker");
            this.BrokenDatePicker.Name = "BrokenDatePicker";
            // 
            // ReasonComboBox
            // 
            resources.ApplyResources(this.ReasonComboBox, "ReasonComboBox");
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.SelectedIndexChanged += new System.EventHandler(this.ReasonComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.ExitButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SaveButton, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Wheat;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditInformationView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInformationView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditInformation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HandleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProcessComboBox;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.TextBox OperatorTextBox;
        private System.Windows.Forms.Label MachineLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MachineTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker BrokenTimePicker;
        private System.Windows.Forms.DateTimePicker BrokenDatePicker;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
    }
}