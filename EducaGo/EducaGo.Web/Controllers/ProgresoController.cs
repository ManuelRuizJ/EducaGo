using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducaGo.Web.Controllers
{
    public class ProgresoController : Controller
    {
        // GET: ProgresoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProgresoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProgresoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgresoController/Create
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

        // GET: ProgresoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProgresoController/Edit/5
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

        // GET: ProgresoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProgresoController/Delete/5
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
