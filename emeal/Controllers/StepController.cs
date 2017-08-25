using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class StepController : Controller
    {
        [HttpGet]
        public PartialViewResult PartialStep()
        {
            return PartialView("PartialStep", new Step());
        }
    }
}