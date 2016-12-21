using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class phieu_nhap
    {
        public phieu_nhap()
        {

        }

        public phieu_nhap(phieu_nhap obj)
        {
            id = obj.id;
            ma_phieu_nhap = obj.ma_phieu_nhap;
            ngay_nhap = obj.ngay_nhap;
            tongtien = obj.tongtien;
            id_tinh_trang = obj.id_tinh_trang;
            id_nhan_vien = obj.id_nhan_vien;
            trang_thai = obj.trang_thai;
            nhan_vien = obj.nhan_vien;


        }

        public int id { get; set; }

        public string ma_phieu_nhap { get; set; }

        public DateTime ngay_nhap { get; set; }

        public float tongtien { get; set; }

        public int id_tinh_trang { get; set; }

        public int id_nhan_vien { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }

        [ForeignKey("id_nhan_vien")]
        public virtual nhan_vien nhan_vien { get; set; }

        public virtual ICollection<phieu_nhap_chi_tiet> phieu_nhap_chi_tiet { get; set; }

    }
}
