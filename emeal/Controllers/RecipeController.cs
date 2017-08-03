using System.Linq;
using System.Net;
using System.Web.Mvc;
using emeal.Models;

namespace emeal.Controllers
{
    public class RecipeController : Controller
    {
        internal RecipeDb db = new RecipeDb();

        // GET: CRUD
        public ActionResult Index()
        {
            return View(db.Recipes.ToList());
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var recipe = db.Recipes.Find(id);

            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUD/Create
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

        // GET: CRUD/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Recipe recipe = db.Recipes.Find(id);

            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        // POST: CRUD/Edit/5
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

        // GET: CRUD/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null) return HttpNotFound();

            return View(recipe);
        }

        // POST: CRUD/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Recipe recipe = db.Recipes.Find(id);
                db.Recipes.Remove(recipe);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}