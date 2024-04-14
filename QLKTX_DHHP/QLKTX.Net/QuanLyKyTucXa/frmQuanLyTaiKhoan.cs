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
    public partial class frmQuanLyTaiKhoan : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmQuanLyTaiKhoan()
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

            String sql = "Select * from CanBo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbo_maCB.DataSource = dt;
            cbo_maCB.DisplayMember = "TenCB";
            cbo_maCB.ValueMember = "MaCB";

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Accounts";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_qlTaiKhoan.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into Accounts Values" + "(@taiKhoan, @matKhau, @maCB)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txt_matKhau.Text);
                cmd.Parameters.AddWithValue("@maCB", cbo_maCB.SelectedValue.ToString());

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                frmQuanLyTaiKhoan_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập lại tên khác!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            String sql = "Update Accounts Set matKhau = @matKhau, MaCB=@maCB Where TaiKhoan=@taiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txt_matKhau.Text);
                cmd.Parameters.AddWithValue("@maCB", cbo_maCB.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
            }

            frmQuanLyTaiKhoan_Load(sender, e);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete Accounts Where TaiKhoan=@taiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmQuanLyTaiKhoan_Load(sender, e);
        }

        private void dgv_qlTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_taiKhoan.Enabled = false;
            int row = e.RowIndex;

            txt_taiKhoan.Text = dgv_qlTaiKhoan.Rows[row].Cells[0].Value.ToString();
            txt_matKhau.Text = dgv_qlTaiKhoan.Rows[row].Cells[1].Value.ToString();
            cbo_maCB.SelectedValue = dgv_qlTaiKhoan.Rows[row].Cells[2].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
