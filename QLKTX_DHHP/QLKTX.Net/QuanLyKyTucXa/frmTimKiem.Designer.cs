namespace QuanLyKyTucXa
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_hienThi = new System.Windows.Forms.Button();
            this.dgv_searSinhVien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_searchSV = new System.Windows.Forms.Button();
            this.grm_sv = new System.Windows.Forms.GroupBox();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_searchPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoiht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoitd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_searchPhong = new System.Windows.Forms.Button();
            this.grb_phong = new System.Windows.Forms.GroupBox();
            this.txt_tenPhong = new System.Windows.Forms.TextBox();
            this.lbl_maPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searSinhVien)).BeginInit();
            this.grm_sv.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchPhong)).BeginInit();
            this.grb_phong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 57);
            this.panel1.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(458, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Tìm kiếm thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_hienThi);
            this.panel2.Controls.Add(this.dgv_searSinhVien);
            this.panel2.Controls.Add(this.btn_searchSV);
            this.panel2.Controls.Add(this.grm_sv);
            this.panel2.Location = new System.Drawing.Point(1, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 715);
            this.panel2.TabIndex = 1;
            // 
            // btn_hienThi
            // 
            this.btn_hienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienThi.Image = global::QuanLyKyTucXa.Properties.Resources.Doc32;
            this.btn_hienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienThi.Location = new System.Drawing.Point(394, 191);
            this.btn_hienThi.Name = "btn_hienThi";
            this.btn_hienThi.Size = new System.Drawing.Size(107, 54);
            this.btn_hienThi.TabIndex = 4;
            this.btn_hienThi.Text = "Hiển thị";
            this.btn_hienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienThi.UseVisualStyleBackColor = true;
            this.btn_hienThi.Click += new System.EventHandler(this.btn_hienThi_Click);
            // 
            // dgv_searSinhVien
            // 
            this.dgv_searSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.tensv,
            this.ngaysinh,
            this.gioiTinh,
            this.diaChi,
            this.sodt,
            this.lop,
            this.khoahoc,
            this.khoa});
            this.dgv_searSinhVien.Location = new System.Drawing.Point(11, 280);
            this.dgv_searSinhVien.Name = "dgv_searSinhVien";
            this.dgv_searSinhVien.RowHeadersWidth = 51;
            this.dgv_searSinhVien.RowTemplate.Height = 24;
            this.dgv_searSinhVien.Size = new System.Drawing.Size(602, 426);
            this.dgv_searSinhVien.TabIndex = 3;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "MaSV";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.Width = 155;
            // 
            // tensv
            // 
            this.tensv.DataPropertyName = "TenSV";
            this.tensv.HeaderText = "Tên sinh viên";
            this.tensv.MinimumWidth = 6;
            this.tensv.Name = "tensv";
            this.tensv.Width = 155;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 125;
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "SDT";
            this.sodt.HeaderText = "Số điện thoại";
            this.sodt.MinimumWidth = 6;
            this.sodt.Name = "sodt";
            this.sodt.Width = 125;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // khoahoc
            // 
            this.khoahoc.DataPropertyName = "KhoasHoc";
            this.khoahoc.HeaderText = "Khóa học";
            this.khoahoc.MinimumWidth = 6;
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Width = 125;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "Khoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // btn_searchSV
            // 
            this.btn_searchSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchSV.Image = global::QuanLyKyTucXa.Properties.Resources.TraCuu32;
            this.btn_searchSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchSV.Location = new System.Drawing.Point(61, 191);
            this.btn_searchSV.Name = "btn_searchSV";
            this.btn_searchSV.Size = new System.Drawing.Size(107, 54);
            this.btn_searchSV.TabIndex = 1;
            this.btn_searchSV.Text = "Tìm kiếm";
            this.btn_searchSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_searchSV.UseVisualStyleBackColor = true;
            this.btn_searchSV.Click += new System.EventHandler(this.btn_searchSV_Click);
            // 
            // grm_sv
            // 
            this.grm_sv.Controls.Add(this.txt_maSV);
            this.grm_sv.Controls.Add(this.lbl_maSV);
            this.grm_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grm_sv.Location = new System.Drawing.Point(11, 12);
            this.grm_sv.Name = "grm_sv";
            this.grm_sv.Size = new System.Drawing.Size(599, 144);
            this.grm_sv.TabIndex = 0;
            this.grm_sv.TabStop = false;
            this.grm_sv.Text = "Tìm kiếm sinh viên";
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(237, 53);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(283, 27);
            this.txt_maSV.TabIndex = 1;
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Location = new System.Drawing.Point(14, 56);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(164, 20);
            this.lbl_maSV.TabIndex = 0;
            this.lbl_maSV.Text = "Nhập mã sinh viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_searchPhong);
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.btn_searchPhong);
            this.panel3.Controls.Add(this.grb_phong);
            this.panel3.Location = new System.Drawing.Point(620, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 715);
            this.panel3.TabIndex = 2;
            // 
            // dgv_searchPhong
            // 
            this.dgv_searchPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.makhu,
            this.tenphong,
            this.loaiphong,
            this.songuoiht,
            this.songuoitd,
            this.giaphong});
            this.dgv_searchPhong.Location = new System.Drawing.Point(3, 280);
            this.dgv_searchPhong.Name = "dgv_searchPhong";
            this.dgv_searchPhong.RowHeadersWidth = 51;
            this.dgv_searchPhong.RowTemplate.Height = 24;
            this.dgv_searchPhong.Size = new System.Drawing.Size(572, 426);
            this.dgv_searchPhong.TabIndex = 5;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "MaPhong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 155;
            // 
            // makhu
            // 
            this.makhu.DataPropertyName = "MaKhu";
            this.makhu.HeaderText = "Mã khu";
            this.makhu.MinimumWidth = 6;
            this.makhu.Name = "makhu";
            this.makhu.Width = 125;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "TenPhong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.MinimumWidth = 6;
            this.tenphong.Name = "tenphong";
            this.tenphong.Width = 150;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "LoaiPhong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.MinimumWidth = 6;
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.Width = 150;
            // 
            // songuoiht
            // 
            this.songuoiht.DataPropertyName = "SoNguoiHienTai";
            this.songuoiht.HeaderText = "Số người hiện tại";
            this.songuoiht.MinimumWidth = 6;
            this.songuoiht.Name = "songuoiht";
            this.songuoiht.Width = 150;
            // 
            // songuoitd
            // 
            this.songuoitd.DataPropertyName = "SoNguoiToiDa";
            this.songuoitd.HeaderText = "Số người tối đa";
            this.songuoitd.MinimumWidth = 6;
            this.songuoitd.Name = "songuoitd";
            this.songuoitd.Width = 150;
            // 
            // giaphong
            // 
            this.giaphong.DataPropertyName = "GiaPhong";
            this.giaphong.HeaderText = "Giá phòng";
            this.giaphong.MinimumWidth = 6;
            this.giaphong.Name = "giaphong";
            this.giaphong.Width = 125;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(395, 191);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(107, 54);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_searchPhong
            // 
            this.btn_searchPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchPhong.Image = global::QuanLyKyTucXa.Properties.Resources.TraCuu32;
            this.btn_searchPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchPhong.Location = new System.Drawing.Point(94, 191);
            this.btn_searchPhong.Name = "btn_searchPhong";
            this.btn_searchPhong.Size = new System.Drawing.Size(107, 54);
            this.btn_searchPhong.TabIndex = 3;
            this.btn_searchPhong.Text = "Tìm kiếm";
            this.btn_searchPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_searchPhong.UseVisualStyleBackColor = true;
            this.btn_searchPhong.Click += new System.EventHandler(this.btn_searchPhong_Click);
            // 
            // grb_phong
            // 
            this.grb_phong.Controls.Add(this.txt_tenPhong);
            this.grb_phong.Controls.Add(this.lbl_maPhong);
            this.grb_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_phong.Location = new System.Drawing.Point(3, 12);
            this.grb_phong.Name = "grb_phong";
            this.grb_phong.Size = new System.Drawing.Size(572, 144);
            this.grb_phong.TabIndex = 0;
            this.grb_phong.TabStop = false;
            this.grb_phong.Text = "Tìm kiếm phòng";
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenPhong.Location = new System.Drawing.Point(216, 57);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Size = new System.Drawing.Size(283, 27);
            this.txt_tenPhong.TabIndex = 3;
            // 
            // lbl_maPhong
            // 
            this.lbl_maPhong.AutoSize = true;
            this.lbl_maPhong.Location = new System.Drawing.Point(42, 60);
            this.lbl_maPhong.Name = "lbl_maPhong";
            this.lbl_maPhong.Size = new System.Drawing.Size(140, 20);
            this.lbl_maPhong.TabIndex = 2;
            this.lbl_maPhong.Text = "Nhập tên phòng";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 783);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searSinhVien)).EndInit();
            this.grm_sv.ResumeLayout(false);
            this.grm_sv.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchPhong)).EndInit();
            this.grb_phong.ResumeLayout(false);
            this.grb_phong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_searSinhVien;
        private System.Windows.Forms.Button btn_searchSV;
        private System.Windows.Forms.GroupBox grm_sv;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_searchPhong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_searchPhong;
        private System.Windows.Forms.GroupBox grb_phong;
        private System.Windows.Forms.TextBox txt_tenPhong;
        private System.Windows.Forms.Label lbl_maPhong;
        private System.Windows.Forms.Button btn_hienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoiht;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoitd;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaphong;
    }
}