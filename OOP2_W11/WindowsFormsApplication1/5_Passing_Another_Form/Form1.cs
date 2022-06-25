using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Passing_Another_Form
{
    public partial class Form1 : Form
    {

        public static string name;
        public static string id;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            name = textBox1.Text;
            id = textBox2.Text;

            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
