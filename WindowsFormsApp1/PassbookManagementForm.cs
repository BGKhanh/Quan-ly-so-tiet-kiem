using System;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class PassbookManagementForm : Form
    {
        public PassbookManagementForm()
        {
            InitializeComponent();
            LoadSavingAccounts();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnOpenNewAccount_Click(object sender, EventArgs e)
        {
            OpenNewPassbookForm openNewPassbookForm = new OpenNewPassbookForm();
            openNewPassbookForm.Show();
        }

        private void dgvSavingAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSavingAccounts.Rows[e.RowIndex];
                // Handle cell content click if necessary
            }
        }

        private void LoadSavingAccounts()
        {
            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Sổ", typeof(string));
            dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
            dataTable.Columns.Add("Số Dư", typeof(decimal));
            dataTable.Columns.Add("Kỳ Hạn", typeof(string));
            dataTable.Columns.Add("Lãi Suất", typeof(decimal));

            dataTable.Rows.Add("SA001", "Nguyễn Văn A", 1000000, "12 tháng", 6.5);
            dataTable.Rows.Add("SA002", "Trần Thị B", 500000, "6 tháng", 5.0);

            dgvSavingAccounts.DataSource = dataTable;
        }

        private void PassbookManagementForm_Load(object sender, EventArgs e)
        {
            // Add any additional initialization code here
        }
    }
}