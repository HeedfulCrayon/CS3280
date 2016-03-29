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
    /// Interaction logic for HighScores.xaml
    /// </summary>
    public partial class HighScores : Window
    {
        #region Constructor
        /// <summary>
        /// Sets the source for the DataGridView to the list of scores presorted, with only the top 10 scores
        /// </summary>
        public HighScores()
        {
            InitializeComponent();
            lvScores.ItemsSource = MainMenu.Scores.OrderByDescending(c => c.NumCorrect).ThenBy(c=> c.NumWrong).ThenBy(c => c.TimeTaken).Take(10);
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
            this.Hide();
            e.Cancel = true;
        }
        #endregion
    }
}
