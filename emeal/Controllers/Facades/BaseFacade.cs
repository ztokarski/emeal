using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    public class BaseFacade
    {
        protected readonly IBaseService BaseService;

        public BaseFacade(IBaseService baseService)
        {
            BaseService = baseService;
        }

        internal IEnumerable<Recipe> GetAllRecipes()
        {
            return BaseService.GetAllRecipes();
        }

        internal IEnumerable<Product> GetAllProducts()
        {
            return BaseService.GetAllProducts();
        }
    }
}