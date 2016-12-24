using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_dau_sach_Click(object sender, EventArgs e)
        {
            this.Hide();
            DauSach frm = new DauSach();
            frm.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap frm = new PhieuNhap();
            frm.Show();
        }

        private void btn_doc_gia_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocGia frm = new DocGia();
            frm.Show();
        }
    }
}
