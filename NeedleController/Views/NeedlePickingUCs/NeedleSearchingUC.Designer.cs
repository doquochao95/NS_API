
namespace NeedleController.Views.NeedlePickingUCs
{
    partial class NeedleSearchingUC
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
            this.NeedleSearchinggroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NeedleSearchNamelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NeedleSearchinglistBox = new System.Windows.Forms.ListBox();
            this.NeedleSearchinggroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NeedleSearchinggroupBox
            // 
            this.NeedleSearchinggroupBox.Controls.Add(this.tableLayoutPanel1);
            this.NeedleSearchinggroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleSearchinggroupBox.Location = new System.Drawing.Point(10, 10);
            this.NeedleSearchinggroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.NeedleSearchinggroupBox.Name = "NeedleSearchinggroupBox";
            this.NeedleSearchinggroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.NeedleSearchinggroupBox.Size = new System.Drawing.Size(206, 198);
            this.NeedleSearchinggroupBox.TabIndex = 0;
            this.NeedleSearchinggroupBox.TabStop = false;
            this.NeedleSearchinggroupBox.Text = "Search";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.NeedleSearchinglistBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 165);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NeedleSearchNamelabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 60);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(78, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NeedleSearchNamelabel
            // 
            this.NeedleSearchNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NeedleSearchNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleSearchNamelabel.Location = new System.Drawing.Point(11, 5);
            this.NeedleSearchNamelabel.Margin = new System.Windows.Forms.Padding(0);
            this.NeedleSearchNamelabel.Name = "NeedleSearchNamelabel";
            this.NeedleSearchNamelabel.Size = new System.Drawing.Size(66, 20);
            this.NeedleSearchNamelabel.TabIndex = 6;
            this.NeedleSearchNamelabel.Text = "Needle :";
            this.NeedleSearchNamelabel.Click += new System.EventHandler(this.NeedleSearchNamelabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(78, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 5;
            // 
            // NeedleSearchinglistBox
            // 
            this.NeedleSearchinglistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleSearchinglistBox.FormattingEnabled = true;
            this.NeedleSearchinglistBox.Location = new System.Drawing.Point(3, 69);
            this.NeedleSearchinglistBox.Name = "NeedleSearchinglistBox";
            this.NeedleSearchinglistBox.Size = new System.Drawing.Size(180, 93);
            this.NeedleSearchinglistBox.TabIndex = 5;
            // 
            // NeedleSearchingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeedleSearchinggroupBox);
            this.Name = "NeedleSearchingUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(226, 218);
            this.Load += new System.EventHandler(this.NeedleSearchingUC_Load);
            this.NeedleSearchinggroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NeedleSearchinggroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox NeedleSearchinglistBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NeedleSearchNamelabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
