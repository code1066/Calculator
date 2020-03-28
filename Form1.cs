using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string selectOperator;
        bool clearFlag;
        public Form1()
        {
            InitializeComponent();
            clearFlag = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            selectOperator = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            selectOperator = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "0";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "4";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "7";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "6";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "5";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "9";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "8";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(textBox1.Text);
            clearFlag = true;

            if (selectOperator == "+") { result = firstNumber + secondNumber; textBox1.Text = Convert.ToString(result); firstNumber = result; }
            if (selectOperator == "-") { result = firstNumber - secondNumber; textBox1.Text = Convert.ToString(result); firstNumber = result; }
            if (selectOperator == "*") { result = firstNumber * secondNumber; textBox1.Text = Convert.ToString(result); firstNumber = result; }
            if (selectOperator == "/") { if (secondNumber == 0) { textBox1.Text = "Divide By Zero"; } else { result = firstNumber / secondNumber; textBox1.Text = Convert.ToString(result); firstNumber = result; } }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            selectOperator = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double value;
            value = 0 - Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(value);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            selectOperator = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "1";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "2";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || clearFlag)
            {
                textBox1.Text = "3";
                clearFlag = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
