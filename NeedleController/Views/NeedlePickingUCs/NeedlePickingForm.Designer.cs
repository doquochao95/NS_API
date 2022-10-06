
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
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.NeedleNameTilteLabel = new System.Windows.Forms.Label();
            this.QuantityTilteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.31326F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.68675F));
            this.tableLayoutPanel1.Controls.Add(this.QuantityLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GetButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NeedleNameTilteLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuantityTilteLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.White;
            this.QuantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(226, 25);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(63, 54);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "0";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.Color.White;
            this.GetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetButton.FlatAppearance.BorderSize = 0;
            this.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.ForeColor = System.Drawing.Color.Black;
            this.GetButton.Location = new System.Drawing.Point(1, 25);
            this.GetButton.Margin = new System.Windows.Forms.Padding(0);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(224, 54);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "777777/777";
            this.GetButton.UseVisualStyleBackColor = false;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // NeedleNameTilteLabel
            // 
            this.NeedleNameTilteLabel.AutoSize = true;
            this.NeedleNameTilteLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NeedleNameTilteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleNameTilteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NeedleNameTilteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NeedleNameTilteLabel.Location = new System.Drawing.Point(1, 1);
            this.NeedleNameTilteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NeedleNameTilteLabel.Name = "NeedleNameTilteLabel";
            this.NeedleNameTilteLabel.Size = new System.Drawing.Size(224, 23);
            this.NeedleNameTilteLabel.TabIndex = 5;
            this.NeedleNameTilteLabel.Text = "Needle Code";
            this.NeedleNameTilteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityTilteLabel
            // 
            this.QuantityTilteLabel.AutoSize = true;
            this.QuantityTilteLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.QuantityTilteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityTilteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityTilteLabel.Location = new System.Drawing.Point(226, 1);
            this.QuantityTilteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.QuantityTilteLabel.Name = "QuantityTilteLabel";
            this.QuantityTilteLabel.Size = new System.Drawing.Size(63, 23);
            this.QuantityTilteLabel.TabIndex = 6;
            this.QuantityTilteLabel.Text = "Quantity";
            this.QuantityTilteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NeedlePickingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(300, 90);
            this.MinimumSize = new System.Drawing.Size(300, 90);
            this.Name = "NeedlePickingForm";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Size = new System.Drawing.Size(300, 90);
            this.Load += new System.EventHandler(this.NeedlePickingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label NeedleNameTilteLabel;
        private System.Windows.Forms.Label QuantityTilteLabel;
    }
}
