using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class dau_sach
    {
         public dau_sach() { }

        public dau_sach(dau_sach obj)
        {
            id = obj.id;
            ma_dau_sach = obj.ma_dau_sach;
            ten_dau_sach = obj.ten_dau_sach;
            id_loai_sach = obj.id_loai_sach;
            tom_tat = obj.tom_tat;
            id_nxb = obj.id_nxb;
            so_luong_cuon_sach = obj.so_luong_cuon_sach;
            nam_xuat_ban = obj.nam_xuat_ban;
            id_tac_gia = obj.id_tac_gia;
            id_tinh_trang = obj.id_tinh_trang;
            loai_sach = obj.loai_sach;
            nha_xuat_ban = obj.nha_xuat_ban;
          
        }
       
        public int id { get; set; }

        public string ma_dau_sach { get; set; }

        [Required]
        [StringLength(255)]
        public string ten_dau_sach { get; set; }

        public int id_loai_sach { get; set; }

        [Required]
        public string tom_tat { get; set; }

        public int id_nxb { get; set; }

        public int so_luong_cuon_sach { get; set; }

        public int nam_xuat_ban { get; set; }

        public int id_tac_gia { get; set; }

        public int id_tinh_trang { get; set; }

        public virtual ICollection<cuon_sach> cuon_sach { get; set; }

        [ForeignKey("id_loai_sach")]
        public virtual loai_sach loai_sach { get; set; }

        [ForeignKey("id_nxb")]
        public virtual nha_xuat_ban nha_xuat_ban { get; set; }

        [ForeignKey("id_tac_gia")]
        public virtual tac_gia tac_gia { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }

        public virtual ICollection<phieu_muon_chi_tiet> phieu_muon_chi_tiet { get; set; }

        public virtual ICollection<phieu_nhap_chi_tiet> phieu_nhap_chi_tiet { get; set; }

        public virtual ICollection<phieu_tra_chi_tiet> phieu_tra_chi_tiet { get; set; }

        QuanLyThuVienDB db = new QuanLyThuVienDB();
        public List<dau_sach> ListAll()
        {
            return db.dau_sach.ToList();
        }

       
    }
}
