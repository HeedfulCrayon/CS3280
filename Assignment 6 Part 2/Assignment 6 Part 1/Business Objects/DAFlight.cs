using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Part_1.Business_Objects
{
    static class DAFlight
    {
        static DataAccess db;
        public static List<Flight> GetFlights()
        {
            try
            {
                db = new DataAccess();
                List<Flight> flightList = new List<Flight>();
                //addPassengerWindow = new AddPassengerWindow();

                string sqlStatement;
                int numRows = 0;
                DataSet dataSet = new DataSet();
                Flight flight;

                sqlStatement = "SELECT * FROM Flight";

                dataSet = db.ExecuteSQLStatement(sqlStatement, ref numRows);

                for (int i = 0; i < numRows; i++)
                {
                    flight = new Flight();
                    flight.FlightID = Int32.Parse(dataSet.Tables[0].Rows[i]["Flight_ID"].ToString());
                    flight.FlightNumber = Int32.Parse(dataSet.Tables[0].Rows[i]["Flight_Number"].ToString());
                    flight.AircraftType = dataSet.Tables[0].Rows[i]["Aircraft_Type"].ToString();
                    flightList.Add(flight);
                    //flightComboBox.Items.Add(flight);
                }
                return flightList;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
