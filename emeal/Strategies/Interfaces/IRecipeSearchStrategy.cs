using System.Collections.Generic;
using emeal.Models;

namespace emeal.Strategies.Interfaces
{
    public interface IRecipeSearchStrategy
    {
        List<int> GetRelevantRecipeIds(IEnumerable<Recipe> recipeList, List<int> queryProductIds);
    }
}