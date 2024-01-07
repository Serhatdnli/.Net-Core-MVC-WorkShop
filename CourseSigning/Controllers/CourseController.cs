using CourseSigning.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseSigning.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            if (Repository.Applications.Any(x => x.EMail.Equals(candidate.EMail)))
                ModelState.AddModelError("Email", "This email address is already registered.");

            if (ModelState.IsValid)
            {
                Repository.Add(candidate);
                return View("Feedback", candidate);
            }
            else
                return View();
        }
    }
}