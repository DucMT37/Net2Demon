using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controller
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Person> psList = new List<Person>()
            { 
                new Employee {PersonID = 1, PersonName = " Nguyen Van D", Phonenumber = "0123657890"}
                new Employee {PersonID = 2, PersonName = " Nguyen Van H", Phonenumber = "0334567880"}
                new Employee {PersonID = 3, PersonName = " Nguyen Van C", Phonenumber = "0322456789"}

            };
            ViewData["Person"] = PslList;
            return View();
        }
        [HttpPost]

        public IActionResult Create(Person ps)
        {
            string message = ps.PersonID + "_";
            message += ps.PersonName + "_";
            message += ps.Phonenumber;
            ViewBag.PS = message;
            return View();

        }
    }
}