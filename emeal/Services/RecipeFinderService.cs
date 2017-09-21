using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;
using emeal.Strategies.Interfaces;

namespace emeal.Services
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeFinderService : IRecipeFinder
    {
        private readonly IRecipeSearchStrategy _strategy;

        public RecipeFinderService(IRecipeSearchStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<int> FindRelevantRecipes(IEnumerable<Recipe> recipeList, List<int> queryArr)
        {
            return _strategy.GetRelevantRecipeIds(recipeList, queryArr);
        }
    }
}