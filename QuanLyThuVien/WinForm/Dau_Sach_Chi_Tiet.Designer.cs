﻿namespace WinForm
{
    partial class Dau_Sach_Chi_Tiet
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
            this.btn_dong_xem_dau_sach = new System.Windows.Forms.Button();
            this.tac_gia_xem = new System.Windows.Forms.ComboBox();
            this.tinh_trang_xem = new System.Windows.Forms.ComboBox();
            this.nxb_xem = new System.Windows.Forms.ComboBox();
            this.loai_sach_xem = new System.Windows.Forms.ComboBox();
            this.nam_xuat_ban_xem = new System.Windows.Forms.TextBox();
            this.tom_tat_xem = new System.Windows.Forms.TextBox();
            this.ten_dau_sach_xem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tinh_trang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nxb = new System.Windows.Forms.Label();
            this.lbl_tom_tat = new System.Windows.Forms.Label();
            this.lbl_ten_dau_sach = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.ma_dau_sach_xem = new System.Windows.Forms.TextBox();
            this.lbl_xem_dau_sach = new System.Windows.Forms.Label();
            this.lbl_ma_dau_sach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dong_xem_dau_sach
            // 
            this.btn_dong_xem_dau_sach.Location = new System.Drawing.Point(496, 351);
            this.btn_dong_xem_dau_sach.Name = "btn_dong_xem_dau_sach";
            this.btn_dong_xem_dau_sach.Size = new System.Drawing.Size(84, 31);
            this.btn_dong_xem_dau_sach.TabIndex = 22;
            this.btn_dong_xem_dau_sach.Text = "ĐÓNG";
            this.btn_dong_xem_dau_sach.UseVisualStyleBackColor = true;
            this.btn_dong_xem_dau_sach.Click += new System.EventHandler(this.btn_dong_xem_dau_sach_Click);
            // 
            // tac_gia_xem
            // 
            this.tac_gia_xem.Enabled = false;
            this.tac_gia_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tac_gia_xem.FormattingEnabled = true;
            this.tac_gia_xem.Location = new System.Drawing.Point(644, 208);
            this.tac_gia_xem.Name = "tac_gia_xem";
            this.tac_gia_xem.Size = new System.Drawing.Size(182, 24);
            this.tac_gia_xem.TabIndex = 20;
            // 
            // tinh_trang_xem
            // 
            this.tinh_trang_xem.Enabled = false;
            this.tinh_trang_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_trang_xem.FormattingEnabled = true;
            this.tinh_trang_xem.Location = new System.Drawing.Point(645, 256);
            this.tinh_trang_xem.Name = "tinh_trang_xem";
            this.tinh_trang_xem.Size = new System.Drawing.Size(133, 24);
            this.tinh_trang_xem.TabIndex = 19;
            // 
            // nxb_xem
            // 
            this.nxb_xem.Enabled = false;
            this.nxb_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxb_xem.FormattingEnabled = true;
            this.nxb_xem.Location = new System.Drawing.Point(644, 111);
            this.nxb_xem.Name = "nxb_xem";
            this.nxb_xem.Size = new System.Drawing.Size(182, 24);
            this.nxb_xem.TabIndex = 18;
            // 
            // loai_sach_xem
            // 
            this.loai_sach_xem.Enabled = false;
            this.loai_sach_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loai_sach_xem.FormattingEnabled = true;
            this.loai_sach_xem.Location = new System.Drawing.Point(282, 213);
            this.loai_sach_xem.Name = "loai_sach_xem";
            this.loai_sach_xem.Size = new System.Drawing.Size(169, 24);
            this.loai_sach_xem.TabIndex = 17;
            // 
            // nam_xuat_ban_xem
            // 
            this.nam_xuat_ban_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_xuat_ban_xem.Location = new System.Drawing.Point(645, 165);
            this.nam_xuat_ban_xem.Name = "nam_xuat_ban_xem";
            this.nam_xuat_ban_xem.ReadOnly = true;
            this.nam_xuat_ban_xem.Size = new System.Drawing.Size(181, 22);
            this.nam_xuat_ban_xem.TabIndex = 14;
            // 
            // tom_tat_xem
            // 
            this.tom_tat_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tom_tat_xem.Location = new System.Drawing.Point(282, 261);
            this.tom_tat_xem.Multiline = true;
            this.tom_tat_xem.Name = "tom_tat_xem";
            this.tom_tat_xem.ReadOnly = true;
            this.tom_tat_xem.Size = new System.Drawing.Size(181, 59);
            this.tom_tat_xem.TabIndex = 13;
            // 
            // ten_dau_sach_xem
            // 
            this.ten_dau_sach_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_dau_sach_xem.Location = new System.Drawing.Point(282, 168);
            this.ten_dau_sach_xem.Name = "ten_dau_sach_xem";
            this.ten_dau_sach_xem.ReadOnly = true;
            this.ten_dau_sach_xem.Size = new System.Drawing.Size(169, 22);
            this.ten_dau_sach_xem.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÁC GIẢ";
            // 
            // lbl_tinh_trang
            // 
            this.lbl_tinh_trang.AutoSize = true;
            this.lbl_tinh_trang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tinh_trang.Location = new System.Drawing.Point(531, 264);
            this.lbl_tinh_trang.Name = "lbl_tinh_trang";
            this.lbl_tinh_trang.Size = new System.Drawing.Size(91, 16);
            this.lbl_tinh_trang.TabIndex = 10;
            this.lbl_tinh_trang.Text = "TÌNH TRẠNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(530, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "NĂM XUẤT BẢN";
            // 
            // lbl_nxb
            // 
            this.lbl_nxb.AutoSize = true;
            this.lbl_nxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nxb.Location = new System.Drawing.Point(530, 114);
            this.lbl_nxb.Name = "lbl_nxb";
            this.lbl_nxb.Size = new System.Drawing.Size(107, 16);
            this.lbl_nxb.TabIndex = 8;
            this.lbl_nxb.Text = "NHÀ XUẤT BẢN";
            // 
            // lbl_tom_tat
            // 
            this.lbl_tom_tat.AutoSize = true;
            this.lbl_tom_tat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tom_tat.Location = new System.Drawing.Point(168, 264);
            this.lbl_tom_tat.Name = "lbl_tom_tat";
            this.lbl_tom_tat.Size = new System.Drawing.Size(68, 16);
            this.lbl_tom_tat.TabIndex = 7;
            this.lbl_tom_tat.Text = "TÓM TẮT";
            // 
            // lbl_ten_dau_sach
            // 
            this.lbl_ten_dau_sach.AutoSize = true;
            this.lbl_ten_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_dau_sach.Location = new System.Drawing.Point(165, 168);
            this.lbl_ten_dau_sach.Name = "lbl_ten_dau_sach";
            this.lbl_ten_dau_sach.Size = new System.Drawing.Size(110, 16);
            this.lbl_ten_dau_sach.TabIndex = 6;
            this.lbl_ten_dau_sach.Text = "TÊN ĐẦU SÁCH ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(165, 216);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 16);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "LOẠI SÁCH";
            // 
            // ma_dau_sach_xem
            // 
            this.ma_dau_sach_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma_dau_sach_xem.Location = new System.Drawing.Point(282, 114);
            this.ma_dau_sach_xem.Name = "ma_dau_sach_xem";
            this.ma_dau_sach_xem.ReadOnly = true;
            this.ma_dau_sach_xem.Size = new System.Drawing.Size(168, 22);
            this.ma_dau_sach_xem.TabIndex = 15;
            this.ma_dau_sach_xem.TextChanged += new System.EventHandler(this.ma_dau_sach_xem_TextChanged);
            // 
            // lbl_xem_dau_sach
            // 
            this.lbl_xem_dau_sach.AutoSize = true;
            this.lbl_xem_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xem_dau_sach.Location = new System.Drawing.Point(261, 32);
            this.lbl_xem_dau_sach.Name = "lbl_xem_dau_sach";
            this.lbl_xem_dau_sach.Size = new System.Drawing.Size(342, 31);
            this.lbl_xem_dau_sach.TabIndex = 11;
            this.lbl_xem_dau_sach.Text = "XEM CHI TIẾT ĐẦU SÁCH";
            // 
            // lbl_ma_dau_sach
            // 
            this.lbl_ma_dau_sach.AutoSize = true;
            this.lbl_ma_dau_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma_dau_sach.Location = new System.Drawing.Point(164, 114);
            this.lbl_ma_dau_sach.Name = "lbl_ma_dau_sach";
            this.lbl_ma_dau_sach.Size = new System.Drawing.Size(99, 16);
            this.lbl_ma_dau_sach.TabIndex = 12;
            this.lbl_ma_dau_sach.Text = "MÃ ĐẦU SÁCH";
            // 
            // Dau_Sach_Chi_Tiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 460);
            this.Controls.Add(this.btn_dong_xem_dau_sach);
            this.Controls.Add(this.tac_gia_xem);
            this.Controls.Add(this.tinh_trang_xem);
            this.Controls.Add(this.nxb_xem);
            this.Controls.Add(this.loai_sach_xem);
            this.Controls.Add(this.nam_xuat_ban_xem);
            this.Controls.Add(this.tom_tat_xem);
            this.Controls.Add(this.ten_dau_sach_xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tinh_trang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_nxb);
            this.Controls.Add(this.lbl_tom_tat);
            this.Controls.Add(this.lbl_ten_dau_sach);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ma_dau_sach_xem);
            this.Controls.Add(this.lbl_xem_dau_sach);
            this.Controls.Add(this.lbl_ma_dau_sach);
            this.Name = "Dau_Sach_Chi_Tiet";
            this.Text = "Dau_Sach_Chi_Tiet";
            this.Load += new System.EventHandler(this.Dau_Sach_Chi_Tiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_dong_xem_dau_sach;
        public System.Windows.Forms.ComboBox tac_gia_xem;
        public System.Windows.Forms.ComboBox tinh_trang_xem;
        public System.Windows.Forms.ComboBox nxb_xem;
        public System.Windows.Forms.ComboBox loai_sach_xem;
        public System.Windows.Forms.TextBox nam_xuat_ban_xem;
        public System.Windows.Forms.TextBox tom_tat_xem;
        public System.Windows.Forms.TextBox ten_dau_sach_xem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_tinh_trang;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_nxb;
        public System.Windows.Forms.Label lbl_tom_tat;
        public System.Windows.Forms.Label lbl_ten_dau_sach;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox ma_dau_sach_xem;
        public System.Windows.Forms.Label lbl_xem_dau_sach;
        public System.Windows.Forms.Label lbl_ma_dau_sach;


    }
}