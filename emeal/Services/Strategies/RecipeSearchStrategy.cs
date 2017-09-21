using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emeal.Models;

namespace emeal.Services.Strategies
{
    internal static class RecipeSearchStrategy
    {
        public static List<int> GetRelevantRecipeIds(List<Recipe> recipeList, List<int> queryArr,
            int maxProductNumberDifference)
        {
            // TODO: Untangle this unholy mess

            #region algorithm

            var recipeCoefficient = new List<Tuple<int, int>>(); // (recipeID, matchCoefficient)

            var result = new List<int>(); // Coefficient: 0 bestMatch, 1 oneRedundantIngredient, -1 oneMissingIngredient
            foreach (var recipe in recipeList)
            {
                var productsIds = GetProductsIdsFromRecipe(recipe);

                var exceptQueryRecipe = queryArr.Except(productsIds).ToList().Count;
                var exceptRecipeQuery = productsIds.Except(queryArr).ToList().Count;

                var queryLen = queryArr.Count;
                var recipeLen = productsIds.Count;

                var currentProductNumberDifference = queryLen - recipeLen;

                if (currentProductNumberDifference <= maxProductNumberDifference)
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

                #endregion
            }
            recipeCoefficient.Sort((y, x) => y.Item2.CompareTo(x.Item2));
            foreach (var tuple in recipeCoefficient) result.Add(tuple.Item1);

            return result;
        }

        static List<int> GetProductsIdsFromRecipe(Recipe recipe)
        {
            var productsIdsInRecipe = new List<int>();
            foreach (var ingredient in recipe.Ingredients) productsIdsInRecipe.Add(ingredient.Product.Id);

            return productsIdsInRecipe;
        }
    }
}