using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Member_Organisations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("RegisterMember");
        }

        // GET: Register Member
        public ActionResult RegisterMember()
        {
            return View();
        }

        // GET: Register Organisation
        public ActionResult RegisterOrganisation()
        {
            return View();
        }
    }
}