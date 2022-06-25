using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Check_Box
{
    public partial class Form1 : Form
    {
        string name1 = "";
        string name2 = "";
        string name3 = "";
        string name4 = "";
        string name5 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                name1 = checkBox1.Text;
            }
            else
            {
                name1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                name2 = checkBox2.Text;
            }
            else
            {
                name2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                name3 = checkBox3.Text;
            }
            else
            {
                name3 = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                name4 = checkBox4.Text;
            }
            else
            {
                name4 = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                name5 = checkBox5.Text;
            }
            else
            {
                name5 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            MessageBox.Show(name1+" "+name2+" "+name3+" "+name4+" "+name5);
        }
    }
}
