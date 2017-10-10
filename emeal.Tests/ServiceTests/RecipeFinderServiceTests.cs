using System.Collections.Generic;
using emeal.Models;
using emeal.Services.Interfaces;
using emeal.Strategies.Interfaces;
using Moq;
using NUnit.Framework;

namespace emeal.Tests.ServiceTests
{
    [TestFixture]
    internal class RecipeFinderServiceTests
    {
        private Mock<IRecipeDb> _mockedDb;
        private Mock<IRecipeSearchStrategy> _mockedStrategy;
        private Mock<IRecipeFinder> _finderService;

        [SetUp]
        public void Setup()
        {
            _mockedDb = new Mock<IRecipeDb>();
            _mockedStrategy = new Mock<IRecipeSearchStrategy>();
            _finderService = new Mock<IRecipeFinder>();
        }

        [Test]
        public void FindRelevantRecipeIdsReturnsEmptyList()
        {
            _finderService.Setup(srv => srv.FindRelevantRecipesIds(It.IsAny<List<int>>(), It.IsAny<List<int>>()))
                .Returns(new List<int>());

            _finderService.Verify();
        }

        [Test]
        public void GetsQueryResult()
        {
            _finderService.Setup(srv => srv.GetQueryResult(It.IsAny<List<int>>(), It.IsAny<List<int>>()))
                .Returns(new List<Recipe>());

            _finderService.Verify();
        }
    }
}