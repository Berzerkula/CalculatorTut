using System;
using System.Windows.Forms;

namespace CalculatorTut
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "0";
            this.mantissa.Text += input;
        }

        private void period_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += ".";
            this.mantissa.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "1";
            this.mantissa.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "2";
            this.mantissa.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "3";
            this.mantissa.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "4";
            this.mantissa.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "5";
            this.mantissa.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "6";
            this.mantissa.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "7";
            this.mantissa.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "8";
            this.mantissa.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.mantissa.Text = "";
            input += "9";
            this.mantissa.Text += input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                result = num1 + num2;
                mantissa.Text = result.ToString();
            }
            else if(operation == '-')
            {
                result = num1 - num2;
                mantissa.Text = result.ToString();
            }
            else if(operation == '*')
            {
                result = num1 * num2;
                mantissa.Text = result.ToString();
            }
            else if(operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    mantissa.Text = result.ToString();
                }
                else
                {
                    mantissa.Text = "DIV/Zero!";
                }
            }
            this.input = string.Empty;
        }
    }
}
