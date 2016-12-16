using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }


           
        private void button1_Click(object sender, EventArgs e)
        {
            // FROM 10 TO Other
            if (radioButton1.Checked && radioButton5.Checked )
            {
                textBox2.Text = textBox1.Text;
            }
            else if (radioButton1.Checked && radioButton6.Checked)
            {
                int number = int.Parse(textBox1.Text);
                string Base = Convert.ToString(number, 2);
                textBox2.Text = Base;
            }
            else if (radioButton1.Checked && radioButton7.Checked)
            {
                int number = int.Parse(textBox1.Text);
                string Base = Convert.ToString(number, 8);
                textBox2.Text = Base;
            }
            else if (radioButton1.Checked && radioButton8.Checked)
            {
                int number = int.Parse(textBox1.Text);
                string Base = Convert.ToString(number, 16);
                textBox2.Text = Base;
            }


            // FROM 2 TO OTHER
            else if (radioButton2.Checked && radioButton5.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 2);
                string Base = Convert.ToString(number, 10);
                textBox2.Text = Base;
            }

            else if (radioButton2.Checked && radioButton6.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 2);
                string Base = Convert.ToString(number, 2);
                textBox2.Text = Base;
            }
            else if (radioButton2.Checked && radioButton7.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 2);
                string Base = Convert.ToString(number, 8);
                textBox2.Text = Base;
            }
            else if (radioButton2.Checked && radioButton8.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 2);
                string Base = Convert.ToString(number, 16);
                textBox2.Text = Base;
            }

            //FROM 8 TO OTHER
            else if (radioButton3.Checked && radioButton5.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 8);
                string Base = Convert.ToString(number, 10);
                textBox2.Text = Base;
            }
            else if (radioButton3.Checked && radioButton6.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 8);
                string Base = Convert.ToString(number, 2);
                textBox2.Text = Base;
            }
            else if (radioButton3.Checked && radioButton7.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 8);
                string Base = Convert.ToString(number, 8);
                textBox2.Text = Base;
            }
            else if (radioButton3.Checked && radioButton8.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 8);
                string Base = Convert.ToString(number, 16);
                textBox2.Text = Base;
            }
            // FROM 16 TO OTHER
            else if (radioButton4.Checked && radioButton5.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 16);
                string Base = Convert.ToString(number, 10);
                textBox2.Text = Base;
            }
            else if (radioButton4.Checked && radioButton6.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 16);
                string Base = Convert.ToString(number, 2);
                textBox2.Text = Base;
            }
            else if (radioButton4.Checked && radioButton7.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 16);
                string Base = Convert.ToString(number, 8);
                textBox2.Text = Base;
            }
            else if (radioButton4.Checked && radioButton8.Checked)
            {
                int number = Convert.ToInt32(textBox1.Text, 16);
                string Base = Convert.ToString(number, 16);
                textBox2.Text = Base;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }
    }
}
