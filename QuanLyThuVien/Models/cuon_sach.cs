using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class cuon_sach
    {
        
        public cuon_sach()
        {
            
        }

        public cuon_sach(cuon_sach obj)
        {
            id = obj.id;
            ma_cuon_sach = obj.ma_cuon_sach;
            id_dau_sach = obj.id_dau_sach;
            id_tinh_trang = obj.id_tinh_trang;
            trang_thai = obj.trang_thai;
            dau_sach = obj.dau_sach;
           

        }

        public int id { get; set; }

        public string ma_cuon_sach { get; set; }

        public int id_dau_sach { get; set; }

        public int id_tinh_trang { get; set; }

        [ForeignKey("id_dau_sach")]
        public virtual dau_sach dau_sach { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }
        
        public virtual ICollection<phieu_muon_chi_tiet> phieu_muon_chi_tiet { get; set; }
        
        public virtual ICollection<phieu_tra_chi_tiet> phieu_tra_chi_tiet { get; set; }

    }
}
