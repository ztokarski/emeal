using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using emeal.Models;
using emeal.Models.Utils;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    public class RecipeService : MainService, IRecipe
    {

        public RecipeService(IRecipeDb Db) : base (Db)
        {
        }

        public void Add(Recipe recipe)
        {
            if (!recipe.PathToImage.CheckUrlValid() || recipe.EstimatedTime <= 0)
                throw new ArgumentException();
            //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            // TODO: Replace new User() with one adding the recipe
            recipe.Author = new User();
            recipe.WhenAdded = DateTime.Today;

            Db.Recipes.Add(recipe);
            Db.SaveChanges();
        }

        public Recipe Find(int? id)
        {
            return Db.Recipes.Find(id);
        }

        public void Edit(Recipe recipe)
        {
            Db.Recipes.AddOrUpdate(recipe);
            Db.SaveChanges();
        }

        public void Remove(Recipe recipe)
        {
            Db.Steps.RemoveRange(recipe.Steps);
            Db.Ingredients.RemoveRange(recipe.Ingredients);
            Db.Recipes.Remove(recipe);
            Db.SaveChanges();
        }

        public IEnumerable<Recipe> GetIndex(string searchName, string sortOrder)
        {
            var recipes = GetAllRecipes();

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

            return recipes;
        }
    }
}