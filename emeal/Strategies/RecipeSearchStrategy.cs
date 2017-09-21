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

        public List<int> GetRelevantRecipeIds(IEnumerable<Recipe> recipeList, List<int> queryArr)
        {
            // TODO: Untangle this unholy mess

            #region algorithm

            //                                  (recipeID, matchCoefficient)
            var recipeCoefficient = new List<Tuple<int, int>>();

            foreach (var recipe in recipeList)
            {
                var productsIds = GetProductsIdsFromRecipe(recipe);

                var exceptQueryRecipe = queryArr.Except(productsIds).ToList().Count;
                var exceptRecipeQuery = productsIds.Except(queryArr).ToList().Count;

                var queryLen = queryArr.Count;
                var recipeLen = productsIds.Count;

                var currentProductNumberDifference = queryLen - recipeLen;

                if (currentProductNumberDifference <= MaxProductNumberDifference)
                {
                    if (exceptQueryRecipe == queryLen) continue;
                    else if (exceptQueryRecipe >= 0 && exceptRecipeQuery > 0)
                        recipeCoefficient.Add(Tuple.Create(recipe.Id, -exceptRecipeQuery + recipeLen * 10));
                    else if (exceptQueryRecipe >= 0 && queryLen >= recipeLen)
                        recipeCoefficient.Add(Tuple.Create(recipe.Id, exceptQueryRecipe));
                    else if (exceptQueryRecipe == 0 && queryLen < recipeLen)
                        recipeCoefficient.Add(Tuple.Create(recipe.Id, -exceptRecipeQuery + recipeLen * 10));
                    else
                        recipeCoefficient.Add(Tuple.Create(recipe.Id, -exceptRecipeQuery + recipeLen * 10));
                }
            }
            recipeCoefficient.Sort((y, x) => y.Item2.CompareTo(x.Item2));

            return recipeCoefficient.Select(tuple => tuple.Item1).ToList();

            #endregion
        }

        public List<int> GetProductsIdsFromRecipe(Recipe recipe)
        {
            return recipe.Ingredients.Select(ingredient => ingredient.Product.Id).ToList();
        }
    }
}