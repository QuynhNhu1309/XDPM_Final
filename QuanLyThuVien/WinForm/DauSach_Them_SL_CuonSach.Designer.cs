namespace WinForm
{
    partial class DauSach_Them_SL_CuonSach
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
            this.txt_them_dau_sach = new System.Windows.Forms.TextBox();
            this.btn_them_sl_cuon_sach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số lượng cuốn sách cần thêm";
            // 
            // txt_them_dau_sach
            // 
            this.txt_them_dau_sach.Location = new System.Drawing.Point(224, 81);
            this.txt_them_dau_sach.Name = "txt_them_dau_sach";
            this.txt_them_dau_sach.Size = new System.Drawing.Size(151, 20);
            this.txt_them_dau_sach.TabIndex = 1;
            // 
            // btn_them_sl_cuon_sach
            // 
            this.btn_them_sl_cuon_sach.Location = new System.Drawing.Point(173, 142);
            this.btn_them_sl_cuon_sach.Name = "btn_them_sl_cuon_sach";
            this.btn_them_sl_cuon_sach.Size = new System.Drawing.Size(75, 23);
            this.btn_them_sl_cuon_sach.TabIndex = 2;
            this.btn_them_sl_cuon_sach.Text = "Thêm";
            this.btn_them_sl_cuon_sach.UseVisualStyleBackColor = true;
            this.btn_them_sl_cuon_sach.Click += new System.EventHandler(this.btn_them_sl_cuon_sach_Click);
            // 
            // DauSach_Them_SL_CuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 262);
            this.Controls.Add(this.btn_them_sl_cuon_sach);
            this.Controls.Add(this.txt_them_dau_sach);
            this.Controls.Add(this.label1);
            this.Name = "DauSach_Them_SL_CuonSach";
            this.Text = "DauSach_Them_SL_CuonSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_them_dau_sach;
        private System.Windows.Forms.Button btn_them_sl_cuon_sach;
    }
}