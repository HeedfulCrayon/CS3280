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

        clsDataAccess db = new clsDataAccess();

        DataSet Flights;
        DataSet Passengers;

        int iRet = 0;

        public Flight_Reservation()
        {
            InitializeComponent();
            LoadFlights();
        }

        private void LoadFlights()
        {
            string sSQL = "SELECT Flight_ID, Flight_Number, Aircraft_Type FROM FLIGHT";
            iRet = 0;
            Flights = db.ExecuteSQLStatement(sSQL, ref iRet);
            for (int i = 0; i < Flights.Tables[0].Rows.Count; i++)
            {
                cbFlight.Items.Add(Flights.Tables[0].Rows[i][1].ToString() + " - " + Flights.Tables[0].Rows[i][2].ToString());
            }
        }

        private void UpdatePassengerList(int flight)
        {
            string sSQL = "SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number " +
                            "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
                            "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
                            "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
                            "FLIGHT.FLIGHT_ID = " + flight;
            cbPassenger.Items.Clear();
            
            int iRet = 0;
            Passengers = db.ExecuteSQLStatement(sSQL, ref iRet);
            for (int i = 0; i < Passengers.Tables[0].Rows.Count; i++)
            {
                cbPassenger.Items.Add(Passengers.Tables[0].Rows[i][1].ToString() + " " + Passengers.Tables[0].Rows[i][2].ToString());
            }
        }

        private void cbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;
            UpdatePassengerList(Convert.ToInt32(Flights.Tables[0].Rows[temp.SelectedIndex][0]));
            LoadFlightPanel(Convert.ToInt32(Flights.Tables[0].Rows[temp.SelectedIndex][0]));
        }

        private void LoadFlightPanel(int flight)
        {
            if (flight == 412)
            {
                plFlight412.Visible = true;
                // Somehow need to figure out how to show the labels as seat taken and empty
                //for (int i = 0; i < Passengers.Tables[0].Rows.Count; i++)
                //{

                //}

                //foreach (Control lbls in plFlight412.Controls)
                //{
                //    if (lbls.Name.Contains("lblSeat"))
                //    {
                //        string seat = new string(lbls.Name.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
                //    }
                //}
            }
        }

        private void cbPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT Seat_Number FROM Flight_Passenger_Link where Passenger_ID = " + Passengers.Tables[0].Rows[cbPassenger.SelectedIndex][0].ToString();
            lblPassengerSeatNum.Text = db.ExecuteScalarSQL(sSQL);
        }
    }
}
