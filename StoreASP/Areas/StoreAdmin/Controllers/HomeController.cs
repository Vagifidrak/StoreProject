using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreASP.Areas.StoreAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: StoreAdmin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}