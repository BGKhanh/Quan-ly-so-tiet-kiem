using System;
using System.Data;
using System.Data.SQLite; // Sử dụng thư viện SQLite
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmDangKyNV : Form
    {
        private string connectionString = "Data Source=DATA.db;Version=3;";

        public frmDangKyNV()
        {
            InitializeComponent();
        }

        private void frmDangKyNV_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string chucVu = txtChucVu.Text;
                string sdt = txtSDT.Text;
                string gioiTinh = cboGioiTinh.SelectedItem.ToString();
                string diaChi = txtDiaChi.Text;
                string matKhau = txtMK.Text;

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO NhanVien (MaNV, TenNV, ChucVu, SDT, GioiTinh, DiaChi, MatKhau) VALUES (@MaNV, @TenNV, @ChucVu, @SDT, @GioiTinh, @DiaChi, @MatKhau)";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nhân viên mới đã được thêm thành công!");

                        // Refresh DataGridView
                        LoadEmployeeData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add logic to handle cell content click event
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Validate MaNV
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                errTenNV.SetError(txtMaNV, "Mã nhân viên không được để trống.");
                isValid = false;
            }
            else
            {
                errTenNV.SetError(txtMaNV, string.Empty);
            }

            // Validate TenNV
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                errTenNV.SetError(txtTenNV, "Tên nhân viên không được để trống.");
                isValid = false;
            }
            else
            {
                errTenNV.SetError(txtTenNV, string.Empty);
            }

            // Validate ChucVu
            if (string.IsNullOrWhiteSpace(txtChucVu.Text))
            {
                errChucVu.SetError(txtChucVu, "Chức vụ không được để trống.");
                isValid = false;
            }
            else
            {
                errChucVu.SetError(txtChucVu, string.Empty);
            }

            // Validate SDT
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errChucVu.SetError(txtSDT, "Số điện thoại không được để trống.");
                isValid = false;
            }
            else
            {
                errChucVu.SetError(txtSDT, string.Empty);
            }

            // Validate GioiTinh
            if (cboGioiTinh.SelectedIndex < 0)
            {
                errGT.SetError(cboGioiTinh, "Giới tính không được để trống.");
                isValid = false;
            }
            else
            {
                errGT.SetError(cboGioiTinh, string.Empty);
            }

            // Validate DiaChi
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errDC.SetError(txtDiaChi, "Địa chỉ không được để trống.");
                isValid = false;
            }
            else
            {
                errDC.SetError(txtDiaChi, string.Empty);
            }

            // Validate MatKhau
            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                errMK.SetError(txtMK, "Mật khẩu không được để trống.");
                isValid = false;
            }
            else
            {
                errMK.SetError(txtMK, string.Empty);
            }

            // Validate NhapLaiMK
            if (txtNhapLaiMK.Text != txtMK.Text)
            {
                errMK.SetError(txtNhapLaiMK, "Mật khẩu nhập lại không khớp.");
                isValid = false;
            }
            else
            {
                errMK.SetError(txtNhapLaiMK, string.Empty);
            }

            return isValid;
        }

        private void LoadEmployeeData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NhanVien";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewDSNV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void frmDangKyNV_Load_1(object sender, EventArgs e)
        {

        }

        private void frmDangKyNV_Load_2(object sender, EventArgs e)
        {

        }
    }
}
