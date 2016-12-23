namespace WinForm
{
    partial class DocGiaThem
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
            this.lbl_docgia_hoten = new System.Windows.Forms.Label();
            this.lbl_docgia_diachi = new System.Windows.Forms.Label();
            this.lbl_docgia_dienthoai = new System.Windows.Forms.Label();
            this.lbl_docgia_ngaycapthe = new System.Windows.Forms.Label();
            this.lbl_docgia_ngayhethan = new System.Windows.Forms.Label();
            this.lbl_docgia_thoigian_muontoida = new System.Windows.Forms.Label();
            this.lbl_docgia_cmnd = new System.Windows.Forms.Label();
            this.lbl_docgia_nghenghiep = new System.Windows.Forms.Label();
            this.lbl_docgia_nam_tot_nghiep = new System.Windows.Forms.Label();
            this.lbl_docgia_sosach_muontoida = new System.Windows.Forms.Label();
            this.datetime_docgia_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.datetime_docgia_ngaycapthe = new System.Windows.Forms.DateTimePicker();
            this.txt_docgia_hoten = new System.Windows.Forms.TextBox();
            this.txt_docgia_diachi = new System.Windows.Forms.TextBox();
            this.txt_docgia_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.number_sosach_toida = new System.Windows.Forms.NumericUpDown();
            this.number_thoigian_toida = new System.Windows.Forms.NumericUpDown();
            this.lbl_docgia_them_title = new System.Windows.Forms.Label();
            this.btn_them_docgia = new System.Windows.Forms.Button();
            this.btn_docgia_huy = new System.Windows.Forms.Button();
            this.btn_docgia_dong = new System.Windows.Forms.Button();
            this.cb_docgia_nghenghiep = new System.Windows.Forms.ComboBox();
            this.dtpicker_docgia_namtotnghiep = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number_sosach_toida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_thoigian_toida)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_docgia_hoten
            // 
            this.lbl_docgia_hoten.AutoSize = true;
            this.lbl_docgia_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_hoten.Location = new System.Drawing.Point(81, 164);
            this.lbl_docgia_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_hoten.Name = "lbl_docgia_hoten";
            this.lbl_docgia_hoten.Size = new System.Drawing.Size(80, 16);
            this.lbl_docgia_hoten.TabIndex = 0;
            this.lbl_docgia_hoten.Text = "HỌ VÀ TÊN";
            this.lbl_docgia_hoten.Click += new System.EventHandler(this.lbl_docgia_hoten_Click);
            // 
            // lbl_docgia_diachi
            // 
            this.lbl_docgia_diachi.AutoSize = true;
            this.lbl_docgia_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_diachi.Location = new System.Drawing.Point(81, 235);
            this.lbl_docgia_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_diachi.Name = "lbl_docgia_diachi";
            this.lbl_docgia_diachi.Size = new System.Drawing.Size(54, 16);
            this.lbl_docgia_diachi.TabIndex = 0;
            this.lbl_docgia_diachi.Text = "ĐỊA CHỈ";
            this.lbl_docgia_diachi.Click += new System.EventHandler(this.lbl_docgia_diachi_Click);
            // 
            // lbl_docgia_dienthoai
            // 
            this.lbl_docgia_dienthoai.AutoSize = true;
            this.lbl_docgia_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_dienthoai.Location = new System.Drawing.Point(77, 314);
            this.lbl_docgia_dienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_dienthoai.Name = "lbl_docgia_dienthoai";
            this.lbl_docgia_dienthoai.Size = new System.Drawing.Size(83, 16);
            this.lbl_docgia_dienthoai.TabIndex = 0;
            this.lbl_docgia_dienthoai.Text = "ĐIỆN THOẠI";
            this.lbl_docgia_dienthoai.Click += new System.EventHandler(this.lbl_docgia_dienthoai_Click);
            // 
            // lbl_docgia_ngaycapthe
            // 
            this.lbl_docgia_ngaycapthe.AutoSize = true;
            this.lbl_docgia_ngaycapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_ngaycapthe.Location = new System.Drawing.Point(81, 396);
            this.lbl_docgia_ngaycapthe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_ngaycapthe.Name = "lbl_docgia_ngaycapthe";
            this.lbl_docgia_ngaycapthe.Size = new System.Drawing.Size(107, 16);
            this.lbl_docgia_ngaycapthe.TabIndex = 0;
            this.lbl_docgia_ngaycapthe.Text = "NGÀY CẤP THẺ";
            this.lbl_docgia_ngaycapthe.Click += new System.EventHandler(this.lbl_docgia_ngaycapthe_Click);
            // 
            // lbl_docgia_ngayhethan
            // 
            this.lbl_docgia_ngayhethan.AutoSize = true;
            this.lbl_docgia_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_ngayhethan.Location = new System.Drawing.Point(81, 479);
            this.lbl_docgia_ngayhethan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_ngayhethan.Name = "lbl_docgia_ngayhethan";
            this.lbl_docgia_ngayhethan.Size = new System.Drawing.Size(109, 16);
            this.lbl_docgia_ngayhethan.TabIndex = 0;
            this.lbl_docgia_ngayhethan.Text = "NGÀY HẾT HẠN";
            this.lbl_docgia_ngayhethan.Click += new System.EventHandler(this.lbl_docgia_ngayhethan_Click);
            // 
            // lbl_docgia_thoigian_muontoida
            // 
            this.lbl_docgia_thoigian_muontoida.AutoSize = true;
            this.lbl_docgia_thoigian_muontoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_thoigian_muontoida.Location = new System.Drawing.Point(645, 314);
            this.lbl_docgia_thoigian_muontoida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_thoigian_muontoida.Name = "lbl_docgia_thoigian_muontoida";
            this.lbl_docgia_thoigian_muontoida.Size = new System.Drawing.Size(165, 16);
            this.lbl_docgia_thoigian_muontoida.TabIndex = 0;
            this.lbl_docgia_thoigian_muontoida.Text = "THỜI GIAN MƯỢN TỐI ĐA";
            this.lbl_docgia_thoigian_muontoida.Click += new System.EventHandler(this.lbl_docgia_thoigian_muontoida_Click);
            // 
            // lbl_docgia_cmnd
            // 
            this.lbl_docgia_cmnd.AutoSize = true;
            this.lbl_docgia_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_cmnd.Location = new System.Drawing.Point(645, 396);
            this.lbl_docgia_cmnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_cmnd.Name = "lbl_docgia_cmnd";
            this.lbl_docgia_cmnd.Size = new System.Drawing.Size(168, 16);
            this.lbl_docgia_cmnd.TabIndex = 0;
            this.lbl_docgia_cmnd.Text = "CHỨNG MINH NHÂN DÂN";
            this.lbl_docgia_cmnd.Click += new System.EventHandler(this.lbl_docgia_cmnd_Click);
            // 
            // lbl_docgia_nghenghiep
            // 
            this.lbl_docgia_nghenghiep.AutoSize = true;
            this.lbl_docgia_nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_nghenghiep.Location = new System.Drawing.Point(645, 479);
            this.lbl_docgia_nghenghiep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_nghenghiep.Name = "lbl_docgia_nghenghiep";
            this.lbl_docgia_nghenghiep.Size = new System.Drawing.Size(101, 16);
            this.lbl_docgia_nghenghiep.TabIndex = 0;
            this.lbl_docgia_nghenghiep.Text = "NGHỀ NGHIỆP";
            this.lbl_docgia_nghenghiep.Click += new System.EventHandler(this.lbl_docgia_nghenghiep_Click);
            // 
            // lbl_docgia_nam_tot_nghiep
            // 
            this.lbl_docgia_nam_tot_nghiep.AutoSize = true;
            this.lbl_docgia_nam_tot_nghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_nam_tot_nghiep.Location = new System.Drawing.Point(645, 164);
            this.lbl_docgia_nam_tot_nghiep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_nam_tot_nghiep.Name = "lbl_docgia_nam_tot_nghiep";
            this.lbl_docgia_nam_tot_nghiep.Size = new System.Drawing.Size(123, 16);
            this.lbl_docgia_nam_tot_nghiep.TabIndex = 0;
            this.lbl_docgia_nam_tot_nghiep.Text = "NĂM TỐT NGHIỆP";
            this.lbl_docgia_nam_tot_nghiep.Click += new System.EventHandler(this.lbl_docgia_nam_tot_nghiep_Click);
            // 
            // lbl_docgia_sosach_muontoida
            // 
            this.lbl_docgia_sosach_muontoida.AutoSize = true;
            this.lbl_docgia_sosach_muontoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_sosach_muontoida.Location = new System.Drawing.Point(645, 233);
            this.lbl_docgia_sosach_muontoida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_sosach_muontoida.Name = "lbl_docgia_sosach_muontoida";
            this.lbl_docgia_sosach_muontoida.Size = new System.Drawing.Size(157, 16);
            this.lbl_docgia_sosach_muontoida.TabIndex = 0;
            this.lbl_docgia_sosach_muontoida.Text = "SỐ SÁCH MƯỢN TỐI ĐA";
            this.lbl_docgia_sosach_muontoida.Click += new System.EventHandler(this.lbl_docgia_sosach_muontoida_Click);
            // 
            // datetime_docgia_ngayhethan
            // 
            this.datetime_docgia_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_docgia_ngayhethan.Location = new System.Drawing.Point(264, 479);
            this.datetime_docgia_ngayhethan.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_docgia_ngayhethan.Name = "datetime_docgia_ngayhethan";
            this.datetime_docgia_ngayhethan.Size = new System.Drawing.Size(265, 22);
            this.datetime_docgia_ngayhethan.TabIndex = 1;
            // 
            // datetime_docgia_ngaycapthe
            // 
            this.datetime_docgia_ngaycapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_docgia_ngaycapthe.Location = new System.Drawing.Point(264, 389);
            this.datetime_docgia_ngaycapthe.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_docgia_ngaycapthe.Name = "datetime_docgia_ngaycapthe";
            this.datetime_docgia_ngaycapthe.Size = new System.Drawing.Size(265, 22);
            this.datetime_docgia_ngaycapthe.TabIndex = 1;
            // 
            // txt_docgia_hoten
            // 
            this.txt_docgia_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_hoten.Location = new System.Drawing.Point(264, 160);
            this.txt_docgia_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_hoten.Name = "txt_docgia_hoten";
            this.txt_docgia_hoten.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_hoten.TabIndex = 2;
            // 
            // txt_docgia_diachi
            // 
            this.txt_docgia_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_diachi.Location = new System.Drawing.Point(264, 225);
            this.txt_docgia_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_diachi.Name = "txt_docgia_diachi";
            this.txt_docgia_diachi.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_diachi.TabIndex = 2;
            // 
            // txt_docgia_dienthoai
            // 
            this.txt_docgia_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_dienthoai.Location = new System.Drawing.Point(264, 306);
            this.txt_docgia_dienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_dienthoai.Name = "txt_docgia_dienthoai";
            this.txt_docgia_dienthoai.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_dienthoai.TabIndex = 2;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(888, 391);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(287, 22);
            this.txt_cmnd.TabIndex = 2;
            // 
            // number_sosach_toida
            // 
            this.number_sosach_toida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_sosach_toida.Location = new System.Drawing.Point(888, 226);
            this.number_sosach_toida.Margin = new System.Windows.Forms.Padding(4);
            this.number_sosach_toida.Name = "number_sosach_toida";
            this.number_sosach_toida.Size = new System.Drawing.Size(160, 22);
            this.number_sosach_toida.TabIndex = 3;
            // 
            // number_thoigian_toida
            // 
            this.number_thoigian_toida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_thoigian_toida.Location = new System.Drawing.Point(888, 311);
            this.number_thoigian_toida.Margin = new System.Windows.Forms.Padding(4);
            this.number_thoigian_toida.Name = "number_thoigian_toida";
            this.number_thoigian_toida.Size = new System.Drawing.Size(160, 22);
            this.number_thoigian_toida.TabIndex = 3;
            // 
            // lbl_docgia_them_title
            // 
            this.lbl_docgia_them_title.AutoSize = true;
            this.lbl_docgia_them_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_them_title.Location = new System.Drawing.Point(451, 32);
            this.lbl_docgia_them_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_them_title.Name = "lbl_docgia_them_title";
            this.lbl_docgia_them_title.Size = new System.Drawing.Size(271, 31);
            this.lbl_docgia_them_title.TabIndex = 4;
            this.lbl_docgia_them_title.Text = "THÊM ĐỘC GIẢ MỚI";
            // 
            // btn_them_docgia
            // 
            this.btn_them_docgia.Location = new System.Drawing.Point(399, 566);
            this.btn_them_docgia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them_docgia.Name = "btn_them_docgia";
            this.btn_them_docgia.Size = new System.Drawing.Size(152, 41);
            this.btn_them_docgia.TabIndex = 5;
            this.btn_them_docgia.Text = "THÊM";
            this.btn_them_docgia.UseVisualStyleBackColor = true;
            this.btn_them_docgia.Click += new System.EventHandler(this.btn_them_docgia_Click);
            // 
            // btn_docgia_huy
            // 
            this.btn_docgia_huy.Location = new System.Drawing.Point(581, 566);
            this.btn_docgia_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_docgia_huy.Name = "btn_docgia_huy";
            this.btn_docgia_huy.Size = new System.Drawing.Size(148, 39);
            this.btn_docgia_huy.TabIndex = 6;
            this.btn_docgia_huy.Text = "HỦY";
            this.btn_docgia_huy.UseVisualStyleBackColor = true;
            this.btn_docgia_huy.Click += new System.EventHandler(this.btn_docgia_huy_Click);
            // 
            // btn_docgia_dong
            // 
            this.btn_docgia_dong.Location = new System.Drawing.Point(761, 567);
            this.btn_docgia_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_docgia_dong.Name = "btn_docgia_dong";
            this.btn_docgia_dong.Size = new System.Drawing.Size(148, 39);
            this.btn_docgia_dong.TabIndex = 7;
            this.btn_docgia_dong.Text = "ĐÓNG";
            this.btn_docgia_dong.UseVisualStyleBackColor = true;
            this.btn_docgia_dong.Click += new System.EventHandler(this.btn_docgia_dong_Click);
            // 
            // cb_docgia_nghenghiep
            // 
            this.cb_docgia_nghenghiep.FormattingEnabled = true;
            this.cb_docgia_nghenghiep.Items.AddRange(new object[] {
            "Giáo viên",
            "Học sinh"});
            this.cb_docgia_nghenghiep.Location = new System.Drawing.Point(888, 479);
            this.cb_docgia_nghenghiep.Margin = new System.Windows.Forms.Padding(4);
            this.cb_docgia_nghenghiep.Name = "cb_docgia_nghenghiep";
            this.cb_docgia_nghenghiep.Size = new System.Drawing.Size(287, 24);
            this.cb_docgia_nghenghiep.TabIndex = 8;
            // 
            // dtpicker_docgia_namtotnghiep
            // 
            this.dtpicker_docgia_namtotnghiep.Location = new System.Drawing.Point(888, 160);
            this.dtpicker_docgia_namtotnghiep.Margin = new System.Windows.Forms.Padding(4);
            this.dtpicker_docgia_namtotnghiep.Name = "dtpicker_docgia_namtotnghiep";
            this.dtpicker_docgia_namtotnghiep.Size = new System.Drawing.Size(265, 22);
            this.dtpicker_docgia_namtotnghiep.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1056, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ngày";
            // 
            // DocGiaThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpicker_docgia_namtotnghiep);
            this.Controls.Add(this.cb_docgia_nghenghiep);
            this.Controls.Add(this.btn_docgia_dong);
            this.Controls.Add(this.btn_docgia_huy);
            this.Controls.Add(this.btn_them_docgia);
            this.Controls.Add(this.lbl_docgia_them_title);
            this.Controls.Add(this.number_thoigian_toida);
            this.Controls.Add(this.number_sosach_toida);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_docgia_dienthoai);
            this.Controls.Add(this.txt_docgia_diachi);
            this.Controls.Add(this.txt_docgia_hoten);
            this.Controls.Add(this.datetime_docgia_ngaycapthe);
            this.Controls.Add(this.datetime_docgia_ngayhethan);
            this.Controls.Add(this.lbl_docgia_sosach_muontoida);
            this.Controls.Add(this.lbl_docgia_nghenghiep);
            this.Controls.Add(this.lbl_docgia_nam_tot_nghiep);
            this.Controls.Add(this.lbl_docgia_cmnd);
            this.Controls.Add(this.lbl_docgia_thoigian_muontoida);
            this.Controls.Add(this.lbl_docgia_ngayhethan);
            this.Controls.Add(this.lbl_docgia_ngaycapthe);
            this.Controls.Add(this.lbl_docgia_dienthoai);
            this.Controls.Add(this.lbl_docgia_diachi);
            this.Controls.Add(this.lbl_docgia_hoten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocGiaThem";
            this.Text = "THÊM ĐỘC GIẢ";
            this.Load += new System.EventHandler(this.DocGiaThem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number_sosach_toida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_thoigian_toida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_docgia_hoten;
        private System.Windows.Forms.Label lbl_docgia_diachi;
        private System.Windows.Forms.Label lbl_docgia_dienthoai;
        private System.Windows.Forms.Label lbl_docgia_ngaycapthe;
        private System.Windows.Forms.Label lbl_docgia_ngayhethan;
        private System.Windows.Forms.Label lbl_docgia_thoigian_muontoida;
        private System.Windows.Forms.Label lbl_docgia_cmnd;
        private System.Windows.Forms.Label lbl_docgia_nghenghiep;
        private System.Windows.Forms.Label lbl_docgia_nam_tot_nghiep;
        private System.Windows.Forms.Label lbl_docgia_sosach_muontoida;
        private System.Windows.Forms.DateTimePicker datetime_docgia_ngayhethan;
        private System.Windows.Forms.DateTimePicker datetime_docgia_ngaycapthe;
        private System.Windows.Forms.TextBox txt_docgia_hoten;
        private System.Windows.Forms.TextBox txt_docgia_diachi;
        private System.Windows.Forms.TextBox txt_docgia_dienthoai;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.NumericUpDown number_sosach_toida;
        private System.Windows.Forms.NumericUpDown number_thoigian_toida;
        private System.Windows.Forms.Label lbl_docgia_them_title;
        private System.Windows.Forms.Button btn_them_docgia;
        private System.Windows.Forms.Button btn_docgia_huy;
        private System.Windows.Forms.Button btn_docgia_dong;
        private System.Windows.Forms.ComboBox cb_docgia_nghenghiep;
        private System.Windows.Forms.DateTimePicker dtpicker_docgia_namtotnghiep;
        private System.Windows.Forms.Label label1;
    }
}