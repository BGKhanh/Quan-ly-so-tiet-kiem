using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class TransactionHistoryForm : Form
    {
        private string databaseFile = "DATA.db";
        private string databasePath;
        private string connectionString;
        private string username;

        public TransactionHistoryForm(string username)
        {
            InitializeComponent();
            this.username = username;

            databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, databaseFile);
            connectionString = $"Data Source={databasePath};Version=3;";
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaGD, LoaiGiaoDich, MaKH, MaSo, MaNV, NgayGiaoDich, SoTien FROM GiaoDich";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
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
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TransactionID", transactionID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                detailsDataGridView.DataSource = dt;
                detailsPanel.Visible = true;
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

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = $@"SELECT 
                                    MaGD, LoaiGiaoDich, MaKH, MaSo, MaNV, NgayGiaoDich, SoTien
                                FROM GiaoDich
                                WHERE {searchField} LIKE @SearchValue";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
