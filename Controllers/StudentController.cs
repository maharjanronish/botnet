using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentDetails st)
        {
            return View("ViewDetails", st);
        }

        [HttpGet]
        public IActionResult ViewDetails()
        {
            return View();
        }
    }
}
