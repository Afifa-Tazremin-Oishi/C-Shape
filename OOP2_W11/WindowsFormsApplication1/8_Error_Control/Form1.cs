using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Error_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Enter your name please!");
                //MessageBox.Show("Enter your name please!");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
                //errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Enter your salary please!");
                //MessageBox.Show("Enter your salary please!");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
                //errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proud AIUBIAN");
        }
    }
}
