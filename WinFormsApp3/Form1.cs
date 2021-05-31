using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnObl_Click(object sender, EventArgs e)
        {
            double wzrost = Convert.ToDouble(txtWzr.Text);
            double wagaSt = wzrost - 100;
            double result;
            if((radK.Checked || radM.Checked) && checkStd.Checked)
            {
                result = wzrost - 100;
                txtResult.Text = "Twoja odpowiednia waga to " + result;
            }
            else if (radK.Checked && checkIde.Checked)
            {
                
                result = wagaSt * 0.85;
                txtResult.Text = "Twoja odpowiednia waga to " + result;
            }
            else if (radM.Checked && checkIde.Checked)
            {
                
                result = wagaSt * 0.9;
                txtResult.Text = "Twoja odpowiednia waga to " + result;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radK.Checked = false;
            radM.Checked = false;
            checkStd.Checked = false;
            checkIde.Checked = false;
            txtWzr.Clear();
            txtResult.Clear();
        }
    }
}
