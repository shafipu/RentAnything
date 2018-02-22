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
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult Profile()
        {
            tbl_usermaster admin = new tbl_usermaster();
            


            return View(admin);
        }

        
    }
}