using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KLTN_QL_KTX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public class PheduyetController : Controller
        {
            public ActionResult Index()
            {
                return View("PheDuyet"); 
            }
        }

    }
}
