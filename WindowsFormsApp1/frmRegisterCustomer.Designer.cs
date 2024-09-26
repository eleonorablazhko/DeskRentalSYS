namespace WindowsFormsApp1
{
    partial class frmRegisterCustomer
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
            this.lblRegisterCustomer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDeskType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpRegCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.grpRegCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(24, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRegisterCustomer
            // 
            this.lblRegisterCustomer.AutoSize = true;
            this.lblRegisterCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegisterCustomer.Location = new System.Drawing.Point(537, 23);
            this.lblRegisterCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegisterCustomer.Name = "lblRegisterCustomer";
            this.lblRegisterCustomer.Size = new System.Drawing.Size(509, 67);
            this.lblRegisterCustomer.TabIndex = 2;
            this.lblRegisterCustomer.Text = "Register Customer";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(386, 424);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 75);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEmail.Location = new System.Drawing.Point(208, 295);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 37);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLName.Location = new System.Drawing.Point(208, 132);
            this.lblLName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(173, 37);
            this.lblLName.TabIndex = 19;
            this.lblLName.Text = "Last Name";
            // 
            // lblDeskType
            // 
            this.lblDeskType.AutoSize = true;
            this.lblDeskType.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDeskType.Location = new System.Drawing.Point(405, 56);
            this.lblDeskType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeskType.Name = "lblDeskType";
            this.lblDeskType.Size = new System.Drawing.Size(0, 44);
            this.lblDeskType.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 301);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(538, 219);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(296, 31);
            this.txtPhone.TabIndex = 16;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(538, 138);
            this.txtLName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(296, 31);
            this.txtLName.TabIndex = 15;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblFName.Location = new System.Drawing.Point(208, 63);
            this.lblFName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(175, 37);
            this.lblFName.TabIndex = 24;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(538, 56);
            this.txtFName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(296, 31);
            this.txtFName.TabIndex = 25;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPhone.Location = new System.Drawing.Point(206, 213);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 37);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "Phone";
            // 
            // grpRegCustomer
            // 
            this.grpRegCustomer.Controls.Add(this.lblPhone);
            this.grpRegCustomer.Controls.Add(this.txtFName);
            this.grpRegCustomer.Controls.Add(this.lblFName);
            this.grpRegCustomer.Controls.Add(this.btnSave);
            this.grpRegCustomer.Controls.Add(this.lblEmail);
            this.grpRegCustomer.Controls.Add(this.lblLName);
            this.grpRegCustomer.Controls.Add(this.lblDeskType);
            this.grpRegCustomer.Controls.Add(this.txtEmail);
            this.grpRegCustomer.Controls.Add(this.txtPhone);
            this.grpRegCustomer.Controls.Add(this.txtLName);
            this.grpRegCustomer.Location = new System.Drawing.Point(250, 299);
            this.grpRegCustomer.Name = "grpRegCustomer";
            this.grpRegCustomer.Size = new System.Drawing.Size(997, 508);
            this.grpRegCustomer.TabIndex = 36;
            this.grpRegCustomer.TabStop = false;
            this.grpRegCustomer.Text = "Enter Customer Data";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCustID.Location = new System.Drawing.Point(558, 195);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(196, 37);
            this.lblCustID.TabIndex = 38;
            this.lblCustID.Text = "Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(788, 201);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(210, 31);
            this.txtCustID.TabIndex = 37;
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 870);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.grpRegCustomer);
            this.Controls.Add(this.lblRegisterCustomer);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRegisterCustomer";
            this.Text = "frmRegisterCustomer";
            this.Load += new System.EventHandler(this.frmRegisterCustomer_Load);
            this.grpRegCustomer.ResumeLayout(false);
            this.grpRegCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRegisterCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblDeskType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpRegCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
    }
}