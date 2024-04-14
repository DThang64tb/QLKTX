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
    public partial class frmTimKiem : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmTimKiem()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        public void LoadSinhVien()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from SinhVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_searSinhVien.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void LoadPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_searchPhong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
            LoadPhong();
        }

        private void btn_searchSV_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from SinhVien Where MaSV = '" + txt_maSV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {
                MessageBox.Show("Không tìm thấy sinh viên tìm kiếm!", "Thông báo");
            }

            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_searSinhVien.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_searchPhong_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong Where TenPhong = '" + txt_tenPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {
                MessageBox.Show("Không tìm thấy phòng tìm kiếm!", "Thông báo");
            }

            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_searchPhong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
            LoadPhong();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
