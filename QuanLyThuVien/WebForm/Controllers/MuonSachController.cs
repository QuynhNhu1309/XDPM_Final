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
using System.Web.Routing;



namespace WebForm.Controllers
{
    public class MuonSachController : Controller
    {


        //
        // GET: /MuonSach/
        QuanLyThuVienDB db = new QuanLyThuVienDB();
        public DateTime ngay_muon;
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
            return View(phieu_muon.ToList().ToPagedList(page ?? 1, 10));
            //return View(phieu_muon.ToList());
        
        }

        //
        // GET: /MuonSach/Details/5

        public ActionResult Details(int id)
        {

            //var pmct_list = from pmct in db.phieu_muon_chi_tiet
            //                join cs in db.cuon_sach on pmct.id_cuon_sach equals cs.id
            //                join pm in db.phieu_muon on pmct.id equals pm.id
            //                join tt in db.trang_thai on pmct.id_tinh_trang equals tt.id
            //                where pmct.id_phieu_muon == id
            //                select new { ma_phieu_muon = pm.ma_phieu_muon, ma_phieu_muon_chi_tiet = pmct.ma_phieu_muon_chi_tiet,
            //                             ma_cuon_sach = cs.ma_cuon_sach,
            //                             so_luong = pmct.so_luong,
            //                             ten_trang_thai = tt.ten_trang_thai
            //                };

            var pmct_list = from pmct in db.phieu_muon_chi_tiet
                           where pmct.id_phieu_muon == id
                            select pmct;
            //pmct_list = pmct_list.Where(pmct => pmct.id_phieu_muon.Contains(id));

            return View(pmct_list.ToList());
           
        }

        

        //
        // GET: /MuonSach/Create

