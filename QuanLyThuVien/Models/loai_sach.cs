using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class loai_sach
    {
        public loai_sach() { }
        public loai_sach(loai_sach obj)
        {
            id = obj.id;
            ma_loai_sach = obj.ma_loai_sach;
            ten_loai = obj.ten_loai;
        }

        public int id { get; set; }

        [StringLength(100)]
        public string ma_loai_sach { get; set; }

        [Required]
        [StringLength(200)]
        public string ten_loai { get; set; }

       
        public virtual ICollection<dau_sach> dau_sach { get; set; }
    }
}
