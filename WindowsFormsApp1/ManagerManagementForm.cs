using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmDangKyNV : Form
    {
        private string username;
        private bool isEditing = false;
        private string originalMaNV;

        public frmDangKyNV(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadEmployeeData();
        }

        private void frmDangKyNV_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            SetFormReadOnly(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetFormReadOnly(false);
            GenerateTemporaryEmployeeId();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (isEditing)
                {
                    UpdateEmployee();
                }
                else
                {
                    AddNewEmployee();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void dataGridViewDSNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDSNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDSNV.SelectedRows[0];
                txtMaNV.Text = selectedRow.Cells["colMaNV"].Value.ToString();
                txtTenNV.Text = selectedRow.Cells["colTenNV"].Value.ToString();
                cboChucVu.SelectedItem = selectedRow.Cells["colChucVu"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["colSDT"].Value.ToString();
                cboGioiTinh.SelectedItem = selectedRow.Cells["colGioiTinh"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["colDiaChi"].Value.ToString();
                txtCMND.Text = selectedRow.Cells["colCMND"].Value.ToString();
                txtMK.Text = selectedRow.Cells["colMatKhau"].Value.ToString();

                originalMaNV = txtMaNV.Text;
                SetFormReadOnly(true);
                isEditing = false;
            }
        }

        private void SetFormReadOnly(bool isReadOnly)
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = isReadOnly;
            cboChucVu.Enabled = !isReadOnly;
            txtSDT.ReadOnly = isReadOnly;
            cboGioiTinh.Enabled = !isReadOnly;
            txtDiaChi.ReadOnly = isReadOnly;
            txtCMND.ReadOnly = true;
            txtMK.ReadOnly = isReadOnly;
            txtNhapLaiMK.ReadOnly = isReadOnly;

            btnLuu.Enabled = !isReadOnly;
        }

        private void ClearForm()
        {
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            cboChucVu.SelectedIndex = -1;
            txtSDT.Text = string.Empty;
            cboGioiTinh.SelectedIndex = -1;
            txtDiaChi.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtNhapLaiMK.Text = string.Empty;
        }

        private void GenerateTemporaryEmployeeId()
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT COUNT(*) FROM NhanVien";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cboChucVu.SelectedItem.ToString() == "Quản lý")
                    {
                        txtMaNV.Text = "QL" + (count + 1).ToString("D4");
                    }
                    else
                    {
                        txtMaNV.Text = "NV" + (count + 1).ToString("D4");
                    }
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
        }

        private void AddNewEmployee()
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string chucVu = cboChucVu.SelectedItem.ToString();
            string sdt = txtSDT.Text;
            string gioiTinh = cboGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text;
            string matKhau = txtMK.Text;
            string cmnd = txtCMND.Text;

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "INSERT INTO NhanVien (MaNV, TenNV, ChucVu, SDT, GioiTinh, DiaChi, MatKhau, \"CMND/CCCD\") VALUES (@MaNV, @TenNV, @ChucVu, @SDT, @GioiTinh, @DiaChi, @MatKhau, @CMND)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@CMND", cmnd);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhân viên mới đã được thêm thành công!");
                    LoadEmployeeData();
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
        }

        private void UpdateEmployee()
        {
            string maNV = originalMaNV;
            string tenNV = txtTenNV.Text;
            string chucVu = cboChucVu.SelectedItem.ToString();
            string sdt = txtSDT.Text;
            string gioiTinh = cboGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text;
            string matKhau = txtMK.Text;
            string cmnd = txtCMND.Text;

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "UPDATE NhanVien SET TenNV = @TenNV, ChucVu = @ChucVu, SDT = @SDT, GioiTinh = @GioiTinh, DiaChi = @DiaChi, MatKhau = @MatKhau WHERE MaNV = @MaNV";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công!");
                    LoadEmployeeData();
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
        }

        private bool ValidateForm()
        {
            bool isValid = true;

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
            if (cboChucVu.SelectedIndex == -1)
            {
                errChucVu.SetError(cboChucVu, "Chức vụ không được để trống.");
                isValid = false;
            }
            else
            {
                errChucVu.SetError(cboChucVu, string.Empty);
            }

            // Validate SDT
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errSDT.SetError(txtSDT, "Số điện thoại không được để trống.");
                isValid = false;
            }
            else
            {
                errSDT.SetError(txtSDT, string.Empty);
            }

            // Validate GioiTinh
            if (cboGioiTinh.SelectedIndex == -1)
            {
                errGioiTinh.SetError(cboGioiTinh, "Giới tính không được để trống.");
                isValid = false;
            }
            else
            {
                errGioiTinh.SetError(cboGioiTinh, string.Empty);
            }

            // Validate DiaChi
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errDiaChi.SetError(txtDiaChi, "Địa chỉ không được để trống.");
                isValid = false;
            }
            else
            {
                errDiaChi.SetError(txtDiaChi, string.Empty);
            }

            // Validate MatKhau
            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                errMatKhau.SetError(txtMK, "Mật khẩu không được để trống.");
                isValid = false;
            }
            else
            {
                errMatKhau.SetError(txtMK, string.Empty);
            }

            // Validate MatKhau confirm
            if (txtMK.Text != txtNhapLaiMK.Text)
            {
                errNhapLaiMK.SetError(txtNhapLaiMK, "Mật khẩu nhập lại không khớp.");
                isValid = false;
            }
            else
            {
                errNhapLaiMK.SetError(txtNhapLaiMK, string.Empty);
            }

            return isValid;
        }

        private void LoadEmployeeData()
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT MaNV, TenNV, ChucVu, SDT, GioiTinh, DiaChi, MatKhau, \"CMND/CCCD\" FROM NhanVien";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, DatabaseManager.Instance.GetConnection()))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Kiểm tra nếu DataGridView không có cột nào thì tạo các cột
                    if (dataGridViewDSNV.Columns.Count == 0)
                    {
                        dataGridViewDSNV.AutoGenerateColumns = false;

                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colMaNV", DataPropertyName = "MaNV", HeaderText = "Mã NV" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colTenNV", DataPropertyName = "TenNV", HeaderText = "Tên NV" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colChucVu", DataPropertyName = "ChucVu", HeaderText = "Chức vụ" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colSDT", DataPropertyName = "SDT", HeaderText = "SĐT" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colGioiTinh", DataPropertyName = "GioiTinh", HeaderText = "Giới tính" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCMND", DataPropertyName = "CMND", HeaderText = "CMND" });
                        dataGridViewDSNV.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colMatKhau", DataPropertyName = "MatKhau", HeaderText = "Mật khẩu" });
                    }

                    dataGridViewDSNV.DataSource = dt;
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
        }


        private void dataGridViewDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
