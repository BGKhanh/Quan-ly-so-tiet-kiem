using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerRegisterForm
{
    public partial class frmDangKyNV : Form
    {
        private string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";

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
                string gioiTinh = cboGioiTinh.SelectedItem.ToString();
                string email = txtEmail.Text;
                string diaChi = txtDiaChi.Text;
                string tenTK = txtTenTK.Text;
                string matKhau = txtMK.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Employees (MaNV, TenNV, GioiTinh, NgaySinh, Email, DiaChi, TenTK, MatKhau) VALUES (@MaNV, @TenNV, @GioiTinh, @NgaySinh, @Email, @DiaChi, @TenTK, @MatKhau)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@TenTK", tenTK);
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

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, "Email không được để trống.");
                isValid = false;
            }
            else
            {
                errEmail.SetError(txtEmail, string.Empty);
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

            // Validate TenTK
            if (string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                errTenTK.SetError(txtTenTK, "Tên tài khoản không được để trống.");
                isValid = false;
            }
            else
            {
                errTenTK.SetError(txtTenTK, string.Empty);
            }

            // Validate MK
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

            return isValid;
        }

        private void LoadEmployeeData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDangKyNV
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmDangKyNV";
            this.Load += new System.EventHandler(this.frmDangKyNV_Load_1);
            this.ResumeLayout(false);

        }

        private void frmDangKyNV_Load_1(object sender, EventArgs e)
        {

        }
    }
}