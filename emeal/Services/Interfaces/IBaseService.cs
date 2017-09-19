using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IBaseService
    {
        IEnumerable<Recipe> GetAllRecipes();
        IEnumerable<Product> GetAllProducts();
    }
}