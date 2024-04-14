namespace QuanLyKyTucXa
{
    partial class frmQuanLyPhong
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
            this.txt_loaiPhong = new System.Windows.Forms.TextBox();
            this.grb_giaPhong = new System.Windows.Forms.GroupBox();
            this.txt_giaPhong = new System.Windows.Forms.TextBox();
            this.lbl_giaPhong = new System.Windows.Forms.Label();
            this.cbo_maKhu = new System.Windows.Forms.ComboBox();
            this.txt_soNguoiMax = new System.Windows.Forms.TextBox();
            this.txt_soNguoiHT = new System.Windows.Forms.TextBox();
            this.txt_tenPhong = new System.Windows.Forms.TextBox();
            this.lbl_soNguoiMax = new System.Windows.Forms.Label();
            this.txt_maPhong = new System.Windows.Forms.TextBox();
            this.lbl_tenPhong = new System.Windows.Forms.Label();
            this.lbl_loaiPhong = new System.Windows.Forms.Label();
            this.lbl_songuoiHT = new System.Windows.Forms.Label();
            this.lbl_maKhu = new System.Windows.Forms.Label();
            this.lbl_maPhong = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_qlPhong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grb_giaPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_loaiPhong
            // 
            this.txt_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaiPhong.Location = new System.Drawing.Point(839, 82);
            this.txt_loaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_loaiPhong.Name = "txt_loaiPhong";
            this.txt_loaiPhong.Size = new System.Drawing.Size(236, 27);
            this.txt_loaiPhong.TabIndex = 25;
            // 
            // grb_giaPhong
            // 
            this.grb_giaPhong.Controls.Add(this.txt_giaPhong);
            this.grb_giaPhong.Controls.Add(this.lbl_giaPhong);
            this.grb_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_giaPhong.Location = new System.Drawing.Point(286, 259);
            this.grb_giaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.grb_giaPhong.Name = "grb_giaPhong";
            this.grb_giaPhong.Padding = new System.Windows.Forms.Padding(4);
            this.grb_giaPhong.Size = new System.Drawing.Size(609, 98);
            this.grb_giaPhong.TabIndex = 28;
            this.grb_giaPhong.TabStop = false;
            this.grb_giaPhong.Text = "Giá phòng/Sinh viên/Tháng";
            // 
            // txt_giaPhong
            // 
            this.txt_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaPhong.Location = new System.Drawing.Point(211, 40);
            this.txt_giaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giaPhong.Name = "txt_giaPhong";
            this.txt_giaPhong.Size = new System.Drawing.Size(305, 27);
            this.txt_giaPhong.TabIndex = 7;
            // 
            // lbl_giaPhong
            // 
            this.lbl_giaPhong.AutoSize = true;
            this.lbl_giaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaPhong.Location = new System.Drawing.Point(106, 44);
            this.lbl_giaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giaPhong.Name = "lbl_giaPhong";
            this.lbl_giaPhong.Size = new System.Drawing.Size(61, 20);
            this.lbl_giaPhong.TabIndex = 15;
            this.lbl_giaPhong.Text = "Số tiền";
            // 
            // cbo_maKhu
            // 
            this.cbo_maKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maKhu.FormattingEnabled = true;
            this.cbo_maKhu.Location = new System.Drawing.Point(232, 144);
            this.cbo_maKhu.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_maKhu.Name = "cbo_maKhu";
            this.cbo_maKhu.Size = new System.Drawing.Size(238, 28);
            this.cbo_maKhu.TabIndex = 21;
            this.cbo_maKhu.SelectedIndexChanged += new System.EventHandler(this.cbo_maKhu_SelectedIndexChanged);
            // 
            // txt_soNguoiMax
            // 
            this.txt_soNguoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soNguoiMax.Location = new System.Drawing.Point(838, 200);
            this.txt_soNguoiMax.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soNguoiMax.Name = "txt_soNguoiMax";
            this.txt_soNguoiMax.Size = new System.Drawing.Size(238, 27);
            this.txt_soNguoiMax.TabIndex = 27;
            // 
            // txt_soNguoiHT
            // 
            this.txt_soNguoiHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soNguoiHT.Location = new System.Drawing.Point(839, 144);
            this.txt_soNguoiHT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soNguoiHT.Name = "txt_soNguoiHT";
            this.txt_soNguoiHT.Size = new System.Drawing.Size(238, 27);
            this.txt_soNguoiHT.TabIndex = 26;
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenPhong.Location = new System.Drawing.Point(232, 202);
            this.txt_tenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Size = new System.Drawing.Size(238, 27);
            this.txt_tenPhong.TabIndex = 24;
            // 
            // lbl_soNguoiMax
            // 
            this.lbl_soNguoiMax.AutoSize = true;
            this.lbl_soNguoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soNguoiMax.Location = new System.Drawing.Point(629, 204);
            this.lbl_soNguoiMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soNguoiMax.Name = "lbl_soNguoiMax";
            this.lbl_soNguoiMax.Size = new System.Drawing.Size(135, 20);
            this.lbl_soNguoiMax.TabIndex = 23;
            this.lbl_soNguoiMax.Text = "Số người tối đa";
            // 
            // txt_maPhong
            // 
            this.txt_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maPhong.Location = new System.Drawing.Point(232, 82);
            this.txt_maPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maPhong.Name = "txt_maPhong";
            this.txt_maPhong.Size = new System.Drawing.Size(238, 27);
            this.txt_maPhong.TabIndex = 18;
            // 
            // lbl_tenPhong
            // 
            this.lbl_tenPhong.AutoSize = true;
            this.lbl_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenPhong.Location = new System.Drawing.Point(78, 206);
            this.lbl_tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenPhong.Name = "lbl_tenPhong";
            this.lbl_tenPhong.Size = new System.Drawing.Size(96, 20);
            this.lbl_tenPhong.TabIndex = 22;
            this.lbl_tenPhong.Text = "Tên phòng";
            // 
            // lbl_loaiPhong
            // 
            this.lbl_loaiPhong.AutoSize = true;
            this.lbl_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loaiPhong.Location = new System.Drawing.Point(664, 84);
            this.lbl_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loaiPhong.Name = "lbl_loaiPhong";
            this.lbl_loaiPhong.Size = new System.Drawing.Size(101, 20);
            this.lbl_loaiPhong.TabIndex = 17;
            this.lbl_loaiPhong.Text = "Loại phòng";
            // 
            // lbl_songuoiHT
            // 
            this.lbl_songuoiHT.AutoSize = true;
            this.lbl_songuoiHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_songuoiHT.Location = new System.Drawing.Point(611, 144);
            this.lbl_songuoiHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_songuoiHT.Name = "lbl_songuoiHT";
            this.lbl_songuoiHT.Size = new System.Drawing.Size(150, 20);
            this.lbl_songuoiHT.TabIndex = 16;
            this.lbl_songuoiHT.Text = "Số người hiện tại";
            // 
            // lbl_maKhu
            // 
            this.lbl_maKhu.AutoSize = true;
            this.lbl_maKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maKhu.Location = new System.Drawing.Point(130, 147);
            this.lbl_maKhu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maKhu.Name = "lbl_maKhu";
            this.lbl_maKhu.Size = new System.Drawing.Size(41, 20);
            this.lbl_maKhu.TabIndex = 20;
            this.lbl_maKhu.Text = "Khu";
            // 
            // lbl_maPhong
            // 
            this.lbl_maPhong.AutoSize = true;
            this.lbl_maPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maPhong.Location = new System.Drawing.Point(84, 84);
            this.lbl_maPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maPhong.Name = "lbl_maPhong";
            this.lbl_maPhong.Size = new System.Drawing.Size(90, 20);
            this.lbl_maPhong.TabIndex = 19;
            this.lbl_maPhong.Text = "Mã phòng";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(465, 25);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(242, 38);
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "Quản lý phòng";
            // 
            // dgv_qlPhong
            // 
            this.dgv_qlPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.maKhu,
            this.tenPhong,
            this.loaiPhong,
            this.soNguoiHT,
            this.soNguoiMax,
            this.giaPhong});
            this.dgv_qlPhong.Location = new System.Drawing.Point(10, 474);
            this.dgv_qlPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_qlPhong.Name = "dgv_qlPhong";
            this.dgv_qlPhong.RowHeadersWidth = 51;
            this.dgv_qlPhong.RowTemplate.Height = 24;
            this.dgv_qlPhong.Size = new System.Drawing.Size(1152, 294);
            this.dgv_qlPhong.TabIndex = 33;
            this.dgv_qlPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlPhong_CellClick);
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "MaPhong";
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.Width = 125;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "MaKhu";
            this.maKhu.HeaderText = "Mã khu";
            this.maKhu.MinimumWidth = 6;
            this.maKhu.Name = "maKhu";
            this.maKhu.Width = 125;
            // 
            // tenPhong
            // 
            this.tenPhong.DataPropertyName = "TenPhong";
            this.tenPhong.HeaderText = "Tên phòng";
            this.tenPhong.MinimumWidth = 6;
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Width = 125;
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "LoaiPhong";
            this.loaiPhong.HeaderText = "Loại phòng";
            this.loaiPhong.MinimumWidth = 6;
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.Width = 125;
            // 
            // soNguoiHT
            // 
            this.soNguoiHT.DataPropertyName = "SoNguoiHienTai";
            this.soNguoiHT.HeaderText = "Số người hiện tại";
            this.soNguoiHT.MinimumWidth = 6;
            this.soNguoiHT.Name = "soNguoiHT";
            this.soNguoiHT.Width = 155;
            // 
            // soNguoiMax
            // 
            this.soNguoiMax.DataPropertyName = "SoNguoiToiDa";
            this.soNguoiMax.HeaderText = "Số người tối đa";
            this.soNguoiMax.MinimumWidth = 6;
            this.soNguoiMax.Name = "soNguoiMax";
            this.soNguoiMax.Width = 150;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "GiaPhong";
            this.giaPhong.HeaderText = "Giá phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 125;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(995, 384);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 61);
            this.btn_thoat.TabIndex = 32;
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
            this.btn_xoa.Location = new System.Drawing.Point(696, 384);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 61);
            this.btn_xoa.TabIndex = 31;
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
            this.btn_sua.Location = new System.Drawing.Point(396, 384);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 61);
            this.btn_sua.TabIndex = 30;
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
            this.btn_them.Location = new System.Drawing.Point(117, 384);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(106, 61);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 782);
            this.Controls.Add(this.dgv_qlPhong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.txt_loaiPhong);
            this.Controls.Add(this.grb_giaPhong);
            this.Controls.Add(this.cbo_maKhu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_soNguoiMax);
            this.Controls.Add(this.txt_soNguoiHT);
            this.Controls.Add(this.txt_tenPhong);
            this.Controls.Add(this.lbl_soNguoiMax);
            this.Controls.Add(this.txt_maPhong);
            this.Controls.Add(this.lbl_tenPhong);
            this.Controls.Add(this.lbl_loaiPhong);
            this.Controls.Add(this.lbl_songuoiHT);
            this.Controls.Add(this.lbl_maKhu);
            this.Controls.Add(this.lbl_maPhong);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyPhong";
            this.Load += new System.EventHandler(this.frmQuanLyPhong_Load);
            this.grb_giaPhong.ResumeLayout(false);
            this.grb_giaPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_loaiPhong;
        private System.Windows.Forms.GroupBox grb_giaPhong;
        private System.Windows.Forms.TextBox txt_giaPhong;
        private System.Windows.Forms.Label lbl_giaPhong;
        private System.Windows.Forms.ComboBox cbo_maKhu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_soNguoiMax;
        private System.Windows.Forms.TextBox txt_soNguoiHT;
        private System.Windows.Forms.TextBox txt_tenPhong;
        private System.Windows.Forms.Label lbl_soNguoiMax;
        private System.Windows.Forms.TextBox txt_maPhong;
        private System.Windows.Forms.Label lbl_tenPhong;
        private System.Windows.Forms.Label lbl_loaiPhong;
        private System.Windows.Forms.Label lbl_songuoiHT;
        private System.Windows.Forms.Label lbl_maKhu;
        private System.Windows.Forms.Label lbl_maPhong;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_qlPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
    }
}