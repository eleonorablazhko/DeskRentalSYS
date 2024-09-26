using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer
    {
        private int customer_ID;
        private String firstName;
        private String lastName;
        private String email;
        private String phone;
        private String status;



        public Customer()
        {
            this.customer_ID = 0;
            this.firstName = "";
            this.lastName = "";
            this.email = "";
            this.phone = "";
            this.status = "";
        }

        public Customer(int customer_ID, string firstName, string lastName, string email, string phone, string status)
        {
            this.customer_ID = customer_ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.status = status;
        }
        //getters
        public int getCustomer_ID() { return this.customer_ID; }
        public String getFirstName() { return this.firstName; }
        public String getLastName() { return this.lastName; }
        public String getEmail() { return this.email; }
        public String getStatus() { return this.status; }
        public String getPhone() { return this.phone; }

        //setters
        public void setCustomer_ID(int CustomerID) { customer_ID = CustomerID; }
        public void setFirstName(String FName) { firstName = FName; }
        public void setLastName(String LName) { lastName = LName; }
        public void setEmail(String Email) { email = Email; }
        public void setStatus(String Status) { status = Status; }
        public void setPhone(string Phone) { phone = Phone; }


        public void registerCustomer()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Customers ( customer_ID, firstName, lastName, email, phone, status) " +
                  "VALUES (" + this.customer_ID + ", '" +
                                     this.firstName + "', '" +
                                     this.lastName + "', '" +
                                     this.email + "', '" +
                                     this.phone + "', '" +
                                     this.status + "')";



            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public static int getNextCustomerID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(customer_id) FROM Customers";

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
        public static bool existsEmail(string email)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to be executed
                string sqlQuery = "SELECT COUNT(*) FROM Customers WHERE email = :email";

                // Create and execute the SQL command
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameter for email
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                    // Open the connection
                    conn.Open();

                    // Execute the command and get the count
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Close the connection
                    conn.Close();

                    // If count is greater than 0, the email exists
                    return count > 0;
                }
            }
        }
        public static bool existsPhoneNumber(string phoneNumber)
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to be executed
                string sqlQuery = "SELECT COUNT(*) FROM Customers WHERE phone = :phone";

                // Create and execute the SQL command
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameter for phoneNumber
                    cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phoneNumber;

                    // Open the connection
                    conn.Open();

                    // Execute the command and get the count
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Close the connection
                    conn.Close();

                    // If count is greater than 0, the phoneNumber exists
                    return count > 0;
                }
            }
        }
        public void getCustomer(int Id)
        {
            //Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                //Define the SQL query to be executed
                String sqlQuery = "SELECT * FROM Customers WHERE Customer_ID = " + Id;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    if (dr.Read()) // Check if there are rows to read
                    {
                        // Set the instance variables with values from data reader
                        setCustomer_ID(dr.GetInt32(0));
                        setFirstName(dr.GetString(1));
                        setLastName(dr.GetString(2));
                        setEmail(dr.GetString(3));
                        setPhone(dr.GetString(4));
                        setStatus(dr.GetString(5));
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    Console.WriteLine("Error occurred while setting instance variables from data reader: " + ex.Message);
                }

                //close DB
                conn.Close();
            }
        }
        public void updateCustomer()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "UPDATE Customers SET " +
                "Customer_Id = " + this.customer_ID + "," +
                "FirstName = '" + this.firstName + "'," +
                "LastName = '" + this.lastName + "'," +
                "email = '" + this.email + "'," +
                "phone = '" + this.phone + "' " +
                "WHERE Customer_Id = " + this.customer_ID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findCustomers(String lastName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            String sqlQuery = "SELECT customer_ID, firstName, lastName, email, phone, status FROM Customers " +
                "WHERE lastName LIKE '" + lastName + "%' ORDER BY Customer_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "customer");

            //Close db connection
            conn.Close();

            return ds;
        }
        public void deregisterCustomer(int customerId)
        {
            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                try
                {
                    // Define the SQL query to update the status to "deregistered"
                    string sqlQuery = "UPDATE Customers SET Status = 'Deleted' WHERE Customer_ID = :customerId";

                    // Create the OracleCommand object with parameters
                    using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId;

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
        public static string RetrieveAvailabilityStatus(int customerId)
        {
            string availabilityStatus = "Active"; // Assuming "Active" represents an active status

            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to retrieve availability status
                string sqlQuery = "SELECT status FROM Customers WHERE Customer_ID = :customerId";

                // Create the OracleCommand object with parameters
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.Add(":customerId", OracleDbType.Int32).Value = customerId;

                    // Open the database connection
                    conn.Open();

                    // Execute the SQL query
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null && result != DBNull.Value)
                    {
                        availabilityStatus = Convert.ToString(result);
                    }
                }
            }

            return availabilityStatus;
        }



    }
}
