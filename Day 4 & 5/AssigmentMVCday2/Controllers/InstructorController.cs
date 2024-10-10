using AssigmentMVCday2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday2.Controllers
{
    public class InstructorController : Controller
    {
        MyDbContext context =new MyDbContext();
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
        public IActionResult NewRecord()
        {
            ViewData["deptList"] = context.departments.ToList();
            ViewData["crsList"] = context.courses.ToList();

            return View(new Instructor());
        }
        [HttpPost]
        public IActionResult SaveNewRecord(Instructor inst)
        {
            if (inst.Name != null & inst.Salary != 0)
            {
                context.instructors.Add(inst);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["deptList"] = context.departments.ToList();
                ViewData["crsList"] = context.courses.ToList();

                return View("NewRecord", inst);
            }

        }
        public IActionResult Edit(int id)
        {
            Instructor inst = context.instructors.FirstOrDefault(d=> d.Id == id);
            ViewData["deptList"] = context.departments.ToList();
            ViewData["crsList"] = context.courses.ToList();
            return View(inst);
        }
        public IActionResult SaveEdit(int id, Instructor newInst)
        {
            if (newInst != null)
            {
                Instructor oldInst = context.instructors.FirstOrDefault(d => d.Id == id);
                if (oldInst != null)
                {
                    oldInst.Salary = newInst.Salary;
                    oldInst.Name = newInst.Name;
                    oldInst.crs_id = newInst.crs_id;
                    oldInst.Address = newInst.Address;
                    oldInst.dep_id = newInst.dep_id;
                    oldInst.Image = newInst.Image;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
                ViewData["deptList"] = context.departments.ToList();
                ViewData["crsList"] = context.courses.ToList();
                return View("Edit", newInst);
        }
    }
}
