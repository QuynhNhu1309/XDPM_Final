using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.ViewModel;
using System.Data.SqlClient;

namespace WinForm
{
    public partial class DauSach : Form
    {
        QuanLyThuVienDB db = new QuanLyThuVienDB();
        dau_sach dau_sach = new dau_sach();
        DauSachViewModel ds_view = new DauSachViewModel();
        public int current_page_Index = 0;
        public int number_page = 1;
        public int total_dau_sach = 1;
        public int number_record = 10;
       
        public DauSach()
        {
            InitializeComponent();

            
        }

        public void Refresh_Form(Int32 number_record, Int32 current_page_Index)
        {

            total_dau_sach = db.dau_sach.Count();
            number_page = total_dau_sach / number_record;
            if(total_dau_sach % number_record > 0)
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
                var q = (from w in db.dau_sach.AsEnumerable()
                         select new
                         {
                             w.id,
                             w.ma_dau_sach,
                             w.ten_dau_sach, //0,1,2
                             w.id_loai_sach,
                             w.loai_sach.ten_loai,//3,4
                             w.tom_tat,
                             w.id_nxb,
                             w.nha_xuat_ban.ten_nxb, //5,6,7
                             w.so_luong_cuon_sach,
                             w.nam_xuat_ban, //8,9
                             w.id_tac_gia,
                             w.tac_gia.ho_ten, //10,11
                             w.id_tinh_trang,
                             w.trang_thai.ten_trang_thai
                         }) //12,13
                           .Skip(current_page_Index * number_record).Take(number_record).ToList();
                dtgv_dau_sach.DataSource = q.ToList();
            }
            else if (current_page_Index > 0)
            {
                    var q = (from w in db.dau_sach.AsEnumerable()
                             select new
                             {
                                 w.id,
                                 w.ma_dau_sach,
                                 w.ten_dau_sach, //0,1,2
                                 w.id_loai_sach,
                                 w.loai_sach.ten_loai,//3,4
                                 w.tom_tat,
                                 w.id_nxb,
                                 w.nha_xuat_ban.ten_nxb, //5,6,7
                                 w.so_luong_cuon_sach,
                                 w.nam_xuat_ban, //8,9
                                 w.id_tac_gia,
                                 w.tac_gia.ho_ten, //10,11
                                 w.id_tinh_trang,
                                 w.trang_thai.ten_trang_thai
                             }) //12,13
                               .Skip(current_page_Index * number_record).Take(number_record).ToList();
                    dtgv_dau_sach.DataSource = q.ToList();
            }
            
            //var bindinglist = new BindingList<dau_sach>(db.dau_sach.ToList().Select(w => new w.ma_dau_sach).ToList());
            //var source = new BindingSource(bindinglist, null);
            //dtgv_dau_sach.DataSource = source;
            dtgv_dau_sach.Columns[0].HeaderText = "STT";
            dtgv_dau_sach.Columns[0].Visible = true;
            dtgv_dau_sach.Columns[0].Width = 40;

            dtgv_dau_sach.Columns[1].HeaderText = "Mã đầu sách";
            dtgv_dau_sach.Columns[1].Visible = true;
            dtgv_dau_sach.Columns[1].Width = 100;

            dtgv_dau_sach.Columns[2].HeaderText = "Tên đầu sách";
            dtgv_dau_sach.Columns[2].Visible = true;
            dtgv_dau_sach.Columns[2].Width = 140;

            dtgv_dau_sach.Columns[3].HeaderText = "ID loại sách";
            dtgv_dau_sach.Columns[3].Visible = false;

            dtgv_dau_sach.Columns[4].HeaderText = "Tên loại sách";
            dtgv_dau_sach.Columns[4].Visible = true;
            dtgv_dau_sach.Columns[4].Width = 120;

            dtgv_dau_sach.Columns[5].HeaderText = "Tóm tắt";
            dtgv_dau_sach.Columns[5].Visible = false;

            dtgv_dau_sach.Columns[6].HeaderText = "ID nhà xuất bản";
            dtgv_dau_sach.Columns[6].Visible = false;

            dtgv_dau_sach.Columns[7].HeaderText = "Nhà xuất bản";
            dtgv_dau_sach.Columns[7].Visible = true;
            dtgv_dau_sach.Columns[7].Width = 120;

            dtgv_dau_sach.Columns[8].HeaderText = "Số lượng cuốn sách";
            dtgv_dau_sach.Columns[8].Visible = true;
            dtgv_dau_sach.Columns[8].Width = 150;

