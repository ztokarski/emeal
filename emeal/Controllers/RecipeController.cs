using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using emeal.Controllers.Facades;
using emeal.Models;
using emeal.Models.Utils;

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
            return View(_facade.GetIndex(searchName, sortOrder));
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var recipe = _facade.Find(id);
                if (recipe == null) return HttpNotFound();

                return View(recipe);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine($@"Sorry, couldn\'t find the recipe! \n {ioe}");
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
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var recipe = _facade.Find(id);
                if (recipe == null) return HttpNotFound();

                return View();
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
            if (!updatedRecipe.PathToImage.CheckUrlValid())
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            try
            {
                var originalRecipe = _facade.Find(id);
                if (originalRecipe == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                originalRecipe.Name = originalRecipe.Name == updatedRecipe.Name
                    ? originalRecipe.Name
                    : updatedRecipe.Name;

                originalRecipe.Description = originalRecipe.Description == updatedRecipe.Description
                    ? originalRecipe.Description
                    : updatedRecipe.Description;

                originalRecipe.DifficultyLevel = originalRecipe.DifficultyLevel == updatedRecipe.DifficultyLevel
                    ? originalRecipe.DifficultyLevel
                    : updatedRecipe.DifficultyLevel;

                originalRecipe.PathToImage = originalRecipe.PathToImage == updatedRecipe.PathToImage
                    ? originalRecipe.PathToImage
                    : updatedRecipe.PathToImage;

                originalRecipe.EstimatedTime = originalRecipe.EstimatedTime == updatedRecipe.EstimatedTime
                    ? originalRecipe.EstimatedTime
                    : updatedRecipe.EstimatedTime;

                originalRecipe.Ingredients = originalRecipe.Ingredients == updatedRecipe.Ingredients
                    ? originalRecipe.Ingredients
                    : updatedRecipe.Ingredients;

                originalRecipe.Steps = originalRecipe.Steps == updatedRecipe.Steps
                    ? originalRecipe.Steps
                    : updatedRecipe.Steps;


                _facade.Edit(originalRecipe);
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
                if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var recipe = _facade.Find(id);
                if (recipe == null) return HttpNotFound();

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
        public ActionResult Delete(int id)
        {
            try
            {
                var recipe = _facade.Find(id);
                if (recipe == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                _facade.Remove(recipe);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RandomRecipe()
        {
            throw new NotImplementedException();
        }
    }
}