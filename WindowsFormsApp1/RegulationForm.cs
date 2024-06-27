using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class RegulationForm : Form
    {
        private string username;

        public RegulationForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentRegulations();
        }

        private void LoadCurrentRegulations()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Kỳ Hạn");
            dt.Columns.Add("Tên Kỳ Hạn");
            dt.Columns.Add("Lãi Suất");
            dt.Columns.Add("Thời Gian Gửi Tối Thiểu");

            string connectionString = "Data Source=DATA.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM LoaiKyHan";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
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
            }

            dgvRegulations.DataSource = dt;
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
            }
        }

        private void btnAddTerm_Click(object sender, EventArgs e)
        {
            txtTerm.Clear();
            txtInterestRate.Clear();
            txtMinTerm.Clear();
            txtTermID.Text = GetNextTermID();
        }

        private string GetNextTermID()
        {
            string nextID = "KH001";
            string connectionString = "Data Source=DATA.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaKyHan FROM LoaiKyHan ORDER BY MaKyHan DESC LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastID = result.ToString();
                            int idNumber = int.Parse(lastID.Substring(2)) + 1;
                            nextID = "KH" + idNumber.ToString("D3");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lấy mã kỳ hạn mới: " + ex.Message);
                }
            }
            return nextID;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text;
            string interestRate = txtInterestRate.Text;
            string minTerm = txtMinTerm.Text;
            string termID = txtTermID.Text;

            if (string.IsNullOrEmpty(term) || string.IsNullOrEmpty(interestRate) || string.IsNullOrEmpty(minTerm) || string.IsNullOrEmpty(termID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string connectionString = "Data Source=DATA.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE LoaiKyHan SET TenKyHan = @TenKyHan, LaiSuat = @LaiSuat, ThoiGianGoiToiThieu = @ThoiGianGoiToiThieu WHERE MaKyHan = @MaKyHan";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKyHan", termID);
                        cmd.Parameters.AddWithValue("@TenKyHan", term);
                        cmd.Parameters.AddWithValue("@LaiSuat", decimal.Parse(interestRate));
                        cmd.Parameters.AddWithValue("@ThoiGianGoiToiThieu", minTerm);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật dữ liệu: " + ex.Message);
                    return;
                }
            }

            LoadCurrentRegulations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string termID = txtTermID.Text;

            if (string.IsNullOrEmpty(termID))
            {
                MessageBox.Show("Vui lòng chọn một kỳ hạn để xóa.");
                return;
            }

            string connectionString = "Data Source=DATA.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM LoaiKyHan WHERE MaKyHan = @MaKyHan";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
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
            }

            LoadCurrentRegulations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string minDeposit = txtMinDeposit.Text;
            string initialDeposit = txtInitialDeposit.Text;

            if (string.IsNullOrEmpty(minDeposit) || string.IsNullOrEmpty(initialDeposit))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            GlobalSettings.MinDeposit = decimal.Parse(minDeposit);
            GlobalSettings.InitialDeposit = decimal.Parse(initialDeposit);

            MessageBox.Show("Quy định mới đã được lưu.");

            this.Close();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
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
    }
}
