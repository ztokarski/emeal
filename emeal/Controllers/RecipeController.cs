using System;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            return View(_db.Recipes.ToList());
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
            if (recipe.PathToImage.CheckUrlValid() && recipe.DifficultyLevel.IsDifficultyEnum()
                && recipe.Popularity.Equals(0) && recipe.EstimatedTime > 0 && recipe.Rating.Equals(0))
            {
                recipe.Id = null;
                recipe.Author = new User(); // TODO: Replace new User() with one adding the recipe
                recipe.WhenAdded = DateTime.Today;
                recipe.Ingredients = new List<Ingredient>();
                recipe.Steps = new List<Step>();

                _db.Recipes.Add(recipe);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
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
        public ActionResult Edit(int id, Recipe recipe)
        {
            if (recipe.PathToImage.CheckUrlValid() && recipe.DifficultyLevel.IsDifficultyEnum())
            {
                recipe.Id = id;
                _db.Recipes.AddOrUpdate(recipe);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
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
    }
}