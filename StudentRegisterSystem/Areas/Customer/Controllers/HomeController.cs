using Microsoft.AspNetCore.Mvc;
using StudentRegisterSystem.Data;
using StudentRegisterSystem.Models;
using System.Diagnostics;

namespace StudentRegisterSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        StudentRegisterSystemDbContext _DbContext=new StudentRegisterSystemDbContext();
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Login(string studentCode)
        {

            return View();
        }



        [HttpGet]
        public IActionResult Rgister()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
