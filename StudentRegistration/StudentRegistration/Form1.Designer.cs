namespace StudentRegistration
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DobPicker = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.DobTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegNoBox = new System.Windows.Forms.TextBox();
            this.MitRadio = new System.Windows.Forms.RadioButton();
            this.FoaRadio = new System.Windows.Forms.RadioButton();
            this.SocRadio = new System.Windows.Forms.RadioButton();
            this.KmcRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TcCheck = new System.Windows.Forms.CheckBox();
            this.SubmitBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddrTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(140, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(325, 29);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Student Registration Portal";
            this.HeadingLabel.Click += new System.EventHandler(this.HeadingLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name    :";
            // 
            // DobPicker
            // 
            this.DobPicker.Location = new System.Drawing.Point(199, 123);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.TabIndex = 4;
            this.DobPicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DobPicker_DateChanged);
            this.DobPicker.MouseCaptureChanged += new System.EventHandler(this.DobPicker_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "DOB      :";
            // 
            // DobTextBox
            // 
            this.DobTextBox.Location = new System.Drawing.Point(199, 123);
            this.DobTextBox.Name = "DobTextBox";
            this.DobTextBox.Size = new System.Drawing.Size(185, 20);
            this.DobTextBox.TabIndex = 6;
            this.DobTextBox.Click += new System.EventHandler(this.DobTextBox_Click);
            this.DobTextBox.TextChanged += new System.EventHandler(this.DobTextBox_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registration No.     :";
            // 
            // RegNoBox
            // 
            this.RegNoBox.Location = new System.Drawing.Point(199, 169);
            this.RegNoBox.Name = "RegNoBox";
            this.RegNoBox.Size = new System.Drawing.Size(185, 20);
            this.RegNoBox.TabIndex = 10;
            this.RegNoBox.TextChanged += new System.EventHandler(this.RegNoBox_TextChanged);
            // 
            // MitRadio
            // 
            this.MitRadio.AutoSize = true;
            this.MitRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MitRadio.Location = new System.Drawing.Point(196, 228);
            this.MitRadio.Name = "MitRadio";
            this.MitRadio.Size = new System.Drawing.Size(51, 22);
            this.MitRadio.TabIndex = 11;
            this.MitRadio.TabStop = true;
            this.MitRadio.Text = "MIT";
            this.MitRadio.UseVisualStyleBackColor = true;
            // 
            // FoaRadio
            // 
            this.FoaRadio.AutoSize = true;
            this.FoaRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoaRadio.Location = new System.Drawing.Point(253, 228);
            this.FoaRadio.Name = "FoaRadio";
            this.FoaRadio.Size = new System.Drawing.Size(59, 22);
            this.FoaRadio.TabIndex = 12;
            this.FoaRadio.TabStop = true;
            this.FoaRadio.Text = "FOA";
            this.FoaRadio.UseVisualStyleBackColor = true;
            // 
            // SocRadio
            // 
            this.SocRadio.AutoSize = true;
            this.SocRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocRadio.Location = new System.Drawing.Point(318, 228);
            this.SocRadio.Name = "SocRadio";
            this.SocRadio.Size = new System.Drawing.Size(61, 22);
            this.SocRadio.TabIndex = 13;
            this.SocRadio.TabStop = true;
            this.SocRadio.Text = "SOC";
            this.SocRadio.UseVisualStyleBackColor = true;
            // 
            // KmcRadio
            // 
            this.KmcRadio.AutoSize = true;
            this.KmcRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmcRadio.Location = new System.Drawing.Point(385, 228);
            this.KmcRadio.Name = "KmcRadio";
            this.KmcRadio.Size = new System.Drawing.Size(62, 22);
            this.KmcRadio.TabIndex = 14;
            this.KmcRadio.TabStop = true;
            this.KmcRadio.Text = "KMC";
            this.KmcRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "College           :";
            // 
            // YearCombo
            // 
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.YearCombo.Location = new System.Drawing.Point(196, 279);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(121, 21);
            this.YearCombo.TabIndex = 16;
            this.YearCombo.Text = "Select";
            this.YearCombo.SelectedIndexChanged += new System.EventHandler(this.YearCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Year                :";
            // 
            // TcCheck
            // 
            this.TcCheck.AutoSize = true;
            this.TcCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcCheck.Location = new System.Drawing.Point(199, 402);
            this.TcCheck.Name = "TcCheck";
            this.TcCheck.Size = new System.Drawing.Size(348, 22);
            this.TcCheck.TabIndex = 19;
            this.TcCheck.Text = "I agree to all the terms and conditions of usage";
            this.TcCheck.UseVisualStyleBackColor = true;
            // 
            // SubmitBut
            // 
            this.SubmitBut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBut.Location = new System.Drawing.Point(280, 440);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(87, 35);
            this.SubmitBut.TabIndex = 20;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.Click += new System.EventHandler(this.SubmitBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address         :";
            // 
            // AddrTextBox
            // 
            this.AddrTextBox.Location = new System.Drawing.Point(196, 321);
            this.AddrTextBox.Multiline = true;
            this.AddrTextBox.Name = "AddrTextBox";
            this.AddrTextBox.Size = new System.Drawing.Size(188, 58);
            this.AddrTextBox.TabIndex = 22;
            this.AddrTextBox.TextChanged += new System.EventHandler(this.AddrTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(199, 68);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(185, 20);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 498);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddrTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubmitBut);
            this.Controls.Add(this.TcCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YearCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KmcRadio);
            this.Controls.Add(this.SocRadio);
            this.Controls.Add(this.FoaRadio);
            this.Controls.Add(this.MitRadio);
            this.Controls.Add(this.RegNoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DobTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DobPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "Form1";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar DobPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DobTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RegNoBox;
        private System.Windows.Forms.RadioButton MitRadio;
        private System.Windows.Forms.RadioButton FoaRadio;
        private System.Windows.Forms.RadioButton SocRadio;
        private System.Windows.Forms.RadioButton KmcRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox TcCheck;
        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddrTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

