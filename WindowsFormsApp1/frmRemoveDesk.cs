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
    public partial class frmRemoveDesk : Form
    {
        frmMainMenu parent;
        public frmRemoveDesk()
        {
            InitializeComponent();
        }
        public frmRemoveDesk(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void lblUpdateDesk_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate the input DESK_ID
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please enter a DESK_ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }
            else if (!Regex.IsMatch(txtSearch.Text, @"^\d{1,4}$"))
            {
                MessageBox.Show("DESK_ID must be a numeric value with up to 4 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }

            int deskId = int.Parse(txtSearch.Text);


            // Check if the desk ID exists in the database
            if (!Desk.ExistingDesk(deskId))
            {
                MessageBox.Show("The specified DESK_ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }

            // Check the availability status of the desk
            char availabilityStatus = Desk.retrieveAvailabilityStatus(deskId);

            // Check if the availability status is 'O'
            if (availabilityStatus == 'O')
            {
                MessageBox.Show("The availability status of the desk is 'O' and cannot be deleted for now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }
            //find matching desks
            grdDesks.DataSource = Desk.findDesks(txtSearch.Text).Tables["desks"];

            if (grdDesks.Rows.Count <= 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }

            // make the matching desks visible
            grdDesks.Visible = true;
        }

        private void grdDesks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the desk ID from the clicked row
                int deskId = Convert.ToInt32(grdDesks.Rows[e.RowIndex].Cells["Desk_ID"].Value);
                // Check the availability status of the desk
                char availabilityStatus = Desk.retrieveAvailabilityStatus(deskId);

                // Check if the availability status is 'O'
                if (availabilityStatus == 'O')
                {
                    MessageBox.Show("The availability status of the desk is 'O' and cannot be deleted for now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                // Check if the availability status is 'D'
                if (availabilityStatus == 'D')
                {
                    MessageBox.Show("The desk is already removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                else
                {
                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to remove desk with ID " + deskId + "?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Desk desk = new Desk();
                            desk.deleteDesk(deskId);

                            // Show success message
                            MessageBox.Show("Desk with ID " + deskId + " has been successfully removed.", "Desk Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView with the updated data
                            grdDesks.DataSource = Desk.getAllDesks().Tables["desk"];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting desk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            //Reset UI
            grdDesks.Visible = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void frmRemoveDesk_Load(object sender, EventArgs e)
        {

        }
    }
}
