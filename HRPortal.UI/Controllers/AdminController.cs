using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;

namespace HRPortal.UI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private RepoOperations _rops = new RepoOperations();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAllResumes()
        {
            var AppsList = _rops.ViewAllApps().ApplicationsList;

            return View(AppsList);
        }
    }
}