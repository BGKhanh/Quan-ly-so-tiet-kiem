namespace BankManagement
{
    partial class RegulationForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvRegulations = new System.Windows.Forms.DataGridView();
            this.groupBoxTermDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveTerm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTerm = new System.Windows.Forms.Button();
            this.txtMinTerm = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtTermID = new System.Windows.Forms.TextBox();
            this.lblMinTerm = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblTermID = new System.Windows.Forms.Label();
            this.groupBoxGlobalSettings = new System.Windows.Forms.GroupBox();
            this.btnSaveGlobalSettings = new System.Windows.Forms.Button();
            this.btnEditGlobalSettings = new System.Windows.Forms.Button();
            this.txtMinWithdraw = new System.Windows.Forms.TextBox();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.txtMinDeposit = new System.Windows.Forms.TextBox();
            this.lblMinWithdraw = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.lblMinDeposit = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.groupBoxTermDetails.SuspendLayout();
            this.groupBoxGlobalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegulations
            // 
            this.dgvRegulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegulations.Location = new System.Drawing.Point(16, 15);
            this.dgvRegulations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegulations.Name = "dgvRegulations";
            this.dgvRegulations.RowHeadersWidth = 51;
            this.dgvRegulations.Size = new System.Drawing.Size(1035, 185);
            this.dgvRegulations.TabIndex = 0;
            this.dgvRegulations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegulations_CellClick);
            // 
            // groupBoxTermDetails
            // 
            this.groupBoxTermDetails.Controls.Add(this.btnSaveTerm);
            this.groupBoxTermDetails.Controls.Add(this.btnEdit);
            this.groupBoxTermDetails.Controls.Add(this.btnDelete);
            this.groupBoxTermDetails.Controls.Add(this.btnAddTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.txtTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtTermID);
            this.groupBoxTermDetails.Controls.Add(this.lblMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.lblInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.lblTerm);
            this.groupBoxTermDetails.Controls.Add(this.lblTermID);
            this.groupBoxTermDetails.Location = new System.Drawing.Point(16, 207);
            this.groupBoxTermDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTermDetails.Name = "groupBoxTermDetails";
            this.groupBoxTermDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTermDetails.Size = new System.Drawing.Size(501, 308);
            this.groupBoxTermDetails.TabIndex = 1;
            this.groupBoxTermDetails.TabStop = false;
            this.groupBoxTermDetails.Text = "Thông tin chi tiết kỳ hạn";
            this.groupBoxTermDetails.Enter += new System.EventHandler(this.groupBoxTermDetails_Enter);
            // 
            // btnSaveTerm
            // 
            this.btnSaveTerm.Location = new System.Drawing.Point(368, 260);
            this.btnSaveTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveTerm.Name = "btnSaveTerm";
            this.btnSaveTerm.Size = new System.Drawing.Size(100, 28);
            this.btnSaveTerm.TabIndex = 11;
            this.btnSaveTerm.Text = "Lưu";
            this.btnSaveTerm.UseVisualStyleBackColor = true;
            this.btnSaveTerm.Click += new System.EventHandler(this.btnSaveTerm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(261, 260);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 260);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Location = new System.Drawing.Point(45, 260);
            this.btnAddTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(100, 28);
            this.btnAddTerm.TabIndex = 8;
            this.btnAddTerm.Text = "Thêm";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            this.btnAddTerm.Click += new System.EventHandler(this.btnAddTerm_Click);
            // 
            // txtMinTerm
            // 
            this.txtMinTerm.Location = new System.Drawing.Point(175, 180);
            this.txtMinTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinTerm.Name = "txtMinTerm";
            this.txtMinTerm.Size = new System.Drawing.Size(293, 22);
            this.txtMinTerm.TabIndex = 7;
            this.txtMinTerm.TextChanged += new System.EventHandler(this.txtMinTerm_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(175, 133);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(293, 22);
            this.txtInterestRate.TabIndex = 6;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(175, 84);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(293, 22);
            this.txtTerm.TabIndex = 5;
            // 
            // txtTermID
            // 
            this.txtTermID.Location = new System.Drawing.Point(175, 34);
            this.txtTermID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTermID.Name = "txtTermID";
            this.txtTermID.Size = new System.Drawing.Size(293, 22);
            this.txtTermID.TabIndex = 4;
            // 
            // lblMinTerm
            // 
            this.lblMinTerm.AutoSize = true;
            this.lblMinTerm.Location = new System.Drawing.Point(41, 186);
            this.lblMinTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinTerm.Name = "lblMinTerm";
            this.lblMinTerm.Size = new System.Drawing.Size(135, 16);
            this.lblMinTerm.TabIndex = 3;
            this.lblMinTerm.Text = "Thời gian gửi tối thiểu:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(41, 137);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(56, 16);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Lãi suất:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(41, 87);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(50, 16);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Kỳ hạn:";
            // 
            // lblTermID
            // 
            this.lblTermID.AutoSize = true;
            this.lblTermID.Location = new System.Drawing.Point(41, 38);
            this.lblTermID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTermID.Name = "lblTermID";
            this.lblTermID.Size = new System.Drawing.Size(71, 16);
            this.lblTermID.TabIndex = 0;
            this.lblTermID.Text = "Mã kỳ hạn:";
            // 
            // groupBoxGlobalSettings
            // 
            this.groupBoxGlobalSettings.Controls.Add(this.btnSaveGlobalSettings);
            this.groupBoxGlobalSettings.Controls.Add(this.btnEditGlobalSettings);
            this.groupBoxGlobalSettings.Controls.Add(this.txtMinWithdraw);
            this.groupBoxGlobalSettings.Controls.Add(this.txtInitialDeposit);
            this.groupBoxGlobalSettings.Controls.Add(this.txtMinDeposit);
            this.groupBoxGlobalSettings.Controls.Add(this.lblMinWithdraw);
            this.groupBoxGlobalSettings.Controls.Add(this.lblInitialDeposit);
            this.groupBoxGlobalSettings.Controls.Add(this.lblMinDeposit);
            this.groupBoxGlobalSettings.Location = new System.Drawing.Point(549, 207);
            this.groupBoxGlobalSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGlobalSettings.Name = "groupBoxGlobalSettings";
            this.groupBoxGlobalSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGlobalSettings.Size = new System.Drawing.Size(501, 308);
            this.groupBoxGlobalSettings.TabIndex = 2;
            this.groupBoxGlobalSettings.TabStop = false;
            this.groupBoxGlobalSettings.Text = "Thiết lập chung";
            // 
            // btnSaveGlobalSettings
            // 
            this.btnSaveGlobalSettings.Location = new System.Drawing.Point(303, 260);
            this.btnSaveGlobalSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveGlobalSettings.Name = "btnSaveGlobalSettings";
            this.btnSaveGlobalSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSaveGlobalSettings.TabIndex = 7;
            this.btnSaveGlobalSettings.Text = "Lưu";
            this.btnSaveGlobalSettings.UseVisualStyleBackColor = true;
            this.btnSaveGlobalSettings.Click += new System.EventHandler(this.btnSaveGlobalSettings_Click);
            // 
            // btnEditGlobalSettings
            // 
            this.btnEditGlobalSettings.Location = new System.Drawing.Point(195, 260);
            this.btnEditGlobalSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditGlobalSettings.Name = "btnEditGlobalSettings";
            this.btnEditGlobalSettings.Size = new System.Drawing.Size(100, 28);
            this.btnEditGlobalSettings.TabIndex = 6;
            this.btnEditGlobalSettings.Text = "Chỉnh sửa";
            this.btnEditGlobalSettings.UseVisualStyleBackColor = true;
            this.btnEditGlobalSettings.Click += new System.EventHandler(this.btnEditGlobalSettings_Click);
            // 
            // txtMinWithdraw
            // 
            this.txtMinWithdraw.Location = new System.Drawing.Point(169, 182);
            this.txtMinWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinWithdraw.Name = "txtMinWithdraw";
            this.txtMinWithdraw.Size = new System.Drawing.Size(315, 22);
            this.txtMinWithdraw.TabIndex = 5;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(169, 133);
            this.txtInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(315, 22);
            this.txtInitialDeposit.TabIndex = 4;
            // 
            // txtMinDeposit
            // 
            this.txtMinDeposit.Location = new System.Drawing.Point(169, 84);
            this.txtMinDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinDeposit.Name = "txtMinDeposit";
            this.txtMinDeposit.Size = new System.Drawing.Size(315, 22);
            this.txtMinDeposit.TabIndex = 3;
            // 
            // lblMinWithdraw
            // 
            this.lblMinWithdraw.AutoSize = true;
            this.lblMinWithdraw.Location = new System.Drawing.Point(41, 186);
            this.lblMinWithdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinWithdraw.Name = "lblMinWithdraw";
            this.lblMinWithdraw.Size = new System.Drawing.Size(78, 16);
            this.lblMinWithdraw.TabIndex = 2;
            this.lblMinWithdraw.Text = "Rút tối thiểu:";
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(41, 137);
            this.lblInitialDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(82, 16);
            this.lblInitialDeposit.TabIndex = 1;
            this.lblInitialDeposit.Text = "Gửi ban đầu:";
            // 
            // lblMinDeposit
            // 
            this.lblMinDeposit.AutoSize = true;
            this.lblMinDeposit.Location = new System.Drawing.Point(41, 87);
            this.lblMinDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinDeposit.Name = "lblMinDeposit";
            this.lblMinDeposit.Size = new System.Drawing.Size(78, 16);
            this.lblMinDeposit.TabIndex = 0;
            this.lblMinDeposit.Text = "Gửi tối thiểu:";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(951, 522);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMain.TabIndex = 3;
            this.btnBackToMain.Text = "Quay lại";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // RegulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.groupBoxGlobalSettings);
            this.Controls.Add(this.groupBoxTermDetails);
            this.Controls.Add(this.dgvRegulations);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegulationForm";
            this.Text = "Quản lý quy định";
            this.Load += new System.EventHandler(this.RegulationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.groupBoxTermDetails.ResumeLayout(false);
            this.groupBoxTermDetails.PerformLayout();
            this.groupBoxGlobalSettings.ResumeLayout(false);
            this.groupBoxGlobalSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvRegulations;
        private System.Windows.Forms.GroupBox groupBoxTermDetails;
        private System.Windows.Forms.Label lblMinTerm;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblTermID;
        private System.Windows.Forms.TextBox txtMinTerm;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtTermID;
        private System.Windows.Forms.Button btnSaveTerm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTerm;
        private System.Windows.Forms.GroupBox groupBoxGlobalSettings;
        private System.Windows.Forms.Button btnSaveGlobalSettings;
        private System.Windows.Forms.Button btnEditGlobalSettings;
        private System.Windows.Forms.TextBox txtMinWithdraw;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.TextBox txtMinDeposit;
        private System.Windows.Forms.Label lblMinWithdraw;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label lblMinDeposit;
        private System.Windows.Forms.Button btnBackToMain;
    }
}
