namespace WinForm
{
    partial class DocGia
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
            this.dtgv_docgia = new System.Windows.Forms.DataGridView();
            this.lbl_ds_docgia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_back_e = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_next_end = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_docgia_them = new System.Windows.Forms.Button();
            this.btn_docgia_sua = new System.Windows.Forms.Button();
            this.btn_docgia_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_docgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_docgia
            // 
            this.dtgv_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_docgia.Location = new System.Drawing.Point(89, 140);
            this.dtgv_docgia.Name = "dtgv_docgia";
            this.dtgv_docgia.Size = new System.Drawing.Size(887, 309);
            this.dtgv_docgia.TabIndex = 0;
            // 
            // lbl_ds_docgia
            // 
            this.lbl_ds_docgia.AutoSize = true;
            this.lbl_ds_docgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ds_docgia.Location = new System.Drawing.Point(410, 43);
            this.lbl_ds_docgia.Name = "lbl_ds_docgia";
            this.lbl_ds_docgia.Size = new System.Drawing.Size(297, 31);
            this.lbl_ds_docgia.TabIndex = 12;
            this.lbl_ds_docgia.Text = "DANH SÁCH ĐỘC GIẢ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(750, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_back_e
            // 
            this.btn_back_e.Location = new System.Drawing.Point(819, 100);
            this.btn_back_e.Name = "btn_back_e";
            this.btn_back_e.Size = new System.Drawing.Size(32, 23);
            this.btn_back_e.TabIndex = 16;
            this.btn_back_e.Text = "<<";
            this.btn_back_e.UseVisualStyleBackColor = true;
            this.btn_back_e.Click += new System.EventHandler(this.btn_back_e_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(857, 100);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(32, 23);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(895, 100);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(32, 23);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_next_end
            // 
            this.btn_next_end.Location = new System.Drawing.Point(933, 100);
            this.btn_next_end.Name = "btn_next_end";
            this.btn_next_end.Size = new System.Drawing.Size(32, 23);
            this.btn_next_end.TabIndex = 13;
            this.btn_next_end.Text = ">>";
            this.btn_next_end.UseVisualStyleBackColor = true;
            this.btn_next_end.Click += new System.EventHandler(this.btn_next_end_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "XEM CHI TIẾT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_docgia_them
            // 
            this.btn_docgia_them.Location = new System.Drawing.Point(279, 502);
            this.btn_docgia_them.Name = "btn_docgia_them";
            this.btn_docgia_them.Size = new System.Drawing.Size(98, 32);
            this.btn_docgia_them.TabIndex = 19;
            this.btn_docgia_them.Text = "THÊM";
            this.btn_docgia_them.UseVisualStyleBackColor = true;
            this.btn_docgia_them.Click += new System.EventHandler(this.btn_docgia_them_Click);
            // 
            // btn_docgia_sua
            // 
            this.btn_docgia_sua.Location = new System.Drawing.Point(524, 502);
            this.btn_docgia_sua.Name = "btn_docgia_sua";
            this.btn_docgia_sua.Size = new System.Drawing.Size(103, 32);
            this.btn_docgia_sua.TabIndex = 20;
            this.btn_docgia_sua.Text = "SỬA";
            this.btn_docgia_sua.UseVisualStyleBackColor = true;
            this.btn_docgia_sua.Click += new System.EventHandler(this.btn_docgia_sua_Click);
            // 
            // btn_docgia_dong
            // 
            this.btn_docgia_dong.Location = new System.Drawing.Point(654, 502);
            this.btn_docgia_dong.Name = "btn_docgia_dong";
            this.btn_docgia_dong.Size = new System.Drawing.Size(103, 33);
            this.btn_docgia_dong.TabIndex = 21;
            this.btn_docgia_dong.Text = "ĐÓNG";
            this.btn_docgia_dong.UseVisualStyleBackColor = true;
            this.btn_docgia_dong.Click += new System.EventHandler(this.btn_docgia_dong_Click);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 570);
            this.Controls.Add(this.btn_docgia_dong);
            this.Controls.Add(this.btn_docgia_sua);
            this.Controls.Add(this.btn_docgia_them);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_back_e);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_next_end);
            this.Controls.Add(this.lbl_ds_docgia);
            this.Controls.Add(this.dtgv_docgia);
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_docgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_docgia;
        public System.Windows.Forms.Label lbl_ds_docgia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_back_e;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_next_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_docgia_them;
        private System.Windows.Forms.Button btn_docgia_sua;
        private System.Windows.Forms.Button btn_docgia_dong;
    }
}