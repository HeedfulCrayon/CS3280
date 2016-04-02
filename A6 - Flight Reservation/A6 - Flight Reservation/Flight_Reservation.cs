using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6___Flight_Reservation
{
    public partial class Flight_Reservation : Form
    {
        #region Attributes
        /// <summary>
        /// Database access class
        /// </summary>
        clsDataAccess db;

        /// <summary>
        /// Dataset that stores flight ID, flight number and aircraft type
        /// </summary>
        DataSet Flights;

        /// <summary>
        /// Dataset that stores the passenger ID, first name, last name and seat number 
        /// </summary>
        DataSet Passengers;
        
        /// <summary>
        /// Sets the returned number of rows to 0
        /// </summary>
        int iRet = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Flight_Reservation()
        {
            InitializeComponent();
            // Defines db object as a Dataaccess object
            db = new clsDataAccess();
            // Loads the flights from the database
            LoadFlights();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Loads the flight information from the database and stores it in the flight dataset
        /// </summary>
        private void LoadFlights()
        {
            // SQL Query Statement
            string sSQL = "SELECT Flight_ID, Flight_Number + ' - ' + Aircraft_Type AS Flight FROM FLIGHT";
            // Execute SQL Query
            Flights = db.ExecuteSQLStatement(sSQL, ref iRet);
            // Update Flight selection combobox
            cbFlight.DisplayMember = "Flight";
            // Sets combobox datasource
            cbFlight.DataSource = Flights.Tables[0];
            // Sets selected index to initial position
            cbFlight.SelectedIndex = -1;
        }

        /// <summary>
        /// Updates the passenger list based on the flight selection
        /// </summary>
        /// <param name="flight">Selected flight ID</param>
        private void UpdatePassengerList(int flight)
        {
            // SQL Query Statement
            string sSQL = "SELECT PASSENGER.Passenger_ID, First_Name + ' ' + Last_Name AS FullName, Seat_Number AS Seat " +
                            "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
                            "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
                            "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
                            "FLIGHT.FLIGHT_ID = " + flight;
            // Sets the Passenger seat label blank
            lblPassengerSeatNum.Text = "";
            // Execute SQL Query
            Passengers = db.ExecuteSQLStatement(sSQL, ref iRet);
            // Sets combobox display member
            cbPassenger.DisplayMember = "FullName";
            // Sets combobox datasource
            cbPassenger.DataSource = Passengers.Tables[0];
            // Sets combobox selection to a blank selection
            cbPassenger.SelectedIndex = -1;
        }
        
        /// <summary>
        /// Loads the correct flight panel
        /// </summary>
        /// <param name="flight">Flight ID</param>
        private void LoadFlightPanel(int flight)
        {
            // Sets both panels as not hidden
            plFlight412.Visible = false;
            plFlight102.Visible = false;
            if (flight == 2)
            {
                plFlight412.Visible = true;
            }
            else if (flight == 1)
            {
                plFlight102.Visible = true;
            }
        }
        
        /// <summary>
        /// Adds a passenger to the database
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Button Args</param>
        private void btnAddPass_Click(object sender, EventArgs e)
        {
            // Initializes and defines new form
            Add_Passenger frmAddPass = new Add_Passenger();
            // Calls new form
            frmAddPass.ShowDialog();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// When flight combobox index changes, this method updates the passenger list and loads the correct flight panel
        /// </summary>
        /// <param name="sender">cbFlight</param>
        /// <param name="e">cbFlight args</param>
        private void cbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creates a temp combobox and sets it equal to sender
            ComboBox temp = (ComboBox)sender;
            // If index is set to initial position
            if (temp.SelectedIndex == -1)
            {
                // Unload current flight panel
                LoadFlightPanel(0);
                // Disable Add passenger button
                btnAddPass.Enabled = false;
            }
            else
            {
                // Updates the passenger list
                int flight;
                Int32.TryParse(Flights.Tables[0].Rows[temp.SelectedIndex][0].ToString(), out flight);
                UpdatePassengerList(flight);
                // Loads the correct flight panel
                LoadFlightPanel(flight);
                // Enables the passenger combobox
                cbPassenger.Enabled = true;
                // Enables the add passenger button
                btnAddPass.Enabled = true;
            }
        }

        /// <summary>
        /// Runs to update the passenger seat on passenger combobox selection change
        /// </summary>
        /// <param name="sender">cbPassenger</param>
        /// <param name="e">cbPassneger Args</param>
        private void cbPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creates a temp combobox and sets it equal to the sender
            ComboBox temp = (ComboBox)sender;
            // Initial combobox position
            if (temp.SelectedIndex == -1)
            {
                // Sets seat number to blank
                lblPassengerSeatNum.Text = "";
            }
            else
            {
                // SQL Query Statement
                string sSQL = "SELECT Seat_Number FROM Flight_Passenger_Link where Passenger_ID = " + Passengers.Tables[0].Rows[cbPassenger.SelectedIndex][0].ToString();
                // Execute Query
                lblPassengerSeatNum.Text = db.ExecuteScalarSQL(sSQL);
            }
        }
        #endregion
    }
}
