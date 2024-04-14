namespace QuanLyKyTucXa
{
    partial class frmDangKyThue
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.lbl_tenSV = new System.Windows.Forms.Label();
            this.lbl_diaChi = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_ngayDen = new System.Windows.Forms.Label();
            this.lbl_ngayDi = new System.Windows.Forms.Label();
            this.lbl_phong = new System.Windows.Forms.Label();
            this.lbl_giaPhong = new System.Windows.Forms.Label();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.txt_tenSV = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_soDT = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_giaPhong = new System.Windows.Forms.TextBox();
            this.btn_dangKy = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtp_ngayDen = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayDi = new System.Windows.Forms.DateTimePicker();
            this.dgv_dangKy = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_phong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(405, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(513, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Quản lý KTX Đại học Hải Phòng";
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSV.Location = new System.Drawing.Point(52, 87);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(115, 20);
            this.lbl_maSV.TabIndex = 1;
            this.lbl_maSV.Text = "Mã sinh viên";
            this.lbl_maSV.Click += new System.EventHandler(this.lbl_maSV_Click);
            // 
            // lbl_tenSV
            // 
            this.lbl_tenSV.AutoSize = true;
            this.lbl_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSV.Location = new System.Drawing.Point(46, 145);
            this.lbl_tenSV.Name = "lbl_tenSV";
            this.lbl_tenSV.Size = new System.Drawing.Size(121, 20);
            this.lbl_tenSV.TabIndex = 2;
            this.lbl_tenSV.Text = "Tên sinh viên";
            // 
            // lbl_diaChi
            // 
            this.lbl_diaChi.AutoSize = true;
            this.lbl_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaChi.Location = new System.Drawing.Point(99, 203);
            this.lbl_diaChi.Name = "lbl_diaChi";
            this.lbl_diaChi.Size = new System.Drawing.Size(68, 20);
            this.lbl_diaChi.TabIndex = 3;
            this.lbl_diaChi.Text = "Địa chỉ";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(48, 261);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(127, 20);
            this.lbl_SDT.TabIndex = 4;
            this.lbl_SDT.Text = "Số Điện Thoại";
            this.lbl_SDT.Click += new System.EventHandler(this.lbl_SDT_Click);
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(127, 319);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(40, 20);
            this.lbl_lop.TabIndex = 5;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(116, 375);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(51, 20);
            this.lbl_khoa.TabIndex = 6;
            this.lbl_khoa.Text = "Khóa";
            // 
            // lbl_ngayDen
            // 
            this.lbl_ngayDen.AutoSize = true;
            this.lbl_ngayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayDen.Location = new System.Drawing.Point(740, 87);
            this.lbl_ngayDen.Name = "lbl_ngayDen";
            this.lbl_ngayDen.Size = new System.Drawing.Size(87, 20);
            this.lbl_ngayDen.TabIndex = 7;
            this.lbl_ngayDen.Text = "Ngày đến";
            // 
            // lbl_ngayDi
            // 
            this.lbl_ngayDi.AutoSize = true;
            this.lbl_ngayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayDi.Location = new System.Drawing.Point(755, 145);
            this.lbl_ngayDi.Name = "lbl_ngayDi";
            this.lbl_ngayDi.Size = new System.Drawing.Size(72, 20);
            this.lbl_ngayDi.TabIndex = 8;
            this.lbl_ngayDi.Text = "Ngày đi";
            // 
            // lbl_phong
            // 
            this.lbl_phong.AutoSize = true;
            this.lbl_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.Location = new System.Drawing.Point(766, 203);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(61, 20);
            this.lbl_phong.TabIndex = 9;
            this.lbl_phong.Text = "Phòng";
            // 
            // lbl_giaPhong
            // 
            this.lbl_giaPhong.AutoSize = true;
            this.lbl_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaPhong.Location = new System.Drawing.Point(681, 261);
            this.lbl_giaPhong.Name = "lbl_giaPhong";
            this.lbl_giaPhong.Size = new System.Drawing.Size(146, 20);
            this.lbl_giaPhong.TabIndex = 10;
            this.lbl_giaPhong.Text = "Giá phòng/tháng";
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(191, 84);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(259, 27);
            this.txt_maSV.TabIndex = 12;
            this.txt_maSV.TextChanged += new System.EventHandler(this.txt_maSV_TextChanged);
            // 
            // txt_tenSV
            // 
            this.txt_tenSV.Enabled = false;
            this.txt_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSV.Location = new System.Drawing.Point(191, 142);
            this.txt_tenSV.Name = "txt_tenSV";
            this.txt_tenSV.Size = new System.Drawing.Size(259, 27);
            this.txt_tenSV.TabIndex = 13;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Enabled = false;
            this.txt_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(191, 200);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(259, 27);
            this.txt_diaChi.TabIndex = 14;
            // 
            // txt_soDT
            // 
            this.txt_soDT.Enabled = false;
            this.txt_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDT.Location = new System.Drawing.Point(191, 258);
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(259, 27);
            this.txt_soDT.TabIndex = 15;
            // 
            // txt_lop
            // 
            this.txt_lop.Enabled = false;
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop.Location = new System.Drawing.Point(191, 316);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(259, 27);
            this.txt_lop.TabIndex = 16;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Enabled = false;
            this.txt_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(191, 372);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(259, 27);
            this.txt_khoa.TabIndex = 17;
            // 
            // txt_giaPhong
            // 
            this.txt_giaPhong.Enabled = false;
            this.txt_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaPhong.Location = new System.Drawing.Point(858, 258);
            this.txt_giaPhong.Name = "txt_giaPhong";
            this.txt_giaPhong.Size = new System.Drawing.Size(258, 27);
            this.txt_giaPhong.TabIndex = 21;
            this.txt_giaPhong.TextChanged += new System.EventHandler(this.txt_giaPhong_TextChanged);
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKy.Image = global::QuanLyKyTucXa.Properties.Resources.DanhMuc32;
            this.btn_dangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangKy.Location = new System.Drawing.Point(147, 439);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(112, 43);
            this.btn_dangKy.TabIndex = 23;
            this.btn_dangKy.Text = "Đăng ký";
            this.btn_dangKy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.Xoa16_1;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(624, 439);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 43);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(1002, 439);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(90, 43);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtp_ngayDen
            // 
            this.dtp_ngayDen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayDen.Location = new System.Drawing.Point(858, 78);
            this.dtp_ngayDen.Name = "dtp_ngayDen";
            this.dtp_ngayDen.Size = new System.Drawing.Size(258, 30);
            this.dtp_ngayDen.TabIndex = 28;
            this.dtp_ngayDen.ValueChanged += new System.EventHandler(this.dtp_ngayDen_ValueChanged);
            // 
            // dtp_ngayDi
            // 
            this.dtp_ngayDi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayDi.Location = new System.Drawing.Point(858, 135);
            this.dtp_ngayDi.Name = "dtp_ngayDi";
            this.dtp_ngayDi.Size = new System.Drawing.Size(258, 30);
            this.dtp_ngayDi.TabIndex = 29;
            this.dtp_ngayDi.ValueChanged += new System.EventHandler(this.dtp_ngayDi_ValueChanged);
            // 
            // dgv_dangKy
            // 
            this.dgv_dangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.tenSV,
            this.diaChi,
            this.sdt,
            this.lop,
            this.khoa,
            this.ngayDen,
            this.ngayDi,
            this.maPhong,
            this.giaPhong});
            this.dgv_dangKy.Location = new System.Drawing.Point(12, 510);
            this.dgv_dangKy.Name = "dgv_dangKy";
            this.dgv_dangKy.RowHeadersWidth = 51;
            this.dgv_dangKy.RowTemplate.Height = 24;
            this.dgv_dangKy.Size = new System.Drawing.Size(1167, 274);
            this.dgv_dangKy.TabIndex = 30;
            this.dgv_dangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dangKy_CellClick);
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "MaSV";
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            this.maSV.Width = 140;
            // 
            // tenSV
            // 
            this.tenSV.DataPropertyName = "TenSV";
            this.tenSV.HeaderText = "Tên sinh viên";
            this.tenSV.MinimumWidth = 6;
            this.tenSV.Name = "tenSV";
            this.tenSV.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 150;
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
            this.khoa.DataPropertyName = "Khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // ngayDen
            // 
            this.ngayDen.DataPropertyName = "NgayDen";
            this.ngayDen.HeaderText = "Ngày đến";
            this.ngayDen.MinimumWidth = 6;
            this.ngayDen.Name = "ngayDen";
            this.ngayDen.Width = 140;
            // 
            // ngayDi
            // 
            this.ngayDi.DataPropertyName = "NgayDi";
            this.ngayDi.HeaderText = "Ngày đi";
            this.ngayDi.MinimumWidth = 6;
            this.ngayDi.Name = "ngayDi";
            this.ngayDi.Width = 140;
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "MaPhong";
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.Width = 125;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "GiaPhong";
            this.giaPhong.HeaderText = "Giá phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 125;
            // 
            // cbo_phong
            // 
            this.cbo_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phong.FormattingEnabled = true;
            this.cbo_phong.Location = new System.Drawing.Point(858, 196);
            this.cbo_phong.Name = "cbo_phong";
            this.cbo_phong.Size = new System.Drawing.Size(258, 28);
            this.cbo_phong.TabIndex = 31;
            this.cbo_phong.SelectedIndexChanged += new System.EventHandler(this.cbo_phong_SelectedIndexChanged);
            // 
            // frmDangKyThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1191, 796);
            this.Controls.Add(this.cbo_phong);
            this.Controls.Add(this.dgv_dangKy);
            this.Controls.Add(this.dtp_ngayDi);
            this.Controls.Add(this.dtp_ngayDen);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_dangKy);
            this.Controls.Add(this.txt_giaPhong);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_lop);
            this.Controls.Add(this.txt_soDT);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_tenSV);
            this.Controls.Add(this.txt_maSV);
            this.Controls.Add(this.lbl_giaPhong);
            this.Controls.Add(this.lbl_phong);
            this.Controls.Add(this.lbl_ngayDi);
            this.Controls.Add(this.lbl_ngayDen);
            this.Controls.Add(this.lbl_khoa);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.lbl_diaChi);
            this.Controls.Add(this.lbl_tenSV);
            this.Controls.Add(this.lbl_maSV);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDangKyThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKyThue";
            this.Load += new System.EventHandler(this.frmDangKyThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.Label lbl_tenSV;
        private System.Windows.Forms.Label lbl_diaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_ngayDen;
        private System.Windows.Forms.Label lbl_ngayDi;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.Label lbl_giaPhong;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.TextBox txt_tenSV;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_soDT;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_giaPhong;
        private System.Windows.Forms.Button btn_dangKy;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker dtp_ngayDen;
        private System.Windows.Forms.DateTimePicker dtp_ngayDi;
        private System.Windows.Forms.DataGridView dgv_dangKy;
        private System.Windows.Forms.ComboBox cbo_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
    }
}