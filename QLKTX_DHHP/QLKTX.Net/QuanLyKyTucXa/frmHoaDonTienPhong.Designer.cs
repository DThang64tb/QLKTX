namespace QuanLyKyTucXa
{
    partial class cbo_maPhong
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
            this.lbl_maHD = new System.Windows.Forms.Label();
            this.lbl_maSV = new System.Windows.Forms.Label();
            this.lbl_tenSV = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_phong = new System.Windows.Forms.Label();
            this.lbl_soTien = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.txt_tenSV = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.txt_soTien = new System.Windows.Forms.TextBox();
            this.txt_nguoiLap = new System.Windows.Forms.TextBox();
            this.grb_noiDung = new System.Windows.Forms.GroupBox();
            this.txt_noiDung = new System.Windows.Forms.RichTextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_HDTienPhong = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_in_excel = new System.Windows.Forms.Button();
            this.grb_noiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDTienPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(388, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(376, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Hóa đơn thu tiền phòng";
            // 
            // lbl_maHD
            // 
            this.lbl_maHD.AutoSize = true;
            this.lbl_maHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maHD.Location = new System.Drawing.Point(125, 76);
            this.lbl_maHD.Name = "lbl_maHD";
            this.lbl_maHD.Size = new System.Drawing.Size(31, 20);
            this.lbl_maHD.TabIndex = 1;
            this.lbl_maHD.Text = "Số";
            // 
            // lbl_maSV
            // 
            this.lbl_maSV.AutoSize = true;
            this.lbl_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSV.Location = new System.Drawing.Point(50, 119);
            this.lbl_maSV.Name = "lbl_maSV";
            this.lbl_maSV.Size = new System.Drawing.Size(115, 20);
            this.lbl_maSV.TabIndex = 1;
            this.lbl_maSV.Text = "Mã sinh viên";
            // 
            // lbl_tenSV
            // 
            this.lbl_tenSV.AutoSize = true;
            this.lbl_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSV.Location = new System.Drawing.Point(44, 163);
            this.lbl_tenSV.Name = "lbl_tenSV";
            this.lbl_tenSV.Size = new System.Drawing.Size(121, 20);
            this.lbl_tenSV.TabIndex = 1;
            this.lbl_tenSV.Text = "Tên sinh viên";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(116, 213);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(40, 20);
            this.lbl_lop.TabIndex = 1;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(750, 73);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(87, 20);
            this.lbl_khoa.TabIndex = 1;
            this.lbl_khoa.Text = "Khóa học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(776, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phòng";
            // 
            // lbl_phong
            // 
            this.lbl_phong.AutoSize = true;
            this.lbl_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.Location = new System.Drawing.Point(769, 170);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(68, 20);
            this.lbl_phong.TabIndex = 1;
            this.lbl_phong.Text = "Số tiền";
            // 
            // lbl_soTien
            // 
            this.lbl_soTien.AutoSize = true;
            this.lbl_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soTien.Location = new System.Drawing.Point(749, 210);
            this.lbl_soTien.Name = "lbl_soTien";
            this.lbl_soTien.Size = new System.Drawing.Size(88, 20);
            this.lbl_soTien.TabIndex = 1;
            this.lbl_soTien.Text = "Người lập";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Enabled = false;
            this.txt_maHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHD.Location = new System.Drawing.Point(195, 73);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(66, 27);
            this.txt_maHD.TabIndex = 1;
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(195, 119);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(270, 27);
            this.txt_maSV.TabIndex = 2;
            this.txt_maSV.TextChanged += new System.EventHandler(this.txt_maSV_TextChanged);
            // 
            // txt_tenSV
            // 
            this.txt_tenSV.Enabled = false;
            this.txt_tenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSV.Location = new System.Drawing.Point(195, 163);
            this.txt_tenSV.Name = "txt_tenSV";
            this.txt_tenSV.Size = new System.Drawing.Size(270, 27);
            this.txt_tenSV.TabIndex = 3;
            // 
            // txt_lop
            // 
            this.txt_lop.Enabled = false;
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop.Location = new System.Drawing.Point(195, 210);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(270, 27);
            this.txt_lop.TabIndex = 4;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Enabled = false;
            this.txt_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(877, 66);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(270, 27);
            this.txt_khoa.TabIndex = 5;
            // 
            // txt_phong
            // 
            this.txt_phong.Enabled = false;
            this.txt_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phong.Location = new System.Drawing.Point(877, 119);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(270, 27);
            this.txt_phong.TabIndex = 6;
            this.txt_phong.TextChanged += new System.EventHandler(this.txt_phong_TextChanged);
            // 
            // txt_soTien
            // 
            this.txt_soTien.Enabled = false;
            this.txt_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soTien.Location = new System.Drawing.Point(877, 163);
            this.txt_soTien.Name = "txt_soTien";
            this.txt_soTien.Size = new System.Drawing.Size(270, 27);
            this.txt_soTien.TabIndex = 8;
            // 
            // txt_nguoiLap
            // 
            this.txt_nguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguoiLap.Location = new System.Drawing.Point(877, 210);
            this.txt_nguoiLap.Name = "txt_nguoiLap";
            this.txt_nguoiLap.Size = new System.Drawing.Size(270, 27);
            this.txt_nguoiLap.TabIndex = 9;
            // 
            // grb_noiDung
            // 
            this.grb_noiDung.Controls.Add(this.txt_noiDung);
            this.grb_noiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_noiDung.Location = new System.Drawing.Point(234, 253);
            this.grb_noiDung.Name = "grb_noiDung";
            this.grb_noiDung.Size = new System.Drawing.Size(712, 179);
            this.grb_noiDung.TabIndex = 3;
            this.grb_noiDung.TabStop = false;
            this.grb_noiDung.Text = "Nội dung";
            // 
            // txt_noiDung
            // 
            this.txt_noiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noiDung.Location = new System.Drawing.Point(93, 35);
            this.txt_noiDung.Name = "txt_noiDung";
            this.txt_noiDung.Size = new System.Drawing.Size(535, 116);
            this.txt_noiDung.TabIndex = 7;
            this.txt_noiDung.Text = "";
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(120, 447);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(124, 56);
            this.btn_luu.TabIndex = 10;
            this.btn_luu.Text = "Lập phiếu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QuanLyKyTucXa.Properties.Resources.Sua16_1;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(275, 447);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(124, 56);
            this.btn_sua.TabIndex = 11;
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
            this.btn_xoa.Location = new System.Drawing.Point(434, 447);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(124, 56);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(609, 447);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(124, 56);
            this.btn_in.TabIndex = 13;
            this.btn_in.Text = "In Word";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(978, 447);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(124, 56);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_HDTienPhong
            // 
            this.dgv_HDTienPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDTienPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.maSV,
            this.tenSV,
            this.lop,
            this.khoa,
            this.phong,
            this.noiDung,
            this.soTien,
            this.nguoiLap});
            this.dgv_HDTienPhong.Location = new System.Drawing.Point(12, 520);
            this.dgv_HDTienPhong.Name = "dgv_HDTienPhong";
            this.dgv_HDTienPhong.RowHeadersWidth = 51;
            this.dgv_HDTienPhong.RowTemplate.Height = 24;
            this.dgv_HDTienPhong.Size = new System.Drawing.Size(1157, 253);
            this.dgv_HDTienPhong.TabIndex = 16;
            this.dgv_HDTienPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDTienPhong_CellClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "MaHD";
            this.maHD.HeaderText = "Mã hợp đồng";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.Width = 150;
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
            this.tenSV.Width = 150;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 150;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "Khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 150;
            // 
            // phong
            // 
            this.phong.DataPropertyName = "Phong";
            this.phong.HeaderText = "Phòng";
            this.phong.MinimumWidth = 6;
            this.phong.Name = "phong";
            this.phong.Width = 150;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "NoiDung";
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.MinimumWidth = 6;
            this.noiDung.Name = "noiDung";
            this.noiDung.Width = 150;
            // 
            // soTien
            // 
            this.soTien.DataPropertyName = "SoTien";
            this.soTien.HeaderText = "Số tiền";
            this.soTien.MinimumWidth = 6;
            this.soTien.Name = "soTien";
            this.soTien.Width = 150;
            // 
            // nguoiLap
            // 
            this.nguoiLap.DataPropertyName = "NguoiLap";
            this.nguoiLap.HeaderText = "Người lập hóa đơn";
            this.nguoiLap.MinimumWidth = 6;
            this.nguoiLap.Name = "nguoiLap";
            this.nguoiLap.Width = 150;
            // 
            // btn_in_excel
            // 
            this.btn_in_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in_excel.Image = global::QuanLyKyTucXa.Properties.Resources.luu;
            this.btn_in_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in_excel.Location = new System.Drawing.Point(780, 447);
            this.btn_in_excel.Name = "btn_in_excel";
            this.btn_in_excel.Size = new System.Drawing.Size(124, 56);
            this.btn_in_excel.TabIndex = 17;
            this.btn_in_excel.Text = "In Excel";
            this.btn_in_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in_excel.UseVisualStyleBackColor = true;
            this.btn_in_excel.Click += new System.EventHandler(this.btn_in_excel_Click);
            // 
            // cbo_maPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1181, 784);
            this.Controls.Add(this.btn_in_excel);
            this.Controls.Add(this.dgv_HDTienPhong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.grb_noiDung);
            this.Controls.Add(this.txt_nguoiLap);
            this.Controls.Add(this.txt_lop);
            this.Controls.Add(this.txt_soTien);
            this.Controls.Add(this.txt_tenSV);
            this.Controls.Add(this.txt_phong);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.txt_maSV);
            this.Controls.Add(this.txt_maHD);
            this.Controls.Add(this.lbl_soTien);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_phong);
            this.Controls.Add(this.lbl_tenSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_khoa);
            this.Controls.Add(this.lbl_maSV);
            this.Controls.Add(this.lbl_maHD);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "cbo_maPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonTienPhong";
            this.Load += new System.EventHandler(this.frmHoaDonTienPhong_Load);
            this.grb_noiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDTienPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_maHD;
        private System.Windows.Forms.Label lbl_maSV;
        private System.Windows.Forms.Label lbl_tenSV;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.Label lbl_soTien;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.TextBox txt_tenSV;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.TextBox txt_soTien;
        private System.Windows.Forms.TextBox txt_nguoiLap;
        private System.Windows.Forms.GroupBox grb_noiDung;
        private System.Windows.Forms.RichTextBox txt_noiDung;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_HDTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiLap;
        private System.Windows.Forms.Button btn_in_excel;
    }
}