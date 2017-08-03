using emeal.Models;
using System.Collections.Generic;
using System.Net;
using RecipeModel = emeal.Models.Recipe;

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
            Product pomidor = new Product()
            {
                Name = "pomidor",
                PathToImage = "path to pomidor's image"
            };
            Product ziemniak = new Product()
            {
                Name = "ziemniak",
                PathToImage = "path to ziemniak's image"
            };
            Product cebula = new Product()
            {
                Name = "cebula",
                PathToImage = "path to cebula's image"
            };
            Product marchew = new Product()
            {
                Name = "marchew",
                PathToImage = "path to marchew's image"
            };

            Ingredient pomidor1 = new Ingredient()
            {
                Product = pomidor,
                Amount = 1,
                UnitType = Unit.szt
            };
            Ingredient ziemniak1 = new Ingredient()
            {
                Product = ziemniak,
                Amount = 1,
                UnitType = Unit.kg
            };
            Ingredient cebula1 = new Ingredient()
            {
                Product = cebula,
                Amount = 1,
                UnitType = Unit.szt
            };
            Ingredient marchew1 = new Ingredient()
            {
                Product = marchew,
                Amount = 1,
                UnitType = Unit.kg
            };
            Step step1 = new Step()
            {
                Name = "Krok 1 - Umyj produkty",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Order = 1,
                PathToImage = "path to image",
                Timer = 20,
            };
            Step step2 = new Step()
            {
                Name = "Krok 2 - Ugotuj w garnku",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Order = 2,
                PathToImage = "path to image",
                Timer = 20,
            };
            Step step3 = new Step()
            {
                Name = "Krok 3 - Pozmywaj",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Order = 3,
                PathToImage = "path to image",
                Timer = 20,
            };
//            User user1 = new User()
//            {
//                Name = "Stanis³aw",
//                PathToImage = "path to Stanis³aw's image"
//            };
//            User user2 = new User()
//            {
//                Name = "Claudia",
//                PathToImage = "path to Claudia's image"
//            };

            context.Recipes.AddOrUpdate(p => p.Name,
                new RecipeModel
                {
                    Name = "Pierogi babci Ani",
                    Description = "przepis po babci, znaleziony na strychu. Moje dzieci go uwielbiaj¹",
                    Author = new User()
                    {
                        Name = "Piotr",
                        PathToImage = "path to Stanis³aw's image"
                    },

                    Ingredients = new List<Ingredient>()
                    {
                        marchew1,
                        cebula1
                    },
                    Steps = new List<Step>()
                    {
                        step1,
                        step2
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
                    Name = "Kapuœniak po œl¹sku",
                    Description = "przepis po dziadku, znaleziony w gara¿u. Moje dzieci go nie cierpi¹",
                    Author = new User()
                    {
                        Name = "Anna",
                        PathToImage = "path to Anna's image"
                    },
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
                });
//                new RecipeModel
//                {
//                    Name = "Babeczki z ¿urawin¹",
//                    Description = "przepis w³asny, testowany na zwierzêtach domowych",
//                    Author = user2,
//                    Ingredients = new List<Ingredient>()
//                    {
//                        pomidor1, cebula1, marchew1
//                    },
//                    Steps = new List<Step>()
//                    {
//                        step1, step3
//                    },
//                    PathToImage = "path to main image",
//                    DifficultyLevel = Difficulty.Hard,
//                    WhenAdded = DateTime.Today,
//                    EstimatedTime = 100,
//                    Popularity = 5,
//                    Rating = 5
//                },
//                new RecipeModel
//                {
//                    Name = "Cukinie zasma¿ane z cebul¹",
//                    Description = "pychotki",
//                    Author = user2,
//                    Ingredients = new List<Ingredient>()
//                    {
//                        cebula1
//                    },
//                    Steps = new List<Step>()
//                    {
//                        step1, step2, step3
//                    },
//                    PathToImage = "path to main image",
//                    DifficultyLevel = Difficulty.Easy,
//                    WhenAdded = DateTime.Today,
//                    EstimatedTime = 20,
//                    Popularity = 1,
//                    Rating = 3
//                },
//                new RecipeModel
//                {
//                    Name = "Naleœniki z d¿emem",
//                    Description = "przygotowuj je bardzo despacito, wtedy s¹ najlepsze. Buziaczki <3",
//                    Author = user2,
//                    Ingredients = new List<Ingredient>()
//                    {
//                        pomidor1
//                    },
//                    Steps = new List<Step>()
//                    {
//                        step1, step2, step3
//                    },
//                    PathToImage = "path to main image",
//                    DifficultyLevel = Difficulty.Easy,
//                    WhenAdded = DateTime.Today,
//                    EstimatedTime = 500,
//                    Popularity = 5,
//                    Rating = 4
//                },
//                new RecipeModel
//                {
//                    Name = "Kanapki z szynk¹",
//                    Description = "nigdy nie testowa³em, ale powinno dzia³aæ",
//                    Author = user1,
//                    Ingredients = new List<Ingredient>()
//                    {
//                        pomidor1, marchew1
//                    },
//                    Steps = new List<Step>()
//                    {
//                        step1, step3
//                    },
//                    PathToImage = "path to main image",
//                    DifficultyLevel = Difficulty.Medium,
//                    WhenAdded = DateTime.Today,
//                    EstimatedTime = 100,
//                    Popularity = 1,
//                    Rating = 1
//                }
//            );
//            //  This method will be called after migrating to the latest version.
//
//            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
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