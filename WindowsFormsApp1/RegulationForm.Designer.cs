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
        private TextBox txtTerm;
        private TextBox txtInterestRate;
        private TextBox txtMinTerm;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblMinDeposit;
        private TextBox txtMinDeposit;
        private Label lblInitialDeposit;
        private TextBox txtInitialDeposit;
        private Button btnSave;
        private Button btnCancel;

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
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMinTerm = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMinDeposit = new System.Windows.Forms.Label();
            this.txtMinDeposit = new System.Windows.Forms.TextBox();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.groupBoxTermDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Trở về";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Location = new System.Drawing.Point(118, 12);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(100, 28);
            this.btnAddTerm.TabIndex = 1;
            this.btnAddTerm.Text = "Thêm kỳ hạn";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            this.btnAddTerm.Click += new System.EventHandler(this.btnAddTerm_Click);
            // 
            // dgvRegulations
            // 
            this.dgvRegulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegulations.Location = new System.Drawing.Point(12, 46);
            this.dgvRegulations.Name = "dgvRegulations";
            this.dgvRegulations.RowHeadersWidth = 51;
            this.dgvRegulations.Size = new System.Drawing.Size(776, 219);
            this.dgvRegulations.TabIndex = 2;
            this.dgvRegulations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegulations_CellClick);
            // 
            // groupBoxTermDetails
            // 
            this.groupBoxTermDetails.Controls.Add(this.lblTerm);
            this.groupBoxTermDetails.Controls.Add(this.lblInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.lblMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtTerm);
            this.groupBoxTermDetails.Controls.Add(this.txtInterestRate);
            this.groupBoxTermDetails.Controls.Add(this.txtMinTerm);
            this.groupBoxTermDetails.Controls.Add(this.btnEdit);
            this.groupBoxTermDetails.Controls.Add(this.btnDelete);
            this.groupBoxTermDetails.Location = new System.Drawing.Point(12, 274);
            this.groupBoxTermDetails.Name = "groupBoxTermDetails";
            this.groupBoxTermDetails.Size = new System.Drawing.Size(427, 184);
            this.groupBoxTermDetails.TabIndex = 3;
            this.groupBoxTermDetails.TabStop = false;
            this.groupBoxTermDetails.Text = "Thông tin chi tiết kỳ hạn";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(6, 69);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(50, 16);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Kỳ hạn:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(6, 105);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(56, 16);
            this.lblInterestRate.TabIndex = 1;
            this.lblInterestRate.Text = "Lãi suất:";
            // 
            // lblMinTerm
            // 
            this.lblMinTerm.AutoSize = true;
            this.lblMinTerm.Location = new System.Drawing.Point(6, 142);
            this.lblMinTerm.Name = "lblMinTerm";
            this.lblMinTerm.Size = new System.Drawing.Size(135, 16);
            this.lblMinTerm.TabIndex = 6;
            this.lblMinTerm.Text = "Thời gian gửi tối thiểu:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(147, 69);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(265, 22);
            this.txtTerm.TabIndex = 2;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(147, 105);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(265, 22);
            this.txtInterestRate.TabIndex = 3;
            // 
            // txtMinTerm
            // 
            this.txtMinTerm.Location = new System.Drawing.Point(147, 142);
            this.txtMinTerm.Name = "txtMinTerm";
            this.txtMinTerm.Size = new System.Drawing.Size(265, 22);
            this.txtMinTerm.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(206, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMinDeposit
            // 
            this.lblMinDeposit.AutoSize = true;
            this.lblMinDeposit.Location = new System.Drawing.Point(445, 349);
            this.lblMinDeposit.Name = "lblMinDeposit";
            this.lblMinDeposit.Size = new System.Drawing.Size(120, 16);
            this.lblMinDeposit.TabIndex = 4;
            this.lblMinDeposit.Text = "Số tiền gửi tối thiểu:";
            // 
            // txtMinDeposit
            // 
            this.txtMinDeposit.Location = new System.Drawing.Point(523, 379);
            this.txtMinDeposit.Name = "txtMinDeposit";
            this.txtMinDeposit.Size = new System.Drawing.Size(265, 22);
            this.txtMinDeposit.TabIndex = 5;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(445, 283);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(143, 16);
            this.lblInitialDeposit.TabIndex = 6;
            this.lblInitialDeposit.Text = "Số tiền mở sổ ban đầu:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(523, 315);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(265, 22);
            this.txtInitialDeposit.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(565, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(688, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.txtMinDeposit);
            this.Controls.Add(this.lblMinDeposit);
            this.Controls.Add(this.groupBoxTermDetails);
            this.Controls.Add(this.dgvRegulations);
            this.Controls.Add(this.btnAddTerm);
            this.Controls.Add(this.btnBackToMain);
            this.Name = "RegulationForm";
            this.Text = "Quản lý Quy định";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.groupBoxTermDetails.ResumeLayout(false);
            this.groupBoxTermDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
