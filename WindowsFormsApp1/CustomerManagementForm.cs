using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class CustomerManagementForm : Form
    {
        private string username;
        private bool isEditMode = false;

        public CustomerManagementForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT MaKH, TenKH, \"CMND/CCCD\", SDT, GioiTinh, DiaChi FROM KhachHang";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, DatabaseManager.Instance.GetConnection()))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DataTable dt = new DataTable();
                dt.Columns.Add("Field");
                dt.Columns.Add("Value");
                dt.Rows.Add("MaKH", row.Cells["MaKH"].Value.ToString());
                dt.Rows.Add("TenKH", row.Cells["TenKH"].Value.ToString());
                dt.Rows.Add("CMND/CCCD", row.Cells["CMND/CCCD"].Value.ToString());
                dt.Rows.Add("SDT", row.Cells["SDT"].Value.ToString());
                dt.Rows.Add("GioiTinh", row.Cells["GioiTinh"].Value.ToString());
                dt.Rows.Add("DiaChi", row.Cells["DiaChi"].Value.ToString());
                detailsDataGridView.DataSource = dt;
                detailsPanel.Visible = true;
                SetReadOnlyMode(true);
            }
        }

        private void SetReadOnlyMode(bool isReadOnly)
        {
            foreach (DataGridViewRow row in detailsDataGridView.Rows)
            {
                row.Cells["Value"].ReadOnly = isReadOnly;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                SetReadOnlyMode(false);
                isEditMode = true;
                btnEdit.Text = "Lưu";
            }
            else
            {
                SaveChanges();
                SetReadOnlyMode(true);
                isEditMode = false;
                btnEdit.Text = "Chỉnh sửa";
            }
        }

        private void SaveChanges()
        {
            string maKH = detailsDataGridView.Rows[0].Cells["Value"].Value.ToString();
            string tenKH = detailsDataGridView.Rows[1].Cells["Value"].Value.ToString();
            string cmnd = detailsDataGridView.Rows[2].Cells["Value"].Value.ToString();
            string sdt = detailsDataGridView.Rows[3].Cells["Value"].Value.ToString();
            string gioiTinh = detailsDataGridView.Rows[4].Cells["Value"].Value.ToString();
            string diaChi = detailsDataGridView.Rows[5].Cells["Value"].Value.ToString();

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "UPDATE KhachHang SET TenKH = @TenKH, \"CMND/CCCD\" = @CMND, SDT = @SDT, GioiTinh = @GioiTinh, DiaChi = @DiaChi WHERE MaKH = @MaKH";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@CMND", cmnd);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            LoadCustomerData();
            MessageBox.Show("Thông tin khách hàng đã được cập nhật.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detailsDataGridView.Rows.Count > 0)
            {
                string customerID = detailsDataGridView.Rows[0].Cells["Value"].Value.ToString();

                // Check for open savings accounts before deleting
                bool hasOpenAccounts = false;
                try
                {
                    DatabaseManager.Instance.OpenConnection();
                    string checkQuery = "SELECT COUNT(*) FROM SoTietKiem WHERE MaKH = @MaKH AND TinhTrang = 1";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, DatabaseManager.Instance.GetConnection()))
                    {
                        checkCmd.Parameters.AddWithValue("@MaKH", customerID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            hasOpenAccounts = true;
                        }
                    }
                }
                finally
                {
                    DatabaseManager.Instance.CloseConnection();
                }

                if (hasOpenAccounts)
                {
                    MessageBox.Show("Không thể xóa khách hàng vì có sổ tiết kiệm còn mở.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool success = false;
                    int attempts = 0;
                    while (!success && attempts < 5)
                    {
                        try
                        {
                            DatabaseManager.Instance.OpenConnection();
                            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                            using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@MaKH", customerID);
                                cmd.ExecuteNonQuery();
                            }
                            success = true;
                            LoadCustomerData();
                            detailsPanel.Visible = false;
                            MessageBox.Show("Đã xóa khách hàng.");
                        }
                        catch (SQLiteException ex) when (ex.Message.Contains("database is locked"))
                        {
                            attempts++;
                            System.Threading.Thread.Sleep(500);
                        }
                        finally
                        {
                            DatabaseManager.Instance.CloseConnection();
                        }
                    }
                    if (!success)
                    {
                        MessageBox.Show("Không thể xóa khách hàng do cơ sở dữ liệu đang bị khóa. Vui lòng thử lại sau.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
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

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = $"SELECT MaKH, TenKH, \"CMND/CCCD\", SDT, GioiTinh, DiaChi FROM KhachHang WHERE {searchField} LIKE @SearchValue";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, DatabaseManager.Instance.GetConnection()))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm registerForm = new AddCustomerForm();
            registerForm.ShowDialog();
            LoadCustomerData();
        }
    }
}
