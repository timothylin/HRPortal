using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;
using HRPortal.UI.Models;

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
            var policies = new ViewPoliciesVM();

            policies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());

            return View(policies);
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