using System;
using System.Windows.Forms;
using FibGrokLib;

namespace FibGrokDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtPosition.Text, out n) && n >= 0)
            {
                FibonacciCalculator calc = new FibonacciCalculator();
                calc.Position = n;
                calc.Calculate();
                lblResult.Text = "Result: " + calc.Result;
            }
            else
            {
                lblResult.Text = "Invalid input! - HungLanBTVN";
            }
        }
    }
}