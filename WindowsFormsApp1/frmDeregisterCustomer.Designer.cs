namespace WindowsFormsApp1
{
    partial class frmDeregisterCustomer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDeregisterCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(538, 160);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 31);
            this.txtSearch.TabIndex = 66;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(790, 148);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 54);
            this.btnSearch.TabIndex = 65;
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
            this.lblSurname.Location = new System.Drawing.Point(366, 160);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(133, 33);
            this.lblSurname.TabIndex = 64;
            this.lblSurname.Text = "Surname";
            // 
            // lblDeregisterCustomer
            // 
            this.lblDeregisterCustomer.AutoSize = true;
            this.lblDeregisterCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblDeregisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeregisterCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDeregisterCustomer.Location = new System.Drawing.Point(408, 19);
            this.lblDeregisterCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeregisterCustomer.Name = "lblDeregisterCustomer";
            this.lblDeregisterCustomer.Size = new System.Drawing.Size(560, 67);
            this.lblDeregisterCustomer.TabIndex = 62;
            this.lblDeregisterCustomer.Text = "Deregister Customer";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(20, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(116, 234);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.RowHeadersWidth = 82;
            this.grdCustomers.RowTemplate.Height = 33;
            this.grdCustomers.Size = new System.Drawing.Size(1052, 511);
            this.grdCustomers.TabIndex = 67;
            this.grdCustomers.Visible = false;
            this.grdCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellContentClick);
            // 
            // frmDeregisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblDeregisterCustomer);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeregisterCustomer";
            this.Text = "DeregisterCustomer";
            this.Load += new System.EventHandler(this.frmDeregisterCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDeregisterCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}