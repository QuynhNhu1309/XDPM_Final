using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class nhan_vien
    {
        
        public nhan_vien()
        {
            
        }
        public nhan_vien(nhan_vien obj)
        {
            id = obj.id;
            ma_nhan_vien = obj.ma_nhan_vien;
            ho_ten = obj.ho_ten;
            dia_chi = obj.dia_chi;
            dien_thoai = obj.dien_thoai;
            cmnd = obj.cmnd;
            chuc_vu = obj.chuc_vu;
            id_tinh_trang = obj.id_tinh_trang;
            trang_thai = obj.trang_thai;
            
        }


        public int id { get; set; }

        [StringLength(100)]
        public string ma_nhan_vien { get; set; }

        [Required]
        [StringLength(250)]
        public string ho_ten { get; set; }

        [Required]
        [StringLength(200)]
        public string dia_chi { get; set; }

        [Required]
        [StringLength(50)]
        public string dien_thoai { get; set; }

        public string cmnd { get; set; }

        public string chuc_vu { get; set; }

        public int id_tinh_trang { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }

        public virtual ICollection<phieu_muon> phieu_muon { get; set; }

        public virtual ICollection<phieu_tra> phieu_tra { get; set; }

        public virtual ICollection<phieu_nhap> phieu_nhap { get; set; }
    }
}
