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
    public partial class frmQuanLyCanBo : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmQuanLyCanBo()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void frmQuanLyCanBo_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from CanBo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_qlCanBo.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                Boolean gt;
                if (chk_Nam.Checked)
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }
                String sql = "Insert Into CanBo Values" + "(@maCB, @tenCB, @ngaySinh, @gioiTinh,@chucVu, @diaChi, @soDT)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@maCB", txt_maCB.Text);
                cmd.Parameters.AddWithValue("@tenCB", txt_tenCB.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dtp_ngaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gioiTinh", gt);
                cmd.Parameters.AddWithValue("@chucVu", txt_chucVu.Text);
                cmd.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@soDT", txt_SDT.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                frmQuanLyCanBo_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã cán bộ đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Boolean gt;
            if (chk_Nam.Checked)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            String sql = "Update CanBo Set TenCB=@tenCB, NgaySinh=@ngaySinh, GioiTinh=@gioiTinh, ChucVu=@chucVu, DiaChi=@diaChi, SDT=@soDT Where MaCB=@maCB";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maCB", txt_maCB.Text);
                cmd.Parameters.AddWithValue("@tenCB", txt_tenCB.Text);
                cmd.Parameters.AddWithValue("@ngaySinh", dtp_ngaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gioiTinh", gt);
                cmd.Parameters.AddWithValue("@chucVu", txt_chucVu.Text);
                cmd.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@soDT", txt_SDT.Text); 

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmQuanLyCanBo_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete CanBo Where MaCB=@maCB";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maCB", txt_maCB.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmQuanLyCanBo_Load(sender, e);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from CanBo Where TenCB = '"+txt_search.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows == false)
            {
                MessageBox.Show("Không tìm thấy cán bộ", "Thông báo");
            }
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_qlCanBo.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void dgv_qlCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_maCB.Text = dgv_qlCanBo.Rows[row].Cells[0].Value.ToString();
            txt_tenCB.Text = dgv_qlCanBo.Rows[row].Cells[1].Value.ToString();
            dtp_ngaySinh.Value = DateTime.Parse(dgv_qlCanBo.Rows[row].Cells[2].Value.ToString());
            if (dgv_qlCanBo.Rows[row].Cells[3].Value.Equals(true))
            {
                chk_Nam.Checked = true;
            }
            else
            {
                chk_Nam.Checked = false;
            }
            txt_chucVu.Text = dgv_qlCanBo.Rows[row].Cells[4].Value.ToString();
            txt_diaChi.Text = dgv_qlCanBo.Rows[row].Cells[5].Value.ToString();
            txt_SDT.Text = dgv_qlCanBo.Rows[row].Cells[6].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
