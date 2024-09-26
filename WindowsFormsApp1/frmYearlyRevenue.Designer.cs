namespace WindowsFormsApp1
{
    partial class frmYearlyRevenue
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
            this.btnBack = new System.Windows.Forms.Button();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chtData
            // 
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(84, 150);
            this.chtData.Name = "chtData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(965, 542);
            this.chtData.TabIndex = 5;
            this.chtData.Text = "Yearly Revenue";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(839, 44);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(245, 33);
            this.cboYears.TabIndex = 6;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(648, 44);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(168, 40);
            this.txtYear.TabIndex = 7;
            this.txtYear.Text = "Select Year";
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 724);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.chtData);
            this.Controls.Add(this.btnBack);
            this.Name = "frmYearlyRevenue";
            this.Text = "frmYearlyRevenue";
            this.Load += new System.EventHandler(this.frmYearlyRevenue_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.TextBox txtYear;
    }
}