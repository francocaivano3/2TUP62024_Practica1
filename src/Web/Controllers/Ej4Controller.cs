using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej4Controller : Controller
    {
        // GET: Ej4Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ej4Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ej4Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ej4Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ej4Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ej4Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ej4Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ej4Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
