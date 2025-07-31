using Microsoft.AspNetCore.Mvc;
using SimpleInterestAndStudentApp.Models;

namespace SimpleInterestAndStudentApp.Controllers
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

        public IActionResult ViewDetails(StudentDetails st)
        {
            return View(st);
        }
    }
}
