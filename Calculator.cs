using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string D;
        public string Num1;
        public bool Num2;
        public Calculator()
        {
            Num2 = false;
            InitializeComponent();
        }

        private void number13_Click(object sender, EventArgs e)
        {
            if (Num2)
            {
                Num2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox2.Text = B.Text;
            D = B.Text;
            Num1 = textBox1.Text;
            Num2 = true;
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            res = 0;
            n1 = Convert.ToDouble(Num1);
            n2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = n1 + n2;
            }
            if (D == "-")
            {
                res = n1 - n2;
            }
            if (D == "*")
            {
                res = n1 * n2;
            }
            if (D == "/")
            {
                res = n1 / n2;
            }
            D = "=";
            Num2 = true;
            textBox1.Text = res.ToString();

        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = 1/dn;
            textBox1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }
    }
}
