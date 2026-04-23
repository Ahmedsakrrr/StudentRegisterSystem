using Microsoft.AspNetCore.Mvc;
using StudentRegisterSystem.Data;


namespace StudentRegisterSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CourseController : Controller
    {
        StudentRegisterSystemDbContext _DbContext = new StudentRegisterSystemDbContext();
        public IActionResult Index()
        {
            var courses = _DbContext.Courses.Include(c=>c.Doctor).AsQueryable();
          
            
            return View(courses.AsEnumerable());
        }
    }
}
