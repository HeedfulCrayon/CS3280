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
    /// Interaction logic for GameUI.xaml
    /// </summary>
    public partial class GameUI : Window
    {
        private HighScores wndCopyHighScores;

        private clsGame Game;

        public HighScores CopyHighScores
        {
            get { return wndCopyHighScores; }
            set { wndCopyHighScores = value; }
        }

        public GameUI()
        {
            InitializeComponent();
            gridQuestion.Visibility = Visibility.Hidden;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Game.EndGame();
            this.Hide();
        }

        private void btnGameType_Click(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            Game = new clsGame(Convert.ToString(temp.Content));
            gridGameType.Visibility = Visibility.Hidden;
            gridQuestion.Visibility = Visibility.Visible;
            newQuestion();
        }
        private void newQuestion()
        {
            txtAnswer.Text = "";
            btnSubmit.Content = "Submit";
            lblAnswerStatus.Visibility = Visibility.Hidden;
            lblQuestion.Content = Game.newQuestion();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (lblAnswerStatus.Visibility == Visibility.Visible)
            {
                newQuestion();
            }
            else
            {
                if (Game.CheckAnswer(Convert.ToInt32(txtAnswer.Text)))
                {
                    lblAnswerStatus.Content = "Correct!";
                    lblAnswerStatus.Foreground = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    lblAnswerStatus.Content = "Wrong!";
                    lblAnswerStatus.Foreground = new SolidColorBrush(Colors.Red);
                }
                lblAnswerStatus.Visibility = Visibility.Visible;
                btnSubmit.Content = "Next>>";
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                // Prints Number
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
