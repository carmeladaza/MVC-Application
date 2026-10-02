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
        public IActionResult Xigrid()
        {
            Xigrid xigrid = new Xigrid();
         
            xigrid.FirstName = "Xigrid Micah";
            xigrid.MiddleName = "Gianan";
            xigrid.LastName = "Caharian";
            xigrid.Address = "Deparo, Caloocan City";
            xigrid.Age = "20";
            xigrid.School = "Polytechnic University of the Philippines";

            return View(xigrid);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
