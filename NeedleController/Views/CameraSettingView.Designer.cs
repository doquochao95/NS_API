
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveParaButton = new System.Windows.Forms.Button();
            this.DefaultParaButton = new System.Windows.Forms.Button();
            this.Preview_grBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OutputVideo = new System.Windows.Forms.PictureBox();
            this.CannyVideo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cameraImgParaSetting1 = new NeedleController.Views.CameraSettingUCs.CameraImgParaSetting();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Preview_grBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyVideo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.SaveParaButton);
            this.panel1.Controls.Add(this.DefaultParaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 45);
            this.panel1.TabIndex = 7;
            // 
            // SaveParaButton
            // 
            this.SaveParaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SaveParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveParaButton.Location = new System.Drawing.Point(594, 9);
            this.SaveParaButton.Name = "SaveParaButton";
            this.SaveParaButton.Size = new System.Drawing.Size(150, 30);
            this.SaveParaButton.TabIndex = 22;
            this.SaveParaButton.Text = "Save";
            this.SaveParaButton.UseVisualStyleBackColor = true;
            this.SaveParaButton.Click += new System.EventHandler(this.SaveParaButton_Click);
            // 
            // DefaultParaButton
            // 
            this.DefaultParaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DefaultParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultParaButton.Location = new System.Drawing.Point(234, 9);
            this.DefaultParaButton.Name = "DefaultParaButton";
            this.DefaultParaButton.Size = new System.Drawing.Size(150, 30);
            this.DefaultParaButton.TabIndex = 21;
            this.DefaultParaButton.Text = "Default";
            this.DefaultParaButton.UseVisualStyleBackColor = true;
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
            this.Preview_grBox.Size = new System.Drawing.Size(978, 198);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 177);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OutputVideo
            // 
            this.OutputVideo.BackColor = System.Drawing.Color.DarkGray;
            this.OutputVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputVideo.Image = global::NeedleController.Properties.Resources.Techlogo;
            this.OutputVideo.Location = new System.Drawing.Point(491, 5);
            this.OutputVideo.Margin = new System.Windows.Forms.Padding(5);
            this.OutputVideo.Name = "OutputVideo";
            this.OutputVideo.Size = new System.Drawing.Size(476, 167);
            this.OutputVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OutputVideo.TabIndex = 8;
            this.OutputVideo.TabStop = false;
            // 
            // CannyVideo
            // 
            this.CannyVideo.BackColor = System.Drawing.Color.DarkGray;
            this.CannyVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CannyVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CannyVideo.Image = global::NeedleController.Properties.Resources.Techlogo;
            this.CannyVideo.Location = new System.Drawing.Point(5, 5);
            this.CannyVideo.Margin = new System.Windows.Forms.Padding(5);
            this.CannyVideo.Name = "CannyVideo";
            this.CannyVideo.Size = new System.Drawing.Size(476, 167);
            this.CannyVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CannyVideo.TabIndex = 7;
            this.CannyVideo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 300);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cameraImgParaSetting1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(495, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 300);
            this.panel3.TabIndex = 11;
            // 
            // cameraImgParaSetting1
            // 
            this.cameraImgParaSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraImgParaSetting1.Location = new System.Drawing.Point(0, 0);
            this.cameraImgParaSetting1.Name = "cameraImgParaSetting1";
            this.cameraImgParaSetting1.Size = new System.Drawing.Size(486, 300);
            this.cameraImgParaSetting1.TabIndex = 10;
            // 
            // CameraSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
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
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveParaButton;
        private System.Windows.Forms.Button DefaultParaButton;
        private System.Windows.Forms.GroupBox Preview_grBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox CannyVideo;
        private System.Windows.Forms.PictureBox OutputVideo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CameraSettingUCs.CameraImgParaSetting cameraImgParaSetting1;
    }
}