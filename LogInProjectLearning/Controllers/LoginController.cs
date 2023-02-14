using LogInProjectLearning.Data;
using LogInProjectLearning.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Providers.Entities;

namespace LogInProjectLearning.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;
        //public static string temp;

        public LoginController(ApplicationDbContext db)
        {
            _db= db;
        }
        // Get action method
        public IActionResult Index()
        {
            return View();
        }

        // POST 
        [HttpPost]
        public IActionResult Index(Login obj)
        {
            
            var objFromDb = _db.getlogin.Where(login => login.Username == obj.Username && login.Password == obj.Password).FirstOrDefault();
            if (objFromDb != null)
            {
                //temp = objFromDb.Username;
                HttpContext.Session.GetString(obj.Id.ToString());
                HttpContext.Session.GetString(obj.Username);
                TempData["success"] = "Login successfully:)";
                return  RedirectToAction("Index","User");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult ViewDetails(Login obj)
        {
            //IServiceCollection
            //HttpContext.Session.(temp);
            //ViewBag.Success = HttpContext.Session.Get(temp);
            //ViewBag.Username = temp;

            return View();
        }

        public IActionResult Logout()
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
