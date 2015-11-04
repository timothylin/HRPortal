using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;

namespace HRPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        
        public RepoOperations rops = new RepoOperations();
        Session["RepoOps"] = rops

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