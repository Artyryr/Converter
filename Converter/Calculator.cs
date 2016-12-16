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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            radioButton12.Checked = true;

        }

        private void calculation()
        {
            /////////////PLUS
            /// a = 10
            if (radioButton1.Checked && radioButton5.Checked && radioButton12.Checked)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int sum = a + b;

                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton6.Checked && radioButton12.Checked)
            {
                int a = int.Parse(textBox1.Text);
               
                int number = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);
                
                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton7.Checked && radioButton12.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton8.Checked && radioButton12.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }



            ////a = 2
            else if (radioButton2.Checked && radioButton5.Checked && radioButton12.Checked)
            {
                
                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton6.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton2.Checked && radioButton7.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton8.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            //8
            else if (radioButton3.Checked && radioButton5.Checked && radioButton12.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton6.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton3.Checked && radioButton7.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton8.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            ////16
            else if (radioButton4.Checked && radioButton5.Checked && radioButton12.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton6.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton4.Checked && radioButton7.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton8.Checked && radioButton12.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a + b;
                textBox3.Text = sum.ToString();
            }


            ////////////MINUS
            /// a=10
            else if (radioButton1.Checked && radioButton5.Checked && radioButton11.Checked)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int sum = a - b;

                textBox3.Text = sum.ToString();
            }

            else if (radioButton1.Checked && radioButton6.Checked && radioButton11.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton7.Checked && radioButton11.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton8.Checked && radioButton11.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            ////a = 2
            else if (radioButton2.Checked && radioButton5.Checked && radioButton11.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton6.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton2.Checked && radioButton7.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton8.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            //8
            else if (radioButton3.Checked && radioButton5.Checked && radioButton11.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton6.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton3.Checked && radioButton7.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton8.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            ////16
            else if (radioButton4.Checked && radioButton5.Checked && radioButton11.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton6.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton4.Checked && radioButton7.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);
            
                int sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton8.Checked && radioButton11.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a - b;
                textBox3.Text = sum.ToString();
            }


            ///////////// MULTIPLY
            /// a = 10
            else if (radioButton1.Checked && radioButton5.Checked && radioButton10.Checked)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int sum = a * b;

                textBox3.Text = sum.ToString();
            }

            else if (radioButton1.Checked && radioButton6.Checked && radioButton10.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton7.Checked && radioButton10.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton8.Checked && radioButton10.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }


            ////a = 2
            else if (radioButton2.Checked && radioButton5.Checked && radioButton10.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton6.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton2.Checked && radioButton7.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton8.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            //8
            else if (radioButton3.Checked && radioButton5.Checked && radioButton10.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton6.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton3.Checked && radioButton7.Checked && radioButton10.Checked)
            { 
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton8.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            ////16
            else if (radioButton4.Checked && radioButton5.Checked && radioButton10.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton6.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton4.Checked && radioButton7.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton8.Checked && radioButton10.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                int sum = a * b;
                textBox3.Text = sum.ToString();
            }

            /////////// DEVIDE
            /// a = 10
            else if (radioButton1.Checked && radioButton5.Checked && radioButton9.Checked)
            {
                double a = int.Parse(textBox1.Text);
                double b = int.Parse(textBox2.Text);
                double sum = a / b;

                textBox3.Text = sum.ToString();
            }

            else if (radioButton1.Checked && radioButton6.Checked && radioButton9.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton7.Checked && radioButton9.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }
            else if (radioButton1.Checked && radioButton8.Checked && radioButton9.Checked)
            {
                int a = int.Parse(textBox1.Text);

                int number = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(number, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }


            ////a = 2
            else if (radioButton2.Checked && radioButton5.Checked && radioButton9.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton6.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }

            else if (radioButton2.Checked && radioButton7.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked && radioButton8.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 2);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }
            //8
            else if (radioButton3.Checked && radioButton5.Checked && radioButton9.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2; textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton6.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton3.Checked && radioButton7.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);


                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked && radioButton8.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 8);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
            ////16
            else if (radioButton4.Checked && radioButton5.Checked && radioButton9.Checked)
            {

                int b = int.Parse(textBox2.Text);
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton6.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 2);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }

            else if (radioButton4.Checked && radioButton7.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 8);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked && radioButton8.Checked && radioButton9.Checked)
            {
                int numbera = Convert.ToInt32(textBox1.Text, 16);
                string olda = Convert.ToString(numbera, 10);
                int a = Convert.ToInt32(olda);

                int numberb = Convert.ToInt32(textBox2.Text, 16);
                string oldb = Convert.ToString(numberb, 10);
                int b = Convert.ToInt32(oldb);

                double a2 = Convert.ToDouble(a);
                double b2 = Convert.ToDouble(b);
                double sum = a2 / b2;
                textBox3.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
