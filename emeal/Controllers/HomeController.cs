using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["User"] = new User
            {
                Id = 42,
                Name = "DJ Khaled",
                PathToImage = "~/Content/img/djkhaled.png"
            };

            return View();
        }
    }
}