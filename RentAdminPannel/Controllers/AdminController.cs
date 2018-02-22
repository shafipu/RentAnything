using RentAdminPannel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentAdminPannel.Controllers
{
    public class AdminController : Controller
    {
        private RentAdminPannelContext db = new RentAdminPannelContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult Profile()
        {
            return View();
        }
 
         [HttpPost]
        [ValidateAntiForgeryToken]
        public new ActionResult Profile([Bind(Include = "email,password,firstname,lastname,gender,dob,address,country,state,city,zipcode,phone,entrydate,isActive")] tbl_usermaster tbl_Usermaster)
        {
            if (ModelState.IsValid)
            {
                
                tbl_Usermaster.entrydate = DateTime.Now;
                tbl_Usermaster.isActive = 1;
                db.tbl_usermaster.Add(tbl_Usermaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Usermaster);
        }

           
        }



    }



