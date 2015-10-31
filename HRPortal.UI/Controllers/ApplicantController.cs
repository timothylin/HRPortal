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

            Experience newExp = new Experience();
            newApplication.ApplicationInfo.Experiences.Add(newExp);
            EducationInfo newEdu = new EducationInfo();
            newApplication.ApplicationInfo.Education.Add(newEdu);

            newApplication.ApplicationInfo.AppId = _rops.HighestAppIDNum() + 1;

            return View(newApplication);

        }

        [HttpPost]
        public ActionResult CreateApp(CreateAppVM newAppInfo)
        {
            newAppInfo.CreateStateList(_rops.ReturnListOfStates());
            newAppInfo.CreatePositionsList(_rops.ReturnListOfPositions());
            newAppInfo.CreateDegreesList();
            

            if (ModelState.IsValid)
            {
                _rops.AddAppToRepo(newAppInfo.ApplicationInfo);

                return View("Confirmation", _rops.ViewAllApps().ApplicationsList);
            }

            return View(newAppInfo);
        }
    }
}