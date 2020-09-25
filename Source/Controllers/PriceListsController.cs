//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using WebApp.Models;

//namespace WebApp.Controllers
//{
//    public class PriceListsController : Controller
//    {
//        private PriceContext db = new PriceContext();

//        // GET: PriceLists
//        public ActionResult Index()
//        {
//            return View(db.Prices.ToList());
//        }

//        // GET: PriceLists/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            PriceList priceList = db.PriceLists.Find(id);
//            if (priceList == null)
//            {
//                return HttpNotFound();
//            }
//            return View(priceList);
//        }

//        // GET: PriceLists/Create
//        public ActionResult Create()
//        {
//            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name");
//            return View();
//        }

//        // POST: PriceLists/Create
//        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
//        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,PriceId,Name,Code")] PriceList priceList)
//        {
//            if (ModelState.IsValid)
//            {
//                db.PriceLists.Add(priceList);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", priceList.PriceId);
//            return View(priceList);
//        }

//        // GET: PriceLists/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            PriceList priceList = db.PriceLists.Find(id);
//            if (priceList == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", priceList.PriceId);
//            return View(priceList);
//        }

//        // POST: PriceLists/Edit/5
//        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
//        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,PriceId,Name,Code")] PriceList priceList)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(priceList).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.PriceId = new SelectList(db.Prices, "Id", "Name", priceList.PriceId);
//            return View(priceList);
//        }

//        // GET: PriceLists/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            PriceList priceList = db.PriceLists.Find(id);
//            if (priceList == null)
//            {
//                return HttpNotFound();
//            }
//            return View(priceList);
//        }

//        // POST: PriceLists/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            PriceList priceList = db.PriceLists.Find(id);
//            db.PriceLists.Remove(priceList);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
