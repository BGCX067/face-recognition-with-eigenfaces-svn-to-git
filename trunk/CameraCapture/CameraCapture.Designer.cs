namespace LiveFaceDetection
{
    partial class CameraCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraCapture));
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thresholdUpDown = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.windowSizeYTextBox = new System.Windows.Forms.TextBox();
            this.windowSizeXTextBox = new System.Windows.Forms.TextBox();
            this.minNeighborsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleFactorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamImageBox
            // 
            this.CamImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(10, 10);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(540, 410);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            this.CamImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CamImageBox_MouseClick);
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(366, 427);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(67, 21);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Camera:";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(475, 425);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.thresholdUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.windowSizeYTextBox);
            this.groupBox1.Controls.Add(this.windowSizeXTextBox);
            this.groupBox1.Controls.Add(this.minNeighborsComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scaleFactorComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(569, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parametres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x  100";
            // 
            // thresholdUpDown
            // 
            this.thresholdUpDown.Items.Add("50");
            this.thresholdUpDown.Items.Add("45");
            this.thresholdUpDown.Items.Add("40");
            this.thresholdUpDown.Items.Add("39");
            this.thresholdUpDown.Items.Add("38");
            this.thresholdUpDown.Items.Add("37");
            this.thresholdUpDown.Items.Add("36");
            this.thresholdUpDown.Items.Add("35");
            this.thresholdUpDown.Items.Add("34");
            this.thresholdUpDown.Items.Add("33");
            this.thresholdUpDown.Items.Add("32");
            this.thresholdUpDown.Items.Add("31");
            this.thresholdUpDown.Items.Add("30");
            this.thresholdUpDown.Items.Add("29");
            this.thresholdUpDown.Items.Add("28");
            this.thresholdUpDown.Items.Add("27");
            this.thresholdUpDown.Items.Add("26");
            this.thresholdUpDown.Items.Add("25");
            this.thresholdUpDown.Items.Add("24");
            this.thresholdUpDown.Items.Add("23");
            this.thresholdUpDown.Items.Add("22");
            this.thresholdUpDown.Items.Add("21");
            this.thresholdUpDown.Items.Add("20");
            this.thresholdUpDown.Items.Add("19");
            this.thresholdUpDown.Items.Add("18");
            this.thresholdUpDown.Items.Add("17");
            this.thresholdUpDown.Items.Add("16");
            this.thresholdUpDown.Items.Add("15");
            this.thresholdUpDown.Items.Add("14");
            this.thresholdUpDown.Items.Add("13");
            this.thresholdUpDown.Items.Add("12");
            this.thresholdUpDown.Items.Add("11");
            this.thresholdUpDown.Items.Add("10");
            this.thresholdUpDown.Items.Add("9");
            this.thresholdUpDown.Items.Add("8");
            this.thresholdUpDown.Items.Add("7");
            this.thresholdUpDown.Items.Add("6");
            this.thresholdUpDown.Items.Add("5");
            this.thresholdUpDown.Items.Add("4");
            this.thresholdUpDown.Items.Add("3");
            this.thresholdUpDown.Items.Add("2");
            this.thresholdUpDown.Items.Add("1");
            this.thresholdUpDown.Location = new System.Drawing.Point(119, 104);
            this.thresholdUpDown.Name = "thresholdUpDown";
            this.thresholdUpDown.Size = new System.Drawing.Size(80, 20);
            this.thresholdUpDown.TabIndex = 9;
            this.thresholdUpDown.Text = "12";
            this.thresholdUpDown.TextChanged += new System.EventHandler(this.thresholdUpDown_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Threshold :";
            // 
            // windowSizeYTextBox
            // 
            this.windowSizeYTextBox.Location = new System.Drawing.Point(187, 82);
            this.windowSizeYTextBox.Name = "windowSizeYTextBox";
            this.windowSizeYTextBox.Size = new System.Drawing.Size(60, 20);
            this.windowSizeYTextBox.TabIndex = 7;
            this.windowSizeYTextBox.Text = "50";
            // 
            // windowSizeXTextBox
            // 
            this.windowSizeXTextBox.Location = new System.Drawing.Point(119, 82);
            this.windowSizeXTextBox.Name = "windowSizeXTextBox";
            this.windowSizeXTextBox.Size = new System.Drawing.Size(60, 20);
            this.windowSizeXTextBox.TabIndex = 6;
            this.windowSizeXTextBox.Text = "50";
            // 
            // minNeighborsComboBox
            // 
            this.minNeighborsComboBox.FormattingEnabled = true;
            this.minNeighborsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.minNeighborsComboBox.Location = new System.Drawing.Point(119, 61);
            this.minNeighborsComboBox.Name = "minNeighborsComboBox";
            this.minNeighborsComboBox.Size = new System.Drawing.Size(128, 21);
            this.minNeighborsComboBox.TabIndex = 5;
            this.minNeighborsComboBox.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min Window Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Neighbors :";
            // 
            // scaleFactorComboBox
            // 
            this.scaleFactorComboBox.FormattingEnabled = true;
            this.scaleFactorComboBox.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.scaleFactorComboBox.Location = new System.Drawing.Point(119, 40);
            this.scaleFactorComboBox.Name = "scaleFactorComboBox";
            this.scaleFactorComboBox.Size = new System.Drawing.Size(128, 21);
            this.scaleFactorComboBox.TabIndex = 1;
            this.scaleFactorComboBox.Text = "1.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scale Factor :";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(23, 427);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 459);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CameraCapture_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scaleFactorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox windowSizeYTextBox;
        private System.Windows.Forms.TextBox windowSizeXTextBox;
        private System.Windows.Forms.ComboBox minNeighborsComboBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown thresholdUpDown;
    }
}

