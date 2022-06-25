using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_List_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fruits.Items.Add(textBox1.Text);//Fruits List box name
            textBox1.Clear();
            textBox1.Focus();//fOR CURSOR
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Fruits.Items.Count;
            MessageBox.Show("List items are : "+count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fruits.Sorted = true;//BY DEFAULT Sorted PROPERTY IS FALSE 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fruits.Items.Remove(Fruits.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fruits.Items.RemoveAt(Fruits.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fruits.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
