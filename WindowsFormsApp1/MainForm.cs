using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class MainForm : Form
    {
        private string _username;

        public MainForm(string username)
        {
            InitializeComponent();
            _username = username;
            string employeeName = GetEmployeeName(_username);
            lblWelcome.Text += employeeName;
        }

        private string GetEmployeeName(string employeeCode)
        {
            string employeeName = string.Empty;

            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = "SELECT TenNV FROM NhanVien WHERE MaNV = @EmployeeCode";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeName = reader["TenNV"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy tên nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }

            return employeeName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerManagementForm = new CustomerManagementForm(_username);
            customerManagementForm.Show();
            this.Close();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm(_username);
            transactionHistoryForm.Show();
            this.Close();
        }

        private void btnChangeRegulations_Click(object sender, EventArgs e)
        {
            RegulationForm regulationForm = new RegulationForm(_username);
            regulationForm.Show();
            this.Close();
        }

        private void btnOpenCloseAccount_Click(object sender, EventArgs e)
        {
            PassbookManagementForm passbookManagementForm = new PassbookManagementForm(_username);
            passbookManagementForm.Show();
            this.Close();
        }

        private void btnManageDatabase_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(_username);
            transactionForm.Show();
            this.Close();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            frmDangKyNV addEmployeeForm = new frmDangKyNV(_username);
            addEmployeeForm.Show();
            this.Close();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(_username);
            reportForm.Show();
            this.Close();
        }
    }
}
