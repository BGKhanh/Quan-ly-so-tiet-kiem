using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class ReportForm : Form
    {
        string username;

        public ReportForm(string username)
        {
            InitializeComponent();
            this.username = username;
            cbPeriodTypeSales.SelectedIndexChanged += new EventHandler(cbPeriodTypeSales_SelectedIndexChanged);
            cbPeriodTypeSavings.SelectedIndexChanged += new EventHandler(cbPeriodTypeSavings_SelectedIndexChanged);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cbPeriodTypeSales.SelectedIndex = 0;
            cbPeriodTypeSavings.SelectedIndex = 0;
            txtPeriodSales.Text = "dd/MM/yyyy";
            txtPeriodSavings.Text = "dd/MM/yyyy";
            lblSalesReport.Text = "Báo cáo Doanh Số Hoạt Động Ngày";
            lblSavingsReport.Text = "Báo cáo Mở/Đóng Sổ Tháng";
        }

        private void cbPeriodTypeSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPeriodTypeSales.SelectedItem.ToString())
            {
                case "Ngày":
                    txtPeriodSales.Text = "dd/MM/yyyy";
                    break;
                case "Tháng":
                    txtPeriodSales.Text = "MM/yyyy";
                    break;
                case "Quý":
                    txtPeriodSales.Text = "Q1/Q2/Q3/Q4-yyyy";
                    break;
                case "Năm":
                    txtPeriodSales.Text = "yyyy";
                    break;
            }
        }

        private void cbPeriodTypeSavings_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPeriodTypeSavings.SelectedItem.ToString())
            {
                case "Ngày":
                    txtPeriodSavings.Text = "dd/MM/yyyy";
                    break;
                case "Tháng":
                    txtPeriodSavings.Text = "MM/yyyy";
                    break;
                case "Quý":
                    txtPeriodSavings.Text = "Q1/Q2/Q3/Q4-yyyy";
                    break;
                case "Năm":
                    txtPeriodSavings.Text = "yyyy";
                    break;
            }
        }

        private void txtPeriodSales_GotFocus(object sender, EventArgs e)
        {
            txtPeriodSales.Text = "";
        }

        private void txtPeriodSales_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPeriodSales.Text))
            {
                switch (cbPeriodTypeSales.SelectedItem.ToString())
                {
                    case "Ngày":
                        txtPeriodSales.Text = "dd/MM/yyyy";
                        break;
                    case "Tháng":
                        txtPeriodSales.Text = "MM/yyyy";
                        break;
                    case "Quý":
                        txtPeriodSales.Text = "Q1/Q2/Q3/Q4-yyyy";
                        break;
                    case "Năm":
                        txtPeriodSales.Text = "yyyy";
                        break;
                }
            }
        }

        private void txtPeriodSavings_GotFocus(object sender, EventArgs e)
        {
            txtPeriodSavings.Text = "";
        }

        private void txtPeriodSavings_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPeriodSavings.Text))
            {
                switch (cbPeriodTypeSavings.SelectedItem.ToString())
                {
                    case "Ngày":
                        txtPeriodSavings.Text = "dd/MM/yyyy";
                        break;
                    case "Tháng":
                        txtPeriodSavings.Text = "MM/yyyy";
                        break;
                    case "Quý":
                        txtPeriodSavings.Text = "Q1/Q2/Q3/Q4-yyyy";
                        break;
                    case "Năm":
                        txtPeriodSavings.Text = "yyyy";
                        break;
                }
            }
        }

        private void btnGenerateSalesReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport(cbPeriodTypeSales.SelectedItem.ToString(), txtPeriodSales.Text);
        }

        private void btnGenerateSavingsReport_Click(object sender, EventArgs e)
        {
            LoadSavingsReport(cbPeriodTypeSavings.SelectedItem.ToString(), txtPeriodSavings.Text);
        }

        private void LoadSalesReport(string periodType, string periodValue)
        {
            string query = "SELECT LoaiKyHan.TenKyHan AS LoaiKyHan, " +
                           "SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Thu' THEN GiaoDich.SoTien ELSE 0 END) AS TongThu, " +
                           "SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Chi' THEN GiaoDich.SoTien ELSE 0 END) AS TongChi, " +
                           "(SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Thu' THEN GiaoDich.SoTien ELSE 0 END) - " +
                           "SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Chi' THEN GiaoDich.SoTien ELSE 0 END)) AS ChenhLech " +
                           "FROM GiaoDich " +
                           "JOIN SoTietKiem ON GiaoDich.MaSo = SoTietKiem.MaSo " +
                           "JOIN LoaiKyHan ON SoTietKiem.MaKyHan = LoaiKyHan.MaKyHan";

            string whereClause = GetWhereClause(periodType, periodValue, "GiaoDich.NgayGiaoDich");
            if (!string.IsNullOrEmpty(whereClause))
            {
                query += " WHERE " + whereClause;
            }

            query += " GROUP BY LoaiKyHan.TenKyHan";

            try
            {
                DatabaseManager.Instance.OpenConnection();
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSalesReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải báo cáo doanh thu: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }

        private void LoadSavingsReport(string periodType, string periodValue)
        {
            string query = "SELECT " +
                           "CASE " +
                           "WHEN @periodType = 'Ngày' THEN strftime('%Y-%m-%d', SoTietKiem.NgayLapSo) " +
                           "WHEN @periodType = 'Tháng' THEN strftime('%Y-%m', SoTietKiem.NgayLapSo) " +
                           "WHEN @periodType = 'Quý' THEN 'Q' || ((strftime('%m', SoTietKiem.NgayLapSo)-1) / 3 + 1) || '-' || strftime('%Y', SoTietKiem.NgayLapSo) " +
                           "ELSE strftime('%Y', SoTietKiem.NgayLapSo) END AS Ngay, " +
                           "COUNT(CASE WHEN SoTietKiem.TinhTrang = 1 THEN 1 ELSE NULL END) AS SoSoMo, " +
                           "COUNT(CASE WHEN SoTietKiem.TinhTrang = 0 THEN 1 ELSE NULL END) AS SoSoDong, " +
                           "(COUNT(CASE WHEN SoTietKiem.TinhTrang = 1 THEN 1 ELSE NULL END) - COUNT(CASE WHEN SoTietKiem.TinhTrang = 0 THEN 1 ELSE NULL END)) AS ChenhLech " +
                           "FROM SoTietKiem";

            string whereClause = GetWhereClause(periodType, periodValue, "SoTietKiem.NgayLapSo");
            if (!string.IsNullOrEmpty(whereClause))
            {
                query += " WHERE " + whereClause;
            }

            query += " GROUP BY Ngay";

            try
            {
                DatabaseManager.Instance.OpenConnection();
                using (SQLiteCommand cmd = new SQLiteCommand(query, DatabaseManager.Instance.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@periodType", periodType);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSavingsReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải báo cáo tiết kiệm: " + ex.Message);
            }
            finally
            {
                DatabaseManager.Instance.CloseConnection();
            }
        }

        private string GetWhereClause(string periodType, string periodValue, string dateColumn)
        {
            if (string.IsNullOrWhiteSpace(periodValue))
                return "";

            switch (periodType)
            {
                case "Ngày":
                    return $"{dateColumn} = '{periodValue}'";
                case "Tháng":
                    if (periodValue.Length == 7) // "YYYY-MM"
                    {
                        return $"strftime('%m', {dateColumn}) = '{periodValue.Substring(5, 2)}' AND strftime('%Y', {dateColumn}) = '{periodValue.Substring(0, 4)}'";
                    }
                    break;
                case "Quý":
                    string[] quarterParts = periodValue.Split('-');
                    if (quarterParts.Length == 2)
                    {
                        int quarter = int.Parse(quarterParts[0].Substring(1));
                        string year = quarterParts[1];
                        return $"strftime('%Y', {dateColumn}) = '{year}' AND ((strftime('%m', {dateColumn})-1) / 3 + 1) = {quarter}";
                    }
                    break;
                case "Năm":
                    return $"strftime('%Y', {dateColumn}) = '{periodValue}'";
            }

            return "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm(username);
            main.Show();
        }

        private void dgvSavingsReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSavingsReport_Click(object sender, EventArgs e)
        {

        }
    }
}
