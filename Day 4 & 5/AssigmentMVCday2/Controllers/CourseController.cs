using AssigmentMVCday2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday2.Controllers
{
    public class CourseController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult Index()
        {
            List<Course> courses = context.courses.ToList();
            return View(courses);
        }
        public IActionResult New()
        {
            ViewData["deptList"] = context.departments.ToList();
            return View(new Course());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveNew(Course newCrs)
        {
            if(newCrs.Name !=null)
            {
                context.courses.Add(newCrs);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New",newCrs);
        }
        public IActionResult Edit(int id)
        {
            ViewData["DeptList"] = context.departments.ToList();
            Course course = context.courses.FirstOrDefault(c => c.Id == id);
            return View(course);
        }
        public IActionResult SaveEdit(int id,Course newCrs)
        {
            if(newCrs.Name !=null)
            {
                Course old = context.courses.FirstOrDefault(d=>d.Id == id);
                if (old != null)
                {
                    old.Name = newCrs.Name;
                    old.dep_id = newCrs.dep_id;
                    old.Degree = newCrs.Degree;
                    old.minDegree = newCrs.minDegree;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewData["DeptList"] = context.departments.ToList();

            return View("Edit",newCrs);
        }
    }
}
