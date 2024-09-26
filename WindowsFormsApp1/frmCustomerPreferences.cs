using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class frmCustomerPreferences : Form
    {
        frmMainMenu parent;
        public frmCustomerPreferences()
        {
            InitializeComponent();
            chtCustomerPreferences.Titles.Add("Customer Preferences");
        }

        public frmCustomerPreferences(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        


        private void DisplayCustomerPreferences(int month)
        {
            String strSQL = "SELECT desk_type_id, COUNT(*) " +
                            "FROM bookings " +
                            "WHERE EXTRACT(MONTH FROM arrival_Date) = :month " +
                            "GROUP BY desk_type_id";

            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.Parameters.Add(":month", OracleDbType.Int32).Value = month;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();

            // Bind data to the chart
            chtCustomerPreferences.Series[0].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string deskType = row[0].ToString();
                int bookingsCount = Convert.ToInt32(row[1]);
                chtCustomerPreferences.Series[0].Points.AddXY(deskType, bookingsCount);
            }
        }
        private void frmCustomerPreferences_Load(object sender, EventArgs e)
        {
            cboYears.Items.Add("2023");
            cboYears.Items.Add("2024");
        }

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonths.Items.Clear(); 
            cboMonths.Items.AddRange(GetMonthsOfYear(cboYears.SelectedItem.ToString())); 
        }

        private string[] GetMonthsOfYear(string year)
        {
            List<string> months = new List<string>();
            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(int.Parse(year), month, 1);
                months.Add(date.ToString("MMMM"));
            }
            return months.ToArray();
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = cboMonths.SelectedIndex + 1; 
            DisplayCustomerPreferences(selectedMonth);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
