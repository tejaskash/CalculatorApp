using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.ShowDialog();
            try
            {
                string FileName = ofd.FileName;
                StreamReader sr = new StreamReader(FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select A File");
            }
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save";
            sfd.ShowDialog();
            try
            {
                string FileName = sfd.FileName;
                StreamWriter sw = new StreamWriter(FileName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter File Name");
            }
           
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK) 
            { 
                richTextBox1.SelectionFont = fd.Font; 
                richTextBox1.SelectionColor = fd.Color; 
            }
}

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            richTextBox1.SelectionColor = cd.Color;
        }
        }
    }
