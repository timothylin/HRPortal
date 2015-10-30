﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;
using HRPortal.Models;
using HRPortal.UI.Models;

namespace HRPortal.UI.Controllers
{
    public class SecureApplyController : Controller
    {
        private RepoOperations _rops = new RepoOperations();

        // GET: SecureApply
        public ActionResult Index()
        {
            return View();
        }

        // GET: Direct Application
        public ActionResult SecureApply()
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

            return View(newApplication);
        }

        [HttpPost]
        public ActionResult SecureApply(CreateAppVM newAppInfo)
        {
            newAppInfo.CreateStateList(_rops.ReturnListOfStates());
            newAppInfo.CreatePositionsList(_rops.ReturnListOfPositions());
            newAppInfo.CreateDegreesList();

            if (ModelState.IsValid)
            {
                return View("Confirmation", newAppInfo.ApplicationInfo);
            }

            return View(newAppInfo);
        }
    }
}