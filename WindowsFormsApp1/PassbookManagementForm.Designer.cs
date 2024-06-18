using System.Windows.Forms;

namespace BankManagement
{
    partial class PassbookManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private Button btnOpenNewAccount;
        private DataGridView dgvSavingAccounts;

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
            // dgvSavingAccounts
            // 
            this.dgvSavingAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingAccounts.Location = new System.Drawing.Point(16, 62);
            this.dgvSavingAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSavingAccounts.Name = "dgvSavingAccounts";
            this.dgvSavingAccounts.RowHeadersWidth = 51;
            this.dgvSavingAccounts.Size = new System.Drawing.Size(800, 369);
            this.dgvSavingAccounts.TabIndex = 2;
            this.dgvSavingAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSavingAccounts_CellContentClick);
            // 
            // PassbookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 444);
            this.Controls.Add(this.dgvSavingAccounts);
            this.Controls.Add(this.btnOpenNewAccount);
            this.Controls.Add(this.btnBackToMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassbookManagementForm";
            this.Text = "Quản lý sổ tiết kiệm";
            this.Load += new System.EventHandler(this.PassbookManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingAccounts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
