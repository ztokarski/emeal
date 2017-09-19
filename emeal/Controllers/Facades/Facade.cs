using System.Collections.Generic;
using System.Linq;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Controllers.Facades
{
    public class Facade
    {
        protected readonly IMainService MainService;

        protected Facade(IMainService mainService)
        {
            MainService = mainService;
        }

        protected IEnumerable<Recipe> GetAllRecipes()
        {
            return MainService.GetAllRecipes();
        }

        protected IEnumerable<Product> GetAllProducts()
        {
            return MainService.GetAllProducts();
        }
    }
}