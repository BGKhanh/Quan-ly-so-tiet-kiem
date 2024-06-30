using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BankManagement
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // Lấy mã khách hàng mới nhất từ cơ sở dữ liệu
            string newCustomerCode = GetNewCustomerCode();
            lblCustomerCode.Text =  newCustomerCode;
        }

        private string GetNewCustomerCode()
        {
            string newCode = "1";
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT IFNULL(MAX(CAST(MaKH AS INTEGER)), 0) + 1 FROM KhachHang";
                using (var cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        newCode = result.ToString();
                    }
                }
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
            return newCode;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (cmnd.Length < 9 || cmnd.Length > 20)
            {
                MessageBox.Show("CMND/CCCD không hợp lệ.");
                return;
            }

            if (IsCustomerExist(cmnd))
            {
                MessageBox.Show("Khách hàng đã tồn tại.");
                return;
            }

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "INSERT INTO KhachHang (MaKH, TenKH, \"CMND/CCCD\", SDT, GioiTinh, DiaChi) VALUES (@MaKH, @TenKH, @CMND, @SDT, @GioiTinh, @DiaChi)";
                using (var cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaKH", lblCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@TenKH", customerName);
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

            MessageBox.Show("Đăng ký khách hàng thành công.");
            this.Close();
        }

        private bool IsCustomerExist(string cmnd)
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT COUNT(*) FROM KhachHang WHERE \"CMND/CCCD\" = @CMND";
                using (var cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@CMND", cmnd);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
