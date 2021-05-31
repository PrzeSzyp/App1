using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        int smallSize = 10;
        int bigSize = 20;
        int veryBigSize = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (radKur.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Italic);
            }
            else if (radPod.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Underline);
            }

            else if (radPog.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Bold);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////

            else if (radW3.Checked)
            {
                txt.Font = new Font(txt.Font.FontFamily, veryBigSize);
            }

            else if (radW2.Checked)
            {
                txt.Font = new Font(txt.Font.FontFamily, bigSize);
            }

            else if (radW1.Checked)
            {
                txt.Font = new Font(txt.Font.FontFamily, smallSize);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radColR.Checked)
            {
                txt.ForeColor = Color.Red;
            }

            else if (radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
            }

            else if (radColG.Checked)
            {
                txt.ForeColor = Color.Green;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radKur.Checked && radColR.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Italic);
                txt.ForeColor = Color.Red;
            }
            else if (radKur.Checked && radColB.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Italic);
                txt.ForeColor = Color.Blue;
            }
            else if (radKur.Checked && radColG.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Italic);
                txt.ForeColor = Color.Green;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radPog.Checked && radColR.Checked)
            {
                txt.ForeColor = Color.Red;
                txt.Font = new Font(txt.Font, FontStyle.Bold);

            }
            else if (radPog.Checked && radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
                txt.Font = new Font(txt.Font, FontStyle.Bold);

            }
            else if (radPog.Checked && radColG.Checked)
            {
                txt.Font = new Font(txt.Font, FontStyle.Bold);
                txt.ForeColor = Color.Green;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radPod.Checked && radColR.Checked)
            {
                txt.ForeColor = Color.Red;
                txt.Font = new Font(txt.Font, FontStyle.Underline);

            }
            else if (radPod.Checked && radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
                txt.Font = new Font(txt.Font, FontStyle.Underline);

            }
            else if (radPod.Checked && radColG.Checked)
            {
                txt.ForeColor = Color.Green;
                txt.Font = new Font(txt.Font, FontStyle.Underline);


            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radW1.Checked && radColR.Checked)
            {
                txt.ForeColor = Color.Red;
                txt.Font = new Font(txt.Font.FontFamily, smallSize);

            }
            else if (radW1.Checked && radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
                txt.Font = new Font(txt.Font.FontFamily, smallSize);

            }
            else if (this.radW1.Checked && this.radColG.Checked)
            {
                txt.ForeColor = Color.Green;
                txt.Font = new Font(txt.Font.FontFamily, smallSize);


            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radW2.Checked && radColR.Checked)
            {
                txt.ForeColor = Color.Red;
                txt.Font = new Font(txt.Font.FontFamily, bigSize);

            }
            else if (radW2.Checked && radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
                txt.Font = new Font(txt.Font.FontFamily, bigSize);

            }
            else if (this.radW2.Checked && this.radColG.Checked)
            {
                txt.ForeColor = Color.Green;
                txt.Font = new Font(txt.Font.FontFamily, bigSize);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (radW3.Checked && radColR.Checked)
            {
                txt.ForeColor = Color.Red;
                txt.Font = new Font(txt.Font.FontFamily, veryBigSize);

            }
            else if (radW3.Checked && radColB.Checked)
            {
                txt.ForeColor = Color.Blue;
                txt.Font = new Font(txt.Font.FontFamily, veryBigSize);

            }
            else if (this.radW3.Checked && this.radColG.Checked)
            {
                txt.ForeColor = Color.Green;
                txt.Font = new Font(txt.Font.FontFamily, veryBigSize);


            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void btnReset_Click(object sender, EventArgs e)
        {



            txt.Font = new Font(txt.Font.FontFamily,9,FontStyle.Regular);

            radW1.Checked = false;
            radW2.Checked = false;
            radW3.Checked = false;


        }

        private void btnReset2_Click(object sender, EventArgs e)
        {


            txt.Font = new Font(txt.Font, FontStyle.Regular);

            radPod.Checked = false;
            radKur.Checked = false;
            radPog.Checked = false;
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            txt.ForeColor = Color.Black;


            radColR.Checked = false;
            radColB.Checked = false;
            radColG.Checked = false;
        }
    }
}
