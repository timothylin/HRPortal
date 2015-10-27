using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;
using HRPortal.Models;
using HRPortal.UI.Models;

namespace HRPortal.UI.Controllers
{
    public class ApplicantController : Controller
    {
        private RepoOperations _rops = new RepoOperations();

        // GET: Applicant
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public ActionResult CreateApp()
        {
            var newApplication = new CreateAppVM();
            newApplication.ApplicationInfo = new Resume();
            newApplication.CreatePositionsList(_rops.ReturnListOfPositions());
            newApplication.CreateStateList(_rops.ReturnListOfStates());
            newApplication.CreateDegreesList();

            return View(newApplication);

        }

        [HttpPost]
        public ActionResult CreateApp(CreateAppVM newAppInfo)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmation", newAppInfo);
            }

            return View();
        }
    }
}