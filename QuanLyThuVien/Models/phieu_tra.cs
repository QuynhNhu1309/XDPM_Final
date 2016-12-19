using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class phieu_tra
    {
     
        public phieu_tra(){    }
        public phieu_tra(phieu_tra obj)
        {
            id = obj.id;
            ma_phieu_tra = obj.ma_phieu_tra;
            id_phieu_muon = obj.id_phieu_muon;
            id_nv = obj.id_nv;
            ngay_tra = obj.ngay_tra;
            nhan_vien = obj.nhan_vien;
            phieu_muon = obj.phieu_muon;
            
        }
        public int id { get; set; }

        public string ma_phieu_tra { get; set; }

        public int id_phieu_muon { get; set; }

        public int id_nv { get; set; }

        public DateTime ngay_tra { get; set; }

        [ForeignKey("id_nv")]
        public virtual nhan_vien nhan_vien { get; set; }

        [ForeignKey("id_phieu_muon")]
        public virtual phieu_muon phieu_muon { get; set; }

        public virtual ICollection<phieu_tra_chi_tiet> phieu_tra_chi_tiet { get; set; }
    }
}
