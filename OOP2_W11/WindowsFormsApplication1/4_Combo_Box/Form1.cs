using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if(comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("Items already Exists");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill the text box first");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            MessageBox.Show("Total items are : "+count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
