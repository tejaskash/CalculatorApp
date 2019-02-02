using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (UserText.Text.Equals("cust1"))
            {
                index = 0;
            }
            else
            {
                index = 1;
            }
            if (!OldPassText.Text.Equals(NewPassText.Text))
            {
                MessageBox.Show("Passwords Do Not Match");
            }
            else
            {
                Users.pass[index] = NewPassText.Text;
                MessageBox.Show("Password Has Been Changed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }
    }
}
