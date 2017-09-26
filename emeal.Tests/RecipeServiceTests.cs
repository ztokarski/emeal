using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emeal.Exceptions;
using emeal.Models;
using emeal.Services;
using emeal.Services.Interfaces;
using emeal.Strategies.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Assert = NUnit.Framework.Assert;

namespace emeal.Tests
{
    // SUT - Service Under Test

    //Arrange
    //Act
    //Assert
    [TestFixture]
    class RecipeServiceTests
    {
        private Mock<IRecipeDb> _mockedDb;
        private RecipeService _recipeService;

        [SetUp]
        public void Setup()
        {
            _mockedDb = new Mock<IRecipeDb>();
            _recipeService = new RecipeService(_mockedDb.Object);
        }


        //Testing ADD method
        [Test]
        public void DoesAddMethodSaveChanges()
        {
            //Arrange
            _mockedDb.Setup(x => x.Recipes.Add(It.IsAny<Recipe>()));
            _mockedDb.Setup(x => x.SaveChanges());
           
            //Act
            var mockedRecipe = new Mock<Recipe>();
            _recipeService.Add(mockedRecipe.Object);

            //Assert
            _mockedDb.Verify(x => x.Recipes.Add(It.IsAny<Recipe>()), Times.Once);
            _mockedDb.Verify(x => x.SaveChanges(), Times.Once);        
        }

        [Test]
        public void DoesSutThrowsExceptionWhenRecipeIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Add(null));
        }

        [Test]
        public void DoesFindMethodUsesEntityFind()
        {
            //Arrange
            _mockedDb.Setup(x => x.Recipes.Find(It.IsAny<int>()));

            //Act
            _recipeService.Find(It.IsAny<int>());

            //Assert
            _mockedDb.Verify(x => x.Recipes.Find(It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void DoesSutThrowsExceptionWhenFindParameterIsNull()
        {
            //Arrange
            var expectedExceptionType = new InvalidRecipeIdException().GetType();

            //Assert
            Assert.Throws(expectedExceptionType, () => _recipeService.Find(null));
        }
    }
}
