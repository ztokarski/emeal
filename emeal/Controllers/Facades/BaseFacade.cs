using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    public abstract class BaseFacade
    {
        private readonly IBaseService _baseService;

        protected BaseFacade(IBaseService baseService)
        {
            _baseService = baseService;
        }

        internal IEnumerable<Recipe> GetAllRecipes()
        {
            return _baseService.GetAllRecipes();
        }

        internal IEnumerable<Product> GetAllProducts()
        {
            return _baseService.GetAllProducts();
        }
    }
}