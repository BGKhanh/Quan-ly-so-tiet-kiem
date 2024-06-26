namespace BankManagement
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBM51;
        private System.Windows.Forms.DataGridView dgvBM52;
        private System.Windows.Forms.DateTimePicker dateTimePickerBM51;
        private System.Windows.Forms.DateTimePicker dateTimePickerBM52;
        private System.Windows.Forms.ComboBox cbLoaiTietKiemBM52;
        private System.Windows.Forms.Button btnGenerateBM51;
        private System.Windows.Forms.Button btnGenerateBM52;

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
            this.dgvBM51 = new System.Windows.Forms.DataGridView();
            this.dgvBM52 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerBM51 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBM52 = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiTietKiemBM52 = new System.Windows.Forms.ComboBox();
            this.btnGenerateBM51 = new System.Windows.Forms.Button();
            this.btnGenerateBM52 = new System.Windows.Forms.Button();

            // DGV BM5.1
            this.dgvBM51.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBM51.Location = new System.Drawing.Point(12, 50);
            this.dgvBM51.Name = "dgvBM51";
            this.dgvBM51.Size = new System.Drawing.Size(760, 200);
            this.dgvBM51.TabIndex = 0;

            // DGV BM5.2
            this.dgvBM52.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBM52.Location = new System.Drawing.Point(12, 300);
            this.dgvBM52.Name = "dgvBM52";
            this.dgvBM52.Size = new System.Drawing.Size(760, 200);
            this.dgvBM52.TabIndex = 1;

            // DateTimePicker BM5.1
            this.dateTimePickerBM51.Location = new System.Drawing.Point(12, 20);
            this.dateTimePickerBM51.Name = "dateTimePickerBM51";
            this.dateTimePickerBM51.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBM51.TabIndex = 2;

            // DateTimePicker BM5.2
            this.dateTimePickerBM52.Location = new System.Drawing.Point(12, 270);
            this.dateTimePickerBM52.Name = "dateTimePickerBM52";
            this.dateTimePickerBM52.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBM52.TabIndex = 3;

            // ComboBox Loai Tiet Kiem BM5.2
            this.cbLoaiTietKiemBM52.FormattingEnabled = true;
            this.cbLoaiTietKiemBM52.Items.AddRange(new object[] {
            "Loại 1",
            "Loại 2",
            "Loại 3"});
            this.cbLoaiTietKiemBM52.Location = new System.Drawing.Point(250, 270);
            this.cbLoaiTietKiemBM52.Name = "cbLoaiTietKiemBM52";
            this.cbLoaiTietKiemBM52.Size = new System.Drawing.Size(200, 24);
            this.cbLoaiTietKiemBM52.TabIndex = 4;

            // Button Generate BM5.1
            this.btnGenerateBM51.Location = new System.Drawing.Point(250, 20);
            this.btnGenerateBM51.Name = "btnGenerateBM51";
            this.btnGenerateBM51.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateBM51.TabIndex = 5;
            this.btnGenerateBM51.Text = "Generate BM5.1";
            this.btnGenerateBM51.UseVisualStyleBackColor = true;
            this.btnGenerateBM51.Click += new System.EventHandler(this.btnGenerateBM51_Click);

            // Button Generate BM5.2
            this.btnGenerateBM52.Location = new System.Drawing.Point(500, 270);
            this.btnGenerateBM52.Name = "btnGenerateBM52";
            this.btnGenerateBM52.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateBM52.TabIndex = 6;
            this.btnGenerateBM52.Text = "Generate BM5.2";
            this.btnGenerateBM52.UseVisualStyleBackColor = true;
            this.btnGenerateBM52.Click += new System.EventHandler(this.btnGenerateBM52_Click);

            // ReportForm
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGenerateBM52);
            this.Controls.Add(this.btnGenerateBM51);
            this.Controls.Add(this.cbLoaiTietKiemBM52);
            this.Controls.Add(this.dateTimePickerBM52);
            this.Controls.Add(this.dateTimePickerBM51);
            this.Controls.Add(this.dgvBM52);
            this.Controls.Add(this.dgvBM51);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBM51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBM52)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
