using emeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emeal.Services
{
    public interface IRecipeFinder
    {
        List<int> FindRelevantRecipes(List<Recipe> allRecipes, List<int> queryArr);
        List<int> GetProductsIdsFromRecipe(Recipe recipe);
    }
}
