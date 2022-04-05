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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuccessButton = new System.Windows.Forms.Button();
            this.FailButton = new System.Windows.Forms.Button();
            this.RetryButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProcessStatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SuccessButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FailButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RetryButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProcessStatusLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 54);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SuccessButton
            // 
            this.SuccessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuccessButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SuccessButton.Location = new System.Drawing.Point(3, 3);
            this.SuccessButton.Name = "SuccessButton";
            this.SuccessButton.Size = new System.Drawing.Size(55, 26);
            this.SuccessButton.TabIndex = 10;
            this.SuccessButton.Text = "Success";
            this.SuccessButton.UseVisualStyleBackColor = true;
            this.SuccessButton.Visible = false;
            this.SuccessButton.Click += new System.EventHandler(this.SuccessButton_Click);
            // 
            // FailButton
            // 
            this.FailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FailButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FailButton.Location = new System.Drawing.Point(186, 3);
            this.FailButton.Name = "FailButton";
            this.FailButton.Size = new System.Drawing.Size(55, 26);
            this.FailButton.TabIndex = 11;
            this.FailButton.Text = "Fail";
            this.FailButton.UseVisualStyleBackColor = true;
            this.FailButton.Visible = false;
            this.FailButton.Click += new System.EventHandler(this.FailButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.RetryButton, 2);
            this.RetryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetryButton.Enabled = false;
            this.RetryButton.FlatAppearance.BorderSize = 0;
            this.RetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetryButton.Location = new System.Drawing.Point(0, 32);
            this.RetryButton.Margin = new System.Windows.Forms.Padding(0);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(122, 22);
            this.RetryButton.TabIndex = 4;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.SetColumnSpan(this.CancelButton, 2);
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Enabled = false;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(122, 32);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 22);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessStatusLabel
            // 
            this.ProcessStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessStatusLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ProcessStatusLabel, 2);
            this.ProcessStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessStatusLabel.Location = new System.Drawing.Point(64, 0);
            this.ProcessStatusLabel.Name = "ProcessStatusLabel";
            this.ProcessStatusLabel.Size = new System.Drawing.Size(116, 32);
            this.ProcessStatusLabel.TabIndex = 1;
            this.ProcessStatusLabel.Text = "Please wait ...";
            this.ProcessStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MachineProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 54);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MachineProcessView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ProcessStatusLabel;
        private System.Windows.Forms.Button SuccessButton;
        private System.Windows.Forms.Button FailButton;
        private System.Windows.Forms.Timer timer1;
    }
}