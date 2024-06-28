using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class LoginForm : Form
    {
        private bool isFullscreen = false;
        private Rectangle previousBounds;
        private Font previousFont;
        private Size previousSize;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                if (IsLoginValid(username, password))
                {
                    MainForm mainForm = new MainForm(username);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng. Vui lòng nhập lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsLoginValid(string username, string password)
        {
            try
            {
                DatabaseManager.Instance.OpenConnection();
                string query = @"
                    SELECT MaNV, MatKhau
                    FROM NhanVien
                    WHERE MaNV = @Username AND MatKhau = @Password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ cơ sở dữ liệu nếu tìm thấy tài khoản
                            string dbUsername = reader["MaNV"].ToString();
                            string dbPassword = reader["MatKhau"].ToString();

                            // Kiểm tra xem tài khoản và mật khẩu có khớp hay không
                            if (dbUsername == username && dbPassword == password)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Logic khởi tạo cần thiết khi form load (nếu có)
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Nhập tên tài khoản")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (isFullscreen)
            {
                // Restore previous state
                this.WindowState = FormWindowState.Normal;
                this.Bounds = previousBounds;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                RestoreControlSizes();
                isFullscreen = false;
            }
            else
            {
                // Save current bounds and sizes before going fullscreen
                previousBounds = this.Bounds;
                previousFont = this.Font;
                previousSize = this.ClientSize;

                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                AdjustControlSizes();
                isFullscreen = true;
            }
        }

        private void AdjustControlSizes()
        {
            // Adjust the size and position of controls for fullscreen mode
            float scaleFactorWidth = (float)this.ClientSize.Width / previousSize.Width;
            float scaleFactorHeight = (float)this.ClientSize.Height / previousSize.Height;

            foreach (Control control in this.Controls)
            {
                control.Left = (int)(control.Left * scaleFactorWidth);
                control.Top = (int)(control.Top * scaleFactorHeight);
                control.Width = (int)(control.Width * scaleFactorWidth);
                control.Height = (int)(control.Height * scaleFactorHeight);
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * Math.Min(scaleFactorWidth, scaleFactorHeight), control.Font.Style);
            }
        }

        private void RestoreControlSizes()
        {
            // Restore the size and position of controls to their original state
            float scaleFactorWidth = (float)previousSize.Width / this.ClientSize.Width;
            float scaleFactorHeight = (float)previousSize.Height / this.ClientSize.Height;

            foreach (Control control in this.Controls)
            {
                control.Left = (int)(control.Left * scaleFactorWidth);
                control.Top = (int)(control.Top * scaleFactorHeight);
                control.Width = (int)(control.Width * scaleFactorWidth);
                control.Height = (int)(control.Height * scaleFactorHeight);
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * Math.Min(scaleFactorWidth, scaleFactorHeight), control.Font.Style);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
