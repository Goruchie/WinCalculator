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
            a = int.Parse(firstNumTb.Text);
            b = int.Parse(secondNumTb.Text);
            c = a + b;
            resultLbl.Text = "= " + c;
        }
    }
}
