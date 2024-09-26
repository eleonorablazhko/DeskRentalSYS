using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class DeskType
    {
        private int desk_type_id;
        private String description;
        private int rate;
        public DeskType()
        {
            this.desk_type_id = 0;
            this.description = "";
            this.rate = 0;
        }

        public DeskType(string description, int desk_type_id, int rate)
        {
            this.description = description;
            this.desk_type_id = desk_type_id;
            this.rate = rate;
        }

        public static DataSet getDeskTypes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM DeskTypes ORDER BY desk_type_id";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static int GetDeskTypeCost(string deskTypeId)
        {
            int cost = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to retrieve the rate of the selected desk type
                string sqlQuery = "SELECT cost FROM DeskTypes WHERE desk_type_id = :deskTypeId";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameter
                    cmd.Parameters.Add(":deskTypeId", OracleDbType.Varchar2).Value = deskTypeId;
                    conn.Open();

                    // Execute the command and retrieve the rate
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        cost = Convert.ToInt32(result);
                    }
                }
            }

            return cost;
        }
    }
}

