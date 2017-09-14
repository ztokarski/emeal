using System.Linq;
using System.Web.Mvc;
using emeal.Models;
using System.Collections.Generic;

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

        [HttpGet]
        public ActionResult GetSearchResults()
        {
            var stubbedProductsFormSelect2 = new List<int>(){ 1, 2 };

            var queryResult = _db.Recipes.ToList();
            return View(queryResult);
        }
    }
}