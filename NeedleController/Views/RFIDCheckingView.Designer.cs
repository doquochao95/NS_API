
namespace NeedleController.Views
{
    partial class RFIDCheckingView
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
            this.RFIDstatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RFIDstatusLabel
            // 
            this.RFIDstatusLabel.AutoSize = true;
            this.RFIDstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDstatusLabel.Location = new System.Drawing.Point(63, 24);
            this.RFIDstatusLabel.Name = "RFIDstatusLabel";
            this.RFIDstatusLabel.Size = new System.Drawing.Size(114, 16);
            this.RFIDstatusLabel.TabIndex = 0;
            this.RFIDstatusLabel.Text = "Scan your ID card";
            this.RFIDstatusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RFIDCheckingView
            // 
            this.ClientSize = new System.Drawing.Size(244, 64);
            this.ControlBox = false;
            this.Controls.Add(this.RFIDstatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 70);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 70);
            this.Name = "RFIDCheckingView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RFIDCheckingView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RFIDstatusLabel;
    }
}