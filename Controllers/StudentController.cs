using Microsoft.AspNetCore.Mvc;
using Ronish.Models;

namespace Ronish.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentDetails student)
        {
            return View("ViewDetails", student);
        }
    }
}
