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
        int iCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startRoll_Click(object sender, EventArgs e)
        {
            if ((txtGuess.Text != "") && (Convert.ToInt32(txtGuess.Text) > 0) && (Convert.ToInt32(txtGuess.Text) < 7))
            {
                int iGuess = Convert.ToInt32(txtGuess.Text);
                Random rand = new Random();
                int iRoll = 0;
                for (int i = 0; i < 4; i++)
                {
                    iRoll = rand.Next(1, 7);
                    pbImage.Image = Image.FromFile("die" + iRoll.ToString() + ".gif");
                    pbImage.Refresh();
                    Thread.Sleep(300);
                }
                iCount++;
                switch (iRoll)
                {
                    case 1:
                        {
                            int freq = Convert.ToInt32(lblFreq1.Text) + 1;
                            lblFreq1.Text = Convert.ToString(freq);
                            break;
                        }
                    case 2:
                        {
                            int freq = Convert.ToInt32(lblFreq2.Text) + 1;
                            lblFreq2.Text = Convert.ToString(freq);
                            break;
                        }
                    case 3:
                        {
                            int freq = Convert.ToInt32(lblFreq3.Text) + 1;
                            lblFreq3.Text = Convert.ToString(freq);
                            break;
                        }
                    case 4:
                        {
                            int freq = Convert.ToInt32(lblFreq4.Text) + 1;
                            lblFreq4.Text = Convert.ToString(freq);
                            break;
                        }
                    case 5:
                        {
                            int freq = Convert.ToInt32(lblFreq5.Text) + 1;
                            lblFreq5.Text = Convert.ToString(freq);
                            break;
                        }
                    case 6:
                        {
                            int freq = Convert.ToInt32(lblFreq6.Text) + 1;
                            lblFreq6.Text = Convert.ToString(freq);
                            break;
                        }
                }
            }
            else
            {
                lblInvalid.Visible = true;
            }
            
        }

        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startRoll_Click(sender, e);
            }
        }
    }
}
