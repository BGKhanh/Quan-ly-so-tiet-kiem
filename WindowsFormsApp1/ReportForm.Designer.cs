namespace BankManagement
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.DataGridView dgvSavingsReport;
        private System.Windows.Forms.ComboBox cbPeriodTypeSales;
        private System.Windows.Forms.ComboBox cbPeriodTypeSavings;
        private System.Windows.Forms.TextBox txtPeriodSales;
        private System.Windows.Forms.TextBox txtPeriodSavings;
        private System.Windows.Forms.Button btnGenerateSalesReport;
        private System.Windows.Forms.Button btnGenerateSavingsReport;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.dgvSavingsReport = new System.Windows.Forms.DataGridView();
            this.cbPeriodTypeSales = new System.Windows.Forms.ComboBox();
            this.cbPeriodTypeSavings = new System.Windows.Forms.ComboBox();
            this.txtPeriodSales = new System.Windows.Forms.TextBox();
            this.txtPeriodSavings = new System.Windows.Forms.TextBox();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.btnGenerateSavingsReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 80);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.Size = new System.Drawing.Size(760, 200);
            this.dgvSalesReport.TabIndex = 0;
            // 
            // dgvSavingsReport
            // 
            this.dgvSavingsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingsReport.Location = new System.Drawing.Point(12, 350);
            this.dgvSavingsReport.Name = "dgvSavingsReport";
            this.dgvSavingsReport.RowHeadersWidth = 51;
            this.dgvSavingsReport.Size = new System.Drawing.Size(760, 200);
            this.dgvSavingsReport.TabIndex = 1;
            // 
            // cbPeriodTypeSales
            // 
            this.cbPeriodTypeSales.FormattingEnabled = true;
            this.cbPeriodTypeSales.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbPeriodTypeSales.Location = new System.Drawing.Point(12, 20);
            this.cbPeriodTypeSales.Name = "cbPeriodTypeSales";
            this.cbPeriodTypeSales.Size = new System.Drawing.Size(121, 24);
            this.cbPeriodTypeSales.TabIndex = 2;
            this.cbPeriodTypeSales.SelectedIndexChanged += new System.EventHandler(this.cbPeriodTypeSales_SelectedIndexChanged);
            // 
            // cbPeriodTypeSavings
            // 
            this.cbPeriodTypeSavings.FormattingEnabled = true;
            this.cbPeriodTypeSavings.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbPeriodTypeSavings.Location = new System.Drawing.Point(12, 300);
            this.cbPeriodTypeSavings.Name = "cbPeriodTypeSavings";
            this.cbPeriodTypeSavings.Size = new System.Drawing.Size(121, 24);
            this.cbPeriodTypeSavings.TabIndex = 3;
            this.cbPeriodTypeSavings.SelectedIndexChanged += new System.EventHandler(this.cbPeriodTypeSavings_SelectedIndexChanged);
            // 
            // txtPeriodSales
            // 
            this.txtPeriodSales.Location = new System.Drawing.Point(150, 20);
            this.txtPeriodSales.Name = "txtPeriodSales";
            this.txtPeriodSales.Size = new System.Drawing.Size(200, 22);
            this.txtPeriodSales.TabIndex = 4;
            this.txtPeriodSales.GotFocus += new System.EventHandler(this.txtPeriodSales_GotFocus);
            this.txtPeriodSales.LostFocus += new System.EventHandler(this.txtPeriodSales_LostFocus);
            // 
            // txtPeriodSavings
            // 
            this.txtPeriodSavings.Location = new System.Drawing.Point(150, 300);
            this.txtPeriodSavings.Name = "txtPeriodSavings";
            this.txtPeriodSavings.Size = new System.Drawing.Size(200, 22);
            this.txtPeriodSavings.TabIndex = 5;
            this.txtPeriodSavings.GotFocus += new System.EventHandler(this.txtPeriodSavings_GotFocus);
            this.txtPeriodSavings.LostFocus += new System.EventHandler(this.txtPeriodSavings_LostFocus);
            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(370, 20);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateSalesReport.TabIndex = 6;
            this.btnGenerateSalesReport.Text = "Generate";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            this.btnGenerateSalesReport.Click += new System.EventHandler(this.btnGenerateSalesReport_Click);
            // 
            // btnGenerateSavingsReport
            // 
            this.btnGenerateSavingsReport.Location = new System.Drawing.Point(370, 300);
            this.btnGenerateSavingsReport.Name = "btnGenerateSavingsReport";
            this.btnGenerateSavingsReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateSavingsReport.TabIndex = 7;
            this.btnGenerateSavingsReport.Text = "Generate";
            this.btnGenerateSavingsReport.UseVisualStyleBackColor = true;
            this.btnGenerateSavingsReport.Click += new System.EventHandler(this.btnGenerateSavingsReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(672, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerateSavingsReport);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.txtPeriodSavings);
            this.Controls.Add(this.txtPeriodSales);
            this.Controls.Add(this.cbPeriodTypeSavings);
            this.Controls.Add(this.cbPeriodTypeSales);
            this.Controls.Add(this.dgvSavingsReport);
            this.Controls.Add(this.dgvSalesReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
