using Microsoft.AspNetCore.Mvc;
using MVC_ITIday2.Models;
using MVC_ITIday2.ViewModel;

namespace MVC_ITIday2.Controllers
{
    public class PassDataaController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult testViewData(int id)
        {
            Employee emp = context.Employees.FirstOrDefault(d=> d.Id==id);
            string msg = "hello";
            int temp = 55;
            string color = "Red";

            List<string> list = new List<string>();
            list.Add("Alex");
            list.Add("Luxor");
            list.Add("Cairo");
            list.Add("Aswan");
            list.Add("Qus");

            // ViewData[Key]=Value;

            ViewData["msge"]=msg;
            ViewBag.msge = "Hi";
            ViewData["temp"]=temp;
            ViewData["color"]=color;
            ViewData["list"]=list;

            EmployeeWithMessageAndBranchesViewModel empViewModel = new EmployeeWithMessageAndBranchesViewModel();
            empViewModel.Message = msg;
            empViewModel.Branches = list;
            empViewModel.EmpId = id;
            empViewModel.EmpName = emp.Name;
            empViewModel.Temp = temp;
            empViewModel.Color = color;

            return View(empViewModel);
        }
    }
}
