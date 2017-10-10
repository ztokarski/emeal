using System.Collections.Generic;
using emeal.Exceptions;
using emeal.Models;
using emeal.Services;
using emeal.Services.Interfaces;
using Moq;
using NUnit.Framework;

namespace emeal.Tests.ServiceTests
{
    //SUT - System Under Test
    //Arrange
    //Act
    //Assert

     // Todo: Write tests for: Edit(), GetSortedRecipes()

    [TestFixture]
    internal class RecipeServiceTests
    {
        [SetUp]
        public void Setup()
        {
            _mockedDb = new Mock<IRecipeDb>();
            _recipeService = new RecipeService(_mockedDb.Object);
        }

        private Mock<IRecipeDb> _mockedDb;
        private RecipeService _recipeService;

        [Test]
        public void DoesAddMethodSaveChanges()
        {
            //Arrange
            var mockedRecipe = new Mock<Recipe>();
            _mockedDb.Setup(x => x.Recipes.Add(It.IsAny<Recipe>()));
            _mockedDb.Setup(x => x.SaveChanges());

            //Act
            _recipeService.Add(mockedRecipe.Object);

            //Assert
            _mockedDb.Verify(x => x.Recipes.Add(It.IsAny<Recipe>()), Times.Once);
            _mockedDb.Verify(x => x.SaveChanges(), Times.Once);
        }

        [Test]
        public void DoesFindMethodReturnsProperDataType()
        {
            //Arrange
            _mockedDb.Setup(x => x.Recipes.Find(It.IsAny<int>())).Returns(new Recipe());

            //Act
            var foundRecipe = _recipeService.Find(It.IsAny<int>());

            //Assert
            Assert.That(foundRecipe, Is.TypeOf<Recipe>());
        }

        [Test]
        public void DoesFindMethodUsesEntityFind()
        {
            //Arrange
            _mockedDb.Setup(x => x.Recipes.Find(It.IsAny<int>())).Returns(new Recipe());

            //Act
            _recipeService.Find(It.IsAny<int>());

            //Assert
            _mockedDb.Verify(x => x.Recipes.Find(It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void DoesSUTThrowsExceptionWhenFindParameterIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeIdException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Find(null));
        }

        [Test]
        public void DoesSUTThrowsExceptionWhenAddedRecipeIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Add(null));
        }

        [Test]
        public void DoesSUTThrowsExceptionWhenEdittedRecipeIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Edit(It.IsAny<int>(), null));
        }

        [Test]
        public void DoesRemoveMethodRemovesOnceAndSavesChanges()
        {
            //Arrange
            var mockedRecipe = new Mock<Recipe>();
            _mockedDb.Setup(x => x.Steps.RemoveRange(It.IsAny<IEnumerable<Step>>()));
            _mockedDb.Setup(x => x.Ingredients.RemoveRange(It.IsAny<IEnumerable<Ingredient>>()));
            _mockedDb.Setup(x => x.Recipes.Remove(It.IsAny<Recipe>()));
            _mockedDb.Setup(x => x.SaveChanges());

            //Act
            _recipeService.Remove(mockedRecipe.Object);

            //Assert
            _mockedDb.Verify(x => x.Steps.RemoveRange((It.IsAny<IEnumerable<Step>>())), Times.Once);
            _mockedDb.Verify(x => x.Ingredients.RemoveRange((It.IsAny<IEnumerable<Ingredient>>())), Times.Once);
            _mockedDb.Verify(x => x.Recipes.Remove(It.IsAny<Recipe>()), Times.Once);
            _mockedDb.Verify(x => x.SaveChanges(), Times.Once);
        }

        [Test]
        public void DoesSUTThrowsExceptionWhenRemovedRecipeIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Remove(null));
        }
    }
}