namespace WindowsFormsApp1
{
    partial class frmUpdateCustomer
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUpdateCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.grpUpdateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(456, 201);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 61);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblUpdateCustomer
            // 
            this.lblUpdateCustomer.AutoSize = true;
            this.lblUpdateCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpdateCustomer.Location = new System.Drawing.Point(417, 26);
            this.lblUpdateCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUpdateCustomer.Name = "lblUpdateCustomer";
            this.lblUpdateCustomer.Size = new System.Drawing.Size(480, 67);
            this.lblUpdateCustomer.TabIndex = 37;
            this.lblUpdateCustomer.Text = "Update Customer";
            this.lblUpdateCustomer.Click += new System.EventHandler(this.lblRegisterCustomer_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(28, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpUpdateCustomer
            // 
            this.grpUpdateCustomer.Controls.Add(this.lblLName);
            this.grpUpdateCustomer.Controls.Add(this.lblPhone);
            this.grpUpdateCustomer.Controls.Add(this.txtFName);
            this.grpUpdateCustomer.Controls.Add(this.lblFirstName);
            this.grpUpdateCustomer.Controls.Add(this.btnSubmit);
            this.grpUpdateCustomer.Controls.Add(this.lblEmail);
            this.grpUpdateCustomer.Controls.Add(this.txtEmail);
            this.grpUpdateCustomer.Controls.Add(this.txtPhone);
            this.grpUpdateCustomer.Controls.Add(this.txtLName);
            this.grpUpdateCustomer.Location = new System.Drawing.Point(75, 478);
            this.grpUpdateCustomer.Name = "grpUpdateCustomer";
            this.grpUpdateCustomer.Size = new System.Drawing.Size(1142, 274);
            this.grpUpdateCustomer.TabIndex = 57;
            this.grpUpdateCustomer.TabStop = false;
            this.grpUpdateCustomer.Text = "Update Info";
            this.grpUpdateCustomer.Visible = false;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLName.Location = new System.Drawing.Point(17, 115);
            this.lblLName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(173, 37);
            this.lblLName.TabIndex = 57;
            this.lblLName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPhone.Location = new System.Drawing.Point(634, 49);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 37);
            this.lblPhone.TabIndex = 49;
            this.lblPhone.Text = "Phone";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(218, 53);
            this.txtFName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(296, 31);
            this.txtFName.TabIndex = 46;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblFirstName.Location = new System.Drawing.Point(17, 47);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(175, 37);
            this.lblFirstName.TabIndex = 45;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEmail.Location = new System.Drawing.Point(636, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 37);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(835, 121);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 31);
            this.txtEmail.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(835, 55);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(296, 31);
            this.txtPhone.TabIndex = 39;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(218, 121);
            this.txtLName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(296, 31);
            this.txtLName.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(798, 156);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 53);
            this.btnSearch.TabIndex = 59;
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
            this.lblSurname.Location = new System.Drawing.Point(374, 167);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(133, 33);
            this.lblSurname.TabIndex = 58;
            this.lblSurname.Text = "Surname";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(524, 167);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 31);
            this.txtSearch.TabIndex = 60;
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(135, 237);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.RowHeadersWidth = 82;
            this.grdCustomers.RowTemplate.Height = 33;
            this.grdCustomers.Size = new System.Drawing.Size(1052, 209);
            this.grdCustomers.TabIndex = 61;
            this.grdCustomers.Visible = false;
            this.grdCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellContentClick);
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 782);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.grpUpdateCustomer);
            this.Controls.Add(this.lblUpdateCustomer);
            this.Controls.Add(this.btnBack);
            this.Name = "frmUpdateCustomer";
            this.Text = "frmUpdateCustomer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.grpUpdateCustomer.ResumeLayout(false);
            this.grpUpdateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUpdateCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpUpdateCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}