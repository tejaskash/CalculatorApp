using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DobPicker.Hide();
            DobPicker.MaxSelectionCount = 1;
        }

        private void HeadingLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void DobTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DobPicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = DobPicker.SelectionRange.Start.ToShortDateString();
            DobTextBox.AppendText(date);
        }

        private void DobTextBox_Click(object sender, EventArgs e)
        {
            DobPicker.Show();
            DobPicker.BringToFront();
        }

        private void DobPicker_MouseCaptureChanged(object sender, EventArgs e)
        {
            DobPicker.Hide();
        }

        private void DobTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string dob = DobTextBox.Text;
    }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string studname = NameTextBox.Text;
        }

        private void RegNoBox_TextChanged(object sender, EventArgs e)
        {
            string regno = RegNoBox.Text;
        }

        private void YearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = YearCombo.SelectedText;
            Console.WriteLine(year);
        }

        private void AddrTextBox_TextChanged(object sender, EventArgs e)
        {
            string addr = AddrTextBox.Text;
        }

        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if(AddrTextBox.Text.Equals("")||NameTextBox.Text.Equals("")||DobTextBox.Text.Equals("")||RegNoBox.Text.Equals(""))
            {
                MessageBox.Show("Some Fields Are Empty, Kindly Fill The Required Fields");
            }
            if(!MitRadio.Checked&&!SocRadio.Checked&&!KmcRadio.Checked&&!FoaRadio.Checked)
            {
                MessageBox.Show("Please Select Your College");
            }
            if (!TcCheck.Checked)
            {
                MessageBox.Show("Please Agree to T&C");
            }

            else
            {
                MessageBox.Show("Your Entered Details Are: \n" + "Name: " + NameTextBox.Text + "\nDob: " + DobTextBox.Text + "\nRegistration Number: " + RegNoBox.Text + "\nYear: " + YearCombo.SelectedText + "\nAddress: " + AddrTextBox.Text);
                this.Dispose();
             }

        }
    }
}
