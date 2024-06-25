﻿using System;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class TransactionHistoryForm : Form
    {
        private string username; // Thêm thuộc tính username

        public TransactionHistoryForm(string username) // Thay đổi constructor để nhận username
        {
            InitializeComponent();
            this.username = username; // Lưu trữ username khi khởi tạo form
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            // Load transaction data into DataGridView
            LoadTransactionData();
        }

        private void LoadTransactionData()
        {
            // Here you would load transaction data from your database or other source
            // For demo purposes, we will add some dummy data
            dataGridView1.Columns.Add("TransactionID", "Mã giao dịch");
            dataGridView1.Columns.Add("TransactionType", "Loại giao dịch");
            dataGridView1.Columns.Add("CustomerID", "Mã khách hàng");
            dataGridView1.Columns.Add("SavingsAccountID", "Mã sổ tiết kiệm");
            dataGridView1.Columns.Add("TransactionDate", "Ngày tháng giao dịch");
            dataGridView1.Columns.Add("Amount", "Số tiền"); // Added a column for transaction amount
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Show transaction details
                string transactionID = dataGridView1.Rows[e.RowIndex].Cells["TransactionID"].Value.ToString();
                string transactionType = dataGridView1.Rows[e.RowIndex].Cells["TransactionType"].Value.ToString();
                string customerID = dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                string savingsAccountID = dataGridView1.Rows[e.RowIndex].Cells["SavingsAccountID"].Value.ToString();
                string transactionDate = dataGridView1.Rows[e.RowIndex].Cells["TransactionDate"].Value.ToString();
                string amount = dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value.ToString();

                lblDetails.Text = $"Chi tiết giao dịch: \nMã: {transactionID}\nLoại: {transactionType}\nMã KH: {customerID}\nMã STK: {savingsAccountID}\nNgày: {transactionDate}\nSố tiền: {amount}";
                detailsPanel.Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit transaction
            MessageBox.Show("Chức năng chỉnh sửa đang được phát triển.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete transaction
            MessageBox.Show("Chức năng xóa đang được phát triển.");
        }
    }
}