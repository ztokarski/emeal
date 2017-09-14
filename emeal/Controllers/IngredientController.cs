using System.Linq;
using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class IngredientController : Controller
    {
        private readonly RecipeDb _db;

        public IngredientController()
        {
            _db = new RecipeDb();
        }

        [HttpGet]
        public PartialViewResult PartialIngredient()
        {
            return PartialView("PartialIngredient", new Ingredient());
        }

        [HttpGet]
        public ActionResult SearchByIngredients()
        {
            return View(_db.Products.ToList());
        }
    }
}