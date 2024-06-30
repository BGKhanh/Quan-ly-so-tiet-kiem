using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class PassbookManagementForm : Form
    {
        private string username;

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
                    try
                    {
                        DatabaseManager.Instance.OpenConnection();
                        string deleteQuery = "DELETE FROM SoTietKiem WHERE MaSo = @MaSo";
                        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, DatabaseManager.Instance.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@MaSo", accountId);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        DatabaseManager.Instance.CloseConnection();
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
            string query = @"
        SELECT 
            stk.MaSo AS 'Mã Sổ', 
            lk.TenKyHan AS 'Loại Tiết Kiệm', 
            kh.TenKH AS 'Tên Khách Hàng', 
            kh.[CMND/CCCD] AS 'CMND/CCCD',
            kh.DiaChi AS 'Địa Chỉ',
            strftime('%d/%m/%Y', stk.NgayLapSo) AS 'Ngày Mở Sổ', 
            CASE
                WHEN stk.NgayDongSo IS NOT NULL THEN strftime('%d/%m/%Y', stk.NgayDongSo)
                ELSE ''
            END AS 'Ngày Đóng Sổ',
            stk.SoDu AS 'Số Tiền Gửi',
            CASE
                WHEN stk.TinhTrang = 1 THEN 'Đang Mở'
                ELSE 'Đã Đóng'
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

            try
            {
                DatabaseManager.Instance.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, DatabaseManager.Instance.GetConnection());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchField", searchField);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvSavingAccounts.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }


        private void PassbookManagementForm_Load(object sender, EventArgs e)
        {
            cmbSearchField.SelectedIndex = 0; // Default selection for ComboBox
        }

        private void dgvSavingAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
