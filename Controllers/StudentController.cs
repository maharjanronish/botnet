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
            // Assign random Id just for demo purposes (no DB)
            st.Id = new Random().Next(1, 1000);

            // Pass the model to ViewDetails view
            return View("ViewDetails", st);
        }
    }
}
