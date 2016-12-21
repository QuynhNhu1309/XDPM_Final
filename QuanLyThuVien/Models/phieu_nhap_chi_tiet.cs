using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class phieu_nhap_chi_tiet
    {
        public phieu_nhap_chi_tiet()
        {

        }

        public phieu_nhap_chi_tiet(phieu_nhap_chi_tiet obj)
        {
            id = obj.id;
            ma_phieu_nhap_chi_tiet = obj.ma_phieu_nhap_chi_tiet;
            id_nha_xuat_ban = obj.id_nha_xuat_ban;
            id_dau_sach = obj.id_dau_sach;
            gia_nhap = obj.gia_nhap;
            so_luong_nhap = obj.so_luong_nhap;
            thanh_tien = obj.thanh_tien;
            id_phieu_nhap = obj.id_phieu_nhap;
            phieu_nhap = obj.phieu_nhap;
            dau_sach = obj.dau_sach;
            nha_xuat_ban = obj.nha_xuat_ban;


        }

        public int id { get; set; }

        public string ma_phieu_nhap_chi_tiet { get; set; }

        public int id_nha_xuat_ban { get; set; }

        public int id_dau_sach { get; set; }

        public float gia_nhap { get; set; }

        public int so_luong_nhap { get; set; }

        public float thanh_tien { get; set; }

        public int id_phieu_nhap { get; set; }

        [ForeignKey("id_phieu_nhap")]
        public virtual phieu_nhap phieu_nhap { get; set; }

        [ForeignKey("id_dau_sach")]
        public virtual dau_sach dau_sach { get; set; }

        [ForeignKey("id_nha_xuat_ban")]
        public virtual nha_xuat_ban nha_xuat_ban { get; set; }
    }
}
