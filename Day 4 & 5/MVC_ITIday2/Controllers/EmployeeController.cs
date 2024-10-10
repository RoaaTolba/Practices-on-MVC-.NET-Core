using Microsoft.AspNetCore.Mvc;
using MVC_ITIday2.Models;

namespace MVC_ITIday2.Controllers
{
    public class EmployeeController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult Index()
        {
            return View(context.Employees.ToList());
        }
        public IActionResult New()
        {
            ViewData["Department"]= context.Employees.ToList();
            return View();
        }
        [HttpPost]
        //for post only not get
        [ValidateAntiForgeryToken]//for tag helper
        public IActionResult SaveNew(Employee newEmp)
        {
            if(newEmp.Name !=null)
            {
                context.Employees.Add(newEmp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New",newEmp);
        }

        public IActionResult Edit(int id)
        {
            Employee empModel = context.Employees.FirstOrDefault(d => d.Id == id);
            ViewData["deptList"] = context.DepartmentSet.ToList();
            return View(empModel);
        }
        [HttpPost]
        public IActionResult SaveEdit(int id, Employee newEmp)
        { 
            if (newEmp != null)
            {
                Employee oldref = context.Employees.FirstOrDefault(e => e.Id == id);
                if (oldref != null)
                {
                    oldref.Salary = newEmp.Salary;
                    oldref.Name = newEmp.Name;
                    oldref.Address = newEmp.Address;
                    oldref.Dep_id = newEmp.Dep_id;
                    oldref.Image = newEmp.Image;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewData["deptList"] = context.DepartmentSet.ToList();

            return View("Edit", newEmp);
        }
    }
}
