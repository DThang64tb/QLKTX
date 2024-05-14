using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class frmthongke : Form
    {
        private string connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        private SqlConnection conn;

        public frmthongke()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            // Phương thức này có thể được sử dụng để khởi tạo các thành phần nếu cần khi tải
        }

        private void FetchElectricityBillStatistics(DateTime fromDate, DateTime toDate)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Truy vấn SQL để lấy số liệu thống kê hóa đơn tiền điện trong phạm vi ngày đã chỉ định
                string sql = @"
                    SELECT MaPhong, SUM(ThanhTienDien) AS TongTienDien
                    FROM HDDienNuoc
                    WHERE Thang BETWEEN @fromDate AND @toDate
                    GROUP BY MaPhong";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Tính tổng giá trị của cột TongTienDien
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["TongTienDien"]);
                }

                // Thêm hàng tổng cộng vào DataTable
                DataRow totalRow = dt.NewRow();
                totalRow["MaPhong"] = "Tổng cộng";
                totalRow["TongTienDien"] = total;
                dt.Rows.Add(totalRow);

                dgv_thongke.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            // Lấy ngày bắt đầu và ngày kết thúc từ điều khiển DateTimePicker
            DateTime fromDate = dtpThongKeTu.Value;
            DateTime toDate = dtpThongKeDen.Value;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy và hiển thị số liệu thống kê hóa đơn tiền điện
            FetchElectricityBillStatistics(fromDate, toDate);
        }

        private void dgv_thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtpThongKeTu_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpThongKeDen_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
