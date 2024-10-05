using Microsoft.AspNetCore.Mvc;

namespace MVC_ITIday2.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult setCookie()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddHours(1);
            Response.Cookies.Append("name", "Asmaa",cookieOptions);//presedent session
            Response.Cookies.Append("state", "1");// session will end after 20 minute
            return Content("Cookie Saved");
        }
        public IActionResult getCookie()
        {
            string name = Request.Cookies["name"];
            string state = Request.Cookies["state"];
            return Content($"{name} - {state}");
        }

        public IActionResult setSession()
        {
            HttpContext.Session.SetString("name", "ahmed");
            HttpContext.Session.SetInt32("state", 1);
            return Content("Session Data Saved");
        }
        public IActionResult getSession()
        { 
            string name = HttpContext.Session.GetString("name");
            int? state = HttpContext.Session.GetInt32("state");
           // OR  int state = HttpContext.Session.GetInt32("state").Value;
            return Content($"{name} {state}");
        }

        public IActionResult setTempData()
        {
            TempData["msg"] = "hello";
            return Content("Data Saved");
        }
        public IActionResult get1() 
        {
            string message = TempData["msg"].ToString();
            //peek will take temp data not the real so the setion will not destroy becouse that isn't the real one
            string messge = TempData.Peek("msg").ToString();

            return Content("get1" + message);
        }
        public IActionResult get2() 
        {
            string message = TempData["msg"].ToString();
            //it will back the info to the setion and it will not allow to the setion be ended
             TempData.Keep("msg");

            return Content("get2" + message);
        }

    }
}
