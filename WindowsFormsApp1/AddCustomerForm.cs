using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class AddCustomerForm : Form
    {
        private string connectionString = "Data Source=Passbook_data.db;Version=3;";

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string cmnd = txtCMND.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text;
            string matKhau = txtMatKhau.Text;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO khachhang (TenKH, CMND, GioiTinh, DiaChi, MatKhau) VALUES (@TenKH, @CMND, @GioiTinh, @DiaChi, @MatKhau)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKH", customerName);
                cmd.Parameters.AddWithValue("@CMND", cmnd);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đăng ký khách hàng thành công.");
            this.Close();
        }
    }
}
