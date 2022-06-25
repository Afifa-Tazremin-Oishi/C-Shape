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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label2.Text = Form1.name;
            //label3.Text = Form1.id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Form1.name;
            label3.Text = Form1.id;

        }
    }
}
