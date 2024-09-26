using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Desk
    {
        private int desk_ID;
        private String location;
        private String desk_type_id;
        private String availability_status;


        public Desk()
        {
            this.desk_ID = 0;
            this.location = "";
            this.desk_type_id = "";
            this.availability_status = "";
        }

        public Desk(int desk_ID, string location, string desk_type_id, String availability_status)
        {
            this.desk_ID = desk_ID;
            this.location = location;
            this.desk_type_id = desk_type_id;
            this.availability_status = availability_status;
        }

        //getters
        public int getDesk_ID() { return this.desk_ID; }
        public String getLocation() { return this.location; }
        public String getDesk_type_id() { return this.desk_type_id; }
        public String getAvailability_status() { return this.availability_status; }

        //setters
        public void setDesk_ID(int deskID) { desk_ID = deskID; }
        public void setLocation(String Location) { location = Location; }
        public void setDesk_type_id(String DeskType_id) { desk_type_id = DeskType_id; }
        public void setAvailability_status(String status) { availability_status = status; }


        public static DataSet getAllDesks()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Desk_ID, Location, desk_type_id, availability_status " +
                "FROM Desks ORDER BY Location";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "desk");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getDesk(int Id)
        {
            //Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                //Define the SQL query to be executed
                String sqlQuery = "SELECT * FROM Desks WHERE Desk_ID = " + Id;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) // Check if there are rows to read
                {
                    // Set the instance variables with values from data reader
                    setDesk_ID(dr.GetInt32(0));
                    setDesk_type_id(dr.GetString(1));
                    setAvailability_status(dr.GetString(2));
                    setLocation(dr.GetString(3));
                }

                //close DB
                conn.Close();
            }
        }

        public void addDesk()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Desks (desk_ID, location, desk_type_id, availability_status) " +
                  "VALUES (" + this.desk_ID + ", '" +
                                 this.location + "', '" +
                                 this.desk_type_id + "', '" +
                                 "A" + "')";




            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public static int getNextDeskID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(desk_id) FROM Desks";

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
        public void updateDesk()
        {
            try
            {
                // Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                // Define the SQL query to be executed
                String sqlQuery = "UPDATE Desks SET " +
                    "Desk_Id = " + this.desk_ID + "," +
                    "Location = '" + this.location + "'," +
                    "Desk_type_id = '" + this.desk_type_id + "' " +
                    "WHERE Desk_Id = " + this.desk_ID;

                // Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                // Close db connection
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating desk: " + ex.Message);
                // You can throw the exception here to propagate it to the caller if necessary
                // throw;
            }
        }



        public static DataSet findDesks(String Desk_ID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "SELECT Desk_id, location, Desk_type_id, availability_status FROM Desks " +
                "WHERE Desk_id LIKE '%" + Desk_ID + "%' ORDER BY Desk_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "desks");

            //Close db connection
            conn.Close();

            return ds;
        }
        public void deleteDesk(int deskId)
        {
            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                try
                {
                    // Define the SQL query to be executed
                    string sqlQuery = "UPDATE Desks SET availability_status = 'D' WHERE Desk_ID = :deskId";

                    // Create the OracleCommand object with parameters
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.Add(":deskId", OracleDbType.Int32).Value = deskId;

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
        public static char retrieveAvailabilityStatus(int deskId)
        {
            char availabilityStatus = 'A'; // Default value

            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to retrieve availability status
                string sqlQuery = "SELECT availability_status FROM Desks WHERE Desk_ID = :deskId";

                // Create the OracleCommand object with parameters
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.Add(":deskId", OracleDbType.Int32).Value = deskId;

                    // Open the database connection
                    conn.Open();

                    // Execute the SQL query
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null && result != DBNull.Value)
                    {
                        availabilityStatus = Convert.ToChar(result);///
                    }
                }
            }

            return availabilityStatus;
        }


        public static bool ExistingDesk(int deskId)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to check for the existence of the desk ID
                string sqlQuery = "SELECT COUNT(*) FROM Desks WHERE Desk_id = :deskId";

                // Create the OracleCommand object with parameters
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.Add(":deskId", OracleDbType.Int32).Value = deskId;

                    // Open the database connection
                    conn.Open();

                    // Execute the SQL query and get the count of rows
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Close the database connection
                    conn.Close();

                    // Return true if the desk_ID exists, otherwise false
                    return rowCount > 0;
                }
            }
        }

        public static DataSet GetAvailableDesks(string deskTypeId, DateTime fromDate, DateTime toDate)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string dateFrom = fromDate.ToString("dd-MMM-yy");
                string dateTo = toDate.ToString("dd-MMM-yy");
                try
                {
                    conn.Open();

                    string sqlQuery = "SELECT desk_id, location, desk_type_id, availability_status " +
                        "FROM Desks " +
                        "WHERE desk_type_id = :deskTypeId " +
                        "AND desk_id NOT IN " +
                        "(SELECT desk_id FROM Bookings " +
                        "WHERE arrival_date <= :toDate " +
                        "AND departure_date >= :fromDate)";


                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                    cmd.Parameters.Add(":deskTypeId", OracleDbType.Varchar2).Value = deskTypeId;
                    cmd.Parameters.Add(":fromDate", dateFrom);
                    cmd.Parameters.Add(":toDate", dateTo);

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "desks");
                    return ds;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void InsertDataGrid(DataGridView Desks, String deskTypeId, DateTime fromDate, DateTime toDate)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string dateFrom = fromDate.ToString("dd-MMM-yy");
                string dateTo = toDate.ToString("dd-MMM-yy");

                conn.Open();

                string sqlQuery = "SELECT desk_id, location, desk_type_id, availability_status " +
                    "FROM Desks " +
                    "WHERE desk_type_id = :deskTypeId " +
                    "AND desk_id NOT IN " +
                    "(SELECT desk_id FROM Bookings " +
                    "WHERE arrival_date <= :toDate " +
                    "AND departure_date >= :fromDate)";


                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(":deskTypeId", OracleDbType.Varchar2).Value = deskTypeId;
                cmd.Parameters.Add(":fromDate", dateFrom);
                cmd.Parameters.Add(":toDate", dateTo);

                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    Desks.Rows.Clear();
                    while (dr.Read())
                    {
                        Desks.Rows.Add(dr["Desk_id"], dr["location"], dr["desk_type_id"], dr["availability_status"]);
                    }
                }
            }
        }
        public void SetStatus(string status)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                string sqlUpdate = "UPDATE desks SET availability_status = :status WHERE desk_id = :deskID";

                using (OracleCommand cmd = new OracleCommand(sqlUpdate, conn))
                {
                    cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
                    cmd.Parameters.Add(":deskID", OracleDbType.Int32).Value = desk_ID;

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while updating desk status: " + ex.Message);
                    }
                }
            }
        }

    }
}


