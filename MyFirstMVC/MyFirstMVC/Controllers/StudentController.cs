using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using System.Diagnostics;

namespace MyFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student Index Page";
            ViewBag.Message = "Welcome to the student module";
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.StudentId = id;
            return View();
        }
        public IActionResult About()
        {
            return Content("This is the About page of the Student module.");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
