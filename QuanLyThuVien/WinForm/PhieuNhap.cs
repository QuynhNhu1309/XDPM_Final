using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.ViewModel;
using System.Data.SqlClient;
using System;

namespace WinForm
{
    public partial class PhieuNhap : Form
    {

        QuanLyThuVienDB db = new QuanLyThuVienDB();
        phieu_nhap phieu_nhap = new phieu_nhap();
        public int current_page_Index = 0;
        public int number_page = 1;
        public int total_dau_sach = 1;
        public int number_record = 2;
       
        public PhieuNhap()
        {
            InitializeComponent();
        }

        public void Refresh_Form(Int32 number_record, Int32 current_page_Index)
        {

            total_dau_sach = db.phieu_nhap.Count();
            number_page = total_dau_sach / number_record;
            if (total_dau_sach % number_record > 0)
            {
                number_page = number_page + 1;
            }
            number_page = number_page - 1;

            //Xét điều kiện nếu trang đầu tiên thì không cho <
            if (current_page_Index == 0)
            {
                btn_back.Enabled = false;
            }
            if (current_page_Index > 0)
            {
                btn_back.Enabled = true;
            }

            //Nếu trang đầu tiên thì không cho <<
            if (current_page_Index == 0)
            {
                btn_back_e.Enabled = false;
            }
            if (current_page_Index > 0)
            {
                btn_back_e.Enabled = true;
            }

            //Nếu trang cuối cùng thì không cho >
            if (current_page_Index == number_page)
            {
                btn_next.Enabled = false;
            }
            if (current_page_Index >= 0 && current_page_Index < number_page)
            {
                btn_next.Enabled = true;
            }

            //Nếu trang cuối cùng thì không cho >>
            if (current_page_Index == number_page)
            {
                btn_next_end.Enabled = false;
            }
            if (current_page_Index >= 0 && current_page_Index < number_page)
            {
                btn_next_end.Enabled = true;
            }



            //MessageBox.Show("number_record = " + number_record.ToString());
            //MessageBox.Show("current_page_Index = " + current_page_Index.ToString());
            //var bindinglist = new BindingList<DauSachViewModel>(db.dau_sach.ToList().Select(i => new DauSachViewModel(i)).Take///(4).ToList());


            //var query =  from p in db.dau_sach 
            //            select new { p.ma_dau_sach, p.ten_dau_sach, p.id_loai_sach };


            // MessageBox.Show(total_dau_sach.ToString());



            if (current_page_Index == 0)
            {
                var q = (from w in db.phieu_nhap.AsEnumerable()
                         select new
                         {
                             w.id,
                             w.ma_phieu_nhap,
                             w.ngay_nhap, //0,1,2
                             w.tongtien,
                             w.nhan_vien.ho_ten,//3,4

                         }) //12,13
                           .Skip(current_page_Index * number_record).Take(number_record).ToList();
                dtgrv_phieu_nhap.DataSource = q.ToList();
            }
            else if (current_page_Index > 0)
            {
                var q = (from w in db.phieu_nhap.AsEnumerable()
                         select new
                         {
                             w.id,
                             w.ma_phieu_nhap,
                             w.ngay_nhap, //0,1,2
                             w.tongtien,
                             w.nhan_vien.ho_ten,//3,4
                         }) //12,13
                           .Skip(current_page_Index * number_record).Take(number_record).ToList();
                dtgrv_phieu_nhap.DataSource = q.ToList();
            }

            //var bindinglist = new BindingList<dau_sach>(db.dau_sach.ToList().Select(w => new w.ma_dau_sach).ToList());
            //var source = new BindingSource(bindinglist, null);
            //dtgv_dau_sach.DataSource = source;
            dtgrv_phieu_nhap.Columns[0].HeaderText = "id";
            dtgrv_phieu_nhap.Columns[0].Visible = false;

            dtgrv_phieu_nhap.Columns[1].HeaderText = "Mã phiếu nhập";
            dtgrv_phieu_nhap.Columns[1].Visible = true;

            dtgrv_phieu_nhap.Columns[2].HeaderText = "Ngày nhập";
            dtgrv_phieu_nhap.Columns[2].Visible = true;

            dtgrv_phieu_nhap.Columns[3].HeaderText = "Tổng tiền";
            dtgrv_phieu_nhap.Columns[3].Visible = true;

            dtgrv_phieu_nhap.Columns[4].HeaderText = "Tên nhân viên";
            dtgrv_phieu_nhap.Columns[4].Visible = true;
        }


