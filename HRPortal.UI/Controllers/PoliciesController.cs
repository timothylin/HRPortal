using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.BLL;

namespace HRPortal.UI.Controllers
{
    public class PoliciesController : Controller
    {
        private RepoOperations _rops = new RepoOperations();

        // GET: Policies
        public ActionResult Index()
        {
            return View();
        }
    }
}