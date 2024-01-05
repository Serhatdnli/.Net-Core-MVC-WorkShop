using CourseSigning.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseSigning.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            Repository.Add(candidate);
            return View("Feedback", candidate);
        }
    }
}