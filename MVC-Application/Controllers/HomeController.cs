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
            student.MiddleName = "Castillo";
            student.LastName = "Soliven";
            student.Address = "Pasig City";

            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