        private void PhieuNhap_Load(object sender, System.EventArgs e)
        {
            Refresh_Form(number_record, current_page_Index);
        }

        private void btn_back_e_Click(object sender, EventArgs e)
        {
            current_page_Index = 0;
            Refresh_Form(number_record, current_page_Index);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (current_page_Index <= number_page)
            {
                current_page_Index = current_page_Index - 1;
                Refresh_Form(number_record, current_page_Index);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current_page_Index < number_page)
            {
                current_page_Index = current_page_Index + 1;
                Refresh_Form(number_record, current_page_Index);
            }
        }

        private void btn_next_end_Click(object sender, EventArgs e)
        {
            current_page_Index = number_page;
            Refresh_Form(number_record, current_page_Index);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            number_record = int.Parse(selectedItem.ToString());
            Refresh_Form(number_record, current_page_Index);
        }

        //Xem phiếu nhập chi tiết

        private void btn_xem_phieu_nhap_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                    dtgrv_phieu_nhap.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //MessageBox.Show(this.dtgrv_phieu_nhap.CurrentRow.Cells[0].Value.ToString());
            if (selectedRowCount == 1)
            {
                int id_pn = Convert.ToInt32(dtgrv_phieu_nhap.CurrentRow.Cells[0].Value.ToString());
                PhieuNhapChiTiet frm = new PhieuNhapChiTiet();
                    var ct = (from w in db.phieu_nhap_chi_tiet
                              
                             select new
                             {
                                 w.id,
                                 w.ma_phieu_nhap_chi_tiet,
                                 w.nha_xuat_ban.ten_nxb, //0,1,2
                                 w.dau_sach.ten_dau_sach,
                                 w.gia_nhap,//3,4
                                 w.so_luong_nhap,//5,6
                                 w.thanh_tien,
                                 w.id_phieu_nhap
                             }) //12,13
                              .Where(w => w.id_phieu_nhap == id_pn).ToList();
                    frm.dtgv_phieunhapct.DataSource = ct.ToList();


                //var bindinglist = new BindingList<dau_sach>(db.dau_sach.ToList().Select(w => new w.ma_dau_sach).ToList());
                //var source = new BindingSource(bindinglist, null);
                //dtgv_dau_sach.DataSource = source;
                frm.dtgv_phieunhapct.Columns[0].HeaderText = "id";
                frm.dtgv_phieunhapct.Columns[0].Visible = false;

                frm.dtgv_phieunhapct.Columns[1].HeaderText = "Mã phiếu nhập chi tiết";
                frm.dtgv_phieunhapct.Columns[1].Visible = true;

                frm.dtgv_phieunhapct.Columns[2].HeaderText = "Nhà xuất bản";
                frm.dtgv_phieunhapct.Columns[2].Visible = true;

                frm.dtgv_phieunhapct.Columns[3].HeaderText = "Tên đầu sách";
                frm.dtgv_phieunhapct.Columns[3].Visible = true;

                frm.dtgv_phieunhapct.Columns[4].HeaderText = "Giá nhập";
                frm.dtgv_phieunhapct.Columns[4].Visible = true;

                frm.dtgv_phieunhapct.Columns[5].HeaderText = "Số lượng nhập";
                frm.dtgv_phieunhapct.Columns[5].Visible = true;

                frm.dtgv_phieunhapct.Columns[6].HeaderText = "Thành tiền";
                frm.dtgv_phieunhapct.Columns[6].Visible = true;

                frm.dtgv_phieunhapct.Columns[7].HeaderText = "id phiếu nhập";
                frm.dtgv_phieunhapct.Columns[7].Visible = false;

                frm.lbl_xemct_phieunhap.Text += this.dtgrv_phieu_nhap.CurrentRow.Cells[1].Value.ToString();
                frm.lbl_ngaynhap.Text += this.dtgrv_phieu_nhap.CurrentRow.Cells[2].Value.ToString();
                frm.lbl_tongtien.Text += this.dtgrv_phieu_nhap.CurrentRow.Cells[3].Value.ToString();
                frm.lbl_nhanvien.Text += this.dtgrv_phieu_nhap.CurrentRow.Cells[4].Value.ToString();

                frm.Show();
            }

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
