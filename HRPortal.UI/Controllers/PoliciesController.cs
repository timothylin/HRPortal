using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;
using HRPortal.UI.Models;

namespace HRPortal.UI.Controllers
{
    public class PoliciesController : Controller
    {
        private RepoOperations _rops;

        // GET: Policies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManagePolicies()
        {
            _rops = new RepoOperations();
            var policiesVm = new ViewPoliciesVM(_rops.ReturnListOfPolicyCategories(), _rops.ReturnAllPolicies());

            return View(policiesVm);
        }

        public ActionResult AddPolicyToNewCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPolicyInCategory(string categoryId)
        {
            _rops = new RepoOperations();
            var newPolicyVm = new CreatePolicyVM(_rops.ReturnListOfPolicyCategories());
            //newPolicyVm.CreatePolicyCatList(_rops.ReturnListOfPolicyCategories());
            newPolicyVm.Policy.Category.CategoryId = int.Parse(categoryId);

            return View(newPolicyVm);
        }

        [HttpPost]
        public ActionResult SubmitNewPolicyInCat(CreatePolicyVM vM)
        {
            _rops = new RepoOperations();
            vM.Policy.DateCreated = DateTime.Now.Date;
            //if (ModelState.IsValid)
            //{
                var complete = _rops.AddNewPolicy(vM.Policy);

                return View("Confirmation", complete);
            //}

            //return View("AddPolicyInCategory", vM);
        }

        public ActionResult ViewPoliciesInCategory(int id)
        {
            _rops = new RepoOperations();
            var policies = _rops.ReturnAllPolicies().Where(p => p.Category.CategoryId == id).ToList();

            return View(policies);
        }


        public ActionResult ManageCategories()
        {
            return View();
        }

        public ActionResult ViewAllPolicies()
        {
            return View();
        }
    }
}