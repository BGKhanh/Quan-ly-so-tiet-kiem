using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class PassbookManagementForm : Form
    {
        private string username;
        private string connectionString = "Data Source=DATA.db;Version=3;";

        public PassbookManagementForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadSavingAccounts();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }

        private void btnOpenNewAccount_Click(object sender, EventArgs e)
        {
            OpenNewPassbookForm openNewPassbookForm = new OpenNewPassbookForm();
            openNewPassbookForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgvSavingAccounts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSavingAccounts.SelectedRows[0];
                string accountId = selectedRow.Cells["Mã Sổ"].Value.ToString();
                decimal accountBalance = Convert.ToDecimal(selectedRow.Cells["Số Tiền Gửi"].Value);

                if (accountBalance != 0)
                {
                    MessageBox.Show("Chỉ có thể xóa sổ tiết kiệm khi số tiền trong sổ là 0.");
                    return;
                }

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sổ tiết kiệm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM SoTietKiem WHERE MaSo = @MaSo";
                        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaSo", accountId);
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadSavingAccounts();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sổ tiết kiệm để xóa.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            string searchField = cmbSearchField.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchField))
            {
                MessageBox.Show("Vui lòng chọn trường tìm kiếm.");
                return;
            }

            LoadSavingAccounts(searchValue, searchField);
        }

        private void LoadSavingAccounts(string searchKeyword = "", string searchField = "")
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        stk.MaSo AS 'Mã Sổ', 
                        lk.TenKyHan AS 'Loại Tiết Kiệm', 
                        kh.TenKH AS 'Tên Khách Hàng', 
                        kh.[CMND/CCCD] AS 'CMND/CCCD',
                        kh.DiaChi AS 'Địa Chỉ',
                        stk.NgayLapSo AS 'Ngày Mở Sổ', 
                        stk.SoDu AS 'Số Tiền Gửi',
                        CASE
                            WHEN stk.SoDu = 0 THEN 'Đóng'
                            ELSE 'Đang Mở'
                        END AS 'Tình Trạng'
                    FROM 
                        SoTietKiem stk
                    JOIN 
                        KhachHang kh ON stk.MaKH = kh.MaKH
                    JOIN 
                        LoaiKyHan lk ON stk.MaKyHan = lk.MaKyHan
                    WHERE 
                        (@SearchField = '' OR 
                        (@SearchField = 'Mã Sổ' AND stk.MaSo LIKE @SearchKeyword) OR
                        (@SearchField = 'Tên Khách Hàng' AND kh.TenKH LIKE @SearchKeyword) OR
                        (@SearchField = 'CMND/CCCD' AND kh.[CMND/CCCD] LIKE @SearchKeyword) OR
                        (@SearchField = 'Địa Chỉ' AND kh.DiaChi LIKE @SearchKeyword))";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchField", searchField);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvSavingAccounts.DataSource = dataTable;
            }
        }

        private void PassbookManagementForm_Load(object sender, EventArgs e)
        {
            cmbSearchField.SelectedIndex = 0; // Default selection for ComboBox
        }
    }
}
