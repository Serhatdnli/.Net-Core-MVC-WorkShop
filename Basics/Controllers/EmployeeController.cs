using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{

    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "Hello World";
        }

        public ViewResult Index2()
        {
            return View("Index");
        }


        //IActionResult implemented ViewResult and ContentResult classes.

        public IActionResult Index3()
        {
            return Content("Employee");
        }


        public IActionResult Index4()
        {
            return View("Index4", $"Time: {DateTime.Now}");
        }


        public IActionResult Index5()
        {
            var names = new string[]{
                "Serhat Denli",
                "Ahmet Ilhan",
                "Muhammet Boyraz",
            };

            return View(names);
        }

        public IActionResult Index6()
        {
            var list = new List<Employee>(){
                new Employee(1,"Serhat","Denli",25),
                new Employee(2,"Ahmet","Ilhan",24),
                new Employee(3,"Muhammet","Boyraz",24),
            };
            return View("Employee", list);
        }
    }


}