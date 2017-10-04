using emeal.Services;
using emeal.Services.Interfaces;
using emeal.Strategies;
using Moq;
using NUnit.Framework;

namespace emeal.Tests.ServiceTests
{
    [TestFixture]
    internal class RecipeFinderServiceTests
    {
        private Mock<IRecipeDb> _mockedDb;
        private Mock<RecipeSearchStrategy> _mockedStrategy;
        private RecipeFinderService _finderService;

        [SetUp]
        public void Setup()
        {
            _mockedDb = new Mock<IRecipeDb>();
            _mockedStrategy = new Mock<RecipeSearchStrategy>();
            _finderService = new RecipeFinderService(_mockedStrategy.Object, _mockedDb.Object);
        }

        [Test]
        public void FindsRelevantRecipeIds()
        {
            _finderService;
        }

        [Test]
        public void GetsQueryResult()
        {
        }

        [Test]
        public void FindsMatchedRecipes()
        {
        }

        [Test]
        public void SortsMatchedRecipes()
        {
        }
    }
}