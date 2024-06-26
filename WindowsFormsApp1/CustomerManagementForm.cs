using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class CustomerManagementForm : Form
    {
        private string databaseFile = "DATA.db";
        private string databasePath;
        private string connectionString;
        private string username; // Thêm thuộc tính username

        public CustomerManagementForm(string username)
        {
            InitializeComponent();
            this.username = username; // Lưu trữ username khi khởi tạo form

            // Khởi tạo databasePath và connectionString trong constructor
            databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, databaseFile);
            connectionString = $"Data Source={databasePath};Version=3;";
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            // Load customer data into DataGridView
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaKH, TenKH, \"CMND/CCCD\", SDT, GioiTinh, DiaChi FROM KhachHang";
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
                string customerID = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                ShowCustomerDetails(customerID);
            }
        }

        private void ShowCustomerDetails(string customerID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM khachhang WHERE MaKH = @MaKH";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", customerID);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string customerName = reader["TenKH"].ToString();
                    string cmnd = reader["CMND/CCCD"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string diaChi = reader["DiaChi"].ToString();

                    lblDetails.Text = $"Chi tiết khách hàng: \nMã: {customerID}\nTên: {customerName}\nCMND: {cmnd}\nGiới tính: {gioiTinh}\nĐịa chỉ: {diaChi}";
                    detailsPanel.Visible = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit customer
            AddCustomerForm detailForm = new AddCustomerForm();
            detailForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete customer
            string customerID = dataGridView1.SelectedRows[0].Cells["MaKH"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM khachhang WHERE MaKH = @MaKH";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", customerID);
                    cmd.ExecuteNonQuery();
                }
                LoadCustomerData(); // Refresh the data grid
                MessageBox.Show("Đã xóa khách hàng.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaKH, TenKH, \"CMND/CCCD\", DiaChi FROM khachhang WHERE MaKH LIKE @search OR TenKH LIKE @search OR \"CMND/CCCD\" LIKE @search OR DiaChi LIKE @search";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            LoadCustomerData(); // Refresh the data grid after adding new customer
        }
    }
}
