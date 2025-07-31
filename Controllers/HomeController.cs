using Microsoft.AspNetCore.Mvc;
using SimpleInterestAndStudentApp.Models;

namespace SimpleInterestAndStudentApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(SimpleInterestModel model)
        {
            model.Interest = (model.Principal * model.Rate * model.Time) / 100;
            return View("Result", model);
        }
    }
}
