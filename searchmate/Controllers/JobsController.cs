using Microsoft.AspNetCore.Mvc;

namespace YourAppName.Controllers
{
    public class JobsController : Controller
    {
        // GET: /Jobs/JobSearch
        public ActionResult JobSearch()
        {
            // Here you can fetch jobs from your database or any other data source
            // For simplicity, let's assume we have a list of sample jobs
            List<string> sampleJobs = new List<string>
            {
                "Software Engineer",
                "Data Scientist",
                "Web Developer",
                "Product Manager"
            };

            // Pass the list of jobs to the view
            return View(sampleJobs);
        }
    }
}
