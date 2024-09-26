using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class frmUpdateCustomer : Form
    {
        frmMainMenu parent;
        Customer theCustomer = new Customer();
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }
        public frmUpdateCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void lblRegisterCustomer_Click(object sender, EventArgs e)
        {

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Equals(""))
            {
                MessageBox.Show("Forename Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }
            else if (txtFName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Forename Must Not Contain Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }
            else if (txtLName.Text.Equals(""))
            {
                MessageBox.Show("Surname Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Focus();
                return;
            }
            else if (txtLName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Surname Must Not Contain Digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLName.Focus();
                return;
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string email = txtEmail.Text;
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid Email Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else
            {
                //instantiate the object variables
                theCustomer.setFirstName(txtFName.Text);
                theCustomer.setLastName(txtLName.Text);
                theCustomer.setEmail(txtEmail.Text);
                theCustomer.setPhone(txtPhone.Text);

                //update the data in the database
                theCustomer.updateCustomer();

                //Display confirmation message
                MessageBox.Show("Customer Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset UI
                grpUpdateCustomer.Visible = false;
                grdCustomers.Visible = false;
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(grdCustomers.Rows[e.RowIndex].Cells["Customer_id"].Value);
            theCustomer.getCustomer(Id);
            int customerId = Convert.ToInt32(grdCustomers.Rows[e.RowIndex].Cells["Customer_ID"].Value);
            // Check the status of the customer
            string availabilityStatus = Customer.RetrieveAvailabilityStatus(customerId);

            if (availabilityStatus == "Deleted")
            {
                MessageBox.Show("The Customer is already deregistered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            // Move the instance variable values to the form controls
            txtFName.Text = theCustomer.getFirstName();
            txtLName.Text = theCustomer.getLastName();
            txtEmail.Text = theCustomer.getEmail();
            txtPhone.Text = theCustomer.getPhone();
            grpUpdateCustomer.Visible = true;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
