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
    public partial class frmDanhSachSinhVienTheoPhong : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        String ID;
        public frmDanhSachSinhVienTheoPhong()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }
        public void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select MaSV, TenSV, Lop, Khoa from HopDongThue where MaPhong = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_danhSach.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void frmDanhSachSinhVienTheoPhong_Load(object sender, EventArgs e)
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

            cbo_phong.DataSource = dt;
            cbo_phong.DisplayMember = "TenPhong";
            cbo_phong.ValueMember = "MaPhong";

            ID = cbo_phong.SelectedValue.ToString();
            LoadData();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void cbo_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = cbo_phong.SelectedValue.ToString();
            LoadData();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
