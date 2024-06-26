using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class OpenNewPassbookForm : Form
    {
        private string connectionString = "Data Source=DATA.db;Version=3;";

        public OpenNewPassbookForm()
        {
            InitializeComponent();
        }

        private void OpenNewPassbookForm_Load(object sender, EventArgs e)
        {
            int newPassbookID = GetNextPassbookID();
            lblPassbookIDValue.Text = newPassbookID.ToString();
        }

        private int GetNextPassbookID()
        {
            int lastPassbookID = 0;
            string query = "SELECT MAX(CAST(SUBSTR(MaSo, 4) AS INTEGER)) FROM SoTietKiem";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastPassbookID = Convert.ToInt32(result);
                }
            }

            return lastPassbookID + 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string passbookID = lblPassbookIDValue.Text;
            string customerID = txtCustomerID.Text;
            string passbookType = txtPassbookType.Text;
            string customerName = txtCustomerName.Text;
            string idCard = txtIDCard.Text;
            string address = txtAddress.Text;
            DateTime openDate = dtpOpenDate.Value;
            string initialDeposit = txtInitialDeposit.Text;

            if (string.IsNullOrEmpty(passbookType) || string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(idCard) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(initialDeposit))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            SaveNewPassbook(passbookID, customerID, passbookType, customerName, idCard, address, openDate, initialDeposit);
            MessageBox.Show($"Sổ tiết kiệm mới đã được mở:\nMã số: {passbookID}\nLoại tiết kiệm: {passbookType}\nKhách hàng: {customerName}\nCMND: {idCard}\nĐịa chỉ: {address}\nNgày mở sổ: {openDate.ToShortDateString()}\nSố tiền gởi: {initialDeposit}");

            this.Close();
        }

        private void SaveNewPassbook(string passbookID, string customerID, string passbookType, string customerName, string idCard, string address, DateTime openDate, string initialDeposit)
        {
            string query = "INSERT INTO SoTietKiem (MaSo, MaKH, MaKyHan, SoDu, NgayLapSo) VALUES (@MaSo, @MaKH, @MaKyHan, @SoDu, @NgayLapSo)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", passbookID);
                command.Parameters.AddWithValue("@MaKH", customerID);
                command.Parameters.AddWithValue("@MaKyHan", passbookType);
                command.Parameters.AddWithValue("@SoDu", initialDeposit);
                command.Parameters.AddWithValue("@NgayLapSo", openDate.ToString("yyyy-MM-dd"));

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            string customerID = txtCustomerID.Text;

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.");
                return;
            }

            string query = "SELECT TenKH, \"CMND/CCCD\", DiaChi FROM KhachHang WHERE MaKH = @MaKH";

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
                    txtAddress.Text = reader["DiaChi"].ToString();
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ.");
                    txtCustomerName.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
            }
        }
    }
}
