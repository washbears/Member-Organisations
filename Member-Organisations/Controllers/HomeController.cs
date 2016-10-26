using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Member_Organisations.Models;

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
            return View();
        }

        // GET: Register Member
        public ActionResult RegisterMember()
        {
            RegisterMember RegisterMemberModel = new RegisterMember(db.Organisations.ToList());

            return View(RegisterMemberModel);
        }

        [HttpPost]
        public ActionResult RegisterMember(List<Organisation> orgs)
        {
            if (ModelState.IsValid)
            {

                // Add new member
                // NOTE: Upon clicking 'Registrera' the code does NOT take information from the form
                db.Members.Add(new Member() {
                    FName = "Lina",
                    LName = "Hanner",
                    Address = "Gatan",
                    PhoneNum = "000",
                    OrganisationID = 1
                    });

                // Save changes and return to page
                db.SaveChanges();
                return RedirectToAction("RegisterMember");
            }

            return View(orgs);
        }

        // GET: Register Organisation
        public ActionResult RegisterOrganisation()
        {
            return View(new MODatabaseEntities().Organisations.ToList());
        }
        [HttpPost]
        public ActionResult RegisterOrganisation(List<Organisation> orgs)
        {

            if (ModelState.IsValid)
            {

                // Add new organisation
                // NOTE: Upon clicking 'Registrera' the code does NOT take information from the form
                db.Organisations.Add(new Organisation()
                {
                    Name = "TestOrganisation"
                });

                // Save changes and return to page
                db.SaveChanges();
                return RedirectToAction("RegisterOrganisation");
            }

            return View(orgs);
        }

    }
}