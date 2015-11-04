using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;

namespace HRPortal.UI.Controllers
{
    public class PolicyController : Controller
    {
        private RepoOperations _rops = new RepoOperations();

        // GET: Policy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAllPolicies()
        {
            return View();
        }

        public ActionResult ManagePolicies()
        {
            return View();
        }

        public ActionResult ManageCategories()
        {
            return View();
        }
    }
}