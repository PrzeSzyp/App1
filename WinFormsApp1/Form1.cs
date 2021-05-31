using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double num1, num2, num3, result;

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            num3 = Convert.ToDouble(txtNum3.Text);
            result = num1 + num2 + num3;
            txtResult.Text = result.ToString();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIlo_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            num3 = Convert.ToDouble(txtNum3.Text);
            result = num1 * num2 * num3;
            txtResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtResult.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
