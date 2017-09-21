using System.Web.Mvc;

namespace emeal.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}