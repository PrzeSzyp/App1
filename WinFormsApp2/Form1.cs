using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
       Double value = 0;
        String action = "";
        bool action_btn_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (action_btn_pressed == true))
                txtResult.Clear();
            Button b = (Button)sender;
            txtResult.Text = txtResult.Text + b.Text;
        }



        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            action = b.Text;
            value = Double.Parse(txtResult.Text);
            action_btn_pressed = true;

        }
        private void btnCls_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
                txtResult.Text = "0";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch(action)
            {

                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;

                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;

                case "x":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;

                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;

                default:
                    break;

            }
            action_btn_pressed = false;
        }
    }
}
