using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class trang_thai
    {
       
        public trang_thai()  {     }

        public trang_thai(trang_thai obj)
        {
            id = obj.id;
            ten_trang_thai = obj.ten_trang_thai;
            ten_bang = obj.ten_bang;
            
        }

        [Key]
        public int id { get; set; }

        public string ten_trang_thai { get; set; }

        public string ten_bang { get; set; }

        
        public virtual ICollection<cuon_sach> cuon_sach { get; set; }

        public virtual ICollection<dau_sach> dau_sach { get; set; }

        public virtual ICollection<doc_gia> doc_gia { get; set; }

        public virtual ICollection<nhan_vien> nhan_vien { get; set; }

        public virtual ICollection<phieu_muon> phieu_muon { get; set; }

        public virtual ICollection<phieu_muon_chi_tiet> phieu_muon_chi_tiet { get; set; }

        public virtual ICollection<phieu_tra_chi_tiet> phieu_tra_chi_tiet { get; set; }

       // public virtual ICollection<phieu_nhap> phieu_nhap { get; set; }
    }
}
