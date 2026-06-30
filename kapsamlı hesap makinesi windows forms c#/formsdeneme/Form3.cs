using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsdeneme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(text2.Text);
            double b = double.Parse(text1.Text);
            double c = double.Parse(textSbt.Text);
            double d = (b * b) - 4 * a * c;
            if (d < 0)
            {
                d = -d;
                double disc = Math.Sqrt(d);
                double x1 = (-b ) / 2 * a;
                double x2 = (-b ) / 2 * a;
                textx1.Text = (Convert.ToString(x1)+"+"+Convert.ToString(disc/2*a)+" i");
                textx2.Text = (Convert.ToString(x2)+Convert.ToString(-disc/2*a)+" i");
            }
            else
            {
                double disc = Math.Sqrt(d);
                double x1 = (-b + disc) / 2 * a;
                double x2 = (-b - disc) / 2 * a;
                textx1.Text = Convert.ToString(x1);
                textx2.Text = Convert.ToString(x2);
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (text1.Visible is true)
            {
                text1.Visible = false;
                text2.Visible = false;
                textSbt.Visible = false;
                textx1.Visible = false;
                textx2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
            }
            else
            {
                text1.Visible = true;
                text2.Visible = true;
                textSbt.Visible = true;
                textx1.Visible = true;
                textx2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                button1.Visible = true;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
