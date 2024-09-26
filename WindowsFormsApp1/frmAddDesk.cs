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
    public partial class frmAddDesk : Form
    {
        frmMainMenu parent;
        public frmAddDesk()
        {
            InitializeComponent();
        }

        public frmAddDesk(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddDesk_Load(object sender, EventArgs e)
        {
            txtDesk_ID.Text = Desk.getNextDeskID().ToString("0000");
           
            //Load TypeCodes into ComboBox
            DataSet ds = DeskType.getDeskTypes();
            cboDeskType.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboDeskType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        private void txtDeskType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDeskType_Click(object sender, EventArgs e)
        {

        }

        private void lblAddDesk_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
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
            else
            {
                try
                {
                    //Create an instance of Desk and instantiate with values from form controls
                    Desk aDesk = new Desk(Convert.ToInt32(txtDesk_ID.Text), txtLocation.Text,
                        cboDeskType.Text.Substring(0, 2), "");

                    //invoke the method to add the data to the Products table
                    aDesk.addDesk();

                    //display confirmation message
                    MessageBox.Show("Desk " + txtDesk_ID.Text + " added successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //reset UI
                    txtDesk_ID.Text = Desk.getNextDeskID().ToString("0000");
                    txtLocation.Clear();
                    cboDeskType.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    //exception
                    MessageBox.Show("Error: The desk cannot be added due to incomplete information: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cboDeskType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
