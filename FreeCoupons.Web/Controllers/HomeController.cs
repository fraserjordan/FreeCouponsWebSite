using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FreeCoupons.Domain;
using FreeCoupons.Web.Infrastructure;
using System.Web.SessionState;

namespace FreeCoupons.Web.Controllers
{
    public class HomeController : Controller
    {

        private IFreeCouponDataSource _db = new UserDb();

        public HomeController(IFreeCouponDataSource db) 
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allUsers = _db.Users;

            return View(allUsers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Main() 
        {
            ViewBag.Message = "mian coupon page";

            return View();
        }
    }
}
