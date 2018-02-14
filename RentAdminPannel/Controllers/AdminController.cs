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
            return View();
        }

        public ActionResult categoryManagement()
        {
            return View();
        }

        public ActionResult userManagement()
        {
            return View();
        }

        public ActionResult adManagement()
        {
            return View();
        }

        public ActionResult locationManagement()
        {
            return View();
        }

        public ActionResult packageScheme()
        {
            return View();
        }

        public ActionResult notification()
        {
            return View();
        }

        
    }
}