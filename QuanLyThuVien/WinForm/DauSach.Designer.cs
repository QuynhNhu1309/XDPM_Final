namespace WinForm
{
    partial class DauSach
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
            this.dtgv_dau_sach = new System.Windows.Forms.DataGridView();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_them_cuon_sach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dau_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgv_dau_sach
            // 
            this.dtgv_dau_sach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_dau_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dau_sach.Location = new System.Drawing.Point(12, 79);
            this.dtgv_dau_sach.Name = "dtgv_dau_sach";
            this.dtgv_dau_sach.Size = new System.Drawing.Size(886, 214);
            this.dtgv_dau_sach.TabIndex = 1;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(86, 320);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 2;
            this.btn_xem.Text = "Xem chi tiết";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(191, 320);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(295, 320);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(719, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_them_cuon_sach
            // 
            this.btn_them_cuon_sach.Location = new System.Drawing.Point(414, 319);
            this.btn_them_cuon_sach.Name = "btn_them_cuon_sach";
            this.btn_them_cuon_sach.Size = new System.Drawing.Size(75, 23);
            this.btn_them_cuon_sach.TabIndex = 4;
            this.btn_them_cuon_sach.Text = "THÊM";
            this.btn_them_cuon_sach.UseVisualStyleBackColor = true;
            this.btn_them_cuon_sach.Click += new System.EventHandler(this.btn_them_cuon_sach_Click);
            // 
            // DauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 400);
            this.Controls.Add(this.btn_them_cuon_sach);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.dtgv_dau_sach);
            this.Controls.Add(this.label1);
            this.Name = "DauSach";
            this.Text = "DauSach";
            this.Load += new System.EventHandler(this.DauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dau_sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        public System.Windows.Forms.DataGridView dtgv_dau_sach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_them_cuon_sach;
    }
}