using System.Data.Entity;
using emeal.Models;
using emeal.Services.Interfaces;

namespace emeal.Services
{
    public class RecipeDb : DbContext, IRecipeDb
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Step> Steps { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}