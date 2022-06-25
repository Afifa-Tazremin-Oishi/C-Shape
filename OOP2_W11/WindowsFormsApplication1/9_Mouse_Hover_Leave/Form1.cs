using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Mouse_Hover_Leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "AIUB";
            button1.BackColor = Color.Purple;
            button1.ForeColor = Color.Blue;
            button1.Font = new Font("hobo std", 80);
            this.BackColor = System.Drawing.Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse";
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.Black;
            this.BackColor = System.Drawing.Color.Cyan;
            label1.Font = new Font("hobo std", 72);
        }
    }
}
