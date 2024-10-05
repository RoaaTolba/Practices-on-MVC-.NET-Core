using Microsoft.AspNetCore.Mvc;
using MVC_ITI.Models;

namespace MVC_ITI.Controllers
{
    public class ProductController : Controller
    {
        ProductSampleDate sampleDate = new ProductSampleDate();
        public IActionResult GetAllData()
        {
            List<Product> products = sampleDate.GetAll();
            return View("ShowAll",products);
        }
        public IActionResult Details(int id)
        {
            Product ProductModel = sampleDate.GetById(id);
            return View("ProductDetails",ProductModel);
        }

        #region First part
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public ViewResult ViewResult()
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "View1";
        //    return result;

        //}
        //public JsonResult JsonResult()
        //{
        //    //JsonResult json = new JsonResult(new {id =2 , name = "basem"});
        //    //return json;

        //    return Json(new { id = 2, name = "basem" });
        //}


        //// this is interface that ViewResult class and ContentResult class was implemented
        //public IActionResult Details(int id)
        //{
        //    //ViewResult result = new ViewResult();
        //    //result.ViewName = "View1";
        //    //return result ;
        //    if (id == 0)
        //        return View("View1");
        //    else
        //        return Content("Error");
        //}
        #endregion
    }
}
