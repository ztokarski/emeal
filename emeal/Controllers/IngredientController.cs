using System.Web.Mvc;
using emeal.Models;
using System.Collections.Generic;
using emeal.Controllers.Facades;

namespace emeal.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IngredientFacade _facade;

        public IngredientController(IngredientFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public PartialViewResult PartialIngredient()
        {
            return PartialView("PartialIngredient", new Ingredient());
        }

        [HttpGet]
        public ActionResult SearchByIngredients()
        {
            return View(_facade.GetAllProducts());
        }

        [HttpGet]
        public PartialViewResult SearchByIngredientsResult()
        {
            var stubbedProductsFormSelect2 = new List<int>();
            return PartialView("PartialSearchResults", _facade.SearchByProducts(stubbedProductsFormSelect2));
        }
    }
}