using AssigmentMVCday2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday2.Controllers
{
    public class InstructorController : Controller
    {MyDbContext context =new MyDbContext();
        public IActionResult Index()
        {
            //Get All
            List<Instructor> instructors = context.instructors.ToList();
            return View("Index",instructors);
        }
        public IActionResult Details(int id)
        {
            Instructor instructor = context.instructors.FirstOrDefault(x => x.Id == id);
            return View("Details",instructor);
        }
    }
}
