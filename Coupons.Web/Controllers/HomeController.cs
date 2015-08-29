using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coupons.Web.Infrastructure;
using System.Web.SessionState;
using Coupons.Web.Models;

namespace Coupons.Web.Controllers
{
    public class HomeController : Controller
    {

        private Context db = new Context();

        public HomeController()
        {
            
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("initial", "home", null);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Initial()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Main()
        {
            ViewBag.Message = "main coupon page";

            return View();
        }
    }
}
