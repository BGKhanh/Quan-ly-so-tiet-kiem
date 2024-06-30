using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class RegulationForm : Form
    {
        private string username;

        private void LoadCurrentRegulations()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Kỳ Hạn");
            dt.Columns.Add("Tên Kỳ Hạn");
            dt.Columns.Add("Lãi Suất");
            dt.Columns.Add("Thời Gian Gửi Tối Thiểu");

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT * FROM LoaiKyHan";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["Mã Kỳ Hạn"] = reader["MaKyHan"].ToString();
                            row["Tên Kỳ Hạn"] = reader["TenKyHan"].ToString();
                            row["Lãi Suất"] = reader["LaiSuat"].ToString();
                            row["Thời Gian Gửi Tối Thiểu"] = reader["ThoiGianGoiToiThieu"].ToString();
                            dt.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            dgvRegulations.DataSource = dt;
            dgvRegulations.Columns["Mã Kỳ Hạn"].ReadOnly = true;
        }

        private void dgvRegulations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRegulations.Rows[e.RowIndex];
                txtTerm.Text = row.Cells["Tên Kỳ Hạn"].Value.ToString();
                txtInterestRate.Text = row.Cells["Lãi Suất"].Value.ToString();
                txtMinTerm.Text = row.Cells["Thời Gian Gửi Tối Thiểu"].Value.ToString();
                txtTermID.Text = row.Cells["Mã Kỳ Hạn"].Value.ToString();
                SetFieldsReadOnly(true);
            }
        }

        private void LoadGlobalSettings()
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT * FROM GlobalSetting";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMinDeposit.Text = reader["MinDeposit"].ToString();
                            txtInitialDeposit.Text = reader["InitialDeposit"].ToString();
                            txtMinWithdraw.Text = reader["MinWithdraw"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            SetGlobalSettingsReadOnly(true);
        }

        private string GetNextTermID()
        {
            string nextID = "1";
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT COUNT(MaKyHan) FROM LoaiKyHan";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int count = Convert.ToInt32(result);
                        nextID = (count + 1).ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy mã kỳ hạn mới: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
            return nextID;
        }


        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }

        private void txtMinTerm_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTermDetails_Enter(object sender, EventArgs e)
        {

        }

        private void RegulationForm_Load(object sender, EventArgs e)
        {
            LoadCurrentRegulations();
            LoadGlobalSettings();
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            txtTerm.ReadOnly = readOnly;
            txtInterestRate.ReadOnly = readOnly;
            txtMinTerm.ReadOnly = readOnly;
            txtTermID.ReadOnly = readOnly;
        }

        private void SetGlobalSettingsReadOnly(bool readOnly)
        {
            txtMinDeposit.ReadOnly = readOnly;
            txtInitialDeposit.ReadOnly = readOnly;
            txtMinWithdraw.ReadOnly = readOnly;
        }

        private void ClearFields()
        {
            txtTerm.Clear();
            txtInterestRate.Clear();
            txtMinTerm.Clear();
            txtTermID.Clear();
        }

        public RegulationForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnAddTerm_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtTermID.Text = GetNextTermID();
            SetFieldsReadOnly(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetFieldsReadOnly(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string termID = txtTermID.Text;

            if (string.IsNullOrEmpty(termID))
            {
                MessageBox.Show("Vui lòng chọn một kỳ hạn để xóa.");
                return;
            }

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "DELETE FROM LoaiKyHan WHERE MaKyHan = @MaKyHan";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaKyHan", termID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa dữ liệu: " + ex.Message);
                return;
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            LoadCurrentRegulations();
            ClearFields();
            SetFieldsReadOnly(true);
        }

        private void btnSaveTerm_Click(object sender, EventArgs e)
        {
            string termID = txtTermID.Text;
            string term = txtTerm.Text;
            string interestRate = txtInterestRate.Text;
            string minTerm = txtMinTerm.Text;

            if (string.IsNullOrEmpty(termID) || string.IsNullOrEmpty(term) || string.IsNullOrEmpty(interestRate) || string.IsNullOrEmpty(minTerm))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query;
                if (string.IsNullOrEmpty(txtTermID.Text))
                {
                    // Add new term
                    query = "INSERT INTO LoaiKyHan (MaKyHan, TenKyHan, LaiSuat, ThoiGianGoiToiThieu) VALUES (@MaKyHan, @TenKyHan, @LaiSuat, @ThoiGianGoiToiThieu)";
                }
                else
                {
                    // Update existing term
                    query = "UPDATE LoaiKyHan SET TenKyHan = @TenKyHan, LaiSuat = @LaiSuat, ThoiGianGoiToiThieu = @ThoiGianGoiToiThieu WHERE MaKyHan = @MaKyHan";
                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaKyHan", termID);
                    cmd.Parameters.AddWithValue("@TenKyHan", term);
                    cmd.Parameters.AddWithValue("@LaiSuat", interestRate);
                    cmd.Parameters.AddWithValue("@ThoiGianGoiToiThieu", minTerm);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                return;
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            LoadCurrentRegulations();
            ClearFields();
            SetFieldsReadOnly(true);
        }

        private void btnEditGlobalSettings_Click(object sender, EventArgs e)
        {
            SetGlobalSettingsReadOnly(false);
        }

        private void btnSaveGlobalSettings_Click(object sender, EventArgs e)
        {
            string minDeposit = txtMinDeposit.Text;
            string initialDeposit = txtInitialDeposit.Text;
            string minWithdraw = txtMinWithdraw.Text;

            if (string.IsNullOrEmpty(minDeposit) || string.IsNullOrEmpty(initialDeposit) || string.IsNullOrEmpty(minWithdraw))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "UPDATE GlobalSetting SET MinDeposit = @MinDeposit, InitialDeposit = @InitialDeposit, MinWithdraw = @MinWithdraw";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MinDeposit", minDeposit);
                    cmd.Parameters.AddWithValue("@InitialDeposit", initialDeposit);
                    cmd.Parameters.AddWithValue("@MinWithdraw", minWithdraw);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                return;
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            LoadGlobalSettings();
            SetGlobalSettingsReadOnly(true);
        }

        private void dgvRegulations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
