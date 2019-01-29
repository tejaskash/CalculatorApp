using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        char OperatorUsed;
        double FirstOperand;
        double SecondOperand;
        double Result;
        double Operand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MainInputText.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MainInputText.AppendText(".");
        }


        private void button11_Click(object sender, EventArgs e)
        {
            
            if(OperatorUsed=='q'|| OperatorUsed == 'r' || OperatorUsed == 's' || OperatorUsed == 'c')
            {

            }
            else
            {
                string SecondOperandText = MainInputText.Text;
                SecondOperand = Convert.ToDouble(SecondOperandText);
            }
            switch(OperatorUsed)
            {
                case '+': Result = FirstOperand + SecondOperand; break;
                case '-': Result = FirstOperand - SecondOperand; break;
                case '*': Result = FirstOperand * SecondOperand;break;
                case 'd': Result = FirstOperand / SecondOperand;break;
                case 'q': Result = Operand * Operand;break;
                case 'r': Result = Math.Sqrt(Operand);break;
                case 's': Result = Math.Sin(Operand);break;
                case 'c': Result = Math.Cos(Operand);break;

            }
            SubTextBox.ResetText();
            SubTextBox.AppendText(Convert.ToString(Result));
            MainInputText.ResetText();
            MainInputText.AppendText(Convert.ToString(Result));
        }


        private void button15_Click(object sender, EventArgs e)
        {
            string FirstOperandText = MainInputText.Text;
            FirstOperand = Convert.ToDouble(FirstOperandText);
            SubTextBox.AppendText(MainInputText.Text + "-");
            MainInputText.ResetText();
            OperatorUsed = '-';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string FirstOperandText = MainInputText.Text;
            FirstOperand = Convert.ToDouble(FirstOperandText);
            SubTextBox.AppendText(MainInputText.Text + "*");
            MainInputText.ResetText();
            OperatorUsed = '*';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string FirstOperandText = MainInputText.Text;
            FirstOperand = Convert.ToDouble(FirstOperandText);
            SubTextBox.AppendText(MainInputText.Text + "/");
            MainInputText.ResetText();
            OperatorUsed = 'd';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string OperandText = MainInputText.Text;
            Operand = Convert.ToDouble(OperandText);
            MainInputText.ResetText();
            MainInputText.AppendText("\x00B2");
            OperatorUsed = 'q';
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            string FirstOperandText = MainInputText.Text;
            FirstOperand = Convert.ToDouble(FirstOperandText);
            SubTextBox.AppendText(MainInputText.Text + "+");
            MainInputText.ResetText();
            OperatorUsed = '+';
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MainInputText.Text = MainInputText.Text.Remove(MainInputText.Text.Length - 1, 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainInputText.ResetText();
            SubTextBox.ResetText();
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            string OperandText = MainInputText.Text;
            Operand = Convert.ToDouble(OperandText);
            MainInputText.ResetText();
            MainInputText.AppendText("√"+MainInputText.Text);
            OperatorUsed = 'r';
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            string OperandText = MainInputText.Text;
            Operand = Convert.ToDouble(OperandText);
            Operand = Operand * (Math.PI/ 180);
            MainInputText.ResetText();
            MainInputText.AppendText("sin(" + MainInputText.Text+")");
            OperatorUsed = 's';
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            string OperandText = MainInputText.Text;
            Operand = Convert.ToDouble(OperandText);
            Operand = Operand * (Math.PI/180);
            MainInputText.ResetText();
            MainInputText.AppendText("cos(" + MainInputText.Text+")");
            OperatorUsed = 'c';
        }
    }
}
