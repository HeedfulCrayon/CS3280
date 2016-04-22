using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment_6_Part_1.Business_Objects
{
    static class DAPassenger
    {
        static DataAccess db;

        public static List<Passenger> GetPassengers(int flightNum)
        {
            try
            {
                db = new DataAccess();
                List<Passenger> passengerList = new List<Passenger>();

                string sqlStatement = "SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number AS Seat " +
                            "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
                            "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
                            "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
                            "FLIGHT.FLIGHT_ID = " + flightNum; ;
                int numRows = 0;
                DataSet dataSet = new DataSet();
                dataSet = db.ExecuteSQLStatement(sqlStatement, ref numRows);
                int index = 0;
                foreach (var item in dataSet.Tables[0].Rows)
                {
                    Passenger newPassenger = new Passenger();
                    MessageBox.Show(dataSet.Tables[0].Rows[index][0].ToString());
                    newPassenger.passengerID = Convert.ToInt32(dataSet.Tables[0].Rows[index][0].ToString());
                    newPassenger.firstName = dataSet.Tables[0].Rows[index][1].ToString();
                    newPassenger.lastName = dataSet.Tables[0].Rows[index][2].ToString();
                    newPassenger.seat = Convert.ToInt32(dataSet.Tables[0].Rows[index][3]);
                    passengerList.Add(newPassenger);
                    index++;
                }
                return passengerList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
