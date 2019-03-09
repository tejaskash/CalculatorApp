using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Connectivity
{
    public partial class DriverRegistration : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public DriverRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertBut_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ictorcl;User ID=it1096;Password=student";
            conn = new OracleConnection(oradb);
            try
            {
                conn.Open();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "INSERT INTO PERSON VALUES('" + DriverField.Text + "','" + NameField.Text + "','" + AddressField.Text + "')";
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Inserted!");
                conn.Close();
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            DeletePage dp = new DeletePage();
            dp.Show();
        }

        private void SelectBut_Click(object sender, EventArgs e)
        {
            SelectPage sp = new SelectPage();
            sp.Show();
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            UpdatePage up = new UpdatePage();
            up.Show();
        }
    }
}
