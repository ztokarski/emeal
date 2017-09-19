using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    public class BaseService : IBaseService
    {
        protected readonly IRecipeDb Db;

        public BaseService(IRecipeDb db)
        {
            this.Db = db;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return Db.Recipes.ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Db.Products.ToList();
        }
    }
}