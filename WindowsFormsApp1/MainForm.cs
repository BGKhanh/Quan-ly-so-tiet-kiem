using System;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class MainForm : Form
    {
        private string username;

        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = $"Xin chào {username}";
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

        private void btnOpenCloseAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnManageDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}