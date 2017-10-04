using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipeFinder
    {
        IList<int> FindRelevantRecipesIds(List<int> queryArr, List<int> queryAllergies);
        IEnumerable<Recipe> GetQueryResult(List<int> queryArr, List<int> queryAllergies);
    }
}
