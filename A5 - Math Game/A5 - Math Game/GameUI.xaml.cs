using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace A5___Math_Game
{
    /// <summary>
    /// Interaction logic for GameUI.xaml
    /// </summary>
    public partial class GameUI : Window
    {
        #region Attributes
        /// <summary>
        /// Copy of the High Scores Window from the Main Menu
        /// </summary>
        private HighScores wndCopyHighScores;
        /// <summary>
        /// Game Timer Handler
        /// </summary>
        DispatcherTimer GameTimer;
        #endregion

        #region Properties
        /// <summary>
        /// Sets the wndCopyHighScores attribute
        /// </summary>
        public HighScores CopyHighScores
        {
            get { return wndCopyHighScores; }
            set { wndCopyHighScores = value; }
        }
        #endregion

        #region Contructor
        /// <summary>
        /// Default Constructor.  Initializes timer, and related event handlers.
        /// Hides specific elements for the window appearance.
        /// </summary>
        public GameUI()
        {
            InitializeComponent();
            GameTimer = new DispatcherTimer();
            // Sets the time interval to 1 second
            GameTimer.Interval = TimeSpan.FromSeconds(1);
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            // Hides the question and elements related to it
            gridQuestion.Visibility = Visibility.Hidden;
            // Hides the players game stats and elements related to it
            gridGameStats.Visibility = Visibility.Hidden;
            // Hides the close button
            btnClose.Visibility = Visibility.Hidden;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns to the previous window that the object has been completed successfully
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Hide();
        }
        /// <summary>
        /// Starts the game that the user selects
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnGameType_Click(object sender, RoutedEventArgs e)
        {
            // Creates a temp button
            Button temp = (Button)sender;
            // Tells the game class what type of game was selected
            MainMenu.Game.gameType = Convert.ToString(temp.Content);
            // Hides the game selection grid
            gridGameType.Visibility = Visibility.Hidden;
            // Shows the Questions grid
            gridQuestion.Visibility = Visibility.Visible;
            // Calls for a new question to be displayed
            newQuestion();
        }
        /// <summary>
        /// Checks to see if the game has ended, if not, it starts the timer and asks the game class for a new question
        /// </summary>
        private void newQuestion()
        {
            // If game has ended
            if (MainMenu.Game.TotalQuestions == MainMenu.Scores[MainMenu.Scores.Count - 1].NumQuestions)
            {
                EndGame();
            }
            else
            { 
                // Sets timer start time for each question
                MainMenu.Game.TimerStart = DateTime.Now;
                // Starts timer
                GameTimer.Start();
                // Clears text in textbox
                txtAnswer.Text = "";
                // Changes submit button to submit
                btnSubmit.Content = "Submit";
                // Hides previous answer status
                lblAnswerStatus.Visibility = Visibility.Hidden;
                // Enables textbox
                txtAnswer.IsEnabled = true;
                // Changes image
                BitmapImage image = new BitmapImage(new Uri((Environment.CurrentDirectory + @"..\..\..\Images\Ralph.jpg")));
                imgQuestion.Source = image;
                // Sets focus to textbox
                txtAnswer.Focus();
                // Asks game class for new question
                lblQuestion.Content = MainMenu.Game.newQuestion();
            }
        }
        /// <summary>
        /// Displays whether the answer was right or wrong, plays sound
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // If the previous question's answer status is visible, it calls the new question function
            // For when the button is "Next>>" instead of submit
            if (lblAnswerStatus.Visibility == Visibility.Visible)
            {
                newQuestion();
            }
            else
            {
                // Variable for storage of input
                int answer;
                // Verify answer input
                if (Int32.TryParse(txtAnswer.Text, out answer))
                {
                    // Check answer -> Correct
                    if (MainMenu.Game.CheckAnswer(answer))
                    {
                        GameTimer.Stop();
                        lblAnswerStatus.Content = "Correct!";
                        SoundPlayer correct = new SoundPlayer(A5___Math_Game.Properties.Resources.Correct);
                        correct.Play();
                        lblAnswerStatus.Foreground = new SolidColorBrush(Colors.Green);
                        // Changes image
                        BitmapImage image = new BitmapImage(new Uri((Environment.CurrentDirectory + @"..\..\..\Images\Fix_it_felix_jr.jpg")));
                        imgQuestion.Source = image;
                    }
                    // Check answer -> Incorrect
                    else
                    {
                        GameTimer.Stop();
                        lblAnswerStatus.Content = "Wrong!";
                        SoundPlayer wrong = new SoundPlayer(A5___Math_Game.Properties.Resources.Wrong);
                        wrong.Play();
                        lblAnswerStatus.Foreground = new SolidColorBrush(Colors.Red);
                        // Change image
                        BitmapImage image = new BitmapImage(new Uri((Environment.CurrentDirectory + @"..\..\..\Images\Angry_Ralph.jpg")));
                        imgQuestion.Source = image;
                    }
                    // Shows the user if they got the question right
                    lblAnswerStatus.Visibility = Visibility.Visible;
                    // Changes the submit button to direct user
                    btnSubmit.Content = "Next>>";
                    // Blanks out timer
                    lblTimer.Content = "";
                    // Disables textbox
                    txtAnswer.IsEnabled = false;
                    // Sets focus to the "Next>>" button
                    btnSubmit.Focus();
                }
                else
                {
                    
                }
                
            }
        }
        /// <summary>
        /// Shows the high scores window
        /// </summary>
        /// <param name="sender">Button Clicked</param>
        /// <param name="e">Button Args</param>
        private void btnViewHighScores_Click(object sender, RoutedEventArgs e)
        {
            wndCopyHighScores = new HighScores();
            wndCopyHighScores.ShowDialog();
        }
        /// <summary>
        /// End Game display
        /// </summary>
        private void EndGame()
        {
            // Hides question grid
            gridQuestion.Visibility = Visibility.Hidden;
            // Shows the player their game stats
            gridGameStats.Visibility = Visibility.Visible;
            lblCorrect.Content = String.Format("You answered {0} questions right!", MainMenu.Scores[MainMenu.Scores.Count - 1].NumCorrect);
            lblIncorrect.Content = String.Format("You answered {0} questions wrong!", MainMenu.Scores[MainMenu.Scores.Count - 1].NumWrong);
            lblTime.Content = String.Format("Your time was {0:mm\\:ss}!", MainMenu.Scores[MainMenu.Scores.Count - 1].TimeTaken);
            // Shows the close button
            btnClose.Visibility = Visibility.Visible;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the window closing
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
        /// <summary>
        /// Checks the key input for the answer textbox (has to be a number)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                // Prints Number
            }
            else if (e.Key == Key.Enter)
            {
                btnSubmit_Click(sender, e);
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Runs every second to update the timer on the game window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Content = String.Format("{0:t}", MainMenu.Game.GetTime().Seconds.ToString());
        }
        #endregion
    }
}
