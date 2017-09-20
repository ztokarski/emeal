using System;
using System.Collections.Generic;
using emeal.Models;
using NUnit.Framework;

namespace emeal.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        [SetUp]
        public void Init() => CreateTestRecipe();

        private User _testAuthor;
        private Product _testProduct1;
        private Product _testProduct2;
        private Ingredient _testIngredient1;
        private Ingredient _testIngredient2;
        private Step _testStep1;
        private Step _testStep2;
        private Recipe _testRecipe;

        private void CreateTestRecipe()
        {
            _testAuthor = new User {Id = 1, Name = "John", PathToImage = "myPath"};

            _testProduct1 = new Product {Id = 1, Name = "Tomato", PathToImage = "myProductPath"};
            _testProduct2 = new Product {Id = 2, Name = "Onion", PathToImage = "myProductPath"};

            _testIngredient1 = new Ingredient {Id = 1, Amount = 42, Product = _testProduct1, UnitType = Unit.szt};
            _testIngredient2 = new Ingredient {Id = 2, Amount = 42, Product = _testProduct2, UnitType = Unit.g};

            _testStep1 = new Step
            {
                Id = 1,
                Name = "Cut the onion",
                PathToImage = "myPathOnion",
                Timer = 30,
                Order = 1
            };

            _testStep2 = new Step
            {
                Id = 2,
                Name = "Slice the tomato",
                PathToImage = "myPathTomato",
                Timer = 60,
                Order = 2
            };

            _testRecipe = new Recipe
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


            _testRecipe.Ingredients.Add(_testIngredient1);
            _testRecipe.Ingredients.Add(_testIngredient2);

            _testRecipe.Steps.Add(_testStep1);
            _testRecipe.Steps.Add(_testStep2);
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

            Assert.AreEqual(expectedRecipeId, _testRecipe.Id);
            Assert.AreEqual(expectedName, _testRecipe.Name);
            Assert.AreEqual(expectedDescription, _testRecipe.Description);
            Assert.AreEqual(expectedPathToImage, _testRecipe.PathToImage);
            Assert.AreEqual(expectedDifficulty, _testRecipe.DifficultyLevel);
            Assert.AreEqual(expectedDate, _testRecipe.WhenAdded);
            Assert.AreEqual(expectedEstimatedTime, _testRecipe.EstimatedTime);
            Assert.AreEqual(expectedPopularity, _testRecipe.Popularity);
            Assert.AreEqual(expectedRating, _testRecipe.Rating);
        }

        [Test]
        public void AuthorFieldTests()
        {
            Assert.AreEqual(_testAuthor, _testRecipe.Author);
            Assert.AreEqual(_testAuthor.Id, _testRecipe.Author.Id);
            Assert.AreEqual(_testAuthor.Name, _testRecipe.Author.Name);
            Assert.AreEqual(_testAuthor.PathToImage, _testRecipe.Author.PathToImage);
        }

        [Test]
        public void ProductFieldTests()
        {
            const int expectedId = 1;
            const string expectedName = "Tomato";
            const string expectedPathToImage = "myProductPath";

            Assert.AreEqual(expectedId, _testProduct1.Id);
            Assert.AreEqual(expectedName, _testProduct1.Name);
            Assert.AreEqual(expectedPathToImage, _testProduct1.PathToImage);
        }

        [Test]
        public void IngredientFieldTests()
        {
            const int expectedId = 1;
            const double expectedAmount = 42;
            var expectedProduct = _testProduct1;
            const Unit expectedUnitType = Unit.szt;
            _testIngredient1 = new Ingredient
            {
                Id = expectedId,
                Amount = expectedAmount,
                Product = _testProduct1,
                UnitType = expectedUnitType
            };


            Assert.AreEqual(expectedId, _testIngredient1.Id);
            Assert.AreEqual(expectedAmount, _testIngredient1.Amount);
            Assert.AreEqual(expectedProduct, _testIngredient1.Product);
            Assert.AreEqual(expectedUnitType, _testIngredient1.UnitType);
        }

        [Test]
        public void StepFieldTest()
        {
            const int expectedId = 1;
            const string expectedName = "Cut the onion";
            const string expectedPathToImage = "myPathOnion";
            const int expectedTimer = 30;
            const int expectedOrder = 1;

            Assert.AreEqual(expectedId, _testStep1.Id);
            Assert.AreEqual(expectedName, _testStep1.Name);
            Assert.AreEqual(expectedPathToImage, _testStep1.PathToImage);
            Assert.AreEqual(expectedTimer, _testStep1.Timer);
            Assert.AreEqual(expectedOrder, _testStep1.Order);
        }
    }
}