using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // dipslay student data in view
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "ajay",
                Address = "N delhi",
                Score = 90
            };
            ViewBag.student = student;
            return View();
        }

        public IActionResult List()
        {
            List<Student> list;
            list = new List<Student>()
                {
                    new Student() { Id = 1, Name = "Ajay", Address = "N delhi", Score = 89 },

                    new Student() { Id = 2, Name = "Jay", Address = "O delhi", Score = 89 },

                    new Student() { Id = 3, Name = "Vijay", Address = "Calcutta", Score = 76 },

                    new Student() { Id = 4, Name = "Sagar", Address = "N delhi", Score = 90 }
                };
            ViewBag.list = list;
            return View();
        }


        public IActionResult Display1()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "ajay",
                Address = "N delhi",
                Score = 90
            };
            //ViewBag.student = student;
            return View(student);

        }

        public IActionResult List1()
        {
            List<Student> list;
            list = new List<Student>()
                {
                    new Student() { Id = 1, Name = "Ajay", Address = "N delhi", Score = 89 },

                    new Student() { Id = 2, Name = "Jay", Address = "O delhi", Score = 89 },

                    new Student() { Id = 3, Name = "Vijay", Address = "Calcutta", Score = 76 },

                    new Student() { Id = 4, Name = "Sagar", Address = "N delhi", Score = 90 }
                };
            return View(list);
        }
    }
}
