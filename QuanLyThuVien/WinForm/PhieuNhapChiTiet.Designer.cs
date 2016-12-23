namespace WinForm
{
    partial class PhieuNhapChiTiet
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
            this.btn_dong_xem_ct_phieunhap = new System.Windows.Forms.Button();
            this.lbl_xemct_phieunhap = new System.Windows.Forms.Label();
            this.dtgv_phieunhapct = new System.Windows.Forms.DataGridView();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_phieunhapct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dong_xem_ct_phieunhap
            // 
            this.btn_dong_xem_ct_phieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong_xem_ct_phieunhap.Location = new System.Drawing.Point(427, 404);
            this.btn_dong_xem_ct_phieunhap.Name = "btn_dong_xem_ct_phieunhap";
            this.btn_dong_xem_ct_phieunhap.Size = new System.Drawing.Size(84, 27);
            this.btn_dong_xem_ct_phieunhap.TabIndex = 40;
            this.btn_dong_xem_ct_phieunhap.Text = "ĐÓNG";
            this.btn_dong_xem_ct_phieunhap.UseVisualStyleBackColor = true;
            this.btn_dong_xem_ct_phieunhap.Click += new System.EventHandler(this.btn_dong_xem_ct_phieunhap_Click);
            // 
            // lbl_xemct_phieunhap
            // 
            this.lbl_xemct_phieunhap.AutoSize = true;
            this.lbl_xemct_phieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xemct_phieunhap.Location = new System.Drawing.Point(322, 32);
            this.lbl_xemct_phieunhap.Name = "lbl_xemct_phieunhap";
            this.lbl_xemct_phieunhap.Size = new System.Drawing.Size(375, 31);
            this.lbl_xemct_phieunhap.TabIndex = 30;
            this.lbl_xemct_phieunhap.Text = "XEM CHI TIẾT PHIẾU NHẬP ";
            // 
            // dtgv_phieunhapct
            // 
            this.dtgv_phieunhapct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_phieunhapct.Location = new System.Drawing.Point(58, 105);
            this.dtgv_phieunhapct.Name = "dtgv_phieunhapct";
            this.dtgv_phieunhapct.Size = new System.Drawing.Size(901, 208);
            this.dtgv_phieunhapct.TabIndex = 41;
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap.Location = new System.Drawing.Point(729, 76);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(55, 16);
            this.lbl_ngaynhap.TabIndex = 42;
            this.lbl_ngaynhap.Text = "NGÀY : ";
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Location = new System.Drawing.Point(465, 347);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(90, 16);
            this.lbl_nhanvien.TabIndex = 42;
            this.lbl_nhanvien.Text = "NHÂN VIÊN : ";
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.Location = new System.Drawing.Point(718, 347);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(90, 16);
            this.lbl_tongtien.TabIndex = 42;
            this.lbl_tongtien.Text = "TỔNG TIỀN : ";
            // 
            // PhieuNhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 566);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.lbl_nhanvien);
            this.Controls.Add(this.lbl_ngaynhap);
            this.Controls.Add(this.dtgv_phieunhapct);
            this.Controls.Add(this.btn_dong_xem_ct_phieunhap);
            this.Controls.Add(this.lbl_xemct_phieunhap);
            this.Name = "PhieuNhapChiTiet";
            this.Text = "XEM CHI TIẾT PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.PhieuNhapChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_phieunhapct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_dong_xem_ct_phieunhap;
        public System.Windows.Forms.Label lbl_xemct_phieunhap;
        public System.Windows.Forms.Label lbl_ngaynhap;
        public System.Windows.Forms.Label lbl_nhanvien;
        public System.Windows.Forms.Label lbl_tongtien;
        public System.Windows.Forms.DataGridView dtgv_phieunhapct;
    }
}