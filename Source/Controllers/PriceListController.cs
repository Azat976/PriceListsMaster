//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebApp.Models;
//using System.Data.Entity;

//namespace WebApp.Controllers
//{
//    public class PriceListController : Controller
//    {
//        // создаем контекст данных
//        PriceContext db = new PriceContext();

//        public ActionResult Index(int? Id)
//        {


//            var pricelists = db.PriceLists.Include(s => s.Price)
//                .FirstOrDefaultAsync(m => m.Id == Id);
       
//            return View(pricelists);
//            //var pricelists = db.PriceLists
//            // .Include(c => c.Price)
//            // .AsNoTracking();
//            //return View(pricelists.ToList());
//        }
//        // GET: PriceList/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: PriceList/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: PriceList/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: PriceList/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: PriceList/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: PriceList/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: PriceList/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
