namespace QuanLyKyTucXa
{
    partial class frmHopDong
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
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.txt_tenSV = new System.Windows.Forms.TextBox();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_tenSV = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_giaHan = new System.Windows.Forms.Button();
            this.btn_LapHD = new System.Windows.Forms.Button();
            this.dgv_hopDong = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtp_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.txt_giaPhong = new System.Windows.Forms.TextBox();
            this.lbl_giaPhong = new System.Windows.Forms.Label();
            this.lbl_maPhong = new System.Windows.Forms.Label();
            this.txt_maSinhVien = new System.Windows.Forms.TextBox();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.lbl_ngayLap = new System.Windows.Forms.Label();
            this.txt_maHopDong = new System.Windows.Forms.TextBox();
            this.lbl_maHopDong = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dtp_ngayDi = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayDen = new System.Windows.Forms.DateTimePicker();
            this.lbl_ngayDi = new System.Windows.Forms.Label();
            this.lbl_ngayDen = new System.Windows.Forms.Label();
            this.btn_In = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_phong
            // 
            this.txt_phong.Enabled = false;
            this.txt_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phong.Location = new System.Drawing.Point(829, 137);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(280, 27);
            this.txt_phong.TabIndex = 61;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Enabled = false;
            this.txt_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(829, 82);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(280, 27);
            this.txt_khoa.TabIndex = 60;
            // 
            // txt_lop
            // 
            this.txt_lop.Enabled = false;
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop.Location = new System.Drawing.Point(248, 300);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(280, 27);
            this.txt_lop.TabIndex = 59;
            // 
            // txt_tenSV
            // 
            this.txt_tenSV.Enabled = false;
            this.txt_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSV.Location = new System.Drawing.Point(248, 245);
            this.txt_tenSV.Name = "txt_tenSV";
            this.txt_tenSV.Size = new System.Drawing.Size(280, 27);
            this.txt_tenSV.TabIndex = 56;
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(725, 85);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(51, 20);
            this.lbl_khoa.TabIndex = 55;
            this.lbl_khoa.Text = "Khóa";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(174, 299);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(40, 20);
            this.lbl_lop.TabIndex = 54;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_tenSV
            // 
            this.lbl_tenSV.AutoSize = true;
            this.lbl_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSV.Location = new System.Drawing.Point(93, 248);
            this.lbl_tenSV.Name = "lbl_tenSV";
            this.lbl_tenSV.Size = new System.Drawing.Size(121, 20);
            this.lbl_tenSV.TabIndex = 51;
            this.lbl_tenSV.Text = "Tên sinh viên";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.Xoa16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(592, 364);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_giaHan
            // 
            this.btn_giaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giaHan.Image = global::QuanLyKyTucXa.Properties.Resources.Sua16_1;
            this.btn_giaHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giaHan.Location = new System.Drawing.Point(381, 364);
            this.btn_giaHan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giaHan.Name = "btn_giaHan";
            this.btn_giaHan.Size = new System.Drawing.Size(89, 46);
            this.btn_giaHan.TabIndex = 41;
            this.btn_giaHan.Text = "Gia hạn";
            this.btn_giaHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giaHan.UseVisualStyleBackColor = true;
            this.btn_giaHan.Click += new System.EventHandler(this.btn_giaHan_Click);
            // 
            // btn_LapHD
            // 
            this.btn_LapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LapHD.Image = global::QuanLyKyTucXa.Properties.Resources.Them32_1;
            this.btn_LapHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LapHD.Location = new System.Drawing.Point(146, 364);
            this.btn_LapHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LapHD.Name = "btn_LapHD";
            this.btn_LapHD.Size = new System.Drawing.Size(89, 46);
            this.btn_LapHD.TabIndex = 39;
            this.btn_LapHD.Text = "Lập HD";
            this.btn_LapHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LapHD.UseVisualStyleBackColor = true;
            this.btn_LapHD.Click += new System.EventHandler(this.btn_LapHD_Click);
            // 
            // dgv_hopDong
            // 
            this.dgv_hopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.ngayLap,
            this.maSV,
            this.tenSV,
            this.lop,
            this.khoa,
            this.dsPhong,
            this.giaPhong,
            this.ngayDen,
            this.ngayDi});
            this.dgv_hopDong.Location = new System.Drawing.Point(13, 442);
            this.dgv_hopDong.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hopDong.Name = "dgv_hopDong";
            this.dgv_hopDong.RowHeadersWidth = 51;
            this.dgv_hopDong.RowTemplate.Height = 24;
            this.dgv_hopDong.Size = new System.Drawing.Size(1163, 331);
            this.dgv_hopDong.TabIndex = 47;
            this.dgv_hopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hopDong_CellClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "MaHD";
            this.maHD.HeaderText = "Mã hợp đồng";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.Width = 150;
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "NgayLap";
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.Width = 150;
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
            // dsPhong
            // 
            this.dsPhong.DataPropertyName = "MaPhong";
            this.dsPhong.HeaderText = "Phòng";
            this.dsPhong.MinimumWidth = 6;
            this.dsPhong.Name = "dsPhong";
            this.dsPhong.Width = 150;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "GiaPhong";
            this.giaPhong.HeaderText = "Giá phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 150;
            // 
            // ngayDen
            // 
            this.ngayDen.DataPropertyName = "NgayDen";
            this.ngayDen.HeaderText = "Ngày đến";
            this.ngayDen.MinimumWidth = 6;
            this.ngayDen.Name = "ngayDen";
            this.ngayDen.Width = 150;
            // 
            // ngayDi
            // 
            this.ngayDi.DataPropertyName = "NgayDi";
            this.ngayDi.HeaderText = "Ngày đi";
            this.ngayDi.MinimumWidth = 6;
            this.ngayDi.Name = "ngayDi";
            this.ngayDi.Width = 150;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(1020, 364);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(89, 46);
            this.btn_thoat.TabIndex = 45;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.Enabled = false;
            this.dtp_ngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayLap.Location = new System.Drawing.Point(248, 135);
            this.dtp_ngayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.Size = new System.Drawing.Size(280, 27);
            this.dtp_ngayLap.TabIndex = 33;
            // 
            // txt_giaPhong
            // 
            this.txt_giaPhong.Enabled = false;
            this.txt_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaPhong.Location = new System.Drawing.Point(829, 188);
            this.txt_giaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giaPhong.Name = "txt_giaPhong";
            this.txt_giaPhong.Size = new System.Drawing.Size(280, 27);
            this.txt_giaPhong.TabIndex = 35;
            // 
            // lbl_giaPhong
            // 
            this.lbl_giaPhong.AutoSize = true;
            this.lbl_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaPhong.Location = new System.Drawing.Point(682, 195);
            this.lbl_giaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_giaPhong.Name = "lbl_giaPhong";
            this.lbl_giaPhong.Size = new System.Drawing.Size(94, 20);
            this.lbl_giaPhong.TabIndex = 40;
            this.lbl_giaPhong.Text = "Giá phòng";
            // 
            // lbl_maPhong
            // 
            this.lbl_maPhong.AutoSize = true;
            this.lbl_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maPhong.Location = new System.Drawing.Point(715, 140);
            this.lbl_maPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maPhong.Name = "lbl_maPhong";
            this.lbl_maPhong.Size = new System.Drawing.Size(61, 20);
            this.lbl_maPhong.TabIndex = 44;
            this.lbl_maPhong.Text = "Phòng";
            // 
            // txt_maSinhVien
            // 
            this.txt_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSinhVien.Location = new System.Drawing.Point(248, 189);
            this.txt_maSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maSinhVien.Name = "txt_maSinhVien";
            this.txt_maSinhVien.Size = new System.Drawing.Size(280, 27);
            this.txt_maSinhVien.TabIndex = 34;
            this.txt_maSinhVien.TextChanged += new System.EventHandler(this.txt_maSinhVien_TextChanged);
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSV.Location = new System.Drawing.Point(99, 192);
            this.lbl_maSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(115, 20);
            this.lbl_maSV.TabIndex = 48;
            this.lbl_maSV.Text = "Mã sinh viên";
            // 
            // lbl_ngayLap
            // 
            this.lbl_ngayLap.AutoSize = true;
            this.lbl_ngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayLap.Location = new System.Drawing.Point(132, 132);
            this.lbl_ngayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ngayLap.Name = "lbl_ngayLap";
            this.lbl_ngayLap.Size = new System.Drawing.Size(82, 20);
            this.lbl_ngayLap.TabIndex = 49;
            this.lbl_ngayLap.Text = "Ngày lập";
            // 
            // txt_maHopDong
            // 
            this.txt_maHopDong.Enabled = false;
            this.txt_maHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHopDong.Location = new System.Drawing.Point(248, 82);
            this.txt_maHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maHopDong.Name = "txt_maHopDong";
            this.txt_maHopDong.Size = new System.Drawing.Size(57, 27);
            this.txt_maHopDong.TabIndex = 32;
            // 
            // lbl_maHopDong
            // 
            this.lbl_maHopDong.AutoSize = true;
            this.lbl_maHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maHopDong.Location = new System.Drawing.Point(98, 85);
            this.lbl_maHopDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maHopDong.Name = "lbl_maHopDong";
            this.lbl_maHopDong.Size = new System.Drawing.Size(116, 20);
            this.lbl_maHopDong.TabIndex = 50;
            this.lbl_maHopDong.Text = "Mã hợp đồng";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(415, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(348, 38);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Hợp đồng thuê phòng";
            // 
            // dtp_ngayDi
            // 
            this.dtp_ngayDi.Enabled = false;
            this.dtp_ngayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayDi.Location = new System.Drawing.Point(829, 295);
            this.dtp_ngayDi.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayDi.Name = "dtp_ngayDi";
            this.dtp_ngayDi.Size = new System.Drawing.Size(280, 27);
            this.dtp_ngayDi.TabIndex = 63;
            // 
            // dtp_ngayDen
            // 
            this.dtp_ngayDen.Enabled = false;
            this.dtp_ngayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayDen.Location = new System.Drawing.Point(829, 243);
            this.dtp_ngayDen.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayDen.Name = "dtp_ngayDen";
            this.dtp_ngayDen.Size = new System.Drawing.Size(280, 27);
            this.dtp_ngayDen.TabIndex = 62;
            // 
            // lbl_ngayDi
            // 
            this.lbl_ngayDi.AutoSize = true;
            this.lbl_ngayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayDi.Location = new System.Drawing.Point(704, 298);
            this.lbl_ngayDi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ngayDi.Name = "lbl_ngayDi";
            this.lbl_ngayDi.Size = new System.Drawing.Size(72, 20);
            this.lbl_ngayDi.TabIndex = 64;
            this.lbl_ngayDi.Text = "Ngày đi";
            // 
            // lbl_ngayDen
            // 
            this.lbl_ngayDen.AutoSize = true;
            this.lbl_ngayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayDen.Location = new System.Drawing.Point(689, 248);
            this.lbl_ngayDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ngayDen.Name = "lbl_ngayDen";
            this.lbl_ngayDen.Size = new System.Drawing.Size(87, 20);
            this.lbl_ngayDen.TabIndex = 65;
            this.lbl_ngayDen.Text = "Ngày đến";
            // 
            // btn_In
            // 
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(811, 364);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(89, 46);
            this.btn_In.TabIndex = 66;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 784);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.dtp_ngayDi);
            this.Controls.Add(this.dtp_ngayDen);
            this.Controls.Add(this.lbl_ngayDi);
            this.Controls.Add(this.lbl_ngayDen);
            this.Controls.Add(this.txt_phong);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_lop);
            this.Controls.Add(this.txt_tenSV);
            this.Controls.Add(this.lbl_khoa);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_tenSV);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_giaHan);
            this.Controls.Add(this.btn_LapHD);
            this.Controls.Add(this.dgv_hopDong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dtp_ngayLap);
            this.Controls.Add(this.txt_giaPhong);
            this.Controls.Add(this.lbl_giaPhong);
            this.Controls.Add(this.lbl_maPhong);
            this.Controls.Add(this.txt_maSinhVien);
            this.Controls.Add(this.lbl_maSV);
            this.Controls.Add(this.lbl_ngayLap);
            this.Controls.Add(this.txt_maHopDong);
            this.Controls.Add(this.lbl_maHopDong);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.TextBox txt_tenSV;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_tenSV;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_giaHan;
        private System.Windows.Forms.Button btn_LapHD;
        private System.Windows.Forms.DataGridView dgv_hopDong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker dtp_ngayLap;
        private System.Windows.Forms.TextBox txt_giaPhong;
        private System.Windows.Forms.Label lbl_giaPhong;
        private System.Windows.Forms.Label lbl_maPhong;
        private System.Windows.Forms.TextBox txt_maSinhVien;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.Label lbl_ngayLap;
        private System.Windows.Forms.TextBox txt_maHopDong;
        private System.Windows.Forms.Label lbl_maHopDong;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DateTimePicker dtp_ngayDi;
        private System.Windows.Forms.DateTimePicker dtp_ngayDen;
        private System.Windows.Forms.Label lbl_ngayDi;
        private System.Windows.Forms.Label lbl_ngayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDi;
        private System.Windows.Forms.Button btn_In;
    }
}