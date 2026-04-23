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
        [HttpGet]
        public IActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Login(string studentCode)
        {
            var student = _DbContext.Students
                .FirstOrDefault(s => s.StudentCode == studentCode);
            Console.WriteLine(studentCode);

            if (student != null)
            {
                return RedirectToAction("Index","Course");
            }

            ViewBag.Error = "Invalid Code";
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
