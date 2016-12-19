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
       
        public DauSach()
        {
            InitializeComponent();

            
        }

        public void Refresh_Form(Int32 number_record)
        {
            //var bindinglist = new BindingList<DauSachViewModel>(db.dau_sach.ToList().Select(i => new DauSachViewModel(i)).Take///(4).ToList());


            //var query =  from p in db.dau_sach 
            //            select new { p.ma_dau_sach, p.ten_dau_sach, p.id_loai_sach };
            var q = (from w in db.dau_sach
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
                                  .Take(number_record).ToList();
            dtgv_dau_sach.DataSource = q.ToList();
            //var bindinglist = new BindingList<dau_sach>(db.dau_sach.ToList().Select(w => new w.ma_dau_sach).ToList());
            //var source = new BindingSource(bindinglist, null);
            //dtgv_dau_sach.DataSource = source;
            dtgv_dau_sach.Columns[0].HeaderText = "Mã đầu sách";
            dtgv_dau_sach.Columns[0].Visible = false;

            dtgv_dau_sach.Columns[1].HeaderText = "Mã đầu sách";
            dtgv_dau_sach.Columns[1].Visible = true;

            dtgv_dau_sach.Columns[2].HeaderText = "Tên đầu sách";
            dtgv_dau_sach.Columns[2].Visible = true;

            dtgv_dau_sach.Columns[3].HeaderText = "ID loại sách";
            dtgv_dau_sach.Columns[3].Visible = false;

            dtgv_dau_sach.Columns[4].HeaderText = "Tên loại sách";
            dtgv_dau_sach.Columns[4].Visible = true;

            dtgv_dau_sach.Columns[5].HeaderText = "Tóm tắt";
            dtgv_dau_sach.Columns[5].Visible = false;

            dtgv_dau_sach.Columns[6].HeaderText = "ID nhà xuất bản";
            dtgv_dau_sach.Columns[6].Visible = false;

            dtgv_dau_sach.Columns[7].HeaderText = "Nhà xuất bản";
            dtgv_dau_sach.Columns[7].Visible = true;

            dtgv_dau_sach.Columns[8].HeaderText = "Số lượng cuốn sách";
            dtgv_dau_sach.Columns[8].Visible = true;

            dtgv_dau_sach.Columns[9].HeaderText = "Năm xuất bản";
            dtgv_dau_sach.Columns[9].Visible = true;

            dtgv_dau_sach.Columns[10].HeaderText = "ID tác giả";
            dtgv_dau_sach.Columns[10].Visible = false;

            dtgv_dau_sach.Columns[11].HeaderText = "Tác giả";
            dtgv_dau_sach.Columns[11].Visible = true;

            dtgv_dau_sach.Columns[12].HeaderText = "ID tình trạng";
            dtgv_dau_sach.Columns[12].Visible = false;

            dtgv_dau_sach.Columns[13].HeaderText = "Tình trạng";
            dtgv_dau_sach.Columns[13].Visible = true;
            //datagvDauSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DauSach_Load(object sender, EventArgs e)
        {

            Refresh_Form(3);
           

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
                 Refresh_Form(3);
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
                DauSach_Sua frm = new DauSach_Sua(id);

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
            int var = int.Parse(selectedItem.ToString());
            Refresh_Form(var);
            //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n");
            //var q = (from w in db.dau_sach
            //         select new { w.ma_dau_sach, w.ten_dau_sach, w.loai_sach.ten_loai, w.trang_thai.ten_trang_thai }).Take(var);
            //dtgv_dau_sach.DataSource = q.ToList();

        }


        //Thêm số lượng cuốn sách
        private void btn_them_cuon_sach_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount =
                    dtgv_dau_sach.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                Int32 id_current = int.Parse(this.dtgv_dau_sach.CurrentRow.Cells[0].Value.ToString());
                DauSach_Them_SL_CuonSach frm = new DauSach_Them_SL_CuonSach(id_current);
                frm.Show();
            }  
        }
    }
}
