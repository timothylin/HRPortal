using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;
using HRPortal.Models;

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

        public ActionResult Details(int appId)
        {
            var response = _rops.GetAppById(appId);
            var resume = response.Application;
            return View(resume);
        }
    }
}