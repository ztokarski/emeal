using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using emeal.Controllers.Facades;
using emeal.Models;
using emeal.Services;
using emeal.Services.Interfaces;

namespace emeal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var contBuilder = new ContainerBuilder();

            contBuilder.RegisterControllers(typeof(MvcApplication).Assembly);

            contBuilder.RegisterType<RecipeDb>().As<IRecipeDb>();
            contBuilder.RegisterType<RecipeFinderService>().As<IRecipeFinder>();

            contBuilder.RegisterType<Facade>().As<Facade>();
            contBuilder.RegisterType<IngredientFacade>().As<IngredientFacade>();
            contBuilder.RegisterType<RecipeFacade>().As<RecipeFacade>();

            var autofacDependencyResolver = new AutofacDependencyResolver(contBuilder.Build());

            DependencyResolver.SetResolver(autofacDependencyResolver);
        }
    }
}