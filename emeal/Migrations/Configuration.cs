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
                    DifficultyLevel = Difficulty.Medium,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 20,
                    Popularity = 1,
                    Rating = 3
                },
                new RecipeModel
                {
                    Name = "Kapusniak po slasku",
                    Description = "przepis po dziadku, znaleziony w gara�u. Moje dzieci go nie cierpi�",
                    Author = user2,
                    Ingredients = new List<Ingredient>()
                    {
                        pomidor1,
                        ziemniak1,
                    },
                    Steps = new List<Step>()
                    {
                        step3
                    },
                    PathToImage = "path to main image",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 50,
                    Popularity = 3,
                    Rating = 4
                }
            );

            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Zupa pomidorowa",
                    Description = "przepis po dziadku, znaleziony w mokrej piwnicy.",
                    Author = new User { Name = "Przemek" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "pomidor",
                                PathToImage = "path to image..."
                            },
                            Amount = "4",
                            UnitType = Unit.szt
                        },
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "wywar z rosolu",
                                PathToImage = "path to image..."
                            },
                            Amount = "400",
                            UnitType = Unit.ml
                        },
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "makaron",
                                PathToImage = "path to image..."
                            },
                            Amount = "200",
                            UnitType = Unit.g
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
                        },
                        new Step
                        {
                            Name = "Krok 2",
                            Order = 2,
                            PathToImage = "path to image",
                            Timer = 30,
                        }
                    },
                    PathToImage = "path to main image",
                    DifficultyLevel = Difficulty.Medium,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 80,
                    Popularity = 15,
                    Rating = 5
                }
            );

            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Kotlet schabowy",
                    Description = "Tradycyjny kotlet.",
                    Author = new User { Name = "Marysia" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "Jajka",
                                PathToImage = "path to image..."
                            },
                            Amount = "2",
                            UnitType = Unit.szt
                        },
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "Maka",
                                PathToImage = "path to image..."
                            },
                            Amount = "200",
                            UnitType = Unit.g
                        },
                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "Olej rzepakowy",
                                PathToImage = "path to image..."
                            },
                            Amount = "100",
                            UnitType = Unit.ml
                        },

                        new Ingredient
                        {
                            Product = new Product
                            {
                                Name = "Schab bez kosci",
                                PathToImage = "path to image..."
                            },
                            Amount = "500",
                            UnitType = Unit.g
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
                        },
                        new Step
                        {
                            Name = "Krok 2",
                            Order = 2,
                            PathToImage = "path to image",
                            Timer = 30,
                        },
                        new Step
                        {
                            Name = "Krok 3",
                            Order = 3,
                            PathToImage = "path to image",
                            Timer = 70,
                        }
                    },
                    PathToImage = "path to main image",
                    DifficultyLevel = Difficulty.Hard,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 100,
                    Popularity = 100,
                    Rating = 5
                }
            );
        }
    }
}