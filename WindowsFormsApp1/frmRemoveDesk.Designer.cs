namespace WindowsFormsApp1
{
    partial class frmRemoveDesk
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
            this.lblRemoveDesk = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDeskID = new System.Windows.Forms.Label();
            this.grdDesks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemoveDesk
            // 
            this.lblRemoveDesk.AutoSize = true;
            this.lblRemoveDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveDesk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRemoveDesk.Location = new System.Drawing.Point(360, 10);
            this.lblRemoveDesk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemoveDesk.Name = "lblRemoveDesk";
            this.lblRemoveDesk.Size = new System.Drawing.Size(402, 67);
            this.lblRemoveDesk.TabIndex = 36;
            this.lblRemoveDesk.Text = "Remove Desk";
            this.lblRemoveDesk.Click += new System.EventHandler(this.lblUpdateDesk_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(434, 143);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.MaxLength = 3;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 44);
            this.txtSearch.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(666, 143);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 44);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDeskID
            // 
            this.lblDeskID.AutoSize = true;
            this.lblDeskID.BackColor = System.Drawing.Color.LightGray;
            this.lblDeskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskID.Location = new System.Drawing.Point(264, 147);
            this.lblDeskID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskID.Name = "lblDeskID";
            this.lblDeskID.Size = new System.Drawing.Size(129, 37);
            this.lblDeskID.TabIndex = 41;
            this.lblDeskID.Text = "Desk ID";
            // 
            // grdDesks
            // 
            this.grdDesks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesks.Location = new System.Drawing.Point(25, 229);
            this.grdDesks.Name = "grdDesks";
            this.grdDesks.RowHeadersWidth = 82;
            this.grdDesks.RowTemplate.Height = 33;
            this.grdDesks.Size = new System.Drawing.Size(1039, 384);
            this.grdDesks.TabIndex = 44;
            this.grdDesks.Visible = false;
            this.grdDesks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDesks_CellContentClick);
            // 
            // frmRemoveDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 701);
            this.Controls.Add(this.grdDesks);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDeskID);
            this.Controls.Add(this.lblRemoveDesk);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemoveDesk";
            this.Text = "frmRemoveDesk";
            this.Load += new System.EventHandler(this.frmRemoveDesk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDesks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemoveDesk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDeskID;
        private System.Windows.Forms.DataGridView grdDesks;
    }
}