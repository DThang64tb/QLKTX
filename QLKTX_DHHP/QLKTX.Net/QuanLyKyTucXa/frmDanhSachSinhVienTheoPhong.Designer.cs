namespace QuanLyKyTucXa
{
    partial class frmDanhSachSinhVienTheoPhong
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
            this.lbl_phong = new System.Windows.Forms.Label();
            this.cbo_phong = new System.Windows.Forms.ComboBox();
            this.dgv_danhSach = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(122, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(525, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Danh sách sinh viên trong phòng";
            // 
            // lbl_phong
            // 
            this.lbl_phong.AutoSize = true;
            this.lbl_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.Location = new System.Drawing.Point(31, 100);
            this.lbl_phong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(61, 20);
            this.lbl_phong.TabIndex = 1;
            this.lbl_phong.Text = "Phòng";
            // 
            // cbo_phong
            // 
            this.cbo_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phong.FormattingEnabled = true;
            this.cbo_phong.Location = new System.Drawing.Point(129, 97);
            this.cbo_phong.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_phong.Name = "cbo_phong";
            this.cbo_phong.Size = new System.Drawing.Size(196, 28);
            this.cbo_phong.TabIndex = 2;
            this.cbo_phong.SelectedIndexChanged += new System.EventHandler(this.cbo_phong_SelectedIndexChanged);
            // 
            // dgv_danhSach
            // 
            this.dgv_danhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.tenSV,
            this.lop,
            this.khoa});
            this.dgv_danhSach.Location = new System.Drawing.Point(10, 190);
            this.dgv_danhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_danhSach.Name = "dgv_danhSach";
            this.dgv_danhSach.RowHeadersWidth = 51;
            this.dgv_danhSach.RowTemplate.Height = 24;
            this.dgv_danhSach.Size = new System.Drawing.Size(767, 422);
            this.dgv_danhSach.TabIndex = 3;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(685, 93);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 34);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 160;
            // 
            // tenSV
            // 
            this.tenSV.DataPropertyName = "TenSV";
            this.tenSV.HeaderText = "Tên sinh viên";
            this.tenSV.MinimumWidth = 6;
            this.tenSV.Name = "tenSV";
            this.tenSV.Width = 200;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 160;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "Khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 150;
            // 
            // frmDanhSachSinhVienTheoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 622);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgv_danhSach);
            this.Controls.Add(this.cbo_phong);
            this.Controls.Add(this.lbl_phong);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachSinhVienTheoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachSinhVienTheoPhong";
            this.Load += new System.EventHandler(this.frmDanhSachSinhVienTheoPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.ComboBox cbo_phong;
        private System.Windows.Forms.DataGridView dgv_danhSach;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
    }
}