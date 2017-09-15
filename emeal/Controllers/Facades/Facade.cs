using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    public class Facade
    {
        protected readonly IRecipeDb Db;

        protected Facade(IRecipeDb db)
        {
            Db = db;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return Db.Recipes.ToList();
        }
    }
}