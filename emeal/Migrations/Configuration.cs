using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using emeal.Models;

namespace emeal.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RecipeDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RecipeDb context)
        {
            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Pierogi babci Ani",
                    Description = "przepis po babci, znaleziony na strychu. Moje dzieci go uwielbiają",
                    Author = new User {Name = "Stanislaw"},
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "pomidor",
                                PathToImage = "path to image..."
                            },
                            Amount = "2",
                            UnitType = Unit.szt
                        }
                    },
                    Steps = new List<Step>
                    {
                        new Step
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
        }
    }
}