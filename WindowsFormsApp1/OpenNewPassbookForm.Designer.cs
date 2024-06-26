using System.Windows.Forms;

namespace BankManagement
{
    partial class OpenNewPassbookForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSave;
        private Button btnCancel;
        private Label lblPassbookTitle;
        private Label lblPassbookID;
        private Label lblCustomerID;
        private Label lblPassbookType;
        private Label lblCustomerName;
        private Label lblIDCard;
        private Label lblAddress;
        private Label lblOpenDate;
        private Label lblInitialDeposit;
        private Label lblPassbookIDValue;
        private TextBox txtCustomerID;
        private TextBox txtPassbookType;
        private TextBox txtCustomerName;
        private TextBox txtIDCard;
        private TextBox txtAddress;
        private DateTimePicker dtpOpenDate;
        private TextBox txtInitialDeposit;

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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPassbookTitle = new System.Windows.Forms.Label();
            this.lblPassbookID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblPassbookType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.lblPassbookIDValue = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtPassbookType = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPassbookTitle
            // 
            this.lblPassbookTitle.AutoSize = true;
            this.lblPassbookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassbookTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPassbookTitle.Name = "lblPassbookTitle";
            this.lblPassbookTitle.Size = new System.Drawing.Size(118, 20);
            this.lblPassbookTitle.TabIndex = 2;
            this.lblPassbookTitle.Text = "Sổ Tiết Kiệm";
            // 
            // lblPassbookID
            // 
            this.lblPassbookID.AutoSize = true;
            this.lblPassbookID.Location = new System.Drawing.Point(16, 48);
            this.lblPassbookID.Name = "lblPassbookID";
            this.lblPassbookID.Size = new System.Drawing.Size(50, 13);
            this.lblPassbookID.TabIndex = 3;
            this.lblPassbookID.Text = "Mã số:";
            // 
            // lblPassbookIDValue
            // 
            this.lblPassbookIDValue.AutoSize = true;
            this.lblPassbookIDValue.Location = new System.Drawing.Point(120, 48);
            this.lblPassbookIDValue.Name = "lblPassbookIDValue";
            this.lblPassbookIDValue.Size = new System.Drawing.Size(50, 13);
            this.lblPassbookIDValue.TabIndex = 10;
            this.lblPassbookIDValue.Text = "TBD";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(16, 78);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "Mã khách hàng:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(120, 75);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerID.TabIndex = 11;
            this.txtCustomerID.Leave += new System.EventHandler(this.txtCustomerID_Leave);
            // 
            // lblPassbookType
            // 
            this.lblPassbookType.AutoSize = true;
            this.lblPassbookType.Location = new System.Drawing.Point(16, 108);
            this.lblPassbookType.Name = "lblPassbookType";
            this.lblPassbookType.Size = new System.Drawing.Size(86, 13);
            this.lblPassbookType.TabIndex = 5;
            this.lblPassbookType.Text = "Loại tiết kiệm:";
            // 
            // txtPassbookType
            // 
            this.txtPassbookType.Location = new System.Drawing.Point(120, 105);
            this.txtPassbookType.Name = "txtPassbookType";
            this.txtPassbookType.Size = new System.Drawing.Size(200, 20);
            this.txtPassbookType.TabIndex = 12;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 138);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Khách hàng:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 135);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 13;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(16, 168);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(48, 13);
            this.lblIDCard.TabIndex = 7;
            this.lblIDCard.Text = "CMND:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(120, 165);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(200, 20);
            this.txtIDCard.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 198);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Location = new System.Drawing.Point(16, 228);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(79, 13);
            this.lblOpenDate.TabIndex = 9;
            this.lblOpenDate.Text = "Ngày mở sổ:";
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Location = new System.Drawing.Point(120, 225);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOpenDate.TabIndex = 16;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(16, 258);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(72, 13);
            this.lblInitialDeposit.TabIndex = 10;
            this.lblInitialDeposit.Text = "Số tiền gởi:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(120, 255);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(200, 20);
            this.txtInitialDeposit.TabIndex = 17;
            // 
            // OpenNewPassbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.dtpOpenDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPassbookType);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPassbookType);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblPassbookIDValue);
            this.Controls.Add(this.lblPassbookID);
            this.Controls.Add(this.lblPassbookTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "OpenNewPassbookForm";
            this.Text = "Mở sổ tiết kiệm mới";
            this.Load += new System.EventHandler(this.OpenNewPassbookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
