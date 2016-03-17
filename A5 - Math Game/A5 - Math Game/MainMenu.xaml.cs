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
        public MainMenu()
        {
            InitializeComponent();
        }

        public static List<clsPlayer> Players = new List<clsPlayer>();

        private void btnCreatePlayer_Click(object sender, RoutedEventArgs e)
        {
            PlayerInfo newPlayerWindow = new PlayerInfo(this);
            this.Hide();
            newPlayerWindow.Show();
        }
    }
}
