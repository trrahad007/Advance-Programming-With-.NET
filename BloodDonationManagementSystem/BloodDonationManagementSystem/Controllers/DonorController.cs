using BloodDonationManagementSystem.EF;
using BloodDonationManagementSystem.EF.Tables;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonationManagementSystem.Controllers
{
    public class DonorController : Controller
    {
     BloodBankDbContext db;
     public DonorController(BloodBankDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Donor());
        }
        [HttpPost]
        public IActionResult Create(Donor d)
        {
            if (ModelState.IsValid)
            {
                db.Donors.Add(d);
                var rs = db.SaveChanges(); //this returns row affectd
                if (rs > 0) return RedirectToAction("List");
            }
            return View(d);

        }
        public IActionResult List()
        {
            var data = db.Donors.ToList();
            return View(data);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
