using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to AIUB");
            //MessageBox.Show("Welcome to "+textBox1.Text);

            label3.Text = "Welcome to "+textBox1.Text;
            label3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
