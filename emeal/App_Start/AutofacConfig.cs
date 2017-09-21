using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using emeal.Controllers.Facades;
using emeal.Services;
using emeal.Services.Interfaces;
using emeal.Strategies;
using emeal.Strategies.Interfaces;

namespace emeal
{
    public static class AutofacConfig
    {
        internal static IDependencyResolver GetDependencyResolver()
        {
            var contBuilder = new ContainerBuilder();

            contBuilder.RegisterControllers(typeof(MvcApplication).Assembly);

            contBuilder.RegisterType<BaseService>().As<IBaseService>();
            contBuilder.RegisterType<RecipeFinderService>().As<IRecipeFinder>();
            contBuilder.RegisterType<RecipeService>().As<IRecipe>();

            contBuilder.RegisterType<MsqlRecipeDb>().As<IRecipeDb>();

            contBuilder.RegisterType<RecipeSearchStrategy>().As<IRecipeSearchStrategy>();

            contBuilder.RegisterType<BaseFacade>().As<BaseFacade>();
            contBuilder.RegisterType<IngredientFacade>().As<IngredientFacade>();
            contBuilder.RegisterType<RecipeFacade>().As<RecipeFacade>();

            return new AutofacDependencyResolver(contBuilder.Build());
        }
    }
}