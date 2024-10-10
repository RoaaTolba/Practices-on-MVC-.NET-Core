using Microsoft.AspNetCore.Mvc;
using MVC_ITIday2.Models;

namespace MVC_ITIday2.Controllers
{
    public class BindController : Controller
    {
        // model binging : map action parameter with request data (formdata - query string - routedata)

        //Bind/testPrimitive?id=1&name=Ahmed&color=red&color=blue
        //Bind/testPrimitive?id=1&name=Ahmed&color[1]=red&color[0]=blue
        //Bind/testPrimitive/1?name=Ahmed&color[1]=red&color[0]=blue
        public IActionResult testPrimitive(int id,string name, int age,List<string> color)
        {
            return Content($"{name} {id} ");
        }

        //Bind/testDec?name=Roaa&phones[Ahmed]=0102837488&phones[Name]=01233453424
        public IActionResult testDec(Dictionary<string,int> phones,string name)
        {
            return Content($"{phones.Count} {name}");
        }
        //Binding Custom / complex type
        //Bind/testComplex?Id=1&ManegerName=qasem&Name=hossam
        public IActionResult testComplex(Department dep)
        {
            return Content("ok");
        }
        // it will take the id and name only from the class
        public IActionResult testComplex2([Bind(include:"Id,Name")]Department dep)
        {
            return Content("ok");
        }
    }
}
