using Models;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinForm
{
    public partial class DocGia_Sua : Form
    {
        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        public Models.doc_gia doc_gia = new doc_gia();
        public int id_docgia = 0;

        public DocGia_Sua(Int32 id)
        {
            id_docgia = id;
            InitializeComponent();
        }

        private void DocGia_Sua_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_sua_docgia_Click(object sender, EventArgs e)
        {
            try
            {

                doc_gia obj = db.doc_gia.Find(id_docgia);
                obj.ho_ten = txt_docgia_hoten.Text.Trim();
                obj.dia_chi = txt_docgia_diachi.Text.Trim();
                obj.dien_thoai = txt_docgia_dienthoai.Text.Trim();
                obj.ngay_cap_the = datetime_docgia_ngaycapthe.Value;
                obj.ngay_het_han = datetime_docgia_ngayhethan.Value;
                obj.nam_tot_nghiep = dtpicker_docgia_namtotnghiep.Value;
                obj.so_sach_muon_toi_da = Decimal.ToInt32(number_sosach_toida.Value);
                obj.thoi_gian_muon_toi_da = Decimal.ToInt32(number_thoigian_toida.Value);
                //obj.cmnd = datetime_docgia_ngaycapthe.Value;
                obj.id_tinh_trang = int.Parse(cb_docgia_tinhtrang.SelectedValue.ToString());
                db.SaveChanges();
                //obj.nghe_nghiep = datetime_docgia_ngaycapthe.Value;
                MessageBox.Show("Sửa thông tin thành công");
                this.Hide();
                DocGia frm = new DocGia();
                frm.Show();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sửa độc giả không thành công. Vui lòng kiểm tra lại thông tin độc giả");
            }
        }

        //HỦy sửa độc giả

        //private void btn_docgia_sua_huy_Click(object sender, EventArgs e)
        //{
        //    Controls.Clear();
        //    InitializeComponent();
        //}

        //Đóng form

        private void btn_docgia_sua_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocGia frm = new DocGia();
            frm.Show();
        }
    }
}
