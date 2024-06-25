using System;
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
            this.Text = "Welcome, " + _username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Quay lại màn hình đăng nhập khi người dùng nhấn đăng xuất
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
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm(_username);
            transactionHistoryForm.Show();
        }

        private void btnChangeRegulations_Click(object sender, EventArgs e)
        {
            RegulationForm regulationForm = new RegulationForm(_username);
            regulationForm.Show();
        }

        private void btnOpenCloseAccount_Click(object sender, EventArgs e)
        {
            PassbookManagementForm passbookManagementForm = new PassbookManagementForm(_username);
            passbookManagementForm.Show();
        }

        private void btnManageDatabase_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            frmDangKyNV addEmployeeForm = new frmDangKyNV();
            addEmployeeForm.Show();
        }
    }
}