            dtgv_dau_sach.Columns[9].HeaderText = "Năm xuất bản";
            dtgv_dau_sach.Columns[9].Visible = true;
            dtgv_dau_sach.Columns[9].Width = 120;

            dtgv_dau_sach.Columns[10].HeaderText = "ID tác giả";
            dtgv_dau_sach.Columns[10].Visible = false;


            dtgv_dau_sach.Columns[11].HeaderText = "Tác giả";
            dtgv_dau_sach.Columns[11].Visible = true;
            dtgv_dau_sach.Columns[11].Width = 140;

            dtgv_dau_sach.Columns[12].HeaderText = "ID tình trạng";
            dtgv_dau_sach.Columns[12].Visible = false;

            dtgv_dau_sach.Columns[13].HeaderText = "Tình trạng";
            dtgv_dau_sach.Columns[13].Visible = true;
            dtgv_dau_sach.Columns[13].Width = 110;
            //datagvDauSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DauSach_Load(object sender, EventArgs e)
        {

            Refresh_Form(number_record, current_page_Index);
           
           

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
             Int32 selectedRowCount = dtgv_dau_sach.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount > 0)
             {
                 for (int i = 0; i < selectedRowCount; i++)
                 {
                     //sb.Append("Row: ");
                     //sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                     //sb.Append(Environment.NewLine);

                     var index_row = dtgv_dau_sach.SelectedRows[i].Index;
                     int pro_id = Convert.ToInt32(dtgv_dau_sach.Rows[index_row].Cells[0].Value);

                     db.dau_sach.RemoveRange(db.dau_sach.Where(o => o.id == pro_id));

                 }

                 db.SaveChanges();
                 this.Visible = false;
                 MessageBox.Show("Xóa thành công");
                 Refresh_Form(10, current_page_Index);
                 DauSach frm = new DauSach();
                 frm.Show();
                 
                 //reload

                 //var list = db.dau_sach.ToList().Select(i => new DauSachViewModel(i)).ToList();
                // var bindingList = new BindingList<DauSachViewModel>(list);
                 //var source = new BindingSource(bindingList, null);
                // dtgv_dau_sach.DataSource = source;
             }
        }


