using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class OpenNewPassbookForm : Form
    {
        private string connectionString = "Data Source=your_database_file.db;Version=3;";

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

            SaveNewPassbook(passbookID, passbookType, customerName, idCard, address, openDate, initialDeposit);
            MessageBox.Show($"Sổ tiết kiệm mới đã được mở:\nMã số: {passbookID}\nLoại tiết kiệm: {passbookType}\nKhách hàng: {customerName}\nCMND: {idCard}\nĐịa chỉ: {address}\nNgày mở sổ: {openDate.ToShortDateString()}\nSố tiền gởi: {initialDeposit}");

            this.Close();
        }

        private void SaveNewPassbook(string passbookID, string passbookType, string customerName, string idCard, string address, DateTime openDate, string initialDeposit)
        {
            string query = "INSERT INTO SoTietKiem (MaSo, MaKH, MaKyHan, SoDu, NgayLapSo) VALUES (@MaSo, @MaKH, @MaKyHan, @SoDu, @NgayLapSo)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", passbookID);
                command.Parameters.AddWithValue("@MaKH", customerName); // MaKH cần lấy từ bảng KhachHang dựa trên tên khách hàng
                command.Parameters.AddWithValue("@MaKyHan", passbookType); // MaKyHan cần lấy từ bảng LoaiKyHan dựa trên loại tiết kiệm
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
    }
}
