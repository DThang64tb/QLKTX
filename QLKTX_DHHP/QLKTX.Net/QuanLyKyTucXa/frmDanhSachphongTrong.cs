using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKyTucXa
{
    public partial class frmDanhSachphongTrong : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmDanhSachphongTrong()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void frmDanhSachphongTrong_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong Where SoNguoiHienTai < SoNguoiToiDa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_dsPhongTrong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong Where TenPhong = @TenPhong and SoNguoiHienTai < SoNguoiToiDa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenPhong", txt_search.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Không có phòng cần tìm kiếm.", "Thông báo");
            }
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_dsPhongTrong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
