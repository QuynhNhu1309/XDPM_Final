using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using System.Dynamic;
using PagedList;
using PagedList.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Collections;


namespace WebForm.Controllers
{
    public class TraSachController : Controller
    {
        //
        // GET: /TraSach/
        QuanLyThuVienDB db = new QuanLyThuVienDB();
        public DateTime ngay_tra;

        public ActionResult Index(string tim_doc_gia_index, int? page)
        {

            ViewBag.tim_doc_gia_index = tim_doc_gia_index;
            //List<object> Mymodel = new List<object>();
            //var doc_gia = from s in db.doc_gia
            //               select s;
            var phieu_tra = from pt in db.phieu_tra
                             select pt;

            if (!String.IsNullOrEmpty(tim_doc_gia_index))
            {
                phieu_tra = phieu_tra.Where(w => w.phieu_muon.doc_gia.ma_the_thu_vien.Contains(tim_doc_gia_index));

            }
            //Mymodel.Add(doc_gia.ToList());
            //Mymodel.Add(phieu_muon.ToList().ToPagedList(page ?? 1, 3));
            //return View(Mymodel);
            return View(phieu_tra.ToList().ToPagedList(page ?? 1, 5));
            //return View();
        }

        //
        // GET: /TraSach/Details/5

        public ActionResult Details(int id)
        {

            var ptct_list = from ptct in db.phieu_tra_chi_tiet
                            where ptct.id_phieu_tra == id
                            select ptct;

            //pmct_list = pmct_list.Where(pmct => pmct.id_phieu_muon.Contains(id));

            return View(ptct_list.ToList());
            //return View();
        }

        //
        // GET: /TraSach/Create

        public ActionResult Create(string tim_doc_gia)
        {
            ViewBag.tim_doc_gia = tim_doc_gia;
            List<object> Mymodel = new List<object>();
            var doc_gia = from s in db.doc_gia
                          select s;
            var phieu_muon_chi_tiet = (from pmct in db.phieu_muon_chi_tiet select pmct).
                Where(pmct=>pmct.phieu_muon.doc_gia.ma_the_thu_vien.Contains(tim_doc_gia));


            //var phieu_muon = (from pm in db.phieu_muon select pm)
            //                          .Where(pm => pm.doc_gia.ma_the_thu_vien.Contains(tim_doc_gia));
            //                              ;


            if (!String.IsNullOrEmpty(tim_doc_gia))
            {
                doc_gia = doc_gia.Where(s => s.ma_the_thu_vien.Contains(tim_doc_gia));
                Session.Remove("s_tim_doc_gia");
                Session["s_tim_doc_gia"] = tim_doc_gia;
                ViewBag.tim_doc_gia = Session["s_tim_doc_gia"];

            }
            else
            {
                doc_gia = from s in db.doc_gia
                          select s;

                if (!String.IsNullOrEmpty((string)(Session["s_tim_doc_gia"])))
                {
                    tim_doc_gia = (string)(Session["s_tim_doc_gia"]);
                    ViewBag.tim_doc_gia = Session["s_tim_doc_gia"];
                    doc_gia = doc_gia.Where(s => s.ma_the_thu_vien.Contains(tim_doc_gia));
                }
            }
            Mymodel.Add(doc_gia.ToList());
            Mymodel.Add(phieu_muon_chi_tiet.ToList());
            //Mymodel.Add(list_cuon_sach.ToList());
            //Mymodel.Add(phieu_muon_chi_tiet.ToList());
            //return View(Mymodel);
            return View(Mymodel);

        }

        //
        // POST: /TraSach/Create

        [HttpPost]
        public JsonResult Create(string[] list)
        {

            var pt = new phieu_tra();
            if (list.Length > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {

                    int res = pt.Tra_Sach(Convert.ToInt32(list[i]));
                }
                TempData["Success_PhieuTra"] = "Trả sách thành công";
            }
            
           
                return Json(list, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /TraSach/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TraSach/Edit/5

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
        // GET: /TraSach/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TraSach/Delete/5

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
