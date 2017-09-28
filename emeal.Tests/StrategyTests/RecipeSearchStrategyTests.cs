using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emeal.Models;
using emeal.Strategies;
using NUnit.Framework;

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
        public void test()
        {
            //Arrange
            var mockedRecipeList = new List<Recipe>();
            List<int> actionResult;
            //Act
            actionResult = _recipeSearchStrategy.GetRelevantRecipeIds(null, null);
            //Assert
            Assert.That(actionResult.Count == 0);
        }
    }
}
