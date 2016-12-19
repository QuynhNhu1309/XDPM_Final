using Models;
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
    public partial class DauSach_Them_SL_CuonSach : Form
    {
        private QuanLyThuVienDB db = new QuanLyThuVienDB();
        public Models.dau_sach dau_sach_ins = new dau_sach();
        public DauSach_Them_SL_CuonSach(Int32 id_current)
        {
            dau_sach_ins.id = id_current;
            InitializeComponent();
        }

        private void btn_them_sl_cuon_sach_Click(object sender, EventArgs e)
        {
            Int32 so_luong_cuon_sach_can_them = Int32.Parse(txt_them_dau_sach.Text);
            for (int i = 0; i < so_luong_cuon_sach_can_them; i++)
            {
                string u = (from w in db.cuon_sach orderby w.id descending select w.id).First().ToString();
                string ma_cuon_sach;
                int stt = Int32.Parse(u);
                stt = stt + 1;
                if (stt < 10)
                {
                    ma_cuon_sach = "CS000" + stt.ToString();
                   
                    var cuon_sach_ins = db.Set<cuon_sach>();
                    cuon_sach_ins.Add(new cuon_sach { ma_cuon_sach = ma_cuon_sach.Trim(), id_dau_sach = dau_sach_ins.id, id_tinh_trang = 6 });

                    db.SaveChanges();

                }
                if (stt < 100 && stt >= 10)
                {
                    ma_cuon_sach = "CS0" + stt.ToString();
                    var cuon_sach_ins = db.Set<cuon_sach>();
                    cuon_sach_ins.Add(new cuon_sach { ma_cuon_sach = ma_cuon_sach.Trim(), id_dau_sach = dau_sach_ins.id, id_tinh_trang = 6 });

                    db.SaveChanges();
                }
                
            }
        }
    }
}
