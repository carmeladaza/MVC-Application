using Microsoft.AspNetCore.Mvc;
using MVC_Application.Models;
using System.Diagnostics;

namespace MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult carmela()
        {
            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "Carmela";
            student.MiddleName = "Pestilos";
            student.LastName = "Daza";
            student.Address = "Quezon City";

            return View(student);
        }
        public IActionResult james()
        {
            StudentModel student = new StudentModel();
            student.ID = 2;
            student.FirstName = "James Paul";
            student.MiddleName = "Castillo";
            student.LastName = "Soliven";
            student.Address = "Pasig City";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
