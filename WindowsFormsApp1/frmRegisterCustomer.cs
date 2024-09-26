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
    public partial class frmRegisterCustomer : Form
    {
        frmMainMenu parent;
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }
        public frmRegisterCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
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

            // Check if the email already exists in the database
            if (Customer.existsEmail(email))
            {
                MessageBox.Show("Email Already Exists in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Check if the phone number already exists in the database
            string phoneNumber = txtPhone.Text;
            if (Customer.existsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone Number Already Exists in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }


            else
            {
                try
                {
                    
                    //Create an instance of Customer and instantiate with values from form controls
                    Customer aCustomer = new Customer(Convert.ToInt32(txtCustID.Text), txtFName.Text,
                        txtLName.Text,txtEmail.Text, txtPhone.Text, "Active");

                    //invoke the method to add the data to the Customers table
                    aCustomer.registerCustomer();

                    //display confirmation message
                    MessageBox.Show("Customer " + txtCustID.Text + " registered successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //reset UI
                    txtCustID.Text = Customer.getNextCustomerID().ToString("0000");
                    txtFName.Clear();
                    txtLName.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();

                }
                catch (Exception ex)
                {
                    //exception
                    MessageBox.Show("Error: The Customer cannot be registered due to incomplete information: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            txtCustID.Text = Customer.getNextCustomerID().ToString("0000");
        }
    }
}
