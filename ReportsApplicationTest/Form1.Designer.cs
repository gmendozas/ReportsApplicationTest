namespace ReportsApplicationTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.txbW = new System.Windows.Forms.TextBox();
            this.txbH = new System.Windows.Forms.TextBox();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbY1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbY2 = new System.Windows.Forms.TextBox();
            this.chbDirection = new System.Windows.Forms.CheckBox();
            this.cmbAngle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1346, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(700, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(136, 25);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(32, 20);
            this.txbX.TabIndex = 8;
            this.txbX.Text = "0";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(195, 25);
            this.txbY.Name = "txbY";
            this.txbY.ReadOnly = true;
            this.txbY.Size = new System.Drawing.Size(34, 20);
            this.txbY.TabIndex = 9;
            this.txbY.Text = "0";
            // 
            // txbW
            // 
            this.txbW.Location = new System.Drawing.Point(285, 25);
            this.txbW.Name = "txbW";
            this.txbW.Size = new System.Drawing.Size(56, 20);
            this.txbW.TabIndex = 10;
            this.txbW.Text = "50";
            // 
            // txbH
            // 
            this.txbH.Location = new System.Drawing.Point(381, 25);
            this.txbH.Name = "txbH";
            this.txbH.Size = new System.Drawing.Size(58, 20);
            this.txbH.TabIndex = 11;
            this.txbH.Text = "0";
            this.txbH.TextChanged += new System.EventHandler(this.txbH_TextChanged);
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Checked = true;
            this.chbBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBold.Location = new System.Drawing.Point(563, 30);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(47, 17);
            this.chbBold.TabIndex = 12;
            this.chbBold.Text = "Bold";
            this.chbBold.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(781, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Text Size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(874, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "View as HTML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Top Line X1";
            // 
            // txbX1
            // 
            this.txbX1.Location = new System.Drawing.Point(84, 56);
            this.txbX1.Name = "txbX1";
            this.txbX1.Size = new System.Drawing.Size(56, 20);
            this.txbX1.TabIndex = 20;
            this.txbX1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Top Line X2";
            // 
            // txbX2
            // 
            this.txbX2.Location = new System.Drawing.Point(407, 56);
            this.txbX2.Name = "txbX2";
            this.txbX2.Size = new System.Drawing.Size(64, 20);
            this.txbX2.TabIndex = 22;
            this.txbX2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Top Line Y1";
            // 
            // txbY1
            // 
            this.txbY1.Location = new System.Drawing.Point(247, 56);
            this.txbY1.Name = "txbY1";
            this.txbY1.Size = new System.Drawing.Size(69, 20);
            this.txbY1.TabIndex = 24;
            this.txbY1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Top Line Y2";
            // 
            // txbY2
            // 
            this.txbY2.Location = new System.Drawing.Point(576, 56);
            this.txbY2.Name = "txbY2";
            this.txbY2.Size = new System.Drawing.Size(80, 20);
            this.txbY2.TabIndex = 26;
            this.txbY2.Text = "0";
            // 
            // chbDirection
            // 
            this.chbDirection.AutoSize = true;
            this.chbDirection.Checked = true;
            this.chbDirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDirection.Enabled = false;
            this.chbDirection.Location = new System.Drawing.Point(614, 28);
            this.chbDirection.Name = "chbDirection";
            this.chbDirection.Size = new System.Drawing.Size(84, 17);
            this.chbDirection.TabIndex = 27;
            this.chbDirection.Text = "Left to Right";
            this.chbDirection.UseVisualStyleBackColor = true;
            // 
            // cmbAngle
            // 
            this.cmbAngle.FormattingEnabled = true;
            this.cmbAngle.Location = new System.Drawing.Point(54, 24);
            this.cmbAngle.Name = "cmbAngle";
            this.cmbAngle.Size = new System.Drawing.Size(55, 21);
            this.cmbAngle.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 459);
            this.Controls.Add(this.cmbAngle);
            this.Controls.Add(this.chbDirection);
            this.Controls.Add(this.txbY2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbY1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbX2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbX1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chbBold);
            this.Controls.Add(this.txbH);
            this.Controls.Add(this.txbW);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.TextBox txbW;
        private System.Windows.Forms.TextBox txbH;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbX1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbX2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbY1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbY2;
        private System.Windows.Forms.CheckBox chbDirection;
        private System.Windows.Forms.ComboBox cmbAngle;
    }
}

