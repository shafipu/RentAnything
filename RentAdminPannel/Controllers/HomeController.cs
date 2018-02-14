using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentAdminPannel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Item_display()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Description()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult adPosting()
        {
            return View();
        }
        /** public ActionResult About()
         {
             ViewBag.Message = "Your application description page.";

             return View();
         }

         public ActionResult Contact()
         {
             ViewBag.Message = "Your contact page.";

             return View();
         }**/
    }
}