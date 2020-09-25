using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using System.Data.Entity;
using System.Data;
using System.Net;
using Newtonsoft.Json;
//using System.Data.SqlPriceList;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace WebApp.Controllers
{

  

    public class HomeController : Controller
    {
        private PriceContext db = new PriceContext();
   
        //
        public ActionResult Index()
        {

          
            return View(db.Prices.ToList());
            //db.SaveChanges();
            //return View(dt);
        }

        public ActionResult Details(int id = 0)
        {
            Price student = db.Prices.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //public ActionResult Create(int id = 0)
        //{
        //    Price student = db.Prices.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.PriceLists = db.PriceLists.ToList();
        //    return View(student);
        //}

        //[HttpPost]
        //public ActionResult Create(Price student, int[] selectedPriceLists)
        //{
        //    Price newPrice = db.Prices.Find(student.Id);
        //    newPrice.Name = student.Name;

        //    newPrice.PriceLists.Clear();
        //    if (selectedPriceLists != null)
        //    {
        //        //получаем выбранные курсы
        //        foreach (var c in db.PriceLists.Where(co => selectedPriceLists.Contains(co.Id)))
        //        {
        //            newPrice.PriceLists.Add(c);
        //        }
        //    }

        //    db.Entry(newPrice).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpGet]
        public ActionResult Create()
        {
            // Формируем список команд для передачи в представление
            SelectList teams = new SelectList(db.PriceLists, "Id", "Name");
            ViewBag.PriceLists = teams;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Price player)
        {

            #region
            //DataSet bookStore = new DataSet("DefaultConnection");
            //DataTable booksTable = new DataTable("PriceLists");
            //// добавляем таблицу в dataset
            //bookStore.Tables.Add(booksTable);

            //// создаем столбцы для таблицы Books
            //DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            //idColumn.Unique = true; // столбец будет иметь уникальное значение
            //idColumn.AllowDBNull = false; // не может принимать null
            //idColumn.AutoIncrement = true; // будет автоинкрементироваться
            //idColumn.AutoIncrementSeed = 1; // начальное значение
            //idColumn.AutoIncrementStep = 1; // приращении при добавлении новой строки

            //DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            //DataColumn priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            //priceColumn.DefaultValue = 100; // значение по умолчанию
            //DataColumn discountColumn = new DataColumn("Discount", Type.GetType("System.Decimal"));
            //discountColumn.Expression = "Price * 0.2";

            //booksTable.Columns.Add(idColumn);
            //booksTable.Columns.Add(nameColumn);
            //booksTable.Columns.Add(priceColumn);
            //booksTable.Columns.Add(discountColumn);
            //// определяем первичный ключ таблицы books
            //booksTable.PrimaryKey = new DataColumn[] { booksTable.Columns["Id"] };

            //DataRow row = booksTable.NewRow();
            //row.ItemArray = new object[] { null, "Война и мир", 200 };
            //booksTable.Rows.Add(row); // добавляем первую строку
            //booksTable.Rows.Add(new object[] { null, "Отцы и дети", 170 }); // добавляем вторую строку

            //Console.Write("\tИд \tНазвание \tЦена \tСкидка");
            //Console.WriteLine();
            //foreach (DataRow r in booksTable.Rows)
            //{
            //    foreach (var cell in r.ItemArray)
            //        Console.Write("\t{0}", cell);
            //    Console.WriteLine();
            //}
            //Console.Read();

            //DataTable dt = new DataTable("PriceLists");
            //dt.Columns.Add("Email", typeof(System.Int32));
            //dt.Columns.Add("TimeStamp", typeof(System.Int32));
            ////DataTable dt = sql.ExecuteDataTable("sp_MyProc");

            ////dt.Columns.Add("NewColumn", typeof(System.Int32));

            ////foreach (DataRow row in dt.Rows)
            ////{
            ////    //need to set value to NewColumn column
            ////    row["NewColumn"] = 0;   // or set it to some other value
            ////}
            #endregion
            //Добавляем игрока в таблицу
            db.Prices.Add(player);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
        //public ActionResult Create()
        //{
        //    PopulateDepartmentsDropDownList();
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "PriceListID,Title,Credits,DepartmentID")]PriceList course)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.PriceLists.Add(course);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (RetryLimitExceededException /* dex */)
        //    {
        //        //Log the error (uncomment dex variable name and add a line here to write a log.)
        //        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //    }
        //    PopulateDepartmentsDropDownList(course.DepartmentID);
        //    return View(course);
        //}
        public ActionResult Edit(int id = 0)
        {
            Price student = db.Prices.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.PriceLists = db.PriceLists.ToList();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Price student, int[] selectedPriceLists)
        {
            Price newPrice = db.Prices.Find(student.Id);
            newPrice.Name = student.Name;
      
            newPrice.PriceLists.Clear();
            if (selectedPriceLists != null)
            {
                //получаем выбранные курсы
                foreach (var c in db.PriceLists.Where(co => selectedPriceLists.Contains(co.Id)))
                {
                    newPrice.PriceLists.Add(c);
                }
            }

            db.Entry(newPrice).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
