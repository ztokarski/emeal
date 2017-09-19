using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipe
    {
        void Add(Recipe recipe);
        Recipe Find(int? id);
        void Edit(Recipe recipe);
        void Remove(Recipe recipe);
        IEnumerable<Recipe> GetIndex(string searchName, string sortOrder);
    }
}