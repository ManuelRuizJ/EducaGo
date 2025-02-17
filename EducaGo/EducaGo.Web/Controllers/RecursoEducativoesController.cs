using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EducaGo.Shared.Entities;
using EducaGo.Web.Data;

namespace EducaGo.Web.Controllers
{
    public class RecursoEducativoesController : Controller
    {
        private readonly DataContext _context;

        public RecursoEducativoesController(DataContext context)
        {
            _context = context;
        }

        // GET: RecursoEducativoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RecursosEducativos.ToListAsync());
        }

        // GET: RecursoEducativoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recursoEducativo = await _context.RecursosEducativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recursoEducativo == null)
            {
                return NotFound();
            }

            return View(recursoEducativo);
        }

        // GET: RecursoEducativoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RecursoEducativoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Ruta,Tipo")] RecursoEducativo recursoEducativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recursoEducativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recursoEducativo);
        }

        // GET: RecursoEducativoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recursoEducativo = await _context.RecursosEducativos.FindAsync(id);
            if (recursoEducativo == null)
            {
                return NotFound();
            }
            return View(recursoEducativo);
        }

        // POST: RecursoEducativoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Ruta,Tipo")] RecursoEducativo recursoEducativo)
        {
            if (id != recursoEducativo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recursoEducativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecursoEducativoExists(recursoEducativo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recursoEducativo);
        }

        // GET: RecursoEducativoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recursoEducativo = await _context.RecursosEducativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recursoEducativo == null)
            {
                return NotFound();
            }

            return View(recursoEducativo);
        }

        // POST: RecursoEducativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recursoEducativo = await _context.RecursosEducativos.FindAsync(id);
            if (recursoEducativo != null)
            {
                _context.RecursosEducativos.Remove(recursoEducativo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecursoEducativoExists(int id)
        {
            return _context.RecursosEducativos.Any(e => e.Id == id);
        }
    }
}
