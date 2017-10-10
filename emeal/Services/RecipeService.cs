using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using emeal.Exceptions;
using emeal.Models;
using emeal.Models.Utils;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeService : BaseService, IRecipe
    {
        public RecipeService(IRecipeDb db) : base(db)
        {
        }

        public void Add(Recipe recipe)
        {
            if (!recipe.IsValid()) throw new InvalidRecipeException();

            // TODO: Replace new User() with one adding the recipe
            recipe.Author = new User();
            recipe.WhenAdded = DateTime.Today;

            Db.Recipes.Add(recipe);
            Db.SaveChanges();
        }

        public Recipe Find(int? id)
        {
            if (id == null) throw new InvalidRecipeIdException();
            return Db.Recipes.Find(id);
        }

        public void Edit(int id, Recipe editedRecipe)
        {
            if (!editedRecipe.IsValid())
                throw new InvalidRecipeException();

            var originalRecipe = Find(id);
            if (originalRecipe == null) throw new InvalidRecipeException();

            // TODO: Move this hunk of code to an overriden .equals() method

            #region toMove

            originalRecipe.Name = originalRecipe.Name == editedRecipe.Name
                ? originalRecipe.Name
                : editedRecipe.Name;

            originalRecipe.Description = originalRecipe.Description == editedRecipe.Description
                ? originalRecipe.Description
                : editedRecipe.Description;

            originalRecipe.DifficultyLevel = originalRecipe.DifficultyLevel == editedRecipe.DifficultyLevel
                ? originalRecipe.DifficultyLevel
                : editedRecipe.DifficultyLevel;

            originalRecipe.PathToImage = originalRecipe.PathToImage == editedRecipe.PathToImage
                ? originalRecipe.PathToImage
                : editedRecipe.PathToImage;

            originalRecipe.EstimatedTime = originalRecipe.EstimatedTime == editedRecipe.EstimatedTime
                ? originalRecipe.EstimatedTime
                : editedRecipe.EstimatedTime;

            originalRecipe.Ingredients = originalRecipe.Ingredients == editedRecipe.Ingredients
                ? originalRecipe.Ingredients
                : editedRecipe.Ingredients;

            originalRecipe.Steps = originalRecipe.Steps == editedRecipe.Steps
                ? originalRecipe.Steps
                : editedRecipe.Steps;

            #endregion

            Db.Recipes.AddOrUpdate(originalRecipe);
            Db.SaveChanges();
        }

        public void Remove(Recipe recipe)
        {
            if (!recipe.IsValid()) throw new InvalidRecipeException();

            Db.Steps.RemoveRange(recipe.Steps);
            Db.Ingredients.RemoveRange(recipe.Ingredients);
            Db.Recipes.Remove(recipe);
            Db.SaveChanges();
        }

        public IEnumerable<Recipe> GetSortedRecipes(string searchName, string sortOrder)
        {
            var recipes = GetAllRecipes();

            if (!string.IsNullOrEmpty(searchName))
                recipes = recipes.Where(r => r.Name.ToLower()
                    .Contains(searchName.ToLower())).ToList();

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

        public int GetRandomRecipeId()
        {
            Random random = new Random();
            var maxId = Db.Recipes.Count();
            var id = random.Next(maxId + 1);
            return id;
        }
    }
}