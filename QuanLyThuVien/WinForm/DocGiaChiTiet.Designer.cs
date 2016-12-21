namespace WinForm
{
    partial class DocGiaChiTiet
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
            this.docgia_hoten_xem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tinh_trang = new System.Windows.Forms.Label();
            this.lbl_nxb = new System.Windows.Forms.Label();
            this.lbl_tom_tat = new System.Windows.Forms.Label();
            this.lbl_hoten_doc_gia = new System.Windows.Forms.Label();
            this.lbl_docgia_diachi = new System.Windows.Forms.Label();
            this.txt_xem_ma_docgia = new System.Windows.Forms.TextBox();
            this.lbl_xemct_docgia = new System.Windows.Forms.Label();
            this.lbl_ma_doc_gia = new System.Windows.Forms.Label();
            this.docgia_diachi_xem = new System.Windows.Forms.TextBox();
            this.docgia_dienthoai_xem = new System.Windows.Forms.TextBox();
            this.lbl_docgia_namhethan = new System.Windows.Forms.Label();
            this.docgia_namtotnghiep_xem = new System.Windows.Forms.TextBox();
            this.docgia_sosach_toida_xem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.docgia_thoigian_muon_toida_xem = new System.Windows.Forms.TextBox();
            this.docgia_cmnd_xem = new System.Windows.Forms.TextBox();
            this.docgia_mathe_xem = new System.Windows.Forms.TextBox();
            this.docgia_nghenghiep_xem = new System.Windows.Forms.TextBox();
            this.docgia_tinhtrang_xem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.docgia_ngayhethan_xem = new System.Windows.Forms.TextBox();
            this.docgia_ngaycapthe_xem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dong_xem_dau_sach
            // 
            this.btn_dong_xem_dau_sach.Location = new System.Drawing.Point(428, 436);
            this.btn_dong_xem_dau_sach.Name = "btn_dong_xem_dau_sach";
            this.btn_dong_xem_dau_sach.Size = new System.Drawing.Size(75, 23);
            this.btn_dong_xem_dau_sach.TabIndex = 40;
            this.btn_dong_xem_dau_sach.Text = "ĐÓNG";
            this.btn_dong_xem_dau_sach.UseVisualStyleBackColor = true;
            // 
            // docgia_hoten_xem
            // 
            this.docgia_hoten_xem.Location = new System.Drawing.Point(200, 134);
            this.docgia_hoten_xem.Name = "docgia_hoten_xem";
            this.docgia_hoten_xem.ReadOnly = true;
            this.docgia_hoten_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_hoten_xem.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CHỨNG MINH NHÂN DÂN";
            // 
            // lbl_tinh_trang
            // 
            this.lbl_tinh_trang.AutoSize = true;
            this.lbl_tinh_trang.Location = new System.Drawing.Point(52, 372);
            this.lbl_tinh_trang.Name = "lbl_tinh_trang";
            this.lbl_tinh_trang.Size = new System.Drawing.Size(86, 13);
            this.lbl_tinh_trang.TabIndex = 29;
            this.lbl_tinh_trang.Text = "NGÀY CẤP THẺ";
            // 
            // lbl_nxb
            // 
            this.lbl_nxb.AutoSize = true;
            this.lbl_nxb.Location = new System.Drawing.Point(498, 134);
            this.lbl_nxb.Name = "lbl_nxb";
            this.lbl_nxb.Size = new System.Drawing.Size(137, 13);
            this.lbl_nxb.TabIndex = 27;
            this.lbl_nxb.Text = "THỜI GIAN MƯỢN TỐI ĐA";
            this.lbl_nxb.Click += new System.EventHandler(this.lbl_nxb_Click);
            // 
            // lbl_tom_tat
            // 
            this.lbl_tom_tat.AutoSize = true;
            this.lbl_tom_tat.Location = new System.Drawing.Point(50, 233);
            this.lbl_tom_tat.Name = "lbl_tom_tat";
            this.lbl_tom_tat.Size = new System.Drawing.Size(69, 13);
            this.lbl_tom_tat.TabIndex = 26;
            this.lbl_tom_tat.Text = "ĐIỆN THOẠI";
            // 
            // lbl_hoten_doc_gia
            // 
            this.lbl_hoten_doc_gia.AutoSize = true;
            this.lbl_hoten_doc_gia.Location = new System.Drawing.Point(50, 134);
            this.lbl_hoten_doc_gia.Name = "lbl_hoten_doc_gia";
            this.lbl_hoten_doc_gia.Size = new System.Drawing.Size(48, 13);
            this.lbl_hoten_doc_gia.TabIndex = 25;
            this.lbl_hoten_doc_gia.Text = "HỌ TÊN";
            // 
            // lbl_docgia_diachi
            // 
            this.lbl_docgia_diachi.AutoSize = true;
            this.lbl_docgia_diachi.Location = new System.Drawing.Point(52, 180);
            this.lbl_docgia_diachi.Name = "lbl_docgia_diachi";
            this.lbl_docgia_diachi.Size = new System.Drawing.Size(46, 13);
            this.lbl_docgia_diachi.TabIndex = 24;
            this.lbl_docgia_diachi.Text = "ĐỊA CHỈ";
            // 
            // txt_xem_ma_docgia
            // 
            this.txt_xem_ma_docgia.Location = new System.Drawing.Point(200, 87);
            this.txt_xem_ma_docgia.Name = "txt_xem_ma_docgia";
            this.txt_xem_ma_docgia.ReadOnly = true;
            this.txt_xem_ma_docgia.Size = new System.Drawing.Size(192, 20);
            this.txt_xem_ma_docgia.TabIndex = 34;
            // 
            // lbl_xemct_docgia
            // 
            this.lbl_xemct_docgia.AutoSize = true;
            this.lbl_xemct_docgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xemct_docgia.Location = new System.Drawing.Point(270, 33);
            this.lbl_xemct_docgia.Name = "lbl_xemct_docgia";
            this.lbl_xemct_docgia.Size = new System.Drawing.Size(316, 31);
            this.lbl_xemct_docgia.TabIndex = 30;
            this.lbl_xemct_docgia.Text = "XEM CHI TIẾT ĐỘC GIẢ";
            // 
            // lbl_ma_doc_gia
            // 
            this.lbl_ma_doc_gia.AutoSize = true;
            this.lbl_ma_doc_gia.Location = new System.Drawing.Point(50, 90);
            this.lbl_ma_doc_gia.Name = "lbl_ma_doc_gia";
            this.lbl_ma_doc_gia.Size = new System.Drawing.Size(70, 13);
            this.lbl_ma_doc_gia.TabIndex = 31;
            this.lbl_ma_doc_gia.Text = "MÃ ĐỘC GIẢ";
            // 
            // docgia_diachi_xem
            // 
            this.docgia_diachi_xem.Location = new System.Drawing.Point(200, 177);
            this.docgia_diachi_xem.Name = "docgia_diachi_xem";
            this.docgia_diachi_xem.ReadOnly = true;
            this.docgia_diachi_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_diachi_xem.TabIndex = 35;
            // 
            // docgia_dienthoai_xem
            // 
            this.docgia_dienthoai_xem.Location = new System.Drawing.Point(200, 227);
            this.docgia_dienthoai_xem.Name = "docgia_dienthoai_xem";
            this.docgia_dienthoai_xem.ReadOnly = true;
            this.docgia_dienthoai_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_dienthoai_xem.TabIndex = 35;
            // 
            // lbl_docgia_namhethan
            // 
            this.lbl_docgia_namhethan.AutoSize = true;
            this.lbl_docgia_namhethan.Location = new System.Drawing.Point(48, 281);
            this.lbl_docgia_namhethan.Name = "lbl_docgia_namhethan";
            this.lbl_docgia_namhethan.Size = new System.Drawing.Size(100, 13);
            this.lbl_docgia_namhethan.TabIndex = 26;
            this.lbl_docgia_namhethan.Text = "NĂM TỐT NGHIỆP";
            // 
            // docgia_namtotnghiep_xem
            // 
            this.docgia_namtotnghiep_xem.Location = new System.Drawing.Point(200, 275);
            this.docgia_namtotnghiep_xem.Name = "docgia_namtotnghiep_xem";
            this.docgia_namtotnghiep_xem.ReadOnly = true;
            this.docgia_namtotnghiep_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_namtotnghiep_xem.TabIndex = 35;
            // 
            // docgia_sosach_toida_xem
            // 
            this.docgia_sosach_toida_xem.Location = new System.Drawing.Point(200, 322);
            this.docgia_sosach_toida_xem.Name = "docgia_sosach_toida_xem";
            this.docgia_sosach_toida_xem.ReadOnly = true;
            this.docgia_sosach_toida_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_sosach_toida_xem.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "SỐ SÁCH MƯỢN TỐI ĐA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "NGHỀ NGHIỆP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "MÃ THẺ THƯ VIỆN";
            // 
            // docgia_thoigian_muon_toida_xem
            // 
            this.docgia_thoigian_muon_toida_xem.Location = new System.Drawing.Point(689, 127);
            this.docgia_thoigian_muon_toida_xem.Name = "docgia_thoigian_muon_toida_xem";
            this.docgia_thoigian_muon_toida_xem.ReadOnly = true;
            this.docgia_thoigian_muon_toida_xem.Size = new System.Drawing.Size(183, 20);
            this.docgia_thoigian_muon_toida_xem.TabIndex = 33;
            // 
            // docgia_cmnd_xem
            // 
            this.docgia_cmnd_xem.Location = new System.Drawing.Point(690, 180);
            this.docgia_cmnd_xem.Name = "docgia_cmnd_xem";
            this.docgia_cmnd_xem.ReadOnly = true;
            this.docgia_cmnd_xem.Size = new System.Drawing.Size(182, 20);
            this.docgia_cmnd_xem.TabIndex = 33;
            // 
            // docgia_mathe_xem
            // 
            this.docgia_mathe_xem.Location = new System.Drawing.Point(690, 229);
            this.docgia_mathe_xem.Name = "docgia_mathe_xem";
            this.docgia_mathe_xem.ReadOnly = true;
            this.docgia_mathe_xem.Size = new System.Drawing.Size(182, 20);
            this.docgia_mathe_xem.TabIndex = 33;
            // 
            // docgia_nghenghiep_xem
            // 
            this.docgia_nghenghiep_xem.Location = new System.Drawing.Point(690, 268);
            this.docgia_nghenghiep_xem.Name = "docgia_nghenghiep_xem";
            this.docgia_nghenghiep_xem.ReadOnly = true;
            this.docgia_nghenghiep_xem.Size = new System.Drawing.Size(182, 20);
            this.docgia_nghenghiep_xem.TabIndex = 33;
            // 
            // docgia_tinhtrang_xem
            // 
            this.docgia_tinhtrang_xem.Location = new System.Drawing.Point(690, 319);
            this.docgia_tinhtrang_xem.Name = "docgia_tinhtrang_xem";
            this.docgia_tinhtrang_xem.ReadOnly = true;
            this.docgia_tinhtrang_xem.Size = new System.Drawing.Size(182, 20);
            this.docgia_tinhtrang_xem.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "NGÀY HẾT HẠN";
            // 
            // docgia_ngayhethan_xem
            // 
            this.docgia_ngayhethan_xem.Location = new System.Drawing.Point(689, 80);
            this.docgia_ngayhethan_xem.Name = "docgia_ngayhethan_xem";
            this.docgia_ngayhethan_xem.ReadOnly = true;
            this.docgia_ngayhethan_xem.Size = new System.Drawing.Size(183, 20);
            this.docgia_ngayhethan_xem.TabIndex = 33;
            // 
            // docgia_ngaycapthe_xem
            // 
            this.docgia_ngaycapthe_xem.Location = new System.Drawing.Point(200, 369);
            this.docgia_ngaycapthe_xem.Name = "docgia_ngaycapthe_xem";
            this.docgia_ngaycapthe_xem.ReadOnly = true;
            this.docgia_ngaycapthe_xem.Size = new System.Drawing.Size(192, 20);
            this.docgia_ngaycapthe_xem.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "TÌNH TRẠNG";
            // 
            // DocGiaChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.docgia_ngaycapthe_xem);
            this.Controls.Add(this.docgia_sosach_toida_xem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dong_xem_dau_sach);
            this.Controls.Add(this.docgia_ngayhethan_xem);
            this.Controls.Add(this.docgia_thoigian_muon_toida_xem);
            this.Controls.Add(this.docgia_tinhtrang_xem);
            this.Controls.Add(this.docgia_nghenghiep_xem);
            this.Controls.Add(this.docgia_mathe_xem);
            this.Controls.Add(this.docgia_cmnd_xem);
            this.Controls.Add(this.docgia_namtotnghiep_xem);
            this.Controls.Add(this.docgia_dienthoai_xem);
            this.Controls.Add(this.docgia_diachi_xem);
            this.Controls.Add(this.docgia_hoten_xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_tinh_trang);
            this.Controls.Add(this.lbl_nxb);
            this.Controls.Add(this.lbl_docgia_namhethan);
            this.Controls.Add(this.lbl_tom_tat);
            this.Controls.Add(this.lbl_hoten_doc_gia);
            this.Controls.Add(this.lbl_docgia_diachi);
            this.Controls.Add(this.txt_xem_ma_docgia);
            this.Controls.Add(this.lbl_xemct_docgia);
            this.Controls.Add(this.lbl_ma_doc_gia);
            this.Name = "DocGiaChiTiet";
            this.Text = "DocGiaChiTiet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_dong_xem_dau_sach;
        public System.Windows.Forms.TextBox docgia_hoten_xem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_tinh_trang;
        public System.Windows.Forms.Label lbl_nxb;
        public System.Windows.Forms.Label lbl_tom_tat;
        public System.Windows.Forms.Label lbl_hoten_doc_gia;
        public System.Windows.Forms.Label lbl_docgia_diachi;
        public System.Windows.Forms.TextBox txt_xem_ma_docgia;
        public System.Windows.Forms.Label lbl_xemct_docgia;
        public System.Windows.Forms.Label lbl_ma_doc_gia;
        public System.Windows.Forms.TextBox docgia_diachi_xem;
        public System.Windows.Forms.TextBox docgia_dienthoai_xem;
        public System.Windows.Forms.Label lbl_docgia_namhethan;
        public System.Windows.Forms.TextBox docgia_namtotnghiep_xem;
        public System.Windows.Forms.TextBox docgia_sosach_toida_xem;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox docgia_thoigian_muon_toida_xem;
        public System.Windows.Forms.TextBox docgia_cmnd_xem;
        public System.Windows.Forms.TextBox docgia_mathe_xem;
        public System.Windows.Forms.TextBox docgia_nghenghiep_xem;
        public System.Windows.Forms.TextBox docgia_tinhtrang_xem;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox docgia_ngayhethan_xem;
        public System.Windows.Forms.TextBox docgia_ngaycapthe_xem;
        public System.Windows.Forms.Label label6;
    }
}