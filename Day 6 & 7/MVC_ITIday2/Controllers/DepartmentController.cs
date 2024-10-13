using Microsoft.AspNetCore.Mvc;
using MVC_ITIday2.Models;

namespace MVC_ITIday2.Controllers
{
    public class DepartmentController : Controller
    {
        MyDbContext context = new MyDbContext();

        public IActionResult ShowDepEmp()
        {
            List<Department> deptList = context.DepartmentSet.ToList();
            ViewData["DeptList"] = deptList;
            return View(deptList);
        }
        //Department/GetEmp_Dep?DeptId=2
        public IActionResult GetEmp_Dep(int DeptId)
        {
            List<Employee> EmpList = context.Employees.Where(d => d.Dep_id == DeptId).ToList();
            return Json(EmpList);
        }
        public IActionResult Index()
        {
            //Get all department

            List<Department> dep= context.DepartmentSet.ToList();

            return View("Index",dep);
            //return View(dep); //View= Index, Model= dep
            //return View(); //View= Index, Model= null
        }
        public IActionResult New()
        {
            return View(new Department());  
        }
        //the user can access to database with query string without passing on javascript validation and without put on submit
        // he will write the url like that [Department/saveNew?Id=1&ManegerName=qasem&Name=hossam]
        // he will know the name of keys from html page
        [HttpPost]
        public IActionResult saveNew(Department dep)
        {
            if (dep.Name != null)
            {
                context.DepartmentSet.Add(dep);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New", dep);
            }
        }
    }
}
