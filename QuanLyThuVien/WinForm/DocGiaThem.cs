using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinForm
{
    public partial class DocGiaThem : Form
    {
        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        public Models.doc_gia doc_gia = new doc_gia();

        public DocGiaThem()
        {
            InitializeComponent();
        }

        private void lbl_docgia_nam_tot_nghiep_Click(object sender, EventArgs e)
        {

        }

        private void DocGiaThem_Load(object sender, EventArgs e)
        {

        }





























        private void lbl_docgia_diachi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_dienthoai_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_ngaycapthe_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_ngayhethan_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_cmnd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_nghenghiep_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_thoigian_muontoida_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_sosach_muontoida_Click(object sender, EventArgs e)
        {

        }

        private void lbl_docgia_hoten_Click(object sender, EventArgs e)
        {

        }


        //THÊM ĐỘC GIẢ
        private void btn_them_docgia_Click(object sender, EventArgs e)
        {
            try
            {
                doc_gia.ho_ten = txt_docgia_hoten.Text.Trim();
                doc_gia.dia_chi = txt_docgia_diachi.Text.Trim();
                doc_gia.dien_thoai = txt_docgia_dienthoai.Text;
                doc_gia.ngay_cap_the = datetime_docgia_ngaycapthe.Value;
                doc_gia.ngay_het_han = datetime_docgia_ngayhethan.Value;
                doc_gia.nam_tot_nghiep = dtpicker_docgia_namtotnghiep.Value;
                doc_gia.so_sach_muon_toi_da = Decimal.ToInt32(number_sosach_toida.Value);
                doc_gia.thoi_gian_muon_toi_da = Decimal.ToInt32(number_thoigian_toida.Value);
                doc_gia.cmnd = txt_cmnd.Text;
                doc_gia.nghe_nghiep = cb_docgia_nghenghiep.Text;
                doc_gia.id_tinh_trang = 6;
                doc_gia.ma_doc_gia = db.Database.SqlQuery<string>(
                            "Get_ID_Ma_DocGia").Single();

                doc_gia.ma_the_thu_vien = db.Database.SqlQuery<string>(
                            "Get_MaTheThuVien").Single();

                //MessageBox.Show(doc_gia.ho_ten);

                //MessageBox.Show(doc_gia.dia_chi);
                //MessageBox.Show(doc_gia.dien_thoai);
                //MessageBox.Show(doc_gia.ngay_cap_the.ToString());
                //MessageBox.Show(doc_gia.ngay_het_han.ToString());
                //MessageBox.Show(doc_gia.nam_tot_nghiep.ToString());
                //MessageBox.Show(doc_gia.so_sach_muon_toi_da.ToString());
                //MessageBox.Show(doc_gia.thoi_gian_muon_toi_da.ToString());
                //MessageBox.Show(doc_gia.cmnd);
                //MessageBox.Show(doc_gia.nghe_nghiep);
                //MessageBox.Show(doc_gia.id_tinh_trang.ToString());
                //MessageBox.Show(doc_gia.ma_doc_gia);
                //MessageBox.Show(doc_gia.ma_the_thu_vien);


                db.doc_gia.Add(doc_gia);
                db.SaveChanges();
                MessageBox.Show("Thêm độc giả thành công");
                this.Hide();
                DocGia frm = new DocGia();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm độc giả không thành công. Vui lòng kiểm tra lại thông tin độc giả");
            }
            
            //MessageBox.Show(doc_gia.ma_the_thu_vien);
            

        }

        private void btn_docgia_huy_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void btn_docgia_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocGia frm = new DocGia();
            frm.Show();
        }
    }
}
