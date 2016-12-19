using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class doc_gia
    {
        
        public doc_gia()
        {
            
        }
        public doc_gia(doc_gia obj)
        {
            id = obj.id;
            ma_doc_gia = obj.ma_doc_gia;
            ho_ten = obj.ho_ten;
            dia_chi = obj.dia_chi;
            dien_thoai = obj.dien_thoai;
            ngay_cap_the = obj.ngay_cap_the;
            ngay_het_han = obj.ngay_het_han;
            nam_tot_nghiep = obj.nam_tot_nghiep;
            so_sach_muon_toi_da = obj.so_sach_muon_toi_da;
            thoi_gian_muon_toi_da = obj.thoi_gian_muon_toi_da;
            cmnd = obj.cmnd;
            nghe_nghiep = obj.nghe_nghiep;
            id_tinh_trang = obj.id_tinh_trang;
            ma_the_thu_vien = obj.ma_the_thu_vien;
            trang_thai = obj.trang_thai;
        }


        public int id { get; set; }

        [StringLength(100)]
        public string ma_doc_gia { get; set; }

        [Required]
        [StringLength(250)]
        public string ho_ten { get; set; }

        [Required]
        [StringLength(200)]
        public string dia_chi { get; set; }

        [Required]
        [StringLength(50)]
        public string dien_thoai { get; set; }

        public DateTime ngay_cap_the { get; set; }

        public DateTime ngay_het_han { get; set; }

        public DateTime nam_tot_nghiep { get; set; }

        public int so_sach_muon_toi_da { get; set; }

        public int thoi_gian_muon_toi_da { get; set; }

        public string cmnd { get; set; }

        public string nghe_nghiep { get; set; }

        public int id_tinh_trang { get; set; }

        public string ma_the_thu_vien { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }
        public virtual ICollection<phieu_muon> phieu_muon { get; set; }


        public QuanLyThuVienDB context = new QuanLyThuVienDB();
        public int Get_id_doc_gia(string ma_the_thu_vien)
        {
        //    object[] parameters = 
        //        {
        //            new SqlParameter("@ma_the_thu_vien", ma_the),
                  
        //          };
        //    int id_doc_gia = context.Database.ExecuteSqlCommand("Data_DG_ID_Dua_Vao_MaTV @ma_the_thu_vien", parameters);
        //    return id_doc_gia;

            object[] parameters = 
                {
                    new SqlParameter("@ma_the_thu_vien", ma_the_thu_vien),
                  
                  };

            int rs = context.Database.SqlQuery<int>("select id from doc_gia where ma_the_thu_vien = '" + @ma_the_thu_vien + "'").FirstOrDefault();

           
            return rs;
        }


        
    }
}
