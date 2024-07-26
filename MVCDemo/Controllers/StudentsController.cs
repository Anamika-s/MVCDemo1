using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentsController : Controller
    {
        // CRUD operations
        // scaffolding > autogeneration of code
        // index action method is used to display records
        static List<Student> list;
        public StudentsController()
        {
            if (list == null)
            {
                list = new List<Student>()
                {
                    new Student() { Id = 1, Name = "Ajay", Address = "N delhi", Score = 89 },

                    new Student() { Id = 2, Name = "Jay", Address = "O delhi", Score = 89 },

                    new Student() { Id = 3, Name = "Vijay", Address = "Calcutta", Score = 76 },

                    new Student() { Id = 4, Name = "Sagar", Address = "N delhi", Score = 90 }
                };

            }
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return  View(list.FirstOrDefault(x => x.Id == id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            list.Add(student);
            return RedirectToAction("Index");   

        }

        public IActionResult Edit(int id)
        {
            return View(list.FirstOrDefault(x => x.Id == id));

        }

        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            foreach(var temp in list)
            {
                if(temp.Id == id)
                {
                    temp.Address = student.Address;
                    temp.Score = student.Score;
                }

            }
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            return View(list.FirstOrDefault(x => x.Id == id));

        }

        [HttpPost]
        public IActionResult Delete(int id, Student student)
        {
            foreach (var temp in list)
            {
                if (temp.Id == id)
                {
                    list.Remove(temp);
                    break;
                }

            }
            return RedirectToAction("Index");

        }
    }
}
