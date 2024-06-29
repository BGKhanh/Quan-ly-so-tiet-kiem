namespace BankManagement
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.ComboBox cbPeriodTypeSales;
        private System.Windows.Forms.TextBox txtPeriodSales;
        private System.Windows.Forms.Button btnGenerateSalesReport;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Label lblSavingsReport;
        private System.Windows.Forms.ComboBox cbPeriodTypeSavings;
        private System.Windows.Forms.TextBox txtPeriodSavings;
        private System.Windows.Forms.Button btnGenerateSavingsReport;
        private System.Windows.Forms.DataGridView dgvSavingsReport;

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
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.cbPeriodTypeSales = new System.Windows.Forms.ComboBox();
            this.txtPeriodSales = new System.Windows.Forms.TextBox();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.lblSavingsReport = new System.Windows.Forms.Label();
            this.cbPeriodTypeSavings = new System.Windows.Forms.ComboBox();
            this.txtPeriodSavings = new System.Windows.Forms.TextBox();
            this.btnGenerateSavingsReport = new System.Windows.Forms.Button();
            this.dgvSavingsReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsReport)).BeginInit();
            this.SuspendLayout();

            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Location = new System.Drawing.Point(13, 13);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(159, 13);
            this.lblSalesReport.TabIndex = 0;
            this.lblSalesReport.Text = "Báo cáo Doanh Số Hoạt Động";

            // 
            // cbPeriodTypeSales
            // 
            this.cbPeriodTypeSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodTypeSales.FormattingEnabled = true;
            this.cbPeriodTypeSales.Items.AddRange(new object[] { "Ngày", "Tháng", "Quý", "Năm" });
            this.cbPeriodTypeSales.Location = new System.Drawing.Point(16, 30);
            this.cbPeriodTypeSales.Name = "cbPeriodTypeSales";
            this.cbPeriodTypeSales.Size = new System.Drawing.Size(121, 21);
            this.cbPeriodTypeSales.TabIndex = 1;

            // 
            // txtPeriodSales
            // 
            this.txtPeriodSales.Location = new System.Drawing.Point(144, 30);
            this.txtPeriodSales.Name = "txtPeriodSales";
            this.txtPeriodSales.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodSales.TabIndex = 2;

            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(250, 28);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSalesReport.TabIndex = 3;
            this.btnGenerateSalesReport.Text = "Generate";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            this.btnGenerateSalesReport.Click += new System.EventHandler(this.btnGenerateSalesReport_Click);

            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(16, 60);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(600, 200);
            this.dgvSalesReport.TabIndex = 4;

            // 
            // lblSavingsReport
            // 
            this.lblSavingsReport.AutoSize = true;
            this.lblSavingsReport.Location = new System.Drawing.Point(13, 270);
            this.lblSavingsReport.Name = "lblSavingsReport";
            this.lblSavingsReport.Size = new System.Drawing.Size(132, 13);
            this.lblSavingsReport.TabIndex = 5;
            this.lblSavingsReport.Text = "Báo cáo Mở/Đóng Sổ";

            // 
            // cbPeriodTypeSavings
            // 
            this.cbPeriodTypeSavings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodTypeSavings.FormattingEnabled = true;
            this.cbPeriodTypeSavings.Items.AddRange(new object[] { "Ngày", "Tháng", "Quý", "Năm" });
            this.cbPeriodTypeSavings.Location = new System.Drawing.Point(16, 287);
            this.cbPeriodTypeSavings.Name = "cbPeriodTypeSavings";
            this.cbPeriodTypeSavings.Size = new System.Drawing.Size(121, 21);
            this.cbPeriodTypeSavings.TabIndex = 6;

            // 
            // txtPeriodSavings
            // 
            this.txtPeriodSavings.Location = new System.Drawing.Point(144, 287);
            this.txtPeriodSavings.Name = "txtPeriodSavings";
            this.txtPeriodSavings.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodSavings.TabIndex = 7;

            // 
            // btnGenerateSavingsReport
            // 
            this.btnGenerateSavingsReport.Location = new System.Drawing.Point(250, 285);
            this.btnGenerateSavingsReport.Name = "btnGenerateSavingsReport";
            this.btnGenerateSavingsReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSavingsReport.TabIndex = 8;
            this.btnGenerateSavingsReport.Text = "Generate";
            this.btnGenerateSavingsReport.UseVisualStyleBackColor = true;
            this.btnGenerateSavingsReport.Click += new System.EventHandler(this.btnGenerateSavingsReport_Click);

            // 
            // dgvSavingsReport
            // 
            this.dgvSavingsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingsReport.Location = new System.Drawing.Point(16, 316);
            this.dgvSavingsReport.Name = "dgvSavingsReport";
            this.dgvSavingsReport.Size = new System.Drawing.Size(600, 200);
            this.dgvSavingsReport.TabIndex = 9;

            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSavingsReport);
            this.Controls.Add(this.btnGenerateSavingsReport);
            this.Controls.Add(this.txtPeriodSavings);
            this.Controls.Add(this.cbPeriodTypeSavings);
            this.Controls.Add(this.lblSavingsReport);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.txtPeriodSales);
            this.Controls.Add(this.cbPeriodTypeSales);
            this.Controls.Add(this.lblSalesReport);
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
