using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagement
{
    public partial class TransactionForm : Form
    {
        private string connectionString = "Data Source=DATA.db;Version=3;";
        private string username;

        public TransactionForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            int newTransactionID = GetNextTransactionID();
            lblTransactionIDValue.Text = newTransactionID.ToString();
        }

        private int GetNextTransactionID()
        {
            int lastTransactionID = 0;
            string query = "SELECT MAX(CAST(SUBSTR(MaGD, 4) AS INTEGER)) FROM GiaoDich";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastTransactionID = Convert.ToInt32(result);
                }
            }

            return lastTransactionID + 1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string transactionType = cbTransactionType.SelectedItem.ToString();
            string passbookID = cbPassbookID.SelectedItem.ToString();
            decimal amount;

            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(passbookID))
            {
                MessageBox.Show("Mã sổ tiết kiệm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = PerformTransaction(transactionType, passbookID, amount);

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
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private bool PerformTransaction(string transactionType, string passbookID, decimal amount)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (transactionType == "Gửi Tiền")
                    {
                        query = "UPDATE SoTietKiem SET SoDu = SoDu + @Amount WHERE MaSo = @PassbookID AND NgayDenHan = @Today";
                    }
                    else if (transactionType == "Rút Tiền")
                    {
                        query = "UPDATE SoTietKiem SET SoDu = SoDu - @Amount WHERE MaSo = @PassbookID AND SoDu >= @Amount";
                    }
                    else
                    {
                        return false;
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@PassbookID", passbookID);
                        cmd.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy-MM-dd"));

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

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            string customerID = txtCustomerID.Text;

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.");
                return;
            }

            string query = "SELECT TenKH, \"CMND/CCCD\" FROM KhachHang WHERE MaKH = @MaKH";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", customerID);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtCustomerName.Text = reader["TenKH"].ToString();
                    txtIDCard.Text = reader["CMND/CCCD"].ToString();
                    LoadPassbookIDs(customerID);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ.");
                    txtCustomerName.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    cbPassbookID.Items.Clear();
                }
            }
        }

        private void LoadPassbookIDs(string customerID)
        {
            string query = "SELECT MaSo FROM SoTietKiem WHERE MaKH = @MaKH";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", customerID);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                cbPassbookID.Items.Clear();
                while (reader.Read())
                {
                    cbPassbookID.Items.Add(reader["MaSo"].ToString());
                }

                if (cbPassbookID.Items.Count > 0)
                {
                    cbPassbookID.SelectedIndex = 0;
                    LoadPassbookDetails(cbPassbookID.SelectedItem.ToString());
                }
            }
        }

        private void cbPassbookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPassbookDetails(cbPassbookID.SelectedItem.ToString());
        }

        private void LoadPassbookDetails(string passbookID)
        {
            string query = @"
    SELECT 
        stk.MaKyHan, 
        stk.SoDu, 
        (lk.ThoiGianGoiToiThieu - julianday(@Today) + julianday(stk.NgayLapSo)) AS ThoiGianConLai 
    FROM 
        SoTietKiem stk 
    JOIN 
        LoaiKyHan lk 
    ON 
        stk.MaKyHan = lk.MaKyHan 
    WHERE 
        stk.MaSo = @MaSo";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", passbookID);
                command.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy-MM-dd"));
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtPassbookType.Text = reader["MaKyHan"].ToString();
                    txtRemainingTime.Text = reader["ThoiGianConLai"].ToString() + " ngày";
                    txtBalance.Text = reader["SoDu"].ToString() + " VND";
                }
            }
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thêm bất kỳ logic nào cần thiết khi loại giao dịch thay đổi.
        }
    }
}