        public ActionResult Create(string tim_doc_gia, int? id_dau_sach)
        {
            //ViewBag.ngay_muon = ngay_muon;
            //ViewBag.ngay_tra = ngay_tra;
            ViewBag.tim_doc_gia = tim_doc_gia;
            List<object> Mymodel = new List<object>();
            var doc_gia = from s in db.doc_gia
                          select s;

            var dau_sach = from ds in db.dau_sach
                            where ds.id_tinh_trang == 2 && ds.so_luong_cuon_sach > 0
                            //group cs by ds into gr
                           select ds;


            //var count = dau_sach.Count();
           

            //ViewBag.so_luong_cuon_sach = 0;

            //List<int> list_cuon_sach = new List<int>();


            
            //    foreach (var item in dau_sach)
            //    {
            //        var cuon_sach_lst = (from cs in db.cuon_sach
            //                             join ds in db.dau_sach on cs.id_dau_sach equals ds.id
            //                             where cs.id_dau_sach == @item.  && cs.id_tinh_trang == 6
            //                             select cs).Count();
            //        list_cuon_sach.Add(cuon_sach_lst);
            //    }
           
            
           
           //var check_sl_cuon_sach = cuon_sach.Count();
            //ViewBag.so_luong_cuon_sach = 8;
            //ViewBag.so_luong_cuon_sach = check_sl_cuon_sach;
            //phieu_muon pm_dm = db.phieu_muon.Find(30);


            
           
            if (!String.IsNullOrEmpty(tim_doc_gia))
            {
                doc_gia = doc_gia.Where(s => s.ma_the_thu_vien.Contains(tim_doc_gia));
                //if(doc_gia.Count() == 1)
                //{
                //    var id_doc_gia = from s1 in db.doc_gia select s1.id;
                //    id_doc_gia = id_doc_gia.Where(s1 => s1.ma_the_thu_vien.Contains(tim_doc_gia)) ;
                //    ViewBag.id_doc_gia = id_doc_gia;
                //}
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
            Mymodel.Add(dau_sach.ToList());
            //Mymodel.Add(list_cuon_sach.ToList());
            //Mymodel.Add(phieu_muon_chi_tiet.ToList());
            //return View(Mymodel);
            return View(Mymodel);

            //var cuon_sach_lst1 = (from cs in db.cuon_sach
            //                     join ds in db.dau_sach on cs.id_dau_sach equals ds.id
            //                     where cs.id_tinh_trang == 6
            //                     select cs).Count();
            //return Json(Mymodel, JsonRequestBehavior.AllowGet);
        }

        //
        // POST: /MuonSach/Create

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(string []list)
        {
            //if (ModelState.IsValid)
            //{

            //db.phieu_muon.Add(pm);
            //var pm = new phieu_muon();
           // int res = pm.Create("PM010", ngay_muon, 1, so_luong, 1, 10, ngay_tra);
            //int res = pm.Create(ngay_muon, id_doc_gia, so_luong, 1, ngay_tra, id_dau_sach );


            
            //if (res > 0)
            //{ 
            //    return RedirectToAction("Create", new { tim_doc_gia = "TV001", idpm = idpm }); }
            //else
            //{
            //    ModelState.AddModelError("", "Thêm không thành công");
            //}
                
            
            //string strDDLValue = Request.Form["ddlVendor"].ToString();
            //ViewBag.ngay_muon = ViewBag.ngay_muon + "ABCDEF";
            //ngay_muon = ngay_muon;
            //if (res > 0)
           // return RedirectToAction("Create", new { tim_doc_gia = ma_doc_gia });
            //return View();
            
           // return Content(arr, "");
            DateTime ngaymuon = DateTime.Now;
            DateTime ngaytra = DateTime.Now;
            string ma_doc_gia="TV001";
            int tongsoluongmuon = 0;
            int j = 0;
            int tmp = 0;
            int flag = 0;
            for (int i = 0; i < list.Length; i++ )
            {
                
                if(list[i] != "")
                {
                    flag = flag + 1;
                }
                
            }
            //return Json(flag, JsonRequestBehavior.AllowGet);

            if (flag == list.Length)
            {
                while (j <= list.Length)
                {

                    if (j == 2)
                    {

                        tongsoluongmuon += Convert.ToInt32(list[j]);
                        tmp = j;

                    }
                    if (j % 2 == 0 && j - tmp == 4 && list.Length - j > 3)
                    {
                        tongsoluongmuon += Convert.ToInt32(list[j]);
                        tmp = j;
                    }

                    if (list.Length - j == 1)
                    {
                        ma_doc_gia = list[j];
                    }

                    if (list.Length - j == 3)
                    {
                        ngaymuon = Convert.ToDateTime(list[j]);
                        //ngaymuon = DateTime.ParseExact(list[j], "dd/MM/yyyy", null);
                    }

                    if (list.Length - j == 2)
                    {
                        ngaytra = Convert.ToDateTime(list[j]);
                        //ngaytra = DateTime.ParseExact(list[j], "dd/MM/yyyy", null);
                    }


                    j = j + 1;


                }

                List<int> list_muon1 = new List<int>();
                list_muon1.Add(tongsoluongmuon);
                int res = 0;
                var pm = new phieu_muon();
                //if(tongsoluongmuon > 0)
                //{ 

                //int res = pm.Them_PhieuMuon("PM010", ngay_muon, 1, so_luong, 1, 10, ngay_tra);
                res = pm.Them_PhieuMuon(ngaymuon, ma_doc_gia, tongsoluongmuon, ngaytra);
                //  }




                int id_dau_sach = 0;
                int soluongmuon = 0;
                int res_pmct = 0;
                for (int i = 1; i < list.Length - 3; i++)
                {

                    if (i % 4 == 2)
                    {
                        soluongmuon = Convert.ToInt32(list[i]);
                    }
                    if (i % 4 == 3)
                    {
                        id_dau_sach = Convert.ToInt32(list[i]);
                    }
                    if (soluongmuon != 0 && id_dau_sach != 0)
                    {
                        res_pmct = pm.Them_PhieuMuon_ChiTiet(soluongmuon, id_dau_sach);
                        soluongmuon = 0;
                        id_dau_sach = 0;
                    }

                }

                TempData["Success"] = "Thêm phiếu mượn thành công";
            }

            else
            {
                TempData["Error"] = "Thêm phiếu mượn không thành công";
            }
            //int[] list_muon = new int[10];
            //List<int> list_muon = new List<int>();

            //list_muon.Add(id_dau_sach);
            //list_muon.Add(soluongmuon);
            //list_muon.push(id_dau_sach);
            //list_muon.push(soluongmuon);

                //return Json(list);
            return Json(list, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Create");
           // return View();
            //return (RedirectToAction("Create", "MuonSach", new { tim_doc_gia = "" }));
            //return RedirectToAction("EveryView", "MuonSach");
    //        return RedirectToAction("Create", new RouteValueDictionary(
    //new { controller = "MuonSach", action = "Create", tim_doc_gia = "" }));
            //return Json(list_muon, JsonRequestBehavior.AllowGet);
            

        }
        public ActionResult EveryView()
        {
            return View();
        }



        public ActionResult Hello()
        {
            return Content("Hello Ajax", "text/plain");
            //return View();
        }

        //
        // GET: /MuonSach/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /MuonSach/Edit/5

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
        // GET: /MuonSach/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /MuonSach/Delete/5

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
