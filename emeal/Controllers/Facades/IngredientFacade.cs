using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class IngredientFacade : BaseFacade
    {
        private readonly IRecipeFinder _recipesFinder;

        public IngredientFacade(IRecipeFinder finder, IBaseService baseService) : base(baseService)
        {
            _recipesFinder = finder;
        }

        internal List<int> SearchByProducts(List<int> queryArr)
        {
            return _recipesFinder.FindRelevantRecipes(GetAllRecipes(), queryArr);
        }
    }
}