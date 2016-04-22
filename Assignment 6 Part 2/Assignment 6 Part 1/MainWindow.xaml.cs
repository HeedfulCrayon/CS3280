using Assignment_6_Part_1.Business_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace Assignment_6_Part_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Holds the add passenger window
        /// </summary>
        AddPassengerWindow addPassengerWindow;

        public MainWindow()
        {
            InitializeComponent();

            flightComboBox.ItemsSource = DAFlight.GetFlights();
        }

        /// <summary>
        /// Displays the correct flight seating arrangement based on the combo box selection.
        /// Enables passenger combo box and add passenger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Flight flight;

                flight = (Flight)flightComboBox.SelectedItem;

                if (flight.FlightNumber == 102)
                {
                    flightSeatingGroupBox1.Visibility = Visibility.Hidden;
                    flightSeatingGroupBox2.Visibility = Visibility.Visible;
                    passengerComboBox.IsEnabled = true;
                    addPassengerButton.IsEnabled = true;
                }
                else if (flight.FlightNumber == 412)
                {
                    flightSeatingGroupBox2.Visibility = Visibility.Hidden;
                    flightSeatingGroupBox1.Visibility = Visibility.Visible;
                    passengerComboBox.IsEnabled = true;
                    addPassengerButton.IsEnabled = true;
                }

                passengerComboBox.ItemsSource = DAPassenger.GetPassengers(flight.FlightID);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Navigates to Add Passenger window from the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navFromMainToAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                addPassengerWindow = new AddPassengerWindow();
                addPassengerWindow.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
