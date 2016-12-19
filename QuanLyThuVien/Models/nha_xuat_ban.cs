using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class nha_xuat_ban
    {
       
        public nha_xuat_ban()
        {
        }
        public nha_xuat_ban(nha_xuat_ban obj)
        {
            id = obj.id;
            ma_nxb = obj.ma_nxb;
            ten_nxb = obj.ten_nxb;
            so_dien_thoai = obj.so_dien_thoai;
            dia_chi = obj.dia_chi;
        }



        public int id { get; set; }

        [StringLength(100)]
        public string ma_nxb { get; set; }

        [Required]
        [StringLength(200)]
        public string ten_nxb { get; set; }

        [StringLength(50)]
        public string so_dien_thoai { get; set; }

        [StringLength(200)]
        public string dia_chi { get; set; }

        public virtual ICollection<dau_sach> dau_sach { get; set; }
    }
}
