namespace NeedleController.Views
{
    partial class LeavingProcessView
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
            this.WaitingStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WaitingStatusLabel
            // 
            this.WaitingStatusLabel.AutoSize = true;
            this.WaitingStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.WaitingStatusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WaitingStatusLabel.Location = new System.Drawing.Point(71, 11);
            this.WaitingStatusLabel.Name = "WaitingStatusLabel";
            this.WaitingStatusLabel.Size = new System.Drawing.Size(99, 18);
            this.WaitingStatusLabel.TabIndex = 1;
            this.WaitingStatusLabel.Text = "Please wait ...";
            this.WaitingStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeavingProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 39);
            this.ControlBox = false;
            this.Controls.Add(this.WaitingStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LeavingProcessView";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label WaitingStatusLabel;
    }
}