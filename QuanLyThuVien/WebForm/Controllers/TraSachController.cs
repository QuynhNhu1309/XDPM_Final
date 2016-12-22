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
            var phieu_muon = from pm in db.phieu_muon
                             select pm;

            if (!String.IsNullOrEmpty(tim_doc_gia_index))
            {
                phieu_muon = phieu_muon.Where(w => w.doc_gia.ma_the_thu_vien.Contains(tim_doc_gia_index));

            }
            //Mymodel.Add(doc_gia.ToList());
            //Mymodel.Add(phieu_muon.ToList().ToPagedList(page ?? 1, 3));
            //return View(Mymodel);
            return View(phieu_muon.ToList().ToPagedList(page ?? 1, 5));
            //return View();
        }

        //
        // GET: /TraSach/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TraSach/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TraSach/Create

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
