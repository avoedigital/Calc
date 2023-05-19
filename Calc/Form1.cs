using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form 
    {
        private double firstNum = 0;
        private string operatorUsed = "";
        private bool isOperatorUsed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperatorUsed)
                txtDisplay.Clear();

            isOperatorUsed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;

        }

      public void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorUsed = button.Text;
            firstNum = double.Parse(txtDisplay.Text);
            isOperatorUsed = true;


        }

        public void button16_Click(object sender, EventArgs e)
        {
            double secondNum = Convert.ToDouble(txtDisplay.Text);

            

            switch (operatorUsed)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum); 
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum); 
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        txtDisplay.Text = Convert.ToString(firstNum / secondNum); 
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                    }
                    break;
                default:
                    break;
            }

            operatorUsed = "";
            isOperatorUsed = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNum = 0;
            operatorUsed = "";
            isOperatorUsed = false;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
