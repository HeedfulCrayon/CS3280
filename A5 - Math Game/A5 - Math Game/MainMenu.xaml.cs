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
        HighScores wndHighScores;

        PlayerInfo wndPlayerInfo;

        GameUI wndGameUI;
        

        public MainMenu()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            wndHighScores = new HighScores();
            wndPlayerInfo = new PlayerInfo();
            wndGameUI = new GameUI();

            wndGameUI.CopyHighScores = wndHighScores;
        }

        public static List<clsPlayer> Players = new List<clsPlayer>();

        private void btnCreatePlayer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wndPlayerInfo.ShowDialog();
            this.Show();
        }

        private void btnPlayGame_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wndGameUI.ShowDialog();
            this.Show();
        }

        private void btnHighScores_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wndHighScores.ShowDialog();
            this.Show();
        }
    }
}
