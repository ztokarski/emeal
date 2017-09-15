using System.Data.Entity;

namespace emeal.Models
{
    public class RecipeDb : DbContext, IRecipeDb
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Step> Steps { get; set; }
    }
}