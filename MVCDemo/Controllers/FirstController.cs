using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public string I1()
        {
            return "hello";
        }

        public ViewResult I2()
        {
            return View();
        }

        public ContentResult I3()
        {
            return Content("aaaaaa");
        }
        public IActionResult Content()
        {
            if (1 == 2)
            {
                return PartialView();
            }
            else if (2 == 2)
            {
                return View();
            }
            else if (1 < 2)
            {
                return Content("aaaaaa");
            }
        }
        // send some value from action method to view
        // ViewBag
        // ViewData
        // TempData
        public IActionResult Display()
        {
            ViewBag.name = "Deepak Kumar";
            ViewData["date"] = DateTime.Now;
            return View();
        }


    }
}
