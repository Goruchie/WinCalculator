using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            try
            {
                a = int.Parse(firstNumTb.Text);
                b = int.Parse(secondNumTb.Text);

                switch (result)
                {
                    case "+":
                        c = a + b;
                        resultLbl.Text = "" + c;
                        break;
                    case "-":
                        c = a - b;
                        resultLbl.Text = "" + c;
                        break;
                    case "*":
                        c = a * b;
                        resultLbl.Text = "" + c;
                        break;
                    case "/":
                        c = a / b;
                        resultLbl.Text = "" + c;
                        break;
                    default:
                        MessageBox.Show("Please, select an operation to calculate...");
                        break;
                }         
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Kindly, use only numbers to calculate...");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("It's not possible to divide a number by zero...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred, please report it to the provider...");
            }
        }

        private void rBtnPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPlus.Checked)
            {
                result = "+";
            }
        }

        private void rBtnMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMinus.Checked)
            {
                result = "-";
            }
        }

        private void rBtnMultiply_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMultiply.Checked)
            {
                result = "*";
            }
        }

        private void rBtnDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDivide.Checked)
            {
                result = "/";
            }
        }
    }
}
