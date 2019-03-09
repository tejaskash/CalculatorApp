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
    public partial class UpdatePage : Form
    {
        OracleConnection conn;
        OracleCommand comm = new OracleCommand();
        OracleCommand comm1 = new OracleCommand();
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public UpdatePage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                textBox2.AppendText(dr["DRIVERID"].ToString());
                textBox3.AppendText(dr["NAME"].ToString());
                textBox4.AppendText(dr["ADDRESS"].ToString());
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ictorcl;User ID=it1096;Password=student";
            conn = new OracleConnection(oradb);
            try
            {
                conn.Open();
                OracleCommand cm = new OracleCommand();
                OracleCommand cm1 = new OracleCommand();
                cm.Connection = conn;
                cm1.Connection = conn;
                cm.CommandText = "UPDATE PERSON SET NAME = '"+textBox3.Text+"' WHERE DRIVERID ='"+textBox1.Text+"'";
                cm.CommandType = CommandType.Text;
                cm1.CommandText = "UPDATE PERSON SET ADDRESS = '" + textBox4.Text + "' WHERE DRIVERID ='" + textBox1.Text + "'";
                cm1.CommandType = CommandType.Text;
                cm1.ExecuteNonQuery();
                MessageBox.Show("Updated!");
                cm.CommandText = "COMMIT";
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
            this.Dispose();
        }
        }
        }

