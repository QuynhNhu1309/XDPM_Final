namespace WinForm
{
    partial class frm_main
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
            this.btn_dau_sach = new System.Windows.Forms.Button();
            this.btn_doc_gia = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dau_sach
            // 
            this.btn_dau_sach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dau_sach.Location = new System.Drawing.Point(146, 36);
            this.btn_dau_sach.Name = "btn_dau_sach";
            this.btn_dau_sach.Size = new System.Drawing.Size(190, 54);
            this.btn_dau_sach.TabIndex = 0;
            this.btn_dau_sach.Text = "QUẢN LÝ ĐẦU SÁCH";
            this.btn_dau_sach.UseVisualStyleBackColor = true;
            // 
            // btn_doc_gia
            // 
            this.btn_doc_gia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doc_gia.Location = new System.Drawing.Point(146, 113);
            this.btn_doc_gia.Name = "btn_doc_gia";
            this.btn_doc_gia.Size = new System.Drawing.Size(190, 50);
            this.btn_doc_gia.TabIndex = 0;
            this.btn_doc_gia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.btn_doc_gia.UseVisualStyleBackColor = true;
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thongke.Location = new System.Drawing.Point(146, 193);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(190, 43);
            this.btn_thongke.TabIndex = 0;
            this.btn_thongke.Text = "THỐNG KÊ";
            this.btn_thongke.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thoat.Location = new System.Drawing.Point(146, 269);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(190, 45);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WinForm.Properties.Resources.Lilacs_Book_620x349;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 357);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.btn_doc_gia);
            this.Controls.Add(this.btn_dau_sach);
            this.DoubleBuffered = true;
            this.Name = "frm_main";
            this.Text = "TRANG CHỦ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dau_sach;
        private System.Windows.Forms.Button btn_doc_gia;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_thoat;
    }
}

