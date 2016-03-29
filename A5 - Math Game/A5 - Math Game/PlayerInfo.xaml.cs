using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace A5___Math_Game
{
    /// <summary>
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        #region Constructor
        /// <summary>
        /// Default Constructor.
        /// Initializes Key Event Handlers for the window.
        /// </summary>
        public PlayerInfo()
        {
            InitializeComponent();
            // Sets Focus to the First Name Field
            tbFName.Focus();
            // Event Handler for Age Input (Digits only)
            tbAge.KeyDown += new KeyEventHandler(Age_KeyDown);
            // Event Handlers for First and Last Name Input (Letters only)
            tbFName.KeyDown += new KeyEventHandler(Name_KeyDown);
            tbLName.KeyDown += new KeyEventHandler(Name_KeyDown);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks input in each field and saves input into clsPlayer List
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Set as true to see if anything flags it as false later on
            bool valid = true;
            // Checks each Textbox in the window for valid text entry
            foreach (Control item in gridPlayerInfo.Children)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (((TextBox)item).Text == "")
                    {
                        item.BorderBrush = new SolidColorBrush(Colors.Red);
                        valid = false;
                    }
                    else
                    {
                        item.BorderBrush = new SolidColorBrush(Colors.Black);
                    }
                }
            }
            // If the entry is valid
            if (valid)
            {
                // Create new player
                clsPlayer newPlayer = new clsPlayer();
                // Set the player name
                newPlayer.sFName = tbFName.Text;
                newPlayer.sLName = tbLName.Text;
                // Set age (already checked data input)
                newPlayer.iAge = Convert.ToInt32(tbAge.Text);
                // Set email
                newPlayer.sEmail = tbEmail.Text;
                // Add new player to list of players
                MainMenu.Players.Add(newPlayer);
                // Create new score with player's name
                clsScores playerScore = new clsScores(tbFName.Text + " " + tbLName.Text);
                // Add score to list of scores
                MainMenu.Scores.Add(playerScore);
                // Tells the window that the objective has been completed successfully
                this.DialogResult = true;
                this.Hide();
                // Blanks out the fields
                tbFName.Text = "";
                tbLName.Text = "";
                tbAge.Text = "";
                tbEmail.Text = "";
            }
        }
        /// <summary>
        /// Handles the window on closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // If the objective has been completed
            if (this.DialogResult == true)
            {
                e.Cancel = false;
            }
            // If the objective has not been completed
            else
            {
                e.Cancel = true;
            }
            this.Hide();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Age field event handler.  Determines if the key pressed is a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Key Pressed</param>
        void Age_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Tab)
            {
                // Key is printed on screen
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Name Fields event handler.  Determines if the key pressed is a letter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Name_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.A && e.Key <= Key.Z) || e.Key == Key.Tab)
            {
                // Key is printed on screen
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Event handler for checking if there is any empty fields.
        /// Marks fields as red when empty.
        /// </summary>
        /// <param name="sender">TextBox Fields in PlayerInfo Window</param>
        /// <param name="e">TextBox Args</param>
        private void ValidateTextInput(object sender, RoutedEventArgs e)
        {
            // Casts sender to Textbox Type
            TextBox temp = (TextBox)sender;
            // Checks to see if Textbox is empty
            if (temp.Text == "")
            {
                // Changes the border color
                temp.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                // Changes the border color
                temp.BorderBrush = new SolidColorBrush(Colors.Black);
            }
        }
        #endregion
    }
}
