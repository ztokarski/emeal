using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipeFinder
    {
        List<int> FindRelevantRecipes(IEnumerable<Recipe> recipeList, List<int> queryArr, int maxProductNumberDifference);
        List<int> GetProductsIdsFromRecipe(Recipe recipe);
    }
}
