using System;
using System.Net;
using System.Web.Mvc;
using emeal.Controllers.Facades;
using emeal.Exceptions;
using emeal.Models;

namespace emeal.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeFacade _facade;

        public RecipeController(RecipeFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public ActionResult Index(string searchName, string sortOrder)
        {
            ViewBag.SearchName = searchName;
            return View(_facade.GetSortedRecipes(searchName, sortOrder));
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            try
            {
                return View(_facade.Find(id));
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine($"Couldn\'t find the recipe by ID! \n {ioe}");
            }
            catch (InvalidRecipeIdException iride)
            {
                Console.WriteLine($"Couldn\'t find the recipe! \n {iride}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Recipe());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            try
            {
                _facade.Add(recipe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            try
            {
                var recipe = _facade.Find(id);
                return View(recipe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Recipe updatedRecipe)
        {
            try
            {
                _facade.Edit(id, updatedRecipe);
            }
            catch (InvalidRecipeException ire)
            {
                Console.WriteLine($"Invalid recipe! \n {ire}");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine($"Couldn\'t find the recipe by ID! \n {ioe}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            try
            {
                var recipe = _facade.Find(id);

                return View(recipe);
            }
            catch (InvalidRecipeException ire)
            {
                Console.WriteLine($"Invalid recipe! \n {ire}");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine($"Couldn\'t find the recipe by ID! \n {ioe}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var recipe = _facade.Find(id);
                _facade.Remove(recipe);
            }
            catch (InvalidRecipeIdException iride)
            {
                Console.WriteLine($@"Couldn\'t find the recipe with that ID! \n {iride}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RandomRecipe()
        {
            var randomId = _facade.RandomRecipeId();
            return RedirectToAction("Details", new {id = randomId});
        }
    }
}