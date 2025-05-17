using Microsoft.AspNetCore.Mvc;
using TableGrid.Data;
using TableGrid.Models;

namespace TableGrid.Controllers
{
    public class TableGridController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TableGridController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IActionResult Index()
        {
            var user = _context.tbl_User.ToList();
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mTableGrid user)
        {
            if (ModelState.IsValid)
            {
                _context.tbl_User.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
