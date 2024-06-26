namespace BankManagement
{
    partial class TransactionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblTransactionIDValue;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.ComboBox cbTransactionType;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label lblPassbookID;
        private System.Windows.Forms.ComboBox cbPassbookID;
        private System.Windows.Forms.Label lblPassbookType;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.lblTransactionIDValue = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.lblPassbookID = new System.Windows.Forms.Label();
            this.cbPassbookID = new System.Windows.Forms.ComboBox();
            this.lblPassbookType = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(30, 30);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(83, 16);
            this.lblTransactionID.TabIndex = 0;
            this.lblTransactionID.Text = "Mã Giao Dịch:";
            // 
            // lblTransactionIDValue
            // 
            this.lblTransactionIDValue.AutoSize = true;
            this.lblTransactionIDValue.Location = new System.Drawing.Point(130, 30);
            this.lblTransactionIDValue.Name = "lblTransactionIDValue";
            this.lblTransactionIDValue.Size = new System.Drawing.Size(0, 16);
            this.lblTransactionIDValue.TabIndex = 1;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(30, 70);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(98, 16);
            this.lblTransactionType.TabIndex = 2;
            this.lblTransactionType.Text = "Loại Giao Dịch:";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "Rút Tiền",
            "Gửi Tiền"});
            this.cbTransactionType.Location = new System.Drawing.Point(130, 67);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(200, 24);
            this.cbTransactionType.TabIndex = 3;
            this.cbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cbTransactionType_SelectedIndexChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(30, 110);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(94, 16);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "Mã Khách Hàng:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(130, 107);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.Leave += new System.EventHandler(this.txtCustomerID_Leave);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(30, 150);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 16);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Tên Khách:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(130, 147);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerName.TabIndex = 7;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(30, 190);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(48, 16);
            this.lblIDCard.TabIndex = 8;
            this.lblIDCard.Text = "CMND:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(130, 187);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.ReadOnly = true;
            this.txtIDCard.Size = new System.Drawing.Size(200, 22);
            this.txtIDCard.TabIndex = 9;
            // 
            // lblPassbookID
            // 
            this.lblPassbookID.AutoSize = true;
            this.lblPassbookID.Location = new System.Drawing.Point(30, 230);
            this.lblPassbookID.Name = "lblPassbookID";
            this.lblPassbookID.Size = new System.Drawing.Size(88, 16);
            this.lblPassbookID.TabIndex = 10;
            this.lblPassbookID.Text = "Mã Sổ Tiết Kiệm:";
            // 
            // cbPassbookID
            // 
            this.cbPassbookID.FormattingEnabled = true;
            this.cbPassbookID.Location = new System.Drawing.Point(130, 227);
            this.cbPassbookID.Name = "cbPassbookID";
            this.cbPassbookID.Size = new System.Drawing.Size(200, 24);
            this.cbPassbookID.TabIndex = 11;
            this.cbPassbookID.SelectedIndexChanged += new System.EventHandler(this.cbPassbookID_SelectedIndexChanged);
            // 
            // lblPassbookType
            // 
            this.lblPassbookType.AutoSize = true;
            this.lblPassbookType.Location = new System.Drawing.Point(30, 270);
            this.lblPassbookType.Name = "lblPassbookType";
            this.lblPassbookType.Size = new System.Drawing.Size(84, 16);
            this.lblPassbookType.TabIndex = 12;
            this.lblPassbookType.Text = "Loại Kỳ Hạn:";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(30, 310);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(94, 16);
            this.lblRemainingTime.TabIndex = 13;
            this.lblRemainingTime.Text = "Thời Gian Còn Lại:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(30, 350);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(62, 16);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Số Dư:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 390);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 16);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Số Tiền:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 387);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(130, 430);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Xác Nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TransactionForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblPassbookType);
            this.Controls.Add(this.cbPassbookID);
            this.Controls.Add(this.lblPassbookID);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.cbTransactionType);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblTransactionIDValue);
            this.Controls.Add(this.lblTransactionID);
            this.Name = "TransactionForm";
            this.Text = "Thực Hiện Giao Dịch";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
