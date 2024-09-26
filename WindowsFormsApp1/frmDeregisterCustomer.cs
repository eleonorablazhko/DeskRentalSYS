using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class frmDeregisterCustomer : Form
    {
        frmMainMenu parent;
        public frmDeregisterCustomer()
        {
            InitializeComponent();
        }
        public frmDeregisterCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
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

            // make the matching customers visible
            grdCustomers.Visible = true;
        }
    

        private void grpDeregisterCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(grdCustomers.Rows[e.RowIndex].Cells["Customer_ID"].Value);

                string availabilityStatus = Customer.RetrieveAvailabilityStatus(customerId);

                if (availabilityStatus == "Deleted")
                {
                    MessageBox.Show("The Customer is already deregistered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                    return;
                }
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to deregister Customer with ID " + customerId + "?",
                                                      "Confirm Deregestration",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Customer customer = new Customer();
                        customer.deregisterCustomer(customerId);

                        // Show success message
                        MessageBox.Show("Customer with ID " + customerId + " has been successfully deregistered.", "Customer Deregistered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grdCustomers.Visible = false;
                        txtSearch.Clear();
                        txtSearch.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deregestering customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                  
                }
            }
        }

        private void frmDeregisterCustomer_Load(object sender, EventArgs e)
        {

        }
    }

}
