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
            this.btn_next_end = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_back_e = new System.Windows.Forms.Button();
            this.btn_dausach_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dau_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẦU SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgv_dau_sach
            // 
            this.dtgv_dau_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dau_sach.Location = new System.Drawing.Point(51, 175);
            this.dtgv_dau_sach.Name = "dtgv_dau_sach";
            this.dtgv_dau_sach.Size = new System.Drawing.Size(1085, 236);
            this.dtgv_dau_sach.TabIndex = 1;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(291, 453);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(97, 33);
            this.btn_xem.TabIndex = 2;
            this.btn_xem.Text = "XEM CHI TIẾT";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(852, 458);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Visible = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(414, 453);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 33);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(871, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_them_cuon_sach
            // 
            this.btn_them_cuon_sach.Location = new System.Drawing.Point(529, 452);
            this.btn_them_cuon_sach.Name = "btn_them_cuon_sach";
            this.btn_them_cuon_sach.Size = new System.Drawing.Size(104, 34);
            this.btn_them_cuon_sach.TabIndex = 4;
            this.btn_them_cuon_sach.Text = "NHẬP SÁCH";
            this.btn_them_cuon_sach.UseVisualStyleBackColor = true;
            this.btn_them_cuon_sach.Click += new System.EventHandler(this.btn_them_cuon_sach_Click);
            // 
            // btn_next_end
            // 
            this.btn_next_end.Location = new System.Drawing.Point(1077, 122);
            this.btn_next_end.Name = "btn_next_end";
            this.btn_next_end.Size = new System.Drawing.Size(32, 23);
            this.btn_next_end.TabIndex = 5;
            this.btn_next_end.Text = ">>";
            this.btn_next_end.UseVisualStyleBackColor = true;
            this.btn_next_end.Click += new System.EventHandler(this.btn_next_end_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1039, 122);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(32, 23);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1001, 122);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(32, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_back_e
            // 
            this.btn_back_e.Location = new System.Drawing.Point(963, 122);
            this.btn_back_e.Name = "btn_back_e";
            this.btn_back_e.Size = new System.Drawing.Size(32, 23);
            this.btn_back_e.TabIndex = 6;
            this.btn_back_e.Text = "<<";
            this.btn_back_e.UseVisualStyleBackColor = true;
            this.btn_back_e.Click += new System.EventHandler(this.btn_back_e_Click);
            // 
            // btn_dausach_dong
            // 
            this.btn_dausach_dong.Location = new System.Drawing.Point(653, 452);
            this.btn_dausach_dong.Name = "btn_dausach_dong";
            this.btn_dausach_dong.Size = new System.Drawing.Size(98, 33);
            this.btn_dausach_dong.TabIndex = 7;
            this.btn_dausach_dong.Text = "ĐÓNG";
            this.btn_dausach_dong.UseVisualStyleBackColor = true;
            this.btn_dausach_dong.Click += new System.EventHandler(this.btn_dausach_dong_Click);
            // 
            // DauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 535);
            this.Controls.Add(this.btn_dausach_dong);
            this.Controls.Add(this.btn_back_e);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_next_end);
            this.Controls.Add(this.btn_them_cuon_sach);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.dtgv_dau_sach);
            this.Controls.Add(this.label1);
            this.Name = "DauSach";
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
        private System.Windows.Forms.Button btn_next_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_back_e;
        private System.Windows.Forms.Button btn_dausach_dong;
    }
}