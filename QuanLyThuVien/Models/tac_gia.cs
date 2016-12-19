using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class tac_gia
    {
       
        public tac_gia()
        {
            
        }
        public tac_gia(tac_gia obj)
        {
            id = obj.id;
            ma_tac_gia = obj.ma_tac_gia;
            ho_ten = obj.ho_ten;
            noi_cong_tac = obj.noi_cong_tac;
            
        }

        public int id { get; set; }

        [StringLength(100)]
        public string ma_tac_gia { get; set; }

        [Required]
        [StringLength(255)]
        public string ho_ten { get; set; }

        [StringLength(255)]
        public string noi_cong_tac { get; set; }

        public virtual ICollection<dau_sach> dau_sach { get; set; }
    }
}
