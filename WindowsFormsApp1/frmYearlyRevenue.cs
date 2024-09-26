using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;

        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        public frmYearlyRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        // Method to display yearly revenue based on the selected year
        private void DisplayYearlyRevenue(string year)
        {
            String strSQL = "SELECT SUM(total_cost), to_Char(arrival_Date,'MM')" +
                            "FROM bookings " +
                            "WHERE EXTRACT(YEAR FROM arrival_Date) = :year " + // Filter by selected year
                            "GROUP BY to_Char(arrival_Date,'MM') " +
                            "ORDER BY to_Char(arrival_Date, 'MM')";

            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.Parameters.Add(":year", OracleDbType.Varchar2).Value = year; // Pass the selected year as a parameter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();

            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            // Initialize arrays with month names and zero amounts
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i + 1);
                Amounts[i] = 0;
            }

            // Update amounts based on retrieved data
            foreach (DataRow row in dt.Rows)
            {
                int monthIndex = Convert.ToInt32(row[1]) - 1;
                Amounts[monthIndex] = Convert.ToDecimal(row[0]);
            }

            // Bind data to the chart
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
        }


        // Get month abbreviation
        public string getMonth(int month)
        {
            switch (month)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "OTH";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = cboYears.SelectedItem.ToString();
            DisplayYearlyRevenue(selectedYear);
        }

        private void frmYearlyRevenue_Load_1(object sender, EventArgs e)
        {
            cboYears.Items.Add("2023");
            cboYears.Items.Add("2024");
            cboYears.SelectedIndex = 1;
            DisplayYearlyRevenue("2024");
        }
    }
}
