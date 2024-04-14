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
    public partial class frmHoaDonDienNuoc : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        String ID;
        private readonly String Temp = Application.StartupPath + "/Template/HD_DienNuoc.docx";
        public frmHoaDonDienNuoc()
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

            String sql = "Select * from HDDienNuoc Where MaPhong = '"+ID+"' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_dienNuoc.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmHoaDonDienNuoc_Load(object sender, EventArgs e)
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

            cbo_maPhong.DataSource = dt;
            cbo_maPhong.DisplayMember = "TenPhong";
            cbo_maPhong.ValueMember = "MaPhong";

            ID = cbo_maPhong.SelectedValue.ToString();
            LoadData();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void cbo_maPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = cbo_maPhong.SelectedValue.ToString();

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

                // Lấy chỉ số điện nước cũ từ CSDL
                string sqlChiso = "SELECT TOP 1 CSDienMoi, CSNuocMoi FROM HDDienNuoc WHERE MaPhong = @maPhong ORDER BY Thang DESC";
                SqlCommand cmdChiso = new SqlCommand(sqlChiso, conn);
                cmdChiso.Parameters.AddWithValue("@maPhong", cbo_maPhong.SelectedValue.ToString());
                SqlDataReader drChiso = cmdChiso.ExecuteReader();
                if (drChiso.Read())
                {
                    txt_chiSoDienCu.Text = drChiso["CSDienMoi"].ToString();
                    txt_chiSoNuocCu.Text = drChiso["CSNuocMoi"].ToString();
                }
                drChiso.Close();

                // Tiếp tục thêm mới bản ghi
                string sql = "INSERT INTO HDDienNuoc (MaPhong, Thang, CSDienCu, CSDienMoi, DonGiaDien, ThanhTienDien, " +
                             "CSNuocCu, CSNuocMoi, DonGiaNuoc, ThanhTienNuoc, TongTien) VALUES (@maPhong, @thang, " +
                             "@chiSoDienCu, @chiSoDienMoi, @donGiaDien, @thanhTienDien, @chiSoNuocCu, @chiSoNuocMoi, " +
                             "@donGiaNuoc, @thanhTienNuoc, @tongTien)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@maPhong", cbo_maPhong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@thang", dtp_thang.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@chiSoDienCu", txt_chiSoDienCu.Text);
                cmd.Parameters.AddWithValue("@chiSoDienMoi", txt_chiSoDienMoi.Text);
                cmd.Parameters.AddWithValue("@donGiaDien", txt_donGiaDien.Text);
                cmd.Parameters.AddWithValue("@thanhTienDien", txt_thanhTienDien.Text);
                cmd.Parameters.AddWithValue("@chiSoNuocCu", txt_chiSoNuocCu.Text);
                cmd.Parameters.AddWithValue("@chiSoNuocMoi", txt_chiSoNuocMoi.Text);
                cmd.Parameters.AddWithValue("@donGiaNuoc", txt_donGiaNuoc.Text);
                cmd.Parameters.AddWithValue("@thanhTienNuoc", txt_thanhTienNuoc.Text);
                cmd.Parameters.AddWithValue("@tongTien", txt_tongTien.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                frmHoaDonDienNuoc_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update HDDienNuoc Set MaPhong=@maPhong, Thang=@thang, CSDienCu=@chiSoDienCu," +
                "CSDienMoi=@chiSoDienMoi, DonGiaDien=@donGiaDien, ThanhTienDien=@thanhTienDien, " +
                "CSNuocCu=@chiSoNuocCu, CSNuocMoi=@chiSoNuocMoi,DonGiaNuoc=@donGiaNuoc, ThanhTienNuoc=@ThanhTienNuoc," +
                " TongTien=@tongTien Where  So=@soHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@soHD", txt_soHD.Text);
                cmd.Parameters.AddWithValue("@maPhong", cbo_maPhong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@thang", dtp_thang.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@chiSoDienCu", txt_chiSoDienCu.Text);
                cmd.Parameters.AddWithValue("@chiSoDienMoi", txt_chiSoDienMoi.Text);
                cmd.Parameters.AddWithValue("@donGiaDien", txt_donGiaDien.Text);
                cmd.Parameters.AddWithValue("@thanhTienDien", txt_thanhTienDien.Text);
                cmd.Parameters.AddWithValue("@chiSoNuocCu", txt_chiSoNuocCu.Text);
                cmd.Parameters.AddWithValue("@chiSoNuocMoi", txt_chiSoNuocMoi.Text);
                cmd.Parameters.AddWithValue("@donGiaNuoc", txt_donGiaNuoc.Text);
                cmd.Parameters.AddWithValue("@thanhTienNuoc", txt_thanhTienNuoc.Text);
                cmd.Parameters.AddWithValue("@tongTien", txt_tongTien.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmHoaDonDienNuoc_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete HDDienNuoc where So = @soHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@soHD", txt_soHD.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmHoaDonDienNuoc_Load(sender, e);
        }

        private void dgv_dienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_soHD.Text = dgv_dienNuoc.Rows[row].Cells[0].Value.ToString();
            cbo_maPhong.SelectedValue = dgv_dienNuoc.Rows[row].Cells[1].Value.ToString();
            dtp_thang.Value = DateTime.Parse(dgv_dienNuoc.Rows[row].Cells[2].Value.ToString());
            txt_chiSoDienCu.Text = dgv_dienNuoc.Rows[row].Cells[3].Value.ToString();
            txt_chiSoDienMoi.Text = dgv_dienNuoc.Rows[row].Cells[4].Value.ToString();
            txt_donGiaDien.Text = dgv_dienNuoc.Rows[row].Cells[5].Value.ToString();
            txt_thanhTienDien.Text = dgv_dienNuoc.Rows[row].Cells[6].Value.ToString();
            txt_chiSoNuocCu.Text = dgv_dienNuoc.Rows[row].Cells[7].Value.ToString();
            txt_chiSoNuocMoi.Text = dgv_dienNuoc.Rows[row].Cells[8].Value.ToString();
            txt_donGiaNuoc.Text = dgv_dienNuoc.Rows[row].Cells[9].Value.ToString();
            txt_thanhTienNuoc.Text = dgv_dienNuoc.Rows[row].Cells[10].Value.ToString();
            txt_tongTien.Text = dgv_dienNuoc.Rows[row].Cells[11].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void txt_chiSoDienMoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_chiSoDienMoi.Text != "")
            {
                int csc, csm;
                if (int.TryParse(txt_chiSoDienCu.Text, out csc) && int.TryParse(txt_chiSoDienMoi.Text, out csm))
                {
                    if (csm < csc)
                    {
                        MessageBox.Show("Dữ liệu đầu vào chưa hợp lệ!", "Thông báo");
                    }
                    else
                    {
                        int donGiaDien;
                        if (int.TryParse(txt_donGiaDien.Text, out donGiaDien))
                        {
                            txt_thanhTienDien.Text = Convert.ToString((csm - csc) * donGiaDien);
                        }
                        else
                        {
                            MessageBox.Show("Đơn giá điện không hợp lệ!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào chưa hợp lệ!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống phần này!", "Thông báo");
            }
        }

        private void txt_chiSoNuocMoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_chiSoNuocMoi.Text != "")
            {
                int csc, csm;
                if (int.TryParse(txt_chiSoNuocCu.Text, out csc) && int.TryParse(txt_chiSoNuocMoi.Text, out csm))
                {
                    if (csm < csc)
                    {
                        MessageBox.Show("Dữ liệu đầu vào chưa hợp lệ!", "Thông báo");
                    }
                    else
                    {
                        int donGiaNuoc;
                        if (int.TryParse(txt_donGiaNuoc.Text, out donGiaNuoc))
                        {
                            txt_thanhTienNuoc.Text = Convert.ToString((csm - csc) * donGiaNuoc);
                        }
                        else
                        {
                            MessageBox.Show("Đơn giá nước không hợp lệ!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào chưa hợp lệ!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống phần này!", "Thông báo");
            }
        }



        private void txt_donGiaDien_TextChanged(object sender, EventArgs e)
        {
            txt_donGiaDien.Text = !String.IsNullOrEmpty(txt_donGiaDien.Text) ? txt_donGiaDien.Text : "0";
        }

        private void txt_donGiaNuoc_TextChanged(object sender, EventArgs e)
        {
            txt_donGiaNuoc.Text = !String.IsNullOrEmpty(txt_donGiaNuoc.Text) ? txt_donGiaNuoc.Text : "0";
        }

        private void txt_thanhTienDien_TextChanged(object sender, EventArgs e)
        {
            //int tienDien = Convert.ToInt32(txt_thanhTienDien.Text);
            //int tienNuoc = Convert.ToInt32(txt_thanhTienNuoc.Text);
            //txt_tongTien.Text = Convert.ToString(tienDien + tienNuoc);
        }

        private void txt_thanhTienNuoc_TextChanged(object sender, EventArgs e)
        {
            int tienDien = Convert.ToInt32(txt_thanhTienDien.Text);
            int tienNuoc = Convert.ToInt32(txt_thanhTienNuoc.Text);
            txt_tongTien.Text = Convert.ToString(tienDien + tienNuoc);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            var so = txt_soHD.Text;
            var phong = cbo_maPhong.SelectedValue.ToString();
            var thang = dtp_thang.Value.ToString();
            var csDienCu = txt_chiSoDienCu.Text;
            var csDienMoi = txt_chiSoDienMoi.Text;
            var donGiaDien = txt_donGiaDien.Text;
            var thanhTienDien = txt_thanhTienDien.Text;
            var csNuocCu = txt_chiSoNuocCu.Text;
            var csNuocMoi = txt_chiSoNuocMoi.Text;
            var donGiaNuoc = txt_donGiaNuoc.Text;
            var thanhTienNuoc = txt_thanhTienNuoc.Text;
            var tongTien = txt_tongTien.Text;

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var wordApp = new Word.Application();
            var wordDocument = wordApp.Documents.Open(Temp);

            Connect con = new Connect();

            con.ReplaceWordStub("{So}", so, wordDocument);
            con.ReplaceWordStub("{MaPhong}", phong, wordDocument);
            con.ReplaceWordStub("{Thang}", thang, wordDocument);
            con.ReplaceWordStub("{CSDienCu}", csDienCu, wordDocument);
            con.ReplaceWordStub("{CSDienMoi}", csDienMoi, wordDocument);
            con.ReplaceWordStub("{DonGiaDien}", donGiaDien, wordDocument);
            con.ReplaceWordStub("{ThanhTienDien}", thanhTienDien, wordDocument);
            con.ReplaceWordStub("{CSNuocCu}", csNuocCu, wordDocument);
            con.ReplaceWordStub("{CSNuocMoi}", csNuocMoi, wordDocument);
            con.ReplaceWordStub("{DonGiaNuoc}", donGiaNuoc, wordDocument);
            con.ReplaceWordStub("{ThanhTienNuoc}", thanhTienNuoc, wordDocument);
            con.ReplaceWordStub("{TongTien}", tongTien, wordDocument);

            String output = "/HD_DienNuoc/HD_Dien_Nuoc" + txt_soHD.Text.Trim() + ".doc";
            wordDocument.SaveAs2(Application.StartupPath + output);
            wordApp.Documents.Open(Application.StartupPath + output);
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
                for (int i = 1; i <= dgv_dienNuoc.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgv_dienNuoc.Columns[i - 1].HeaderText;
                }

                // Data
                for (int i = 0; i < dgv_dienNuoc.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_dienNuoc.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_dienNuoc.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Save the workbook
                workbook.SaveAs("YourFilePath.xlsx");

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
