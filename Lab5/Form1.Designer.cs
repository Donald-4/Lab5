namespace Lab5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblRollName = new System.Windows.Forms.Label();
            this.btnSwapNumbers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.grpOneRoll = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.radOneRoll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRollStats = new System.Windows.Forms.RadioButton();
            this.grpMarkStats = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSeed = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.grpOneRoll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMarkStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dice 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dice 2:";
            // 
            // lblDice1
            // 
            this.lblDice1.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDice1.Location = new System.Drawing.Point(119, 28);
            this.lblDice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(59, 34);
            this.lblDice1.TabIndex = 2;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(7, 174);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(118, 72);
            this.btnRollDice.TabIndex = 5;
            this.btnRollDice.Text = "&Roll \r\nDice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblRollName
            // 
            this.lblRollName.BackColor = System.Drawing.Color.LightSalmon;
            this.lblRollName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRollName.Location = new System.Drawing.Point(156, 110);
            this.lblRollName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRollName.Name = "lblRollName";
            this.lblRollName.Size = new System.Drawing.Size(217, 34);
            this.lblRollName.TabIndex = 7;
            this.lblRollName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwapNumbers
            // 
            this.btnSwapNumbers.Location = new System.Drawing.Point(136, 174);
            this.btnSwapNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSwapNumbers.Name = "btnSwapNumbers";
            this.btnSwapNumbers.Size = new System.Drawing.Size(118, 72);
            this.btnSwapNumbers.TabIndex = 8;
            this.btnSwapNumbers.Text = "&Swap Numbers";
            this.btnSwapNumbers.UseVisualStyleBackColor = true;
            this.btnSwapNumbers.Click += new System.EventHandler(this.btnSwapNumbers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Roll Name:";
            // 
            // lblDice2
            // 
            this.lblDice2.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDice2.Location = new System.Drawing.Point(119, 69);
            this.lblDice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(59, 34);
            this.lblDice2.TabIndex = 6;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOneRoll
            // 
            this.grpOneRoll.Controls.Add(this.btnClear);
            this.grpOneRoll.Controls.Add(this.label1);
            this.grpOneRoll.Controls.Add(this.label2);
            this.grpOneRoll.Controls.Add(this.btnSwapNumbers);
            this.grpOneRoll.Controls.Add(this.lblDice1);
            this.grpOneRoll.Controls.Add(this.lblDice2);
            this.grpOneRoll.Controls.Add(this.lblRollName);
            this.grpOneRoll.Controls.Add(this.btnRollDice);
            this.grpOneRoll.Controls.Add(this.label7);
            this.grpOneRoll.Location = new System.Drawing.Point(11, 88);
            this.grpOneRoll.Name = "grpOneRoll";
            this.grpOneRoll.Size = new System.Drawing.Size(390, 255);
            this.grpOneRoll.TabIndex = 9;
            this.grpOneRoll.TabStop = false;
            this.grpOneRoll.Text = "One Roll";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 174);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 72);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear \r\nOne Roll";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radOneRoll
            // 
            this.radOneRoll.AutoSize = true;
            this.radOneRoll.Location = new System.Drawing.Point(30, 29);
            this.radOneRoll.Name = "radOneRoll";
            this.radOneRoll.Size = new System.Drawing.Size(97, 22);
            this.radOneRoll.TabIndex = 10;
            this.radOneRoll.TabStop = true;
            this.radOneRoll.Text = "One Roll";
            this.radOneRoll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRollStats);
            this.groupBox1.Controls.Add(this.radOneRoll);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // radRollStats
            // 
            this.radRollStats.AutoSize = true;
            this.radRollStats.Location = new System.Drawing.Point(588, 29);
            this.radRollStats.Name = "radRollStats";
            this.radRollStats.Size = new System.Drawing.Size(115, 22);
            this.radRollStats.TabIndex = 11;
            this.radRollStats.TabStop = true;
            this.radRollStats.Text = "Mark Stats";
            this.radRollStats.UseVisualStyleBackColor = true;
            // 
            // grpMarkStats
            // 
            this.grpMarkStats.Controls.Add(this.btnReset);
            this.grpMarkStats.Controls.Add(this.btnGenerate);
            this.grpMarkStats.Controls.Add(this.lblFail);
            this.grpMarkStats.Controls.Add(this.lblPass);
            this.grpMarkStats.Controls.Add(this.lblAverage);
            this.grpMarkStats.Controls.Add(this.lstMarks);
            this.grpMarkStats.Controls.Add(this.label6);
            this.grpMarkStats.Controls.Add(this.label5);
            this.grpMarkStats.Controls.Add(this.label4);
            this.grpMarkStats.Controls.Add(this.chkSeed);
            this.grpMarkStats.Controls.Add(this.label3);
            this.grpMarkStats.Controls.Add(this.nudNumber);
            this.grpMarkStats.Location = new System.Drawing.Point(409, 88);
            this.grpMarkStats.Name = "grpMarkStats";
            this.grpMarkStats.Size = new System.Drawing.Size(486, 255);
            this.grpMarkStats.TabIndex = 12;
            this.grpMarkStats.TabStop = false;
            this.grpMarkStats.Text = "Mark Stats";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(214, 174);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 72);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "&Reset \r\nStats";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(47, 174);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 72);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "&Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblFail
            // 
            this.lblFail.BackColor = System.Drawing.Color.MistyRose;
            this.lblFail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFail.Location = new System.Drawing.Point(121, 95);
            this.lblFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(105, 34);
            this.lblFail.TabIndex = 12;
            this.lblFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.MistyRose;
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPass.Location = new System.Drawing.Point(121, 58);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(105, 34);
            this.lblPass.TabIndex = 11;
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.MistyRose;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(121, 133);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(105, 34);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.ItemHeight = 18;
            this.lstMarks.Location = new System.Drawing.Point(364, 19);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(105, 220);
            this.lstMarks.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pass:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // chkSeed
            // 
            this.chkSeed.AutoSize = true;
            this.chkSeed.Location = new System.Drawing.Point(214, 23);
            this.chkSeed.Name = "chkSeed";
            this.chkSeed.Size = new System.Drawing.Size(118, 22);
            this.chkSeed.TabIndex = 2;
            this.chkSeed.Text = "Seed Value";
            this.chkSeed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marks:";
            // 
            // nudNumber
            // 
            this.nudNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Location = new System.Drawing.Point(102, 23);
            this.nudNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(87, 26);
            this.nudNumber.TabIndex = 0;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 356);
            this.Controls.Add(this.grpMarkStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOneRoll);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5 by ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOneRoll.ResumeLayout(false);
            this.grpOneRoll.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMarkStats.ResumeLayout(false);
            this.grpMarkStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblRollName;
        private System.Windows.Forms.Button btnSwapNumbers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.GroupBox grpOneRoll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radOneRoll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRollStats;
        private System.Windows.Forms.GroupBox grpMarkStats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox chkSeed;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
    }
}

