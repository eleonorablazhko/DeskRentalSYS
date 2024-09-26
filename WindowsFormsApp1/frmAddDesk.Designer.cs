namespace WindowsFormsApp1
{
    partial class frmAddDesk
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddDesk = new System.Windows.Forms.Label();
            this.txtDesk_ID = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDeskType = new System.Windows.Forms.Label();
            this.lblDeskNumber = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboDeskType = new System.Windows.Forms.ComboBox();
            this.grpAddDesk = new System.Windows.Forms.GroupBox();
            this.grpAddDesk.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(22, 29);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddDesk
            // 
            this.lblAddDesk.AutoSize = true;
            this.lblAddDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblAddDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddDesk.Location = new System.Drawing.Point(480, 29);
            this.lblAddDesk.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddDesk.Name = "lblAddDesk";
            this.lblAddDesk.Size = new System.Drawing.Size(286, 67);
            this.lblAddDesk.TabIndex = 1;
            this.lblAddDesk.Text = "Add Desk";
            this.lblAddDesk.Click += new System.EventHandler(this.lblAddDesk_Click);
            // 
            // txtDesk_ID
            // 
            this.txtDesk_ID.Location = new System.Drawing.Point(611, 147);
            this.txtDesk_ID.Margin = new System.Windows.Forms.Padding(6);
            this.txtDesk_ID.Name = "txtDesk_ID";
            this.txtDesk_ID.Size = new System.Drawing.Size(210, 31);
            this.txtDesk_ID.TabIndex = 3;
            this.txtDesk_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(434, 181);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(6);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(436, 31);
            this.txtLocation.TabIndex = 5;
            // 
            // lblDeskType
            // 
            this.lblDeskType.AutoSize = true;
            this.lblDeskType.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskType.Location = new System.Drawing.Point(129, 85);
            this.lblDeskType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskType.Name = "lblDeskType";
            this.lblDeskType.Size = new System.Drawing.Size(168, 37);
            this.lblDeskType.TabIndex = 9;
            this.lblDeskType.Text = "Desk Type";
            this.lblDeskType.Click += new System.EventHandler(this.lblDeskType_Click);
            // 
            // lblDeskNumber
            // 
            this.lblDeskNumber.AutoSize = true;
            this.lblDeskNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskNumber.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskNumber.Location = new System.Drawing.Point(365, 141);
            this.lblDeskNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskNumber.Name = "lblDeskNumber";
            this.lblDeskNumber.Size = new System.Drawing.Size(213, 37);
            this.lblDeskNumber.TabIndex = 10;
            this.lblDeskNumber.Text = "Desk Number";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblRate.Location = new System.Drawing.Point(129, 164);
            this.lblRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(0, 37);
            this.lblRate.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLocation.Location = new System.Drawing.Point(129, 175);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(139, 37);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(372, 326);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 74);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Add Desk";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboDeskType
            // 
            this.cboDeskType.FormattingEnabled = true;
            this.cboDeskType.Location = new System.Drawing.Point(434, 85);
            this.cboDeskType.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeskType.Name = "cboDeskType";
            this.cboDeskType.Size = new System.Drawing.Size(436, 33);
            this.cboDeskType.TabIndex = 14;
            this.cboDeskType.SelectedIndexChanged += new System.EventHandler(this.cboDeskType_SelectedIndexChanged);
            // 
            // grpAddDesk
            // 
            this.grpAddDesk.Controls.Add(this.cboDeskType);
            this.grpAddDesk.Controls.Add(this.btnSave);
            this.grpAddDesk.Controls.Add(this.lblLocation);
            this.grpAddDesk.Controls.Add(this.lblRate);
            this.grpAddDesk.Controls.Add(this.lblDeskType);
            this.grpAddDesk.Controls.Add(this.txtLocation);
            this.grpAddDesk.Location = new System.Drawing.Point(58, 206);
            this.grpAddDesk.Name = "grpAddDesk";
            this.grpAddDesk.Size = new System.Drawing.Size(1023, 436);
            this.grpAddDesk.TabIndex = 15;
            this.grpAddDesk.TabStop = false;
            this.grpAddDesk.Text = "Enter Desk Info";
            // 
            // frmAddDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1140, 679);
            this.Controls.Add(this.grpAddDesk);
            this.Controls.Add(this.lblDeskNumber);
            this.Controls.Add(this.txtDesk_ID);
            this.Controls.Add(this.lblAddDesk);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddDesk";
            this.Text = "frmAddDesk";
            this.Load += new System.EventHandler(this.frmAddDesk_Load);
            this.grpAddDesk.ResumeLayout(false);
            this.grpAddDesk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddDesk;
        private System.Windows.Forms.TextBox txtDesk_ID;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDeskType;
        private System.Windows.Forms.Label lblDeskNumber;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboDeskType;
        private System.Windows.Forms.GroupBox grpAddDesk;
    }
}