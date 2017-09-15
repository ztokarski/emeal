using System;
using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    public class RecipeFinderService : IRecipeFinder
    {
        public List<int> FindRelevantRecipes(IEnumerable<Recipe> allRecipes, List<int> queryArr)
        {
            var recipeCoefficient = new List<Tuple<int, int>>(); // (recipeID, matchCoefficient)
            var result = new List<int>(); // Coefficient: 0 bestMatch, 1 oneRedundantIngredient, -1 oneMissingIngredient
            var maxProductNumberDifference = 5;

            foreach (var recipe in allRecipes)
            {
                var productsIds = GetProductsIdsFromRecipe(recipe);

                var exceptQueryRecipe = queryArr.Except(productsIds).ToList().Count;
                var exceptRecipeQuery = productsIds.Except(queryArr).ToList().Count;

                var queryLen = queryArr.Count;
                var recipeLen = productsIds.Count;

                if (Math.Abs(queryLen - recipeLen) <= maxProductNumberDifference)
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
            recipeCoefficient.Sort((y, x) => Math.Abs(y.Item2).CompareTo(Math.Abs(x.Item2)));

            foreach (var tuple in recipeCoefficient) result.Add(tuple.Item1);

            return result;
        }

        public List<int> GetProductsIdsFromRecipe(Recipe recipe)
        {
            var productsIdsInRecipe = new List<int>();
            foreach (var ingredient in recipe.Ingredients)
                productsIdsInRecipe.Add(ingredient.Product.Id);

            return productsIdsInRecipe;
        }
    }
}