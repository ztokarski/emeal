using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipeFinder
    {
        List<int> FindRelevantRecipes(IEnumerable<Recipe> allRecipes, List<int> queryArr);
        List<int> GetProductsIdsFromRecipe(Recipe recipe);
    }
}
