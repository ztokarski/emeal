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
        private const int MaxProductNumberDifference = 5;

        public List<int> GetRelevantRecipeIds(IEnumerable<Recipe> recipeList, List<int> queryProductIds)
        {
            if (recipeList == null || queryProductIds == null) return new List<int>();

            // TODO: Untangle this unholy mess

            #region recipeMatchAlgorithm

            //                                  (recipeID, matchRatio)
            var recipeMatchRatios = new List<Tuple<int, int>>();
            ;
            foreach (var recipe in recipeList)
            {
                var productsIds = GetProductsIdsFromRecipe(recipe);

                var queryArgumentsWithoutRecipeIdsCount = queryProductIds.Except(productsIds).ToList().Count;
                var productIdsWithoutQueryArgumentsCount = productsIds.Except(queryProductIds).ToList().Count;

                var queryArgumentsCount = queryProductIds.Count;
                var recipeProdictIdsCount = productsIds.Count;

                var currentProductNumberDifference = queryArgumentsCount - recipeProdictIdsCount;

                if (currentProductNumberDifference <= MaxProductNumberDifference)
                {
                    if (queryArgumentsWithoutRecipeIdsCount == queryArgumentsCount) continue;
                    else if (queryArgumentsWithoutRecipeIdsCount >= 0 && productIdsWithoutQueryArgumentsCount > 0)
                        recipeMatchRatios.Add(Tuple.Create(recipe.Id,
                            -productIdsWithoutQueryArgumentsCount + recipeProdictIdsCount * 10));
                    else if (queryArgumentsWithoutRecipeIdsCount >= 0 && queryArgumentsCount >= recipeProdictIdsCount)
                        recipeMatchRatios.Add(Tuple.Create(recipe.Id, queryArgumentsWithoutRecipeIdsCount));
                    else if (queryArgumentsWithoutRecipeIdsCount == 0 && queryArgumentsCount < recipeProdictIdsCount)
                        recipeMatchRatios.Add(Tuple.Create(recipe.Id,
                            -productIdsWithoutQueryArgumentsCount + recipeProdictIdsCount * 10));
                    else
                        recipeMatchRatios.Add(Tuple.Create(recipe.Id,
                            -productIdsWithoutQueryArgumentsCount + recipeProdictIdsCount * 10));
                }
            }
            recipeMatchRatios.Sort((y, x) => y.Item2.CompareTo(x.Item2));

            return recipeMatchRatios.Select(tuple => tuple.Item1).ToList();

            #endregion
        }

        private static List<int> GetProductsIdsFromRecipe(Recipe recipe)
        {
            return recipe.Ingredients.Select(ingredient => ingredient.Product.Id).ToList();
        }
    }
}