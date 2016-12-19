using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QuanLyThuVienDB : DbContext
    {

        public  DbSet<cuon_sach> cuon_sach { get; set; }
        public  DbSet<dau_sach> dau_sach { get; set; }
        public  DbSet<doc_gia> doc_gia { get; set; }
        public  DbSet<loai_sach> loai_sach { get; set; }
        public  DbSet<nha_xuat_ban> nha_xuat_ban { get; set; }
        public  DbSet<nhan_vien> nhan_vien { get; set; }
        public  DbSet<phieu_muon> phieu_muon { get; set; }
        public  DbSet<phieu_muon_chi_tiet> phieu_muon_chi_tiet { get; set; }
        public  DbSet<phieu_tra> phieu_tra { get; set; }
        public  DbSet<phieu_tra_chi_tiet> phieu_tra_chi_tiet { get; set; }
        public  DbSet<tac_gia> tac_gia { get; set; }
        public  DbSet<trang_thai> trang_thai { get; set; }

        //public IEnumerable<doc_gia> Search(string tim_doc_gia)
        //{
        //    IOrderedQueryable<doc_gia> model = 
        //    if(!string.IsNullOrEmpty(tim_doc_gia))
        //}

       
         
    }
}
