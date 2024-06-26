using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class ReportForm : Form
    {
        private string connectionString = "Data Source=DATA.db;Version=3;";

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Bạn có thể load dữ liệu khi form load nếu cần thiết
        }

        private void btnGenerateBM51_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerBM51.Value;
            LoadBM51Report(selectedDate);
        }

        private void btnGenerateBM52_Click(object sender, EventArgs e)
        {
            string selectedLoaiTietKiem = cbLoaiTietKiemBM52.SelectedItem.ToString();
            DateTime selectedMonth = dateTimePickerBM52.Value;
            LoadBM52Report(selectedLoaiTietKiem, selectedMonth);
        }

        private void LoadBM51Report(DateTime date)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT STT, LoaiTietKiem, TongThu, TongChi, (TongThu - TongChi) AS ChenhLech FROM BM51 WHERE Ngay = @Ngay";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ngay", date);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBM51.DataSource = dt;
            }
        }

        private void LoadBM52Report(string loaiTietKiem, DateTime month)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT STT, Ngay, SoSoMo, SoSoDong, (SoSoMo - SoSoDong) AS ChenhLech FROM BM52 WHERE LoaiTietKiem = @LoaiTietKiem AND strftime('%m', Ngay) = @Month AND strftime('%Y', Ngay) = @Year";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoaiTietKiem", loaiTietKiem);
                cmd.Parameters.AddWithValue("@Month", month.ToString("MM"));
                cmd.Parameters.AddWithValue("@Year", month.ToString("yyyy"));

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBM52.DataSource = dt;
            }
        }
    }
}
