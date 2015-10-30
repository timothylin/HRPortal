using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Applicant()
        {
            return RedirectToAction("Index", "Applicant");
        }

        public ActionResult Admin()
        {
            return RedirectToAction("Index", "Admin");
        }
    }
}