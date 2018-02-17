using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace RentAdminPannel.Controllers
{



    public class HomeController : Controller
    {

        public class Data
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }


        public string CallMe()
        {
            /*Data obj = new Data();
            obj.Code = "0023";
            obj.Name = "Ritesh Tandon";*/


            List<Data> lst = new List<Data>();
            lst.Add(new Data() { Code="0005",Name="Ritesh Tandon" });
            lst.Add(new Data() { Code = "0004", Name = "Harleen" });
            lst.Add(new Data() { Code = "0007", Name = "Shafi" });
            lst.Add(new Data() { Code = "0009", Name = "Hemant" });
            return (new JavaScriptSerializer().Serialize(lst));
        }

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