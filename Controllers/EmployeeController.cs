using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controller
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emlList = new List<Employee>()
            { 
                new Employee {EmployeeID = 1, EmployeeName = " Nguyen Van M", Age = 18}
                new Employee {EmployeeID = 2, EmployeeName = " Nguyen Van B", Age = 20}
                new Employee {EmployeeID = 3, EmployeeName = " Nguyen Van N", Age = 18}

            };
            ViewData["Employee"] = EmlList;
            return View();
        }
        [HttpPost]

        public IActionResult Create(Employee eml)
        {
            string message = eml.EmployeeID + "_";
            message += eml.EmployeeName + "_";
            message += eml.Age;
            ViewBag.EM = message;
            return View();

        }
    }
}