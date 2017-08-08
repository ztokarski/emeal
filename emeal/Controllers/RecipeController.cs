using System.Linq;
using System.Net;
using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeDb _db = new RecipeDb();

        [HttpGet]
        public ActionResult Index()
        {
            return View(_db.Recipes.ToList());
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var recipe = _db.Recipes.Find(id);

            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var recipe = _db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var recipe = _db.Recipes.Find(id);
            if (recipe == null) return HttpNotFound();

            return View(recipe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var recipe = _db.Recipes.Find(id);
                if (recipe != null)
                {
                    _db.Recipes.Remove(recipe);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}