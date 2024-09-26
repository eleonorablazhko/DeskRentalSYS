namespace WindowsFormsApp1
{
    partial class frmUpdateDesk
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
            this.grpUpdateDesk = new System.Windows.Forms.GroupBox();
            this.cboDeskType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDeskID = new System.Windows.Forms.Label();
            this.lblUpdateDesk = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdDesks = new System.Windows.Forms.DataGridView();
            this.grpUpdateDesk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUpdateDesk
            // 
            this.grpUpdateDesk.Controls.Add(this.cboDeskType);
            this.grpUpdateDesk.Controls.Add(this.btnSubmit);
            this.grpUpdateDesk.Controls.Add(this.txtLocation);
            this.grpUpdateDesk.Controls.Add(this.lblLocation);
            this.grpUpdateDesk.Controls.Add(this.label4);
            this.grpUpdateDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateDesk.Location = new System.Drawing.Point(133, 501);
            this.grpUpdateDesk.Margin = new System.Windows.Forms.Padding(6);
            this.grpUpdateDesk.Name = "grpUpdateDesk";
            this.grpUpdateDesk.Padding = new System.Windows.Forms.Padding(6);
            this.grpUpdateDesk.Size = new System.Drawing.Size(820, 276);
            this.grpUpdateDesk.TabIndex = 31;
            this.grpUpdateDesk.TabStop = false;
            this.grpUpdateDesk.Text = "Update Info";
            this.grpUpdateDesk.Visible = false;
            this.grpUpdateDesk.Enter += new System.EventHandler(this.grpUpdateDesk_Enter);
            // 
            // cboDeskType
            // 
            this.cboDeskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeskType.FormattingEnabled = true;
            this.cboDeskType.Items.AddRange(new object[] {
            "POD",
            "CWD",
            "CD"});
            this.cboDeskType.Location = new System.Drawing.Point(205, 69);
            this.cboDeskType.Name = "cboDeskType";
            this.cboDeskType.Size = new System.Drawing.Size(375, 45);
            this.cboDeskType.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(223, 209);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 55);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(205, 143);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(6);
            this.txtLocation.MaxLength = 20;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(375, 44);
            this.txtLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(12, 146);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(139, 37);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desk Type";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDeskID
            // 
            this.lblDeskID.AutoSize = true;
            this.lblDeskID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskID.Location = new System.Drawing.Point(256, 114);
            this.lblDeskID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskID.Name = "lblDeskID";
            this.lblDeskID.Size = new System.Drawing.Size(129, 37);
            this.lblDeskID.TabIndex = 34;
            this.lblDeskID.Text = "Desk ID";
            this.lblDeskID.Click += new System.EventHandler(this.lblSelectDeskType_Click);
            // 
            // lblUpdateDesk
            // 
            this.lblUpdateDesk.AutoSize = true;
            this.lblUpdateDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDesk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpdateDesk.Location = new System.Drawing.Point(364, 10);
            this.lblUpdateDesk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUpdateDesk.Name = "lblUpdateDesk";
            this.lblUpdateDesk.Size = new System.Drawing.Size(372, 67);
            this.lblUpdateDesk.TabIndex = 32;
            this.lblUpdateDesk.Text = "Update Desk";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(665, 111);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 44);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(433, 111);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.MaxLength = 3;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 44);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtDeskNum_TextChanged);
            // 
            // grdDesks
            // 
            this.grdDesks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesks.Location = new System.Drawing.Point(16, 189);
            this.grdDesks.Name = "grdDesks";
            this.grdDesks.RowHeadersWidth = 82;
            this.grdDesks.RowTemplate.Height = 33;
            this.grdDesks.Size = new System.Drawing.Size(1052, 303);
            this.grdDesks.TabIndex = 37;
            this.grdDesks.Visible = false;
            this.grdDesks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDesks_CellContentClick);
            // 
            // frmUpdateDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 792);
            this.Controls.Add(this.grdDesks);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDeskID);
            this.Controls.Add(this.lblUpdateDesk);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpUpdateDesk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateDesk";
            this.Text = "Update Info";
            this.Load += new System.EventHandler(this.UpdateDesk_Load);
            this.grpUpdateDesk.ResumeLayout(false);
            this.grpUpdateDesk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateDesk;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDeskID;
        private System.Windows.Forms.Label lblUpdateDesk;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboDeskType;
        private System.Windows.Forms.DataGridView grdDesks;
    }
}