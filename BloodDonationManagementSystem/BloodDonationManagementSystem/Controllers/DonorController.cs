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
        //create -> CRUD
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
        //Read -> CRUD

        public IActionResult List()
        {
            var data = db.Donors.ToList();
            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = db.Donors.Find(id);
            return View(data);
        }

        //UPDATE -> CRUD
        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = db.Donors.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(Donor formObj)
        {
            var exObj = db.Donors.Find(formObj.DonorId);
            exObj.FullName = formObj.FullName;
            exObj.BloodGroup = formObj.BloodGroup;
            exObj.ContactNo = formObj.ContactNo;
            exObj.City= formObj.City;
            exObj.LastDonationDate = formObj.LastDonationDate;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        //DELETE -> CRUD
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = db.Donors.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(string Dcsn, int id)
        {
            if (Dcsn == "Yes")
            {
                var data = db.Donors.Find(id);
                db.Donors.Remove(data);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
