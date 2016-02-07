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
    public partial class DiceGame : Form
    {
        int iCount = 0;
        System.Windows.Forms.Label[] _lblFreq;
        System.Windows.Forms.Label[] _lblPercent;
        System.Windows.Forms.Label[] _lblGuess;
        
        public DiceGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Checks the guess entry box to make sure input is between 1 and 6.
        /// Generates random numbers to show roll, and generate roll number.
        /// Updates all labels to reflect rolled value and guessed value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startRoll_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblInvalid.Visible = false;
            //Create and initialize label arrays
            _lblFreq = new System.Windows.Forms.Label[] { lblFreq1, lblFreq2, lblFreq3, lblFreq4, lblFreq5, lblFreq6 };
            _lblPercent = new System.Windows.Forms.Label[] { lblPercent1, lblPercent2, lblPercent3, lblPercent4, lblPercent5, lblPercent6 };
            _lblGuess = new System.Windows.Forms.Label[] { lblGuess1, lblGuess2, lblGuess3, lblGuess4, lblGuess5, lblGuess6 };

            //Verify Guess entry and store guess
            int iGuess;
            if (Int32.TryParse(txtGuess.Text, out iGuess) && !(iGuess < 1 || iGuess > 6))
            {
                //Generate Random Number between 1 and 6
                Random rand = new Random();
                int iRoll = 0;
                //Update dice image 4 times with random numbers
                for (int i = 0; i < 4; i++)
                {
                    iRoll = rand.Next(1, 7);
                    pbImage.Image = Image.FromFile("die" + iRoll.ToString() + ".gif");
                    pbImage.Refresh();
                    Thread.Sleep(300);
                }
                //Update labels to match rolled value
                incrementLabel(lblRollCount);
                incrementLabel(_lblGuess, iGuess - 1);
                incrementLabel(_lblFreq, iRoll - 1);
                iCount++;
                Percent_Update(iRoll);
                //Display message for guessed value
                if (iGuess == iRoll)
                {
                    lblMessage.ForeColor = Color.LimeGreen;
                    lblMessage.Text = "Great Guess!";
                    incrementLabel(lblCorrectNum);
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Try Again!";
                }
            }
            //Invalid textbox entry
            else
            {
                lblInvalid.Visible = true;
            }
            
        }
        /// <summary>
        /// Take label array and position and increments that position's text by one
        /// </summary>
        /// <param name="lbl">Label Array</param>
        /// <param name="position">Position in label array to update</param>
        private void incrementLabel (Label[] lbl, int position)
        {
            int temp = Convert.ToInt32(lbl[position].Text) + 1;
            lbl[position].Text = Convert.ToString(temp);
        }
        /// <summary>
        /// Takes label and increments that label's text by one
        /// </summary>
        /// <param name="lbl">Label to increment</param>
        private void incrementLabel (Label lbl)
        {
            int temp = Convert.ToInt32(lbl.Text) + 1;
            lbl.Text = Convert.ToString(temp);
        }
        /// <summary>
        /// Runs startRoll_Click when enter key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGuess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startRoll_Click(sender, e);
            }
        }
        /// <summary>
        /// Updates the percent array to reflect current rolled percentages
        /// </summary>
        /// <param name="iRoll">Rolled value</param>
        private void Percent_Update(int iRoll)
        {
            for (int i = 0; i < 6; i++)
            {
                _lblPercent[i].Text = Convert.ToString(Math.Round((Convert.ToDouble(_lblFreq[i].Text) / iCount) * 100,2) + "%");
            }
        }
        /// <summary>
        /// Resets all values back to the default beginning values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                _lblFreq[i].Text = "0";
                _lblGuess[i].Text = "0";
                _lblPercent[i].Text = "0%";
            }
            lblCorrectNum.Text = "0";
            lblRollCount.Text = "0";
            lblMessage.Text = "";
            pbImage.Image = Image.FromFile("die1.gif");
            txtGuess.Text = "";
            iCount = 0;
        }
    }
}
