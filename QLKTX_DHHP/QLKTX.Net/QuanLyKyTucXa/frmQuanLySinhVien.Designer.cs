namespace QuanLyKyTucXa
{
    partial class frmQuanLySinhVien
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
            this.dgv_qlSinhVien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.chk_nam = new System.Windows.Forms.CheckBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_gioiTinh = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.txt_soDT = new System.Windows.Forms.TextBox();
            this.txt_khoas = new System.Windows.Forms.TextBox();
            this.txt_tenSV = new System.Windows.Forms.TextBox();
            this.lbl_soDT = new System.Windows.Forms.Label();
            this.lbl_khoas = new System.Windows.Forms.Label();
            this.lbl_tenSV = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.lbl_diaChi = new System.Windows.Forms.Label();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_qlSinhVien
            // 
            this.dgv_qlSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.tenSV,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi,
            this.sdt,
            this.lop,
            this.khoa,
            this.KhoaH});
            this.dgv_qlSinhVien.Location = new System.Drawing.Point(12, 423);
            this.dgv_qlSinhVien.Name = "dgv_qlSinhVien";
            this.dgv_qlSinhVien.RowHeadersWidth = 51;
            this.dgv_qlSinhVien.RowTemplate.Height = 24;
            this.dgv_qlSinhVien.Size = new System.Drawing.Size(1165, 331);
            this.dgv_qlSinhVien.TabIndex = 61;
            this.dgv_qlSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlSinhVien_CellClick);
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "MaSV";
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            this.maSV.Width = 150;
            // 
            // tenSV
            // 
            this.tenSV.DataPropertyName = "TenSV";
            this.tenSV.HeaderText = "Tên sinh viên";
            this.tenSV.MinimumWidth = 6;
            this.tenSV.Name = "tenSV";
            this.tenSV.Width = 200;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "NgaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
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
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 150;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "KhoasHoc";
            this.khoa.HeaderText = "Khóa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // KhoaH
            // 
            this.KhoaH.DataPropertyName = "Khoa";
            this.KhoaH.HeaderText = "Khoa";
            this.KhoaH.MinimumWidth = 6;
            this.KhoaH.Name = "KhoaH";
            this.KhoaH.Width = 125;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(986, 334);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 61);
            this.btn_thoat.TabIndex = 60;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.XoaPhong32;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(687, 334);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 61);
            this.btn_xoa.TabIndex = 59;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QuanLyKyTucXa.Properties.Resources.SuaPhong32;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(387, 334);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 61);
            this.btn_sua.TabIndex = 58;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QuanLyKyTucXa.Properties.Resources.ThemPhong32;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(108, 334);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(106, 61);
            this.btn_them.TabIndex = 57;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(142, 203);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(238, 27);
            this.dtp_ngaySinh.TabIndex = 50;
            // 
            // chk_nam
            // 
            this.chk_nam.AutoSize = true;
            this.chk_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_nam.Location = new System.Drawing.Point(142, 269);
            this.chk_nam.Name = "chk_nam";
            this.chk_nam.Size = new System.Drawing.Size(66, 24);
            this.chk_nam.TabIndex = 51;
            this.chk_nam.Text = "Nam";
            this.chk_nam.UseVisualStyleBackColor = true;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(933, 77);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(238, 27);
            this.txt_khoa.TabIndex = 56;
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(871, 80);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(51, 20);
            this.lbl_khoa.TabIndex = 48;
            this.lbl_khoa.Text = "Khoa";
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(43, 271);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(80, 20);
            this.lbl_gioiTinh.TabIndex = 47;
            this.lbl_gioiTinh.Text = "Giới tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(40, 203);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(92, 20);
            this.lbl_ngaySinh.TabIndex = 46;
            this.lbl_ngaySinh.Text = "Ngày sinh";
            // 
            // txt_soDT
            // 
            this.txt_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDT.Location = new System.Drawing.Point(600, 141);
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(238, 27);
            this.txt_soDT.TabIndex = 53;
            // 
            // txt_khoas
            // 
            this.txt_khoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoas.Location = new System.Drawing.Point(600, 271);
            this.txt_khoas.Name = "txt_khoas";
            this.txt_khoas.Size = new System.Drawing.Size(238, 27);
            this.txt_khoas.TabIndex = 55;
            // 
            // txt_tenSV
            // 
            this.txt_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSV.Location = new System.Drawing.Point(142, 138);
            this.txt_tenSV.Name = "txt_tenSV";
            this.txt_tenSV.Size = new System.Drawing.Size(238, 27);
            this.txt_tenSV.TabIndex = 49;
            // 
            // lbl_soDT
            // 
            this.lbl_soDT.AutoSize = true;
            this.lbl_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDT.Location = new System.Drawing.Point(444, 141);
            this.lbl_soDT.Name = "lbl_soDT";
            this.lbl_soDT.Size = new System.Drawing.Size(119, 20);
            this.lbl_soDT.TabIndex = 45;
            this.lbl_soDT.Text = "Số điện thoại";
            // 
            // lbl_khoas
            // 
            this.lbl_khoas.AutoSize = true;
            this.lbl_khoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoas.Location = new System.Drawing.Point(502, 274);
            this.lbl_khoas.Name = "lbl_khoas";
            this.lbl_khoas.Size = new System.Drawing.Size(51, 20);
            this.lbl_khoas.TabIndex = 43;
            this.lbl_khoas.Text = "Khóa";
            // 
            // lbl_tenSV
            // 
            this.lbl_tenSV.AutoSize = true;
            this.lbl_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSV.Location = new System.Drawing.Point(18, 139);
            this.lbl_tenSV.Name = "lbl_tenSV";
            this.lbl_tenSV.Size = new System.Drawing.Size(121, 20);
            this.lbl_tenSV.TabIndex = 42;
            this.lbl_tenSV.Text = "Tên sinh viên";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(600, 77);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(238, 27);
            this.txt_diaChi.TabIndex = 52;
            // 
            // lbl_diaChi
            // 
            this.lbl_diaChi.AutoSize = true;
            this.lbl_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaChi.Location = new System.Drawing.Point(487, 77);
            this.lbl_diaChi.Name = "lbl_diaChi";
            this.lbl_diaChi.Size = new System.Drawing.Size(68, 20);
            this.lbl_diaChi.TabIndex = 41;
            this.lbl_diaChi.Text = "Địa chỉ";
            // 
            // txt_lop
            // 
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop.Location = new System.Drawing.Point(600, 206);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(238, 27);
            this.txt_lop.TabIndex = 54;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(511, 206);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(40, 20);
            this.lbl_lop.TabIndex = 40;
            this.lbl_lop.Text = "Lớp";
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(142, 74);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(238, 27);
            this.txt_maSV.TabIndex = 39;
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSV.Location = new System.Drawing.Point(18, 77);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(115, 20);
            this.lbl_maSV.TabIndex = 44;
            this.lbl_maSV.Text = "Mã sinh viên";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(441, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 38);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Quản lý sinh viên";
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 771);
            this.Controls.Add(this.dgv_qlSinhVien);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.chk_nam);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.lbl_khoa);
            this.Controls.Add(this.lbl_gioiTinh);
            this.Controls.Add(this.lbl_ngaySinh);
            this.Controls.Add(this.txt_soDT);
            this.Controls.Add(this.txt_khoas);
            this.Controls.Add(this.txt_tenSV);
            this.Controls.Add(this.lbl_soDT);
            this.Controls.Add(this.lbl_khoas);
            this.Controls.Add(this.lbl_tenSV);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.lbl_diaChi);
            this.Controls.Add(this.txt_lop);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.txt_maSV);
            this.Controls.Add(this.lbl_maSV);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySinhVien";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlSinhVien;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.CheckBox chk_nam;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.TextBox txt_soDT;
        private System.Windows.Forms.TextBox txt_khoas;
        private System.Windows.Forms.TextBox txt_tenSV;
        private System.Windows.Forms.Label lbl_soDT;
        private System.Windows.Forms.Label lbl_khoas;
        private System.Windows.Forms.Label lbl_tenSV;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label lbl_diaChi;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaH;
    }
}