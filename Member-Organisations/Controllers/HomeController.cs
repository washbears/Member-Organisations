using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Member_Organisations.ViewModels;

namespace Member_Organisations.Controllers
{
    public class HomeController : Controller
    {

        MODatabaseEntities db;

        public HomeController()
        {
            db = new MODatabaseEntities();
        }

        // GET: Home
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel(db.Organisations.ToList(), db.Members.ToList());
            return View(model);
        }

        // GET: Register Member
        public ActionResult RegisterMember()
        {
            RegisterMemberViewModel model = new RegisterMemberViewModel(db.Organisations.ToList());

            return View(model);

        }
        [HttpPost]
        public ActionResult RegisterMember(RegisterMemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add member
                Member member = model.member;
                db.Members.Add(member);

                // Save changes and return to page
                db.SaveChanges();

                return RedirectToAction("RegisterMember");
            }

            return RedirectToAction("RegisterMember");
        }

        // GET: Register Organisation
        public ActionResult RegisterOrganisation()
        {
            RegisterOrganisationViewModel model = new RegisterOrganisationViewModel(db.Organisations.ToList());

            return View(model);
        }
        [HttpPost]
        public ActionResult RegisterOrganisation(RegisterOrganisationViewModel model)
        {

            if (ModelState.IsValid)
            {
                // Add new organisation
                Organisation org = model.org;
                db.Organisations.Add(org);
                
                // Save changes and return to page
                db.SaveChanges();
                return RedirectToAction("RegisterOrganisation");
            }

            return RedirectToAction("RegisterOrganisation");
        }

    }
}