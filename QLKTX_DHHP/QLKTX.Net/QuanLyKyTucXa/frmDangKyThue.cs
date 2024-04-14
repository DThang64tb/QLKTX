using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
    public partial class frmDangKyThue : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;

        public frmDangKyThue()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        public void LoadPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong where SoNguoiHienTai < SoNguoiToiDa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbo_phong.DataSource = dt;
            cbo_phong.DisplayMember = "TenPhong";
            cbo_phong.ValueMember = "MaPhong";

            txt_giaPhong.DataBindings.Clear();
            txt_giaPhong.DataBindings.Add("Text", dt, "GiaPhong");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from SinhVien where MaSV ='" + txt_maSV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_tenSV.DataBindings.Clear();
            txt_tenSV.DataBindings.Add("Text", dt, "TenSV");

            txt_diaChi.DataBindings.Clear();
            txt_diaChi.DataBindings.Add("Text", dt, "DiaChi");

            txt_soDT.DataBindings.Clear();
            txt_soDT.DataBindings.Add("Text", dt, "SDT");

            txt_lop.DataBindings.Clear();
            txt_lop.DataBindings.Add("Text", dt, "Lop");

            txt_khoa.DataBindings.Clear();
            txt_khoa.DataBindings.Add("Text", dt, "KhoasHoc");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmDangKyThue_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from DangKyThue";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_dangKy.DataSource = dt;
            LoadPhong();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void txt_maSV_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_phong_TextChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Lấy thông tin sinh viên từ cơ sở dữ liệu
                String sqlSinhVien = "Select * from SinhVien Where MaSV = @maSV";
                SqlCommand cmdSinhVien = new SqlCommand(sqlSinhVien, conn);
                cmdSinhVien.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                SqlDataReader drSinhVien = cmdSinhVien.ExecuteReader();
                DataTable dtSinhVien = new DataTable();
                dtSinhVien.Load(drSinhVien);

                if (dtSinhVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã số " + txt_maSV.Text, "Thông báo");
                    return;
                }

                // Kiểm tra giới tính của sinh viên
                bool gioiTinhSV = Convert.ToBoolean(dtSinhVien.Rows[0]["GioiTinh"]);
                string loaiPhong = cbo_phong.SelectedValue.ToString();

                // Lấy thông tin phòng từ cơ sở dữ liệu
                String sqlPhong = "Select * from Phong Where MaPhong = @maPhong";
                SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn);
                cmdPhong.Parameters.AddWithValue("@maPhong", cbo_phong.SelectedValue.ToString());
                SqlDataReader drPhong = cmdPhong.ExecuteReader();
                DataTable dtPhong = new DataTable();
                dtPhong.Load(drPhong);

                // Kiểm tra loại phòng
                string loaiPhongPhong = dtPhong.Rows[0]["LoaiPhong"].ToString();

                // Kiểm tra giới tính và loại phòng
                if ((gioiTinhSV && loaiPhongPhong == "Nữ") || (!gioiTinhSV && loaiPhongPhong == "Nam"))
                {
                    MessageBox.Show("Sinh viên " + (gioiTinhSV ? "Nam" : "Nữ") + " không được đăng ký vào phòng " + loaiPhongPhong, "Thông báo");
                    return;
                }

                // Thêm giới tính vào bảng DangKyThue
                String sqlDangKy = "Insert Into DangKyThue Values" + "(@maSV, @tenSV, @diaChi, @soDT, @lop, @khoa, @ngayDen, @ngayDi, @phong, @giaPhong)";
                SqlCommand cmdDangKy = new SqlCommand(sqlDangKy, conn);

                cmdDangKy.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmdDangKy.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmdDangKy.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmdDangKy.Parameters.AddWithValue("@soDT", txt_soDT.Text);
                cmdDangKy.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmdDangKy.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmdDangKy.Parameters.AddWithValue("@ngayDen", dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
                cmdDangKy.Parameters.AddWithValue("@ngayDi", dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
                cmdDangKy.Parameters.AddWithValue("@phong", cbo_phong.SelectedValue.ToString());
                cmdDangKy.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);

                cmdDangKy.ExecuteNonQuery();



                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                frmDangKyThue_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }






        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete DangKyThue where MaSV = @maSV";
            SqlCommand cmd = new SqlCommand(sql, conn);

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);

                cmd.ExecuteNonQuery();
            }

            frmDangKyThue_Load(sender, e);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void dgv_dangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_maSV.Text = dgv_dangKy.Rows[row].Cells[0].Value.ToString();
            txt_tenSV.Text = dgv_dangKy.Rows[row].Cells[1].Value.ToString();
            txt_diaChi.Text = dgv_dangKy.Rows[row].Cells[2].Value.ToString();
            txt_soDT.Text = dgv_dangKy.Rows[row].Cells[3].Value.ToString();
            txt_lop.Text = dgv_dangKy.Rows[row].Cells[4].Value.ToString();
            txt_khoa.Text = dgv_dangKy.Rows[row].Cells[5].Value.ToString();
            dtp_ngayDen.Value = DateTime.Parse(dgv_dangKy.Rows[row].Cells[6].Value.ToString());
            dtp_ngayDi.Value = DateTime.Parse(dgv_dangKy.Rows[row].Cells[7].Value.ToString());
            cbo_phong.SelectedValue = dgv_dangKy.Rows[row].Cells[8].Value.ToString();
            txt_giaPhong.Text = dgv_dangKy.Rows[row].Cells[9].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void txt_tongTien_TextChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
            }
        }

        private void dtp_ngayDi_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
            }
        }

        private void dtp_ngayDen_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
            }
        }

        private void cbo_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_giaPhong_TextChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
            }
        }

        private void lbl_SDT_Click(object sender, EventArgs e)
        {

        }

        private void lbl_maSV_Click(object sender, EventArgs e)
        {

        }
    }
}
