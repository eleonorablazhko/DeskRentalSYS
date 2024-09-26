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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class frmUpdateDesk : Form
    {
        frmMainMenu parent;
        Desk theDesk = new Desk();
        public frmUpdateDesk()
        {
            InitializeComponent();
            
        }
        public frmUpdateDesk(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void UpdateDesk_Load(object sender, EventArgs e)
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
                txtSearch.Focus();
                return;
            }
            else if (!Regex.IsMatch(txtSearch.Text, @"^\d{1,4}$"))
            {
                MessageBox.Show("DESK_ID must be a numeric value with up to 4 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            int deskId = int.Parse(txtSearch.Text);
            
            
            // Check if the desk ID exists in the database
            if (!Desk.ExistingDesk(deskId))
            {
                MessageBox.Show("The specified DESK_ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            // Check the availability status of the desk
            char availabilityStatus = Desk.retrieveAvailabilityStatus(deskId);

            // Check if the availability status is 'O'
            if (availabilityStatus == 'O')
            {
                MessageBox.Show("The availability status of the desk is 'O' and cannot be changed for now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
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

        
        

        private void grpUpdateDesk_Enter(object sender, EventArgs e)
        {

        }

        private void lblSelectDeskType_Click(object sender, EventArgs e)
        {

        }

        private void txtDeskNum_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void grdDesks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdDesks.Rows.Count)
            {
                // Extract the Desk_ID from column zero on the selected row in the grid
                int deskId = Convert.ToInt32(grdDesks.Rows[e.RowIndex].Cells["Desk_id"].Value);

                // Check the availability status of the desk
                char availabilityStatus = Desk.retrieveAvailabilityStatus(deskId);

                // Check if the availability status is 'O'
                if (availabilityStatus == 'O')
                {
                    MessageBox.Show("The availability status of the desk is 'O' and cannot be changed for now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                // Check if the availability status is 'D'
                if (availabilityStatus == 'D')
                {
                    MessageBox.Show("The desk is removed from the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                else
                {
                    theDesk.getDesk(deskId);

                    // Move the instance variable values to the form controls
                    txtLocation.Text = theDesk.getLocation();

                    // Load desk types into combo box and set current value
                    //Load TypeCodes into combo box and set current value
                    DataSet ds = DeskType.getDeskTypes();
                    int typeIndex = 0;
                    cboDeskType.Items.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        cboDeskType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                        if (ds.Tables[0].Rows[i][0].Equals(theDesk.getDesk_type_id())) typeIndex = i;
                    }
                    cboDeskType.SelectedIndex = typeIndex;
                }

                // Make the desk data available for updating
                grpUpdateDesk.Visible = true;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDeskType.Text))
            {
                MessageBox.Show("Please select a desk type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDeskType.Focus();
                return;
            }
            // Checks if the location is provided
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location for the desk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            //instantiate the object variables

            theDesk.setLocation(txtLocation.Text);
            theDesk.setDesk_type_id(cboDeskType.Text.Substring(0, 2));

            //update the data in the database
            theDesk.updateDesk();

            //Display confirmation message
            MessageBox.Show("Desk Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpUpdateDesk.Visible = false;
            grdDesks.Visible = false;
            txtSearch.Clear();
            txtSearch.Focus();
        
    }
    }
 }

