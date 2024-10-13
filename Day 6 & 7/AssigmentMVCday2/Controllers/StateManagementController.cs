using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday2.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult setSession()
        {
            HttpContext.Session.SetString("Name","Basem");
            HttpContext.Session.SetInt32("Level",9);
            return Content("Session Data Was Saved");
        }
        public IActionResult getSession()
        {
            var session = HttpContext.Session.GetString("Name");
            int? level = HttpContext.Session.GetInt32("Level");
            return Content($"{session} - {level}");
        }
    }
}
