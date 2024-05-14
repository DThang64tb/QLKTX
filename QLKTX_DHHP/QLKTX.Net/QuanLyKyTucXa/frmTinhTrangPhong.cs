using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class frmTinhTrangPhong : Form
    {
        private string connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        private SqlConnection conn;

        public frmTinhTrangPhong()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmTinhTrangPhong_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private int KiemTraTinhTrangPhong(string tenPhong)
        {
            int tinhTrang = -1; // Mặc định tình trạng không xác định

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Truy vấn để lấy SoNguoiHienTai và SoNguoiToiDa từ bảng Phong
                string sqlQuery = $"SELECT SoNguoiHienTai, SoNguoiToiDa FROM Phong WHERE TenPhong = '{tenPhong}'";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int soNguoiHienTai = Convert.ToInt32(dr["SoNguoiHienTai"]);
                    int soNguoiToiDa = Convert.ToInt32(dr["SoNguoiToiDa"]);

                    if (soNguoiHienTai < soNguoiToiDa)
                    {
                        tinhTrang = 0; // Phòng còn trống
                    }
                    else
                    {
                        tinhTrang = 1; // Phòng đã đầy
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return tinhTrang;
        }

        private void LoadDataToComboBox()
        {

        }


        private void tinhtrangphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = tinhtrangphong.SelectedItem.ToString();
            LoadDataToDataGridView(selectedValue);
        }

        private void LoadDataToDataGridView(string selectedValue)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Lấy danh sách phòng theo tình trạng được chọn
                string sql = "";
                if (selectedValue == "Còn Trống")
                {
                    sql = "SELECT * FROM Phong WHERE SoNguoiHienTai < SoNguoiToiDa";
                }
                else
                {
                    sql = "SELECT * FROM Phong WHERE SoNguoiHienTai >= SoNguoiToiDa";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                dgv_TinhTrangPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
