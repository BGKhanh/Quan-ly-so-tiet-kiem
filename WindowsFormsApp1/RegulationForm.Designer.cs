using System.ComponentModel;
using System.Windows.Forms;

namespace BankManagement
{
    partial class RegulationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBackToMain;
        private Label lblTerm;
        private Label lblInterestRate;
        private TextBox txtTerm;
        private TextBox txtInterestRate;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView dgvRegulations;
        private TextBox txtMinDeposit;
        private Label lblMinDeposit;
        private TextBox txtMinDuration;
        private Label lblMinDuration;

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
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvRegulations = new System.Windows.Forms.DataGridView();
            this.txtMinDeposit = new System.Windows.Forms.TextBox();
            this.lblMinDeposit = new System.Windows.Forms.Label();
            this.txtMinDuration = new System.Windows.Forms.TextBox();
            this.lblMinDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(16, 15);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMain.TabIndex = 0;
            this.btnBackToMain.Text = "Trở về";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(16, 268);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(50, 16);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "Kỳ hạn:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(16, 304);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(56, 16);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Lãi suất:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(163, 264);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(265, 22);
            this.txtTerm.TabIndex = 3;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(163, 300);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(265, 22);
            this.txtInterestRate.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 419);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 419);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvRegulations
            // 
            this.dgvRegulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegulations.Location = new System.Drawing.Point(19, 50);
            this.dgvRegulations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegulations.Name = "dgvRegulations";
            this.dgvRegulations.Size = new System.Drawing.Size(416, 185);
            this.dgvRegulations.TabIndex = 7;
            // 
            // txtMinDeposit
            // 
            this.txtMinDeposit.Location = new System.Drawing.Point(163, 336);
            this.txtMinDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinDeposit.Name = "txtMinDeposit";
            this.txtMinDeposit.Size = new System.Drawing.Size(265, 22);
            this.txtMinDeposit.TabIndex = 9;
            // 
            // lblMinDeposit
            // 
            this.lblMinDeposit.AutoSize = true;
            this.lblMinDeposit.Location = new System.Drawing.Point(16, 340);
            this.lblMinDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinDeposit.Name = "lblMinDeposit";
            this.lblMinDeposit.Size = new System.Drawing.Size(103, 16);
            this.lblMinDeposit.TabIndex = 8;
            this.lblMinDeposit.Text = "Tiền gửi tối thiểu:";
            // 
            // txtMinDuration
            // 
            this.txtMinDuration.Location = new System.Drawing.Point(163, 372);
            this.txtMinDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinDuration.Name = "txtMinDuration";
            this.txtMinDuration.Size = new System.Drawing.Size(265, 22);
            this.txtMinDuration.TabIndex = 11;
            // 
            // lblMinDuration
            // 
            this.lblMinDuration.AutoSize = true;
            this.lblMinDuration.Location = new System.Drawing.Point(16, 376);
            this.lblMinDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinDuration.Name = "lblMinDuration";
            this.lblMinDuration.Size = new System.Drawing.Size(122, 16);
            this.lblMinDuration.TabIndex = 10;
            this.lblMinDuration.Text = "Thời gian gửi tối thiểu:";
            // 
            // RegulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 460);
            this.Controls.Add(this.txtMinDuration);
            this.Controls.Add(this.lblMinDuration);
            this.Controls.Add(this.txtMinDeposit);
            this.Controls.Add(this.lblMinDeposit);
            this.Controls.Add(this.dgvRegulations);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.btnBackToMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegulationForm";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.RegulationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
