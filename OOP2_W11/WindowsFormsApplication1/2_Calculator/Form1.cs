using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            //MessageBox.Show(result.ToString());
            label4.Text = "Result is : " + result;
           // label4.Text = "Result is : " + result.ToString();
            label4.Visible = true;*/

            if(textBox1.Text !="" && textBox2.Text !="")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                label4.Text = "Result is : " + result;
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Invalid Input";
                label4.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                label4.Text = "Result is : " + result;
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Invalid Input";
                label4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                label4.Text = "Result is : " + result;
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Invalid Input";
                label4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 / num2;
                label4.Text = "Result is : " + result;
                label4.Visible = true;
            }
            else
            {
                label4.Text = "Invalid Input";
                label4.Visible = true;
            }
        }
    }
}
