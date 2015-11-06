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

        
        //Methods for View Policies tab
        public ActionResult ViewAllPolicies()
        {
            var viewPolicies = new ViewPoliciesVM();

            viewPolicies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());

            return View("ViewCategories", viewPolicies);
        }

        [HttpPost]
        public ActionResult ViewAllPolicies(ViewPoliciesVM viewPolicies)
        {
            viewPolicies.Policies = _rops.ReturnListOfPoliciesInCategory(viewPolicies.PolicyCategory);

            return View("ViewAllPolicies", viewPolicies);
        }

        public ActionResult ViewPolicyDetails(int policyId)
        {
            var policy = _rops.ReturnPolicyById(policyId);

            return View(policy);
        }



        //Methods for Manage Policies tab
        public ActionResult ManagePolicies()
        {
            var viewPolicies = new ViewPoliciesVM();
            viewPolicies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());

            return View(viewPolicies);
        }

        [HttpPost]
        public ActionResult ManagePoliciesInCategory(ViewPoliciesVM viewPolicies)
        {
            viewPolicies.Policies = _rops.ReturnListOfPoliciesInCategory(viewPolicies.PolicyCategory);

            return View(viewPolicies);
        }

        public ActionResult ViewPolicyDetailsFromMP(int policyId)
        {
            var policy = _rops.ReturnPolicyById(policyId);

            return View(policy);
        }

        public ActionResult DeletePolicy(int policyId, string category)
        {
            _rops.RemovePolicyByIdOp(policyId);
            var viewPolicies = new ViewPoliciesVM();
            viewPolicies.PolicyCategory.Category = category;
            viewPolicies.Policies = _rops.ReturnListOfPoliciesInCategory(viewPolicies.PolicyCategory);

            if (viewPolicies.Policies.Count() != 0)
            {
                return View("ManagePoliciesInCategory", viewPolicies);
            }
            else
            {
                return View("Index");
            }
        }


        //Methods For Add New Policy in Manage Policies tab
        public ActionResult AddNewPolicy()
        {
            var newPolicy = new CreatePolicyVM();
            newPolicy.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());
            //newPolicy.Policy.PolicyId = _rops.HighestPolicyIdNum() + 1;
            return View(newPolicy);
        }

        [HttpPost]
        public ActionResult AddNewPolicy(CreatePolicyVM newPolicy)
        {
            return View("CreateNewPolicyInExistingCat", newPolicy);
        }


        [HttpPost]
        public ActionResult CreateNewPolicyInExistingCat(CreatePolicyVM newPolicy)
        {
            newPolicy.Policy.PolicyId = _rops.HighestPolicyIdNum() + 1;

            if (ModelState.IsValid)
            {
                _rops.AddNewPolicyInExistingCat(newPolicy.Policy);

                return View("Confirmation", newPolicy.Policy);
            }

            return View(newPolicy);
        }

        public ActionResult AddNewCategoryAndPolicy()
        {
            var newPolicy = new CreatePolicyVM();
            newPolicy.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());
            newPolicy.Policy.PolicyId = _rops.HighestPolicyIdNum() + 1;

            return View(newPolicy);
        }

        [HttpPost]
        public ActionResult AddNewCategoryAndPolicy(CreatePolicyVM newPolicy)
        {
            if (ModelState.IsValid)
            {
                _rops.AddNewPolicyInNewCat(newPolicy.Policy);

                return View("Confirmation", newPolicy.Policy);
            }
            return View(newPolicy);
        }

        //Methods for Manage Categories tab
        public ActionResult ManageCategories()
        {
            var viewPolicies = new ViewPoliciesVM();
            viewPolicies.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());

            return View(viewPolicies);
        }
        
    }
}