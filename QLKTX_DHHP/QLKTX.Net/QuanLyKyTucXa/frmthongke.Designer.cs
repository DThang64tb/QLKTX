namespace QuanLyKyTucXa
{
    partial class frmthongke
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtpThongKeTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThongKeDen = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê tiền điện của KTX";
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(21, 170);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.Size = new System.Drawing.Size(753, 268);
            this.dgv_thongke.TabIndex = 1;
            this.dgv_thongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongke_CellContentClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(600, 83);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(128, 53);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtpThongKeTu
            // 
            this.dtpThongKeTu.CustomFormat = "MM/yyyy";
            this.dtpThongKeTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThongKeTu.Location = new System.Drawing.Point(154, 85);
            this.dtpThongKeTu.Name = "dtpThongKeTu";
            this.dtpThongKeTu.ShowUpDown = true;
            this.dtpThongKeTu.Size = new System.Drawing.Size(200, 22);
            this.dtpThongKeTu.TabIndex = 1;
            this.dtpThongKeTu.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            this.dtpThongKeTu.ValueChanged += new System.EventHandler(this.dtpThongKeTu_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ tháng";
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.Location = new System.Drawing.Point(406, 83);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(122, 53);
            this.btn_thongke.TabIndex = 2;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến tháng";
            // 
            // dtpThongKeDen
            // 
            this.dtpThongKeDen.CustomFormat = "MM/yyyy";
            this.dtpThongKeDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThongKeDen.Location = new System.Drawing.Point(154, 129);
            this.dtpThongKeDen.Name = "dtpThongKeDen";
            this.dtpThongKeDen.ShowUpDown = true;
            this.dtpThongKeDen.Size = new System.Drawing.Size(200, 22);
            this.dtpThongKeDen.TabIndex = 7;
            this.dtpThongKeDen.ValueChanged += new System.EventHandler(this.dtpThongKeDen_ValueChanged);
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpThongKeDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThongKeTu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.label1);
            this.Name = "frmthongke";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker dtpThongKeTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpThongKeDen;
    }
}