using System.Data.Entity;
using emeal.Models;

namespace emeal.Services.Interfaces
{
    public interface IRecipeDb
    {
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Step> Steps { get; set; }
        DbSet<User> Users { get; set; }
        void SaveChanges();
    }
}