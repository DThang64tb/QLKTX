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
    public partial class frmQuanLySinhVien : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
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

            dgv_qlSinhVien.DataSource = dt;
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean gt;

                if (chk_nam.Checked)
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into SinhVien Values" + "(@maSV, @tenSV, @ngaySinh, @gioiTinh, @diaChi, @soDT, @lop, @khoasHoc, @khoa)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dtp_ngaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gioiTinh", gt);
                cmd.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@soDT", txt_soDT.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoasHoc", txt_khoas.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                frmQuanLySinhVien_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Boolean gt;

            if (chk_nam.Checked)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update SinhVien Set TenSV=@tenSV, NgaySinh=@ngaySinh, GioiTinh=@gioiTinh, DiaChi=@diaChi, SDT=@soDT, " +
                "Lop=@lop, KhoasHoc=@khoasHoc, Khoa=@khoa Where MaSV=@maSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dtp_ngaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gioiTinh", gt);
                cmd.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@soDT", txt_soDT.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoasHoc", txt_khoas.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmQuanLySinhVien_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Boolean gt;

            if (chk_nam.Checked)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete SinhVien Where MaSV=@maSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmQuanLySinhVien_Load(sender, e);
        }

        private void dgv_qlSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_maSV.Text = dgv_qlSinhVien.Rows[row].Cells[0].Value.ToString();
            txt_tenSV.Text = dgv_qlSinhVien.Rows[row].Cells[1].Value.ToString();
            dtp_ngaySinh.Text = dgv_qlSinhVien.Rows[row].Cells[2].Value.ToString();
            if (dgv_qlSinhVien.Rows[row].Cells[3].Value.Equals(true))
            {
                chk_nam.Checked = true;
            }
            else
            {
                chk_nam.Checked = false;
            }
            txt_diaChi.Text = dgv_qlSinhVien.Rows[row].Cells[4].Value.ToString();
            txt_soDT.Text = dgv_qlSinhVien.Rows[row].Cells[5].Value.ToString();
            txt_lop.Text = dgv_qlSinhVien.Rows[row].Cells[6].Value.ToString();
            txt_khoas.Text = dgv_qlSinhVien.Rows[row].Cells[7].Value.ToString();
            txt_khoa.Text = dgv_qlSinhVien.Rows[row].Cells[8].Value.ToString();
        }
    }
}
