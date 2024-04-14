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
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;

namespace QuanLyKyTucXa
{
    public partial class frmHopDong : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        private readonly String Temp = Application.StartupPath + "/Template/HopDongThue.docx";
        public frmHopDong()
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

            String sql = "Select * from HopDongThue";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_hopDong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String sql = "Select * from DangKyThue Where MaSV = '" + txt_maSinhVien.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_tenSV.DataBindings.Clear();
            txt_tenSV.DataBindings.Add("Text", dt, "TenSV");

            txt_lop.DataBindings.Clear();
            txt_lop.DataBindings.Add("Text", dt, "Lop");

            txt_khoa.DataBindings.Clear();
            txt_khoa.DataBindings.Add("Text", dt, "Khoa");

            dtp_ngayDen.DataBindings.Clear();
            dtp_ngayDen.DataBindings.Add("Text", dt, "NgayDen");

            dtp_ngayDi.DataBindings.Clear();
            dtp_ngayDi.DataBindings.Add("Text", dt, "NgayDi");

            txt_phong.DataBindings.Clear();
            txt_phong.DataBindings.Add("Text", dt, "MaPhong");

            txt_giaPhong.DataBindings.Clear();
            txt_giaPhong.DataBindings.Add("Text", dt, "GiaPhong");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            LoadData();
        }

        private void txt_maSinhVien_TextChanged(object sender, EventArgs e)
        {
            frmHopDong_Load(sender, e);
        }

        private void btn_LapHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into HopDongThue Values" + "(@ngayLap, @maSV, @tenSV, @lop, @khoa, @maPhong, @giaPhong, @ngayDen, @ngayDi)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ngayLap", dtp_ngayLap.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@maSV", txt_maSinhVien.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmd.Parameters.AddWithValue("@maPhong", txt_phong.Text);
                cmd.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);
                cmd.Parameters.AddWithValue("@ngayDen", dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ngayDi", dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                frmHopDong_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã hợp đồng đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void dgv_hopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_maSinhVien.Enabled = false;
            dtp_ngayDen.Enabled = true;
            dtp_ngayDi.Enabled = true;
            if (row > -1)
            {
                txt_maHopDong.Text = dgv_hopDong.Rows[row].Cells[0].Value.ToString();
                dtp_ngayLap.Text = dgv_hopDong.Rows[row].Cells[1].Value.ToString();
                txt_maSinhVien.Text = dgv_hopDong.Rows[row].Cells[2].Value.ToString();
                txt_tenSV.Text = dgv_hopDong.Rows[row].Cells[3].Value.ToString();
                txt_lop.Text = dgv_hopDong.Rows[row].Cells[4].Value.ToString();
                txt_khoa.Text = dgv_hopDong.Rows[row].Cells[5].Value.ToString();
                txt_phong.Text = dgv_hopDong.Rows[row].Cells[6].Value.ToString();
                txt_giaPhong.Text = dgv_hopDong.Rows[row].Cells[7].Value.ToString();
                dtp_ngayDen.Text = dgv_hopDong.Rows[row].Cells[8].Value.ToString();
                dtp_ngayDi.Text = dgv_hopDong.Rows[row].Cells[9].Value.ToString();
            }

        }

        private void btn_giaHan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update HopDongThue Set NgayLap=@ngayLap, MaSV=@maSV,TenSV=@tenSV, Lop=@lop,Khoa=@khoa,MaPhong=@maPhong," +
                "GiaPhong=@giaPhong, NgayDen=@ngayDen, NgayDi=@ngayDi Where MaHD=@maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn gia hạn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maHD", txt_maHopDong.Text);
                cmd.Parameters.AddWithValue("@ngayLap", dtp_ngayLap.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@maSV", txt_maSinhVien.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmd.Parameters.AddWithValue("@maPhong", txt_phong.Text);
                cmd.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);
                cmd.Parameters.AddWithValue("@ngayDen", dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ngayDi", dtp_ngayDi.Value.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmHopDong_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete HopDongThue Where MaHD=@maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maHD", txt_maHopDong.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmHopDong_Load(sender, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            var maHD = txt_maHopDong.Text;
            var ngayLap = dtp_ngayLap.Value.ToString();
            var maSV = txt_maSinhVien.Text;
            var tenSV = txt_tenSV.Text;
            var lop = txt_lop.Text;
            var khoa = txt_khoa.Text;
            var phong = txt_phong.Text;
            var giaPhong = txt_giaPhong.Text;
            var ngayDen = dtp_ngayDen.Value.ToString();
            var ngayDi = dtp_ngayDi.Value.ToString();

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var wordApp = new Word.Application();
            var wordDocument = wordApp.Documents.Open(Temp);

            Connect con = new Connect();

            con.ReplaceWordStub("{MaHD}", maHD, wordDocument);
            con.ReplaceWordStub("{NgayLap}", ngayLap, wordDocument);
            con.ReplaceWordStub("{MaSV}", maSV, wordDocument);
            con.ReplaceWordStub("{TenSV}", tenSV, wordDocument);
            con.ReplaceWordStub("{Lop}", lop, wordDocument);
            con.ReplaceWordStub("{Khoa}", khoa, wordDocument);
            con.ReplaceWordStub("{MaPhong}", phong, wordDocument);
            con.ReplaceWordStub("{GiaPhong}", giaPhong, wordDocument);
            con.ReplaceWordStub("{NgayDen}", ngayDen, wordDocument);
            con.ReplaceWordStub("{NgayDi}", ngayDi, wordDocument);
            con.ReplaceWordStub("{NgayLap}", ngayLap, wordDocument);

            String output = "/HopDong/HopDongThue" + txt_maHopDong.Text.Trim() + ".doc";
            wordDocument.SaveAs2(Application.StartupPath + output);
            wordApp.Documents.Open(Application.StartupPath + output);
        }
    }
}
