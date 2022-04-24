using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVSUZBBSTU.Controllers
{
    public class BSTUController : Controller
    {
        // GET: BSTU
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Minsk()
        {
            return View();
        }
        public ActionResult Mogiliov()
        {
            return View();
        }
    }
}