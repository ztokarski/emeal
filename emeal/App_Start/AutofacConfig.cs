using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using emeal.Controllers.Facades;
using emeal.Services;
using emeal.Services.Interfaces;

namespace emeal
{
    public class AutofacConfig
    {
        internal static IDependencyResolver GetDependencyResolver()
        {
            var contBuilder = new ContainerBuilder();

            contBuilder.RegisterControllers(typeof(MvcApplication).Assembly);

            contBuilder.RegisterType<RecipeDb>().As<IRecipeDb>();
            contBuilder.RegisterType<RecipeFinderService>().As<IRecipeFinder>();

            contBuilder.RegisterType<Facade>().As<Facade>();
            contBuilder.RegisterType<IngredientFacade>().As<IngredientFacade>();
            contBuilder.RegisterType<RecipeFacade>().As<RecipeFacade>();

            return new AutofacDependencyResolver(contBuilder.Build());
        }
    }
}