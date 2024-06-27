using System.Windows.Forms;

namespace BankManagement
{
    partial class TransactionHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private DataGridView dataGridView1;
        private DataGridView detailsDataGridView;
        private Panel detailsPanel;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cmbSearchField;

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
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(16, 15);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Trở về";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.detailsDataGridView);
            this.detailsPanel.Location = new System.Drawing.Point(16, 270);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1013, 250);
            this.detailsPanel.TabIndex = 2;
            this.detailsPanel.Visible = false;
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AllowUserToAddRows = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(4, 4);
            this.detailsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.RowHeadersWidth = 51;
            this.detailsDataGridView.Size = new System.Drawing.Size(1005, 242);
            this.detailsDataGridView.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(576, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(716, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchField
            // 
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.FormattingEnabled = true;
            this.cmbSearchField.Items.AddRange(new object[] {
            "MaGD",
            "LoaiGiaoDich",
            "MaKH",
            "MaSo",
            "MaNV"});
            this.cmbSearchField.Location = new System.Drawing.Point(431, 17);
            this.cmbSearchField.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(137, 24);
            this.cmbSearchField.TabIndex = 5;
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 535);
            this.Controls.Add(this.cmbSearchField);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackToMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionHistoryForm";
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
