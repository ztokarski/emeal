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

        public List<Recipe> GetQueryResult(List<int> queryArr, List<int>queryAllergies)
        {
            var foundRecipeIds = FindRelevantRecipesIds(queryArr, queryAllergies);
            var matchedRecipes = FindMatchedRecipes(foundRecipeIds);
            var sortedRecipes = SortMatchedRecipes(matchedRecipes, foundRecipeIds);

            return sortedRecipes;
        }

        public List<int> FindRelevantRecipesIds(List<int> queryArr, List<int>queryAllergiesIds)
        {
            var recipeList = GetAllRecipes();
            return _strategy.GetRelevantRecipeIds(recipeList, queryArr, queryAllergiesIds);
        }

        private IEnumerable<Recipe> FindMatchedRecipes(IList<int> foundRecipeIds)
        {
            return GetAllRecipes().Where(rcp => foundRecipeIds.Contains(rcp.Id)).ToList();
        }

        private static List<Recipe> SortMatchedRecipes(IEnumerable<Recipe> matchedRecipes, IList<int> foundRecipeIds)
        {
            return matchedRecipes.OrderBy(rcp => foundRecipeIds.IndexOf(rcp.Id)).ToList();
        }
    }
}