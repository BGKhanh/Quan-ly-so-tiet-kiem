using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class TransactionHistoryForm : Form
    {
        private string username;

        public TransactionHistoryForm(string username)
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

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            LoadTransactionData();
        }

        private void LoadTransactionData()
        {
            try
            {
                string query = "SELECT MaGD, LoaiGiaoDich, MaKH, MaSo, MaNV, NgayGiaoDich, SoTien FROM GiaoDich";
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string transactionID = dataGridView1.Rows[e.RowIndex].Cells["MaGD"].Value.ToString();
                LoadTransactionDetails(transactionID);
            }
        }

        private void LoadTransactionDetails(string transactionID)
        {
            try
            {
                string query = $@"SELECT 
                                    G.MaGD, G.LoaiGiaoDich, G.NgayGiaoDich, G.SoTien,
                                    KH.MaKH, KH.TenKH, KH.[CMND/CCCD], KH.SDT, KH.GioiTinh, KH.DiaChi,
                                    NV.MaNV, NV.TenNV, NV.ChucVu,
                                    STK.MaSo, STK.SoDu, STK.NgayLapSo,
                                    LK.MaKyHan, LK.TenKyHan, LK.LaiSuat, LK.ThoiGianGoiToiThieu
                                FROM GiaoDich G
                                JOIN KhachHang KH ON G.MaKH = KH.MaKH
                                JOIN NhanVien NV ON G.MaNV = NV.MaNV
                                JOIN SoTietKiem STK ON G.MaSo = STK.MaSo
                                JOIN LoaiKyHan LK ON STK.MaKyHan = LK.MaKyHan
                                WHERE G.MaGD = @TransactionID";
                SQLiteParameter[] parameters = { new SQLiteParameter("@TransactionID", transactionID) };
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    detailsDataGridView.DataSource = dt;
                    detailsPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = $@"SELECT 
                                    MaGD, LoaiGiaoDich, MaKH, MaSo, MaNV, NgayGiaoDich, SoTien
                                FROM GiaoDich
                                WHERE {searchField} LIKE @SearchValue";
                SQLiteParameter[] parameters = { new SQLiteParameter("@SearchValue", "%" + searchValue + "%") };
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