        //Sửa đầu sách
        private void btn_sua_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dtgv_dau_sach.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {

                //Lấy id chuyển qua form sửa
                Int32 id = int.Parse(this.dtgv_dau_sach.CurrentRow.Cells[0].Value.ToString());
                DauSach_Sua frm = new DauSach_Sua(id, current_page_Index);

                frm.ma_dau_sach_sua.Text = this.dtgv_dau_sach.CurrentRow.Cells[1].Value.ToString();
                frm.ten_dau_sach_sua.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //frm.loai_sach_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                frm.tom_tat_sua.Text = this.dtgv_dau_sach.CurrentRow.Cells[5].Value.ToString();
                //frm.nxb_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                frm.nam_xuat_ban_sua.Text = this.dtgv_dau_sach.CurrentRow.Cells[9].Value.ToString();
                //frm.tac_gia_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //frm.tinh_trang_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //combobox
                var list_category = db.loai_sach.ToList().Select(i => new loai_sach(i)).ToList();
                frm.loai_sach_sua.DataSource = list_category;
                frm.loai_sach_sua.DisplayMember = "ten_loai";
                frm.loai_sach_sua.ValueMember = "id";
                frm.loai_sach_sua.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[3].Value;

                //combobox
                var list_nxb = db.nha_xuat_ban.ToList().Select(i => new nha_xuat_ban(i)).ToList();
                frm.nxb_sua.DataSource = list_nxb;
                frm.nxb_sua.DisplayMember = "ten_nxb";
                frm.nxb_sua.ValueMember = "id";
                frm.nxb_sua.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[6].Value;

                //combobox
                var list_tac_gia = db.tac_gia.ToList().Select(i => new tac_gia(i)).ToList();
                frm.tac_gia_sua.DataSource = list_tac_gia;
                frm.tac_gia_sua.DisplayMember = "ho_ten";
                frm.tac_gia_sua.ValueMember = "id";
                frm.tac_gia_sua.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[10].Value;

                //combobox

                var list_tinh_trang = db.trang_thai.ToList().Where(i => i.ten_bang == "dau_sach").ToList();
                frm.tinh_trang_sua.DataSource = list_tinh_trang;
                frm.tinh_trang_sua.DisplayMember = "ten_trang_thai";
                frm.tinh_trang_sua.ValueMember = "id";
                frm.tinh_trang_sua.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[12].Value;

                //MessageBox.Show(this.dtgv_dau_sach.CurrentRow.Cells[0].Value.ToString());
                this.Visible = false;
                frm.Show();
                
                
            }
        }


        //Xem chi tiết đầu sách
        private void btn_xem_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                    dtgv_dau_sach.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
              
                Dau_Sach_Chi_Tiet frm = new Dau_Sach_Chi_Tiet();


                frm.ma_dau_sach_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[1].Value.ToString();
                frm.ten_dau_sach_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //frm.loai_sach_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                frm.tom_tat_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[5].Value.ToString();
                //frm.nxb_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                frm.nam_xuat_ban_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[9].Value.ToString();
                //frm.tac_gia_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //frm.tinh_trang_xem.Text = this.dtgv_dau_sach.CurrentRow.Cells[2].Value.ToString();
                //combobox
                var list_category = db.loai_sach.ToList().Select(i => new loai_sach(i)).ToList();
                frm.loai_sach_xem.DataSource = list_category;
                frm.loai_sach_xem.DisplayMember = "ten_loai";
                frm.loai_sach_xem.ValueMember = "id";
                frm.loai_sach_xem.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[3].Value;

                //combobox
                var list_nxb = db.nha_xuat_ban.ToList().Select(i => new nha_xuat_ban(i)).ToList();
                frm.nxb_xem.DataSource = list_nxb;
                frm.nxb_xem.DisplayMember = "ten_nxb";
                frm.nxb_xem.ValueMember = "id";
                frm.nxb_xem.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[6].Value;

                //combobox
                var list_tac_gia = db.tac_gia.ToList().Select(i => new tac_gia(i)).ToList();
                frm.tac_gia_xem.DataSource = list_tac_gia;
                frm.tac_gia_xem.DisplayMember = "ho_ten";
                frm.tac_gia_xem.ValueMember = "id";
                frm.tac_gia_xem.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[10].Value;

                //combobox
                
                var list_tinh_trang = db.trang_thai.ToList().Where(i => i.ten_bang=="dau_sach").ToList();
                frm.tinh_trang_xem.DataSource = list_tinh_trang;
                frm.tinh_trang_xem.DisplayMember = "ten_trang_thai";
                frm.tinh_trang_xem.ValueMember = "id";
                frm.tinh_trang_xem.SelectedValue = this.dtgv_dau_sach.CurrentRow.Cells[12].Value;

                //MessageBox.Show(this.dtgv_dau_sach.CurrentRow.Cells[0].Value.ToString());
               // this.Visible = false;
                frm.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        //Chọn số dòng cần hiển thị
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            number_record = int.Parse(selectedItem.ToString());
            Refresh_Form(number_record, current_page_Index);
            //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n");
            //var q = (from w in db.dau_sach
            //         select new { w.ma_dau_sach, w.ten_dau_sach, w.loai_sach.ten_loai, w.trang_thai.ten_trang_thai }).Take(var);
            //dtgv_dau_sach.DataSource = q.ToList();

        }


        //Thêm số lượng cuốn sách
        private void btn_them_cuon_sach_Click(object sender, EventArgs e)
        {
            this.Hide();
            DauSachNhap frm = new DauSachNhap();
            frm.Show();
            //Int32 selectedRowCount =
            //        dtgv_dau_sach.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //if (selectedRowCount == 1)
            //{
            //    Int32 id_current = int.Parse(this.dtgv_dau_sach.CurrentRow.Cells[0].Value.ToString());
            //    DauSach_Them_SL_CuonSach frm = new DauSach_Them_SL_CuonSach(id_current);
            //    frm.Show();
            //}  
        }


        //Quay về trang trước
        private void button2_Click(object sender, EventArgs e)
        {
            if (current_page_Index <= number_page)
            {
                current_page_Index = current_page_Index - 1;
                Refresh_Form(number_record, current_page_Index);
            }
        }


        //Xem trang kế tiếp
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current_page_Index < number_page)
            {
                current_page_Index = current_page_Index + 1;
                Refresh_Form(number_record, current_page_Index);
            }

           


            //    total_dau_sach = db.dau_sach.Count();
            //number_page = total_dau_sach / number_record;

        }


        //Xem trang cuối cùng
        private void btn_next_end_Click(object sender, EventArgs e)
        {
                current_page_Index = number_page;
                Refresh_Form(number_record, current_page_Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Xem trang đầu tiên
        private void btn_back_e_Click(object sender, EventArgs e)
        {
                current_page_Index = 0;
                Refresh_Form(number_record, current_page_Index);
            
        }


        //Đóng form quản lý sách
        private void btn_dausach_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
