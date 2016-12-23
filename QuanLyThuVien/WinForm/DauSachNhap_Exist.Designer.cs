namespace WinForm
{
    partial class DauSachNhap_Exist
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
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btn_huy_them_dau_sach = new System.Windows.Forms.Button();
            this.btn_them_dau_sach = new System.Windows.Forms.Button();
            this.tac_gia_them = new System.Windows.Forms.ComboBox();
            this.nxb_them = new System.Windows.Forms.ComboBox();
            this.loai_sach_them = new System.Windows.Forms.ComboBox();
            this.nam_xuat_ban_them = new System.Windows.Forms.TextBox();
            this.tom_tat_them = new System.Windows.Forms.TextBox();
            this.ten_dau_sach_them = new System.Windows.Forms.TextBox();
            this.lbl_dausach_thanhtien = new System.Windows.Forms.Label();
            this.lbl_dausach_gianhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nxb = new System.Windows.Forms.Label();
            this.lbl_tom_tat = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.lbl_ten_dau_sach = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_sua_dau_sach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(736, 437);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(118, 20);
            this.txt_thanhtien.TabIndex = 44;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(736, 372);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(118, 20);
            this.txt_gianhap.TabIndex = 43;
            this.txt_gianhap.TextChanged += new System.EventHandler(this.DauSachNhap_Exist_Load);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(736, 300);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(118, 20);
            this.txt_soluong.TabIndex = 42;
            this.txt_soluong.TextChanged += new System.EventHandler(this.DauSachNhap_Exist_Load);
            // 
            // btn_huy_them_dau_sach
            // 
            this.btn_huy_them_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy_them_dau_sach.Location = new System.Drawing.Point(589, 527);
            this.btn_huy_them_dau_sach.Name = "btn_huy_them_dau_sach";
            this.btn_huy_them_dau_sach.Size = new System.Drawing.Size(88, 31);
            this.btn_huy_them_dau_sach.TabIndex = 41;
            this.btn_huy_them_dau_sach.Text = "ĐÓNG";
            this.btn_huy_them_dau_sach.UseVisualStyleBackColor = true;
            // 
            // btn_them_dau_sach
            // 
            this.btn_them_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_dau_sach.Location = new System.Drawing.Point(472, 527);
            this.btn_them_dau_sach.Name = "btn_them_dau_sach";
            this.btn_them_dau_sach.Size = new System.Drawing.Size(90, 31);
            this.btn_them_dau_sach.TabIndex = 40;
            this.btn_them_dau_sach.Text = "THÊM";
            this.btn_them_dau_sach.UseVisualStyleBackColor = true;
            this.btn_them_dau_sach.Click += new System.EventHandler(this.btn_them_dau_sach_Click);
            // 
            // tac_gia_them
            // 
            this.tac_gia_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tac_gia_them.FormattingEnabled = true;
            this.tac_gia_them.Location = new System.Drawing.Point(727, 235);
            this.tac_gia_them.Name = "tac_gia_them";
            this.tac_gia_them.Size = new System.Drawing.Size(194, 24);
            this.tac_gia_them.TabIndex = 39;
            // 
            // nxb_them
            // 
            this.nxb_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxb_them.FormattingEnabled = true;
            this.nxb_them.Location = new System.Drawing.Point(293, 429);
            this.nxb_them.Name = "nxb_them";
            this.nxb_them.Size = new System.Drawing.Size(193, 24);
            this.nxb_them.TabIndex = 38;
            // 
            // loai_sach_them
            // 
            this.loai_sach_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai_sach_them.FormattingEnabled = true;
            this.loai_sach_them.Location = new System.Drawing.Point(293, 232);
            this.loai_sach_them.Name = "loai_sach_them";
            this.loai_sach_them.Size = new System.Drawing.Size(213, 24);
            this.loai_sach_them.TabIndex = 37;
            // 
            // nam_xuat_ban_them
            // 
            this.nam_xuat_ban_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_xuat_ban_them.Location = new System.Drawing.Point(727, 167);
            this.nam_xuat_ban_them.Name = "nam_xuat_ban_them";
            this.nam_xuat_ban_them.Size = new System.Drawing.Size(193, 22);
            this.nam_xuat_ban_them.TabIndex = 35;
            // 
            // tom_tat_them
            // 
            this.tom_tat_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tom_tat_them.Location = new System.Drawing.Point(293, 297);
            this.tom_tat_them.Multiline = true;
            this.tom_tat_them.Name = "tom_tat_them";
            this.tom_tat_them.Size = new System.Drawing.Size(213, 95);
            this.tom_tat_them.TabIndex = 34;
            // 
            // ten_dau_sach_them
            // 
            this.ten_dau_sach_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_dau_sach_them.Location = new System.Drawing.Point(293, 170);
            this.ten_dau_sach_them.Name = "ten_dau_sach_them";
            this.ten_dau_sach_them.Size = new System.Drawing.Size(213, 22);
            this.ten_dau_sach_them.TabIndex = 36;
            // 
            // lbl_dausach_thanhtien
            // 
            this.lbl_dausach_thanhtien.AutoSize = true;
            this.lbl_dausach_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dausach_thanhtien.Location = new System.Drawing.Point(597, 437);
            this.lbl_dausach_thanhtien.Name = "lbl_dausach_thanhtien";
            this.lbl_dausach_thanhtien.Size = new System.Drawing.Size(90, 16);
            this.lbl_dausach_thanhtien.TabIndex = 26;
            this.lbl_dausach_thanhtien.Text = "THÀNH TIỀN";
            // 
            // lbl_dausach_gianhap
            // 
            this.lbl_dausach_gianhap.AutoSize = true;
            this.lbl_dausach_gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dausach_gianhap.Location = new System.Drawing.Point(597, 376);
            this.lbl_dausach_gianhap.Name = "lbl_dausach_gianhap";
            this.lbl_dausach_gianhap.Size = new System.Drawing.Size(71, 16);
            this.lbl_dausach_gianhap.TabIndex = 25;
            this.lbl_dausach_gianhap.Text = "GIÁ NHẬP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "TÁC GIẢ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(594, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "NĂM XUẤT BẢN";
            // 
            // lbl_nxb
            // 
            this.lbl_nxb.AutoSize = true;
            this.lbl_nxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nxb.Location = new System.Drawing.Point(161, 432);
            this.lbl_nxb.Name = "lbl_nxb";
            this.lbl_nxb.Size = new System.Drawing.Size(107, 16);
            this.lbl_nxb.TabIndex = 31;
            this.lbl_nxb.Text = "NHÀ XUẤT BẢN";
            // 
            // lbl_tom_tat
            // 
            this.lbl_tom_tat.AutoSize = true;
            this.lbl_tom_tat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tom_tat.Location = new System.Drawing.Point(153, 300);
            this.lbl_tom_tat.Name = "lbl_tom_tat";
            this.lbl_tom_tat.Size = new System.Drawing.Size(68, 16);
            this.lbl_tom_tat.TabIndex = 30;
            this.lbl_tom_tat.Text = "TÓM TẮT";
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.Location = new System.Drawing.Point(597, 304);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(80, 16);
            this.lbl_soluong.TabIndex = 29;
            this.lbl_soluong.Text = "SỐ LƯỢNG ";
            // 
            // lbl_ten_dau_sach
            // 
            this.lbl_ten_dau_sach.AutoSize = true;
            this.lbl_ten_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_dau_sach.Location = new System.Drawing.Point(151, 170);
            this.lbl_ten_dau_sach.Name = "lbl_ten_dau_sach";
            this.lbl_ten_dau_sach.Size = new System.Drawing.Size(110, 16);
            this.lbl_ten_dau_sach.TabIndex = 28;
            this.lbl_ten_dau_sach.Text = "TÊN ĐẦU SÁCH ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(151, 235);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 16);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "LOẠI SÁCH";
            // 
            // lbl_sua_dau_sach
            // 
            this.lbl_sua_dau_sach.AutoSize = true;
            this.lbl_sua_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sua_dau_sach.Location = new System.Drawing.Point(399, 95);
            this.lbl_sua_dau_sach.Name = "lbl_sua_dau_sach";
            this.lbl_sua_dau_sach.Size = new System.Drawing.Size(297, 31);
            this.lbl_sua_dau_sach.TabIndex = 33;
            this.lbl_sua_dau_sach.Text = "THÊM ĐẦU SÁCH MỚI";
            // 
            // DauSachNhap_Exist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 621);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.btn_huy_them_dau_sach);
            this.Controls.Add(this.btn_them_dau_sach);
            this.Controls.Add(this.tac_gia_them);
            this.Controls.Add(this.nxb_them);
            this.Controls.Add(this.loai_sach_them);
            this.Controls.Add(this.nam_xuat_ban_them);
            this.Controls.Add(this.tom_tat_them);
            this.Controls.Add(this.ten_dau_sach_them);
            this.Controls.Add(this.lbl_dausach_thanhtien);
            this.Controls.Add(this.lbl_dausach_gianhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_nxb);
            this.Controls.Add(this.lbl_tom_tat);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.lbl_ten_dau_sach);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_sua_dau_sach);
            this.Name = "DauSachNhap_Exist";
            this.Text = "NHẬP ĐẦU SÁCH MỚI";
            this.Load += new System.EventHandler(this.DauSachNhap_Exist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.TextBox txt_soluong;
        public System.Windows.Forms.Button btn_huy_them_dau_sach;
        public System.Windows.Forms.Button btn_them_dau_sach;
        public System.Windows.Forms.ComboBox tac_gia_them;
        public System.Windows.Forms.ComboBox nxb_them;
        public System.Windows.Forms.ComboBox loai_sach_them;
        public System.Windows.Forms.TextBox nam_xuat_ban_them;
        public System.Windows.Forms.TextBox tom_tat_them;
        public System.Windows.Forms.TextBox ten_dau_sach_them;
        public System.Windows.Forms.Label lbl_dausach_thanhtien;
        public System.Windows.Forms.Label lbl_dausach_gianhap;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_nxb;
        public System.Windows.Forms.Label lbl_tom_tat;
        public System.Windows.Forms.Label lbl_soluong;
        public System.Windows.Forms.Label lbl_ten_dau_sach;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label lbl_sua_dau_sach;
    }
}