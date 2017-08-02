using emeal.Models;
using System.Collections.Generic;
using ReceipeModel = emeal.Models.Recipe;

namespace emeal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<emeal.Models.RecipeDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(emeal.Models.RecipeDb context)
        {
       
            context.Recipes.AddOrUpdate(p => p.Name,
                new ReceipeModel
                {
                    Name = "Pierogi babci Ani",
                    Description = "przepis po babci, znaleziony na strychu. Moje dzieci go uwielbiaj¹",
                    Author = new User() { Name = "Stanis³aw"},
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Product = new Product()
                            {
                                Name = "pomidor",
                                PathToImage = "path to image..."
                            },
                            Amount = "2",
                            UnitType = Unit.szt
                        }
                    },
                    Steps = new List<Step>()
                    {
                        new Step()
                        {
                            Name = "Krok 1",
                            Order = 1,
                            PathToImage = "path to image",
                            Timer = 20,
                        }
                    },
                    PathToImage = "path to main image",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 50,
                    Popularity = 3,
                    Rating = 4
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
