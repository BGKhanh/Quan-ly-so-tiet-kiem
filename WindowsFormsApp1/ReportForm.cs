using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class ReportForm : Form
    {
        string username;
        private string connectionString = "Data Source=DATA.db;Version=3;";

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
            string query = "SELECT LoaiKyHan.TenKyHan AS TenKyHan, " +
                           "COUNT(CASE WHEN SoTietKiem.TrangThai = 'Mo' THEN 1 ELSE NULL END) AS SoSoMo, " +
                           "COUNT(CASE WHEN SoTietKiem.TrangThai = 'Dong' THEN 1 ELSE NULL END) AS SoSoDong, " +
                           "(COUNT(CASE WHEN SoTietKiem.TrangThai = 'Mo' THEN 1 ELSE NULL END) - COUNT(CASE WHEN SoTietKiem.TrangThai = 'Dong' THEN 1 ELSE NULL END)) AS ChenhLech " +
                           "FROM SoTietKiem " +
                           "JOIN LoaiKyHan ON SoTietKiem.MaKyHan = LoaiKyHan.MaKyHan";

            string whereClause = GetWhereClause(periodType, periodValue);
            if (!string.IsNullOrEmpty(whereClause))
            {
                query += " WHERE " + whereClause;
            }

            query += " GROUP BY LoaiKyHan.TenKyHan";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSalesReport.DataSource = dt;
            }
        }

        private void LoadSavingsReport(string periodType, string periodValue)
        {
            string query = "SELECT " +
                           "CASE " +
                           "WHEN @periodType = 'Ngày' THEN strftime('%Y-%m-%d', NgayGiaoDich) " +
                           "WHEN @periodType = 'Tháng' THEN strftime('%Y-%m', NgayGiaoDich) " +
                           "WHEN @periodType = 'Quý' THEN 'Q' || ((strftime('%m', NgayGiaoDich)-1) / 3 + 1) || '-' || strftime('%Y', NgayGiaoDich) " +
                           "ELSE strftime('%Y', NgayGiaoDich) END AS NgayThangQuyNam, " +
                           "SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Goi' THEN 1 ELSE 0 END) AS SoSoMo, " +
                           "SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Rut' THEN 1 ELSE 0 END) AS SoSoDong, " +
                           "(SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Goi' THEN 1 ELSE 0 END) - SUM(CASE WHEN GiaoDich.LoaiGiaoDich = 'Rut' THEN 1 ELSE 0 END)) AS ChenhLech " +
                           "FROM GiaoDich " +
                           "JOIN SoTietKiem ON GiaoDich.MaSo = SoTietKiem.MaSo ";
            string whereClause = GetWhereClause(periodType, periodValue);

            if (!string.IsNullOrEmpty(whereClause))
            {
                query += " WHERE " + whereClause;
            }

            query += " GROUP BY NgayThangQuyNam";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@periodType", periodType);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSavingsReport.DataSource = dt;
            }
        }

        private string GetWhereClause(string periodType, string periodValue)
        {
            if (string.IsNullOrWhiteSpace(periodValue))
                return "";

            switch (periodType)
            {
                case "Ngày":
                    return $"NgayGiaoDich = '{periodValue}'";
                case "Tháng":
                    if (periodValue.Length == 7) // "YYYY-MM"
                    {
                        return $"strftime('%m', NgayGiaoDich) = '{periodValue.Substring(5, 2)}' AND strftime('%Y', NgayGiaoDich) = '{periodValue.Substring(0, 4)}'";
                    }
                    break;
                case "Quý":
                    string[] months = GetQuarterMonths(periodValue);
                    if (months.Length > 0)
                    {
                        return $"strftime('%m', NgayGiaoDich) IN ({string.Join(",", months)})";
                    }
                    break;
                case "Năm":
                    if (periodValue.Length == 4) // "YYYY"
                    {
                        return $"strftime('%Y', NgayGiaoDich) = '{periodValue}'";
                    }
                    break;
                default:
                    return "";
            }
            return "";
        }

        private string[] GetQuarterMonths(string quarter)
        {
            switch (quarter)
            {
                case "Q1":
                    return new string[] { "'01'", "'02'", "'03'" };
                case "Q2":
                    return new string[] { "'04'", "'05'", "'06'" };
                case "Q3":
                    return new string[] { "'07'", "'08'", "'09'" };
                case "Q4":
                    return new string[] { "'10'", "'11'", "'12'" };
                default:
                    return new string[0];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }
    }
}
