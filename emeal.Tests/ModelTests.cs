using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using emeal.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace emeal.Tests.ModelTests
{

    [TestFixture]
    public class RecipeTests
    {
        [SetUp]
        public void Init()
        {
            CreateTestRecipe();
        }

        private User _testAuthor;
        private Product _testProduct1;
        private Product _testProduct2;
        private Ingredient _testIngredient1;
        private Ingredient _testIngredient2;
        private Step _testStep1;
        private Step _testStep2;

        private Recipe _testRecipe;


        public void CreateTestRecipe()
        {
            this._testAuthor = new User() { Id = 1, Name = "John", PathToImage = "myPath" };

            this._testProduct1 = new Product() { Id = 1, Name = "Tomato", PathToImage = "myProductPath" };
            this._testProduct2 = new Product() { Id = 2, Name = "Onion", PathToImage = "myProductPath" };

            this._testIngredient1 = new Ingredient() { Id = 1, Amount = "Some", Product = this._testProduct1, UnitType = Unit.szt };
            this._testIngredient2 = new Ingredient() { Id = 2, Amount = "A lot", Product = this._testProduct2, UnitType = Unit.g };

            this._testStep1 = new Step()
            {
                Id = 1,
                Name = "Cut the onion",
                PathToImage = "myPathOnion",
                Timer = 30,
                Order = 1
            };

            this._testStep2 = new Step()
            {
                Id = 2,
                Name = "Slice the tomato",
                PathToImage = "myPathTomato",
                Timer = 60,
                Order = 2
            };

            this._testRecipe = new Recipe()
            {
                Id = 1,
                Name = "Soup",
                Description = "Very Good",
                Author = _testAuthor,
                Ingredients = new List<Ingredient>(),
                Steps = new List<Step>(),
                PathToImage = "myPathImage",
                DifficultyLevel = Difficulty.Medium,
                WhenAdded = DateTime.Today,
                EstimatedTime = 15,
                Popularity = 5,
                Rating = 6
            };

            this._testRecipe.Ingredients.Add(this._testIngredient1);
            this._testRecipe.Ingredients.Add(this._testIngredient2);

            this._testRecipe.Steps.Add(this._testStep1);
            this._testRecipe.Steps.Add(this._testStep2);
        }

        [Test]
        public void RecipePlainFieldsTest()
        {
            const int expectedRecipeId = 1;
            const string expectedName = "Soup";
            const string expectedDescription = "Very Good";
            const string expectedPathToImage = "myPathImage";
            const Difficulty expectedDifficulty = Difficulty.Medium;
            var expectedDate = DateTime.Today;
            const int expectedEstimatedTime = 15;
            const int expectedPopularity = 5;
            const int expectedRating = 6;


            Assert.AreEqual(expectedRecipeId, this._testRecipe.Id);
            Assert.AreEqual(expectedName, this._testRecipe.Name);
            Assert.AreEqual(expectedDescription, this._testRecipe.Description);
            Assert.AreEqual(expectedPathToImage, this._testRecipe.PathToImage);
            Assert.AreEqual(expectedDifficulty, this._testRecipe.DifficultyLevel);
            Assert.AreEqual(expectedDate, this._testRecipe.WhenAdded);
            Assert.AreEqual(expectedEstimatedTime, this._testRecipe.EstimatedTime);
            Assert.AreEqual(expectedPopularity, this._testRecipe.Popularity);
            Assert.AreEqual(expectedRating, this._testRecipe.Rating);
        }

        [Test]
        public void AuthorFieldTests()
        {
            Assert.AreEqual(this._testAuthor, this._testRecipe.Author);
            Assert.AreEqual(this._testAuthor.Id, this._testRecipe.Author.Id);
            Assert.AreEqual(this._testAuthor.Name, this._testRecipe.Author.Name);
            Assert.AreEqual(this._testAuthor.PathToImage, this._testRecipe.Author.PathToImage);
        }

        [Test]
        public void ProductFieldTests()
        {
            const int expectedId = 1;
            const string expectedName = "Tomato";
            const string expectedPathToImage = "myProductPath";

            Assert.AreEqual(expectedId, this._testProduct1.Id);
            Assert.AreEqual(expectedName, this._testProduct1.Name);
            Assert.AreEqual(expectedPathToImage, this._testProduct1.PathToImage);
        }

        [Test]
        public void IngredientFieldTests()
        {
            this._testIngredient1 = new Ingredient() { Id = 1, Amount = "Some", Product = this._testProduct1, UnitType = Unit.szt };
            const int expectedId = 1;
            const string expectedAmount = "Some";
            var expectedProduct = this._testProduct1;
            const Unit expectedUnityType = Unit.szt;

            Assert.AreEqual(expectedId, this._testIngredient1.Id);
            Assert.AreEqual(expectedAmount, this._testIngredient1.Amount);
            Assert.AreEqual(expectedProduct, this._testIngredient1.Product);
            Assert.AreEqual(expectedUnityType, this._testIngredient1.UnitType);
        }

        [Test]
        public void StepFieldTest()
        {
            const int expectedId = 1;
            const string expectedName = "Cut the onion";
            const string expectedPathToImage = "myPathOnion";
            const int expectedTimer = 30;
            const int expectedOrder = 1;

            Assert.AreEqual(expectedId, this._testStep1.Id);
            Assert.AreEqual(expectedName, this._testStep1.Name);
            Assert.AreEqual(expectedPathToImage, this._testStep1.PathToImage);
            Assert.AreEqual(expectedTimer, this._testStep1.Timer);
            Assert.AreEqual(expectedOrder, this._testStep1.Order);
        }

    }
}
