using System;
using System.Data.Entity.Migrations;
using emeal.Models;
using emeal.Models.Utils;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeFacade : Facade
    {
        public RecipeFacade(IRecipeDb db) : base(db)
        {
        }

        public void Add(Recipe recipe)
        {
            if (!recipe.PathToImage.CheckUrlValid() || recipe.EstimatedTime <= 0)
                throw new ArgumentException();
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

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
    }
}