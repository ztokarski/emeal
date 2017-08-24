using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using emeal.Models;
using emeal.Models.Utils;

namespace emeal.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeDb _db = new RecipeDb();

        [HttpGet]
        public ActionResult Index(string searchName, string sortOrder)
        {
            ViewBag.searchName = searchName;
            var recipes = _db.Recipes.ToList();

            if (!string.IsNullOrEmpty(searchName))
            {
                recipes = recipes.Where(r => r.Name.ToLower().Contains(searchName.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "name":
                    recipes = recipes.OrderBy(r => r.Name).ToList();
                    break;
                case "difficulty":
                    recipes = recipes.OrderBy(r => r.DifficultyLevel).ToList();
                    break;
                case "rating":
                    recipes = recipes.OrderByDescending(r => r.Rating).ToList();
                    break;
                case "time":
                    recipes = recipes.OrderBy(r => r.EstimatedTime).ToList();
                    break;
                default:
                    recipes = recipes.OrderByDescending(r => r.Popularity).ToList();
                    break;
            }
            return View(recipes);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var recipe = _db.Recipes.Find(id);
            if (recipe == null) return HttpNotFound();

            return View(recipe);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            if (!recipe.PathToImage.CheckUrlValid() || !recipe.DifficultyLevel.IsDifficultyEnum() ||
                recipe.EstimatedTime <= 0) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            try
            {
                // TODO: Replace new User() with one adding the recipe
                recipe.Author = new User();
                recipe.WhenAdded = DateTime.Today;

                _db.Recipes.Add(recipe);
                _db.SaveChanges();
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
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var recipe = _db.Recipes.Find(id);
            if (recipe == null) return HttpNotFound();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Recipe updatedRecipe)
        {
            if (!updatedRecipe.PathToImage.CheckUrlValid() || !updatedRecipe.DifficultyLevel.IsDifficultyEnum())
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            try
            {
                var originalRecipe = _db.Recipes.Find(id);

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

//                 TODO
//                originalRecipe.Ingredients = originalRecipe.Ingredients == updatedRecipe.Ingredients
//                    ? originalRecipe.Ingredients
//                    : updatedRecipe.Ingredients;
//                originalRecipe.Steps = originalRecipe.Steps == updatedRecipe.Steps
//                    ? originalRecipe.Steps
//                    : updatedRecipe.Steps;


                _db.Recipes.AddOrUpdate(originalRecipe);
                _db.SaveChanges();
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
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var recipe = _db.Recipes.Find(id);
            if (recipe == null) return HttpNotFound();
            return View(recipe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var recipe = _db.Recipes.Find(id);
            if (recipe != null)
            {
                _db.Recipes.Remove(recipe);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpGet]
        public ActionResult SearchByIngredients()
        {
            return View();
        }
    }
}