namespace Connectivity
{
    partial class DriverRegistration
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
            this.DriverIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DriverField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.InsertBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.SelectBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriverIDLabel
            // 
            this.DriverIDLabel.AutoSize = true;
            this.DriverIDLabel.Location = new System.Drawing.Point(50, 27);
            this.DriverIDLabel.Name = "DriverIDLabel";
            this.DriverIDLabel.Size = new System.Drawing.Size(55, 13);
            this.DriverIDLabel.TabIndex = 0;
            this.DriverIDLabel.Text = "Driver ID: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name: ";
            // 
            // DriverField
            // 
            this.DriverField.Location = new System.Drawing.Point(112, 27);
            this.DriverField.Name = "DriverField";
            this.DriverField.Size = new System.Drawing.Size(100, 20);
            this.DriverField.TabIndex = 2;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(112, 58);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 3;
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(112, 100);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(100, 63);
            this.AddressField.TabIndex = 4;
            this.AddressField.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(54, 100);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(51, 13);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Address: ";
            // 
            // InsertBut
            // 
            this.InsertBut.Location = new System.Drawing.Point(57, 193);
            this.InsertBut.Name = "InsertBut";
            this.InsertBut.Size = new System.Drawing.Size(75, 23);
            this.InsertBut.TabIndex = 7;
            this.InsertBut.Text = "Insert";
            this.InsertBut.UseVisualStyleBackColor = true;
            this.InsertBut.Click += new System.EventHandler(this.InsertBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(199, 193);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 8;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // SelectBut
            // 
            this.SelectBut.Location = new System.Drawing.Point(57, 246);
            this.SelectBut.Name = "SelectBut";
            this.SelectBut.Size = new System.Drawing.Size(75, 23);
            this.SelectBut.TabIndex = 9;
            this.SelectBut.Text = "Select";
            this.SelectBut.UseVisualStyleBackColor = true;
            this.SelectBut.Click += new System.EventHandler(this.SelectBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(199, 246);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateBut.TabIndex = 10;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // DriverRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 320);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SelectBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.InsertBut);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.DriverField);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DriverIDLabel);
            this.Name = "DriverRegistration";
            this.Text = "Driver Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DriverIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DriverField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.RichTextBox AddressField;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button InsertBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button SelectBut;
        private System.Windows.Forms.Button UpdateBut;
    }
}

