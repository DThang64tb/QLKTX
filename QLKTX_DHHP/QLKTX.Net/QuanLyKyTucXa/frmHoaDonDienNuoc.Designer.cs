namespace QuanLyKyTucXa
{
    partial class frmHoaDonDienNuoc
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
            this.cbo_maPhong = new System.Windows.Forms.ComboBox();
            this.dtp_thang = new System.Windows.Forms.DateTimePicker();
            this.txt_chiSoNuocMoi = new System.Windows.Forms.TextBox();
            this.txt_chiSoNuocCu = new System.Windows.Forms.TextBox();
            this.txt_chiSoDienMoi = new System.Windows.Forms.TextBox();
            this.lbl_chiSoNuocMoi = new System.Windows.Forms.Label();
            this.txt_chiSoDienCu = new System.Windows.Forms.TextBox();
            this.lbl_chiSoDienMoi = new System.Windows.Forms.Label();
            this.lbl_chiSoNuocCu = new System.Windows.Forms.Label();
            this.lbl_chiSoDienCu = new System.Windows.Forms.Label();
            this.lbl_thang = new System.Windows.Forms.Label();
            this.lbl_maPhong = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_dienNuoc = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoDienCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoDienMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoNuocCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoNuocMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_soHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_donGiaDien = new System.Windows.Forms.TextBox();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.txt_thanhTienDien = new System.Windows.Forms.TextBox();
            this.txt_thanhTienNuoc = new System.Windows.Forms.TextBox();
            this.txt_donGiaNuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_in_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dienNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_maPhong
            // 
            this.cbo_maPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maPhong.FormattingEnabled = true;
            this.cbo_maPhong.Location = new System.Drawing.Point(244, 115);
            this.cbo_maPhong.Name = "cbo_maPhong";
            this.cbo_maPhong.Size = new System.Drawing.Size(231, 28);
            this.cbo_maPhong.TabIndex = 2;
            this.cbo_maPhong.SelectedIndexChanged += new System.EventHandler(this.cbo_maPhong_SelectedIndexChanged);
            // 
            // dtp_thang
            // 
            this.dtp_thang.CustomFormat = "MM/yyyy";
            this.dtp_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thang.Location = new System.Drawing.Point(885, 71);
            this.dtp_thang.Name = "dtp_thang";
            this.dtp_thang.Size = new System.Drawing.Size(231, 27);
            this.dtp_thang.TabIndex = 3;
            // 
            // txt_chiSoNuocMoi
            // 
            this.txt_chiSoNuocMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiSoNuocMoi.Location = new System.Drawing.Point(885, 163);
            this.txt_chiSoNuocMoi.Name = "txt_chiSoNuocMoi";
            this.txt_chiSoNuocMoi.Size = new System.Drawing.Size(231, 27);
            this.txt_chiSoNuocMoi.TabIndex = 9;
            this.txt_chiSoNuocMoi.TextChanged += new System.EventHandler(this.txt_chiSoNuocMoi_TextChanged);
            // 
            // txt_chiSoNuocCu
            // 
            this.txt_chiSoNuocCu.Enabled = false;
            this.txt_chiSoNuocCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiSoNuocCu.Location = new System.Drawing.Point(885, 115);
            this.txt_chiSoNuocCu.Name = "txt_chiSoNuocCu";
            this.txt_chiSoNuocCu.Size = new System.Drawing.Size(231, 27);
            this.txt_chiSoNuocCu.TabIndex = 8;
            // 
            // txt_chiSoDienMoi
            // 
            this.txt_chiSoDienMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiSoDienMoi.Location = new System.Drawing.Point(244, 216);
            this.txt_chiSoDienMoi.Name = "txt_chiSoDienMoi";
            this.txt_chiSoDienMoi.Size = new System.Drawing.Size(231, 27);
            this.txt_chiSoDienMoi.TabIndex = 5;
            this.txt_chiSoDienMoi.TextChanged += new System.EventHandler(this.txt_chiSoDienMoi_TextChanged);
            // 
            // lbl_chiSoNuocMoi
            // 
            this.lbl_chiSoNuocMoi.AutoSize = true;
            this.lbl_chiSoNuocMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiSoNuocMoi.Location = new System.Drawing.Point(710, 165);
            this.lbl_chiSoNuocMoi.Name = "lbl_chiSoNuocMoi";
            this.lbl_chiSoNuocMoi.Size = new System.Drawing.Size(145, 20);
            this.lbl_chiSoNuocMoi.TabIndex = 9;
            this.lbl_chiSoNuocMoi.Text = "Chỉ số nước mới";
            // 
            // txt_chiSoDienCu
            // 
            this.txt_chiSoDienCu.Enabled = false;
            this.txt_chiSoDienCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiSoDienCu.Location = new System.Drawing.Point(244, 163);
            this.txt_chiSoDienCu.Name = "txt_chiSoDienCu";
            this.txt_chiSoDienCu.Size = new System.Drawing.Size(231, 27);
            this.txt_chiSoDienCu.TabIndex = 4;
            // 
            // lbl_chiSoDienMoi
            // 
            this.lbl_chiSoDienMoi.AutoSize = true;
            this.lbl_chiSoDienMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiSoDienMoi.Location = new System.Drawing.Point(73, 219);
            this.lbl_chiSoDienMoi.Name = "lbl_chiSoDienMoi";
            this.lbl_chiSoDienMoi.Size = new System.Drawing.Size(140, 20);
            this.lbl_chiSoDienMoi.TabIndex = 10;
            this.lbl_chiSoDienMoi.Text = "Chỉ số điện mới";
            // 
            // lbl_chiSoNuocCu
            // 
            this.lbl_chiSoNuocCu.AutoSize = true;
            this.lbl_chiSoNuocCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiSoNuocCu.Location = new System.Drawing.Point(722, 118);
            this.lbl_chiSoNuocCu.Name = "lbl_chiSoNuocCu";
            this.lbl_chiSoNuocCu.Size = new System.Drawing.Size(135, 20);
            this.lbl_chiSoNuocCu.TabIndex = 11;
            this.lbl_chiSoNuocCu.Text = "Chỉ số nước cũ";
            // 
            // lbl_chiSoDienCu
            // 
            this.lbl_chiSoDienCu.AutoSize = true;
            this.lbl_chiSoDienCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiSoDienCu.Location = new System.Drawing.Point(73, 164);
            this.lbl_chiSoDienCu.Name = "lbl_chiSoDienCu";
            this.lbl_chiSoDienCu.Size = new System.Drawing.Size(130, 20);
            this.lbl_chiSoDienCu.TabIndex = 12;
            this.lbl_chiSoDienCu.Text = "Chỉ số điện cũ";
            // 
            // lbl_thang
            // 
            this.lbl_thang.AutoSize = true;
            this.lbl_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thang.Location = new System.Drawing.Point(779, 81);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(60, 20);
            this.lbl_thang.TabIndex = 13;
            this.lbl_thang.Text = "Tháng";
            // 
            // lbl_maPhong
            // 
            this.lbl_maPhong.AutoSize = true;
            this.lbl_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maPhong.Location = new System.Drawing.Point(129, 122);
            this.lbl_maPhong.Name = "lbl_maPhong";
            this.lbl_maPhong.Size = new System.Drawing.Size(61, 20);
            this.lbl_maPhong.TabIndex = 14;
            this.lbl_maPhong.Text = "Phòng";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(368, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(489, 38);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Hóa đơn điện nước hàng tháng";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(90, 382);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(101, 49);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Lập";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QuanLyKyTucXa.Properties.Resources.Sua16_1;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(244, 382);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(99, 49);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.Xoa16_1;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(395, 382);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(99, 49);
            this.btn_xoa.TabIndex = 15;
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
            this.btn_thoat.Location = new System.Drawing.Point(1018, 382);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 49);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_dienNuoc
            // 
            this.dgv_dienNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dienNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.maPhong,
            this.thang,
            this.chiSoDienCu,
            this.chiSoDienMoi,
            this.donGiaDien,
            this.thanhTienDien,
            this.chiSoNuocCu,
            this.chiSoNuocMoi,
            this.donGiaNuoc,
            this.thanhTienNuoc,
            this.tongTien});
            this.dgv_dienNuoc.Location = new System.Drawing.Point(12, 465);
            this.dgv_dienNuoc.Name = "dgv_dienNuoc";
            this.dgv_dienNuoc.RowHeadersWidth = 51;
            this.dgv_dienNuoc.RowTemplate.Height = 24;
            this.dgv_dienNuoc.Size = new System.Drawing.Size(1166, 307);
            this.dgv_dienNuoc.TabIndex = 18;
            this.dgv_dienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dienNuoc_CellClick);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "So";
            this.SoHD.HeaderText = "Số";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 125;
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "MaPhong";
            this.maPhong.HeaderText = "Phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.Width = 125;
            // 
            // thang
            // 
            this.thang.DataPropertyName = "Thang";
            this.thang.HeaderText = "Tháng";
            this.thang.MinimumWidth = 6;
            this.thang.Name = "thang";
            this.thang.Width = 125;
            // 
            // chiSoDienCu
            // 
            this.chiSoDienCu.DataPropertyName = "CSDienCu";
            this.chiSoDienCu.HeaderText = "Chỉ số điện cũ";
            this.chiSoDienCu.MinimumWidth = 6;
            this.chiSoDienCu.Name = "chiSoDienCu";
            this.chiSoDienCu.Width = 150;
            // 
            // chiSoDienMoi
            // 
            this.chiSoDienMoi.DataPropertyName = "CSDienMoi";
            this.chiSoDienMoi.HeaderText = "Chỉ số điện mới";
            this.chiSoDienMoi.MinimumWidth = 6;
            this.chiSoDienMoi.Name = "chiSoDienMoi";
            this.chiSoDienMoi.Width = 150;
            // 
            // donGiaDien
            // 
            this.donGiaDien.DataPropertyName = "DonGiaDien";
            this.donGiaDien.HeaderText = "Đơn giá điện";
            this.donGiaDien.MinimumWidth = 6;
            this.donGiaDien.Name = "donGiaDien";
            this.donGiaDien.Width = 125;
            // 
            // thanhTienDien
            // 
            this.thanhTienDien.DataPropertyName = "ThanhTienDien";
            this.thanhTienDien.HeaderText = "Thành tiền điện";
            this.thanhTienDien.MinimumWidth = 6;
            this.thanhTienDien.Name = "thanhTienDien";
            this.thanhTienDien.Width = 125;
            // 
            // chiSoNuocCu
            // 
            this.chiSoNuocCu.DataPropertyName = "CSNuocCu";
            this.chiSoNuocCu.HeaderText = "Chỉ số nước cũ";
            this.chiSoNuocCu.MinimumWidth = 6;
            this.chiSoNuocCu.Name = "chiSoNuocCu";
            this.chiSoNuocCu.Width = 150;
            // 
            // chiSoNuocMoi
            // 
            this.chiSoNuocMoi.DataPropertyName = "CSNuocMoi";
            this.chiSoNuocMoi.HeaderText = "Chỉ số nước mới";
            this.chiSoNuocMoi.MinimumWidth = 6;
            this.chiSoNuocMoi.Name = "chiSoNuocMoi";
            this.chiSoNuocMoi.Width = 150;
            // 
            // donGiaNuoc
            // 
            this.donGiaNuoc.DataPropertyName = "DonGiaNuoc";
            this.donGiaNuoc.HeaderText = "Đơn giá nước";
            this.donGiaNuoc.MinimumWidth = 6;
            this.donGiaNuoc.Name = "donGiaNuoc";
            this.donGiaNuoc.Width = 125;
            // 
            // thanhTienNuoc
            // 
            this.thanhTienNuoc.DataPropertyName = "ThanhTienNuoc";
            this.thanhTienNuoc.HeaderText = "Thành tiền nước";
            this.thanhTienNuoc.MinimumWidth = 6;
            this.thanhTienNuoc.Name = "thanhTienNuoc";
            this.thanhTienNuoc.Width = 125;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "TongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 125;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(100, 71);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(103, 20);
            this.lbl_ID.TabIndex = 25;
            this.lbl_ID.Text = "Số hóa đơn";
            // 
            // txt_soHD
            // 
            this.txt_soHD.Enabled = false;
            this.txt_soHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soHD.Location = new System.Drawing.Point(244, 71);
            this.txt_soHD.Name = "txt_soHD";
            this.txt_soHD.Size = new System.Drawing.Size(87, 27);
            this.txt_soHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đơn giá điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thành tiền điện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng tiền";
            // 
            // txt_donGiaDien
            // 
            this.txt_donGiaDien.Enabled = false;
            this.txt_donGiaDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGiaDien.Location = new System.Drawing.Point(244, 262);
            this.txt_donGiaDien.Name = "txt_donGiaDien";
            this.txt_donGiaDien.Size = new System.Drawing.Size(231, 27);
            this.txt_donGiaDien.TabIndex = 6;
            this.txt_donGiaDien.Text = "2300";
            this.txt_donGiaDien.TextChanged += new System.EventHandler(this.txt_donGiaDien_TextChanged);
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Enabled = false;
            this.txt_tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTien.Location = new System.Drawing.Point(885, 306);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(231, 27);
            this.txt_tongTien.TabIndex = 12;
            // 
            // txt_thanhTienDien
            // 
            this.txt_thanhTienDien.Enabled = false;
            this.txt_thanhTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhTienDien.Location = new System.Drawing.Point(244, 309);
            this.txt_thanhTienDien.Name = "txt_thanhTienDien";
            this.txt_thanhTienDien.Size = new System.Drawing.Size(231, 27);
            this.txt_thanhTienDien.TabIndex = 7;
            this.txt_thanhTienDien.TextChanged += new System.EventHandler(this.txt_thanhTienDien_TextChanged);
            // 
            // txt_thanhTienNuoc
            // 
            this.txt_thanhTienNuoc.Enabled = false;
            this.txt_thanhTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhTienNuoc.Location = new System.Drawing.Point(885, 257);
            this.txt_thanhTienNuoc.Name = "txt_thanhTienNuoc";
            this.txt_thanhTienNuoc.Size = new System.Drawing.Size(231, 27);
            this.txt_thanhTienNuoc.TabIndex = 11;
            this.txt_thanhTienNuoc.TextChanged += new System.EventHandler(this.txt_thanhTienNuoc_TextChanged);
            // 
            // txt_donGiaNuoc
            // 
            this.txt_donGiaNuoc.Enabled = false;
            this.txt_donGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGiaNuoc.Location = new System.Drawing.Point(885, 209);
            this.txt_donGiaNuoc.Name = "txt_donGiaNuoc";
            this.txt_donGiaNuoc.Size = new System.Drawing.Size(231, 27);
            this.txt_donGiaNuoc.TabIndex = 10;
            this.txt_donGiaNuoc.Text = "5600";
            this.txt_donGiaNuoc.TextChanged += new System.EventHandler(this.txt_donGiaNuoc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thành tiền nước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Đơn giá nước";
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(563, 382);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(139, 49);
            this.btn_in.TabIndex = 16;
            this.btn_in.Text = "In Word";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_in_excel
            // 
            this.btn_in_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in_excel.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_in_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in_excel.Location = new System.Drawing.Point(783, 382);
            this.btn_in_excel.Name = "btn_in_excel";
            this.btn_in_excel.Size = new System.Drawing.Size(139, 49);
            this.btn_in_excel.TabIndex = 34;
            this.btn_in_excel.Text = "In Excel";
            this.btn_in_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in_excel.UseVisualStyleBackColor = true;
            this.btn_in_excel.Click += new System.EventHandler(this.btn_in_excel_Click);
            // 
            // frmHoaDonDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 784);
            this.Controls.Add(this.btn_in_excel);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.txt_thanhTienNuoc);
            this.Controls.Add(this.txt_donGiaNuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_thanhTienDien);
            this.Controls.Add(this.txt_tongTien);
            this.Controls.Add(this.txt_donGiaDien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soHD);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dgv_dienNuoc);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbo_maPhong);
            this.Controls.Add(this.dtp_thang);
            this.Controls.Add(this.txt_chiSoNuocMoi);
            this.Controls.Add(this.txt_chiSoNuocCu);
            this.Controls.Add(this.txt_chiSoDienMoi);
            this.Controls.Add(this.lbl_chiSoNuocMoi);
            this.Controls.Add(this.txt_chiSoDienCu);
            this.Controls.Add(this.lbl_chiSoDienMoi);
            this.Controls.Add(this.lbl_chiSoNuocCu);
            this.Controls.Add(this.lbl_chiSoDienCu);
            this.Controls.Add(this.lbl_thang);
            this.Controls.Add(this.lbl_maPhong);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHoaDonDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonDienNuoc";
            this.Load += new System.EventHandler(this.frmHoaDonDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dienNuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_maPhong;
        private System.Windows.Forms.DateTimePicker dtp_thang;
        private System.Windows.Forms.TextBox txt_chiSoNuocMoi;
        private System.Windows.Forms.TextBox txt_chiSoNuocCu;
        private System.Windows.Forms.TextBox txt_chiSoDienMoi;
        private System.Windows.Forms.Label lbl_chiSoNuocMoi;
        private System.Windows.Forms.TextBox txt_chiSoDienCu;
        private System.Windows.Forms.Label lbl_chiSoDienMoi;
        private System.Windows.Forms.Label lbl_chiSoNuocCu;
        private System.Windows.Forms.Label lbl_chiSoDienCu;
        private System.Windows.Forms.Label lbl_thang;
        private System.Windows.Forms.Label lbl_maPhong;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_dienNuoc;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_soHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_donGiaDien;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.TextBox txt_thanhTienDien;
        private System.Windows.Forms.TextBox txt_thanhTienNuoc;
        private System.Windows.Forms.TextBox txt_donGiaNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoDienCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoDienMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoNuocCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoNuocMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.Button btn_in_excel;
    }
}