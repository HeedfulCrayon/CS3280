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
        public PlayerInfo(MainMenu wSender)
        {
            InitializeComponent();
            wParent = wSender;
            tbAge.KeyDown += new KeyEventHandler(Age_KeyDown);
            tbFName.KeyDown += new KeyEventHandler(Name_KeyDown);
            tbLName.KeyDown += new KeyEventHandler(Name_KeyDown);
        }

        private MainMenu wParent;

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            clsPlayer newPlayer = new clsPlayer(tbFName.Text, tbLName.Text, Convert.ToInt32(tbAge.Text), tbEmail.Text);
            MainMenu.Players.Add(newPlayer);
            this.Close();
            wParent.Show();
        }

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
    }
}
