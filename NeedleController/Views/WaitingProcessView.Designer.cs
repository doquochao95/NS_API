namespace NeedleController.Views
{
    partial class WaitingProcessView
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WaitingStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // WaitingStatusLabel
            // 
            this.WaitingStatusLabel.AutoSize = true;
            this.WaitingStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WaitingStatusLabel.Location = new System.Drawing.Point(82, 16);
            this.WaitingStatusLabel.Name = "WaitingStatusLabel";
            this.WaitingStatusLabel.Size = new System.Drawing.Size(112, 25);
            this.WaitingStatusLabel.TabIndex = 0;
            this.WaitingStatusLabel.Text = "Please wait ...";
            // 
            // WaitingProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 50);
            this.ControlBox = false;
            this.Controls.Add(this.WaitingStatusLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "WaitingProcessView";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel WaitingStatusLabel;
    }
}