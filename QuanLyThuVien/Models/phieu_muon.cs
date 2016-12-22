using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class phieu_muon
    {
        public phieu_muon()
        {
            
        }

        public phieu_muon(phieu_muon obj)
        {
            id = obj.id;
            ma_phieu_muon = obj.ma_phieu_muon;
            id_doc_gia = obj.id_doc_gia;
            ngay_muon = obj.ngay_muon;
            ngay_tra = obj.ngay_tra;
            tong_so_luong_muon = obj.tong_so_luong_muon;
            id_nv = obj.id_nv;
            id_tinh_trang = obj.id_tinh_trang;
            doc_gia = obj.doc_gia;
            nhan_vien = obj.nhan_vien;
            trang_thai = obj.trang_thai;
            //phieu_muon_chi_tiet = obj.phieu_muon_chi_tiet;
            
        }


        public int id { get; set; }

        public string ma_phieu_muon { get; set; }

        public int id_doc_gia { get; set; }

        public DateTime ngay_muon { get; set; }

        public DateTime ngay_tra { get; set; }

        public int tong_so_luong_muon { get; set; }

        public int id_nv { get; set; }

        public int id_tinh_trang { get; set; }

        [ForeignKey("id_doc_gia")]
        public virtual doc_gia doc_gia { get; set; }

        [ForeignKey("id_nv")]
        public virtual nhan_vien nhan_vien { get; set; }

        public virtual ICollection<phieu_muon_chi_tiet> phieu_muon_chi_tiet { get; set; }

        [ForeignKey("id_tinh_trang")]
        public virtual trang_thai trang_thai { get; set; }

        public virtual ICollection<phieu_tra> phieu_tra { get; set; }

        public QuanLyThuVienDB context = new QuanLyThuVienDB();

        //public int res = 0;
        // public int Create(string ma_phieu_muon, DateTime ngay_muon,int id_doc_gia,  int tong_so_luong_muon, int id_nv, int id_tinh_trang, DateTime ngay_tra)
        //{
        //        object[] parameters = 
        //        {
        //            new SqlParameter("@ma_phieu_muon",ma_phieu_muon),
        //            new SqlParameter("@ngay_muon", ngay_muon),
        //            new SqlParameter("@id_doc_gia", id_doc_gia),
        //            new SqlParameter("@tong_so_luong_muon", tong_so_luong_muon),
        //            new SqlParameter("@id_nv", id_nv),
        //            new SqlParameter("@id_tinh_trang", id_tinh_trang),
        //            new SqlParameter("@ngay_tra", ngay_tra),
        //          };
        //        int res = context.Database.ExecuteSqlCommand("Them_PM @ma_phieu_muon, @ngay_muon, @id_doc_gia, @tong_so_luong_muon, @id_nv, @id_tinh_trang, @ngay_tra ", parameters);
        //        return res;
        //}

         public int Create(DateTime ngay_muon, int id_doc_gia,  int so_luong_muon, int id_nv, DateTime ngay_tra, int id_dau_sach)
        {
                object[] parameters = 
                {
                    new SqlParameter("@ngay_muon", ngay_muon),
                    new SqlParameter("@id_doc_gia", id_doc_gia),
                    new SqlParameter("@so_luong_muon", so_luong_muon),
                    new SqlParameter("@id_nv", 1),
                    new SqlParameter("@id_tinh_trang", 10),
                    new SqlParameter("@ngay_tra", ngay_tra),
                    new SqlParameter("@id_dau_sach", id_dau_sach),
                  };
                int res = context.Database.ExecuteSqlCommand("Them_PM_PMCT @ngay_muon, @id_doc_gia, @so_luong_muon, @id_nv, @id_tinh_trang, @ngay_tra, @id_dau_sach ", parameters);
                return res;
        }

         public int Them_PhieuMuon(DateTime ngay_muon, string ma_doc_gia, int so_luong_muon, DateTime ngay_tra)
         {
             object[] parameters = 
                {
                    new SqlParameter("@ngay_muon", ngay_muon),
                    new SqlParameter("@ma_doc_gia", ma_doc_gia),
                    new SqlParameter("@so_luong_muon", so_luong_muon),
                    new SqlParameter("@id_nv", 1),
                    new SqlParameter("@id_tinh_trang", 11),
                    new SqlParameter("@ngay_tra", ngay_tra),
               
                  };
             int res = context.Database.ExecuteSqlCommand("Them_PhieuMuon @ma_doc_gia, @so_luong_muon, @ngay_muon, @ngay_tra, @id_nv, @id_tinh_trang ", parameters);
             return res;
         }

         public int Them_PhieuMuon_ChiTiet(int so_luong_muon, int id_dau_sach)
         {
             object[] parameters = 
                {
                    new SqlParameter("@so_luong_muon", so_luong_muon),
                    new SqlParameter("@id_tinh_trang", 15),
                    new SqlParameter("@id_dau_sach", id_dau_sach),
               
                  };
             int res = context.Database.ExecuteSqlCommand("Them_PhieuMuonChiTiet @so_luong_muon, @id_tinh_trang, @id_dau_sach ", parameters);
             return res;
         }


        public int Get_Id_Latest(int id_doc_gia)
        {
             //object[] parameters = 
             //   {
             //       new SqlParameter("@id_doc_gia", id_doc_gia),
                  
             //     };

             //var param = new SqlParameter("@id_doc_gia", id_doc_gia);
             //return context.Database.SqlQuery<int>("Data_PM_ID_Latest @id_doc_gia", param);

             //using (var context = new QuanLyThuVienDB())
             //{
             //    //var blogId = 1;

             //    var param = id_doc_gia;

             //    var blogs = context.doc_gia.SqlQuery("Data_PM_ID_Latest @id_doc_gia", id_doc_gia).Single();
             //}

            int rs = context.Database.SqlQuery<int>(
                    "Data_PM_ID_Latest @id_doc_gia",
                    new SqlParameter("id_doc_gia", id_doc_gia)).Single();
            return rs;


             
         }

        
    }
}
