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
using System.Globalization;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyKyTucXa
{
    public partial class cbo_maPhong : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        private readonly String Temp = Application.StartupPath + "/Template/HD_TienPhong.docx";
        public cbo_maPhong()
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
            String sql = "Select * from DangKyThue where MaSV ='" + txt_maSV.Text + "'";
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

            txt_phong.DataBindings.Clear();
            txt_phong.DataBindings.Add("Text", dt, "MaPhong");

            txt_soTien.DataBindings.Clear();
            txt_soTien.DataBindings.Add("Text", dt, "GiaPhong");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmHoaDonTienPhong_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from HDTienPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_HDTienPhong.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into HDTienPhong Values" + "(@maSV, @tenSV, @lop, @khoa, @phong, @noiDung,@soTien, @nguoiLap)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmd.Parameters.AddWithValue("@phong", txt_phong.Text);
                cmd.Parameters.AddWithValue("@noiDung", txt_noiDung.Text);
                cmd.Parameters.AddWithValue("@soTien", txt_soTien.Text);
                cmd.Parameters.AddWithValue("@nguoiLap", txt_nguoiLap.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                frmHoaDonTienPhong_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã phiếu đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update HDTienPhong Set MaSV=@maSV, TenSV=@tenSV, Lop=@lop, Khoa=@khoa, Phong=@phong, NoiDung=@noiDung,SoTien=@soTien, NguoiLap=@nguoiLap Where MaHD=@maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maHD", txt_maHD.Text);
                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmd.Parameters.AddWithValue("@phong", txt_phong.Text);
                cmd.Parameters.AddWithValue("@noiDung", txt_noiDung.Text);
                cmd.Parameters.AddWithValue("@soTien", txt_soTien.Text);
                cmd.Parameters.AddWithValue("@nguoiLap", txt_nguoiLap.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmHoaDonTienPhong_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete HDTienPhong where MaHD = @maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maHD", txt_maHD.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmHoaDonTienPhong_Load(sender, e);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            var maSV = txt_maSV.Text;
            var tenSV = txt_tenSV.Text;
            var lop = txt_lop.Text;
            var khoa = txt_khoa.Text;
            var phong = txt_phong.Text;
            var noiDung = txt_noiDung.Text;
            var soTien = txt_soTien.Text;
            var nguoiLap = txt_nguoiLap.Text;

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var wordApp = new Word.Application();
            var wordDocument = wordApp.Documents.Open(Temp);

            Connect con = new Connect();

            con.ReplaceWordStub("{MaSV}", maSV, wordDocument);
            con.ReplaceWordStub("{TenSV}", tenSV, wordDocument);
            con.ReplaceWordStub("{Lop}", lop, wordDocument);
            con.ReplaceWordStub("{Khoa}", khoa, wordDocument);
            con.ReplaceWordStub("{Phong}", phong, wordDocument);
            con.ReplaceWordStub("{NoiDung}", noiDung, wordDocument);
            con.ReplaceWordStub("{SoTien}", soTien, wordDocument);
            con.ReplaceWordStub("{NguoiLap}", nguoiLap, wordDocument);

            String output = "/HD_TienPhong/HD_TienPhong" + txt_maSV.Text.Trim() + ".doc";
            wordDocument.SaveAs2(Application.StartupPath + output);
            wordApp.Documents.Open(Application.StartupPath + output);
        }

        private void dgv_HDTienPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txt_maHD.Text = dgv_HDTienPhong.Rows[row].Cells[0].Value.ToString();
            txt_maSV.Text = dgv_HDTienPhong.Rows[row].Cells[1].Value.ToString();
            txt_tenSV.Text = dgv_HDTienPhong.Rows[row].Cells[2].Value.ToString();
            txt_lop.Text = dgv_HDTienPhong.Rows[row].Cells[3].Value.ToString();
            txt_khoa.Text = dgv_HDTienPhong.Rows[row].Cells[4].Value.ToString();
            txt_phong.Text = dgv_HDTienPhong.Rows[row].Cells[5].Value.ToString();
            txt_noiDung.Text = dgv_HDTienPhong.Rows[row].Cells[6].Value.ToString();
            txt_soTien.Text = dgv_HDTienPhong.Rows[row].Cells[7].Value.ToString();
            txt_nguoiLap.Text = dgv_HDTienPhong.Rows[row].Cells[8].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void txt_maSV_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_phong_TextChanged(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btn_in_excel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Header
                for (int i = 1; i <= dgv_HDTienPhong.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgv_HDTienPhong.Columns[i - 1].HeaderText;
                }

                // Data
                for (int i = 0; i < dgv_HDTienPhong.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_HDTienPhong.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_HDTienPhong.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Save the workbook
                workbook.SaveAs("YourFilePath_TienPhong.xlsx");

                // Release Excel objects
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);

                MessageBox.Show("Dữ liệu được xuất sang Excel thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất dữ liệu sang Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The ReleaseObject method remains the same
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
