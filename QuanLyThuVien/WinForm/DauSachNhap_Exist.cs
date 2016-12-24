using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Models;

namespace WinForm
{
    public partial class DauSachNhap_Exist : Form
    {
        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        public Models.dau_sach dau_sach = new dau_sach();
        public DauSachNhap_Exist()
        {
            InitializeComponent();
        }

        private void btn_them_dau_sach_Click(object sender, EventArgs e)
        {
            try
            {
                //Thêm đầu sách
                dau_sach.ten_dau_sach = ten_dau_sach_them.Text.Trim();
                dau_sach.id_loai_sach = int.Parse(loai_sach_them.SelectedValue.ToString());
                dau_sach.tom_tat = tom_tat_them.Text;
                dau_sach.id_nxb = int.Parse(nxb_them.SelectedValue.ToString());
                dau_sach.so_luong_cuon_sach = int.Parse(txt_soluong.Text);
                dau_sach.nam_xuat_ban = int.Parse(nam_xuat_ban_them.Text);
                dau_sach.id_tac_gia = int.Parse(tac_gia_them.SelectedValue.ToString());
                dau_sach.id_tinh_trang = 2;
                float thanh_tien = float.Parse(txt_thanhtien.Text);
                float so_luong = float.Parse(txt_soluong.Text);
                float gia_nhap = float.Parse(txt_gianhap.Text);
                if (so_luong == 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng nhập");
                }

                if (gia_nhap == 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại giá nhập");
                }

                if (so_luong > 0 && gia_nhap > 0)
                {
                    dau_sach.ma_dau_sach = db.Database.SqlQuery<string>(
                                "Get_MaDauSach").Single();

                    db.dau_sach.Add(dau_sach);
                    db.SaveChanges();
                    //MessageBox.Show(nxb_them.SelectedValue.ToString());

                    //// Thêm thông tin vào phiếu nhập và phiếu nhập chi tiết

                    //MessageBox.Show(gia_nhap.ToString());
                    //MessageBox.Show(thanh_tien.ToString());
                    //MessageBox.Show(so_luong.ToString());
                    object[] parameters = 
                {
                    new SqlParameter("@thanhtien", thanh_tien),
                    new SqlParameter("@id_nha_xuat_ban", int.Parse(nxb_them.SelectedValue.ToString())),
                    new SqlParameter("@gia_nhap", gia_nhap),
                    new SqlParameter("@so_luong_nhap", so_luong)
               
                  };
                    db.Database.ExecuteSqlCommand("Them_PhieuNhap_Exist @thanhtien, @id_nha_xuat_ban, @gia_nhap, @so_luong_nhap", parameters);

                    //MessageBox.Show("Thêm thành công");

                    DialogResult dialogResult = MessageBox.Show("Nhập sách thành công!. Bạn có muốn nhập nữa không?", "THÔNG BÁO THÀNH CÔNG", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        this.Hide();
                        DauSachNhap_Exist frm1 = new DauSachNhap_Exist();
                        frm1.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        this.Hide();
                        DauSach frm = new DauSach();
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {



                MessageBox.Show("Thêm đầu sách không thành công. Vui lòng kiểm tra lại thông tin");
            }
        }

        private void DauSachNhap_Exist_Load(object sender, EventArgs e)
        {
            float soluong;
            float gianhap;
            bool isNumeric = float.TryParse(txt_gianhap.Text, out gianhap);
            bool isNumeric_soluong = float.TryParse(txt_soluong.Text, out soluong);
            if (isNumeric && isNumeric_soluong)
            {
                soluong = float.Parse(txt_soluong.Text);
                gianhap = float.Parse(txt_gianhap.Text);
                float rs = soluong * gianhap;
                txt_thanhtien.Text = rs.ToString();
            }

            //combobox
            var list_category = db.loai_sach.ToList().Select(i => new loai_sach(i)).ToList();
            loai_sach_them.DataSource = list_category;
            loai_sach_them.DisplayMember = "ten_loai";
            loai_sach_them.ValueMember = "id";

            //combobox
            var list_nxb = db.nha_xuat_ban.ToList().Select(i => new nha_xuat_ban(i)).ToList();
            nxb_them.DataSource = list_nxb;
            nxb_them.DisplayMember = "ten_nxb";
            nxb_them.ValueMember = "id";
            //nxb_sua.SelectedValue = ds.nha_xuat_ban.id;

            //combobox
            var list_tac_gia = db.tac_gia.ToList().Select(i => new tac_gia(i)).ToList();
            tac_gia_them.DataSource = list_tac_gia;
            tac_gia_them.DisplayMember = "ho_ten";
            tac_gia_them.ValueMember = "id";
        }
    }
}
