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

        public Person GetPerson(int id)
        {
            return PersonModelBuilder.GetPerson(id);
        }

        public int AddOrUpdatePerson(Person person)
        {
            return PersonModelBuilder.AddOrUpdatePerson(person);
        }

        public List<Person> GetAllPersons()
        {
            return PersonModelBuilder.GetAllPersons();
        }

        public List<Person> SearchPerson(string name)
        {
            return PersonModelBuilder.SearchPerson(name);
        }
    }
}