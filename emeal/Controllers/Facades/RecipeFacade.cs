using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using emeal.Models;
using emeal.Models.Utils;
using emeal.Services;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
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

        public void Edit(Recipe recipe)
        {
            _recipeService.Edit(recipe);
        }


        public void Remove(Recipe recipe)
        {
            _recipeService.Remove(recipe);
        }

        public IEnumerable<Recipe> GetIndex(string searchName, string sortOrder)
        {
            return _recipeService.GetIndex(searchName, sortOrder);
        }

    }
}