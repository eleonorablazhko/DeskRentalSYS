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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void mnuAddDesk_Click(object sender, EventArgs e)
        {
            frmAddDesk newForm = new frmAddDesk(this);
            this.Hide();
            newForm.Show();

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuUpdateDesk_Click(object sender, EventArgs e)
        {
            frmUpdateDesk newForm = new frmUpdateDesk(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuRemoveDesk_Click(object sender, EventArgs e)
        {
            frmRemoveDesk newForm = new frmRemoveDesk(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuRegisterCustomer_Click(object sender, EventArgs e)
        {
            frmRegisterCustomer newForm = new frmRegisterCustomer(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuDeregisterCustomer_Click(object sender, EventArgs e)
        {
            frmDeregisterCustomer newForm = new frmDeregisterCustomer(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer newForm = new frmUpdateCustomer(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuBookDesk_Click(object sender, EventArgs e)
        {
            frmBookDesk newForm = new frmBookDesk(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuDBConnect_Click(object sender, EventArgs e)
        {
            frmDBConnect newForm = new frmDBConnect(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuAnalyseYearlyRevenue_Click(object sender, EventArgs e)
        {
            frmYearlyRevenue newForm = new frmYearlyRevenue(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuAnalyseCustomerPreferences_Click(object sender, EventArgs e)
        {
            frmCustomerPreferences newForm = new frmCustomerPreferences(this);
            this.Hide();
            newForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking newForm = new frmCancelBooking(this);
            this.Hide();
            newForm.Show();
        }
    }
}
