using LogInProjectLearning.Data;
using Microsoft.AspNetCore.Mvc;

namespace LogInProjectLearning.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private static string temp;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if(ViewBag.Username == null)
            {
                //ViewBag.Username = temp;
                return RedirectToAction("ViewDetails", "Login");
            }
            else
            {
                return View();
            }
            
            
        }
    }
}
