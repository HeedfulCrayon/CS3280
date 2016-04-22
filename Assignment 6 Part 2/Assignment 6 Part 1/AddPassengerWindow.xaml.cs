using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Assignment_6_Part_1
{
    /// <summary>
    /// Interaction logic for AddPassengerWindow.xaml
    /// </summary>
    public partial class AddPassengerWindow : Window
    {
        public AddPassengerWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        ///// <summary>
        ///// Closes out current window
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    try
        //    {
        //        this.Hide();
        //        e.Cancel = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
        //    }
        //}

        ///// <summary>
        ///// Closes out current window when you click save or cancel
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Window_Closing(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
        //    }
        //}
    }
}
