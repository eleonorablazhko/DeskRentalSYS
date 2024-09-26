namespace WindowsFormsApp1
{
    partial class frmCustomerPreferences
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtCustomerPreferences = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPreferences)).BeginInit();
            this.SuspendLayout();
            // 
            // chtCustomerPreferences
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCustomerPreferences.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCustomerPreferences.Legends.Add(legend1);
            this.chtCustomerPreferences.Location = new System.Drawing.Point(109, 213);
            this.chtCustomerPreferences.Name = "chtCustomerPreferences";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.chtCustomerPreferences.Series.Add(series1);
            this.chtCustomerPreferences.Size = new System.Drawing.Size(1084, 679);
            this.chtCustomerPreferences.TabIndex = 0;
            this.chtCustomerPreferences.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(6, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(455, 40);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(168, 40);
            this.txtYear.TabIndex = 9;
            this.txtYear.Text = "Select Year";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(644, 47);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(245, 33);
            this.cboYears.TabIndex = 8;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(455, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 40);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Select Month";
            // 
            // cboMonths
            // 
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(644, 118);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(245, 33);
            this.cboMonths.TabIndex = 10;
            this.cboMonths.SelectedIndexChanged += new System.EventHandler(this.cboMonths_SelectedIndexChanged);
            // 
            // frmCustomerPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 1041);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboMonths);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chtCustomerPreferences);
            this.Name = "frmCustomerPreferences";
            this.Text = "frmCustomerPreferences";
            this.Load += new System.EventHandler(this.frmCustomerPreferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPreferences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtCustomerPreferences;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboMonths;
    }
}