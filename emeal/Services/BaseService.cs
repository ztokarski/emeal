using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    public class BaseService : IBaseService
    {
        protected readonly IRecipeDb Db;

        public BaseService(IRecipeDb db)
        {
            Db = db;
        }

        public IEnumerable<Recipe> GetAllRecipes() => Db.Recipes.ToList();

        public IEnumerable<Product> GetAllProducts() => Db.Products.ToList();
    }
}