using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.Models
{
    public class ThongKeDocGiaMuonSachModel
    {
        public ThongKeDocGiaMuonSachModel() { }

        public ThongKeDocGiaMuonSachModel(DateTime nm, int idpm, int idds, int sl, string tends) 
        {
            ngay_muon = nm;
            id_phieu_muon = idpm;
            id_dau_sach = idds;
            so_luong = sl;
            ten_dau_sach = tends;
        }

        public DateTime ngay_muon { get; set; }
        public int id_phieu_muon { get; set; }
        public int id_dau_sach { get; set; }
        public int so_luong { get; set; }
        public string ten_dau_sach { get; set; }

    }
}