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
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnGameType_Click(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            Game = new clsGame(Convert.ToString(temp.Content));
            gridGameType.Visibility = Visibility.Hidden;
            newQuestion();
        }
        private void newQuestion()
        {
            lblQuestion.Content = Game.newQuestion();
        }
    }
}
