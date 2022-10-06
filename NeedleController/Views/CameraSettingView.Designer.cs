
namespace NeedleController.Views
{
    partial class CameraSettingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSettingView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DefaultParaButton = new System.Windows.Forms.Button();
            this.Preview_grBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OutputVideo = new System.Windows.Forms.PictureBox();
            this.CannyVideo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveParaButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Preview_grBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyVideo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Preview_grBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DefaultParaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 630);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 26);
            this.panel1.TabIndex = 7;
            // 
            // DefaultParaButton
            // 
            this.DefaultParaButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DefaultParaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultParaButton.FlatAppearance.BorderSize = 0;
            this.DefaultParaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultParaButton.Location = new System.Drawing.Point(0, 0);
            this.DefaultParaButton.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultParaButton.Name = "DefaultParaButton";
            this.DefaultParaButton.Size = new System.Drawing.Size(487, 26);
            this.DefaultParaButton.TabIndex = 21;
            this.DefaultParaButton.Text = "Default";
            this.DefaultParaButton.UseVisualStyleBackColor = false;
            this.DefaultParaButton.Click += new System.EventHandler(this.DefaultParaButton_Click);
            // 
            // Preview_grBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Preview_grBox, 2);
            this.Preview_grBox.Controls.Add(this.tableLayoutPanel2);
            this.Preview_grBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview_grBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview_grBox.Location = new System.Drawing.Point(3, 3);
            this.Preview_grBox.Name = "Preview_grBox";
            this.Preview_grBox.Size = new System.Drawing.Size(978, 246);
            this.Preview_grBox.TabIndex = 8;
            this.Preview_grBox.TabStop = false;
            this.Preview_grBox.Text = "Preview";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.OutputVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CannyVideo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 225);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OutputVideo
            // 
            this.OutputVideo.BackColor = System.Drawing.Color.DarkGray;
            this.OutputVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputVideo.Location = new System.Drawing.Point(491, 5);
            this.OutputVideo.Margin = new System.Windows.Forms.Padding(5);
            this.OutputVideo.Name = "OutputVideo";
            this.OutputVideo.Size = new System.Drawing.Size(476, 215);
            this.OutputVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OutputVideo.TabIndex = 8;
            this.OutputVideo.TabStop = false;
            // 
            // CannyVideo
            // 
            this.CannyVideo.BackColor = System.Drawing.Color.DarkGray;
            this.CannyVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CannyVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CannyVideo.Location = new System.Drawing.Point(5, 5);
            this.CannyVideo.Margin = new System.Windows.Forms.Padding(5);
            this.CannyVideo.Name = "CannyVideo";
            this.CannyVideo.Size = new System.Drawing.Size(476, 215);
            this.CannyVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CannyVideo.TabIndex = 7;
            this.CannyVideo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 372);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(495, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 372);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SaveParaButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(492, 630);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 26);
            this.panel4.TabIndex = 12;
            // 
            // SaveParaButton
            // 
            this.SaveParaButton.BackColor = System.Drawing.Color.LightGreen;
            this.SaveParaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveParaButton.FlatAppearance.BorderSize = 0;
            this.SaveParaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveParaButton.Location = new System.Drawing.Point(0, 0);
            this.SaveParaButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveParaButton.Name = "SaveParaButton";
            this.SaveParaButton.Size = new System.Drawing.Size(487, 26);
            this.SaveParaButton.TabIndex = 23;
            this.SaveParaButton.Text = "Save";
            this.SaveParaButton.UseVisualStyleBackColor = false;
            this.SaveParaButton.Click += new System.EventHandler(this.SaveParaButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CameraSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "CameraSettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraSettingView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraSettingView_FormClosed);
            this.Load += new System.EventHandler(this.CameraSettingView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Preview_grBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyVideo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DefaultParaButton;
        private System.Windows.Forms.GroupBox Preview_grBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox CannyVideo;
        private System.Windows.Forms.PictureBox OutputVideo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SaveParaButton;
    }
}