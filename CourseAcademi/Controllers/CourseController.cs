using CourseAcademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseAcademi.Controllers
{
    public class CourseController   : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//safety attribute
        public IActionResult Apply([FromForm] Candidate model)
        {
            Repository.Add(model);
            return View("Feadback",model);
        }
    }
}