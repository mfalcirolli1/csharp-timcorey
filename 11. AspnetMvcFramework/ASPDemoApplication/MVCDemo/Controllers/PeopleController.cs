using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Matheus", LastName = "Falcirolli", Age = 25 });
            people.Add(new PersonModel { FirstName = "Joice", LastName = "Duarte", Age = 23 });
            people.Add(new PersonModel { FirstName = "Luke", LastName = "Skywalker", Age = 2 });
            people.Add(new PersonModel { FirstName = "Tobby", LastName = "Sponja", Age = 2 });

            return View(people);
        }
    }
}