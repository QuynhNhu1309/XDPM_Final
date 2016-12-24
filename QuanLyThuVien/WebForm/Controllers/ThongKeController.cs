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
        public QuanLyThuVienDB context = new QuanLyThuVienDB();

        public ActionResult Index()
        {
            string id_doc_gia = "TV001";
            //var salesPeople = await context.Database.SqlQuery<doc_gia>(
            //        "Data_PM_ID_Latest @id_doc_gia",
            //        new SqlParameter("id_doc_gia", id_doc_gia)).ToListAsync();
            var countryList = context.Database.SqlQuery<doc_gia>("[Data_DG_ID_Dua_Vao_MaTV]").ToList();
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
