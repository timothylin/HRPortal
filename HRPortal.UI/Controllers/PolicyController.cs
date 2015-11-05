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
            var viewPolicies = new ViewPoliciesVM();

            viewPolicies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());

            return View("ViewCategories", viewPolicies);
        }

        [HttpPost]
        public ActionResult ViewAllPolicies(ViewPoliciesVM viewPolicies)
        {
            //viewPolicies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());
            viewPolicies.Policies = _rops.ReturnListOfPoliciesInCategory(viewPolicies.PolicyCategory);

            return View("ViewAllPolicies", viewPolicies);
        }

        public ActionResult ViewPolicyDetails(int policyId)
        {
            var policy = _rops.ReturnPolicyById(policyId);

            return View(policy);
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