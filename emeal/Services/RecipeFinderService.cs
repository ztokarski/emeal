using System;
using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;
using emeal.Services.Strategies;

namespace emeal.Services
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeFinderService : IRecipeFinder
    {
        private const int MaxProductNumberDifference = 5;

        public List<int> FindRelevantRecipes(List<Recipe> recipeList, List<int> queryArr)
        {
            return RecipeSearchStrategy.GetRelevantRecipeIds(recipeList, queryArr, MaxProductNumberDifference);
        }
    }
}