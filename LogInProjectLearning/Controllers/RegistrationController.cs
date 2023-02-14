using LogInProjectLearning.Data;
using LogInProjectLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogInProjectLearning.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RegistrationController(ApplicationDbContext db)
        {
            _db = db;
        }
        // Get action
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // POST
        public IActionResult Index(Login obj)
        {
            if(ModelState.IsValid)
            {
                // var objRegister = _db.getlogin.Add();
                _db.getlogin.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "User registered successfully:)";
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
