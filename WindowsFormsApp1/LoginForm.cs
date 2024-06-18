using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class LoginForm : Form
    {
        // Tạo danh sách tài khoản quản lý mẫu cho mục đích kiểm tra đăng nhập
        private Dictionary<string, string> adminAccounts = new Dictionary<string, string>
        {
            { "admin", "password" }, // Tài khoản mẫu: username "admin" và password "password"
            // Bạn có thể thêm các tài khoản khác ở đây
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (adminAccounts.ContainsKey(username) && adminAccounts[username] == password)
            {
                // Nếu tài khoản hợp lệ, mở MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Ẩn LoginForm sau khi mở MainForm
            }
            else
            {
                // Nếu tài khoản không hợp lệ, hiển thị thông báo lỗi
                MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng. Vui lòng nhập lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!adminAccounts.ContainsKey(username))
            {
                adminAccounts[username] = password;
                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay bây giờ.", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProjectName_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}