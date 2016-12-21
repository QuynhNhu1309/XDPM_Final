using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class phieu_muon_chi_tiet
    {
        public phieu_muon_chi_tiet()
        {
            
        }

        public phieu_muon_chi_tiet(phieu_muon_chi_tiet obj)
        {
            id = obj.id;
            ma_phieu_muon_chi_tiet = obj.ma_phieu_muon_chi_tiet;
            id_phieu_muon = obj.id_phieu_muon;
            id_cuon_sach = obj.id_cuon_sach;
            id_dau_sach = obj.id_dau_sach;
            //ngay_tra = obj.ngay_tra;
            id_tinh_trang = obj.id_tinh_trang;
            so_luong = obj.so_luong;
            cuon_sach = obj.cuon_sach;
            dau_sach = obj.dau_sach;
            phieu_muon = obj.phieu_muon;
            trang_thai = obj.trang_thai;
            
        }
        public int id { get; set; }

        public string ma_phieu_muon_chi_tiet { get; set; }

        public int id_phieu_muon { get; set; }

        public int id_dau_sach { get; set; }

        public int id_cuon_sach { get; set; }

        public int id_tinh_trang { get; set; }

        public int so_luong { get; set; }

        [ForeignKey("id_cuon_sach")]
        public virtual cuon_sach cuon_sach { get; set; }

        [ForeignKey("id_dau_sach")]
        public virtual dau_sach dau_sach { get; set; }

        [ForeignKey("id_phieu_muon")]
        public virtual phieu_muon phieu_muon { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }
    }
}
