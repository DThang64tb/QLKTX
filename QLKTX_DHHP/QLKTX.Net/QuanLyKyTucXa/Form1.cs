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
    public partial class Form1 : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            String taiKhoan, matKhau;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            taiKhoan = txt_taiKhoan.Text;
            matKhau = txt_matKhau.Text;

            String sql = "Select * From Accounts Where TaiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bai. Vui lòng đăng nhập lại", "Thông báo");
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
