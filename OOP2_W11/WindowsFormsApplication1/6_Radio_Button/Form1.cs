using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("University is : "+ radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("University is : " + radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("University is : " + radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("University is : " + radioButton4.Text);
            }
            else if (radioButton5.Checked == true)
            {
                MessageBox.Show("University is : " + radioButton5.Text);
            }
            else
            {
                MessageBox.Show("Please select anyone");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton6.Checked==true)
            {
                groupBox1.BackColor = Color.Red;
            }
            else if (radioButton7.Checked == true)
            {
                groupBox1.BackColor = Color.Green;
            }
            else if (radioButton8.Checked == true)
            {
                groupBox1.BackColor = Color.Blue;
            }
            else if (radioButton9.Checked == true)
            {
                groupBox1.BackColor = Color.Orange;
            }
            else if (radioButton10.Checked == true)
            {
                groupBox1.BackColor = Color.Purple;
            }
            else if (radioButton11.Checked == true)
            {
                groupBox1.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Please select anyone");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (radioButton14.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else if (radioButton15.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            else if (radioButton16.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            else if (radioButton17.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Purple;
            }
            else if (radioButton12.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                MessageBox.Show("Please select anyone");
            }
        }
    }
}
