using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DbController1 : Controller
    {
        StudentDbContext ab;
        public DbController1(StudentDbContext empDb)
        {
            ab = empDb;
        }
        public IActionResult create()
        {
            return View();
        }
        public IActionResult create1(Emp Emptvl)
        {
            ab.Emps.Add(Emptvl); 
            ab.SaveChanges();
            return View();
        }
    }
   
}
