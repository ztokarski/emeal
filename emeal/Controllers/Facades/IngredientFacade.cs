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

        public IngredientFacade(IRecipeFinder finder, IMainService mainService) : base(mainService)
        {
            _recipesFinder = finder;
        }

        internal List<int> SearchByProducts(List<int> queryArr)
        {
            return _recipesFinder.FindRelevantRecipes(GetAllRecipes(), queryArr);
        }
    }
}