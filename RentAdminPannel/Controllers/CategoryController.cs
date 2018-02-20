using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentAdminPannel.Models;
using System.Web.Script.Serialization;

namespace RentAdminPannel
{
    public class CategoryController : Controller
    {
        private RentAdminPannelContext db = new RentAdminPannelContext();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.tbl_category.ToList());
        }
        
        public string listOfAllCategory()
        {
            return (new JavaScriptSerializer().Serialize(db.tbl_category.ToList()));
        }

        // GET: Category/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "categoryid,categoryname,categorydescription,entryby,entrydate,isactive")] tbl_category tbl_category)
        {
            if (ModelState.IsValid)
            {
                tbl_category.entryby = "shafi";
                tbl_category.entrydate = DateTime.Now;
                tbl_category.isactive = 1;
                db.tbl_category.Add(tbl_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_category);
        }

        [HttpPost]
        public JsonResult CreateCategoryAjax(tbl_category cat)
        {
            tbl_category category = new tbl_category
            {
                categoryname = cat.categoryname,
                categorydescription = cat.categorydescription,
                entryby = "shafi",
                entrydate = DateTime.Now,
                isactive = 1
            };
            db.tbl_category.Add(category);
            db.SaveChanges();
            return Json(category, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult editCategoryAjax(tbl_category cat)
        {
            tbl_category category = new tbl_category
            {
                categoryid=cat.categoryid,
                categoryname = cat.categoryname,
                categorydescription = cat.categorydescription,
                entryby = "shafi",
                entrydate = DateTime.Now,
                isactive = 1
            };
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return Json(category, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public JsonResult deleteCategoryAjax(tbl_category cat)
        {
            tbl_category category = new tbl_category
            {
                categoryid = cat.categoryid,
            };
            tbl_category tbl_category = db.tbl_category.Find(category.categoryid);
            if (tbl_category == null)
            {
                return Json(category, JsonRequestBehavior.AllowGet);
            }
            db.tbl_category.Remove(tbl_category);
            db.SaveChanges();
            return Json(category, JsonRequestBehavior.AllowGet);
        }
        // GET: Category/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "categoryid,categoryname,categorydescription,entryby,entrydate,isactive")] tbl_category tbl_category)
        {
            if (ModelState.IsValid)
            {
                tbl_category.entryby = "shafi";
                tbl_category.entrydate = DateTime.Now;
                tbl_category.isactive = 1;
                db.Entry(tbl_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_category);
        }

        
        // GET: Category/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tbl_category tbl_category = db.tbl_category.Find(id);
            db.tbl_category.Remove(tbl_category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
