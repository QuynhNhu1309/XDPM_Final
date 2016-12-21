namespace WinForm
{
    partial class PhieuNhap
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
            this.dtgrv_phieu_nhap = new System.Windows.Forms.DataGridView();
            this.btn_next_end = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_back_e = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xem_phieu_nhap = new System.Windows.Forms.Button();
            this.lbl_ds_phieunhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_phieu_nhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrv_phieu_nhap
            // 
            this.dtgrv_phieu_nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_phieu_nhap.Location = new System.Drawing.Point(12, 115);
            this.dtgrv_phieu_nhap.Name = "dtgrv_phieu_nhap";
            this.dtgrv_phieu_nhap.Size = new System.Drawing.Size(854, 214);
            this.dtgrv_phieu_nhap.TabIndex = 0;
            // 
            // btn_next_end
            // 
            this.btn_next_end.Location = new System.Drawing.Point(834, 46);
            this.btn_next_end.Name = "btn_next_end";
            this.btn_next_end.Size = new System.Drawing.Size(32, 23);
            this.btn_next_end.TabIndex = 6;
            this.btn_next_end.Text = ">>";
            this.btn_next_end.UseVisualStyleBackColor = true;
            this.btn_next_end.Click += new System.EventHandler(this.btn_next_end_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(796, 46);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(32, 23);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(758, 46);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(32, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_back_e
            // 
            this.btn_back_e.Location = new System.Drawing.Point(720, 46);
            this.btn_back_e.Name = "btn_back_e";
            this.btn_back_e.Size = new System.Drawing.Size(32, 23);
            this.btn_back_e.TabIndex = 9;
            this.btn_back_e.Text = "<<";
            this.btn_back_e.UseVisualStyleBackColor = true;
            this.btn_back_e.Click += new System.EventHandler(this.btn_back_e_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(584, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(413, 351);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(85, 32);
            this.btn_xem.TabIndex = 11;
            this.btn_xem.Text = "ĐÓNG";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xem_phieu_nhap
            // 
            this.btn_xem_phieu_nhap.Location = new System.Drawing.Point(251, 351);
            this.btn_xem_phieu_nhap.Name = "btn_xem_phieu_nhap";
            this.btn_xem_phieu_nhap.Size = new System.Drawing.Size(129, 32);
            this.btn_xem_phieu_nhap.TabIndex = 11;
            this.btn_xem_phieu_nhap.Text = "XEM CHI TIẾT";
            this.btn_xem_phieu_nhap.UseVisualStyleBackColor = true;
            this.btn_xem_phieu_nhap.Click += new System.EventHandler(this.btn_xem_phieu_nhap_Click);
            // 
            // lbl_ds_phieunhap
            // 
            this.lbl_ds_phieunhap.AutoSize = true;
            this.lbl_ds_phieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ds_phieunhap.Location = new System.Drawing.Point(145, 34);
            this.lbl_ds_phieunhap.Name = "lbl_ds_phieunhap";
            this.lbl_ds_phieunhap.Size = new System.Drawing.Size(349, 31);
            this.lbl_ds_phieunhap.TabIndex = 31;
            this.lbl_ds_phieunhap.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 408);
            this.Controls.Add(this.lbl_ds_phieunhap);
            this.Controls.Add(this.btn_xem_phieu_nhap);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_back_e);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_next_end);
            this.Controls.Add(this.dtgrv_phieu_nhap);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_phieu_nhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv_phieu_nhap;
        private System.Windows.Forms.Button btn_next_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_back_e;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xem_phieu_nhap;
        public System.Windows.Forms.Label lbl_ds_phieunhap;
    }
}