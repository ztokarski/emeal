using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipeFinder
    {
        List<int> FindRelevantRecipesIds(List<int> queryArr, List<int>queryAllergies);
        List<Recipe> GetQueryResult(List<int> queryArr, List<int>queryAllergies);
    }
}
