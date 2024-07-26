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
                c = a / b;
                resultLbl.Text = "= " + c;
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
    }
}
