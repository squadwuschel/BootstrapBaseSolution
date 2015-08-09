using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapAndAngularJs.Models.Person.Interfaces;
using BootstrapAndAngularJs.Models.Person.Models;
using Ninject;

namespace BootstrapAndAngularJs.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IPersonModelBuilder PersonModelBuilder { get; set; }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPerson(int id)
        {
            return Json(PersonModelBuilder.GetPerson(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddOrUpdatePerson(Person person)
        {
            return Json(PersonModelBuilder.AddOrUpdatePerson(person), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllPersons()
        {
            return Json(PersonModelBuilder.GetAllPersons(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchPerson(string name)
        {
            return Json(PersonModelBuilder.SearchPerson(name), JsonRequestBehavior.AllowGet);
        }
    }
}