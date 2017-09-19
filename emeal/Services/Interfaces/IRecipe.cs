using System.Collections.Generic;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipe
    {
        /// <exception cref="Exceptions.InvalidRecipeException">Thrown if a new Recipe didn't pass server-side validation.</exception>
        void Add(Recipe recipe);

        /// <exception cref="T:Exceptions.InvalidRecipeIdException">Thrown if the Recipe ID is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">Thrown if there was no Recipe found in the DB.</exception>
        Recipe Find(int? id);

        /// <exception cref="T:Exceptions.InvalidRecipeException">Thrown if the Recipe is null.</exception>
        /// <exception cref="T:Exceptions.InvalidRecipeIdException">Thrown if the Recipe ID is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">Thrown if there was no Recipe found in the DB.</exception>
        void Edit(int id, Recipe recipe);

        /// <exception cref="Exceptions.InvalidRecipeException">Thrown if the Recipe is null.</exception>
        void Remove(Recipe recipe);

        IEnumerable<Recipe> GetSortedRecipes(string searchName, string sortOrder);
    }
}