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
    public partial class DocGia : Form
    {
        QuanLyThuVienDB db = new QuanLyThuVienDB();
        doc_gia doc_gia = new doc_gia();
        public int current_page_Index = 0;
        public int number_page = 1;
        public int total_dau_sach = 1;
        public int number_record = 2;
        public DocGia()
        {
            InitializeComponent();
        }

        public void Refresh_Form(Int32 number_record, Int32 current_page_Index)
        {

            total_dau_sach = db.doc_gia.Count();
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

                var q = (from w in db.doc_gia.AsEnumerable()
                         select new
                         {
                             w.id,
                             w.ma_doc_gia,
                             w.ho_ten, //0,1,2
                             w.dia_chi,
                             w.dien_thoai,//3,4
                             w.ngay_cap_the,//5,6,7
                             w.ngay_het_han,
                             w.nam_tot_nghiep,
                             w.so_sach_muon_toi_da,//8,9,10
                             w.thoi_gian_muon_toi_da,
                             w.cmnd,
                             w.nghe_nghiep,//11,12
                             w.trang_thai.ten_trang_thai,
                             w.ma_the_thu_vien,//13

                         }) 
                           .Skip(current_page_Index * number_record).Take(number_record).ToList();
                dtgv_docgia.DataSource = q.ToList();
           

            //var bindinglist = new BindingList<dau_sach>(db.dau_sach.ToList().Select(w => new w.ma_dau_sach).ToList());
            //var source = new BindingSource(bindinglist, null);
            //dtgv_dau_sach.DataSource = source;
            dtgv_docgia.Columns[0].HeaderText = "id";
            dtgv_docgia.Columns[0].Visible = false;

            dtgv_docgia.Columns[1].HeaderText = "Mã độc giả";
            dtgv_docgia.Columns[1].Visible = true;

            dtgv_docgia.Columns[2].HeaderText = "Họ tên";
            dtgv_docgia.Columns[2].Visible = true;

            dtgv_docgia.Columns[3].HeaderText = "Địa chỉ";
            dtgv_docgia.Columns[3].Visible = false;

            dtgv_docgia.Columns[4].HeaderText = "Điện thoại";
            dtgv_docgia.Columns[4].Visible = false;

            dtgv_docgia.Columns[5].HeaderText = "Ngày cấp thẻ";
            dtgv_docgia.Columns[5].Visible = true;

            dtgv_docgia.Columns[6].HeaderText = "Ngày hết hạn";
            dtgv_docgia.Columns[6].Visible = true;

            dtgv_docgia.Columns[7].HeaderText = "Năm tốt nghiệp";
            dtgv_docgia.Columns[7].Visible = false;

            dtgv_docgia.Columns[8].HeaderText = "Số sách mượn tối đa";
            dtgv_docgia.Columns[8].Visible = false;

            dtgv_docgia.Columns[9].HeaderText = "Thời gian mượn tối đa";
            dtgv_docgia.Columns[9].Visible = false;

            dtgv_docgia.Columns[10].HeaderText = "Chứng minh nhân dân";
            dtgv_docgia.Columns[10].Visible = false;

            dtgv_docgia.Columns[11].HeaderText = "Nghề nghiệp";
            dtgv_docgia.Columns[11].Visible = false;

            dtgv_docgia.Columns[12].HeaderText = "Trạng thái";
            dtgv_docgia.Columns[12].Visible = true;

            dtgv_docgia.Columns[13].HeaderText = "Mã thẻ thư viện";
            dtgv_docgia.Columns[13].Visible = true;


        }

        private void btn_next_end_Click(object sender, EventArgs e)
        {
            current_page_Index = number_page;
            Refresh_Form(number_record, current_page_Index);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current_page_Index < number_page)
            {
                current_page_Index = current_page_Index + 1;
                Refresh_Form(number_record, current_page_Index);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (current_page_Index <= number_page)
            {
                current_page_Index = current_page_Index - 1;
                Refresh_Form(number_record, current_page_Index);
            }
        }

        private void btn_back_e_Click(object sender, EventArgs e)
        {
            current_page_Index = 0;
            Refresh_Form(number_record, current_page_Index);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            number_record = int.Parse(selectedItem.ToString());
            Refresh_Form(number_record, current_page_Index);
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            Refresh_Form(number_record, current_page_Index);
        }


        // Xem chi tiết thông tin độc giả
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                    dtgv_docgia.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {

                DocGiaChiTiet frm = new DocGiaChiTiet();


                frm.txt_xem_ma_docgia.Text = this.dtgv_docgia.CurrentRow.Cells[1].Value.ToString();

                frm.docgia_hoten_xem.Text = this.dtgv_docgia.CurrentRow.Cells[2].Value.ToString();

                frm.docgia_diachi_xem.Text = this.dtgv_docgia.CurrentRow.Cells[3].Value.ToString();

                frm.docgia_dienthoai_xem.Text = this.dtgv_docgia.CurrentRow.Cells[4].Value.ToString();

                frm.docgia_namtotnghiep_xem.Text = this.dtgv_docgia.CurrentRow.Cells[7].Value.ToString();

                frm.docgia_sosach_toida_xem.Text = this.dtgv_docgia.CurrentRow.Cells[8].Value.ToString();

                frm.docgia_ngaycapthe_xem.Text = this.dtgv_docgia.CurrentRow.Cells[5].Value.ToString();

                frm.docgia_ngayhethan_xem.Text = this.dtgv_docgia.CurrentRow.Cells[6].Value.ToString();

                frm.docgia_thoigian_muon_toida_xem.Text = this.dtgv_docgia.CurrentRow.Cells[9].Value.ToString();

                frm.docgia_cmnd_xem.Text = this.dtgv_docgia.CurrentRow.Cells[10].Value.ToString();

                frm.docgia_mathe_xem.Text = this.dtgv_docgia.CurrentRow.Cells[13].Value.ToString();

                frm.docgia_nghenghiep_xem.Text = this.dtgv_docgia.CurrentRow.Cells[11].Value.ToString();

                frm.docgia_tinhtrang_xem.Text = this.dtgv_docgia.CurrentRow.Cells[12].Value.ToString();

                frm.Show();
            }
        }
    }
}
