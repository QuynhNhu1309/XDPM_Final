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
using System.Threading;
using System.Globalization;

namespace WinForm
{
    public partial class Dau_Sach_Chi_Tiet : Form
    {
        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        private Models.dau_sach dau_sach_ins;

        public Dau_Sach_Chi_Tiet() 
        {
            InitializeComponent();       
        }
        public Dau_Sach_Chi_Tiet(Models.dau_sach ds)
        {
            InitializeComponent();

            this.dau_sach_ins = ds;
            ma_dau_sach_xem.Text = ds.ma_dau_sach.ToString();
            ten_dau_sach_xem.Text = ds.ten_dau_sach.ToString();
            loai_sach_xem.Text = ds.loai_sach.ten_loai.ToString();
            tom_tat_xem.Text = ds.tom_tat.ToString();
            nxb_xem.Text = ds.id_nxb.ToString();
            nam_xuat_ban_xem.Text = ds.nam_xuat_ban.ToString();
            tac_gia_xem.Text = ds.id_tac_gia.ToString();
            tinh_trang_xem.Text = ds.id_tinh_trang.ToString();

            //combobox
            var list_category = db.loai_sach.ToList().Select(i => new loai_sach(i)).ToList();
            loai_sach_xem.DataSource = list_category;
            loai_sach_xem.DisplayMember = "ten_loai";
            loai_sach_xem.ValueMember = "id";
            loai_sach_xem.SelectedValue = ds.loai_sach.id;

            //combobox
            var list_nxb = db.nha_xuat_ban.ToList().Select(i => new nha_xuat_ban(i)).ToList();
            nxb_xem.DataSource = list_nxb;
            nxb_xem.DisplayMember = "ten_nxb";
            nxb_xem.ValueMember = "id";
            nxb_xem.SelectedValue = ds.nha_xuat_ban.id;

            //combobox
            var list_tac_gia = db.tac_gia.ToList().Select(i => new tac_gia(i)).ToList();
            tac_gia_xem.DataSource = list_tac_gia;
            tac_gia_xem.DisplayMember = "ho_ten";
            tac_gia_xem.ValueMember = "id";
            tac_gia_xem.SelectedValue = ds.tac_gia.id;

            //combobox
            var list_tinh_trang = db.trang_thai.ToList().Select(i => new trang_thai(i)).ToList();
            tinh_trang_xem.DataSource = list_tinh_trang;
            tinh_trang_xem.DisplayMember = "ten_trang_thai";
            tinh_trang_xem.ValueMember = "id";
            tinh_trang_xem.SelectedValue = ds.trang_thai.id;
        }

        private void Dau_Sach_Chi_Tiet_Load(object sender, EventArgs e)
        {

        }

        private void btn_dong_xem_dau_sach_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
