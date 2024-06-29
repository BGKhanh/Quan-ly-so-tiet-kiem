using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class TransactionForm : Form
    {
        string username;
        public TransactionForm(string username)
        {
            InitializeComponent();
            lblTransactionIDValue.Text = GenerateTransactionID();
            lblTransactionDateValue.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.username = username;
        }

        private string GenerateTransactionID()
        {
            return "GD" + DateTime.Now.ToString("yyyyMMdd");
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT TenKH, [CMND/CCCD] FROM KhachHang WHERE MaKH = @MaKH";
                SQLiteParameter[] parameters = { new SQLiteParameter("@MaKH", txtCustomerID.Text.Trim()) };
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtCustomerName.Text = reader["TenKH"].ToString();
                        txtIDCard.Text = reader["CMND/CCCD"].ToString();
                        LoadPassbookIDs(txtCustomerID.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPassbookIDs(string customerID)
        {
            try
            {
                string query = "SELECT MaSo FROM SoTietKiem WHERE MaKH = @MaKH";
                SQLiteParameter[] parameters = { new SQLiteParameter("@MaKH", customerID) };
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query, parameters))
                {
                    cbPassbookID.Items.Clear();
                    while (reader.Read())
                    {
                        cbPassbookID.Items.Add(reader["MaSo"].ToString());
                    }
                    if (cbPassbookID.Items.Count > 0)
                    {
                        cbPassbookID.SelectedIndex = 0;
                    }
                    else
                    {
                        txtPassbookType.Text = string.Empty;
                        txtRemainingTime.Text = string.Empty;
                        txtBalance.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPassbookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT MaKyHan, JULIANDAY(NgayDongSo) - JULIANDAY('now') AS ThoiGianConLai, SoDu FROM SoTietKiem WHERE MaSo = @MaSo";
                SQLiteParameter[] parameters = { new SQLiteParameter("@MaSo", cbPassbookID.SelectedItem.ToString()) };
                using (SQLiteDataReader reader = DatabaseManager.Instance.ExecuteQuery(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtPassbookType.Text = reader["MaKyHan"].ToString();
                        txtRemainingTime.Text = reader["ThoiGianConLai"].ToString();
                        txtBalance.Text = reader["SoDu"].ToString();
                    }
                    else
                    {
                        txtPassbookType.Text = string.Empty;
                        txtRemainingTime.Text = string.Empty;
                        txtBalance.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string transactionID = lblTransactionIDValue.Text;
                string transactionDate = lblTransactionDateValue.Text;
                string customerID = txtCustomerID.Text.Trim();
                string passbookID = cbPassbookID.SelectedItem.ToString();
                string transactionType = cbTransactionType.SelectedItem.ToString();
                decimal amount = decimal.Parse(txtAmount.Text.Trim());
                string employeeID = "NV123"; // Replace with actual employee ID from session or context

                string query1 = "INSERT INTO GiaoDich (MaGD, NgayGiaoDich, MaKH, MaSo, MaNV, LoaiGiaoDich, SoTien) VALUES (@MaGD, @NgayGiaoDich, @MaKH, @MaSo, @MaNV, @LoaiGiaoDich, @SoTien)";
                SQLiteParameter[] parameters1 =
                {
                    new SQLiteParameter("@MaGD", transactionID),
                    new SQLiteParameter("@NgayGiaoDich", transactionDate),
                    new SQLiteParameter("@MaKH", customerID),
                    new SQLiteParameter("@MaSo", passbookID),
                    new SQLiteParameter("@MaNV", employeeID),
                    new SQLiteParameter("@LoaiGiaoDich", transactionType),
                    new SQLiteParameter("@SoTien", amount)
                };
                DatabaseManager.Instance.ExecuteNonQuery(query1, parameters1);

                string query2 = "UPDATE SoTietKiem SET SoDu = SoDu + @SoTien WHERE MaSo = @MaSo";
                if (transactionType == "Rut")
                {
                    query2 = "UPDATE SoTietKiem SET SoDu = SoDu - @SoTien WHERE MaSo = @MaSo";
                }
                SQLiteParameter[] parameters2 =
                {
                    new SQLiteParameter("@SoTien", amount),
                    new SQLiteParameter("@MaSo", passbookID)
                };
                DatabaseManager.Instance.ExecuteNonQuery(query2, parameters2);

                MessageBox.Show("Giao dịch thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm(username);
            main.Show();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
