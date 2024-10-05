using Microsoft.AspNetCore.Mvc;
using MVC_ITIday2.Models;

namespace MVC_ITIday2.Controllers
{
    public class DepartmentController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult Index()
        {
            //Get all department

            List<Department> dep= context.DepartmentSet.ToList();

            return View("Index",dep);
            //return View(dep); //View= Index, Model= dep
            //return View(); //View= Index, Model= null
        }
    }
}
