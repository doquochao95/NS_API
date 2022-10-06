namespace NeedleController.Views
{
    partial class MachineProcessView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineProcessView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuccessButton = new System.Windows.Forms.Button();
            this.SelectedNeedleLegnthLabel = new System.Windows.Forms.Label();
            this.CapturedNeedleLenghtLabel = new System.Windows.Forms.Label();
            this.CaptureImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProcessStatusLabel = new System.Windows.Forms.Label();
            this.DestVideo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FailButton = new System.Windows.Forms.Button();
            this.InputInformationGroupBox = new System.Windows.Forms.GroupBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.destVideotimer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).BeginInit();
            this.InputInformationGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.timerLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SuccessButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectedNeedleLegnthLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CapturedNeedleLenghtLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CaptureImagePictureBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContinueButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProcessStatusLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DestVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.FailButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.InputInformationGroupBox, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // timerLabel
            // 
            resources.ApplyResources(this.timerLabel, "timerLabel");
            this.timerLabel.Name = "timerLabel";
            // 
            // SuccessButton
            // 
            resources.ApplyResources(this.SuccessButton, "SuccessButton");
            this.SuccessButton.Name = "SuccessButton";
            this.SuccessButton.UseVisualStyleBackColor = true;
            this.SuccessButton.Click += new System.EventHandler(this.SuccessButton_Click);
            // 
            // SelectedNeedleLegnthLabel
            // 
            resources.ApplyResources(this.SelectedNeedleLegnthLabel, "SelectedNeedleLegnthLabel");
            this.SelectedNeedleLegnthLabel.Name = "SelectedNeedleLegnthLabel";
            // 
            // CapturedNeedleLenghtLabel
            // 
            resources.ApplyResources(this.CapturedNeedleLenghtLabel, "CapturedNeedleLenghtLabel");
            this.CapturedNeedleLenghtLabel.Name = "CapturedNeedleLenghtLabel";
            // 
            // CaptureImagePictureBox
            // 
            this.CaptureImagePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.CaptureImagePictureBox.BackgroundImage = global::NeedleController.Properties.Resources.Logo_100x100;
            resources.ApplyResources(this.CaptureImagePictureBox, "CaptureImagePictureBox");
            this.CaptureImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.CaptureImagePictureBox, 2);
            this.CaptureImagePictureBox.Name = "CaptureImagePictureBox";
            this.CaptureImagePictureBox.TabStop = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.ContinueButton, 2);
            resources.ApplyResources(this.ContinueButton, "ContinueButton");
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.SetColumnSpan(this.CancelButton, 2);
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessStatusLabel
            // 
            this.ProcessStatusLabel.AllowDrop = true;
            this.ProcessStatusLabel.AutoEllipsis = true;
            resources.ApplyResources(this.ProcessStatusLabel, "ProcessStatusLabel");
            this.tableLayoutPanel1.SetColumnSpan(this.ProcessStatusLabel, 2);
            this.ProcessStatusLabel.Name = "ProcessStatusLabel";
            // 
            // DestVideo
            // 
            this.DestVideo.BackColor = System.Drawing.Color.DarkGray;
            this.DestVideo.BackgroundImage = global::NeedleController.Properties.Resources.Logo_100x100;
            resources.ApplyResources(this.DestVideo, "DestVideo");
            this.DestVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.DestVideo, 2);
            this.DestVideo.Name = "DestVideo";
            this.DestVideo.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FailButton
            // 
            resources.ApplyResources(this.FailButton, "FailButton");
            this.FailButton.Name = "FailButton";
            this.FailButton.UseVisualStyleBackColor = true;
            this.FailButton.Click += new System.EventHandler(this.FailButton_Click);
            // 
            // InputInformationGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.InputInformationGroupBox, 4);
            this.InputInformationGroupBox.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.InputInformationGroupBox, "InputInformationGroupBox");
            this.InputInformationGroupBox.Name = "InputInformationGroupBox";
            this.InputInformationGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.HandleTextBox, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ProcessComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.OperatorLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OperatorTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MachineLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ReasonLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.ProcessLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.MachineTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.ReasonComboBox, 1, 6);
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
            this.tableLayoutPanel2.SetRowSpan(this.HandleTextBox, 6);
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
            this.ProcessComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProcessComboBox_KeyPress);
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
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.Controls.Add(this.BrokenTimePicker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BrokenDatePicker, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
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
            this.ReasonComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReasonComboBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // destVideotimer2
            // 
            this.destVideotimer2.Tick += new System.EventHandler(this.destVideotimer2_Tick);
            // 
            // MachineProcessView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MachineProcessView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MachineProcess_Close);
            this.Load += new System.EventHandler(this.MachineProcessView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestVideo)).EndInit();
            this.InputInformationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ContinueButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ProcessStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox DestVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CaptureImagePictureBox;
        private System.Windows.Forms.Button SuccessButton;
        private System.Windows.Forms.Label SelectedNeedleLegnthLabel;
        private System.Windows.Forms.Label CapturedNeedleLenghtLabel;
        private System.Windows.Forms.Button FailButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer destVideotimer2;
        private System.Windows.Forms.GroupBox InputInformationGroupBox;
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
    }
}