using emeal.Models;
using emeal.Strategies;
using NUnit.Framework;
using TddEbook.TddToolkit;

namespace emeal.Tests.StrategyTests
{
    internal class RecipeSearchStrategyTests
    {
        private RecipeSearchStrategy _recipeSearchStrategy;

        [SetUp]
        public void Setup()
        {
            _recipeSearchStrategy = new RecipeSearchStrategy();
        }

        [Test]
        public void StrategyReturnsEmptyListIfNullsPassed()
        {
            //Arrange
            var mockedRecipeList = Any.List<Recipe>(0);
            //Act
            var actionResult = _recipeSearchStrategy.GetRelevantRecipeIds(mockedRecipeList, null, null);
            //Assert
            Assert.That(actionResult.Count == 0);
        }
    }
}
