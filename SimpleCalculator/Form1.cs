using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationalSigns = string.Empty;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = (Double.Parse(textBox_result.Text) / 100).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox_result.Text = (Double.Parse(textBox_result.Text) * Double.Parse(textBox_result.Text)).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox_result.Text = (1 / Double.Parse(textBox_result.Text)).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox_result.Text = Math.Sqrt(Double.Parse(textBox_result.Text)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0")
            {
                textBox_result.Clear();
            }
            Button button = (Button)sender;
            textBox_result.Text += button.Text;
        }

        private void Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || (isOperationPerformed))
            {
                textBox_result.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text += button.Text;
                }
            }

            else
            {
                textBox_result.Text += button.Text;
            }
           
        }

        private void Operational_Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationalSigns = button.Text;
            result = Double.Parse(textBox_result.Text);
            currentDisplay.Text = result + "" + operationalSigns;
            isOperationPerformed = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch(operationalSigns)
            {
                case "+":
                    textBox_result.Text =  (result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    double divisor = Double.Parse(textBox_result.Text);
                    if (divisor != 0)
                    {
                        textBox_result.Text = (result / divisor).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error: Can't Divide 0 by 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;

                default:
                    break;
            }

            result = double.Parse(textBox_result.Text);
            currentDisplay.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                if (textBox_result.Text.Length > 0)
                {
                textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1);
                }
         
        }
    }
}
