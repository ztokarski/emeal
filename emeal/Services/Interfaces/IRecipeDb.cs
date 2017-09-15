using emeal.Models;
using System.Data.Entity;

namespace emeal
{
    public interface IRecipeDb
    {
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Step> Steps { get; set; }
        DbSet<User> Users { get; set; }
    }
}