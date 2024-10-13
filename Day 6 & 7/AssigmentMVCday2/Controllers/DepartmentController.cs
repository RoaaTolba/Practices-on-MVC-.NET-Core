using AssigmentMVCday2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday2.Controllers
{
    public class DepartmentController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult ShowDept()
        {
            List<Department> deptList = context.departments.ToList();
            ViewData["DeptList"]=deptList;
            return View(deptList);
        }
        public IActionResult GetCoursesPerDept(int deptId)
        {
            List<Course> crsList = context.courses.Where(d=>d.dep_id==deptId).ToList();
            return Json(crsList);
        }
    }
}
