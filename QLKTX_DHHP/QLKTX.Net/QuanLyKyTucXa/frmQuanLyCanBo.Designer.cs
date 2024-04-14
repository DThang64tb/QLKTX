namespace QuanLyKyTucXa
{
    partial class frmQuanLyCanBo
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
            this.chk_Nam = new System.Windows.Forms.CheckBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_ssearch = new System.Windows.Forms.Label();
            this.lbl_soDT = new System.Windows.Forms.Label();
            this.lbl_diaChi = new System.Windows.Forms.Label();
            this.lbl_chucVu = new System.Windows.Forms.Label();
            this.lbl_gioiTinh = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.lbl_tenCB = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_chucVu = new System.Windows.Forms.TextBox();
            this.txt_tenCB = new System.Windows.Forms.TextBox();
            this.txt_maCB = new System.Windows.Forms.TextBox();
            this.lbl_maCB = new System.Windows.Forms.Label();
            this.dgv_qlCanBo = new System.Windows.Forms.DataGridView();
            this.maCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlCanBo)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Nam
            // 
            this.chk_Nam.AutoSize = true;
            this.chk_Nam.Location = new System.Drawing.Point(166, 278);
            this.chk_Nam.Name = "chk_Nam";
            this.chk_Nam.Size = new System.Drawing.Size(75, 29);
            this.chk_Nam.TabIndex = 49;
            this.chk_Nam.Text = "Nam";
            this.chk_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(166, 212);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(273, 30);
            this.dtp_ngaySinh.TabIndex = 48;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(860, 273);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(272, 27);
            this.txt_search.TabIndex = 53;
            // 
            // lbl_ssearch
            // 
            this.lbl_ssearch.AutoSize = true;
            this.lbl_ssearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssearch.Location = new System.Drawing.Point(600, 280);
            this.lbl_ssearch.Name = "lbl_ssearch";
            this.lbl_ssearch.Size = new System.Drawing.Size(223, 20);
            this.lbl_ssearch.TabIndex = 60;
            this.lbl_ssearch.Text = "Nhập tên cán bộ tìm kiếm";
            // 
            // lbl_soDT
            // 
            this.lbl_soDT.AutoSize = true;
            this.lbl_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDT.Location = new System.Drawing.Point(704, 212);
            this.lbl_soDT.Name = "lbl_soDT";
            this.lbl_soDT.Size = new System.Drawing.Size(119, 20);
            this.lbl_soDT.TabIndex = 59;
            this.lbl_soDT.Text = "Số điện thoại";
            // 
            // lbl_diaChi
            // 
            this.lbl_diaChi.AutoSize = true;
            this.lbl_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaChi.Location = new System.Drawing.Point(755, 153);
            this.lbl_diaChi.Name = "lbl_diaChi";
            this.lbl_diaChi.Size = new System.Drawing.Size(68, 20);
            this.lbl_diaChi.TabIndex = 58;
            this.lbl_diaChi.Text = "Địa chỉ";
            // 
            // lbl_chucVu
            // 
            this.lbl_chucVu.AutoSize = true;
            this.lbl_chucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chucVu.Location = new System.Drawing.Point(746, 88);
            this.lbl_chucVu.Name = "lbl_chucVu";
            this.lbl_chucVu.Size = new System.Drawing.Size(77, 20);
            this.lbl_chucVu.TabIndex = 57;
            this.lbl_chucVu.Text = "Chức vụ";
            // 
            // lbl_gioiTinh
            // 
            this.lbl_gioiTinh.AutoSize = true;
            this.lbl_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioiTinh.Location = new System.Drawing.Point(55, 280);
            this.lbl_gioiTinh.Name = "lbl_gioiTinh";
            this.lbl_gioiTinh.Size = new System.Drawing.Size(80, 20);
            this.lbl_gioiTinh.TabIndex = 56;
            this.lbl_gioiTinh.Text = "Giới tính";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(43, 221);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(92, 20);
            this.lbl_ngaySinh.TabIndex = 55;
            this.lbl_ngaySinh.Text = "Ngày sinh";
            // 
            // lbl_tenCB
            // 
            this.lbl_tenCB.AutoSize = true;
            this.lbl_tenCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenCB.Location = new System.Drawing.Point(31, 157);
            this.lbl_tenCB.Name = "lbl_tenCB";
            this.lbl_tenCB.Size = new System.Drawing.Size(102, 20);
            this.lbl_tenCB.TabIndex = 54;
            this.lbl_tenCB.Text = "Tên cán bộ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(860, 212);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(272, 27);
            this.txt_SDT.TabIndex = 52;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(860, 150);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(275, 27);
            this.txt_diaChi.TabIndex = 51;
            // 
            // txt_chucVu
            // 
            this.txt_chucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chucVu.Location = new System.Drawing.Point(860, 85);
            this.txt_chucVu.Name = "txt_chucVu";
            this.txt_chucVu.Size = new System.Drawing.Size(275, 27);
            this.txt_chucVu.TabIndex = 50;
            // 
            // txt_tenCB
            // 
            this.txt_tenCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenCB.Location = new System.Drawing.Point(166, 152);
            this.txt_tenCB.Name = "txt_tenCB";
            this.txt_tenCB.Size = new System.Drawing.Size(273, 27);
            this.txt_tenCB.TabIndex = 47;
            // 
            // txt_maCB
            // 
            this.txt_maCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCB.Location = new System.Drawing.Point(166, 89);
            this.txt_maCB.Name = "txt_maCB";
            this.txt_maCB.Size = new System.Drawing.Size(273, 27);
            this.txt_maCB.TabIndex = 45;
            // 
            // lbl_maCB
            // 
            this.lbl_maCB.AutoSize = true;
            this.lbl_maCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maCB.Location = new System.Drawing.Point(38, 89);
            this.lbl_maCB.Name = "lbl_maCB";
            this.lbl_maCB.Size = new System.Drawing.Size(96, 20);
            this.lbl_maCB.TabIndex = 46;
            this.lbl_maCB.Text = "Mã cán bộ";
            // 
            // dgv_qlCanBo
            // 
            this.dgv_qlCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlCanBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCB,
            this.tenCB,
            this.ngaySinh,
            this.gioiTinh,
            this.chucVu,
            this.diaChi,
            this.soDT});
            this.dgv_qlCanBo.Location = new System.Drawing.Point(12, 433);
            this.dgv_qlCanBo.Name = "dgv_qlCanBo";
            this.dgv_qlCanBo.RowHeadersWidth = 51;
            this.dgv_qlCanBo.RowTemplate.Height = 24;
            this.dgv_qlCanBo.Size = new System.Drawing.Size(1157, 339);
            this.dgv_qlCanBo.TabIndex = 44;
            this.dgv_qlCanBo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlCanBo_CellClick);
            // 
            // maCB
            // 
            this.maCB.DataPropertyName = "MaCB";
            this.maCB.HeaderText = "Mã cán bộ";
            this.maCB.MinimumWidth = 6;
            this.maCB.Name = "maCB";
            this.maCB.Width = 150;
            // 
            // tenCB
            // 
            this.tenCB.DataPropertyName = "TenCB";
            this.tenCB.HeaderText = "Tên cán bộ";
            this.tenCB.MinimumWidth = 6;
            this.tenCB.Name = "tenCB";
            this.tenCB.Width = 150;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "NgaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gioiTinh.Width = 150;
            // 
            // chucVu
            // 
            this.chucVu.DataPropertyName = "ChucVu";
            this.chucVu.HeaderText = "Chức vụ";
            this.chucVu.MinimumWidth = 6;
            this.chucVu.Name = "chucVu";
            this.chucVu.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Đại chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 150;
            // 
            // soDT
            // 
            this.soDT.DataPropertyName = "SDT";
            this.soDT.HeaderText = "Số điện thoại";
            this.soDT.MinimumWidth = 6;
            this.soDT.Name = "soDT";
            this.soDT.Width = 150;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(437, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(251, 38);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Quản lý cán bộ";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::QuanLyKyTucXa.Properties.Resources.TraCuu32;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(793, 347);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(118, 47);
            this.btn_search.TabIndex = 42;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(1031, 347);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(118, 47);
            this.btn_thoat.TabIndex = 43;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.Xoa16_1;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(551, 347);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 47);
            this.btn_xoa.TabIndex = 41;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QuanLyKyTucXa.Properties.Resources.Sua16_1;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(277, 347);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 47);
            this.btn_sua.TabIndex = 40;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QuanLyKyTucXa.Properties.Resources.Them32_1;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(39, 347);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(119, 47);
            this.btn_them.TabIndex = 39;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frmQuanLyCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1181, 784);
            this.Controls.Add(this.chk_Nam);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_ssearch);
            this.Controls.Add(this.lbl_soDT);
            this.Controls.Add(this.lbl_diaChi);
            this.Controls.Add(this.lbl_chucVu);
            this.Controls.Add(this.lbl_gioiTinh);
            this.Controls.Add(this.lbl_ngaySinh);
            this.Controls.Add(this.lbl_tenCB);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_chucVu);
            this.Controls.Add(this.txt_tenCB);
            this.Controls.Add(this.txt_maCB);
            this.Controls.Add(this.lbl_maCB);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_qlCanBo);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyCanBo";
            this.Load += new System.EventHandler(this.frmQuanLyCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlCanBo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Nam;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_ssearch;
        private System.Windows.Forms.Label lbl_soDT;
        private System.Windows.Forms.Label lbl_diaChi;
        private System.Windows.Forms.Label lbl_chucVu;
        private System.Windows.Forms.Label lbl_gioiTinh;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.Label lbl_tenCB;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_chucVu;
        private System.Windows.Forms.TextBox txt_tenCB;
        private System.Windows.Forms.TextBox txt_maCB;
        private System.Windows.Forms.Label lbl_maCB;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_qlCanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_title;
    }
}