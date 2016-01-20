using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblmyLabel.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box","This is the caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
            MessageBox.Show("Hi Joslyn, this is a message box", "Title", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
