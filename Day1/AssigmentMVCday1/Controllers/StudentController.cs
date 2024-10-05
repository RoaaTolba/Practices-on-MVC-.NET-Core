using AssigmentMVCday1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday1.Controllers
{
    public class StudentController : Controller
    {
        StudentSampleData sampleData=new StudentSampleData();
        public IActionResult Index()
        {
            List<Student> students = sampleData.GetAll();

            return View("ViewIndex",students);
        }
        public IActionResult Details(int id)
        {
            Student student = sampleData.GetById(id);
            return View("ViewDetails",student);
        }
    }
}
