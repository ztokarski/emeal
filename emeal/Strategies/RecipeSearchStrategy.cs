using System;
using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Strategies.Interfaces;

namespace emeal.Strategies
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class RecipeSearchStrategy : IRecipeSearchStrategy
    {
        
        public List<int> GetRelevantRecipeIds(IEnumerable<Recipe> recipeList, List<int> queryProductIds)
        {
            if (recipeList == null || queryProductIds == null) return new List<int>();

            #region recipeMatchAlgorithm

            //                                  (recipeID, matchRatio)
            var recipeMatchRatios = new List<Tuple<int, int>>(); //Create Recipe Tuple in order to sort Recipes by Match Ratio
            ;
            foreach (var recipe in recipeList)
            {
                var productsIds = GetProductsIdsFromRecipe(recipe);

                var queryArgsWithoutRecipeIdsCount = queryProductIds.Except(productsIds).ToList().Count;
                var productIdsWithoutQueryArgsCount = productsIds.Except(queryProductIds).ToList().Count;

                var queryArgumentsCount = queryProductIds.Count;
                var recipeProductIdsCount = productsIds.Count;
                
                if (queryArgsWithoutRecipeIdsCount == queryArgumentsCount) continue; // matching 0%  e.g. query=[1,2,3] & recipe=[4,5,6] 
                else if (queryArgsWithoutRecipeIdsCount >= 0 && productIdsWithoutQueryArgsCount > 0) // e.g. query=[1,2,3] & recipe=[2,3,4]
                    recipeMatchRatios.Add(Tuple.Create(recipe.Id, productIdsWithoutQueryArgsCount + 30));
                else if (queryArgsWithoutRecipeIdsCount >= 0 && queryArgumentsCount >= recipeProductIdsCount) // matching 100% or e.g. query=[1,2,3] & recipe=[1,2]
                    recipeMatchRatios.Add(Tuple.Create(recipe.Id, queryArgsWithoutRecipeIdsCount));
                else                                                                                          // you have to buy product(s) e.g. query=[1,2,3] & recipe=[1,2,3,4] 
                    recipeMatchRatios.Add(Tuple.Create(recipe.Id, productIdsWithoutQueryArgsCount + 30));
                
            }
            recipeMatchRatios.Sort((y, x) => y.Item2.CompareTo(x.Item2)); // sort Recipes by Match Ratio (second element in Tuple)

            return recipeMatchRatios.Select(tuple => tuple.Item1).ToList();

            #endregion
        }

        private static List<int> GetProductsIdsFromRecipe(Recipe recipe)
        {
            return recipe.Ingredients.Select(ingredient => ingredient.Product.Id).ToList();
        }
    }
}