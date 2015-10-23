using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models;

namespace HRPortal.UI.Controllers
{
    public class ApplicantController : Controller
    {
        // GET: Applicant
        public ActionResult Index()
        {
            return View(new Application());
        }

        [HttpPost]
        public ActionResult SubmitApp(Application appInfo)
        {
            return View("Confirmation", appInfo);
        }
    }
}