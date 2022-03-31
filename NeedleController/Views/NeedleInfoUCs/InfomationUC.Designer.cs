﻿namespace NeedleController.Views.NeedleInfoUCs
{
    partial class InfomationUC
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NeedleLabel = new System.Windows.Forms.Label();
            this.NeedleComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NeedleLengthTextBox = new System.Windows.Forms.TextBox();
            this.NeedleLenghtLabel = new System.Windows.Forms.Label();
            this.NeedlePriceTextBox = new System.Windows.Forms.TextBox();
            this.NeedlePriceLabel = new System.Windows.Forms.Label();
            this.NeedlePointTextBox = new System.Windows.Forms.TextBox();
            this.NeedlePointLabel = new System.Windows.Forms.Label();
            this.NeedleSizeTextBox = new System.Windows.Forms.TextBox();
            this.NeedleSizeLabel = new System.Windows.Forms.Label();
            this.NeedleCodeTextBox = new System.Windows.Forms.TextBox();
            this.NeedleCodeLabel = new System.Windows.Forms.Label();
            this.NeedleNameTextBox = new System.Windows.Forms.TextBox();
            this.NeedleNameLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PointImagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NeedleImagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointImagePictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeedleImagePictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.NeedleLabel);
            this.groupBox1.Controls.Add(this.NeedleComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(759, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 27);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(495, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(231, 26);
            this.SearchTextBox.TabIndex = 4;
            // 
            // NeedleLabel
            // 
            this.NeedleLabel.AutoSize = true;
            this.NeedleLabel.Location = new System.Drawing.Point(71, 14);
            this.NeedleLabel.Name = "NeedleLabel";
            this.NeedleLabel.Size = new System.Drawing.Size(47, 13);
            this.NeedleLabel.TabIndex = 3;
            this.NeedleLabel.Text = "Needle :";
            // 
            // NeedleComboBox
            // 
            this.NeedleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleComboBox.FormattingEnabled = true;
            this.NeedleComboBox.Location = new System.Drawing.Point(124, 13);
            this.NeedleComboBox.Name = "NeedleComboBox";
            this.NeedleComboBox.Size = new System.Drawing.Size(121, 28);
            this.NeedleComboBox.TabIndex = 2;
            this.NeedleComboBox.SelectedIndexChanged += new System.EventHandler(this.NeedleComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NeedleLengthTextBox);
            this.groupBox2.Controls.Add(this.NeedleLenghtLabel);
            this.groupBox2.Controls.Add(this.NeedlePriceTextBox);
            this.groupBox2.Controls.Add(this.NeedlePriceLabel);
            this.groupBox2.Controls.Add(this.NeedlePointTextBox);
            this.groupBox2.Controls.Add(this.NeedlePointLabel);
            this.groupBox2.Controls.Add(this.NeedleSizeTextBox);
            this.groupBox2.Controls.Add(this.NeedleSizeLabel);
            this.groupBox2.Controls.Add(this.NeedleCodeTextBox);
            this.groupBox2.Controls.Add(this.NeedleCodeLabel);
            this.groupBox2.Controls.Add(this.NeedleNameTextBox);
            this.groupBox2.Controls.Add(this.NeedleNameLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Information";
            // 
            // NeedleLengthTextBox
            // 
            this.NeedleLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleLengthTextBox.Location = new System.Drawing.Point(74, 203);
            this.NeedleLengthTextBox.Name = "NeedleLengthTextBox";
            this.NeedleLengthTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedleLengthTextBox.TabIndex = 11;
            // 
            // NeedleLenghtLabel
            // 
            this.NeedleLenghtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleLenghtLabel.AutoSize = true;
            this.NeedleLenghtLabel.Location = new System.Drawing.Point(28, 203);
            this.NeedleLenghtLabel.Name = "NeedleLenghtLabel";
            this.NeedleLenghtLabel.Size = new System.Drawing.Size(46, 13);
            this.NeedleLenghtLabel.TabIndex = 10;
            this.NeedleLenghtLabel.Text = "Length :";
            // 
            // NeedlePriceTextBox
            // 
            this.NeedlePriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedlePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedlePriceTextBox.Location = new System.Drawing.Point(74, 167);
            this.NeedlePriceTextBox.Name = "NeedlePriceTextBox";
            this.NeedlePriceTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedlePriceTextBox.TabIndex = 9;
            // 
            // NeedlePriceLabel
            // 
            this.NeedlePriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedlePriceLabel.AutoSize = true;
            this.NeedlePriceLabel.Location = new System.Drawing.Point(28, 167);
            this.NeedlePriceLabel.Name = "NeedlePriceLabel";
            this.NeedlePriceLabel.Size = new System.Drawing.Size(37, 13);
            this.NeedlePriceLabel.TabIndex = 8;
            this.NeedlePriceLabel.Text = "Price :";
            // 
            // NeedlePointTextBox
            // 
            this.NeedlePointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedlePointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedlePointTextBox.Location = new System.Drawing.Point(74, 131);
            this.NeedlePointTextBox.Name = "NeedlePointTextBox";
            this.NeedlePointTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedlePointTextBox.TabIndex = 7;
            // 
            // NeedlePointLabel
            // 
            this.NeedlePointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedlePointLabel.AutoSize = true;
            this.NeedlePointLabel.Location = new System.Drawing.Point(28, 131);
            this.NeedlePointLabel.Name = "NeedlePointLabel";
            this.NeedlePointLabel.Size = new System.Drawing.Size(37, 13);
            this.NeedlePointLabel.TabIndex = 6;
            this.NeedlePointLabel.Text = "Point :";
            // 
            // NeedleSizeTextBox
            // 
            this.NeedleSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleSizeTextBox.Location = new System.Drawing.Point(74, 95);
            this.NeedleSizeTextBox.Name = "NeedleSizeTextBox";
            this.NeedleSizeTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedleSizeTextBox.TabIndex = 5;
            // 
            // NeedleSizeLabel
            // 
            this.NeedleSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleSizeLabel.AutoSize = true;
            this.NeedleSizeLabel.Location = new System.Drawing.Point(28, 95);
            this.NeedleSizeLabel.Name = "NeedleSizeLabel";
            this.NeedleSizeLabel.Size = new System.Drawing.Size(33, 13);
            this.NeedleSizeLabel.TabIndex = 4;
            this.NeedleSizeLabel.Text = "Size :";
            // 
            // NeedleCodeTextBox
            // 
            this.NeedleCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleCodeTextBox.Location = new System.Drawing.Point(74, 59);
            this.NeedleCodeTextBox.Name = "NeedleCodeTextBox";
            this.NeedleCodeTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedleCodeTextBox.TabIndex = 3;
            // 
            // NeedleCodeLabel
            // 
            this.NeedleCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleCodeLabel.AutoSize = true;
            this.NeedleCodeLabel.Location = new System.Drawing.Point(28, 59);
            this.NeedleCodeLabel.Name = "NeedleCodeLabel";
            this.NeedleCodeLabel.Size = new System.Drawing.Size(38, 13);
            this.NeedleCodeLabel.TabIndex = 2;
            this.NeedleCodeLabel.Text = "Code :";
            // 
            // NeedleNameTextBox
            // 
            this.NeedleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedleNameTextBox.Location = new System.Drawing.Point(74, 23);
            this.NeedleNameTextBox.Name = "NeedleNameTextBox";
            this.NeedleNameTextBox.Size = new System.Drawing.Size(320, 26);
            this.NeedleNameTextBox.TabIndex = 1;
            // 
            // NeedleNameLabel
            // 
            this.NeedleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedleNameLabel.AutoSize = true;
            this.NeedleNameLabel.Location = new System.Drawing.Point(28, 23);
            this.NeedleNameLabel.Name = "NeedleNameLabel";
            this.NeedleNameLabel.Size = new System.Drawing.Size(41, 13);
            this.NeedleNameLabel.TabIndex = 0;
            this.NeedleNameLabel.Text = "Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PointImagePictureBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(451, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Point Image";
            // 
            // PointImagePictureBox
            // 
            this.PointImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointImagePictureBox.Location = new System.Drawing.Point(3, 16);
            this.PointImagePictureBox.Name = "PointImagePictureBox";
            this.PointImagePictureBox.Size = new System.Drawing.Size(212, 221);
            this.PointImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PointImagePictureBox.TabIndex = 0;
            this.PointImagePictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NeedleImagePictureBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(675, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 240);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Needle Image";
            // 
            // NeedleImagePictureBox
            // 
            this.NeedleImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedleImagePictureBox.Location = new System.Drawing.Point(3, 16);
            this.NeedleImagePictureBox.Name = "NeedleImagePictureBox";
            this.NeedleImagePictureBox.Size = new System.Drawing.Size(212, 221);
            this.NeedleImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NeedleImagePictureBox.TabIndex = 1;
            this.NeedleImagePictureBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 303);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 241);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detail Specific";
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 16);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(436, 222);
            this.textBox7.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox6, 2);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(451, 303);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(442, 241);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Application";
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(3, 16);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(436, 222);
            this.textBox8.TabIndex = 1;
            // 
            // InfomationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(896, 547);
            this.Name = "InfomationUC";
            this.Size = new System.Drawing.Size(896, 547);
            this.Load += new System.EventHandler(this.InfomationUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointImagePictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NeedleImagePictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label NeedleLabel;
        private System.Windows.Forms.ComboBox NeedleComboBox;
        private System.Windows.Forms.TextBox NeedleNameTextBox;
        private System.Windows.Forms.Label NeedleNameLabel;
        private System.Windows.Forms.TextBox NeedleLengthTextBox;
        private System.Windows.Forms.Label NeedleLenghtLabel;
        private System.Windows.Forms.TextBox NeedlePriceTextBox;
        private System.Windows.Forms.Label NeedlePriceLabel;
        private System.Windows.Forms.TextBox NeedlePointTextBox;
        private System.Windows.Forms.Label NeedlePointLabel;
        private System.Windows.Forms.TextBox NeedleSizeTextBox;
        private System.Windows.Forms.Label NeedleSizeLabel;
        private System.Windows.Forms.TextBox NeedleCodeTextBox;
        private System.Windows.Forms.Label NeedleCodeLabel;
        private System.Windows.Forms.PictureBox PointImagePictureBox;
        private System.Windows.Forms.PictureBox NeedleImagePictureBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Timer Timer1;
    }
}
