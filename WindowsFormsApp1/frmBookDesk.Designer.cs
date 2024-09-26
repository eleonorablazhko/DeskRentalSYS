namespace WindowsFormsApp1
{
    partial class frmBookDesk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookDesk = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.calDateFrom = new System.Windows.Forms.DateTimePicker();
            this.calDateTo = new System.Windows.Forms.DateTimePicker();
            this.cboDeskType = new System.Windows.Forms.ComboBox();
            this.lblDeskType = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.btnFindDesk = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.grdDesks = new System.Windows.Forms.DataGridView();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.Desk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desk_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtDeskID = new System.Windows.Forms.TextBox();
            this.txtDeskTypeID = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.grpCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookDesk
            // 
            this.lblBookDesk.AutoSize = true;
            this.lblBookDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblBookDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDesk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBookDesk.Location = new System.Drawing.Point(439, 9);
            this.lblBookDesk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookDesk.Name = "lblBookDesk";
            this.lblBookDesk.Size = new System.Drawing.Size(308, 67);
            this.lblBookDesk.TabIndex = 4;
            this.lblBookDesk.Text = "Book Desk";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(6, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // calDateFrom
            // 
            this.calDateFrom.Location = new System.Drawing.Point(43, 149);
            this.calDateFrom.Name = "calDateFrom";
            this.calDateFrom.Size = new System.Drawing.Size(396, 31);
            this.calDateFrom.TabIndex = 5;
            // 
            // calDateTo
            // 
            this.calDateTo.Location = new System.Drawing.Point(463, 149);
            this.calDateTo.Name = "calDateTo";
            this.calDateTo.Size = new System.Drawing.Size(396, 31);
            this.calDateTo.TabIndex = 6;
            // 
            // cboDeskType
            // 
            this.cboDeskType.FormattingEnabled = true;
            this.cboDeskType.Location = new System.Drawing.Point(896, 151);
            this.cboDeskType.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeskType.Name = "cboDeskType";
            this.cboDeskType.Size = new System.Drawing.Size(210, 33);
            this.cboDeskType.TabIndex = 16;
            // 
            // lblDeskType
            // 
            this.lblDeskType.AutoSize = true;
            this.lblDeskType.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskType.Location = new System.Drawing.Point(889, 101);
            this.lblDeskType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskType.Name = "lblDeskType";
            this.lblDeskType.Size = new System.Drawing.Size(168, 37);
            this.lblDeskType.TabIndex = 15;
            this.lblDeskType.Text = "Desk Type";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDateFrom.Location = new System.Drawing.Point(154, 101);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(169, 37);
            this.lblDateFrom.TabIndex = 17;
            this.lblDateFrom.Text = "Date From";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDateTo.Location = new System.Drawing.Point(546, 101);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(131, 37);
            this.lblDateTo.TabIndex = 18;
            this.lblDateTo.Text = "Date To";
            // 
            // btnFindDesk
            // 
            this.btnFindDesk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindDesk.Location = new System.Drawing.Point(482, 220);
            this.btnFindDesk.Margin = new System.Windows.Forms.Padding(6);
            this.btnFindDesk.Name = "btnFindDesk";
            this.btnFindDesk.Size = new System.Drawing.Size(176, 42);
            this.btnFindDesk.TabIndex = 19;
            this.btnFindDesk.Text = "Find Desk";
            this.btnFindDesk.UseVisualStyleBackColor = false;
            this.btnFindDesk.Click += new System.EventHandler(this.btnFindDesk_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(430, 247);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 52);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.txtArrivalDate);
            this.grpBookingDetails.Controls.Add(this.txtDepartureDate);
            this.grpBookingDetails.Controls.Add(this.txtTotalCost);
            this.grpBookingDetails.Controls.Add(this.txtDeskTypeID);
            this.grpBookingDetails.Controls.Add(this.txtDeskID);
            this.grpBookingDetails.Controls.Add(this.txtCustomerID);
            this.grpBookingDetails.Controls.Add(this.txtBookingID);
            this.grpBookingDetails.Controls.Add(this.label6);
            this.grpBookingDetails.Controls.Add(this.label5);
            this.grpBookingDetails.Controls.Add(this.label4);
            this.grpBookingDetails.Controls.Add(this.label3);
            this.grpBookingDetails.Controls.Add(this.label2);
            this.grpBookingDetails.Controls.Add(this.label1);
            this.grpBookingDetails.Controls.Add(this.lblBookingId);
            this.grpBookingDetails.Controls.Add(this.btnSubmit);
            this.grpBookingDetails.Location = new System.Drawing.Point(43, 930);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(1063, 308);
            this.grpBookingDetails.TabIndex = 58;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Create Reservation";
            this.grpBookingDetails.Visible = false;
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(388, 21);
            this.lblBookingId.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(113, 25);
            this.lblBookingId.TabIndex = 59;
            this.lblBookingId.Text = "Booking Id";
            // 
            // grdDesks
            // 
            this.grdDesks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desk_id,
            this.Location,
            this.Desk_type_id,
            this.Availability_status});
            this.grdDesks.Location = new System.Drawing.Point(43, 284);
            this.grdDesks.Name = "grdDesks";
            this.grdDesks.RowHeadersWidth = 82;
            this.grdDesks.RowTemplate.Height = 33;
            this.grdDesks.Size = new System.Drawing.Size(1063, 297);
            this.grdDesks.TabIndex = 62;
            this.grdDesks.Visible = false;
            this.grdDesks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDesks_CellContentClick);
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(15, 103);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.RowHeadersWidth = 82;
            this.grdCustomers.RowTemplate.Height = 33;
            this.grdCustomers.Size = new System.Drawing.Size(1006, 209);
            this.grdCustomers.TabIndex = 66;
            this.grdCustomers.Visible = false;
            this.grdCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(393, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 31);
            this.txtSearch.TabIndex = 65;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(668, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 53);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.LightGray;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSurname.Location = new System.Drawing.Point(236, 47);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(133, 33);
            this.lblSurname.TabIndex = 63;
            this.lblSurname.Text = "Surname";
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.txtSearch);
            this.grpCustomers.Controls.Add(this.grdCustomers);
            this.grpCustomers.Controls.Add(this.btnSearch);
            this.grpCustomers.Controls.Add(this.lblSurname);
            this.grpCustomers.Location = new System.Drawing.Point(43, 577);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(1063, 347);
            this.grpCustomers.TabIndex = 67;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Select Customer";
            this.grpCustomers.Visible = false;
            // 
            // Desk_id
            // 
            this.Desk_id.HeaderText = "Desk_id";
            this.Desk_id.MinimumWidth = 10;
            this.Desk_id.Name = "Desk_id";
            this.Desk_id.Width = 50;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 10;
            this.Location.Name = "Location";
            this.Location.Width = 200;
            // 
            // Desk_type_id
            // 
            this.Desk_type_id.HeaderText = "Desk_type_id";
            this.Desk_type_id.MinimumWidth = 10;
            this.Desk_type_id.Name = "Desk_type_id";
            // 
            // Availability_status
            // 
            this.Availability_status.HeaderText = "Availability_status";
            this.Availability_status.MinimumWidth = 10;
            this.Availability_status.Name = "Availability_status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Desk Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Desk Type Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Arrival Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Departure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Total Cost";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(508, 18);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(196, 31);
            this.txtBookingID.TabIndex = 66;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(180, 63);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(196, 31);
            this.txtCustomerID.TabIndex = 67;
            // 
            // txtDeskID
            // 
            this.txtDeskID.Location = new System.Drawing.Point(180, 129);
            this.txtDeskID.Name = "txtDeskID";
            this.txtDeskID.Size = new System.Drawing.Size(196, 31);
            this.txtDeskID.TabIndex = 68;
            // 
            // txtDeskTypeID
            // 
            this.txtDeskTypeID.Location = new System.Drawing.Point(180, 195);
            this.txtDeskTypeID.Name = "txtDeskTypeID";
            this.txtDeskTypeID.Size = new System.Drawing.Size(196, 31);
            this.txtDeskTypeID.TabIndex = 69;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(853, 195);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(196, 31);
            this.txtTotalCost.TabIndex = 70;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(853, 129);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(196, 31);
            this.txtDepartureDate.TabIndex = 71;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(853, 63);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(196, 31);
            this.txtArrivalDate.TabIndex = 72;
            // 
            // frmBookDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 1298);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.grdDesks);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.btnFindDesk);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.cboDeskType);
            this.Controls.Add(this.lblDeskType);
            this.Controls.Add(this.calDateTo);
            this.Controls.Add(this.calDateFrom);
            this.Controls.Add(this.lblBookDesk);
            this.Controls.Add(this.btnBack);
            this.Name = "frmBookDesk";
            this.Text = "frmBookDesk";
            this.Load += new System.EventHandler(this.frmBookDesk_Load);
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookDesk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker calDateFrom;
        private System.Windows.Forms.DateTimePicker calDateTo;
        private System.Windows.Forms.ComboBox cboDeskType;
        private System.Windows.Forms.Label lblDeskType;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnFindDesk;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.DataGridView grdDesks;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desk_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtDeskTypeID;
        private System.Windows.Forms.TextBox txtDeskID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label6;
    }
}