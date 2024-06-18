using System;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class OpenNewPassbookForm : Form
    {
        public OpenNewPassbookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string initialDeposit = txtInitialDeposit.Text;
            string term = txtTerm.Text;
            string interestRate = txtInterestRate.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(initialDeposit) || string.IsNullOrEmpty(term) || string.IsNullOrEmpty(interestRate))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Save the new saving account (implementation depends on your data storage)
            // For now, we just show a message box
            MessageBox.Show($"Sổ tiết kiệm mới đã được mở:\nTên khách hàng: {customerName}\nSố tiền gửi: {initialDeposit}\nKỳ hạn: {term}\nLãi suất: {interestRate}%");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
