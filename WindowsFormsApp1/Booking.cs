using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;

namespace WindowsFormsApp1
{
    class Booking
    {
        private int booking_ID;
        private int customer_id;
        private int desk_id;
        private DateTime book_date;
        private DateTime arrival_date;
        private DateTime departure_date;
        private decimal total_cost;

        // Default constructor
        public Booking()
        {
            this.booking_ID = 0;
            this.customer_id = 0;
            this.desk_id = 0;
            this.book_date = DateTime.MinValue;
            this.arrival_date = DateTime.MinValue;
            this.departure_date = DateTime.MinValue;
            this.total_cost = 0;
        }

        // Parameterized constructor
        public Booking(int booking_ID, int customer_id, int desk_id, DateTime book_date, DateTime arrival_date, DateTime departure_date, decimal total_cost)
        {
            this.booking_ID = booking_ID;
            this.customer_id = customer_id;
            this.desk_id = desk_id;
            this.book_date = book_date;
            this.arrival_date = arrival_date;
            this.departure_date = departure_date;
            this.total_cost = total_cost;
        }

        // Getters
        public int GetBookingID() { return this.booking_ID; }
        public int GetCustomerID() { return this.customer_id; }
        public int GetDeskID() { return this.desk_id; }
        public DateTime GetBookDate() { return this.book_date; }
        public DateTime GetArrivalDate() { return this.arrival_date; }
        public DateTime GetDepartureDate() { return this.departure_date; }
        public decimal GetTotalCost() { return this.total_cost; }

        // Setters
        public void SetBookingID(int booking_ID) { this.booking_ID = booking_ID; }
        public void SetCustomerID(int customer_id) { this.customer_id = customer_id; }
        public void SetDeskID(int desk_id) { this.desk_id = desk_id; }
        public void SetBookDate(DateTime book_date) { this.book_date = book_date; }
        public void SetArrivalDate(DateTime arrival_date) { this.arrival_date = arrival_date; }
        public void SetDepartureDate(DateTime departure_date) { this.departure_date = departure_date; }
        public void SetTotalCost(decimal total_cost) { this.total_cost = total_cost; }





        public static int getNextBookingID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(booking_id) FROM Bookings";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public static bool BookDesk(int bookingID, int customerID, int deskID, string deskTypeID, DateTime arrivalDate, DateTime departureDate, decimal totalCost)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlInsert = @"
            BEGIN
                INSERT INTO bookings (booking_id, customer_id, desk_id, desk_type_id, arrival_date, departure_date, total_cost, book_date)
                VALUES (:bookingID, :customerID, :deskID, :deskTypeID, :arrivalDate, :departureDate, :totalCost, :bookDate);
                
                INSERT INTO bookeddesks (booking_id, desk_id, desk_cost)
                VALUES (:bookingID, :deskID, :totalCost);
            END;";

                using (OracleCommand cmd = new OracleCommand(sqlInsert, conn))
                {
                    cmd.Parameters.Add(":bookingID", OracleDbType.Int32).Value = bookingID;
                    cmd.Parameters.Add(":customerID", OracleDbType.Int32).Value = customerID;
                    cmd.Parameters.Add(":deskID", OracleDbType.Int32).Value = deskID;
                    cmd.Parameters.Add(":deskTypeID", OracleDbType.Varchar2).Value = deskTypeID;
                    cmd.Parameters.Add(":arrivalDate", OracleDbType.Date).Value = arrivalDate;
                    cmd.Parameters.Add(":departureDate", OracleDbType.Date).Value = departureDate;
                    cmd.Parameters.Add(":totalCost", OracleDbType.Decimal).Value = totalCost;
                    cmd.Parameters.Add(":bookDate", OracleDbType.Date).Value = DateTime.Now; 

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public decimal CalculateTotalCost(string deskType, int numberOfDays)
        {
            decimal deskCost = DeskType.GetDeskTypeCost(deskType);
            return deskCost * numberOfDays;
        }
        public static DataSet getAllBookings()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
                "FROM Bookings ORDER BY Desk_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "booking");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet findBookings(String Booking_ID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Bookings " +
                "WHERE Booking_id LIKE '%" + Booking_ID + "%' ORDER BY Booking_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "booking");

            //Close db connection
            conn.Close();

            return ds;
        }
        public void DeleteBooking(int bookingId)
        {
            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                try
                {
                    // Define the SQL query to be executed
                    string sqlQuery = @"
                    BEGIN
                        DELETE FROM BookedDesks WHERE Booking_ID = :bookingId;
                        DELETE FROM Bookings WHERE Booking_ID = :bookingId;
                    END;";

                    // Create the OracleCommand object with parameters
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.Add(":bookingId", OracleDbType.Int32).Value = bookingId;

                        // Open the database connection
                        conn.Open();

                        // Execute the SQL query
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    throw new Exception("Oracle database error: " + ex.Message);
                }
            }
        }

    }
}




