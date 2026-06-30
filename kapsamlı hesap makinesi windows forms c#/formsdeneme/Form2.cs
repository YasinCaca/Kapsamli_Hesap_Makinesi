using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsdeneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.Add("Toplama");
            comboBox1.Items.Add("Çıkarma");
            comboBox1.Items.Add("Çarpma");
            comboBox1.Items.Add("Bölme");

            textBox1.TextChanged += Sonuc;
            textBox2.TextChanged += Sonuc;
            comboBox1.TextChanged += Sonuc;
        }
        private void Sonuc(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    label4.Hide();
                    if (comboBox1.SelectedIndex == 0)
                    {
                        double a = double.Parse(textBox1.Text);
                        double b = double.Parse(textBox2.Text);
                        double c = a + b;
                        string d = Convert.ToString(c);
                        textBox4.Text = d;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        double a = double.Parse(textBox1.Text);
                        double b = double.Parse(textBox2.Text);
                        double c = a - b;
                        string d = Convert.ToString(c);
                        textBox4.Text = d;
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        double a = double.Parse(textBox1.Text);
                        double b = double.Parse(textBox2.Text);
                        double c = a * b;
                        string d = Convert.ToString(c);
                        textBox4.Text = d;
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        double a = double.Parse(textBox1.Text);
                        double b = double.Parse(textBox2.Text);
                        double c = a / b;
                        string d = Convert.ToString(a / b);
                        textBox4.Text = d;
                    }
                }
                else { label4.Show(); textBox4.Text = ""; }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttondif.Visible is true)
            {
                buttondif.Hide();
                buttonturev.Hide();
                buttonderece.Hide();
                buttonsayi.Hide();
            }
            else
            {
                buttondif.Show(); 
                buttonturev.Show();
                buttonderece.Show();
                buttonsayi.Show();
            }
        }

        private void buttonderece_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
       
    }
}
