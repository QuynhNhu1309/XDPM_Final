using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class phieu_tra_chi_tiet
    {
        public phieu_tra_chi_tiet(){    }
        public phieu_tra_chi_tiet(phieu_tra_chi_tiet obj)
        {
            id = obj.id;
            ma_phieu_tra_chi_tiet = obj.ma_phieu_tra_chi_tiet;
            id_phieu_tra = obj.id_phieu_tra;
            id_cuon_sach = obj.id_cuon_sach;
            so_luong = obj.so_luong;
            so_ngay_qua_han = obj.so_ngay_qua_han;
            id_tinh_trang = obj.id_tinh_trang;
            tien_phat = obj.id_tinh_trang;
            cuon_sach = obj.cuon_sach;
            phieu_tra = obj.phieu_tra;
            trang_thai = obj.trang_thai;
            
        }
        public int id { get; set; }

        public string ma_phieu_tra_chi_tiet { get; set; }

        public int id_phieu_tra { get; set; }

        public int id_cuon_sach { get; set; }

        public int so_luong { get; set; }

        public int so_ngay_qua_han { get; set; }

        public int id_tinh_trang { get; set; }

        public int tien_phat { get; set; }

        [ForeignKey("id_cuon_sach")]
        public virtual cuon_sach cuon_sach { get; set; }

        [ForeignKey("id_phieu_tra")]
        public virtual phieu_tra phieu_tra { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }
    }
}
