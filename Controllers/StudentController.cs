using System;
using Microsoft.AspNetCore.Mvc;
using WebApp_Ronish_04.Models;

namespace WebApp_Ronish_04.Controllers
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
            st.Id = new Random().Next(100, 999);
            return View("ViewDetails", st);
        }
    }
}
