using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;
using emeal.Strategies.Interfaces;
using System.Linq;
using System;

namespace emeal.Services
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeFinderService : BaseService, IRecipeFinder
    {
        private readonly IRecipeSearchStrategy _strategy;

        public RecipeFinderService(IRecipeSearchStrategy strategy, IRecipeDb db) : base(db)
        {
            _strategy = strategy;
        }

        public List<Recipe> GetQueryResult(List<int> queryArr)
        {
            var foundRecipeIds = FindRelevantRecipesIds(queryArr);
            var matchedRecipes = FindMatchedRecipes(foundRecipeIds);
            var sortedRecipes = SortMatchedRecipes(matchedRecipes, foundRecipeIds);

            return sortedRecipes;
        }

        public List<int> FindRelevantRecipesIds(List<int> queryArr)
        {
            IEnumerable<Recipe> recipeList = GetAllRecipes();
            return _strategy.GetRelevantRecipeIds(recipeList, queryArr);
        }

        private IEnumerable<Recipe> FindMatchedRecipes(List<int> foundRecipeIds)
        {
            return GetAllRecipes().Where(rcp => foundRecipeIds.Contains(rcp.Id)).ToList();
        }

        private List<Recipe> SortMatchedRecipes(IEnumerable<Recipe> matchedRecipes, List<int> foundRecipeIds)
        {
            return matchedRecipes.OrderBy(rcp => foundRecipeIds.IndexOf(rcp.Id)).ToList();
        }
    }
}