using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class IngredientFacade : Facade
    {
        private readonly IRecipeFinder _recipesFinder;

        public IngredientFacade(IRecipeFinder finder, IRecipeDb db) : base(db)
        {
            _recipesFinder = finder;
        }

        public IEnumerable<Product> GetProducts()
        {
            return Db.Products.ToList();
        }

        internal List<int> SearchByProducts(List<int> queryArr)
        {
            return _recipesFinder.FindRelevantRecipes(GetAllRecipes(), queryArr);
        }
    }
}