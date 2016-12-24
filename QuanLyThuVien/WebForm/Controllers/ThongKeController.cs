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
using WebForm.Models;

namespace WebForm.Controllers
{
    public class ThongKeController : Controller
    {
        //
        // GET: /ThongKe/
        public QuanLyThuVienDB _db = new QuanLyThuVienDB();

        public ActionResult Index(string ma_the)
        {


            return View();
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
        public JsonResult GetData_ThongKe(string mathe, string tungay, string denngay)
        {
            if (mathe != null && tungay != null && denngay != null)
            {
                //var datefrom = Convert.ToDateTime(list_obj[0]);
                //var dateto = Convert.ToDateTime(list_obj[1]);

                

                //var Arr_datefrom = datefrom.ToString().Split('-');
                //var Arr_dateto = dateto.ToString().Split('-');
                var Arr_datefrom = tungay.Split('-');
                var Arr_dateto = denngay.Split('-');


                DateTime date1 = new DateTime(Convert.ToInt32(Arr_datefrom[0]), Convert.ToInt32(Arr_datefrom[1]), Convert.ToInt32(Arr_datefrom[2])); /*new datetime(form["fromdate"]);*/
                DateTime date2 = new DateTime(Convert.ToInt32(Arr_dateto[0]), Convert.ToInt32(Arr_dateto[1]), Convert.ToInt32(Arr_dateto[2])); /*form["todate"];*/


                //DateTime date1 = new DateTime(2016, 10, 20);
                //DateTime date2 = new DateTime(2016, 12, 27);

                var list = _db.phieu_muon.Join(_db.phieu_muon_chi_tiet, pm => pm.id, ctm => ctm.id_phieu_muon, (pm, ctm) => new
                {
                    phieu_muon = pm,
                    phieu_muon_chi_tiet = ctm
                }).Join(_db.dau_sach, ctm => ctm.phieu_muon_chi_tiet.id_dau_sach, cs => cs.id, (ctm, cs) => new
                {
                    phieu_muon_chi_tiet = ctm,
                    dau_sach = cs
                }).Where(i => i.phieu_muon_chi_tiet.phieu_muon.doc_gia.ma_doc_gia == mathe &&
                i.phieu_muon_chi_tiet.phieu_muon.ngay_muon >= date1 &&
                i.phieu_muon_chi_tiet.phieu_muon.ngay_muon <= date2).Select(i => new
                {
                    ngay_muon = i.phieu_muon_chi_tiet.phieu_muon.ngay_muon,
                    id_phieu_muon = i.phieu_muon_chi_tiet.phieu_muon.id,
                    id_dau_sach = i.dau_sach.id,
                    so_luong = i.phieu_muon_chi_tiet.phieu_muon_chi_tiet.so_luong,
                    //MaVachCuonSach = i.CuonSach.MaVach,
                    //DauSachID = i.CuonSach.DauSach.ID,
                    ten_dau_sach = i.dau_sach.ten_dau_sach,
                }).ToList();

                return Json(list);
            }
            else
            {
                return Json("ok");
            }
            //return id;


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
