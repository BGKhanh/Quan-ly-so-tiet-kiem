using System.ComponentModel;
using System.Windows.Forms;

namespace BankManagement
{
    partial class RegulationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private Button btnAddTerm;
        private DataGridView dgvRegulations;
        private GroupBox groupBoxTermDetails;
        private Label lblTerm;
        private Label lblInterestRate;
        private Label lblMinTerm;
        private Label lblTermID;
        private TextBox txtTerm;
        private TextBox txtInterestRate;
        private TextBox txtMinTerm;
        private TextBox txtTermID;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblMinDeposit;
        private TextBox txtMinDeposit;
        private Label lblInitialDeposit;
        private TextBox txtInitialDeposit;
        private Button btnSave;

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
            this.btnAddTerm = new System.Windows.Forms.Button();
            this.dgvRegulations = new System.Windows.Forms.DataGridView();
            this.groupBoxTermDetails = new System.Windows.Forms.GroupBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMinTerm = new System.Windows.Forms.Label();
            this.lblTermID = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMinTerm = new System.Windows.Forms.TextBox();
            this.txtTermID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMinDeposit = new System.Windows.Forms.Label();
            this.txtMinDeposit = new System.Windows.Forms.TextBox();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.groupBoxTermDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(75, 23);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Trở về";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Location = new System.Drawing.Point(87, 22);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(99, 23);
            this.btnAddTerm.TabIndex = 1;
            this.btnAddTerm.Text = "Thêm Kỳ Hạn";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            this.btnAddTerm.Click += new System.EventHandler(this.btnAddTerm_Click);
            // 
            // dgvRegulations
            // 
            this.dgvRegulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegulations.Location = new System.Drawing.Point(12, 41);
            this.dgvRegulations.Name = "dgvRegulations";
            this.dgvRegulations.RowHeadersWidth = 51;
            this.dgvRegulations.Size = new System.Drawing.Size(688, 150);
            this.dgvRegulations.TabIndex = 2;
            this.dgvRegulations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegulations_CellClick);
            // 
            // groupBoxTermDetails
            // 
            this.groupBoxTermDetails.Controls.Add(this.lblTerm);
            this.groupBoxTermDetails.Controls.Add(this.lblInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.lblMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.lblTermID);
            this.groupBoxTermDetails.Controls.Add(this.txtTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.txtMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.btnAddTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtTermID);
            this.groupBoxTermDetails.Controls.Add(this.btnEdit);
            this.groupBoxTermDetails.Controls.Add(this.btnDelete);
            this.groupBoxTermDetails.Location = new System.Drawing.Point(12, 197);
            this.groupBoxTermDetails.Name = "groupBoxTermDetails";
            this.groupBoxTermDetails.Size = new System.Drawing.Size(371, 212);
            this.groupBoxTermDetails.TabIndex = 3;
            this.groupBoxTermDetails.TabStop = false;
            this.groupBoxTermDetails.Text = "Thông tin chi tiết Kỳ Hạn";
            this.groupBoxTermDetails.Enter += new System.EventHandler(this.groupBoxTermDetails_Enter);
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(6, 59);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(75, 16);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Mã Kỳ Hạn:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(6, 96);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(58, 16);
            this.lblInterestRate.TabIndex = 1;
            this.lblInterestRate.Text = "Lãi Suất:";
            // 
            // lblMinTerm
            // 
            this.lblMinTerm.AutoSize = true;
            this.lblMinTerm.Location = new System.Drawing.Point(6, 140);
            this.lblMinTerm.Name = "lblMinTerm";
            this.lblMinTerm.Size = new System.Drawing.Size(151, 16);
            this.lblMinTerm.TabIndex = 2;
            this.lblMinTerm.Text = "Thời Gian Gửi Tối Thiểu:";
            // 
            // lblTermID
            // 
            this.lblTermID.AutoSize = true;
            this.lblTermID.Location = new System.Drawing.Point(6, 177);
            this.lblTermID.Name = "lblTermID";
            this.lblTermID.Size = new System.Drawing.Size(75, 16);
            this.lblTermID.TabIndex = 3;
            this.lblTermID.Text = "Mã Kỳ Hạn:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(178, 59);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(177, 22);
            this.txtTerm.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(178, 96);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(177, 22);
            this.txtInterestRate.TabIndex = 5;
            // 
            // txtMinTerm
            // 
            this.txtMinTerm.Location = new System.Drawing.Point(178, 140);
            this.txtMinTerm.Name = "txtMinTerm";
            this.txtMinTerm.Size = new System.Drawing.Size(177, 22);
            this.txtMinTerm.TabIndex = 6;
            this.txtMinTerm.TextChanged += new System.EventHandler(this.txtMinTerm_TextChanged);
            // 
            // txtTermID
            // 
            this.txtTermID.Location = new System.Drawing.Point(178, 177);
            this.txtTermID.Name = "txtTermID";
            this.txtTermID.Size = new System.Drawing.Size(177, 22);
            this.txtTermID.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMinDeposit
            // 
            this.lblMinDeposit.AutoSize = true;
            this.lblMinDeposit.Location = new System.Drawing.Point(406, 293);
            this.lblMinDeposit.Name = "lblMinDeposit";
            this.lblMinDeposit.Size = new System.Drawing.Size(202, 16);
            this.lblMinDeposit.TabIndex = 4;
            this.lblMinDeposit.Text = "Số Tiền Gửi Giao Dịch Tối Thiểu:";
            // 
            // txtMinDeposit
            // 
            this.txtMinDeposit.Location = new System.Drawing.Point(531, 331);
            this.txtMinDeposit.Name = "txtMinDeposit";
            this.txtMinDeposit.Size = new System.Drawing.Size(169, 22);
            this.txtMinDeposit.TabIndex = 5;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(406, 218);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(159, 16);
            this.lblInitialDeposit.TabIndex = 6;
            this.lblInitialDeposit.Text = "Số Tiền Mở Sổ Tối Thiểu:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(531, 250);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(169, 22);
            this.txtInitialDeposit.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RegulationForm
            // 
            this.ClientSize = new System.Drawing.Size(713, 420);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.txtMinDeposit);
            this.Controls.Add(this.lblMinDeposit);
            this.Controls.Add(this.groupBoxTermDetails);
            this.Controls.Add(this.dgvRegulations);
            this.Controls.Add(this.btnBackToMain);
            this.Name = "RegulationForm";
            this.Text = "Quy Định Ngân Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.groupBoxTermDetails.ResumeLayout(false);
            this.groupBoxTermDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
