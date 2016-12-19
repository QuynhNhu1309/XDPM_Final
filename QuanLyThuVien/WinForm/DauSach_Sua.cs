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
    public partial class DauSach_Sua : Form
    {

        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        public Models.dau_sach dau_sach_ins = new dau_sach();

        public DauSach_Sua(Int32 id_current)
        {
            dau_sach_ins.id = id_current;
            InitializeComponent();
        }
        public DauSach_Sua(Models.dau_sach ds)
        {
            InitializeComponent();
            //id_dau_sach_sua.Text = ds.id.ToString();

            this.dau_sach_ins = ds;
            ma_dau_sach_sua.Text = ds.ma_dau_sach.ToString();
            ten_dau_sach_sua.Text = ds.ten_dau_sach.ToString();
            loai_sach_sua.Text = ds.loai_sach.ten_loai.ToString();
            tom_tat_sua.Text = ds.tom_tat.ToString();
            nxb_sua.Text = ds.id_nxb.ToString();
            nam_xuat_ban_sua.Text = ds.nam_xuat_ban.ToString();
            tac_gia_sua.Text = ds.id_tac_gia.ToString();
            tinh_trang_sua.Text = ds.id_tinh_trang.ToString();

            //combobox
            var list_category = db.loai_sach.ToList().Select(i => new loai_sach(i)).ToList();
            loai_sach_sua.DataSource = list_category;
            loai_sach_sua.DisplayMember = "ten_loai";
            loai_sach_sua.ValueMember = "id";
            loai_sach_sua.SelectedValue = ds.loai_sach.id;

            //combobox
            var list_nxb = db.nha_xuat_ban.ToList().Select(i => new nha_xuat_ban(i)).ToList();
            nxb_sua.DataSource = list_nxb;
            nxb_sua.DisplayMember = "ten_nxb";
            nxb_sua.ValueMember = "id";
            nxb_sua.SelectedValue = ds.nha_xuat_ban.id;

            //combobox
            var list_tac_gia = db.tac_gia.ToList().Select(i => new tac_gia(i)).ToList();
            tac_gia_sua.DataSource = list_tac_gia;
            tac_gia_sua.DisplayMember = "ho_ten";
            tac_gia_sua.ValueMember = "id";
            tac_gia_sua.SelectedValue = ds.tac_gia.id;

            //combobox
            var list_tinh_trang = db.trang_thai.ToList().Select(i => new trang_thai(i)).ToList();
            tinh_trang_sua.DataSource = list_tinh_trang;
            tinh_trang_sua.DisplayMember = "ten_trang_thai";
            tinh_trang_sua.ValueMember = "id";
            tinh_trang_sua.SelectedValue = ds.trang_thai.id;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Sửa đầu sách

        private void btn_sua_dau_sach_Click(object sender, EventArgs e)
        {
            dau_sach obj = db.dau_sach.Find(dau_sach_ins.id);
            obj.ten_dau_sach = ten_dau_sach_sua.Text.Trim();
            obj.id_loai_sach = int.Parse(loai_sach_sua.SelectedValue.ToString());
            obj.tom_tat = tom_tat_sua.Text.Trim();
            obj.id_nxb = int.Parse(nxb_sua.SelectedValue.ToString());
            obj.nam_xuat_ban = int.Parse(nam_xuat_ban_sua.Text);
            obj.id_tac_gia = int.Parse(tac_gia_sua.SelectedValue.ToString());
            obj.id_tinh_trang = int.Parse(tinh_trang_sua.SelectedValue.ToString());

           // var list = context.Products.ToList().Select(i => new Product2(i)).ToList();
            //var bindingList = new BindingList<Product2>(list);
            //var source = new BindingSource(bindingList, null);
            //dtgv1.DataSource = source;

            db.SaveChanges();
            //var list = db.Products.ToList().Select(i => new Product2(i)).ToList();





            this.Visible = false;
            DauSach frm = new DauSach();
            frm.Refresh_Form(3);
            frm.Show();
            
            //frm.Refresh_dtgv(List<Product2> list);
            
           
        }

        private void btn_huy_sua_dau_sach_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          
        }
    }
}
