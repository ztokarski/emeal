using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class RecipeFacade : BaseFacade
    {
        private readonly IRecipe _recipeService;

        public RecipeFacade(IRecipe recipeService, IBaseService baseService) : base(baseService)
        {
            _recipeService = recipeService;
        }

        public void Add(Recipe recipe)
        {
            _recipeService.Add(recipe);
        }

        public Recipe Find(int? id)
        {
            return _recipeService.Find(id);
        }

        public void Edit(int id, Recipe editedRecipe)
        {
            _recipeService.Edit(id, editedRecipe);
        }

        public void Remove(Recipe recipe)
        {
            _recipeService.Remove(recipe);
        }

        public IEnumerable<Recipe> GetSortedRecipes(string searchName, string sortOrder)
        {
            return _recipeService.GetSortedRecipes(searchName, sortOrder);
        }
    }
}