namespace BankManagement
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbPeriodTypeSales;
        private System.Windows.Forms.ComboBox cbPeriodTypeSavings;
        private System.Windows.Forms.TextBox txtPeriodSales;
        private System.Windows.Forms.TextBox txtPeriodSavings;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblSavingsReport;
        private System.Windows.Forms.Button btnGenerateSalesReport;
        private System.Windows.Forms.Button btnGenerateSavingsReport;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.DataGridView dgvSavingsReport;
        private System.Windows.Forms.Button btnBack; // Added button "Back"

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
            this.cbPeriodTypeSales = new System.Windows.Forms.ComboBox();
            this.cbPeriodTypeSavings = new System.Windows.Forms.ComboBox();
            this.txtPeriodSales = new System.Windows.Forms.TextBox();
            this.txtPeriodSavings = new System.Windows.Forms.TextBox();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.lblSavingsReport = new System.Windows.Forms.Label();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.btnGenerateSavingsReport = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.dgvSavingsReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPeriodTypeSales
            // 
            this.cbPeriodTypeSales.FormattingEnabled = true;
            this.cbPeriodTypeSales.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbPeriodTypeSales.Location = new System.Drawing.Point(13, 30);
            this.cbPeriodTypeSales.Name = "cbPeriodTypeSales";
            this.cbPeriodTypeSales.Size = new System.Drawing.Size(121, 24);
            this.cbPeriodTypeSales.TabIndex = 0;
            // 
            // cbPeriodTypeSavings
            // 
            this.cbPeriodTypeSavings.FormattingEnabled = true;
            this.cbPeriodTypeSavings.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbPeriodTypeSavings.Location = new System.Drawing.Point(13, 327);
            this.cbPeriodTypeSavings.Name = "cbPeriodTypeSavings";
            this.cbPeriodTypeSavings.Size = new System.Drawing.Size(121, 24);
            this.cbPeriodTypeSavings.TabIndex = 1;
            // 
            // txtPeriodSales
            // 
            this.txtPeriodSales.Location = new System.Drawing.Point(141, 30);
            this.txtPeriodSales.Name = "txtPeriodSales";
            this.txtPeriodSales.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodSales.TabIndex = 2;
            this.txtPeriodSales.GotFocus += new System.EventHandler(this.txtPeriodSales_GotFocus);
            this.txtPeriodSales.LostFocus += new System.EventHandler(this.txtPeriodSales_LostFocus);
            // 
            // txtPeriodSavings
            // 
            this.txtPeriodSavings.Location = new System.Drawing.Point(141, 327);
            this.txtPeriodSavings.Name = "txtPeriodSavings";
            this.txtPeriodSavings.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodSavings.TabIndex = 3;
            this.txtPeriodSavings.GotFocus += new System.EventHandler(this.txtPeriodSavings_GotFocus);
            this.txtPeriodSavings.LostFocus += new System.EventHandler(this.txtPeriodSavings_LostFocus);
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Location = new System.Drawing.Point(13, 10);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(121, 16);
            this.lblSalesReport.TabIndex = 4;
            this.lblSalesReport.Text = "Báo cáo Doanh Số";
            // 
            // lblSavingsReport
            // 
            this.lblSavingsReport.AutoSize = true;
            this.lblSavingsReport.Location = new System.Drawing.Point(13, 308);
            this.lblSavingsReport.Name = "lblSavingsReport";
            this.lblSavingsReport.Size = new System.Drawing.Size(188, 16);
            this.lblSavingsReport.TabIndex = 5;
            this.lblSavingsReport.Text = "Báo cáo Đóng/Mở Sổ tiết kiệm";
            this.lblSavingsReport.Click += new System.EventHandler(this.lblSavingsReport_Click);
            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(250, 30);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateSalesReport.TabIndex = 6;
            this.btnGenerateSalesReport.Text = "Tạo Báo Cáo";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            this.btnGenerateSalesReport.Click += new System.EventHandler(this.btnGenerateSalesReport_Click);
            // 
            // btnGenerateSavingsReport
            // 
            this.btnGenerateSavingsReport.Location = new System.Drawing.Point(250, 326);
            this.btnGenerateSavingsReport.Name = "btnGenerateSavingsReport";
            this.btnGenerateSavingsReport.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateSavingsReport.TabIndex = 7;
            this.btnGenerateSavingsReport.Text = "Tạo Báo Cáo";
            this.btnGenerateSavingsReport.UseVisualStyleBackColor = true;
            this.btnGenerateSavingsReport.Click += new System.EventHandler(this.btnGenerateSavingsReport_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(13, 58);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.Size = new System.Drawing.Size(927, 245);
            this.dgvSalesReport.TabIndex = 8;
            // 
            // dgvSavingsReport
            // 
            this.dgvSavingsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingsReport.Location = new System.Drawing.Point(13, 357);
            this.dgvSavingsReport.Name = "dgvSavingsReport";
            this.dgvSavingsReport.RowHeadersWidth = 51;
            this.dgvSavingsReport.Size = new System.Drawing.Size(927, 242);
            this.dgvSavingsReport.TabIndex = 9;
            this.dgvSavingsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSavingsReport_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(845, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 22);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(952, 611);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvSavingsReport);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.btnGenerateSavingsReport);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.lblSavingsReport);
            this.Controls.Add(this.lblSalesReport);
            this.Controls.Add(this.txtPeriodSavings);
            this.Controls.Add(this.txtPeriodSales);
            this.Controls.Add(this.cbPeriodTypeSavings);
            this.Controls.Add(this.cbPeriodTypeSales);
            this.Name = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
