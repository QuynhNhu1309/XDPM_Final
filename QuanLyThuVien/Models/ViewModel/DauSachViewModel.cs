using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.ViewModel
{
    public class DauSachViewModel
    {
        public DauSachViewModel() { }

        public DauSachViewModel(dau_sach obj)
        {
            id = obj.id;
            ma_dau_sach = obj.ma_dau_sach;
            ten_dau_sach = obj.ten_dau_sach;
            id_loai_sach = obj.id_loai_sach;
            tom_tat = obj.tom_tat;
            id_nxb = obj.id_nxb;
            so_luong_cuon_sach = obj.so_luong_cuon_sach;
            nam_xuat_ban = obj.nam_xuat_ban;
            id_tac_gia = obj.id_tac_gia;
            id_tinh_trang = obj.id_tinh_trang;
            ten_loai_sach = obj.loai_sach.ten_loai;
            ten_nha_xuat_ban = obj.nha_xuat_ban.ten_nxb;
            ten_tac_gia = obj.tac_gia.ho_ten;
            trang_thai = obj.trang_thai;
        }
        public int id { get; set; }

        public string ma_dau_sach { get; set; }

       
        public string ten_dau_sach { get; set; }

        public int id_loai_sach { get; set; }


        public string tom_tat { get; set; }

        public int id_nxb { get; set; }

        public int so_luong_cuon_sach { get; set; }

        public int nam_xuat_ban { get; set; }

        public int id_tac_gia { get; set; }

        public int id_tinh_trang { get; set; }

        public virtual ICollection<cuon_sach> cuon_sach { get; set; }

       
        public virtual loai_sach loai_sach { get; set; }

        public string ten_loai_sach { get; set; }

       
        public virtual nha_xuat_ban nha_xuat_ban { get; set; }

        public string ten_nha_xuat_ban { get; set; }
      
        public virtual tac_gia tac_gia { get; set; }

        public string ten_tac_gia { get; set; }
      
        public virtual trang_thai trang_thai { get; set; }
    }
}
