using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCancelBooking : Form
    {
        frmMainMenu parent;
        Booking aBooking = new Booking();
        Desk aDesk = new Desk();
        public frmCancelBooking()
        {
            InitializeComponent();
        }
        public frmCancelBooking(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            grdBookings.DataSource = Booking.getAllBookings().Tables["booking"];             
}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please enter a BOOKING_ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtSearch.Text, @"^\d{1,4}$"))
            {
                MessageBox.Show("BOOKING_ID must be a numeric value with up to 4 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            //find matching desks
            grdBookings.DataSource = Booking.findBookings(txtSearch.Text).Tables["booking"];

            if (grdBookings.Rows.Count <= 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
        }

        private void grdBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected booking ID
            int bookingId = Convert.ToInt32(grdBookings.Rows[e.RowIndex].Cells["Booking_ID"].Value);

            // Get the arrival date of the selected booking
            DateTime arrivalDate = Convert.ToDateTime(grdBookings.Rows[e.RowIndex].Cells["Arrival_Date"].Value);

            // Calculate the difference in days between today and the arrival date
            int daysUntilArrival = (arrivalDate - DateTime.Today).Days;

            // Check if the difference is less than 2 days
            if (daysUntilArrival < 2)
            {
                MessageBox.Show("Cancellation less than 2 days before arrival date is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask for confirmation before deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete booking with ID " + bookingId + "?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete the booking
                    aBooking.DeleteBooking(bookingId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Display confirmation message
                    MessageBox.Show("Booking with ID " + bookingId + " has been successfully removed.", "Booking Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the bookings data grid
                    grdBookings.DataSource = Booking.getAllBookings().Tables["booking"];

                    // Update the desk status to available
                    aDesk.SetStatus("A");
                    aDesk.updateDesk();
                    // Reset UI
                    txtSearch.Clear();
                    txtSearch.Focus();
                }
            }
        }


    }
}
