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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A5___Math_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        #region Attributes
        /// <summary>
        /// High Scores Window
        /// </summary>
        HighScores wndHighScores;
        /// <summary>
        /// Player Info Window
        /// </summary>
        PlayerInfo wndPlayerInfo;
        /// <summary>
        /// Game Window
        /// </summary>
        GameUI wndGameUI;
        /// <summary>
        /// Notes whether or not the player has been created
        /// </summary>
        private bool? playerCreated;
        /// <summary>
        /// Notes whether or not the game has been played with current player
        /// </summary>
        private bool? gamePlayed;
        /// <summary>
        /// List of Players
        /// </summary>
        public static List<clsPlayer> Players = new List<clsPlayer>();
        /// <summary>
        /// List of Scores
        /// </summary>
        public static List<clsScores> Scores = new List<clsScores>();
        /// <summary>
        /// Instantiation of Game
        /// </summary>
        public static clsGame Game;
        #endregion

        #region Properties
        /// <summary>
        /// Sets the playerCreated attribute and enables the Play Game Button
        /// </summary>
        public bool? PlayerCreated
        {
            get { return playerCreated; }
            set { playerCreated = value;
                // Enables the Play Game button once the user is created
                if (playerCreated == true)
                {
                    GamePlayed = false;
                    btnPlayGame.IsEnabled = true;
                }
            }
        }
        /// <summary>
        /// Sets the gamePlayed attribute and disables the Play Game button once played
        /// </summary>
        public bool? GamePlayed
        {
            get { return gamePlayed; }
            set { gamePlayed = value;
                // Disables Play Game button once the game has been played
                if (gamePlayed == true)
                {
                    btnPlayGame.IsEnabled = false;
                }
                // Re-Enables the Play Game button
                else
                {
                    btnPlayGame.IsEnabled = true;
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes the Player Info Window and Displays it.
        /// Once player info is entered, PlayerCreated is set to true.
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnCreatePlayer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            // Initializes and calls PlayerInfo window
            wndPlayerInfo = new PlayerInfo();
            // Sets the PlayerCreated Property once player is created
            PlayerCreated = wndPlayerInfo.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Initializes the GameUI Window and Displays it.
        /// Sends the GameUI window the HighScores window.
        /// Once the game is played, GamePlayed is set to true.
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnPlayGame_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            // Initializes and calls the GameUI Window
            wndGameUI = new GameUI();
            wndGameUI.CopyHighScores = wndHighScores;
            // Defines Game
            Game = new clsGame();
            // Sets the GamePlayed Property once game has been played
            GamePlayed = wndGameUI.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Initializes the High Scores Window and Displays it.
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnHighScores_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            // Initializes and calls the HighScores Window
            wndHighScores = new HighScores();
            wndHighScores.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
