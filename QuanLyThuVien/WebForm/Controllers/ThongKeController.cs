using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace WebForm.Controllers
{
    public class ThongKeController : Controller
    {
        //
        // GET: /ThongKe/
        public QuanLyThuVienDB _db = new QuanLyThuVienDB();

        public ActionResult Index()
        {
            string id_doc_gia = "TV001";
            //var salesPeople = await context.Database.SqlQuery<doc_gia>(
            //        "Data_PM_ID_Latest @id_doc_gia",
            //        new SqlParameter("id_doc_gia", id_doc_gia)).ToListAsync();
            //var countryList = context.Database.SqlQuery<phieu_muon_chi_tiet>("Data_DG_ID_Dua_Vao_MaTV @ma_the_thu_vien", new SqlParameter("@ma_the_thu_vien", id_doc_gia)).ToList();

            var datefrom = "2016-11-11 00:00:00.000";
            var dateto = "2016-11-22 00:00:00.000";
            int id = 1;

            var Arr_datefrom = datefrom.ToString().Split('-');
            var Arr_dateto = dateto.ToString().Split('-');

            //DateTime date1 = new DateTime(Convert.ToInt32(Arr_datefrom[0]), Convert.ToInt32(Arr_datefrom[1]), Convert.ToInt32(Arr_datefrom[2])); /*new DateTime(form["FromDate"]);*/
            //DateTime date2 = new DateTime(Convert.ToInt32(Arr_dateto[0]), Convert.ToInt32(Arr_dateto[1]), Convert.ToInt32(Arr_dateto[2])); /*form["ToDate"];*/

            DateTime date1 = new DateTime(2016, 10, 20);
            DateTime date2 = new DateTime(2016, 12, 27);

            var list = _db.phieu_muon.Join(_db.phieu_muon_chi_tiet, pm => pm.id, ctm => ctm.id_phieu_muon, (pm, ctm) => new
            {
                phieu_muon = pm,
                chi_tiet_phieu_muon = ctm
            }).Join(_db.dau_sach, ctm => ctm.chi_tiet_phieu_muon.id_dau_sach, cs => cs.id, (ctm, cs) => new
            {
                chi_tiet_phieu_muon = ctm,
                dau_sach = cs
            }).Where(i => i.chi_tiet_phieu_muon.phieu_muon.id_doc_gia == id &&
            i.chi_tiet_phieu_muon.phieu_muon.ngay_muon >= date1 &&
            i.chi_tiet_phieu_muon.phieu_muon.ngay_muon <= date2).Select(i => new
            {
                ngay_muon = i.chi_tiet_phieu_muon.phieu_muon.ngay_muon,
                id_phieu_muon = i.chi_tiet_phieu_muon.phieu_muon.id,
                id_dau_sach = i.dau_sach.id,
                //MaVachCuonSach = i.CuonSach.MaVach,
                //DauSachID = i.CuonSach.DauSach.ID,
                ten_dau_sach = i.dau_sach.ten_dau_sach,
            }).ToList();

            ViewBag.List = list;
            return View(list);
        }

        //
        // GET: /ThongKe/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ThongKe/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ThongKe/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ThongKe/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ThongKe/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ThongKe/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ThongKe/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
