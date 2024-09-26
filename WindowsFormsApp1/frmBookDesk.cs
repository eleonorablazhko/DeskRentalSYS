using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class frmBookDesk : Form
    {
        private string selectedDeskType;
        private DateTime selectedFromDate;
        private DateTime selectedToDate;
        private string selectedDeskID;
        frmMainMenu parent;
        Customer aCustomer = new Customer();
        Desk aDesk = new Desk();
        Booking aBooking = new Booking();
        

        public frmBookDesk()
        {
            InitializeComponent();
            
        }
        public frmBookDesk(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
            calDateFrom.MinDate = DateTime.Today;
            calDateFrom.Value = DateTime.Today;
            calDateTo.MinDate = DateTime.Today;
            calDateTo.Value = DateTime.Today.AddDays(2);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmBookDesk_Load(object sender, EventArgs e)
        {
            DataSet ds = DeskType.getDeskTypes();
            cboDeskType.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboDeskType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        private void btnFindDesk_Click(object sender, EventArgs e)
        {
            if (calDateFrom.Value >= calDateTo.Value)
            {
                MessageBox.Show("Please select valid dates.");
                return;
            }
            DateTime arrivalDate = calDateFrom.Value;
            DateTime departureDate = calDateTo.Value;
            int bookingDuration = (departureDate - arrivalDate).Days;
            if (bookingDuration < 2)
            {
                MessageBox.Show("Booking duration must be at least 2 days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedDeskType = cboDeskType.Text.Substring(0, 2);
            selectedFromDate = calDateFrom.Value;
            selectedToDate = calDateTo.Value;
            // Insert data into the DataGridView
            Desk.InsertDataGrid(grdDesks, selectedDeskType, selectedFromDate, selectedToDate);
            grdDesks.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please enter a last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            if (txtSearch.Text.Any(char.IsDigit) || !txtSearch.Text.All(char.IsLetter))
            {
                MessageBox.Show("Last name must not contain digits or symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            //find matching customers
            grdCustomers.DataSource = Customer.findCustomers(txtSearch.Text.ToUpper()).Tables["customer"];

            if (grdCustomers.Rows.Count <= 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
            grdCustomers.Visible = true;
    }

        private void grdDesks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdDesks.Rows.Count)
            {
                DataGridViewRow selectedRow = grdDesks.Rows[e.RowIndex];
                selectedDeskID = selectedRow.Cells["desk_id"].Value.ToString();
                grpCustomers.Visible = true;
            }
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdCustomers.Rows.Count)
            {
                int customerId = Convert.ToInt32(grdCustomers.Rows[e.RowIndex].Cells["Customer_ID"].Value);

                string availabilityStatus = Customer.RetrieveAvailabilityStatus(customerId);

                if (availabilityStatus == "Deleted")
                {
                    MessageBox.Show("The Customer is already deregistered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                DataGridViewRow selectedRow = grdCustomers.Rows[e.RowIndex];
                grpBookingDetails.Visible = true;
                txtBookingID.Enabled = false;
                txtCustomerID.Enabled = false;
                txtDeskID.Enabled = false;
                txtTotalCost.Enabled = false;
                txtDeskTypeID.Enabled = false;
                txtArrivalDate.Enabled = false;
                txtDepartureDate.Enabled = false;

                // Calculate the number of days between arrival and departure dates
                int numberOfDays = (selectedToDate - selectedFromDate).Days;
                
                // Populate the text boxes with booking details
                txtBookingID.Text = Booking.getNextBookingID().ToString("0000");
                txtCustomerID.Text = customerId.ToString("0000");
                txtDeskID.Text = selectedDeskID;
                txtTotalCost.Text = aBooking.CalculateTotalCost(selectedDeskType, numberOfDays).ToString("0.00");
                txtDeskTypeID.Text = selectedDeskType;
                txtArrivalDate.Text = selectedFromDate.ToString("dddd dd MMMM yyyy");
                txtDepartureDate.Text = selectedToDate.ToString("dddd dd MMMM yyyy");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            aDesk.SetStatus("O");
            aDesk.updateDesk();
            // Extract values from the form
            int bookingID = int.Parse(txtBookingID.Text);
            int customerID = int.Parse(txtCustomerID.Text);
            int deskID = int.Parse(txtDeskID.Text);
            decimal totalCost = decimal.Parse(txtTotalCost.Text);
            string deskTypeID = txtDeskTypeID.Text;
            DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text);
            DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);

            // Insert the new reservation into the database
            if (Booking.BookDesk(bookingID, customerID, deskID, deskTypeID, arrivalDate, departureDate, totalCost))
            {
                MessageBox.Show("Failed to create reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reservation created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookingID.Clear();
                txtCustomerID.Clear();
                txtDeskID.Clear();
                txtDeskTypeID.Clear();
                txtArrivalDate.Clear();
                txtDepartureDate.Clear();
                txtTotalCost.Clear();
                grpCustomers.Visible = false;
                grpBookingDetails.Visible = false;
                grdCustomers.DataSource = null;
                grdCustomers.Visible = false;
                grdDesks.DataSource = null;
                grdDesks.Visible = false;
                calDateFrom.MinDate = DateTime.Today;
                calDateFrom.Value = DateTime.Today;
                calDateTo.MinDate = DateTime.Today;
                calDateTo.Value = DateTime.Today.AddDays(2);
                cboDeskType.SelectedIndex = -1;
            }
        }
    }
}
