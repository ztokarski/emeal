using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emeal.Models;
using emeal.Services;
using emeal.Services.Interfaces;
using emeal.Strategies;
using emeal.Strategies.Interfaces;
using Moq;
using NUnit.Framework;

namespace emeal.Tests.ServiceTests
{
    [TestFixture]
    internal class BaseServiceTests
    {
        [SetUp]
        public void Setup()
        {
            _mockedDb = new Mock<IRecipeDb>();
            _baseService = new RecipeService(_mockedDb.Object);
        }
        
        private Mock<IRecipeDb> _mockedDb;
        private BaseService _baseService;
        
        [Test]
        public void DoesGetAllRecipesReturnsProperDataType()
        {
            //Arrange
            var expectedResultType = typeof(IEnumerable<Recipe>);
            var mockedRecipe = new Mock<Recipe>();
            var mockedDbSet = new Mock<DbSet<Recipe>>();

            var mockedRecipeList = new List<Recipe> {mockedRecipe.Object}.AsQueryable();
            mockedDbSet.As<IQueryable<Recipe>>().Setup(m => m.Provider).Returns(mockedRecipeList.Provider);
            mockedDbSet.As<IQueryable<Recipe>>().Setup(m => m.Expression).Returns(mockedRecipeList.Expression);
            mockedDbSet.As<IQueryable<Recipe>>().Setup(m => m.ElementType).Returns(mockedRecipeList.ElementType);
            mockedDbSet.As<IQueryable<Recipe>>().Setup(m => m.GetEnumerator()).Returns(mockedRecipeList.GetEnumerator);

            _mockedDb.Setup(x => x.Recipes).Returns(mockedDbSet.Object);

            //Act
            var actionResult = _baseService.GetAllRecipes();

            //Assert
            _mockedDb.Verify(x => x.Recipes, Times.Once);
            Assert.That(actionResult.Count().Equals(1));
            Assert.IsInstanceOf(expectedResultType, actionResult);
        }

        [Test]
        public void DoesGetAllProductsReturnsProperDataType()
        {
            //Arrange
            var expectedResultType = typeof(IEnumerable<Product>);
            var mockedProduct = new Mock<Product>();
            var mockedDbSet = new Mock<DbSet<Product>>();

            var mockedRecipeList = new List<Product> { mockedProduct.Object }.AsQueryable();
            mockedDbSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(mockedRecipeList.Provider);
            mockedDbSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(mockedRecipeList.Expression);
            mockedDbSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(mockedRecipeList.ElementType);
            mockedDbSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(mockedRecipeList.GetEnumerator);

            _mockedDb.Setup(x => x.Products).Returns(mockedDbSet.Object);

            //Act
            var actionResult = _baseService.GetAllProducts();

            //Assert
            _mockedDb.Verify(x => x.Products, Times.Once);
            Assert.That(actionResult.Count().Equals(1));
            Assert.IsInstanceOf(expectedResultType, actionResult);
        }


    }
}
