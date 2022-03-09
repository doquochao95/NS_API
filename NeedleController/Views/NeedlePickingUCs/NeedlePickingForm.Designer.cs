
namespace NeedleController.Views.NeedlePickingUCs
{
    partial class NeedlePickingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.NeedleNameLabel = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.NeedleQtyTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PositionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NeedleNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GetButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NeedleQtyTextbox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PositionLabel.Location = new System.Drawing.Point(0, 35);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(117, 35);
            this.PositionLabel.TabIndex = 2;
            this.PositionLabel.Text = "A1";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NeedleNameLabel
            // 
            this.NeedleNameLabel.AutoSize = true;
            this.NeedleNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NeedleNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NeedleNameLabel.Location = new System.Drawing.Point(0, 0);
            this.NeedleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NeedleNameLabel.Name = "NeedleNameLabel";
            this.NeedleNameLabel.Size = new System.Drawing.Size(117, 35);
            this.NeedleNameLabel.TabIndex = 0;
            this.NeedleNameLabel.Text = "705836";
            this.NeedleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetButton
            // 
            this.GetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetButton.Location = new System.Drawing.Point(127, 40);
            this.GetButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(98, 25);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // NeedleQtyTextbox
            // 
            this.NeedleQtyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NeedleQtyTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleQtyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleQtyTextbox.Location = new System.Drawing.Point(125, 8);
            this.NeedleQtyTextbox.Margin = new System.Windows.Forms.Padding(8);
            this.NeedleQtyTextbox.Name = "NeedleQtyTextbox";
            this.NeedleQtyTextbox.Size = new System.Drawing.Size(102, 24);
            this.NeedleQtyTextbox.TabIndex = 0;
            this.NeedleQtyTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeedlePickingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NeedlePickingForm";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.Size = new System.Drawing.Size(250, 80);
            this.Load += new System.EventHandler(this.NeedlePickingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NeedleNameLabel;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox NeedleQtyTextbox;
        private System.Windows.Forms.Label PositionLabel;
    }
}
