﻿namespace BankManagement
{
    partial class MainForm
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnChangeRegulations = new System.Windows.Forms.Button();
            this.btnOpenCloseAccount = new System.Windows.Forms.Button();
            this.btnManageDatabase = new System.Windows.Forms.Button();
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.txtNotifications = new System.Windows.Forms.TextBox();
            this.pnlNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(16, 11);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(255, 31);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Bank Management";
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(16, 55);
            this.btnManageCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(187, 37);
            this.btnManageCustomers.TabIndex = 1;
            this.btnManageCustomers.Text = "Quản lý khách hàng";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Location = new System.Drawing.Point(211, 55);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(187, 37);
            this.btnTransactionHistory.TabIndex = 2;
            this.btnTransactionHistory.Text = "Lịch sử giao dịch";
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            // 
            // btnChangeRegulations
            // 
            this.btnChangeRegulations.Location = new System.Drawing.Point(405, 55);
            this.btnChangeRegulations.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeRegulations.Name = "btnChangeRegulations";
            this.btnChangeRegulations.Size = new System.Drawing.Size(187, 37);
            this.btnChangeRegulations.TabIndex = 3;
            this.btnChangeRegulations.Text = "Thay đổi quy định";
            this.btnChangeRegulations.UseVisualStyleBackColor = true;
            // 
            // btnOpenCloseAccount
            // 
            this.btnOpenCloseAccount.Location = new System.Drawing.Point(600, 55);
            this.btnOpenCloseAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCloseAccount.Name = "btnOpenCloseAccount";
            this.btnOpenCloseAccount.Size = new System.Drawing.Size(187, 37);
            this.btnOpenCloseAccount.TabIndex = 4;
            this.btnOpenCloseAccount.Text = "Quản lý sổ tiết kiệm";
            this.btnOpenCloseAccount.UseVisualStyleBackColor = true;
            this.btnOpenCloseAccount.Click += new System.EventHandler(this.btnOpenCloseAccount_Click);
            // 
            // btnManageDatabase
            // 
            this.btnManageDatabase.Location = new System.Drawing.Point(795, 55);
            this.btnManageDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageDatabase.Name = "btnManageDatabase";
            this.btnManageDatabase.Size = new System.Drawing.Size(187, 37);
            this.btnManageDatabase.TabIndex = 5;
            this.btnManageDatabase.Text = "Thực hiện giao dịch";
            this.btnManageDatabase.UseVisualStyleBackColor = true;
            this.btnManageDatabase.Click += new System.EventHandler(this.btnManageDatabase_Click);
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.Location = new System.Drawing.Point(989, 55);
            this.btnRegisterEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(187, 37);
            this.btnRegisterEmployee.TabIndex = 6;
            this.btnRegisterEmployee.Text = "Đăng ký nhân viên";
            this.btnRegisterEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1184, 55);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(1200, 18);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(64, 16);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Xin chào, ";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.txtNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(16, 111);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1279, 369);
            this.pnlNotifications.TabIndex = 9;
            // 
            // txtNotifications
            // 
            this.txtNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotifications.Location = new System.Drawing.Point(0, 0);
            this.txtNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotifications.Multiline = true;
            this.txtNotifications.Name = "txtNotifications";
            this.txtNotifications.ReadOnly = true;
            this.txtNotifications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotifications.Size = new System.Drawing.Size(1277, 367);
            this.txtNotifications.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 506);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegisterEmployee);
            this.Controls.Add(this.btnManageDatabase);
            this.Controls.Add(this.btnOpenCloseAccount);
            this.Controls.Add(this.btnChangeRegulations);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.lblProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnChangeRegulations;
        private System.Windows.Forms.Button btnOpenCloseAccount;
        private System.Windows.Forms.Button btnManageDatabase;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.TextBox txtNotifications;
    }
}
