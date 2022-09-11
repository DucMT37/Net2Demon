using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models

namespace Net2Demo.Controller
{
    public class StudentController : Controller;
    {

        public IActionResult Index()
        {
            //Khoi tao mot cai list student
            List<Student> stdList = new List<Student>()
            { 
                new Student {StudentID = 1, Studentname = " Nguyen Van A", Age = 18}
                new Student {StudentID = 2, Studentname = " Nguyen Van B", Age = 18}
                new Student {StudentID = 3, Studentname = " Nguyen Van C", Age = 18}

            };
            ViewData["Student"] = StdList;
            ViewBag.ThongTin = "Gui du lieu thong tin"
            TempData["ThongBao"] = " Gui du lieu TempData";
            return View();
        }
        [HttpPost]

        public IActionResult Create(Student std)
        {
            string message = std.StudentID + "_";
            message += std.StudentName + "_";
            message += std.Age;
            ViewBag.Message = message;
            return View();
        }
    }

        
    

	  
}