using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class TransactionForm : Form
    {
        private string connectionString = "DATA.db"; // Update with your actual connection string

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.SelectedItem.ToString();
            string accountNumber = txtAccountNumber.Text;
            decimal amount;

            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Số tài khoản không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = PerformTransaction(transactionType, accountNumber, amount);

            if (success)
            {
                MessageBox.Show("Giao dịch thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Giao dịch thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool PerformTransaction(string transactionType, string accountNumber, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (transactionType == "Gửi Tiền")
                    {
                        query = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber";
                    }
                    else if (transactionType == "Rút Tiền")
                    {
                        query = "UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber AND Balance >= @Amount";
                    }
                    else
                    {
                        return false;
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
