 namespace WindowsFormsApp1
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.mnuDesks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeregisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseCustomerPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseYearlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 66);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1486, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip4
            // 
            this.menuStrip4.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip4.Location = new System.Drawing.Point(0, 42);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(1486, 24);
            this.menuStrip4.TabIndex = 5;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // menuStrip5
            // 
            this.menuStrip5.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDesks,
            this.mnuCustomers,
            this.mnuBookings,
            this.mnuDataAnalysis,
            this.mnuDBConnect});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(1486, 42);
            this.menuStrip5.TabIndex = 6;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // mnuDesks
            // 
            this.mnuDesks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddDesk,
            this.mnuUpdateDesk,
            this.mnuRemoveDesk});
            this.mnuDesks.Name = "mnuDesks";
            this.mnuDesks.Size = new System.Drawing.Size(96, 38);
            this.mnuDesks.Text = "Desks";
            // 
            // mnuAddDesk
            // 
            this.mnuAddDesk.Name = "mnuAddDesk";
            this.mnuAddDesk.Size = new System.Drawing.Size(285, 44);
            this.mnuAddDesk.Text = "AddDesk";
            this.mnuAddDesk.Click += new System.EventHandler(this.mnuAddDesk_Click);
            // 
            // mnuUpdateDesk
            // 
            this.mnuUpdateDesk.Name = "mnuUpdateDesk";
            this.mnuUpdateDesk.Size = new System.Drawing.Size(285, 44);
            this.mnuUpdateDesk.Text = "UpdateDesk";
            this.mnuUpdateDesk.Click += new System.EventHandler(this.mnuUpdateDesk_Click);
            // 
            // mnuRemoveDesk
            // 
            this.mnuRemoveDesk.Name = "mnuRemoveDesk";
            this.mnuRemoveDesk.Size = new System.Drawing.Size(285, 44);
            this.mnuRemoveDesk.Text = "RemoveDesk";
            this.mnuRemoveDesk.Click += new System.EventHandler(this.mnuRemoveDesk_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer,
            this.mnuDeregisterCustomer});
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(147, 38);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(360, 44);
            this.mnuRegisterCustomer.Text = "RegisterCustomer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.mnuRegisterCustomer_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(360, 44);
            this.mnuUpdateCustomer.Text = "UpdateCustomer";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.mnuUpdateCustomer_Click);
            // 
            // mnuDeregisterCustomer
            // 
            this.mnuDeregisterCustomer.Name = "mnuDeregisterCustomer";
            this.mnuDeregisterCustomer.Size = new System.Drawing.Size(360, 44);
            this.mnuDeregisterCustomer.Text = "DeregisterCustomer";
            this.mnuDeregisterCustomer.Click += new System.EventHandler(this.mnuDeregisterCustomer_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookDesk,
            this.mnuCancelBooking});
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(132, 38);
            this.mnuBookings.Text = "Bookings";
            // 
            // mnuBookDesk
            // 
            this.mnuBookDesk.Name = "mnuBookDesk";
            this.mnuBookDesk.Size = new System.Drawing.Size(359, 44);
            this.mnuBookDesk.Text = "BookDesk";
            this.mnuBookDesk.Click += new System.EventHandler(this.mnuBookDesk_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(359, 44);
            this.mnuCancelBooking.Text = "CancelBooking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuDataAnalysis
            // 
            this.mnuDataAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseCustomerPreferences,
            this.mnuAnalyseYearlyRevenue});
            this.mnuDataAnalysis.Name = "mnuDataAnalysis";
            this.mnuDataAnalysis.Size = new System.Drawing.Size(168, 38);
            this.mnuDataAnalysis.Text = "DataAnalysis";
            // 
            // mnuAnalyseCustomerPreferences
            // 
            this.mnuAnalyseCustomerPreferences.Name = "mnuAnalyseCustomerPreferences";
            this.mnuAnalyseCustomerPreferences.Size = new System.Drawing.Size(456, 44);
            this.mnuAnalyseCustomerPreferences.Text = "AnalyseCustomerPreferences";
            this.mnuAnalyseCustomerPreferences.Click += new System.EventHandler(this.mnuAnalyseCustomerPreferences_Click);
            // 
            // mnuAnalyseYearlyRevenue
            // 
            this.mnuAnalyseYearlyRevenue.Name = "mnuAnalyseYearlyRevenue";
            this.mnuAnalyseYearlyRevenue.Size = new System.Drawing.Size(456, 44);
            this.mnuAnalyseYearlyRevenue.Text = "AnalyseYearlyRevenue";
            this.mnuAnalyseYearlyRevenue.Click += new System.EventHandler(this.mnuAnalyseYearlyRevenue_Click);
            // 
            // mnuDBConnect
            // 
            this.mnuDBConnect.Name = "mnuDBConnect";
            this.mnuDBConnect.Size = new System.Drawing.Size(154, 38);
            this.mnuDBConnect.Text = "DBConnect";
            this.mnuDBConnect.Click += new System.EventHandler(this.mnuDBConnect_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1486, 865);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip4);
            this.Controls.Add(this.menuStrip5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuDesks;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuDeregisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddDesk;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDesk;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveDesk;
        private System.Windows.Forms.ToolStripMenuItem mnuBookDesk;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseCustomerPreferences;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseYearlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem mnuDBConnect;
    }
}

