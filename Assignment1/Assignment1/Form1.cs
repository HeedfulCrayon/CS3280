using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the submit button is clicked, it will start a series of Messageboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            //Displays a messagebox with the text that was typed in textBox1
            var buttonSelection = MessageBox.Show("You typed \"" + textBox1.Text + "\" in the text box", "Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            //Displays a messagebox that tells the user what button they clicked in the previous messagebox
            MessageBox.Show("You selected " + buttonSelection + " from the message box", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
