using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDChef.WebUI.Controllers
{
    public class MaxController : Controller
    {
        // GET: Max
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return PartialView();
        }
        public ActionResult Category()
        {
            return PartialView();
        }
        public ActionResult Vendor()
        {
            return PartialView();
        }
        public ActionResult Customer()
        {
            return PartialView();
        }
    }
}