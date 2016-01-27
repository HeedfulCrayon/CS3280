using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startRoll_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int seed = rand.Next(1, 6);
                pbImage.Image = Image.FromFile("die" + seed.ToString() + ".gif");
                pbImage.Refresh();
                Thread.Sleep(300);
            }
        }
    }
}
