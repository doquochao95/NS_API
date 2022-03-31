namespace NeedleController.Views
{
    partial class IDCardCheckingView
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
            this.RFIDstatusLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // RFIDstatusLabel
            // 
            this.RFIDstatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RFIDstatusLabel.AutoSize = true;
            this.RFIDstatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RFIDstatusLabel.Location = new System.Drawing.Point(65, 15);
            this.RFIDstatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RFIDstatusLabel.Name = "RFIDstatusLabel";
            this.RFIDstatusLabel.Size = new System.Drawing.Size(146, 25);
            this.RFIDstatusLabel.TabIndex = 3;
            this.RFIDstatusLabel.Text = "Scan your ID card";
            this.RFIDstatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDCardCheckingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 50);
            this.Controls.Add(this.RFIDstatusLabel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "IDCardCheckingView";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RFIDstatusLabel;
    }
}