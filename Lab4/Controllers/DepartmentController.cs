using Lab4.EF;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly SchoolDbContext _context;
        public DepartmentController(SchoolDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
        
    }
}
