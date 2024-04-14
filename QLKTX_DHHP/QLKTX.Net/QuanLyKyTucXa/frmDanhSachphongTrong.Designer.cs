namespace QuanLyKyTucXa
{
    partial class frmDanhSachphongTrong
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
            this.dgv_dsPhongTrong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dsPhongTrong
            // 
            this.dgv_dsPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.maKhu,
            this.tenPhong,
            this.loaiPhong,
            this.soNguoiHT,
            this.soNguoiToiDa,
            this.giaPhong});
            this.dgv_dsPhongTrong.Location = new System.Drawing.Point(12, 182);
            this.dgv_dsPhongTrong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_dsPhongTrong.Name = "dgv_dsPhongTrong";
            this.dgv_dsPhongTrong.RowHeadersWidth = 51;
            this.dgv_dsPhongTrong.RowTemplate.Height = 24;
            this.dgv_dsPhongTrong.Size = new System.Drawing.Size(1004, 496);
            this.dgv_dsPhongTrong.TabIndex = 0;
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "MaPhong";
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.MinimumWidth = 6;
            this.maPhong.Name = "maPhong";
            this.maPhong.Width = 150;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "MaKhu";
            this.maKhu.HeaderText = "Mã Khu";
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
            this.soNguoiHT.Width = 150;
            // 
            // soNguoiToiDa
            // 
            this.soNguoiToiDa.DataPropertyName = "SoNguoiToiDa";
            this.soNguoiToiDa.HeaderText = "Số người tối đa";
            this.soNguoiToiDa.MinimumWidth = 6;
            this.soNguoiToiDa.Name = "soNguoiToiDa";
            this.soNguoiToiDa.Width = 150;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "GiaPhong";
            this.giaPhong.HeaderText = "Giá phòng";
            this.giaPhong.MinimumWidth = 6;
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Width = 125;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(292, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(443, 38);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Danh sách phòng còn trống";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(904, 88);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(110, 64);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(25, 104);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(217, 20);
            this.lbl_search.TabIndex = 3;
            this.lbl_search.Text = "Nhập tên phòng tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(260, 101);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(300, 27);
            this.txt_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::QuanLyKyTucXa.Properties.Resources.TraCuu32;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(667, 86);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(122, 64);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frmDanhSachphongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 692);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_dsPhongTrong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachphongTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachphongTrong";
            this.Load += new System.EventHandler(this.frmDanhSachphongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsPhongTrong;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
    }
}