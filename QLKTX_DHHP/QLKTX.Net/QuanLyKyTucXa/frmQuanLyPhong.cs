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
    public partial class frmQuanLyPhong : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        String ID;
        public frmQuanLyPhong()
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

            String sql = "Select * from Phong Where MaKhu = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_qlPhong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Khu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbo_maKhu.DataSource = dt;
            cbo_maKhu.DisplayMember = "TenKhu";
            cbo_maKhu.ValueMember = "MaKhu";

            ID = cbo_maKhu.SelectedValue.ToString();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            LoadData();
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
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Mở giao dịch
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    String sql = "Insert Into Phong Values" + "(@maPhong, @maKhu, @tenPhong, @loaiPhong, @soNguoiHT, @soNguoiMax, @giaPhong)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPhong", txt_maPhong.Text);
                    cmd.Parameters.AddWithValue("@maKhu", cbo_maKhu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tenPhong", txt_tenPhong.Text);
                    cmd.Parameters.AddWithValue("@loaiPhong", txt_loaiPhong.Text);
                    cmd.Parameters.AddWithValue("@soNguoiHT", txt_soNguoiHT.Text);
                    cmd.Parameters.AddWithValue("@soNguoiMax", txt_soNguoiMax.Text);
                    cmd.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);

                    // Gán transaction cho SqlCommand
                    cmd.Transaction = transaction;

                    cmd.ExecuteNonQuery();

                    // Commit giao dịch nếu mọi thứ thành công
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi và rollback giao dịch nếu có lỗi xảy ra
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                // Load lại dữ liệu
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update Phong Set MaKhu=@maKhu, TenPhong=@tenPhong, LoaiPhong=@loaiPhong," +
                "SoNguoiHienTai=@soNguoiHT, SoNguoiToiDa=@soNguoiMax, GiaPhong=@giaPhong Where  MaPhong=@maPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Tương tự như btn_them, bạn cũng có thể sử dụng giao dịch ở đây

            cmd.Parameters.AddWithValue("@maPhong", txt_maPhong.Text);
            cmd.Parameters.AddWithValue("@maKhu", cbo_maKhu.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@tenPhong", txt_tenPhong.Text);
            cmd.Parameters.AddWithValue("@loaiPhong", txt_loaiPhong.Text);
            cmd.Parameters.AddWithValue("@soNguoiHT", txt_soNguoiHT.Text);
            cmd.Parameters.AddWithValue("@soNguoiMax", txt_soNguoiMax.Text);
            cmd.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);

            cmd.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // Tương tự như btn_them, bạn cũng có thể sử dụng giao dịch ở đây

            String sql = "Delete Phong where MaPhong = @maPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Tương tự như btn_them, bạn cũng có thể sử dụng giao dịch ở đây

            cmd.Parameters.AddWithValue("@maPhong", txt_maPhong.Text);

            cmd.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            LoadData();
        }


        private void dgv_qlPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_maPhong.Text = dgv_qlPhong.Rows[row].Cells[0].Value.ToString();
            cbo_maKhu.SelectedValue = dgv_qlPhong.Rows[row].Cells[1].Value.ToString();
            txt_tenPhong.Text = dgv_qlPhong.Rows[row].Cells[2].Value.ToString();
            txt_loaiPhong.Text = dgv_qlPhong.Rows[row].Cells[3].Value.ToString();
            txt_soNguoiHT.Text = dgv_qlPhong.Rows[row].Cells[4].Value.ToString();
            txt_soNguoiMax.Text = dgv_qlPhong.Rows[row].Cells[5].Value.ToString();
            txt_giaPhong.Text = dgv_qlPhong.Rows[row].Cells[6].Value.ToString();
        }

        private void cbo_maKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = cbo_maKhu.SelectedValue.ToString();
            LoadData();
        }
    }
}
