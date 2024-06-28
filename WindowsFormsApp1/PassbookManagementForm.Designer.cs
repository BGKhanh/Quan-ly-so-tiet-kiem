using System.Windows.Forms;

namespace BankManagement
{
    partial class PassbookManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private Button btnOpenNewAccount;
        private Button btnDeleteAccount;
        private Button btnSearch;
        private DataGridView dgvSavingAccounts;
        private TextBox txtSearch;
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
            this.btnOpenNewAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();
            this.dgvSavingAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingAccounts)).BeginInit();
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
            // btnOpenNewAccount
            // 
            this.btnOpenNewAccount.Location = new System.Drawing.Point(124, 15);
            this.btnOpenNewAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenNewAccount.Name = "btnOpenNewAccount";
            this.btnOpenNewAccount.Size = new System.Drawing.Size(133, 28);
            this.btnOpenNewAccount.TabIndex = 1;
            this.btnOpenNewAccount.Text = "Mở sổ mới";
            this.btnOpenNewAccount.UseVisualStyleBackColor = true;
            this.btnOpenNewAccount.Click += new System.EventHandler(this.btnOpenNewAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(265, 15);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(133, 28);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(786, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(554, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // cmbSearchField
            // 
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.FormattingEnabled = true;
            this.cmbSearchField.Items.AddRange(new object[] {
            "Mã Sổ",
            "Tên Khách Hàng",
            "CMND/CCCD",
            "Địa Chỉ"});
            this.cmbSearchField.Location = new System.Drawing.Point(406, 16);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(142, 24);
            this.cmbSearchField.TabIndex = 6;
            // 
            // dgvSavingAccounts
            // 
            this.dgvSavingAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingAccounts.Location = new System.Drawing.Point(16, 62);
            this.dgvSavingAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSavingAccounts.Name = "dgvSavingAccounts";
            this.dgvSavingAccounts.RowHeadersWidth = 51;
            this.dgvSavingAccounts.Size = new System.Drawing.Size(870, 383);
            this.dgvSavingAccounts.TabIndex = 5;
            // 
            // PassbookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 458);
            this.Controls.Add(this.cmbSearchField);
            this.Controls.Add(this.dgvSavingAccounts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnOpenNewAccount);
            this.Controls.Add(this.btnBackToMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassbookManagementForm";
            this.Text = "Quản lý sổ tiết kiệm";
            this.Load += new System.EventHandler(this.PassbookManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
