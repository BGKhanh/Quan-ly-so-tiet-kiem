using System.Windows.Forms;
using System.ComponentModel;

namespace BankManagement
{
    partial class CustomerManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private DataGridView dataGridView1;
        private Panel detailsPanel;
        private DataGridView detailsDataGridView;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddCustomer;
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.SuspendLayout();

            // btnBackToMain
            this.btnBackToMain.Location = new System.Drawing.Point(16, 15);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Trở về";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 369);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // detailsPanel
            this.detailsPanel.Controls.Add(this.detailsDataGridView);
            this.detailsPanel.Controls.Add(this.btnEdit);
            this.detailsPanel.Controls.Add(this.btnDelete);
            this.detailsPanel.Location = new System.Drawing.Point(16, 438);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1013, 123);
            this.detailsPanel.TabIndex = 2;
            this.detailsPanel.Visible = false;

            // detailsDataGridView
            this.detailsDataGridView.AllowUserToAddRows = false;
            this.detailsDataGridView.AllowUserToDeleteRows = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(4, 12);
            this.detailsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.RowHeadersWidth = 51;
            this.detailsDataGridView.Size = new System.Drawing.Size(897, 105);
            this.detailsDataGridView.TabIndex = 3;

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(909, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(909, 48);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(520, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 22);
            this.txtSearch.TabIndex = 3;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(784, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnAddCustomer
            this.btnAddCustomer.Location = new System.Drawing.Point(929, 13);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Đăng ký";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);

            // cmbSearchField
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.FormattingEnabled = true;
            this.cmbSearchField.Items.AddRange(new object[] {
                "MaKH",
                "TenKH",
                "CMND/CCCD",
                "SDT",
                "GioiTinh",
                "DiaChi"
            });
            this.cmbSearchField.Location = new System.Drawing.Point(320, 15);
            this.cmbSearchField.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(192, 24);
            this.cmbSearchField.TabIndex = 6;

            // CustomerManagementForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.cmbSearchField);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackToMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerManagementForm";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.CustomerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
