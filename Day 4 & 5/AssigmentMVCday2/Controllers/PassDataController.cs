using AssigmentMVCday2.Models;
using AssigmentMVCday2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssigmentMVCday2.Controllers
{
    public class PassDataController : Controller
    {
        MyDbContext context = new MyDbContext();
        int crsID = 3;
        int Id = 0;
        public IActionResult Index()
        {
           List< StudentAndHisCourseWithDegree > stdViewModel = new List<StudentAndHisCourseWithDegree>();

            for (int std = 1; std < 3; std++)
            {
                for (int crs =1; crs<5; crs++)
                {
                    // Create a new instance of the view model for each iteration
                    var viewModel = new StudentAndHisCourseWithDegree();

                    viewModel.Id = Id++;
                    // Set the properties for this specific student and course
                    viewModel.StudentId = std;

                    // Retrieve the course name
                    viewModel.CourseName = context.CrsResults
                        .Where(cr => cr.trainee_id == std && cr.crs_id == crs)
                        .Select(cr => cr.Course.Name)
                        .FirstOrDefault();

                    // Retrieve the course result (including degree)
                    var crsResult = context.CrsResults
                        .FirstOrDefault(d => d.trainee_id == std && d.crs_id == crs);

                    // Assign the degree or 0 if no result found
                    viewModel.crsDegree = crsResult != null ? crsResult.degree : 0;

                    // Retrieve the minimum degree
                    viewModel.minDegree = context.CrsResults
                        .Where(cr => cr.trainee_id == std && cr.crs_id == crs)
                        .Select(cr => cr.Course.minDegree)
                        .FirstOrDefault();

                    // Retrieve the student's name
                    viewModel.StdName = context.Trainees
                        .Where(d => d.Id == std)
                        .Select(d => d.Name)
                        .FirstOrDefault();

                    // Add the viewModel to the list
                    stdViewModel.Add(viewModel);
                }
            }
            return View(stdViewModel);
        }
        public IActionResult Details(int id)
        {
            StudentAndHisCourseWithDegree stdViewModel = new StudentAndHisCourseWithDegree();
            
            stdViewModel.StudentId = id;
            stdViewModel.CourseName = context.CrsResults.Where(cr => cr.trainee_id == id & cr.crs_id == crsID).Select(cr => cr.Course.Name).FirstOrDefault();
            //stdViewModel.crsDegree = context.CrsResults.FirstOrDefault(d => d.trainee_id == id);
            var crsResult = context.CrsResults.FirstOrDefault(d => d.trainee_id == id & d.crs_id == crsID);
            // Check if crsResult is not null, then assign the Degree to the view model
            stdViewModel.crsDegree = crsResult != null ? crsResult.degree : 0;

            stdViewModel.minDegree = context.CrsResults.Where(cr => cr.trainee_id == id & cr.crs_id == crsID).Select(cr => cr.Course.minDegree).FirstOrDefault();
            stdViewModel.StdName = context.Trainees
                .Where(d => d.Id == id) // Find the trainee with the given id
                .Select(d => d.Name)    // Select only the Name property
                .FirstOrDefault();
            
            return View(stdViewModel);
        }

    }
}
