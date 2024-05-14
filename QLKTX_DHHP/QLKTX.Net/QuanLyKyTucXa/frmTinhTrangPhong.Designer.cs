namespace QuanLyKyTucXa
{
    partial class frmTinhTrangPhong
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tinhtrangphong = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_TinhTrangPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TinhTrangPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình Trạng Phòng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(768, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái phòng";
            // 
            // tinhtrangphong
            // 
            this.tinhtrangphong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tinhtrangphong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tinhtrangphong.FormattingEnabled = true;
            this.tinhtrangphong.Items.AddRange(new object[] {
            "Còn Trống",
            "Đã Đầy"});
            this.tinhtrangphong.Location = new System.Drawing.Point(250, 125);
            this.tinhtrangphong.Name = "tinhtrangphong";
            this.tinhtrangphong.Size = new System.Drawing.Size(260, 24);
            this.tinhtrangphong.TabIndex = 3;
            this.tinhtrangphong.SelectedIndexChanged += new System.EventHandler(this.tinhtrangphong_SelectedIndexChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(778, 108);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(116, 54);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_TinhTrangPhong
            // 
            this.dgv_TinhTrangPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_TinhTrangPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TinhTrangPhong.Location = new System.Drawing.Point(24, 249);
            this.dgv_TinhTrangPhong.Name = "dgv_TinhTrangPhong";
            this.dgv_TinhTrangPhong.RowHeadersWidth = 51;
            this.dgv_TinhTrangPhong.RowTemplate.Height = 24;
            this.dgv_TinhTrangPhong.Size = new System.Drawing.Size(975, 284);
            this.dgv_TinhTrangPhong.TabIndex = 5;
            // 
            // frmTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 603);
            this.Controls.Add(this.dgv_TinhTrangPhong);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.tinhtrangphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "frmTinhTrangPhong";
            this.Text = "frmTinhTrangPhong";
            this.Load += new System.EventHandler(this.frmTinhTrangPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TinhTrangPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tinhtrangphong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_TinhTrangPhong;
    }
}