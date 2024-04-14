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
    public partial class frmMain : Form
    {
        String connString = @"Data Source=DESKTOP-GN37QAB\SQLEXPRESS;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
        SqlConnection conn;
        public frmMain()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frm = new frmQuanLySinhVien();
            this.Hide();
            frm.ShowDialog();
        }

        private void đăngKýThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbo_maPhong frm = new cbo_maPhong();
            this.Hide();
            frm.ShowDialog();
        }

       

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            this.Hide();
            frm.ShowDialog();
        }

        private void hóaĐơnĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonDienNuoc frm = new frmHoaDonDienNuoc();
            this.Hide();
            frm.ShowDialog();
        }

        private void danhSachPhòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachphongTrong frm = new frmDanhSachphongTrong();
            this.Hide();
            frm.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong frm = new frmQuanLyPhong();
            this.Hide();
            frm.ShowDialog();
        }

        private void thôngTinCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyCanBo frm = new frmQuanLyCanBo();
            this.Hide();
            frm.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            this.Hide();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void đăngKýThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyThue frm = new frmDangKyThue();
            this.Hide();
            frm.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHopDong frm = new frmHopDong();
            this.Hide();
            frm.ShowDialog();
        }

        private void danhSáchSinhViênTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachSinhVienTheoPhong frm = new frmDanhSachSinhVienTheoPhong();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
