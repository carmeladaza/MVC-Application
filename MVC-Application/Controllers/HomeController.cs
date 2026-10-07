using Microsoft.AspNetCore.Mvc;
using MVC_Application.Models;
using System.Diagnostics;

namespace MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "JP";
            student.MiddleName = "C";
            student.LastName = "Soliven";
            student.Address = " Pasig City";


            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult James()
        {
            James james = new James();
            james.ID = 1;
            james.FirstName = "James Paul";
            james.MiddleName = "Castillo";
            james.LastName = "Soliven";
            james.Address = "Pasig City";
            james.Age = "19";
            james.School = "Polytechnic University of the Philippines";

            return View(james);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

