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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string user = UserText.Text;
            string pass = PassText.Text;
            int index = Array.IndexOf(Users.names, user);
            Users.index = index;
            switch (index)
            {
                case -1: MessageBox.Show("User Does Not Exist"); break;
                case 0: if (Users.pass[index].Equals(pass)) { CustomerPortal cp = new CustomerPortal(); cp.Show(); this.Hide(); }
                    else { MessageBox.Show("Invalid Credentials"); } break;
                case 1: if (Users.pass[index].Equals(pass)) { CustomerPortal cp = new CustomerPortal(); cp.Show(); this.Hide(); }
                    else { MessageBox.Show("Invalid Credentials"); } break;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
            this.Hide();
        }
    }
}
