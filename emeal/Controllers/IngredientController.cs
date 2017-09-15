using System.Linq;
using System.Web.Mvc;
using emeal.Models;
using System.Collections.Generic;
using System;
using emeal.Models.Utils;
using System.Data.Entity;
using emeal.Services;

namespace emeal.Controllers
{
    public class IngredientController : Controller
    {
        public Facade facade;

        public IngredientController(Facade facade)
        {
            this.facade = facade;
        }

        [HttpGet]
        public PartialViewResult PartialIngredient()
        {
            return PartialView("PartialIngredient", new Ingredient());
        }

        [HttpGet]
        public ActionResult SearchByIngredients()
        {
            return View(facade.GetProducts());
        }

        [HttpGet]
        public ActionResult GetSearchResults()
        {
            var stubbedProductsFormSelect2 = new List<int>(){ 1 };
            return View(facade.SearchByProducts(stubbedProductsFormSelect2));
        }




    }
}