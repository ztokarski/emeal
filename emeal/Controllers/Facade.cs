using System.Collections.Generic;
using System.Linq;
using emeal.Services;
using emeal.Models;

namespace emeal.Controllers
{
    public class Facade
    {
        private readonly IRecipeDb _db;
        private readonly IRecipeFinder _recipesFinder;

        public Facade(IRecipeFinder finder, IRecipeDb db)
        {
            _db = db;
            _recipesFinder = finder;
        }

        public object GetProducts()
        {
            return _db.Products.ToList();
        }

        public List<Recipe> GetAllRecipes()
        {
            return _db.Recipes.ToList();
        }

        public object GetFinder()
        {
            return null;
        }

        internal List<int> SearchByProducts(List<int> queryArr)
        {
            return _recipesFinder.FindRelevantRecipes(this.GetAllRecipes(), queryArr);
        }
    }
}