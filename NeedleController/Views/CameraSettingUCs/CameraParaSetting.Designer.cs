
namespace NeedleController.Views.CameraSettingUCs
{
    partial class CameraParaSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Color = new System.Windows.Forms.GroupBox();
            this.ColorNeedle = new System.Windows.Forms.PictureBox();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.HighB = new System.Windows.Forms.TextBox();
            this.HighG = new System.Windows.Forms.TextBox();
            this.HighR = new System.Windows.Forms.TextBox();
            this.LowB = new System.Windows.Forms.TextBox();
            this.LowG = new System.Windows.Forms.TextBox();
            this.LowR = new System.Windows.Forms.TextBox();
            this.LowerbLabel = new System.Windows.Forms.Label();
            this.UpperbLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CannyThreshold1Trackbar = new System.Windows.Forms.TrackBar();
            this.CannyThreshold2Value = new System.Windows.Forms.Label();
            this.CannyThreshold1Value = new System.Windows.Forms.Label();
            this.CannyThreshold1Label = new System.Windows.Forms.Label();
            this.CannyThreshold2Label = new System.Windows.Forms.Label();
            this.CannyThreshold2Trackbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressStringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDcameraCmb = new System.Windows.Forms.ComboBox();
            this.CameraAddress = new System.Windows.Forms.Label();
            this.GaussianKSizeCmb = new System.Windows.Forms.ComboBox();
            this.GaussianKsizeLabel = new System.Windows.Forms.Label();
            this.OnOffDetect = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(466, 345);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opencv Setting";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Color, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Color
            // 
            this.Color.Controls.Add(this.ColorNeedle);
            this.Color.Controls.Add(this.BlueLabel);
            this.Color.Controls.Add(this.GreenLabel);
            this.Color.Controls.Add(this.RedLabel);
            this.Color.Controls.Add(this.HighB);
            this.Color.Controls.Add(this.HighG);
            this.Color.Controls.Add(this.HighR);
            this.Color.Controls.Add(this.LowB);
            this.Color.Controls.Add(this.LowG);
            this.Color.Controls.Add(this.LowR);
            this.Color.Controls.Add(this.LowerbLabel);
            this.Color.Controls.Add(this.UpperbLabel);
            this.Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(5, 197);
            this.Color.Margin = new System.Windows.Forms.Padding(5);
            this.Color.Name = "Color";
            this.Color.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.SetRowSpan(this.Color, 2);
            this.Color.Size = new System.Drawing.Size(446, 118);
            this.Color.TabIndex = 16;
            this.Color.TabStop = false;
            this.Color.Text = "Needle Color";
            // 
            // ColorNeedle
            // 
            this.ColorNeedle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ColorNeedle.Location = new System.Drawing.Point(98, 89);
            this.ColorNeedle.Name = "ColorNeedle";
            this.ColorNeedle.Size = new System.Drawing.Size(326, 13);
            this.ColorNeedle.TabIndex = 12;
            this.ColorNeedle.TabStop = false;
            this.ColorNeedle.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorNeedle_Paint);
            // 
            // BlueLabel
            // 
            this.BlueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueLabel.Location = new System.Drawing.Point(369, 17);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(28, 13);
            this.BlueLabel.TabIndex = 10;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.ForeColor = System.Drawing.Color.Green;
            this.GreenLabel.Location = new System.Drawing.Point(244, 16);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(36, 13);
            this.GreenLabel.TabIndex = 9;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(125, 17);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 13);
            this.RedLabel.TabIndex = 8;
            this.RedLabel.Text = "Red";
            // 
            // HighB
            // 
            this.HighB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighB.Location = new System.Drawing.Point(344, 61);
            this.HighB.Name = "HighB";
            this.HighB.Size = new System.Drawing.Size(80, 22);
            this.HighB.TabIndex = 7;
            this.HighB.Text = "80";
            this.HighB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighB_KeyPress);
            // 
            // HighG
            // 
            this.HighG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighG.Location = new System.Drawing.Point(220, 61);
            this.HighG.Name = "HighG";
            this.HighG.Size = new System.Drawing.Size(80, 22);
            this.HighG.TabIndex = 6;
            this.HighG.Text = "110";
            this.HighG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighG_KeyPress);
            // 
            // HighR
            // 
            this.HighR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighR.Location = new System.Drawing.Point(98, 62);
            this.HighR.Name = "HighR";
            this.HighR.Size = new System.Drawing.Size(80, 22);
            this.HighR.TabIndex = 5;
            this.HighR.Text = "150";
            this.HighR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HighR_KeyPress);
            // 
            // LowB
            // 
            this.LowB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowB.Location = new System.Drawing.Point(344, 33);
            this.LowB.Name = "LowB";
            this.LowB.Size = new System.Drawing.Size(80, 22);
            this.LowB.TabIndex = 4;
            this.LowB.Text = "50";
            this.LowB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowB_KeyPress);
            // 
            // LowG
            // 
            this.LowG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowG.Location = new System.Drawing.Point(220, 33);
            this.LowG.Name = "LowG";
            this.LowG.Size = new System.Drawing.Size(80, 22);
            this.LowG.TabIndex = 3;
            this.LowG.Text = "90";
            this.LowG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowG_KeyPress);
            // 
            // LowR
            // 
            this.LowR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowR.Location = new System.Drawing.Point(98, 34);
            this.LowR.Name = "LowR";
            this.LowR.Size = new System.Drawing.Size(80, 22);
            this.LowR.TabIndex = 2;
            this.LowR.Text = "130";
            this.LowR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowR_KeyPress);
            // 
            // LowerbLabel
            // 
            this.LowerbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LowerbLabel.AutoSize = true;
            this.LowerbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerbLabel.Location = new System.Drawing.Point(28, 37);
            this.LowerbLabel.Name = "LowerbLabel";
            this.LowerbLabel.Size = new System.Drawing.Size(51, 16);
            this.LowerbLabel.TabIndex = 1;
            this.LowerbLabel.Text = "Lowerb";
            // 
            // UpperbLabel
            // 
            this.UpperbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UpperbLabel.AutoSize = true;
            this.UpperbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperbLabel.Location = new System.Drawing.Point(28, 64);
            this.UpperbLabel.Name = "UpperbLabel";
            this.UpperbLabel.Size = new System.Drawing.Size(53, 16);
            this.UpperbLabel.TabIndex = 0;
            this.UpperbLabel.Text = "Upperb";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CannyThreshold1Trackbar);
            this.panel3.Controls.Add(this.CannyThreshold2Value);
            this.panel3.Controls.Add(this.CannyThreshold1Value);
            this.panel3.Controls.Add(this.CannyThreshold1Label);
            this.panel3.Controls.Add(this.CannyThreshold2Label);
            this.panel3.Controls.Add(this.CannyThreshold2Trackbar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 90);
            this.panel3.TabIndex = 19;
            // 
            // CannyThreshold1Trackbar
            // 
            this.CannyThreshold1Trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold1Trackbar.Location = new System.Drawing.Point(144, 6);
            this.CannyThreshold1Trackbar.Maximum = 255;
            this.CannyThreshold1Trackbar.Name = "CannyThreshold1Trackbar";
            this.CannyThreshold1Trackbar.Size = new System.Drawing.Size(254, 45);
            this.CannyThreshold1Trackbar.TabIndex = 6;
            this.CannyThreshold1Trackbar.TickFrequency = 10;
            this.CannyThreshold1Trackbar.Scroll += new System.EventHandler(this.CannyThreshold1Trackbar_Scroll);
            // 
            // CannyThreshold2Value
            // 
            this.CannyThreshold2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold2Value.AutoSize = true;
            this.CannyThreshold2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Value.Location = new System.Drawing.Point(409, 54);
            this.CannyThreshold2Value.Name = "CannyThreshold2Value";
            this.CannyThreshold2Value.Size = new System.Drawing.Size(16, 17);
            this.CannyThreshold2Value.TabIndex = 11;
            this.CannyThreshold2Value.Text = "0";
            // 
            // CannyThreshold1Value
            // 
            this.CannyThreshold1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold1Value.AutoSize = true;
            this.CannyThreshold1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Value.Location = new System.Drawing.Point(409, 7);
            this.CannyThreshold1Value.Name = "CannyThreshold1Value";
            this.CannyThreshold1Value.Size = new System.Drawing.Size(16, 17);
            this.CannyThreshold1Value.TabIndex = 10;
            this.CannyThreshold1Value.Text = "0";
            // 
            // CannyThreshold1Label
            // 
            this.CannyThreshold1Label.AutoSize = true;
            this.CannyThreshold1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold1Label.Location = new System.Drawing.Point(23, 8);
            this.CannyThreshold1Label.Name = "CannyThreshold1Label";
            this.CannyThreshold1Label.Size = new System.Drawing.Size(125, 16);
            this.CannyThreshold1Label.TabIndex = 8;
            this.CannyThreshold1Label.Text = "Canny Threshold 1 :";
            // 
            // CannyThreshold2Label
            // 
            this.CannyThreshold2Label.AutoSize = true;
            this.CannyThreshold2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannyThreshold2Label.Location = new System.Drawing.Point(24, 56);
            this.CannyThreshold2Label.Name = "CannyThreshold2Label";
            this.CannyThreshold2Label.Size = new System.Drawing.Size(125, 16);
            this.CannyThreshold2Label.TabIndex = 9;
            this.CannyThreshold2Label.Text = "Canny Threshold 2 :";
            // 
            // CannyThreshold2Trackbar
            // 
            this.CannyThreshold2Trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyThreshold2Trackbar.Location = new System.Drawing.Point(145, 52);
            this.CannyThreshold2Trackbar.Maximum = 255;
            this.CannyThreshold2Trackbar.Name = "CannyThreshold2Trackbar";
            this.CannyThreshold2Trackbar.Size = new System.Drawing.Size(253, 45);
            this.CannyThreshold2Trackbar.TabIndex = 7;
            this.CannyThreshold2Trackbar.TickFrequency = 10;
            this.CannyThreshold2Trackbar.Scroll += new System.EventHandler(this.CannyThreshold2Trackbar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddressStringTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDcameraCmb);
            this.panel1.Controls.Add(this.CameraAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(450, 42);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = ":4747/video";
            // 
            // AddressStringTextBox
            // 
            this.AddressStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressStringTextBox.Location = new System.Drawing.Point(260, 10);
            this.AddressStringTextBox.Name = "AddressStringTextBox";
            this.AddressStringTextBox.Size = new System.Drawing.Size(108, 22);
            this.AddressStringTextBox.TabIndex = 23;
            this.AddressStringTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressStringTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "http://";
            // 
            // IDcameraCmb
            // 
            this.IDcameraCmb.FormattingEnabled = true;
            this.IDcameraCmb.Items.AddRange(new object[] {
            "Local Camera",
            "IP Camera"});
            this.IDcameraCmb.Location = new System.Drawing.Point(83, 9);
            this.IDcameraCmb.Name = "IDcameraCmb";
            this.IDcameraCmb.Size = new System.Drawing.Size(123, 24);
            this.IDcameraCmb.TabIndex = 21;
            this.IDcameraCmb.SelectedIndexChanged += new System.EventHandler(this.IDcameraCmb_SelectedIndexChanged);
            // 
            // CameraAddress
            // 
            this.CameraAddress.AutoSize = true;
            this.CameraAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraAddress.Location = new System.Drawing.Point(22, 13);
            this.CameraAddress.Name = "CameraAddress";
            this.CameraAddress.Size = new System.Drawing.Size(61, 16);
            this.CameraAddress.TabIndex = 20;
            this.CameraAddress.Text = "Camera :";
            // 
            // GaussianKSizeCmb
            // 
            this.GaussianKSizeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianKSizeCmb.FormattingEnabled = true;
            this.GaussianKSizeCmb.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.GaussianKSizeCmb.Location = new System.Drawing.Point(186, 9);
            this.GaussianKSizeCmb.Name = "GaussianKSizeCmb";
            this.GaussianKSizeCmb.Size = new System.Drawing.Size(80, 24);
            this.GaussianKSizeCmb.TabIndex = 25;
            this.GaussianKSizeCmb.SelectedIndexChanged += new System.EventHandler(this.GaussianKSizeCmb_SelectedIndexChanged);
            // 
            // GaussianKsizeLabel
            // 
            this.GaussianKsizeLabel.AutoSize = true;
            this.GaussianKsizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaussianKsizeLabel.Location = new System.Drawing.Point(22, 12);
            this.GaussianKsizeLabel.Name = "GaussianKsizeLabel";
            this.GaussianKsizeLabel.Size = new System.Drawing.Size(163, 16);
            this.GaussianKsizeLabel.TabIndex = 24;
            this.GaussianKsizeLabel.Text = "GaussianBlur Kernel Size :";
            // 
            // OnOffDetect
            // 
            this.OnOffDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnOffDetect.AutoSize = true;
            this.OnOffDetect.Checked = true;
            this.OnOffDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnOffDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffDetect.Location = new System.Drawing.Point(356, 13);
            this.OnOffDetect.Name = "OnOffDetect";
            this.OnOffDetect.Size = new System.Drawing.Size(75, 17);
            this.OnOffDetect.TabIndex = 26;
            this.OnOffDetect.Text = "On Detect";
            this.OnOffDetect.UseVisualStyleBackColor = true;
            this.OnOffDetect.CheckedChanged += new System.EventHandler(this.OnOffDetect_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OnOffDetect);
            this.panel2.Controls.Add(this.GaussianKsizeLabel);
            this.panel2.Controls.Add(this.GaussianKSizeCmb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 42);
            this.panel2.TabIndex = 18;
            // 
            // CameraParaSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(486, 365);
            this.Name = "CameraParaSetting";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(486, 365);
            this.Load += new System.EventHandler(this.CameraParaSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Color.ResumeLayout(false);
            this.Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNeedle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Trackbar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Color;
        private System.Windows.Forms.PictureBox ColorNeedle;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TextBox HighB;
        private System.Windows.Forms.TextBox HighG;
        private System.Windows.Forms.TextBox HighR;
        private System.Windows.Forms.TextBox LowB;
        private System.Windows.Forms.TextBox LowG;
        private System.Windows.Forms.TextBox LowR;
        private System.Windows.Forms.Label LowerbLabel;
        private System.Windows.Forms.Label UpperbLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar CannyThreshold1Trackbar;
        private System.Windows.Forms.Label CannyThreshold2Value;
        private System.Windows.Forms.Label CannyThreshold1Value;
        private System.Windows.Forms.Label CannyThreshold1Label;
        private System.Windows.Forms.Label CannyThreshold2Label;
        private System.Windows.Forms.TrackBar CannyThreshold2Trackbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDcameraCmb;
        private System.Windows.Forms.Label CameraAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox OnOffDetect;
        private System.Windows.Forms.Label GaussianKsizeLabel;
        private System.Windows.Forms.ComboBox GaussianKSizeCmb;
    }
}
