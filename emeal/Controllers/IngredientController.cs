using System.Web.Mvc;

namespace emeal.Controllers
{
    public class IngredientController : Controller
    {
        [HttpGet]
        public PartialViewResult PartialIngredientForm()
        {
            return PartialView();
        }
    }
}