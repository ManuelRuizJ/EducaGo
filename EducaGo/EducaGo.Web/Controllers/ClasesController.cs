using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducaGo.Web.Controllers
{
    public class ClasesController : Controller
    {
        // GET: ClasesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClasesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClasesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClasesController/Create
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

        // GET: ClasesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClasesController/Edit/5
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

        // GET: ClasesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClasesController/Delete/5
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
