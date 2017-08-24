using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class IngredientController : Controller
    {
        [HttpGet]
        public PartialViewResult PartialIngredient()
        {
            return PartialView("PartialIngredient", new Ingredient());
        }
    }
}