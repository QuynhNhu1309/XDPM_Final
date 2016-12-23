namespace WinForm
{
    partial class DocGia_Sua
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
            this.lbl_docgia_sua_title = new System.Windows.Forms.Label();
            this.dtpicker_docgia_namtotnghiep = new System.Windows.Forms.DateTimePicker();
            this.btn_docgia_sua_dong = new System.Windows.Forms.Button();
            this.btn_sua_docgia = new System.Windows.Forms.Button();
            this.number_thoigian_toida = new System.Windows.Forms.NumericUpDown();
            this.number_sosach_toida = new System.Windows.Forms.NumericUpDown();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_docgia_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_docgia_diachi = new System.Windows.Forms.TextBox();
            this.txt_docgia_hoten = new System.Windows.Forms.TextBox();
            this.datetime_docgia_ngaycapthe = new System.Windows.Forms.DateTimePicker();
            this.datetime_docgia_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.lbl_docgia_sosach_muontoida = new System.Windows.Forms.Label();
            this.lbl_docgia_nam_tot_nghiep = new System.Windows.Forms.Label();
            this.lbl_docgia_cmnd = new System.Windows.Forms.Label();
            this.lbl_docgia_thoigian_muontoida = new System.Windows.Forms.Label();
            this.lbl_docgia_ngayhethan = new System.Windows.Forms.Label();
            this.lbl_docgia_ngaycapthe = new System.Windows.Forms.Label();
            this.lbl_docgia_dienthoai = new System.Windows.Forms.Label();
            this.lbl_docgia_diachi = new System.Windows.Forms.Label();
            this.lbl_docgia_hoten = new System.Windows.Forms.Label();
            this.lbl_ma_docgia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_docgia_madocgia_sua = new System.Windows.Forms.TextBox();
            this.txt_docgia_mathe_thuvien_sua = new System.Windows.Forms.TextBox();
            this.lbl_mathe_thuvien = new System.Windows.Forms.Label();
            this.txt_docgia_nhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_docgia_tinhtrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.number_thoigian_toida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_sosach_toida)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_docgia_sua_title
            // 
            this.lbl_docgia_sua_title.AutoSize = true;
            this.lbl_docgia_sua_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_sua_title.Location = new System.Drawing.Point(436, 44);
            this.lbl_docgia_sua_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_sua_title.Name = "lbl_docgia_sua_title";
            this.lbl_docgia_sua_title.Size = new System.Drawing.Size(350, 31);
            this.lbl_docgia_sua_title.TabIndex = 29;
            this.lbl_docgia_sua_title.Text = "SỬA THÔNG TIN ĐỘC GIẢ";
            // 
            // dtpicker_docgia_namtotnghiep
            // 
            this.dtpicker_docgia_namtotnghiep.Enabled = false;
            this.dtpicker_docgia_namtotnghiep.Location = new System.Drawing.Point(873, 108);
            this.dtpicker_docgia_namtotnghiep.Margin = new System.Windows.Forms.Padding(4);
            this.dtpicker_docgia_namtotnghiep.Name = "dtpicker_docgia_namtotnghiep";
            this.dtpicker_docgia_namtotnghiep.Size = new System.Drawing.Size(265, 20);
            this.dtpicker_docgia_namtotnghiep.TabIndex = 52;
            // 
            // btn_docgia_sua_dong
            // 
            this.btn_docgia_sua_dong.Location = new System.Drawing.Point(633, 637);
            this.btn_docgia_sua_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_docgia_sua_dong.Name = "btn_docgia_sua_dong";
            this.btn_docgia_sua_dong.Size = new System.Drawing.Size(148, 39);
            this.btn_docgia_sua_dong.TabIndex = 50;
            this.btn_docgia_sua_dong.Text = "ĐÓNG";
            this.btn_docgia_sua_dong.UseVisualStyleBackColor = true;
            this.btn_docgia_sua_dong.Click += new System.EventHandler(this.btn_docgia_sua_dong_Click);
            // 
            // btn_sua_docgia
            // 
            this.btn_sua_docgia.Location = new System.Drawing.Point(442, 635);
            this.btn_sua_docgia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua_docgia.Name = "btn_sua_docgia";
            this.btn_sua_docgia.Size = new System.Drawing.Size(152, 41);
            this.btn_sua_docgia.TabIndex = 48;
            this.btn_sua_docgia.Text = "SỬA";
            this.btn_sua_docgia.UseVisualStyleBackColor = true;
            this.btn_sua_docgia.Click += new System.EventHandler(this.btn_sua_docgia_Click);
            // 
            // number_thoigian_toida
            // 
            this.number_thoigian_toida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_thoigian_toida.Location = new System.Drawing.Point(873, 259);
            this.number_thoigian_toida.Margin = new System.Windows.Forms.Padding(4);
            this.number_thoigian_toida.Name = "number_thoigian_toida";
            this.number_thoigian_toida.Size = new System.Drawing.Size(160, 22);
            this.number_thoigian_toida.TabIndex = 47;
            // 
            // number_sosach_toida
            // 
            this.number_sosach_toida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_sosach_toida.Location = new System.Drawing.Point(873, 174);
            this.number_sosach_toida.Margin = new System.Windows.Forms.Padding(4);
            this.number_sosach_toida.Name = "number_sosach_toida";
            this.number_sosach_toida.Size = new System.Drawing.Size(160, 22);
            this.number_sosach_toida.TabIndex = 46;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(873, 339);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.ReadOnly = true;
            this.txt_cmnd.Size = new System.Drawing.Size(287, 22);
            this.txt_cmnd.TabIndex = 44;
            // 
            // txt_docgia_dienthoai
            // 
            this.txt_docgia_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_dienthoai.Location = new System.Drawing.Point(246, 397);
            this.txt_docgia_dienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_dienthoai.Name = "txt_docgia_dienthoai";
            this.txt_docgia_dienthoai.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_dienthoai.TabIndex = 43;
            // 
            // txt_docgia_diachi
            // 
            this.txt_docgia_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_diachi.Location = new System.Drawing.Point(246, 316);
            this.txt_docgia_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_diachi.Name = "txt_docgia_diachi";
            this.txt_docgia_diachi.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_diachi.TabIndex = 42;
            // 
            // txt_docgia_hoten
            // 
            this.txt_docgia_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_hoten.Location = new System.Drawing.Point(246, 251);
            this.txt_docgia_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_hoten.Name = "txt_docgia_hoten";
            this.txt_docgia_hoten.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_hoten.TabIndex = 45;
            // 
            // datetime_docgia_ngaycapthe
            // 
            this.datetime_docgia_ngaycapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_docgia_ngaycapthe.Location = new System.Drawing.Point(246, 480);
            this.datetime_docgia_ngaycapthe.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_docgia_ngaycapthe.Name = "datetime_docgia_ngaycapthe";
            this.datetime_docgia_ngaycapthe.Size = new System.Drawing.Size(265, 22);
            this.datetime_docgia_ngaycapthe.TabIndex = 41;
            // 
            // datetime_docgia_ngayhethan
            // 
            this.datetime_docgia_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_docgia_ngayhethan.Location = new System.Drawing.Point(246, 570);
            this.datetime_docgia_ngayhethan.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_docgia_ngayhethan.Name = "datetime_docgia_ngayhethan";
            this.datetime_docgia_ngayhethan.Size = new System.Drawing.Size(265, 22);
            this.datetime_docgia_ngayhethan.TabIndex = 40;
            // 
            // lbl_docgia_sosach_muontoida
            // 
            this.lbl_docgia_sosach_muontoida.AutoSize = true;
            this.lbl_docgia_sosach_muontoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_sosach_muontoida.Location = new System.Drawing.Point(630, 181);
            this.lbl_docgia_sosach_muontoida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_sosach_muontoida.Name = "lbl_docgia_sosach_muontoida";
            this.lbl_docgia_sosach_muontoida.Size = new System.Drawing.Size(157, 16);
            this.lbl_docgia_sosach_muontoida.TabIndex = 38;
            this.lbl_docgia_sosach_muontoida.Text = "SỐ SÁCH MƯỢN TỐI ĐA";
            // 
            // lbl_docgia_nam_tot_nghiep
            // 
            this.lbl_docgia_nam_tot_nghiep.AutoSize = true;
            this.lbl_docgia_nam_tot_nghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_nam_tot_nghiep.Location = new System.Drawing.Point(630, 112);
            this.lbl_docgia_nam_tot_nghiep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_nam_tot_nghiep.Name = "lbl_docgia_nam_tot_nghiep";
            this.lbl_docgia_nam_tot_nghiep.Size = new System.Drawing.Size(123, 16);
            this.lbl_docgia_nam_tot_nghiep.TabIndex = 36;
            this.lbl_docgia_nam_tot_nghiep.Text = "NĂM TỐT NGHIỆP";
            // 
            // lbl_docgia_cmnd
            // 
            this.lbl_docgia_cmnd.AutoSize = true;
            this.lbl_docgia_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_cmnd.Location = new System.Drawing.Point(630, 344);
            this.lbl_docgia_cmnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_cmnd.Name = "lbl_docgia_cmnd";
            this.lbl_docgia_cmnd.Size = new System.Drawing.Size(168, 16);
            this.lbl_docgia_cmnd.TabIndex = 35;
            this.lbl_docgia_cmnd.Text = "CHỨNG MINH NHÂN DÂN";
            // 
            // lbl_docgia_thoigian_muontoida
            // 
            this.lbl_docgia_thoigian_muontoida.AutoSize = true;
            this.lbl_docgia_thoigian_muontoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_thoigian_muontoida.Location = new System.Drawing.Point(630, 262);
            this.lbl_docgia_thoigian_muontoida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_thoigian_muontoida.Name = "lbl_docgia_thoigian_muontoida";
            this.lbl_docgia_thoigian_muontoida.Size = new System.Drawing.Size(165, 16);
            this.lbl_docgia_thoigian_muontoida.TabIndex = 34;
            this.lbl_docgia_thoigian_muontoida.Text = "THỜI GIAN MƯỢN TỐI ĐA";
            // 
            // lbl_docgia_ngayhethan
            // 
            this.lbl_docgia_ngayhethan.AutoSize = true;
            this.lbl_docgia_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_ngayhethan.Location = new System.Drawing.Point(63, 570);
            this.lbl_docgia_ngayhethan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_ngayhethan.Name = "lbl_docgia_ngayhethan";
            this.lbl_docgia_ngayhethan.Size = new System.Drawing.Size(109, 16);
            this.lbl_docgia_ngayhethan.TabIndex = 33;
            this.lbl_docgia_ngayhethan.Text = "NGÀY HẾT HẠN";
            // 
            // lbl_docgia_ngaycapthe
            // 
            this.lbl_docgia_ngaycapthe.AutoSize = true;
            this.lbl_docgia_ngaycapthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_ngaycapthe.Location = new System.Drawing.Point(63, 487);
            this.lbl_docgia_ngaycapthe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_ngaycapthe.Name = "lbl_docgia_ngaycapthe";
            this.lbl_docgia_ngaycapthe.Size = new System.Drawing.Size(107, 16);
            this.lbl_docgia_ngaycapthe.TabIndex = 32;
            this.lbl_docgia_ngaycapthe.Text = "NGÀY CẤP THẺ";
            // 
            // lbl_docgia_dienthoai
            // 
            this.lbl_docgia_dienthoai.AutoSize = true;
            this.lbl_docgia_dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_dienthoai.Location = new System.Drawing.Point(59, 405);
            this.lbl_docgia_dienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_dienthoai.Name = "lbl_docgia_dienthoai";
            this.lbl_docgia_dienthoai.Size = new System.Drawing.Size(83, 16);
            this.lbl_docgia_dienthoai.TabIndex = 31;
            this.lbl_docgia_dienthoai.Text = "ĐIỆN THOẠI";
            // 
            // lbl_docgia_diachi
            // 
            this.lbl_docgia_diachi.AutoSize = true;
            this.lbl_docgia_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_diachi.Location = new System.Drawing.Point(63, 326);
            this.lbl_docgia_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_diachi.Name = "lbl_docgia_diachi";
            this.lbl_docgia_diachi.Size = new System.Drawing.Size(54, 16);
            this.lbl_docgia_diachi.TabIndex = 39;
            this.lbl_docgia_diachi.Text = "ĐỊA CHỈ";
            // 
            // lbl_docgia_hoten
            // 
            this.lbl_docgia_hoten.AutoSize = true;
            this.lbl_docgia_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia_hoten.Location = new System.Drawing.Point(63, 262);
            this.lbl_docgia_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_docgia_hoten.Name = "lbl_docgia_hoten";
            this.lbl_docgia_hoten.Size = new System.Drawing.Size(80, 16);
            this.lbl_docgia_hoten.TabIndex = 30;
            this.lbl_docgia_hoten.Text = "HỌ VÀ TÊN";
            // 
            // lbl_ma_docgia
            // 
            this.lbl_ma_docgia.AutoSize = true;
            this.lbl_ma_docgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma_docgia.Location = new System.Drawing.Point(63, 117);
            this.lbl_ma_docgia.Name = "lbl_ma_docgia";
            this.lbl_ma_docgia.Size = new System.Drawing.Size(84, 16);
            this.lbl_ma_docgia.TabIndex = 53;
            this.lbl_ma_docgia.Text = "MÃ ĐỘC GIẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // txt_docgia_madocgia_sua
            // 
            this.txt_docgia_madocgia_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_madocgia_sua.Location = new System.Drawing.Point(246, 112);
            this.txt_docgia_madocgia_sua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_madocgia_sua.Name = "txt_docgia_madocgia_sua";
            this.txt_docgia_madocgia_sua.ReadOnly = true;
            this.txt_docgia_madocgia_sua.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_madocgia_sua.TabIndex = 45;
            // 
            // txt_docgia_mathe_thuvien_sua
            // 
            this.txt_docgia_mathe_thuvien_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docgia_mathe_thuvien_sua.Location = new System.Drawing.Point(246, 175);
            this.txt_docgia_mathe_thuvien_sua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docgia_mathe_thuvien_sua.Name = "txt_docgia_mathe_thuvien_sua";
            this.txt_docgia_mathe_thuvien_sua.ReadOnly = true;
            this.txt_docgia_mathe_thuvien_sua.Size = new System.Drawing.Size(265, 22);
            this.txt_docgia_mathe_thuvien_sua.TabIndex = 45;
            // 
            // lbl_mathe_thuvien
            // 
            this.lbl_mathe_thuvien.AutoSize = true;
            this.lbl_mathe_thuvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mathe_thuvien.Location = new System.Drawing.Point(63, 183);
            this.lbl_mathe_thuvien.Name = "lbl_mathe_thuvien";
            this.lbl_mathe_thuvien.Size = new System.Drawing.Size(125, 16);
            this.lbl_mathe_thuvien.TabIndex = 53;
            this.lbl_mathe_thuvien.Text = "MÃ THẺ THƯ VIỆN";
            // 
            // txt_docgia_nhanvien
            // 
            this.txt_docgia_nhanvien.Location = new System.Drawing.Point(873, 487);
            this.txt_docgia_nhanvien.Name = "txt_docgia_nhanvien";
            this.txt_docgia_nhanvien.ReadOnly = true;
            this.txt_docgia_nhanvien.Size = new System.Drawing.Size(287, 20);
            this.txt_docgia_nhanvien.TabIndex = 56;
            this.txt_docgia_nhanvien.Text = "Phạm Lê Quỳnh Như";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "TÌNH TRẠNG";
            // 
            // cb_docgia_tinhtrang
            // 
            this.cb_docgia_tinhtrang.FormattingEnabled = true;
            this.cb_docgia_tinhtrang.Location = new System.Drawing.Point(873, 415);
            this.cb_docgia_tinhtrang.Name = "cb_docgia_tinhtrang";
            this.cb_docgia_tinhtrang.Size = new System.Drawing.Size(287, 21);
            this.cb_docgia_tinhtrang.TabIndex = 55;
            // 
            // DocGia_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 702);
            this.Controls.Add(this.txt_docgia_nhanvien);
            this.Controls.Add(this.cb_docgia_tinhtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mathe_thuvien);
            this.Controls.Add(this.lbl_ma_docgia);
            this.Controls.Add(this.dtpicker_docgia_namtotnghiep);
            this.Controls.Add(this.btn_docgia_sua_dong);
            this.Controls.Add(this.btn_sua_docgia);
            this.Controls.Add(this.number_thoigian_toida);
            this.Controls.Add(this.number_sosach_toida);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_docgia_dienthoai);
            this.Controls.Add(this.txt_docgia_mathe_thuvien_sua);
            this.Controls.Add(this.txt_docgia_diachi);
            this.Controls.Add(this.txt_docgia_madocgia_sua);
            this.Controls.Add(this.txt_docgia_hoten);
            this.Controls.Add(this.datetime_docgia_ngaycapthe);
            this.Controls.Add(this.datetime_docgia_ngayhethan);
            this.Controls.Add(this.lbl_docgia_sosach_muontoida);
            this.Controls.Add(this.lbl_docgia_nam_tot_nghiep);
            this.Controls.Add(this.lbl_docgia_cmnd);
            this.Controls.Add(this.lbl_docgia_thoigian_muontoida);
            this.Controls.Add(this.lbl_docgia_ngayhethan);
            this.Controls.Add(this.lbl_docgia_ngaycapthe);
            this.Controls.Add(this.lbl_docgia_dienthoai);
            this.Controls.Add(this.lbl_docgia_diachi);
            this.Controls.Add(this.lbl_docgia_hoten);
            this.Controls.Add(this.lbl_docgia_sua_title);
            this.Name = "DocGia_Sua";
            this.Text = "SỬA THÔNG TIN ĐỘC GIẢ";
            this.Load += new System.EventHandler(this.DocGia_Sua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number_thoigian_toida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_sosach_toida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_docgia_sua_title;
        private System.Windows.Forms.Button btn_docgia_sua_dong;
        private System.Windows.Forms.Button btn_sua_docgia;
        private System.Windows.Forms.Label lbl_docgia_sosach_muontoida;
        private System.Windows.Forms.Label lbl_docgia_nam_tot_nghiep;
        private System.Windows.Forms.Label lbl_docgia_cmnd;
        private System.Windows.Forms.Label lbl_docgia_thoigian_muontoida;
        private System.Windows.Forms.Label lbl_docgia_ngayhethan;
        private System.Windows.Forms.Label lbl_docgia_ngaycapthe;
        private System.Windows.Forms.Label lbl_docgia_dienthoai;
        private System.Windows.Forms.Label lbl_docgia_diachi;
        private System.Windows.Forms.Label lbl_docgia_hoten;
        private System.Windows.Forms.Label lbl_ma_docgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mathe_thuvien;
        public System.Windows.Forms.DateTimePicker dtpicker_docgia_namtotnghiep;
        public System.Windows.Forms.NumericUpDown number_thoigian_toida;
        public System.Windows.Forms.NumericUpDown number_sosach_toida;
        public System.Windows.Forms.TextBox txt_cmnd;
        public System.Windows.Forms.TextBox txt_docgia_dienthoai;
        public System.Windows.Forms.TextBox txt_docgia_diachi;
        public System.Windows.Forms.TextBox txt_docgia_hoten;
        public System.Windows.Forms.DateTimePicker datetime_docgia_ngaycapthe;
        public System.Windows.Forms.DateTimePicker datetime_docgia_ngayhethan;
        public System.Windows.Forms.TextBox txt_docgia_madocgia_sua;
        public System.Windows.Forms.TextBox txt_docgia_mathe_thuvien_sua;
        private System.Windows.Forms.TextBox txt_docgia_nhanvien;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_docgia_tinhtrang;

    }
}