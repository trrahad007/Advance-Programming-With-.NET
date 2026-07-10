using ElectricityBillComplaint.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ElectricityBillComplaint.Controllers
{
    public class BillController : Controller
    {
        [HttpGet]
        public IActionResult Bill()
        {
            return View(new Bill());
        }

        [HttpPost]
        public IActionResult Bill(Bill obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(obj);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}