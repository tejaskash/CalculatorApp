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
    public partial class SelectPage : Form
    {
        OracleConnection conn;
        OracleCommand comm = new OracleCommand();
        OracleCommand comm1 = new OracleCommand();
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public SelectPage()
        {
            InitializeComponent();
        }

        private void SelectPage_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ictorcl;User ID=it1096;Password=student";
            conn = new OracleConnection(oradb);
            comm.CommandText = "SELECT * FROM PERSON";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_PERSON");
            dt = ds.Tables["Tbl_PERSON"];
            int t = dt.Rows.Count;
            int found = 0;
            for (i = 0; i < t; i++)
            {

                dr = dt.Rows[i];
                string did = dr["DRIVERID"].ToString();
                if (did == textBox1.Text)
                {
                    found = 1;
                    break;
                }
            }
            if (found == 0)
            {
                MessageBox.Show("DriverID Does Not Exist");
                conn.Close();
                this.Hide();
                this.Dispose();
            }
            else
            {
                comm1.CommandText = "SELECT * FROM PERSON WHERE DRIVERID = '"+textBox1.Text+"'";
                comm1.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Tbl_PERSON");
                dt = ds.Tables["Tbl_PERSON"];
                dr = dt.Rows[0];
                richTextBox1.AppendText("Driver ID: " + dr["DRIVERID"].ToString() + "\n" + "Name: " + dr["NAME"].ToString() + "\n" + "Address: " + dr["ADDRESS"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
