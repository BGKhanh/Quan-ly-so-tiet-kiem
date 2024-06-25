using System;
using System.Windows.Forms;
using System.Data;

namespace BankManagement
{
    public partial class RegulationForm : Form
    {
        private string username; // Thêm thuộc tính username

        public RegulationForm(string username) // Thay đổi constructor để nhận username
        {
            InitializeComponent();
            this.username = username; // Lưu trữ username khi khởi tạo form
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text;
            string interestRate = txtInterestRate.Text;
            string minDeposit = txtMinDeposit.Text;
            string minDuration = txtMinDuration.Text;

            if (string.IsNullOrEmpty(term) || string.IsNullOrEmpty(interestRate) || string.IsNullOrEmpty(minDeposit) || string.IsNullOrEmpty(minDuration))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Save the new regulations (implementation depends on your data storage)
            // For now, we just show a message box
            MessageBox.Show($"Quy định mới đã được lưu: \nKỳ hạn: {term}\nLãi suất: {interestRate}%\nTiền gửi tối thiểu: {minDeposit}\nThời gian gửi tối thiểu: {minDuration} tháng");

            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username); // Truyền username vào MainForm
            mainForm.Show();
        }

        private void RegulationForm_Load(object sender, EventArgs e)
        {
            LoadCurrentRegulations();
        }

        private void LoadCurrentRegulations()
        {
            // Load current regulations into DataGridView
            // For demo purposes, we will add some dummy data
            DataTable dt = new DataTable();
            dt.Columns.Add("RegulationID");
            dt.Columns.Add("Description");
            dt.Columns.Add("Value");

            dt.Rows.Add("QĐ1", "Số lượng các loại kỳ hạn", "5");
            dt.Rows.Add("QĐ1", "Tiền gửi tối thiểu", "1000000");
            dt.Rows.Add("QĐ3", "Thời gian gửi tối thiểu", "6");
            dt.Rows.Add("QĐ3", "Lãi suất kỳ hạn 6 tháng", "5%");
            dt.Rows.Add("QĐ3", "Lãi suất kỳ hạn 12 tháng", "7%");

            dgvRegulations.DataSource = dt;
        }
    }
}
