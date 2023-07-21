using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form

    {
        double num1, num2, total ;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbnDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedItem.Equals("+"))
            {
                total = num1 + num2;
                lbnDisplayTotal.Text = total.ToString();

            }
            else
                if (cbOperator.SelectedItem.Equals("-"))
            {
                total = num1 - num2;
                lbnDisplayTotal.Text = total.ToString();
            }
            else
                if (cbOperator.SelectedItem.Equals("*"))
            {
                total = num1 * num2;
                lbnDisplayTotal.Text = total.ToString();
            }
            else
                if (cbOperator.SelectedItem.Equals("/"))
            {
                total = num1 / num2;
                lbnDisplayTotal.Text = total.ToString();
            }












        }
    }
}
